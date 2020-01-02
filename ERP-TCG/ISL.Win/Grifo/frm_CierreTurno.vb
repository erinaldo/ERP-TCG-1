' ===================================================================================================
' Modified | Developer
' 02/01/20 | Cess
' ===================================================================================================
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

    Private TurnoActivo As New e_CierreTurno, dTurno As New l_CierreTurno
    Private dTurnoDetalle As New l_CierreTurno_Detalle
    Private ListaDetallesDinamicos As New List(Of e_CierreTurno_Detalle)
    Private swNuevo As Boolean

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
            Operacion = "Inicializa"
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If swNuevo = False Then Exit Sub
            Operacion = "Nuevo"
            gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            TurnoActivo = fc_Inicializar_Turno("I")
            mt_ControlBotoneria()
            mt_Agregar_Detalles()
            mt_HabilitarControles()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            If griOrdenComercial.Selected.Rows.Count > 0 Then
                gmt_MostrarTabs(1, ficOrdenComercial, 1)
                mt_Inicializar()
                TurnoActivo.TipoOperacion = "" : TurnoActivo.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
                TurnoActivo = dTurno.Obtener(TurnoActivo)
                TurnoActivo.TipoOperacion = "A"
                mt_Mostrar_Turno()
                mt_ControlBotoneria()
                mt_HabilitarControles()
                mt_Actualizar_Columnas()
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
                TurnoActivo = New e_CierreTurno
                If .Selected.Rows.Count > 0 Then
                    TurnoActivo.TipoOperacion = ""
                    TurnoActivo.Id = .ActiveRow.Cells("Id").Value
                    TurnoActivo = dTurno.Obtener(TurnoActivo)
                    If TurnoActivo.IdEstado = "1CIX043" Then 'Apertura
                        If MessageBox.Show("Esta seguro de eliminar la Orden: " &
                                 .ActiveRow.Cells("OrdenComercial").Value.ToString & " ?",
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            TurnoActivo.TipoOperacion = "N"
                            TurnoActivo.UsuarioCrea = gUsuarioSGI.Id
                            dTurno.Eliminar(TurnoActivo)
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
        TurnoActivo = New e_CierreTurno
        ListaDetallesDinamicos = New List(Of e_CierreTurno_Detalle)
        Dim lista As List(Of e_Combo), olCombo As New l_Combo
        lista = New List(Of e_Combo)
        'lista.Add(New e_Combo With {.Id = "1", .Nombre = "DIA"})
        'lista.Add(New e_Combo With {.Id = "2", .Nombre = "NOCHE"})
        lista.Add(New e_Combo With {.Id = "1", .Nombre = "TURNO 1"})
        lista.Add(New e_Combo With {.Id = "2", .Nombre = "TURNO 2"})
        lista.Add(New e_Combo With {.Id = "3", .Nombre = "TURNO 3"})
        lista.Add(New e_Combo With {.Id = "4", .Nombre = "TURNO 4"})
        lista.Add(New e_Combo With {.Id = "5", .Nombre = "TURNO 5"})
        LlenarCombo(cmb_Turno, "Nombre", lista, 0)
        LlenarCombo(cmb_TurnoNuevo, "Nombre", lista, 0)
        LlenarCombo(cmb_TurnoBuscado, "Nombre", lista, 0)

        lista = New List(Of e_Combo)
        lista.Add(New e_Combo With {.Id = "ABIERTO", .Nombre = "ABIERTO"})
        lista.Add(New e_Combo With {.Id = "CERRADO", .Nombre = "CERRADO"})
        LlenarCombo(cmb_Estado, "Nombre", lista, 0)
        LlenarCombo(cmb_EstadoBuscado, "Nombre", lista, 0)

        ''Vendedores
        LlenarCombo(cmb_TrabajadorApertura_Buscado, "Nombre", TrabajadorPublic, -1)
        LlenarCombo(cboTrabajadorApertura, "Nombre", TrabajadorPublic, -1)
        LlenarCombo(cboTrabajadorCierre, "Nombre", TrabajadorPublic, -1)
        'lista = New List(Of e_Combo)
        'lista.AddRange(olCombo.Listar(New e_Combo With {.TipoOperacion = "VEND"}))
        'gmt_ComboEspecifico(cmb_TrabajadorApertura_Buscado, lista, 3)
        'gmt_ComboEspecifico(cboTrabajadorApertura, lista, 3)
        'gmt_ComboEspecifico(cboTrabajadorCierre, lista, 3)

        dtpFechaInicio.Value = ObtenerFechaServidor.Date.AddDays(-7)
        dtpFechaFin.Value = ObtenerFechaServidor.Date
        UltraTabControl1.Tabs(0).Selected = True

    End Sub

    Private Sub mt_Listar()
        Try
            Dim ListaTurnos As New List(Of e_CierreTurno)
            TurnoActivo = New e_CierreTurno
            With TurnoActivo
                .TipoOperacion = ""
                .IdEmpresaSis = gs_IdEmpresaSistema
                .IdSucursal = gs_IdSucursal
                .Fecha = dtpFechaInicio.Value.Date
                .FechaCrea = dtpFechaFin.Value.Date
                .Activo = 1
            End With
            ListaTurnos = dTurno.Listar(TurnoActivo)
            griOrdenComercial.DataSource = ListaTurnos

            If ListaTurnos.Count = 0 Then
                swNuevo = True
            Else
                For Each item In ListaTurnos
                    If item.Estado = "ABIERTO" Then swNuevo = False
                Next
            End If

            'mt_CombosGrillaPrincipal(griOrdenComercial)
            For Each fila As UltraGridRow In griOrdenComercial.Rows
                Select Case fila.Cells("Estado").Value
                    Case "ABIERTO" : fila.CellAppearance.BackColor = Me.colorEvaluado.Color
                    Case "CERRADO" : fila.CellAppearance.BackColor = Me.colorParcial.Color
                End Select
            Next
            With griOrdenComercial
                .DisplayLayout.Bands(0).Columns("Id").Hidden = False
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

            mt_ControlBotoneria()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar_Turno()
        Try
            With TurnoActivo
                cmb_Turno.Value = Trim(.IdTurno)
                cmb_TurnoNuevo.Value = fc_Devolver_IdTurnoSiguiente(.IdTurno)
                dtpFecha.Value = .Fecha
                dtp_FechaNuevo.Value = ObtenerFechaServidor.Date
                dtpHoraInicio.Value = .HoraInicio
                dtpHoraFin.Value = .HoraFin
                cmb_Estado.Value = Trim(.IdEstado)
                cboTrabajadorApertura.Value = .IdTrabajador_Apertura
                txtGlosa.Text = .Glosa
                mt_Mostrar_TurnoDetalles()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Inicializar_Turno(TipoOperacion As String)
        Dim Turno As New e_CierreTurno
        With Turno
            .Id = ""
            .TipoOperacion = TipoOperacion
            .IdEmpresaSis = gs_IdEmpresaSistema
            .IdSucursal = gs_IdSucursal
            .IdSucursalSistema = gs_IdSucursal
            .PrefijoID = gs_PrefijoIdSucursal
        End With
        Return Turno
    End Function

    Private Sub mt_HabilitarControles()
        '' Por Tipo Operacion
        Select Case Operacion
            Case "Nuevo"
                cmb_Turno.Enabled = True
                cboTrabajadorApertura.Enabled = True
                cboTrabajadorCierre.Enabled = False
            Case "Editar"
                cmb_Turno.Enabled = False
                cboTrabajadorApertura.Enabled = False
                cboTrabajadorCierre.Enabled = True
        End Select

        '' Por Estado
        If TurnoActivo.Id <> "" Then
            With udg_ContometroAnalogico.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorInicial").CellClickAction = CellClickAction.EditAndSelectText
            End With
            With udg_ContometroDigital.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorInicial").CellClickAction = CellClickAction.EditAndSelectText
            End With
            With udg_Almacenes.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorInicial").CellClickAction = CellClickAction.EditAndSelectText
            End With
        End If
        If TurnoActivo.IdEstado = "ABIERTO" Then
            With udg_ContometroAnalogico.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorFinal").CellClickAction = CellClickAction.EditAndSelectText
            End With
            With udg_ContometroDigital.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorFinal").CellClickAction = CellClickAction.EditAndSelectText
            End With
            With udg_Almacenes.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
                .Columns("ValorFinal").CellClickAction = CellClickAction.EditAndSelectText
            End With
        End If
        If TurnoActivo.IdEstado = "CERRADO" Then
            cmb_Turno.Enabled = False
            cmb_Estado.Enabled = False
            cboTrabajadorApertura.Enabled = False
            cboTrabajadorCierre.Enabled = False
            UltraGroupBox2.Enabled = False
            With udg_ContometroAnalogico.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
            End With
            With udg_ContometroDigital.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
            End With
            With udg_Almacenes.DisplayLayout.Bands(0)
                For Each Columna In .Columns
                    Columna.CellClickAction = CellClickAction.RowSelect
                Next
            End With
        End If
    End Sub
    Private Sub mt_Mostrar_TurnoDetalles()
        Try
            With TurnoActivo
                udg_Trabajadores.DataSource = .Detalles.Where(Function(it) it.Rubro = "TRABAJADORES").ToList : udg_Trabajadores.DataBind()
                udg_ContometroDigital.DataSource = .Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_DIGITAL").ToList : udg_ContometroDigital.DataBind()
                udg_ContometroAnalogico.DataSource = .Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_MECANICO").ToList : udg_ContometroAnalogico.DataBind()
                udg_Almacenes.DataSource = .Detalles.Where(Function(it) it.Rubro = "ALMACENES").ToList : udg_Almacenes.DataBind()
                udg_Combustibles.DataSource = .Detalles.Where(Function(it) it.Rubro = "PRECIO_COMBUSTIBLE").ToList : udg_Combustibles.DataBind()
                udg_VentasxCombustible.DataSource = .Detalles.Where(Function(it) it.Rubro = "VENTASXCOMBUSTIBLE").ToList : udg_VentasxCombustible.DataBind()
                udg_ResumenVentas.DataSource = .Detalles.Where(Function(it) it.Rubro = "VENTAS_CONSOLIDADO").ToList : udg_ResumenVentas.DataBind()
                udg_VentasAnuladas.DataSource = .Detalles.Where(Function(it) it.Rubro = "VENTAS_ANULADAS").ToList : udg_VentasAnuladas.DataBind()
                udg_Calibraciones.DataSource = .Detalles.Where(Function(it) it.Rubro = "CALIBRACIONES").ToList : udg_Calibraciones.DataBind()
            End With

            '' Consulta de informacion Dinamica, registrada al momento justo antes del cierre, ni mas ni menos
            If TurnoActivo.IdEstado = "ABIERTO" Then
                mt_Cargar_ListaDetallesDinamicos()
            End If

            mt_Formatear_Columnas()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Guardar() As Boolean
        Try
            If Operacion = "Nuevo" And cboTrabajadorApertura.Value = "" Then Throw New Exception("Debe indicar el TRABAJADOR que apertura el TURNO")
            If cmb_Estado.Value = "CERRADO" And cboTrabajadorCierre.Value = "" Then Throw New Exception("Indique quien APERTURA el NUEVO TURNO")

            If Not fc_Cargar_Turno() Then Return False
            TurnoActivo = dTurno.Guardar(TurnoActivo)

            If cmb_Estado.Value = "CERRADO" Then
                mt_Generar_TurnoNuevo()
                mt_Guardar_DetallesDinamicos()
            End If

            MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Guardar_DetallesDinamicos()
        Dim dCierreTurnoDetalle As New l_CierreTurno_Detalle
        For Each Item In ListaDetallesDinamicos
            Item.IdCierreTurno = TurnoActivo.Id
            Item.TipoOperacion = "I"
            Item.PrefijoID = TurnoActivo.PrefijoID
            Item.IdEmpresaSis = TurnoActivo.IdEmpresaSis
            dCierreTurnoDetalle.Guardar(Item)
        Next
    End Sub

    Private Sub mt_Generar_TurnoNuevo()
        Dim TurnoNuevo As New e_CierreTurno
        TurnoNuevo = fc_Inicializar_Turno("I")
        With TurnoNuevo
            .IdEstado = "ABIERTO" : .Estado = "ABIERTO"
            .Fecha = Now.Date : .HoraInicio = dtpHoraInicio.Value : .HoraFin = dtpHoraFin.Value
            .IdTrabajador_Apertura = cboTrabajadorCierre.Value : .Trabajador_Apertura = cboTrabajadorCierre.Text
            .IdTurno = cmb_TurnoNuevo.Value : .Turno = cmb_TurnoNuevo.Text
            .UsuarioCrea = gUsuarioSGI.Id : .FechaCrea = Now.Date
            .UsuarioModifica = gUsuarioSGI.Id : .FechaModifica = Now.Date
            .Detalles.AddRange(TurnoActivo.Detalles)
            For Each Detalle In TurnoNuevo.Detalles
                Detalle.TipoOperacion = "I"
                Detalle.Id = ""
                Detalle.IdCierreTurno = ""
                Select Case Detalle.Rubro
                    Case "CONTOMETRO_DIGITAL", "CONTOMETRO_MECANICO", "ALMACENES"
                        Detalle.ValorInicial = Detalle.ValorFinal
                        Detalle.ValorFinal = 0
                        Detalle.ValorDiferencia = 0
                    Case "VENTASXCOMBUSTIBLE", "VENTAS_ANULADAS", "CALIBRACIONES"
                        Detalle.ValorERP = 0
                End Select
            Next
        End With
        TurnoNuevo = dTurno.Guardar(TurnoNuevo)
    End Sub

    Private Function fc_Devolver_IdTurnoSiguiente(IdTurno As String) As String
        If IdTurno <> "" Then
            If IdTurno = "5" Then Return 1
            If dtpFecha.Value.Date <> Now.Date Then Return 1
            Return CInt(IdTurno) + 1
        End If
    End Function

    Public Function fc_Cargar_Turno() As Boolean
        Try
            With TurnoActivo
                .IdTurno = cmb_Turno.Value
                .Turno = cmb_Turno.Text
                .IdEstado = cmb_Estado.Value
                .Estado = cmb_Estado.Text
                .Fecha = dtpFecha.Value.Date
                .HoraInicio = dtpHoraInicio.Value
                .HoraFin = dtpHoraFin.Value
                .IdTrabajador_Apertura = cboTrabajadorApertura.Value
                .Trabajador_Apertura = cboTrabajadorApertura.Text
                .IdTrabajador_Cierre = cboTrabajadorApertura.Value
                .Trabajador_Cierre = cboTrabajadorApertura.Text
                .Glosa = txtGlosa.Text
                .UsuarioCrea = gUsuarioSGI.Id : .FechaCrea = Now.Date
                .UsuarioModifica = gUsuarioSGI.Id : .FechaModifica = Now.Date
                .Activo = True
            End With
            udg_Trabajadores.UpdateData()
            udg_ContometroDigital.UpdateData()
            udg_ContometroAnalogico.UpdateData()
            udg_VentasxCombustible.UpdateData()
            udg_ResumenVentas.UpdateData()
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
                    gmt_ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
                Else
                    gmt_ControlBoton(1, 1)
                End If
            Case 1
                If TurnoActivo.Estado = "ABIERTO" Or TurnoActivo.Estado = "" Then
                    gmt_ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Else
                    gmt_ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
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

    Private Sub mt_Formatear_Columnas()
        Dim Color_ValorInicial As Color = Color.LightBlue
        Dim Color_ValorFinal As Color = Color.LightGreen
        Dim Color_Galones As Color = Color.Yellow

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_Trabajadores)
        With udg_Trabajadores.DisplayLayout.Bands(0)
            .Columns("Concepto").Header.Caption = "Trabajador" : .Columns("Concepto").Hidden = False
        End With

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_Combustibles)
        With udg_Combustibles.DisplayLayout.Bands(0)
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 100
            .Columns("ValorERP").Header.Caption = "Precio"
        End With
        mt_Aplicar_FormatoNumerico(udg_Combustibles, "ValorERP")

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_Almacenes)
        With udg_Almacenes.DisplayLayout.Bands(0)
            .Columns("Concepto").Header.Caption = "Almacen" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 100
            .Columns("ValorInicial").Header.Caption = "V.Inicial" : .Columns("ValorInicial").CellAppearance.BackColor = Color_ValorInicial
            .Columns("ValorFinal").Header.Caption = "V.Final" : .Columns("ValorFinal").CellAppearance.BackColor = Color_ValorFinal
            .Columns("ValorDiferencia").Header.Caption = "Diferencia"
        End With
        mt_Aplicar_FormatoNumerico(udg_Almacenes, "ValorInicial")
        mt_Aplicar_FormatoNumerico(udg_Almacenes, "ValorFinal")
        mt_Aplicar_FormatoNumerico(udg_Almacenes, "ValorDiferencia")

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_ContometroDigital)
        With udg_ContometroDigital.DisplayLayout.Bands(0)
            .Columns("Grupo").Header.Caption = "Lado" : .Columns("Grupo").Hidden = False : .Columns("Grupo").Width = 50
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 100
            .Columns("ValorInicial").Header.Caption = "V.Inicial" : .Columns("ValorInicial").CellAppearance.BackColor = Color_ValorInicial
            .Columns("ValorFinal").Header.Caption = "V.Final" : .Columns("ValorFinal").CellAppearance.BackColor = Color_ValorFinal
            .Columns("ValorDiferencia").Header.Caption = "Diferencia"
            .Columns("ValorAux1").Header.Caption = "Despacho" : .Columns("ValorAux1").CellAppearance.BackColor = Color_Galones
            .Columns("ValorAux2").Header.Caption = "Margen"
        End With
        mt_Aplicar_FormatoNumerico(udg_ContometroDigital, "ValorInicial")
        mt_Aplicar_FormatoNumerico(udg_ContometroDigital, "ValorFinal")
        mt_Aplicar_FormatoNumerico(udg_ContometroDigital, "ValorDiferencia")
        mt_Aplicar_FormatoNumerico(udg_ContometroDigital, "ValorAux1")
        mt_Aplicar_FormatoNumerico(udg_ContometroDigital, "ValorAux2")
        CalcularTotales(udg_ContometroDigital, "ValorDiferencia", "ValorAux1", "ValorAux2")

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_ContometroAnalogico)
        With udg_ContometroAnalogico.DisplayLayout.Bands(0)
            .Columns("Grupo").Hidden = False : .Columns("Grupo").Width = 50 : .Columns("Grupo").Header.Caption = "Lado"
            .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 100 : .Columns("Concepto").Header.Caption = "Combustible"
            .Columns("ValorInicial").Header.Caption = "V.Inicial" : .Columns("ValorInicial").CellAppearance.BackColor = Color_ValorInicial
            .Columns("ValorFinal").Header.Caption = "V.Final" : .Columns("ValorFinal").CellAppearance.BackColor = Color_ValorFinal
            .Columns("ValorDiferencia").Header.Caption = "Diferencia"
            .Columns("ValorAux1").Header.Caption = "Despacho" : .Columns("ValorAux1").CellAppearance.BackColor = Color_Galones
            .Columns("ValorAux2").Header.Caption = "Margen"
        End With
        mt_Aplicar_FormatoNumerico(udg_ContometroAnalogico, "ValorInicial")
        mt_Aplicar_FormatoNumerico(udg_ContometroAnalogico, "ValorFinal")
        mt_Aplicar_FormatoNumerico(udg_ContometroAnalogico, "ValorDiferencia")
        mt_Aplicar_FormatoNumerico(udg_ContometroAnalogico, "ValorAux1")
        mt_Aplicar_FormatoNumerico(udg_ContometroAnalogico, "ValorAux2")
        CalcularTotales(udg_ContometroAnalogico, "ValorDiferencia", "ValorAux1", "ValorAux2")

        '' Ventas de Combustible
        mt_Ocultar_Columnas(udg_VentasxCombustible)
        With udg_VentasxCombustible.DisplayLayout.Bands(0)
            .Columns("Grupo").Header.Caption = "T.Pago" : .Columns("Grupo").Hidden = False : .Columns("Grupo").Width = 80
            .Columns("Descripcion").Header.Caption = "Lado" : .Columns("Descripcion").Hidden = False : .Columns("Descripcion").Width = 60
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 120
            .Columns("ValorERP").Header.Caption = "Importe"
            .Columns("ValorReal").Header.Caption = "Galones" : .Columns("ValorReal").CellAppearance.BackColor = Color_Galones
        End With
        mt_Aplicar_FormatoNumerico(udg_VentasxCombustible, "ValorERP")
        mt_Aplicar_FormatoNumerico(udg_VentasxCombustible, "ValorReal")
        CalcularTotales(udg_VentasxCombustible, "ValorERP", "ValorReal")

        '' Resumen de Ventas
        mt_Ocultar_Columnas(udg_ResumenVentas)
        With udg_ResumenVentas.DisplayLayout.Bands(0)
            .Columns("Descripcion").Header.Caption = "Lado" : .Columns("Descripcion").Hidden = False : .Columns("Descripcion").Width = 60
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 120
            .Columns("ValorERP").Header.Caption = "Importe"
            .Columns("ValorReal").Header.Caption = "Galones" : .Columns("ValorReal").CellAppearance.BackColor = Color_Galones
        End With
        mt_Aplicar_FormatoNumerico(udg_ResumenVentas, "ValorERP")
        mt_Aplicar_FormatoNumerico(udg_ResumenVentas, "ValorReal")
        CalcularTotales(udg_ResumenVentas, "ValorERP", "ValorReal")

        ''Ventas Anuladas
        mt_Ocultar_Columnas(udg_VentasAnuladas)
        With udg_VentasAnuladas.DisplayLayout.Bands(0)
            .Columns("Grupo").Header.Caption = "T.Pago" : .Columns("Grupo").Hidden = False : .Columns("Grupo").Width = 80
            .Columns("Descripcion").Header.Caption = "Lado" : .Columns("Descripcion").Hidden = False : .Columns("Descripcion").Width = 60
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 120
            .Columns("ValorERP").Header.Caption = "Importe"
            .Columns("ValorReal").Header.Caption = "Galones" : .Columns("ValorReal").CellAppearance.BackColor = Color_Galones
        End With
        mt_Aplicar_FormatoNumerico(udg_VentasAnuladas, "ValorERP")
        mt_Aplicar_FormatoNumerico(udg_VentasAnuladas, "ValorReal")
        CalcularTotales(udg_VentasAnuladas, "ValorERP", "ValorReal")

        '' Calibraciones
        mt_Ocultar_Columnas(udg_Calibraciones)
        With udg_Calibraciones.DisplayLayout.Bands(0)
            .Columns("Descripcion").Header.Caption = "Lado" : .Columns("Descripcion").Hidden = False : .Columns("Descripcion").Width = 60
            .Columns("Concepto").Header.Caption = "Combustible" : .Columns("Concepto").Hidden = False : .Columns("Concepto").Width = 120
            .Columns("ValorERP").Header.Caption = "Importe"
            .Columns("ValorReal").Header.Caption = "Galones" : .Columns("ValorReal").CellAppearance.BackColor = Color_Galones
        End With
        mt_Aplicar_FormatoNumerico(udg_Calibraciones, "ValorERP")
        mt_Aplicar_FormatoNumerico(udg_Calibraciones, "ValorReal")
        CalcularTotales(udg_Calibraciones, "ValorERP", "ValorReal")
    End Sub

    Private Sub mt_Ocultar_Columnas(UDG As UltraGrid)
        With UDG.DisplayLayout.Bands(0)
            For Each Columna In .Columns
                Columna.Hidden = True
            Next
        End With
    End Sub

    Private Sub mt_Aplicar_FormatoNumerico(UDG As UltraGrid, Columna As String)
        With UDG.DisplayLayout.Bands(0)
            .Columns(Columna).Hidden = False
            .Columns(Columna).Width = 50
            .Columns(Columna).Format = "#,###,###,###0.000"
            .Columns(Columna).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End With
    End Sub

    Private Sub mt_Agregar_Detalles()
        Try
            Dim ListaCombustibles As New List(Of e_Material), dMaterial As New l_Material
            Dim ListaLado As New List(Of e_Lado), dLado As New l_Lado
            Dim Detalle As New e_CierreTurno_Detalle

            ListaCombustibles = dMaterial.Listar(New e_Material With {.TipoOperacion = "S"})
            ListaLado = dLado.Listar(New e_Lado With {.TipoOperacion = "ALL"})

            '' Trabajadores
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "TRABAJADORES", .Descripcion = "Trabajador1"} : TurnoActivo.Detalles.Add(Detalle)

            '' Contometros
            For Each Lado In ListaLado
                For Each Combustible In ListaCombustibles
                    Select Case Combustible.Id
                        Case "1CH000001990"
                            If Lado.Diesel Then
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                            End If
                        Case "1CH000000147"
                            If Lado.G84 Then
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                            End If
                        Case "1CH000000148"
                            If Lado.G90 Then
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                            End If
                        Case "1CH000000149"
                            If Lado.G95 Then
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_DIGITAL", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                                Detalle = New e_CierreTurno_Detalle With {.Rubro = "CONTOMETRO_MECANICO", .Grupo = Lado.Nombre, .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
                            End If
                    End Select
                Next
            Next

            '' Precios de Combustibles
            For Each Combustible In ListaCombustibles
                Detalle = New e_CierreTurno_Detalle With {.Rubro = "PRECIO_COMBUSTIBLE", .Grupo = "", .IdConcepto = Combustible.Id, .Concepto = Combustible.Nombre, .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
            Next

            '' Almacenes
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "1CH000000001", .IdConcepto = "1CH000000003", .Concepto = "DB5 S-50 UV (5000)", .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "1CH000000002", .IdConcepto = "1CH000000005", .Concepto = "DB5 S-50 UV (4000)", .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "1CH000000004", .IdConcepto = "1CH000000009", .Concepto = "GASOHOL 84 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "1CH000000006", .IdConcepto = "1CH000000012", .Concepto = "GASOHOL 90 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)
            Detalle = New e_CierreTurno_Detalle With {.Rubro = "ALMACENES", .Grupo = "1CH000000007", .IdConcepto = "1CH000000014", .Concepto = "GASOHOL 95 PLUS", .ValorInicial = 0, .ValorFinal = 0} : TurnoActivo.Detalles.Add(Detalle)


            mt_Mostrar_TurnoDetalles()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Cargar_ListaDetallesDinamicos()
        ListaDetallesDinamicos = dTurnoDetalle.Listar(New e_CierreTurno_Detalle With {.TipoOperacion = "CSM", .IdCierreTurno = TurnoActivo.Id})
        If ListaDetallesDinamicos.Count > 0 Then
            udg_VentasxCombustible.DataSource = ListaDetallesDinamicos.Where(Function(it) it.Rubro = "VENTASXCOMBUSTIBLE").ToList : udg_VentasxCombustible.DataBind()
            udg_ResumenVentas.DataSource = ListaDetallesDinamicos.Where(Function(it) it.Rubro = "VENTAS_CONSOLIDADO").ToList : udg_ResumenVentas.DataBind()
            udg_VentasAnuladas.DataSource = ListaDetallesDinamicos.Where(Function(it) it.Rubro = "VENTAS_ANULADAS").ToList : udg_VentasAnuladas.DataBind()
            udg_Calibraciones.DataSource = ListaDetallesDinamicos.Where(Function(it) it.Rubro = "CALIBRACIONES").ToList : udg_Calibraciones.DataBind()
        End If
    End Sub

    Private Sub mt_Actualizar_Columnas(sender As Object, e As CellEventArgs) Handles udg_ContometroDigital.AfterCellUpdate, udg_ContometroAnalogico.AfterCellUpdate, udg_Almacenes.AfterCellUpdate
        mt_Actualizar_Columnas()
    End Sub

    Private Sub mt_Actualizar_Columnas()
        Try
            For Each Item In TurnoActivo.Detalles
                Item.ValorDiferencia = Item.ValorFinal - Item.ValorInicial
            Next

            If ListaDetallesDinamicos.Count > 0 Then
                '' Inicializar
                For Each Cronometro In TurnoActivo.Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_DIGITAL" Or it.Rubro = "CONTOMETRO_MECANICO").ToList
                    Cronometro.ValorAux1 = 0
                Next
                '' Acumular Cantidad Vendida
                For Each Cronometro In TurnoActivo.Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_DIGITAL" Or it.Rubro = "CONTOMETRO_MECANICO").ToList
                    For Each Venta In ListaDetallesDinamicos.Where(Function(it) it.Rubro = "VENTAS_CONSOLIDADO").ToList
                        If Cronometro.Grupo = Venta.Descripcion And Cronometro.IdConcepto = Venta.IdConcepto Then
                            Cronometro.ValorAux1 += Venta.ValorReal
                        End If
                    Next
                Next
                '' Calcular Margen (Contometro - Despacho)
                For Each Cronometro In TurnoActivo.Detalles.Where(Function(it) it.Rubro = "CONTOMETRO_DIGITAL" Or it.Rubro = "CONTOMETRO_MECANICO").ToList
                    Cronometro.ValorAux2 = Cronometro.ValorDiferencia - Cronometro.ValorAux1
                Next
            End If
            udg_Trabajadores.DataBind()
            udg_ContometroDigital.DataBind()
            udg_ContometroAnalogico.DataBind()
            udg_Almacenes.DataBind()
            udg_Combustibles.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_CierreTurno_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub cmb_Turno_ValueChanged(sender As Object, e As EventArgs) Handles cmb_Turno.ValueChanged
        cmb_TurnoNuevo.Value = fc_Devolver_IdTurnoSiguiente(cmb_TurnoNuevo.Value)
    End Sub

    Private Sub frm_CierreTurno_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mt_Inicializar()
        mt_Listar()
    End Sub
End Class