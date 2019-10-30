'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports System.Text
Imports Infragistics.Win.UltraWinEditors

Public Class frm_Peaje
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_Peaje = Nothing
    'Instancia unica de Formulario
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Peaje
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private Operacion As String = ""
    Private oePeaje As e_Peaje
    Private loPeaje As New List(Of e_Peaje)
    Private olPeaje As New l_Peaje
    Private oePeajeTarifa As e_PeajeTarifa
    Private loPeajeTarifa As New List(Of e_PeajeTarifa)
    Private olPeajeTarifa As New l_PeajeTarifa
    Private cadValidacion As StringBuilder

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Operacion = "Listado"
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            mt_InicializarControles()
            'Inicializo objeto principal
            oePeaje = New e_Peaje
            'Ingreso el tipo de operacion
            Operacion = "Nuevo"
            'Cambio de Pestaña
            MostrarTabs(1, FicPeaje, 1)
            'Control Botones generales
            mt_ControlBotoneria()
            'Foco primer control
            txtCodigo.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If fc_ValidarFilaSeleccionada(griPeaje) Then
                mt_Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If fc_ValidarFilaSeleccionada(griPeaje) AndAlso fc_ValidarEliminar() AndAlso _
                MessageBox.Show("Desea eliminar el registro seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oePeaje = New e_Peaje
                oePeaje.Id = griPeaje.ActiveRow.Cells("Id").Value.ToString().Trim()
                oePeaje = olPeaje.Obtener(oePeaje, True)
                If olPeaje.Eliminar(oePeaje, True) Then
                    MessageBox.Show("Registro eliminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loPeaje.Remove(griPeaje.ActiveRow.ListObject)
                    griPeaje.DataBind()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_ValidarRegistro() Then
                mt_RecolectarDatos()
                oePeaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olPeaje.Guardar(oePeaje) Then
                    MessageBox.Show("Registro guardado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTabs(0, FicPeaje, 0)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("Desea cancelar la operacion?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, FicPeaje, 0)
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ExportarGrillaAExcel(griPeaje, Me.Text)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarFormulario()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControlBoton()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspTarifa_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspTarifa.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarTarifa.Name
                    mt_AgregarTarifa()
                Case tsbQuitarTarifa.Name
                    mt_QuitarTarifa()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarifaPeaje_BeforeCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griTarifaPeaje.BeforeCellUpdate
        Try
            If e.Cell.Row.Index <> -1 Then
                Select Case e.Cell.Column.Key
                    Case "CantidadEjes", "Monto"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarifaPeaje_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTarifaPeaje.CellChange
        Try
            griTarifaPeaje.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPeaje_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griPeaje.DoubleClickRow
        Try
            If e.Row.Index >= 0 Then
                Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Peaje_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case FicPeaje.SelectedTab.Index
                Case tabMantPeaje.Tab.Index
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                        Case Keys.Insert
                            tsbAgregarTarifa.PerformClick()
                        Case Keys.Delete
                            tsbQuitarTarifa.PerformClick()
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNombreFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombreFiltro.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uneMontoTarifa_ValidationError(sender As Object, e As ValidationErrorEventArgs) Handles uneMontoTarifa.ValidationError
        CType(sender, UltraNumericEditor).Value = 0
        e.RetainFocus = False
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarControles()
        Try
            txtCodigo.Text = ""
            txtNombre.Text = ""
            chkPagoIda.Checked = False
            chkPagoRetorno.Checked = False
            cmbEmpresa.Text = ""
            cmbEmpresa.SelectedIndex = -1
            cmbLugar.Text = ""
            cmbLugar.SelectedIndex = -1
            txtUbicacion.Text = ""
            txtGlosa.Text = ""
            'Inicializa Controles Tarifa
            mt_InicializarTarifaPeaje()
            loPeajeTarifa.Clear()
            griTarifaPeaje.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarTarifaPeaje()
        Try
            cmbTipoVehiculoTarifa.Text = ""
            cmbTipoVehiculoTarifa.SelectedIndex = -1
            uneMontoTarifa.Value = 0D
            txtGlosaTarifa.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oePeaje = New e_Peaje
            With oePeaje
                .TipoOperacion = "GEN"
                .Nombre = txtNombreFiltro.Text.Trim()
                .IdEmpresa = cmbEmpresaFiltro.Value.ToString()
            End With
            loPeaje.Clear()
            loPeaje.AddRange(olPeaje.Listar(oePeaje))
            griPeaje.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarFormulario()
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            FicPeaje.Tabs(tabMantPeaje.Tab.Index).Enabled = False
            griPeaje.DataSource = loPeaje
            griTarifaPeaje.DataSource = loPeajeTarifa
            'Llenar Combo Empresa
            Dim olEmpresa As New l_Empresa
            Dim loEmpresa As New List(Of e_Empresa)
            Dim oeTipoEmpresa As New e_TipoEmpresa
            oeTipoEmpresa.Codigo = "000008"
            Dim olTipoEmpresa As New l_TipoEmpresa
            Dim loTipoEmpresa As New List(Of e_TipoEmpresa)
            loTipoEmpresa.AddRange(olTipoEmpresa.Listar(oeTipoEmpresa))
            If loTipoEmpresa.Count > 0 Then
                loEmpresa.Add(New e_Empresa With {.Id = gs_IdEmpresaSistema.Trim, .Nombre = gs_TxtEmpresaSistema.Trim})
                loEmpresa.AddRange(
                    olEmpresa.Listar(New e_Empresa With {.IdTipoEmpresa = loTipoEmpresa(0).Id})
                    )
            End If
            Dim oeEmpresa As New e_Empresa
            With oeEmpresa
                .Id = ""
                .Nombre = "TODOS"
            End With
            loEmpresa.Insert(0, oeEmpresa)
            ComboNormal(cmbEmpresa, loEmpresa.Where(Function(x) x.Id <> "").ToList, -1)
            ComboNormal(cmbEmpresaFiltro, loEmpresa, 0)
            'Llenar Combo lugar
            Dim olLugar As New l_Lugar
            Dim loLugar As New List(Of e_Lugar)
            loLugar.AddRange(olLugar.Listar(New e_Lugar()))
            ComboNormal(cmbLugar, loLugar, -1)
            'Llenar Combo Tipo Vehiculo Tarifa
            LlenaComboConfigurable(cmbTipoVehiculoTarifa, "TipoVehiculoTarifa", "ID", "NOMBRE", -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            Select Case FicPeaje.SelectedTab.Index
                Case 0
                    If griPeaje.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)

                    Else
                        ControlBoton(1, 1)
                    End If
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Editar()
        Try
            Operacion = "Editar"
            mt_InicializarControles()
            oePeaje = New e_Peaje
            With oePeaje
                .TipoOperacion = "GEN"
                .Id = griPeaje.ActiveRow.Cells("Id").Value.ToString()
            End With
            oePeaje = olPeaje.Obtener(oePeaje, True)
            oePeaje.TipoOperacion = "A"
            mt_CargarPeaje()
            MostrarTabs(1, FicPeaje, 1)
            mt_ControlBotoneria()
            txtCodigo.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarPeaje()
        Try
            With oePeaje
                txtCodigo.Text = .Codigo
                txtNombre.Text = .Nombre
                chkPagoIda.Checked = .IndPagoIda
                chkPagoRetorno.Checked = .IndPagoRetorno
                cmbEmpresa.Value = .IdEmpresa
                cmbLugar.Value = .IdLugar
                txtUbicacion.Text = .Ubicacion
                txtGlosa.Text = .Glosa
                loPeajeTarifa.AddRange(.ListaTarifa)
                griTarifaPeaje.DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_RecolectarDatos()
        Try
            With oePeaje
                .TipoOperacion = "I"
                .Codigo = txtCodigo.Text.Trim()
                .Nombre = txtNombre.Text.Trim()
                .IndPagoIda = chkPagoIda.Checked
                .IndPagoRetorno = chkPagoRetorno.Checked
                .IdEmpresa = cmbEmpresa.Value.ToString()
                .IdLugar = cmbLugar.Value.ToString()
                .Ubicacion = txtUbicacion.Text.Trim()
                .Glosa = txtGlosa.Text.Trim()
                .UsuarioCreacion = gUsuarioSGI.Id
                .ListaTarifa.Clear()
                .ListaTarifa = loPeajeTarifa
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Tarifa
    Private Sub mt_AgregarTarifa()
        Try
            If fc_ValidarAgregarTarifa() Then
                oePeajeTarifa = New e_PeajeTarifa
                With oePeajeTarifa
                    .IdTipoVehiculoTarifa = cmbTipoVehiculoTarifa.Value
                    .Monto = Convert.ToDecimal(uneMontoTarifa.Value)
                    .Glosa = txtGlosaTarifa.Text.Trim()
                End With
                loPeajeTarifa.Add(oePeajeTarifa)
                griTarifaPeaje.DataBind()
                mt_InicializarTarifaPeaje()
                cmbTipoVehiculoTarifa.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarTarifa()
        Try
            If fc_ValidarFilaSeleccionada(griTarifaPeaje) Then
                If Not String.IsNullOrEmpty(griTarifaPeaje.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                    loPeajeTarifa(loPeajeTarifa.IndexOf(griTarifaPeaje.ActiveRow.ListObject)).TipoOperacion = "E"
                    griTarifaPeaje.ActiveRow.Hidden = True
                Else
                    loPeajeTarifa.Remove(griTarifaPeaje.ActiveRow.ListObject)
                End If
                griTarifaPeaje.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Function fc_ValidarFilaSeleccionada(Grilla As Infragistics.Win.UltraWinGrid.UltraGrid) As Boolean
        Try
            If Not (Grilla.Selected.Rows.Count > 0 AndAlso Grilla.ActiveRow.Index >= 0) Then
                MessageBox.Show("Seleccione Fila", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarRegistro() As Boolean
        Try
            cadValidacion = New StringBuilder
            Dim control As Control = Nothing
            If String.IsNullOrEmpty(txtNombre.Text.Trim()) Then
                cadValidacion.Append("Ingrese nombre de Peaje").AppendLine()
                If control Is Nothing Then
                    control = txtNombre
                End If
            End If
            If cmbEmpresa.SelectedIndex < 0 Then
                cadValidacion.Append("Ingrese Empresa").AppendLine()
                If control Is Nothing Then
                    control = cmbEmpresa
                End If
            End If
            If cmbLugar.SelectedIndex < 0 Then
                cadValidacion.Append("Ingrese Lugar").AppendLine()
                If control Is Nothing Then
                    control = cmbLugar
                End If
            End If
            If Not String.IsNullOrEmpty(cadValidacion.ToString.Trim()) Then
                MessageBox.Show(cadValidacion.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                control.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarEliminar() As Boolean
        Try
            Dim oeRutaPeaje As New e_RutaPeaje
            With oeRutaPeaje
                .TipoOperacion = "GEN"
                .IdPeaje = griPeaje.ActiveRow.Cells("Id").Value.ToString()
            End With
            Dim loRutaPeaje As New List(Of e_RutaPeaje)
            Dim olRutaPeaje As New l_RutaPeaje
            loRutaPeaje.AddRange(olRutaPeaje.Listar(oeRutaPeaje))
            If loRutaPeaje.Count > 0 Then
                MessageBox.Show("No se puede eliminar el peaje seleccionado" & Environment.NewLine &
                                "Porque esta registrado en una Ruta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Tarifa
    Private Function fc_ValidarAgregarTarifa() As Boolean
        Try
            cadValidacion = New StringBuilder
            Dim control As Control
            If cmbTipoVehiculoTarifa.SelectedIndex = -1 Then
                cadValidacion.Append("* Seleccione nombre de tarifa").AppendLine()
                If control Is Nothing Then
                    control = cmbTipoVehiculoTarifa
                End If
            End If
            If uneMontoTarifa.Value <= 0 Then
                cadValidacion.Append("* Ingrese monto de tarifa").AppendLine()
                If control Is Nothing Then
                    control = uneMontoTarifa
                End If
            End If
            If Not String.IsNullOrEmpty(cadValidacion.ToString.Trim()) Then
                MessageBox.Show(cadValidacion.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                control.Focus()
                Return False
            End If
            If loPeajeTarifa.Where(Function(x) x.TipoOperacion <> "E" And x.IdTipoVehiculoTarifa = cmbTipoVehiculoTarifa.Value).Count > 0 Then
                MessageBox.Show("El tipo de tarifa a agregar ya esta agregada a la lista", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class