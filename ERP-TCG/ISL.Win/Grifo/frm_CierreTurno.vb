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

    Private TURNO As New e_CierreTurno, dTURNO As New l_CierreTurno
    Private TURNO_DETALLE As New e_CierreTurno_Detalle


    ' Asiento Modelo
    ' Private REFERENCIA As New e_AsientoModelo_Referencia, LISTA_REFERENCIA As New List(Of e_AsientoModelo_Referencia)

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
        TURNO = New e_CierreTurno
        Dim lista As List(Of e_Combo), olCombo As New l_Combo

        lista = New List(Of e_Combo)
        lista.Add(New e_Combo With {.Id = "D", .Nombre = "DIA"})
        lista.Add(New e_Combo With {.Id = "N", .Nombre = "NOCHE"})
        LlenarCombo(cmb_Turno, "Nombre", lista, 0)
        LlenarCombo(cmb_TurnoBuscado, "Nombre", lista, 0)

        lista = New List(Of e_Combo)
        lista.Add(New e_Combo With {.Id = "ABIERTO", .Nombre = "ABIERTO"})
        lista.Add(New e_Combo With {.Id = "CERRADO", .Nombre = "CERRADO"})
        LlenarCombo(cmb_Estado, "Nombre", lista, 0)
        LlenarCombo(cmb_EstadoBuscado, "Nombre", lista, 0)

        ''Vendedores
        lista = New List(Of e_Combo)
        lista.AddRange(olCombo.Listar(New e_Combo With {.TipoOperacion = "VEND"}))
        gmt_ComboEspecifico(cmb_TrabajadorApertura_Buscado, lista, 3)
        gmt_ComboEspecifico(cboTrabajadorApertura, lista, 3)
        gmt_ComboEspecifico(cboTrabajadorCierre, lista, 3)

        mt_CargarDetalles()
        UltraTabControl1.Tabs(0).Selected = True
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
            With griOrdenComercial
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
                .DisplayLayout.Bands(0).Columns("idSucursal").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTurno").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador_Apertura").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador_Cierre").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar()
        Try
            TURNO = New e_CierreTurno
            TURNO.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            TURNO = dTURNO.Obtener(TURNO)
            With TURNO
                cmb_Turno.Value = Trim(.IdTurno)
                dtpFecha.Value = .Fecha
                dtpHoraInicio.Value = .HoraInicio
                dtpHoraFin.Value = .HoraFin
                cmb_Estado.Value = Trim(.IdEstado)
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
                udg_Combustibles.DataSource = .Detalles.Where(Function(it) it.Rubro = "PRECIO_COMBUSTIBLE").ToList : udg_Almacenes.DataBind()
            End With
            mt_OcultarColumnas()
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
                .TipoOperacion = "I"
                .IdEmpresaSis = gs_IdEmpresaSistema
                .IdSucursal = gs_IdSucursal
                .IdSucursalSistema = gs_IdSucursal
                .PrefijoID = gs_PrefijoIdSucursal
                .IdTurno = cmb_Turno.Value
                .Turno = cmb_Turno.Text
                .IdEstado = cmb_Estado.Value
                .Estado = cmb_Estado.Text
                .Fecha = dtpFecha.Value
                .HoraInicio = dtpHoraInicio.Value
                .HoraFin = dtpHoraFin.Value
                .IdTrabajador_Apertura = "" 'cboTrabajadorApertura.Value.ToString
                .Trabajador_Apertura = "" 'cboTrabajadorApertura.Text
                .IdTrabajador_Cierre = "" 'cboTrabajadorCierre.Value.ToString
                .Trabajador_Cierre = "" 'cboTrabajadorCierre.Text
                .Glosa = txtGlosa.Text
                .UsuarioCrea = gUsuarioSGI.Id
                .FechaCrea = Date.Now
                .UsuarioModifica = gUsuarioSGI.Id
                .FechaModifica = Date.Now
                .Activo = True
            End With
            udg_Trabajadores.UpdateData()
            udg_ContometroDigital.UpdateData()
            udg_ContometroAnalogico.UpdateData()
            udg_VentasxCombustible.UpdateData()
            udg_VentasAnuladas.UpdateData()
            udg_Calibraciones.UpdateData()
            udg_Almacenes.UpdateData()
            udg_Combustibles.UpdateData()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub udg_ContometroDigital_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles udg_ContometroDigital.InitializeLayout
        udg_ContometroDigital.UpdateData()
    End Sub

    Private Sub udg_ContometroAnalogico_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles udg_ContometroAnalogico.InitializeLayout
        udg_ContometroAnalogico.UpdateData()
    End Sub

    Private Sub udg_Almacenes_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles udg_Almacenes.InitializeLayout
        udg_Almacenes.UpdateData()
    End Sub

    Private Sub udg_Combustibles_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles udg_Combustibles.InitializeLayout
        udg_Combustibles.UpdateData()
    End Sub

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
            Dim Lista As New List(Of e_Combo)
            Lista.Add(New e_Combo With {.Id = "D", .Nombre = "Dia"})
            Lista.Add(New e_Combo With {.Id = "N", .Nombre = "Noche"})
            gmt_ComboEspecifico(cmb_Turno, Lista, 0)
            gmt_ComboEspecifico(cmb_TurnoBuscado, Lista, 0)

            ' Vendedores
            Dim ListVendedores As New List(Of e_Combo)
            oeCombo.TipoOperacion = "VEND"
            ListVendedores.AddRange(olCombo.Listar(oeCombo))
            gmt_ComboEspecifico(cboTrabajadorApertura, ListVendedores, 3)
            gmt_ComboEspecifico(cboTrabajadorCierre, ListVendedores, 3)

            ' Cargar Estado
            gmt_ComboEspecifico(cmb_EstadoBuscado, ObtenerListaEstado(True), 3) : cmb_EstadoBuscado.SelectedIndex = 0
            gmt_ComboEspecifico(cmb_Estado, ObtenerListaEstado, 3) : cmb_EstadoBuscado.SelectedIndex = 0

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


    Private Sub mt_OcultarColumnas()

        With udg_Trabajadores
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_ContometroDigital
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = False
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_ContometroAnalogico
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = False
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_VentasxCombustible
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_VentasAnuladas
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_Calibraciones
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_Almacenes
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
        With udg_Combustibles
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdEmpresaSis").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSucursal").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCierreTurno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Grupo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Rubro").Hidden = True
            .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdConcepto").Hidden = True
            .DisplayLayout.Bands(0).Columns("Concepto").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorInicial").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorFinal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorDiferencia").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorERP").Hidden = False
            .DisplayLayout.Bands(0).Columns("ValorReal").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux1").Hidden = True
            .DisplayLayout.Bands(0).Columns("ValorAux2").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaCrea").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("FechaModifica").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
    End Sub


    Private Sub mt_CargarDetalles()
        Try
            Dim Detalle As New e_CierreTurno_Detalle With {.Rubro = "TRABAJADORES", .Descripcion = "Trabajador1"} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 1", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 2", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 3", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 4", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 5", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = "Lado 6", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 1", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 2", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 3", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 4", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 5", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = "Lado 6", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTASXCOMBUSTIBLE", .Grupo = "", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "VENTAS_ANULADAS", .Grupo = "", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "CALIBRACIONES", .Grupo = "", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000001", .Concepto = "", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000002", .Concepto = "DB5 S-50 UV (5000)", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000003", .Concepto = "DB5 S-50 UV (4000)", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000004", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000005", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "CHT000000001", .IdConcepto = "CHT000000005", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "PRECIO_COMBUSTIBLE", .Grupo = "", .IdConcepto = "1CH000000147", .Concepto = "GASOHOL 84", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "PRECIO_COMBUSTIBLE", .Grupo = "", .IdConcepto = "1CH000000148", .Concepto = "GASOHOL 90", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "PRECIO_COMBUSTIBLE", .Grupo = "", .IdConcepto = "1CH000000149", .Concepto = "GASOHOL 95", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "PRECIO_COMBUSTIBLE", .Grupo = "", .IdConcepto = "1CH000007256", .Concepto = "DIESEL DB5", .ValorInicial = 0, .ValorFinal = 0} : TURNO.Detalles.Add(Detalle)
            mt_CargarGrillas()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_CierreTurno_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mt_Inicializar()
    End Sub
End Class