Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_CtaCte_ProAdq
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_CtaCte_ProAdq = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_CtaCte_ProAdq()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Variables"

    Private oeCtaCte As e_CtaCte_ProAdq
    Private olCtaCte As l_CtaCte_ProAdq
    Private loCtaCte As List(Of e_CtaCte_ProAdq)

    Private oeProveedor As e_Proveedor
    Private olProveedor As l_Proveedor
    Private loProveedor As List(Of e_Proveedor)

    Private oeCliente As e_Cliente
    Private olCliente As l_Cliente
    Private loCliente As List(Of e_Cliente)

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            SeleccionTabs(1, ficCtaCte)
            Inicializar()
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            If griCtaCte_ProAdq.Selected.Rows.Count > 0 Then
                Mostrar()
                SeleccionTabs(1, ficCtaCte)
                cboProAdq.Focus()
            End If
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            Tiempo1.Enabled = True
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCtaCte() Then
                mensajeEmergente.Confirmacion("Datos Guardados Correctamente", True)
                ListaCtaCte()
                SeleccionTabs(0, ficCtaCte)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarCtaCte() Then
                        SeleccionTabs(0, ficCtaCte)
                        Consultar(True)
                    End If
                Case Windows.Forms.DialogResult.No
                    SeleccionTabs(0, ficCtaCte)
            End Select
            ControlBotones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficCtaCte.Tabs(0).Selected AndAlso griCtaCte_ProAdq.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griCtaCte_ProAdq)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Public Overrides Sub Eliminar()
    '    Try

    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CtaCte_ProAdq_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBotones()
    End Sub

    Private Sub frm_CtaCte_ProAdq_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_CtaCte_ProAdq_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_CtaCte_ProAdq_Load(sender As Object, e As EventArgs) Handles Me.Load
        olCtaCte = New l_CtaCte_ProAdq
        olCliente = New l_Cliente
        olProveedor = New l_Proveedor
    End Sub

    Private Sub rb_Proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Proveedor.CheckedChanged
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            cboProAdq.DataSource = Nothing
            cboProAdq.Text = String.Empty
            If rb_Proveedor.Checked Then
                loProveedor = New List(Of e_Proveedor)
                oeProveedor = New e_Proveedor
                oeProveedor.TipoOperacion = "5"
                cboProAdq.Value = Nothing
                loProveedor.AddRange(olProveedor.Listar(oeProveedor))
                With cboProAdq
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = loProveedor
                End With
                InicializarComboPro()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub rb_Adquiriente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Adquiriente.CheckedChanged
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            cboProAdq.DataSource = Nothing
            cboProAdq.Text = String.Empty
            If rb_Adquiriente.Checked Then
                oeCliente = New e_Cliente
                loCliente = New List(Of e_Cliente)
                oeCliente.Activo = True
                oeCliente.TipoPersonaEmpresa = 2
                loCliente.AddRange(olCliente.Listar(oeCliente))
                With cboProAdq
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = loCliente
                End With
                InicializarComboAdq()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub griCtaCte_ProAdq_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griCtaCte_ProAdq.DoubleClickRow
        Editar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        oeCtaCte = New e_CtaCte_ProAdq
        cboProAdq.Text = String.Empty
        cboProAdq.DataSource = Nothing
        rb_Adquiriente.Checked = False
        rb_Proveedor.Checked = False
        txtCuenta.Text = String.Empty
    End Sub

    Private Sub ControlBotones()
        Select Case ficCtaCte.SelectedTab.Index
            Case 0
                If griCtaCte_ProAdq.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                 ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub Listar()
        Try
            oeCtaCte = New e_CtaCte_ProAdq
            loCtaCte = olCtaCte.Listar(oeCtaCte)
            griCtaCte_ProAdq.DataSource = loCtaCte.OrderBy(Function(i) i.Empresa).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboPro()
        Try
            Me.cboProAdq.ValueMember = "Id"
            Me.cboProAdq.DisplayMember = "Nombre"
            With cboProAdq.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("Nombre").Header.Caption = "Proveedor"
                .Columns("NroDocumento").Header.Caption = "RUC/DNI"
                .Columns("NroDocumento").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("NroDocumento").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboAdq()
        Try
            Me.cboProAdq.ValueMember = "Id"
            Me.cboProAdq.DisplayMember = "Nombre"
            With cboProAdq.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("Comisionista").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("oeEmpresa").Hidden = True
                .Columns("oepersona").Hidden = True
                .Columns("Nombre").Header.Caption = "Cliente"
                .Columns("Dni").Header.Caption = "RUC/DNI"
                .Columns("Dni").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("Dni").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarCtaCte() As Boolean
        Try
            If txtCuenta.Text.Trim = "" Then Throw New Exception("Escriba la Cta Cte")
            oeCtaCte.TipoOperacion = IIf(Operacion = "Nuevo", "I", "A")
            oeCtaCte.IdClienteProveedor = cboProAdq.Value
            oeCtaCte.IndCliPro = IIf(rb_Proveedor.Checked, 0, 1)
            oeCtaCte.UsuarioCreacion = gUsuarioSGI.Id
            oeCtaCte.Empresa = cboProAdq.Text
            oeCtaCte.Cuenta = FormatoDocumento(txtCuenta.Text, 11)
            If olCtaCte.Guardar(oeCtaCte) Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        Try
            oeCtaCte.Id = griCtaCte_ProAdq.ActiveRow.Cells("Id").Value
            oeCtaCte = olCtaCte.Obtener(oeCtaCte)
            If oeCtaCte.IndCliPro = 0 Then
                rb_Proveedor.Checked = True
            Else
                rb_Adquiriente.Checked = True
            End If
            cboProAdq.Value = oeCtaCte.IdClienteProveedor
            txtCuenta.Text = oeCtaCte.Cuenta
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class