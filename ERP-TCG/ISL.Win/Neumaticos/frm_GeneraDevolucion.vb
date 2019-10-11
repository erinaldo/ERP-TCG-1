'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_GeneraDevolucion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_GeneraDevolucion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_GeneraDevolucion()
        End If
        Instancia.Activate()
        Return Instancia
    End Function


#End Region

#Region "Declaracion de Variables"

    Dim oeRegistroDevolucion As New e_RegistroDevolucion, olRegistroDevolucion As New l_RegistroDevolucion, leRegistroDevolucion As New List(Of e_RegistroDevolucion)
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico, leVidaNeumatico As New List(Of e_VidaNeumatico)
    Dim oeDetalleRegDev As New e_DetalleRegistroDevolucion, olDetalleRegDev As New l_DetalleRegistroDevolucion, leDetalleRegDev As New List(Of e_DetalleRegistroDevolucion)
    Dim oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Dim oeClienteProveedor As New e_ClienteProveedor, olClienteProveedor As New l_ClienteProveedor, leClienteProveedor As New List(Of e_ClienteProveedor)
    Dim leVidaNeu As New List(Of e_VidaNeumatico)
    Private _opeint As Integer

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficRegistroDevolucion, 1)
            Inicializar()
            oeRegistroDevolucion.TipoOperacion = "I"
            oeRegistroDevolucion.Modificado = False
            ' txtCodigo.Text = fn_ObtineCodigo()
            'txtNombre.Focus()
            Operacion = "Nuevo"
            Dim _leAux = leEstado.Where(Function(it) it.Nombre = "GENERADA").ToList
            If _leAux.Count > 0 Then
                oeRegistroDevolucion.IdEstado = _leAux(0).Id
            End If
            cboTipoOperacion.Enabled = True
            _opeint = 0
            MyBase.Nuevo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            Mostrar()
            oeRegistroDevolucion.TipoOperacion = "A"
            MostrarTabs(1, ficRegistroDevolucion, 1)
            If oeRegistroDevolucion.leDetalleRD.Count > 0 Then
                cboTipoOperacion.Enabled = False
            Else
                cboTipoOperacion.Enabled = True
            End If
            _opeint = 0
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Guardando()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeRegistroDevolucion.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficRegistroDevolucion, 2)
                            ' _ingresando_datos = False
                            Consultar(True)
                        Else
                            '_ingresando_datos = True
                            MostrarTabs(1, ficRegistroDevolucion, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficRegistroDevolucion, 2)
                        '_ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficRegistroDevolucion, 2)
                '_ingresando_datos = False
                Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GeneraDevolucion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficRegistroDevolucion.SelectedTab.Index
            Case 0
                If griRegistroDevolucion.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
       
    End Sub

    Private Sub frm_GeneraDevolucion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_GeneraDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fecFin.Value = Date.Now.Date
            fecInicio.Value = DateAdd(DateInterval.Day, -15, Date.Now.Date)
            CargarCombos()
            CargarRegistroDev(New List(Of e_RegistroDevolucion))
            CargarVidaNeu(New List(Of e_VidaNeumatico))
            MostrarTabs(0, ficRegistroDevolucion)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoOperacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoOperacion.ValueChanged
        Try
            If cboTipoOperacion.SelectedIndex > -1 Then
                If leVidaNeumatico.Count > 0 Then
                    If Operacion = "Nuevo" Then txtCodigo.Text = fn_ObtineCodigo()
                    Select Case cboTipoOperacion.SelectedIndex
                        Case 0
                            leVidaNeu = leVidaNeumatico.Where(Function(it) it.Ubicacion = "REENCAUCHE").ToList
                            Dim _leProv = leClienteProveedor.Where(Function(it) it.Proveedor = 1).ToList.OrderBy(Function(it) it.Nombre).ToList
                            LlenarCombo(cboClienteProveedor, "Nombre", _leProv, -1)
                            etiEmpresa.Text = "Proveedor:"
                        Case 1
                            leVidaNeu = leVidaNeumatico.Where(Function(it) it.Ubicacion = "ALMACEN" Or it.Ubicacion = "BAJA").ToList
                            Dim _leCli = leClienteProveedor.Where(Function(it) it.Cliente = 1).ToList.OrderBy(Function(it) it.Nombre).ToList
                            LlenarCombo(cboClienteProveedor, "Nombre", _leCli, -1)
                            etiEmpresa.Text = "Cliente:"
                    End Select
                    CargarVidaNeu(leVidaNeu)
                Else
                    Throw New Exception("No hay Neumaticos " & cboTipoOperacion.Text.Trim)
                End If
                oeRegistroDevolucion.Tipo = cboTipoOperacion.SelectedIndex + 1
            Else
                CargarVidaNeu(New List(Of e_VidaNeumatico))
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuVidaNeu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuVidaNeu.Opening
        If griVidaNeumatico.Rows.Count > 0 Then
            mnuVidaNeu.Items("tsmiExportar").Enabled = True
            Dim _Rows = griVidaNeumatico.Rows.Where(Function(it) it.Cells("Selec").Value = True).ToList
            If _Rows.Count > 0 Then
                mnuVidaNeu.Items("tsmiAgregar").Enabled = True
            Else
                mnuVidaNeu.Items("tsmiAgregar").Enabled = False
            End If
        Else
            mnuVidaNeu.Items("tsmiAgregar").Enabled = False
            mnuVidaNeu.Items("tsmiExportar").Enabled = False
        End If
    End Sub

    Private Sub mnuDetRD_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuDetRD.Opening
        If griDetalleRegDev.Rows.Count > 0 Then
            mnuDetRD.Items("tsmiExportar2").Enabled = True
            Dim _Rows = griDetalleRegDev.Rows.Where(Function(it) it.Cells("Selec").Value = True).ToList
            If _Rows.Count > 0 Then
                mnuDetRD.Items("tsmiQuitar").Enabled = True
            Else
                mnuDetRD.Items("tsmiQuitar").Enabled = False
            End If
        Else
            mnuDetRD.Items("tsmiQuitar").Enabled = False
            mnuDetRD.Items("tsmiExportar2").Enabled = False
        End If
    End Sub

    Private Sub griVidaNeumatico_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griVidaNeumatico.CellChange
        Try
            With griVidaNeumatico
                .UpdateData()
                If .ActiveRow.Index > -1 Then
                    If .ActiveRow.Cells("Selec").Value Then
                        .ActiveRow.CellAppearance.BackColor = Color.LightGreen
                    Else
                        .ActiveRow.CellAppearance.BackColor = Color.White
                    End If

                End If
            End With
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleRegDev_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleRegDev.CellChange
        Try
            With griDetalleRegDev
                .UpdateData()
                If .ActiveRow.Index > -1 Then
                    If .ActiveRow.Cells("Selec").Value Then
                        .ActiveRow.CellAppearance.BackColor = Color.LightCoral
                    Else
                        .ActiveRow.CellAppearance.BackColor = Color.White
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Try
            For Each Fil In griVidaNeumatico.Rows.Where(Function(it) it.Cells("Selec").Value = True).ToList
                Agregar(Fil)
            Next
            CargarDetalleRegDev(leDetalleRegDev)
            CargarVidaNeu(leVidaNeu)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Try
            For Each fil In griDetalleRegDev.Rows.Where(Function(it) it.Cells("Selec").Value = True).ToList
                Quitar(fil)
            Next
            CargarVidaNeu(leVidaNeu)
            CargarDetalleRegDev(leDetalleRegDev)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeRegistroDevolucion.Codigo = txtCodigo.Text
    End Sub

    Private Sub fecRegistro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecRegistro.ValueChanged
        oeRegistroDevolucion.Fecha = fecRegistro.Value
    End Sub

    Private Sub cboResponsable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResponsable.ValueChanged
        oeRegistroDevolucion.IdResponsable = cboResponsable.Value
    End Sub

    Private Sub cboClienteProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteProveedor.ValueChanged
        oeRegistroDevolucion.IdClienteProveedor = cboClienteProveedor.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeRegistroDevolucion.Descripcion = txtGlosa.Value
    End Sub

    Private Sub griRegistroDevolucion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griRegistroDevolucion.DoubleClick
        Try
            If griRegistroDevolucion.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuRegistroDevol_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuRegistroDevol.Opening
        Try
            mnuRegistroDevol.Items("tsmiEnviar").Enabled = False
            mnuRegistroDevol.Items("tsmiTerminar").Enabled = False
            If griRegistroDevolucion.Rows.Count > 0 Then
                mnuRegistroDevol.Items("tsmiEnviar").Enabled = True
                mnuRegistroDevol.Items("tsmiTerminar").Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEnviar.Click
        Try
            If griRegistroDevolucion.ActiveRow.Cells("Estado").Value = "GENERADA" Then
                Editar()
                _opeint = 1
            Else
                _opeint = 0
                Throw New Exception("Seleccione un Registro en estado GENERADA")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiTerminar.Click
        Try
            Try
                If griRegistroDevolucion.ActiveRow.Cells("Estado").Value = "EN PROCESO" Then
                    Editar()
                    _opeint = 2
                Else
                    _opeint = 0
                    Throw New Exception("Seleccione un Registro en estado EN PROCESO")
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportar2.Click
        Try
            Exportar_Excel(griDetalleRegDev)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportar.Click
        Try
            Exportar_Excel(griVidaNeumatico)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            cboTipoOperacion.Items.Clear()
            cboTipoOperacion.Items.Add("PARA REENCAUCHE")
            cboTipoOperacion.Items.Add("PARA VENTA")
            cboTipoOperacion.SelectedIndex = -1

            cboTipoBus.Items.Clear()
            cboTipoBus.Items.Add("< TODOS >")
            cboTipoBus.Items.Add("PARA REENCAUCHE")
            cboTipoBus.Items.Add("PARA VENTA")
            cboTipoBus.SelectedIndex = 0

            Dim _leEstBus As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = "< TODOS >"
            _leEstBus.Add(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "ORDEN DE ASIGNACION"
            leEstado = olEstado.Listar(oeEstado)
            _leEstBus.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstBus, 0)

            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.TipoOperacion = "G"
            'oeVidaNeumatico.EstadoActual = "DES"
            'oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Activo = True
            leVidaNeumatico = olVidaNeumatico.Listar(oeVidaNeumatico)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "P"
            leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))

            Dim _leTraAux = From le In leTrabajador _
                            Where le.Disponible = True _
                            Select le.Id, NombreCompleto = le.oePersona.NombreCompleto, le.oePersona.Dni

            LlenarCombo(cboResponsable, "NombreCompleto", _leTraAux.ToList, -1)

            ' If gUsuarioSGI.IdTrabajador.Trim <> "" Then cboResponsable.Value = gUsuarioSGI.IdTrabajador.Trim

            oeClienteProveedor = New e_ClienteProveedor
            oeClienteProveedor.TipoOperacion = ""
            oeClienteProveedor.Activo = True
            oeClienteProveedor.Cliente = -1
            oeClienteProveedor.Proveedor = -1
            oeClienteProveedor.Comisionista = -1
            leClienteProveedor = olClienteProveedor.Listar(oeClienteProveedor)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarVidaNeu(ByVal leVN As List(Of e_VidaNeumatico))
        Try
            With griVidaNeumatico

                .ResetDisplayLayout()

                Dim _leVNActivo = leVN.Where(Function(it) it.Activo = True).ToList

                .DataSource = _leVNActivo

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                For Each Col In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Selec" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDisenoNeu").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDiseño").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMarca").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMedida").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdNeumatico").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdProveedor").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoActualDolares").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoCascoDolares").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoDolares").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoDolxMilKm").Hidden = True
                .DisplayLayout.Bands(0).Columns("CostoSoles").Hidden = True
                .DisplayLayout.Bands(0).Columns("KmProyectado").Hidden = True
                .DisplayLayout.Bands(0).Columns("Ribete4").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Vigente").Hidden = True
                .DisplayLayout.Bands(0).Columns("EstadoActual").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaFinVida").Hidden = True
                .DisplayLayout.Bands(0).Columns("CocadaOriginal").Hidden = True
                .DisplayLayout.Bands(0).Columns("KmTotalNeumatico").Hidden = True

                .DisplayLayout.Bands(0).Columns("CodigoNeumatico").Header.Caption = "Neumatico"
                .DisplayLayout.Bands(0).Columns("Ribete1").Header.Caption = "R1"
                .DisplayLayout.Bands(0).Columns("Ribete2").Header.Caption = "R2"
                .DisplayLayout.Bands(0).Columns("Ribete3").Header.Caption = "R3"
                .DisplayLayout.Bands(0).Columns("Cocada").Header.Caption = "Cocada P."
                .DisplayLayout.Bands(0).Columns("CocadaMinima").Header.Caption = "Cocada M."

                .DisplayLayout.Bands(0).Columns("CodigoNeumatico").Width = 60
                .DisplayLayout.Bands(0).Columns("Condicion").Width = 55
                .DisplayLayout.Bands(0).Columns("Ribete1").Width = 35
                .DisplayLayout.Bands(0).Columns("Ribete2").Width = 35
                .DisplayLayout.Bands(0).Columns("Ribete3").Width = 35

                .DisplayLayout.Bands(0).Columns("Kilometraje").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Condicion").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("NroVida").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Cocada").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("CocadaMinima").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete1").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete2").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete3").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("Kilometraje").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Kilometraje").Format = "#,##0.00"

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                .Text = "NEUMATICOS " & cboTipoOperacion.Text & " (" & .Rows.Count & ")"

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeRegistroDevolucion = New e_RegistroDevolucion
            oeRegistroDevolucion.TipoOperacion = ""
            oeRegistroDevolucion.Activo = True
            oeRegistroDevolucion.IdEstado = cboEstadoBus.Value
            oeRegistroDevolucion.Tipo = cboTipoBus.SelectedIndex
            leRegistroDevolucion = olRegistroDevolucion.Listar(oeRegistroDevolucion)
            CargarRegistroDev(leRegistroDevolucion)
            If griRegistroDevolucion.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarRegistroDev(ByVal leRD As List(Of e_RegistroDevolucion))
        Try
            With griRegistroDevolucion
                .ResetDisplayLayout()
                .DataSource = leRD

                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdClienteProveedor").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdResponsable").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("ClienteProveedor").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Tipo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Responsable").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("ClienteProveedor").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 7

                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 300
                .DisplayLayout.Bands(0).Columns("Responsable").Width = 250
                .DisplayLayout.Bands(0).Columns("ClienteProveedor").Width = 250
                .DisplayLayout.Bands(0).Columns("Estado").Width = 150

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                .Text = "REGISTRO DEVOLUCION"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleRegDev(ByVal leDetalleRD As List(Of e_DetalleRegistroDevolucion))
        Try
            With griDetalleRegDev
                .ResetDisplayLayout()

                Dim _leAux = From le In leDetalleRD _
                             Where le.Activo = True _
                             Select le.Id, le.IdRegistroDevolucion, le.IdVidaNeumatico, le.oeVidaNeumatico.CodigoNeumatico, _
                             le.oeVidaNeumatico.Marca, le.oeVidaNeumatico.Medida, le.oeVidaNeumatico.Diseño, _
                             le.oeVidaNeumatico.Condicion, le.oeVidaNeumatico.NroVida, le.oeVidaNeumatico.FechaIngreso, _
                             le.oeVidaNeumatico.EstadoActual, le.oeVidaNeumatico.Ubicacion, le.oeVidaNeumatico.Kilometraje, _
                             le.oeVidaNeumatico.Ribete1, le.oeVidaNeumatico.Ribete2, le.oeVidaNeumatico.Ribete3, _
                             le.oeVidaNeumatico.Cocada, le.oeVidaNeumatico.CocadaOriginal, le.oeVidaNeumatico.CocadaMinima, _
                             le.oeVidaNeumatico.Proveedor, le.oeVidaNeumatico.IdDisenoNeu

                .DataSource = _leAux.ToList

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                For Each Col In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Selec" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdRegistroDevolucion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdVidaNeumatico").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDisenoNeu").Hidden = True
                .DisplayLayout.Bands(0).Columns("CocadaOriginal").Hidden = True
                .DisplayLayout.Bands(0).Columns("EstadoActual").Hidden = True

                .DisplayLayout.Bands(0).Columns("CodigoNeumatico").Header.Caption = "Neumatico"
                .DisplayLayout.Bands(0).Columns("Ribete1").Header.Caption = "R1"
                .DisplayLayout.Bands(0).Columns("Ribete2").Header.Caption = "R2"
                .DisplayLayout.Bands(0).Columns("Ribete3").Header.Caption = "R3"
                .DisplayLayout.Bands(0).Columns("Cocada").Header.Caption = "Cocada P."
                .DisplayLayout.Bands(0).Columns("CocadaMinima").Header.Caption = "Cocada M."

                .DisplayLayout.Bands(0).Columns("CodigoNeumatico").Width = 60
                .DisplayLayout.Bands(0).Columns("Condicion").Width = 55
                .DisplayLayout.Bands(0).Columns("Ribete1").Width = 35
                .DisplayLayout.Bands(0).Columns("Ribete2").Width = 35
                .DisplayLayout.Bands(0).Columns("Ribete3").Width = 35

                .DisplayLayout.Bands(0).Columns("Kilometraje").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Condicion").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("NroVida").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Cocada").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("CocadaMinima").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete1").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete2").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Ribete3").CellAppearance.TextHAlign = HAlign.Center

                .DisplayLayout.Bands(0).Columns("Kilometraje").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Kilometraje").Format = "#,##0.00"

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                .Text = "DETALLE DE REGISTRO DE DEVOLUCION" & " (" & .Rows.Count & ")"


            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()

        txtCodigo.Text = String.Empty
        fecRegistro.Value = Date.Now.Date
        cboTipoOperacion.SelectedIndex = -1
        cboResponsable.SelectedIndex = -1
        cboClienteProveedor.SelectedIndex = -1
        txtGlosa.Text = String.Empty
        leDetalleRegDev = New List(Of e_DetalleRegistroDevolucion)
        CargarDetalleRegDev(leDetalleRegDev)
        leVidaNeu = New List(Of e_VidaNeumatico)
        CargarVidaNeu(leVidaNeu)

    End Sub

    Private Function Guardando() As Boolean
        Try
            Select Case _opeint
                Case 0
                    If MessageBox.Show("¿Desea Guardar los Cambios Realizados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        oeRegistroDevolucion.leDetalleRD = leDetalleRegDev
                        oeRegistroDevolucion.UsuarioCreacion = gUsuarioSGI.Id
                        oeRegistroDevolucion.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olRegistroDevolucion.Guardar(oeRegistroDevolucion) Then
                            Consultar(True)
                            MostrarTabs(0, ficRegistroDevolucion)
                            mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
                        End If
                    End If
                Case 1
                    If MessageBox.Show("¿Desea Enviar el Registro Nº: " & txtCodigo.Text & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        oeRegistroDevolucion.leDetalleRD = leDetalleRegDev
                        oeRegistroDevolucion.UsuarioCreacion = gUsuarioSGI.Id
                        oeRegistroDevolucion.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olRegistroDevolucion.Guardar(oeRegistroDevolucion) Then
                            Consultar(True)
                            MostrarTabs(0, ficRegistroDevolucion)
                            mensajeEmergente.Confirmacion("El Registro se ha Enviado Correctamente", True)
                        End If
                    End If
                Case 2
                    If MessageBox.Show("¿Desea Terminar el Registro Nº: " & txtCodigo.Text & "?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        oeRegistroDevolucion.leDetalleRD = leDetalleRegDev
                        oeRegistroDevolucion.UsuarioCreacion = gUsuarioSGI.Id
                        oeRegistroDevolucion.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olRegistroDevolucion.Guardar(oeRegistroDevolucion) Then
                            Consultar(True)
                            MostrarTabs(0, ficRegistroDevolucion)
                            mensajeEmergente.Confirmacion("Los Datos se ha Terminado Correctamente", True)
                        End If
                    End If
            End Select
            
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ObtineCodigo() As String
        Try
            Dim _cod As String = ""
            Dim oeRegDev As New e_RegistroDevolucion
            oeRegDev.TipoOperacion = "U"
            oeRegDev.Tipo = cboTipoOperacion.SelectedIndex + 1
            oeRegDev = olRegistroDevolucion.Obtener(oeRegDev)
            If oeRegDev IsNot Nothing Then
                _cod = oeRegDev.Codigo
            End If
            Return _cod
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Agregar(ByVal filVidaNeu As UltraGridRow)
        Try
            oeDetalleRegDev = New e_DetalleRegistroDevolucion
            oeDetalleRegDev.IdVidaNeumatico = filVidaNeu.Cells("Id").Value
            If Not leDetalleRegDev.Contains(oeDetalleRegDev) Then
                oeDetalleRegDev.IdRegistroDevolucion = oeRegistroDevolucion.Id
                oeDetalleRegDev.IdVidaNeumatico = filVidaNeu.Cells("Id").Value
                oeDetalleRegDev.oeVidaNeumatico.CodigoNeumatico = filVidaNeu.Cells("CodigoNeumatico").Value
                oeDetalleRegDev.oeVidaNeumatico.Marca = filVidaNeu.Cells("Marca").Value
                oeDetalleRegDev.oeVidaNeumatico.Medida = filVidaNeu.Cells("Medida").Value
                oeDetalleRegDev.oeVidaNeumatico.Diseño = filVidaNeu.Cells("Diseño").Value
                oeDetalleRegDev.oeVidaNeumatico.NroVida = filVidaNeu.Cells("NroVida").Value
                oeDetalleRegDev.oeVidaNeumatico.Ribete1 = filVidaNeu.Cells("Ribete1").Value
                oeDetalleRegDev.oeVidaNeumatico.Ribete2 = filVidaNeu.Cells("Ribete2").Value
                oeDetalleRegDev.oeVidaNeumatico.Ribete3 = filVidaNeu.Cells("Ribete3").Value
                oeDetalleRegDev.oeVidaNeumatico.Condicion = filVidaNeu.Cells("Condicion").Value
                oeDetalleRegDev.oeVidaNeumatico.CocadaMinima = filVidaNeu.Cells("CocadaMinima").Value
                oeDetalleRegDev.oeVidaNeumatico.Cocada = filVidaNeu.Cells("Cocada").Value
                oeDetalleRegDev.oeVidaNeumatico.Kilometraje = filVidaNeu.Cells("Kilometraje").Value
                oeDetalleRegDev.oeVidaNeumatico.FechaIngreso = filVidaNeu.Cells("FechaIngreso").Value
                oeDetalleRegDev.oeVidaNeumatico.Proveedor = filVidaNeu.Cells("Proveedor").Value
                oeDetalleRegDev.oeVidaNeumatico.Ubicacion = filVidaNeu.Cells("Ubicacion").Value
                oeDetalleRegDev.oeVidaNeumatico.Activo = True
                leDetalleRegDev.Add(oeDetalleRegDev)
            Else
                oeDetalleRegDev = leDetalleRegDev.Item(leDetalleRegDev.IndexOf(oeDetalleRegDev))
                oeDetalleRegDev.Activo = True
            End If
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Id = filVidaNeu.Cells("Id").Value
            If leVidaNeu.Contains(oeVidaNeumatico) Then
                oeVidaNeumatico = leVidaNeu.Item(leVidaNeu.IndexOf(oeVidaNeumatico))
                oeVidaNeumatico.Activo = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Quitar(ByVal filDetalleRD As UltraGridRow)
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Id = filDetalleRD.Cells("IdVidaNeumatico").Value
            If Not leVidaNeu.Contains(oeVidaNeumatico) Then
                oeVidaNeumatico.CodigoNeumatico = filDetalleRD.Cells("CodigoNeumatico").Value
                oeVidaNeumatico.Marca = filDetalleRD.Cells("Marca").Value
                oeVidaNeumatico.Medida = filDetalleRD.Cells("Medida").Value
                oeVidaNeumatico.Diseño = filDetalleRD.Cells("Diseño").Value
                oeVidaNeumatico.NroVida = filDetalleRD.Cells("NroVida").Value
                oeVidaNeumatico.Ribete1 = filDetalleRD.Cells("Ribete1").Value
                oeVidaNeumatico.Ribete2 = filDetalleRD.Cells("Ribete2").Value
                oeVidaNeumatico.Ribete3 = filDetalleRD.Cells("Ribete3").Value
                oeVidaNeumatico.Condicion = filDetalleRD.Cells("Condicion").Value
                oeVidaNeumatico.CocadaMinima = filDetalleRD.Cells("CocadaMinima").Value
                oeVidaNeumatico.Cocada = filDetalleRD.Cells("Cocada").Value
                oeVidaNeumatico.Kilometraje = filDetalleRD.Cells("Kilometraje").Value
                oeVidaNeumatico.FechaIngreso = filDetalleRD.Cells("FechaIngreso").Value
                oeVidaNeumatico.Proveedor = filDetalleRD.Cells("Proveedor").Value
                oeVidaNeumatico.Ubicacion = filDetalleRD.Cells("Ubicacion").Value
                oeVidaNeumatico.Activo = True
                leVidaNeu.Add(oeVidaNeumatico)
            Else
                oeVidaNeumatico = leVidaNeu.Item(leVidaNeu.IndexOf(oeVidaNeumatico))
                oeVidaNeumatico.Activo = True
            End If
            oeDetalleRegDev = New e_DetalleRegistroDevolucion
            oeDetalleRegDev.IdVidaNeumatico = filDetalleRD.Cells("IdVidaNeumatico").Value
            If leDetalleRegDev.Contains(oeDetalleRegDev) Then
                oeDetalleRegDev = leDetalleRegDev.Item(leDetalleRegDev.IndexOf(oeDetalleRegDev))
                oeDetalleRegDev.Activo = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            oeRegistroDevolucion = New e_RegistroDevolucion
            oeRegistroDevolucion.TipoOperacion = String.Empty
            oeRegistroDevolucion.Id = griRegistroDevolucion.ActiveRow.Cells("Id").Value
            oeRegistroDevolucion = olRegistroDevolucion.Obtener(oeRegistroDevolucion)
            With oeRegistroDevolucion
                txtCodigo.Text = .Codigo
                fecRegistro.Value = .Fecha
                cboTipoOperacion.SelectedIndex = .Tipo - 1
                cboResponsable.Value = .IdResponsable
                cboClienteProveedor.Value = .IdClienteProveedor
                txtGlosa.Text = .Descripcion
                leDetalleRegDev = .leDetalleRD
                CargarDetalleRegDev(leDetalleRegDev)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class