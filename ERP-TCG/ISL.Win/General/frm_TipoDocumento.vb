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

Public Class frm_TipoDocumento

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_TipoDocumento = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoDocumento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeTipoDocumento As New e_TipoDocumento
    Dim olTipoDocumento As New l_TipoDocumento
    Dim _ingresando_datos As Boolean = False
    Dim leDocumentoImpuesto As New List(Of e_DocumentoImpuesto)
    Dim oeImpuesto As New e_Impuesto
    Dim olImpuesto As New l_Impuesto
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If grid_ListaTipoDocumento.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeTipoDocumento.TipoOperacion = "I"
        MostrarTabs(1, tcTipoPago, 1)
        Inicializar()
        txtCodigo.Focus()
        agrListaImpuesto.Expanded = True
        MyBase.Nuevo()
        oeTipoDocumento.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarTipoDocumento()
            oeTipoDocumento.TipoOperacion = "A"
            txtCodigo.Focus()
            agrListaImpuesto.Expanded = False
            MyBase.Editar()
            oeTipoDocumento.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTipoDocumento() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTipoPago, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoDocumento() Then
                            MostrarTabs(0, tcTipoPago, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcTipoPago, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTipoPago, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcTipoPago, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaTipoDocumento
                If ValidarGrilla(grid_ListaTipoDocumento, "TipoPago") Then
                    oeTipoDocumento.Id = .ActiveRow.Cells("ID").Value
                    oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
                    If oeTipoDocumento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Tipo  Mantenimiento: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTipoDocumento.TipoOperacion = "E"
                            olTipoDocumento.Eliminar(oeTipoDocumento)
                            Consultar(_Activo)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
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

            If grid_ListaTipoDocumento.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaTipoDocumento)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TipoPago_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TipoPago_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub oeTipoDocumento_DatoCambiado() Handles oeTipoDocumento.DatoCambiado
        oeTipoDocumento.Modificado = True
    End Sub

    Private Sub frm_TipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcTipoPago)
        grid_ListaTipoDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        grid_ListaTipoDocumento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoPago_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_ListaTipoDocumento_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_ListaTipoDocumento.DoubleClick
        If grid_ListaTipoDocumento.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeTipoDocumento.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeTipoDocumento.Nombre = txtNombre.Text.Trim

        If Not String.IsNullOrEmpty(oeTipoDocumento.Nombre) Then
            Dim oeTipoDocumento2 As New e_TipoDocumento
            Dim olTipoDocumento2 As New l_TipoDocumento
            oeTipoDocumento2.TipoOperacion = "L"
            oeTipoDocumento2.Activo = True
            oeTipoDocumento2.Nombre = txtNombre.Text.Trim
            griTiposDocumentosRegistrados.DataSource = olTipoDocumento2.Listar(oeTipoDocumento2)

            With griTiposDocumentosRegistrados
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 40
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 1000
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 40
            End With
        Else
            griTiposDocumentosRegistrados.DataSource = Nothing
        End If

    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeTipoDocumento.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoDocumento.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub frm_TipoPago_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoPago_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub verCompras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub verVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub verTesoreria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaTipoDocumento_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_ListaTipoDocumento.InitializeLayout
        agrTotalTipoDocumento.Text = "Total de tipos de documento: " & e.Layout.Rows.Count
    End Sub

    Private Sub griListaImpuesto_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaImpuesto.CellChange
        Try
            With griListaImpuesto
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeDocumentoImpuesto As New e_DocumentoImpuesto
                    leDocumentoImpuesto = oeTipoDocumento.leDocumentoImpuesto

                    oeDocumentoImpuesto.IdImpuesto = .ActiveRow.Cells("Id").Value
                    oeDocumentoImpuesto.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If Not leDocumentoImpuesto.Contains(oeDocumentoImpuesto) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeDocumentoImpuesto.IdTipoDocumento = oeTipoDocumento.Id
                            oeDocumentoImpuesto.Nombre = .ActiveRow.Cells("Nombre").Value
                            oeDocumentoImpuesto.Abreviatura = .ActiveRow.Cells("Abreviatura").Value
                            oeDocumentoImpuesto.Porcentaje = .ActiveRow.Cells("Porcentaje").Value
                            oeDocumentoImpuesto.UsuarioCreacion = gUsuarioSGI.Id
                            If griImpuesto.Rows.Count < 1 Then
                                LlenarImpuesto(leDocumentoImpuesto)
                                'oeOcupacionTrabajador.Principal = True
                            End If

                            leDocumentoImpuesto.Add(oeDocumentoImpuesto)

                        End If
                    Else
                        oeDocumentoImpuesto = leDocumentoImpuesto.Item(leDocumentoImpuesto.IndexOf(oeDocumentoImpuesto))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeDocumentoImpuesto.TipoOperacion = "E" Then
                                oeDocumentoImpuesto.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griImpuesto.Rows
                                    If fila.Cells("IdImpuesto").Value = oeDocumentoImpuesto.IdImpuesto Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("El Turno: " & .ActiveRow.Cells("IdImpuesto").Value & " ya esta Asignada")
                            End If

                        Else
                            If oeDocumentoImpuesto.Id <> "" Then
                                oeDocumentoImpuesto.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griImpuesto.Rows
                                    If fila.Cells("IdImpuesto").Value = oeDocumentoImpuesto.IdImpuesto Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                leDocumentoImpuesto.Remove(oeDocumentoImpuesto)
                            End If

                        End If

                    End If

                End If

            End With
            griImpuesto.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Function GuardarTipoDocumento() As Boolean
        Try
            oeTipoDocumento.leDocumentoImpuesto = leDocumentoImpuesto
            oeTipoDocumento.PrefijoID = gs_IdEmpresaSistema '@0001
            If olTipoDocumento.Guardar(oeTipoDocumento) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcTipoPago, 2)
                Consultar(_Activo)
                grid_ListaTipoDocumento.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        LlenarImpuesto(New List(Of e_DocumentoImpuesto))
        ListarImpuesto()
    End Sub

    Private Sub MostrarTipoDocumento()
        Try
            If grid_ListaTipoDocumento.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoDocumento.Id = grid_ListaTipoDocumento.ActiveRow.Cells("Id").Value.ToString
                oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
                txtId.Text = oeTipoDocumento.Id
                txtCodigo.Text = oeTipoDocumento.Codigo
                txtNombre.Text = oeTipoDocumento.Nombre
                txtAbreviatura.Text = oeTipoDocumento.Abreviatura
                verActivo.Checked = oeTipoDocumento.Activo
                MostrarImpuesto()
                MostrarTabs(1, tcTipoPago, 1)
                ficDetalle.Tabs(0).Selected = True
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTipoDocumento = New e_TipoDocumento
            With grid_ListaTipoDocumento
                oeTipoDocumento.Activo = Activo
                oeTipoDocumento.TipoOperacion = ""
                .DataSource = olTipoDocumento.Listar(oeTipoDocumento)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 40
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 1000
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 40

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListaTipoDocumento.Focus()
    End Sub

    Private Sub ListarImpuesto()
        Try

            oeImpuesto = New e_Impuesto
            olImpuesto = New l_Impuesto

            With griListaImpuesto

                .ResetDisplayLayout()
                .DataSource = olImpuesto.Listar(oeImpuesto)

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaFin").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaInicio").Hidden = True

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 70
                .DisplayLayout.Bands(0).Columns("Porcentaje").Width = 70

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Abreviatura").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Porcentaje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarImpuesto(ByVal leDocumentoImpuesto As List(Of e_DocumentoImpuesto))
        Try

            With griImpuesto

                .ResetDisplayLayout()

                '.DataSource = oeUsuario.leTurnoUsuario
                .DataSource = leDocumentoImpuesto
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdImpuesto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 70
                .DisplayLayout.Bands(0).Columns("Porcentaje").Width = 70

                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Abreviatura").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Porcentaje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarImpuesto()
        Try
            If oeTipoDocumento.leDocumentoImpuesto.Count > 0 Then
                LlenarImpuesto(oeTipoDocumento.leDocumentoImpuesto)
                For Each oe As e_DocumentoImpuesto In oeTipoDocumento.leDocumentoImpuesto
                    For Each Fila As UltraWinGrid.UltraGridRow In griListaImpuesto.Rows
                        If Fila.Cells("Id").Value = oe.IdImpuesto And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griListaImpuesto.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoDocumento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoDocumento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaTipoDocumento.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#End Region

   
End Class
