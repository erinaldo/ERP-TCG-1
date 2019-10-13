'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_Control_Garita

#Region "Inicialización del formulario"

    Private Shared Instancia As frm_Control_Garita = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_Control_Garita
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"
    Dim _ingresando_datos As Boolean = False

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim oeControlPersonaVehiculoES As New e_ControlPersonaVehiculoES
    Dim olControlPersonaVehiculoES As New l_ControlPersonaVehiculoES


    Dim lstControlVehiculoES As New List(Of e_ControlVehiculoES)

    Dim oeControlVehiculoES As New e_ControlVehiculoES
    Dim oeControlCargaVehiculoES As New e_ControlCargaVehiculoES

    Dim olControlVehiculoES As New l_ControlVehiculoES

    Dim oeControlPersonaES As New e_ControlPersonaES
    Dim oeControlCargaPersonaES As New e_ControlCargaPersonaES

    'Manejador Vehiculo-Carreta
    Dim ds_VC As DataSet
    Dim relationVehiculo_Carreta As DataRelation
    'Manejador Vehiculo-Tripulante-Equipaje
    Dim ds_VT As DataSet
    Dim relationVehiculo_Tripulante As DataRelation
    Dim relationTripulante_Equi As DataRelation

    Dim ln_cantVehiculo As Integer = 0
    Dim ln_cantPersona As Integer = 0
#End Region

#Region "Eventos"

    Private Sub frm_Control_Garita_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            ListarCombos()
            rfFechaHasta.Value = Date.Now
            rfFechaDesde.Value = Date.Now.AddDays(-7)
            MostrarTabs(0, ficControlGarita)
            ListarVehiculosES("")
            ListarTripulantesES("")
            'ListarUnidadAsignada_Material("")
            'grid_OA.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            'grid_OA.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Control_Garita_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Control_Garita_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub btnMotriz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotriz.Click
        AgregarVehiculoMotriz()
    End Sub

    Private Sub btn_AgregarCarreta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarCarreta.Click
        AgregarVehiculoCarreta()
    End Sub

#End Region

#Region "Metodos"

    Private Sub ListarCombos()
        'Filtros
        cmbTipo.SelectedIndex = 0
        '
        cmbTipoLista.SelectedIndex = 0

        oeVehiculo = New e_Vehiculo
        oeVehiculo.TipoOperacion = "A"
        oeVehiculo.Motriz = 1
        oeVehiculo.Activo = True
        LlenarComboMaestro(cmbPlacaMotriz, olVehiculo.Listar(oeVehiculo), -1)

        oeVehiculo = New e_Vehiculo
        oeVehiculo.TipoOperacion = "A"
        oeVehiculo.Motriz = 0
        oeVehiculo.Activo = True
        LlenarComboMaestro(cmbPlacaCarreta, olVehiculo.Listar(oeVehiculo), -1)

        oeTrabajador = New e_Trabajador
        LlenarComboMaestro(cmbNombreTripulante, olTrabajador.Listar(oeTrabajador), -1)
    End Sub

    Private Sub ListarVehiculosES(ByVal ls_IdPersonaVehiculo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeControlPersonaVehiculoES = New e_ControlPersonaVehiculoES
            oeControlPersonaVehiculoES.TipoOperacion = "1"
            oeControlPersonaVehiculoES.Activo = True
            oeControlPersonaVehiculoES.Id = ls_IdPersonaVehiculo

            ds_VC = olControlPersonaVehiculoES.ListarTablas(oeControlPersonaVehiculoES)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Vehiculos
            'Tabla(1) Carretas
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim parentCol As DataColumn = ds_VC.Tables(0).Columns("IdVehiculoES")
            Dim childCol As DataColumn = ds_VC.Tables(1).Columns("IdVehiculoES")
            relationVehiculo_Carreta = New DataRelation("FK_Relacion", parentCol, childCol, True)
            ds_VC.Relations.Add(relationVehiculo_Carreta)
            ds_VC.AcceptChanges()
            griVehiculos.DataSource = ds_VC
            With griVehiculos.DisplayLayout
                .Bands(0).Columns("IndIsl").Style = ColumnStyle.CheckBox
                .Bands(0).Columns("IndIsl").Header.Caption = "Pertenece a ISL"
                .Bands(1).Columns("IndIsl").Style = ColumnStyle.CheckBox
                .Bands(1).Columns("IdCargaVehiculoES").Hidden = True
                .Bands(1).Columns("IdVehiculoES").Hidden = True
                .Bands(1).Override.RowAppearance.BackColor = Color.LightCyan
                .Bands(1).ColHeadersVisible = False
            End With
            If ds_VC.Tables(0).Rows.Count > 0 Then
                griVehiculos.DataBind()
            End If
            For x As Integer = 0 To griVehiculos.Rows.Count - 1
                griVehiculos.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            griVehiculos.Focus()
        End Try
    End Sub

    Private Sub ListarTripulantesES(ByVal ls_IdPersonaVehiculo As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeControlPersonaVehiculoES = New e_ControlPersonaVehiculoES
            oeControlPersonaVehiculoES.TipoOperacion = "2"
            oeControlPersonaVehiculoES.Activo = True
            oeControlPersonaVehiculoES.Id = ls_IdPersonaVehiculo

            ds_VT = olControlPersonaVehiculoES.ListarTablas(oeControlPersonaVehiculoES)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Vehiculos
            'Tabla(1) Tripulantes
            'Tabla(2) Equipaje
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdVehiculo As DataColumn = ds_VT.Tables(0).Columns("IdVehiculoES")
            Dim IdVehiculoT As DataColumn = ds_VT.Tables(1).Columns("IdVehiculoES")
            relationVehiculo_Tripulante = New DataRelation("FK_Relacion_VT", IdVehiculo, IdVehiculoT, True)
            ds_VT.Relations.Add(relationVehiculo_Tripulante)

            Dim IdPersona As DataColumn = ds_VT.Tables(1).Columns("IdPersonaES")
            Dim IdPersonaE As DataColumn = ds_VT.Tables(2).Columns("IdPersonaES")
            relationTripulante_Equi = New DataRelation("FK_Relacion_PE", IdPersona, IdPersonaE, True)
            ds_VT.Relations.Add(relationTripulante_Equi)
            ds_VT.AcceptChanges()

            griOcupantes.DataSource = ds_VT

            With griOcupantes.DisplayLayout
                .Bands(0).Columns("IndIsl").Style = ColumnStyle.CheckBox
                .Bands(0).Columns("IndIsl").Header.Caption = "Pertenece a ISL"
                .Bands(1).Columns("IndTrabajador").Style = ColumnStyle.CheckBox

                .Bands(0).Columns("IdPersonaVehiculoES").Hidden = True
                .Bands(0).Columns("IdVehiculoES").Hidden = True
                .Bands(1).Columns("IdVehiculoES").Hidden = True
                .Bands(1).Columns("IdPersonaES").Hidden = True
                .Bands(1).Columns("Condicion").Hidden = True
                .Bands(2).Columns("IdCargaPersonaES").Hidden = True
                .Bands(2).Columns("IdPersonaES").Hidden = True
                .Bands(2).Columns("ControlES").Hidden = True
                .Bands(2).Columns("Confirmado").Hidden = True
                .Bands(1).Override.RowAppearance.BackColor = Color.BlanchedAlmond
                .Bands(1).ColHeadersVisible = False
                .Bands(2).ColHeadersVisible = False
            End With
            If ds_VT.Tables(0).Rows.Count > 0 Then
                griOcupantes.DataBind()
            End If
            For x As Integer = 0 To griOcupantes.Rows.Count - 1
                griOcupantes.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            griOcupantes.Focus()
        End Try
    End Sub

    Private Sub AgregarVehiculoMotriz()
        Try
            Dim row As DataRow
            row = ds_VC.Tables(0).NewRow
            row("IdPersonaVehiculoES") = ""
            row("IdVehiculoES") = ln_cantVehiculo
            If String.IsNullOrEmpty(cmbPlacaMotriz.Text) Then Throw New Exception("Ingrese Placa Motriz.")
            Validar("Placa", cmbPlacaMotriz.Text)
            row("Placa") = cmbPlacaMotriz.Text
            row("IndIsl") = IIf(opcIEMotriz.CheckedIndex = 0, 1, 0)
            row("Tipo") = "MOTRIZ"
            ds_VC.Tables(0).Rows.Add(row)
            ds_VC.Tables(0).AcceptChanges()
            ds_VC.AcceptChanges()
            griVehiculos.DataBind()

            Dim row2 As DataRow
            row2 = ds_VT.Tables(0).NewRow
            row2("IdPersonaVehiculoES") = ""
            row2("IdVehiculoES") = ln_cantVehiculo
            row2("Placa") = cmbPlacaMotriz.Text
            row2("IndIsl") = IIf(opcIEMotriz.CheckedIndex = 0, 1, 0)
            row2("Tipo") = "MOTRIZ"
            ds_VT.Tables(0).Rows.Add(row2)
            ds_VT.Tables(0).AcceptChanges()
            ds_VT.AcceptChanges()
            griOcupantes.DataBind()

            oeControlVehiculoES.Modificado = True
            ln_cantVehiculo = ln_cantVehiculo + 1
            cmbPlacaMotriz.Text = String.Empty

            For x As Integer = 0 To griVehiculos.Rows.Count - 1
                Me.griVehiculos.Rows(x).ExpandAll()
            Next

            For x As Integer = 0 To griOcupantes.Rows.Count - 1
                Me.griOcupantes.Rows(x).ExpandAll()
            Next
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub AgregarVehiculoCarreta()
        Try
            Dim ln_CargaVehiculoES As Integer
            If ln_cantVehiculo > 0 AndAlso griVehiculos.ActiveRow.Band.Index = 0 Then
                Dim rowCarreta As DataRow
                ln_CargaVehiculoES = ds_VC.Tables(1).Rows.Count() + 1
                rowCarreta = ds_VC.Tables(1).NewRow
                rowCarreta("IdCargaVehiculoES") = ln_CargaVehiculoES
                rowCarreta("IdVehiculoES") = griVehiculos.ActiveRow.Cells("IdVehiculoES").Value
                If String.IsNullOrEmpty(cmbPlacaCarreta.Text) Then Throw New Exception("Ingrese Placa Carreta.")
                Validar("Placa", cmbPlacaCarreta.Text)
                rowCarreta("Placa") = cmbPlacaCarreta.Text
                rowCarreta("IndIsl") = IIf(opcIECarreta.CheckedIndex = 0, 1, 0)
                rowCarreta("Tipo") = "CARRETA"
                ds_VC.Tables(1).Rows.Add(rowCarreta)
                ds_VC.Tables(1).AcceptChanges()
                ds_VC.AcceptChanges()
                oeControlVehiculoES.Modificado = True
                griVehiculos.DataBind()
                cmbPlacaCarreta.Text = String.Empty
                For x As Integer = 0 To griVehiculos.Rows.Count - 1
                    Me.griVehiculos.Rows(x).ExpandAll()
                Next
            Else
                mensajeEmergente.Confirmacion("Seleccione Vehículo Motriz para Asignar Carreta.")
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub AgregarOcupante()
        Try
            If ln_cantVehiculo > 0 AndAlso griOcupantes.ActiveRow.Band.Index = 0 Then
                Dim rowPersona As DataRow
                ln_cantPersona = ds_VT.Tables(1).Rows.Count() + 1
                rowPersona = ds_VT.Tables(1).NewRow
                rowPersona("IdPersonaES") = ln_cantPersona
                rowPersona("IdVehiculoES") = griOcupantes.ActiveRow.Cells("IdVehiculoES").Value
                If String.IsNullOrEmpty(txtDNI.Value) Then Throw New Exception("Ingrese DNI.")
                If String.IsNullOrEmpty(cmbNombreTripulante.Text) Then Throw New Exception("Ingrese Nombre.")
                Validar("DNI", txtDNI.Value) : Validar("Nombre", cmbNombreTripulante.Text)
                rowPersona("DNI") = txtDNI.Value
                rowPersona("Nombre") = cmbNombreTripulante.Text
                rowPersona("IndTrabajador") = chk_Empleado.Checked
                rowPersona("Condicion") = opCondicion.CheckedIndex
                Select Case opCondicion.CheckedIndex
                    Case 0
                        rowPersona("CondicionNombre") = "Piloto"
                    Case 1
                        rowPersona("CondicionNombre") = "Copiloto"
                    Case 2
                        rowPersona("CondicionNombre") = "Ayudante"
                    Case 3
                        rowPersona("CondicionNombre") = "Ocupante"
                End Select
                ds_VT.Tables(1).Rows.Add(rowPersona)
                ds_VT.Tables(1).AcceptChanges()
                ds_VT.AcceptChanges()
                oeControlVehiculoES.Modificado = True
                griOcupantes.DataBind()
                txtDNI.Value = String.Empty
                cmbNombreTripulante.Text = String.Empty
                For x As Integer = 0 To griOcupantes.Rows.Count - 1
                    Me.griOcupantes.Rows(x).ExpandAll()
                Next
            Else
                mensajeEmergente.Confirmacion("Seleccione Vehículo Motriz para Asignar Tripulantes.")
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub

    Public Sub AgregarBienes()
        Try
            Dim ln_CargaPersonaES As Integer
            If ln_cantPersona > 0 AndAlso griOcupantes.ActiveRow.Band.Index = 1 Then
                Dim rowCarga As DataRow
                ln_CargaPersonaES = ds_VT.Tables(2).Rows.Count() + 1
                rowCarga = ds_VT.Tables(2).NewRow
                rowCarga("IdCargaPersonaES") = ln_CargaPersonaES
                rowCarga("IdPersonaES") = griOcupantes.ActiveRow.Cells("IdPersonaES").Value
                If String.IsNullOrEmpty(txtCarga.Value) Then Throw New Exception("Ingrese Carga.")
                rowCarga("Carga") = txtCarga.Value
                rowCarga("Observacion") = txtObs.Value
                rowCarga("ControlES") = 0
                rowCarga("Confirmado") = 1
                ds_VT.Tables(2).Rows.Add(rowCarga)
                ds_VT.Tables(2).AcceptChanges()
                ds_VT.AcceptChanges()
                oeControlVehiculoES.Modificado = True
                griOcupantes.DataBind()
                txtCarga.Value = String.Empty
                txtObs.Text = String.Empty
                For x As Integer = 0 To griOcupantes.Rows.Count - 1
                    Me.griOcupantes.Rows(x).ExpandAll()
                Next
            Else
                mensajeEmergente.Confirmacion("Seleccione Tripulante para Bienes.")
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub


    Private Function GuardarControlGarita() As Boolean
        Try
            If opMP.CheckedIndex = 0 Then
                TransponerVehiculos()
                TransponerPersonal()
            ElseIf opMP.CheckedIndex = 1 Then

            End If
            If Not olControlVehiculoES.GuardarLista(lstControlVehiculoES) Then Return False
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub TransponerVehiculos()
        lstControlVehiculoES.Clear()
        For Each matRow As DataRow In ds_VC.Tables(0).Rows
            oeControlVehiculoES = New e_ControlVehiculoES
            oeControlVehiculoES.Id = IIf(IsDBNull(matRow("Id")), "", matRow("Id"))
            If cmbTipo.Text = "INGRESO" Then
                oeControlVehiculoES.Ingreso = dtpFecha.Value
            Else
                oeControlVehiculoES.Salida = dtpFecha.Value
            End If
            oeControlVehiculoES.Placa = matRow("Placa")
            oeControlVehiculoES.IndIsl = matRow("IndIsl")
            oeControlVehiculoES.UsuarioCreacion = gUsuarioSGI.Id
            oeControlVehiculoES.PrefijoID = gs_PrefijoIdSucursal '@0001
            lstControlVehiculoES.Add(oeControlVehiculoES)
        Next
    End Sub

    Private Sub TransponerPersonal()

    End Sub

    Private Sub Validar(ByVal caso As String, ByVal ls_parametro As String)
        Try
            Select Case caso
                Case "Placa"
                    With ds_VC.Tables(0)
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("Placa").ToString = ls_parametro Then
                                Throw New Exception("La Placa ya esta Registrada en Motriz.")
                            End If
                        Next
                    End With
                    With ds_VC.Tables(1)
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("Placa").ToString = ls_parametro Then
                                Throw New Exception("La Placa ya esta Registrada en Carreta.")
                            End If
                        Next
                    End With
                Case "DNI"
                    With ds_VT.Tables(1)
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("DNI").ToString = ls_parametro Then
                                Throw New Exception("El DNI ya esta Registrado.")
                            End If
                        Next
                    End With
                Case "Nombre"
                    With ds_VT.Tables(1)
                        For i As Integer = 0 To .Rows.Count - 1
                            If .Rows(i).Item("Nombre").ToString = ls_parametro Then
                                Throw New Exception("El Nombre ya esta Registrado.")
                            End If
                        Next
                    End With
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enfocar(ByVal msj As String)
        If msj.Contains("Placa Motriz") Then cmbPlacaMotriz.Focus()
        If msj.Contains("Placa Carreta") Then cmbPlacaCarreta.Focus()
        If msj.Contains("DNI") Then txtDNI.Focus()
        If msj.Contains("Nombre") Then cmbNombreTripulante.Focus()
        If msj.Contains("Carga") Then txtCarga.Focus()
    End Sub


#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            'Inicializar()
            'oeOrdenAsignacion.TipoOperacion = "I"
            MostrarTabs(1, ficControlGarita, 1)
            Operacion = "Nuevo"
            'Me.txtEstado.Text = "POR GENERAR"
            'Me.ListarAreas(True)
            'Me.ListarTrabajadores()
            'Me.ListarEquipos(True)
            'txtGlosa.Focus()
            'DetalleMenu()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'Listar(Activo)
            'Tiempo1.Enabled = True
            'Operacion = "Inicializa"
            'If grid_OA.Rows.Count > 0 Then
            '    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
            'Else
            '    _Activo = False
            '    MyBase.Consultar()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            'If GuardarOrdenAsignacion() Then
            MostrarTabs(0, ficControlGarita, 2)
            MyBase.Consultar()
            '    _ingresando_datos = False
            '    Me.Consultar(True)
            'Else
            'MostrarTabs(1, tcOA, 1)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        'Inicializar()
        'MostrarOrden()
        'Me.ListarAreas(True)
        'Me.ListarTrabajadores()
        'Me.ListarEquipos(True)
        'oeOrdenAsignacion.TipoOperacion = "A"
        'txtGlosa.Focus()
        'DetalleMenu()
        'Select Case oeOrdenAsignacion.EstadoOA
        '    Case "TERMINADA", "ANULADO"
        '        Vista()
        '    Case Else
        '        Operacion = "Editar"
        '        MyBase.Editar()
        'End Select
    End Sub

    Public Overrides Sub Vista()
        Operacion = "Vista"
        MyBase.Vista()
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeControlPersonaVehiculoES.Modificado Then
                       Select MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarControlGarita() Then
                            MostrarTabs(0, ficControlGarita, 2)
                            _ingresando_datos = False
                            oeControlPersonaVehiculoES.Modificado = False
                            '                    Me.Consultar(True)
                        Else
                            _ingresando_datos = True
                            oeControlPersonaVehiculoES.Modificado = True
                            MostrarTabs(1, ficControlGarita, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficControlGarita, 2)
                        MyBase.Consultar()
                        _ingresando_datos = False
                        oeControlPersonaVehiculoES.Modificado = False
                        'Me.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficControlGarita, 2)
                _ingresando_datos = False
                MyBase.Consultar()
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With grid_OA
            '    If ValidarGrilla(grid_OA, "Orden Asignacion") Then
            '        If .ActiveRow.Cells("EstadoOA").Value.ToString <> "GENERADA" Then
            '            Throw New Exception("Solo Se Pueden Eliminar Orden en Estado GENERADA")
            '        End If
            '        oeOrdenAsignacion.Id = .ActiveRow.Cells("ID").Value
            '        oeOrdenAsignacion = olOrdenAsignacion.Obtener(oeOrdenAsignacion)
            '        oeOrdenAsignacion.TipoOperacion = "E"
            '        If MessageBox.Show("Esta seguro de eliminar la OA N°: " & _
            '        .ActiveRow.Cells("NroOA").Value.ToString.Trim & "?", _
            '        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '            olOrdenAsignacion.Eliminar(oeOrdenAsignacion)
            '            Consultar(True)
            '        End If
            '    End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_ControlGarita.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficControlGarita.SelectedTab.Index = 0 Then Exportar_Excel(grid_ControlGarita)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region


    Private Sub btnAddTripulante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTripulante.Click
        AgregarOcupante()
    End Sub

    Private Sub opcIEMotriz_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcIEMotriz.ValueChanged
        cmbPlacaMotriz.Text = String.Empty
        If opcIEMotriz.CheckedIndex = 1 Then
            cmbPlacaMotriz.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        ElseIf opcIEMotriz.CheckedIndex = 0 Then
            cmbPlacaMotriz.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        End If
    End Sub

    Private Sub opcIECarreta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcIECarreta.ValueChanged
        cmbPlacaCarreta.Text = String.Empty
        If opcIECarreta.CheckedIndex = 1 Then
            cmbPlacaCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        ElseIf opcIECarreta.CheckedIndex = 0 Then
            cmbPlacaCarreta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        End If
    End Sub

    Private Sub chk_Empleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Empleado.CheckedChanged
        Me.txtDNI.Text = String.Empty
        cmbNombreTripulante.Text = String.Empty
        If chk_Empleado.Checked Then
            txtDNI.ReadOnly = True
            cmbNombreTripulante.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            cmbNombreTripulante.Focus()
        Else
            txtDNI.ReadOnly = True
            cmbNombreTripulante.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
            txtDNI.ReadOnly = False
            txtDNI.Focus()
        End If
    End Sub

    Private Sub cmbNombreTripulante_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNombreTripulante.Validated
        Dim oeTrabajador2 As New e_Trabajador
        If Not String.IsNullOrEmpty(cmbNombreTripulante.Text) And chk_Empleado.Checked Then
            oeTrabajador2 = cmbNombreTripulante.Items(cmbNombreTripulante.SelectedIndex).ListObject
            txtDNI.Value = oeTrabajador2.oePersona.Dni
        End If
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Select Case fcDetalle.SelectedTab.Index
            Case 0
                UEGB_Vehiculos.Expanded = True
            Case 1
                UEGB_Ocupantes.Expanded = True
            Case 2
                UEGB_Personal.Expanded = True
        End Select
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Select Case fcDetalle.SelectedTab.Index
            Case 0

            Case 1

            Case 2

        End Select
    End Sub

    Private Sub btnAddBienes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBienes.Click
        AgregarBienes()
    End Sub

End Class