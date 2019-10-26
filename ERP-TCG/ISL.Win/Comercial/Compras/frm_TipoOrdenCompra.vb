'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================


Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_TipoOrdenCompra
    Inherits frm_MenuPadre

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_TipoOrdenCompra = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoOrdenCompra()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"
    Private WithEvents oeTipoOrdenCompra As New e_TipoOrdenCompra

    Dim olTipoOrdenCompra As New l_TipoOrdenCompra
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If grid_ListaTipoOrdenCompra.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeTipoOrdenCompra.TipoOperacion = "I"
        MostrarTabs(1, tcTipoPago, 1)
        Inicializar()
        txtCodigo.Focus()
        MyBase.Nuevo()
        oeTipoOrdenCompra.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        MostrarTipoOrdenCompra()
        oeTipoOrdenCompra.TipoOperacion = "A"
        txtCodigo.Focus()
        MyBase.Editar()
        oeTipoOrdenCompra.Modificado = False
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTipoOrdenCompra() Then
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
            If oeTipoOrdenCompra.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoOrdenCompra() Then
                            MostrarTabs(0, tcTipoPago, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcTipoPago, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTipoPago, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcTipoPago, 2)
                _ingresando_datos = False
                MyBase.Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaTipoOrdenCompra
                If ValidarGrilla(grid_ListaTipoOrdenCompra, "TipoPago") Then
                    oeTipoOrdenCompra.Id = .ActiveRow.Cells("ID").Value
                    oeTipoOrdenCompra = olTipoOrdenCompra.Obtener(oeTipoOrdenCompra)
                    If oeTipoOrdenCompra.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Tipo  Mantenimiento: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTipoOrdenCompra.TipoOperacion = "E"
                            olTipoOrdenCompra.Eliminar(oeTipoOrdenCompra)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_ListaTipoOrdenCompra.Rows.Count = 0 Then Throw New Exception("No hay ningún tipo de órden de compra para exportar al Excel")
            Exportar_Excel(grid_ListaTipoOrdenCompra)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TipoOrdenCompra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TipoOrdenCompra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub oeTipoOrdenCompra_DatoCambiado() Handles oeTipoOrdenCompra.DatoCambiado
        oeTipoOrdenCompra.Modificado = True
    End Sub

    Private Sub frm_TipoOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcTipoPago)
        grid_ListaTipoOrdenCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        grid_ListaTipoOrdenCompra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoPago_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_ListaTipoOrdenCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_ListaTipoOrdenCompra.DoubleClick
        If grid_ListaTipoOrdenCompra.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeTipoOrdenCompra.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeTipoOrdenCompra.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeTipoOrdenCompra.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoOrdenCompra.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
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

    Private Sub grid_ListaTipoOrdenCompra_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        agrTotalTipoOrdenCompra.Text = "Total de tipos de Orden de Compra: " & e.Layout.Rows.Count
    End Sub

#End Region

#Region "Métodos"
    Private Function GuardarTipoOrdenCompra() As Boolean
        Try
            oeTipoOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTipoOrdenCompra.Guardar(oeTipoOrdenCompra) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcTipoPago, 2)
                Consultar(_Activo)
                grid_ListaTipoOrdenCompra.Focus()
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
    End Sub

    Private Sub MostrarTipoOrdenCompra()
        Try
            If grid_ListaTipoOrdenCompra.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoOrdenCompra.Id = grid_ListaTipoOrdenCompra.ActiveRow.Cells("Id").Value.ToString
                oeTipoOrdenCompra = olTipoOrdenCompra.Obtener(oeTipoOrdenCompra)
                txtId.Text = oeTipoOrdenCompra.Id
                txtCodigo.Text = oeTipoOrdenCompra.Codigo
                txtNombre.Text = oeTipoOrdenCompra.Nombre
                txtAbreviatura.Text = oeTipoOrdenCompra.Abreviatura
                verActivo.Checked = oeTipoOrdenCompra.Activo
                MostrarTabs(1, tcTipoPago, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTipoOrdenCompra = New e_TipoOrdenCompra
            With grid_ListaTipoOrdenCompra
                oeTipoOrdenCompra.Activo = Activo
                .DataSource = olTipoOrdenCompra.Listar(oeTipoOrdenCompra)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            End With

            'Ubica el cursor el el primer registro de la grilla
            If grid_ListaTipoOrdenCompra.Rows.Count > 0 Then
                grid_ListaTipoOrdenCompra.Focus()
                grid_ListaTipoOrdenCompra.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListaTipoOrdenCompra.Focus()
    End Sub


#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoOrdenCompra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaTipoOrdenCompra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaTipoOrdenCompra.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#End Region

End Class
