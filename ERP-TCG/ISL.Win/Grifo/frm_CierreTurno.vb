Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_CierreTurno
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CierreTurno = Nothing
    Private Shared Operacion As String

    Private dTURNO As New l_CierreTurno
    Private TURNO As New e_CierreTurno
    Private TURNO_DETALLE As New e_CierreTurno_Detalle


    ' Asiento Modelo
    Private REFERENCIA As New e_AsientoModelo_Referencia
    Private LISTA_REFERENCIA As New List(Of e_AsientoModelo_Referencia)

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CierreTurno()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones Principales"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            mt_Listar()
            Operacion = "Inicializa"
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            mt_ControlBotoneria()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griOrdenComercial.Selected.Rows.Count > 0 Then
                mt_Inicializar()
                mt_Mostrar()
                gmt_MostrarTabs(1, ficOrdenComercial, 1)
                Operacion = "Editar"
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_Guardar() Then
                gmt_MostrarTabs(0, ficOrdenComercial, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '    Case Windows.Forms.DialogResult.Yes
            '        Guardar()
            '    Case Windows.Forms.DialogResult.No
            gmt_MostrarTabs(0, ficOrdenComercial, 2)
            Consultar(True)
            'End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'Throw New Exception("No es posible eliminar Ordenes de Venta, solo se permite anular")
            With griOrdenComercial
                TURNO = New e_CierreTurno
                If .Selected.Rows.Count > 0 Then
                    TURNO.Id = .ActiveRow.Cells("Id").Value
                    TURNO = dTURNO.Obtener(TURNO)
                    If TURNO.IdEstado = "1CIX043" Then 'Apertura
                        If MessageBox.Show("Esta seguro de eliminar la Orden: " &
                                 .ActiveRow.Cells("OrdenComercial").Value.ToString & " ?",
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            TURNO.TipoOperacion = "N"
                            TURNO.UsuarioCrea = gUsuarioSGI.Id
                            dTURNO.Eliminar(TURNO)
                            MsgBox("La Informacion ha Sido Eliminada Correctamente", MsgBoxStyle.Information, Me.Text)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Solo Puede Eliminar Ordenes Terminadas")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griOrdenComercial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griOrdenComercial, Me.Text)
            MyBase.Exportar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        'MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Private Sub mt_Inicializar()
        mt_CargarDetalles()
    End Sub

    Private Sub mt_Listar()
        Try
            TURNO = New e_CierreTurno
            With TURNO

                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                If rdbDatosBasicos.Checked Then
                    .IdTrabajador_Apertura = cmb_TrabajadorApertura_Buscado.Value
                    .IdEstado = cmb_EstadoBuscado.Value
                    .Fecha = dtpFechaInicio.Value
                    .FechaCrea = dtpFechaFin.Value
                Else
                    .Id = txtNroOrden.Text
                End If
            End With
            griOrdenComercial.DataSource = dTURNO.Listar(TURNO)
            'mt_CombosGrillaPrincipal(griOrdenComercial)
            For Each fila As UltraGridRow In griOrdenComercial.Rows
                Select Case fila.Cells("Estado").Value
                    Case "ABIERTO"
                        fila.CellAppearance.BackColor = Me.colorEvaluado.Color
                    Case "CERRADO"
                        fila.CellAppearance.BackColor = Me.colorParcial.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDetalles()
        Try
            Dim Detalle As New e_CierreTurno_Detalle With {.Rubro = "TRABAJADORES", .Descripcion = "Trabajador1"} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 3", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 4", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 3", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 4", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "Diesel DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "Gasolina 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "Gasolina 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "Gasolina 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTAS_ANULADAS", .Grupo = "", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CALIBRACIONES", .Grupo = "", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            mt_CargarGrillas()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar()
        Try
            TURNO.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            TURNO = dTURNO.Obtener(TURNO)
            With TURNO
                cmb_Turno.Value = .IdTurno
                dtpFecha.Value = .Fecha
                dtpHoraInicio.Value = .HoraInicio
                dtpHoraFin.Value = .HoraFin
                cmb_Estado.Value = .IdEstado
                cboTrabajadorApertura.Value = .IdTrabajador_Apertura
                cboTrabajadorCierre.Value = .IdTrabajador_Cierre
                txtGlosa.Text = .Glosa
                mt_CargarGrillas()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarGrillas()
        Try
            With TURNO
                udg_Trabajadores.DataSource = .Detalles.Where(Function(it) it.Rubro = "TRABAJADORES").ToList : udg_Trabajadores.DataBind()
                udg_ContometroDigital.DataSource = .Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_DIGITAL").ToList : udg_ContometroDigital.DataBind()
                udg_ContometroAnalogico.DataSource = .Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_MECANICO").ToList : udg_ContometroAnalogico.DataBind()
                udg_VentasxCombustible.DataSource = .Detalles.Where(Function(it) it.Rubro = "VENTASXCOMBUSTIBLE").ToList : udg_VentasxCombustible.DataBind()
                udg_VentasAnuladas.DataSource = .Detalles.Where(Function(it) it.Rubro = "VENTAS_ANULADAS").ToList : udg_VentasAnuladas.DataBind()
                udg_Calibraciones.DataSource = .Detalles.Where(Function(it) it.Rubro = "CALIBRACIONES").ToList : udg_Calibraciones.DataBind()
                udg_Almacenes.DataSource = .Detalles.Where(Function(it) it.Rubro = "ALMACENES").ToList : udg_Almacenes.DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Guardar() As Boolean
        Try
            If Not fc_LlenaObjeto() Then Return False
            TURNO = dTURNO.Guardar(TURNO)
            MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function fc_LlenaObjeto() As Boolean
        Try
            With TURNO
                .Id = ""
                .IdEmpresaSis = gs_IdEmpresaSistema
                .IdSucursal = ""
                .IdTurno = cmb_Turno.Value
                .Turno = cmb_Turno.Text
                .IdEstado = cmb_Estado.Value
                .Estado = cmb_Estado.Text
                .Fecha = dtpFecha.Value
                .HoraInicio = dtpHoraInicio.Value
                .HoraFin = dtpHoraFin.Value
                .IdTrabajador_Apertura = ""
                .Trabajador_Apertura = ""
                .IdTrabajador_Cierre = ""
                .Trabajador_Cierre = ""
                .Glosa = ""
                .UsuarioCrea = ""
                .FechaCrea = #01/01/1901#
                .UsuarioModifica = ""
                .FechaModifica = #01/01/1901#
                .Activo = True
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Metodos"

    Private Sub mt_ControlBotoneria()
        Select Case ficOrdenComercial.SelectedTab.Index
            Case 0
                If griOrdenComercial.Rows.Count > 0 Then
                    gmt_ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                Else
                    gmt_ControlBoton(1, 1)
                End If
            Case 1
                If TURNO.Estado = "GENERADO" Or TURNO.Estado = "" Then
                    gmt_ControlBoton(0, 0, 0, 1, 1)
                Else
                    gmt_ControlBoton(0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub mt_CargarCombos()
        Try
            Dim olCombo As New l_Combo : Dim oeCombo As New e_Combo

            ' Turno
            gmt_ComboEspecifico(cmb_TurnoBuscado, ObtenerListaTurno(True), 0, "Nombre")
            gmt_ComboEspecifico(cmb_Turno, ObtenerListaTurno, 0, "Nombre")

            ' Vendedores
            Dim ListVendedores As New List(Of e_Combo)
            oeCombo.TipoOperacion = "VEND"
            ListVendedores.AddRange(olCombo.Listar(oeCombo))
            gmt_ComboEspecifico(cboTrabajadorApertura, ListVendedores, 3)

            ' Cargar Estado
            gmt_ComboEspecifico(cmb_EstadoBuscado, ObtenerListaEstado(True), 3) : cmb_EstadoBuscado.SelectedIndex = 0
            gmt_ComboEspecifico(cmb_Estado, ObtenerListaEstado, 3) : cmb_EstadoBuscado.SelectedIndex = 0

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class