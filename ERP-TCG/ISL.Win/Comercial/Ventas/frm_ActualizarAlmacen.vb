Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_ActualizarAlmacen

    Public oeAlmMaterial As e_MaterialAlmacen
    Private loAlmMaterial As List(Of e_MaterialAlmacen)
    Private olAlmMaterial As l_MaterialAlmacen
    Private IdMaterial, CodigoMat, Material As String
    Private Cantidad As Double

    'Sub New()
    '    ' Llamada necesaria para el diseñador.
    '    InitializeComponent()
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    'End Sub

    Sub New(ls_IdMaterial As String, ls_CodMaterial As String, ls_Material As String, ln_Cantidad As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        IdMaterial = ls_IdMaterial
        CodigoMat = ls_CodMaterial
        Material = ls_Material
        Cantidad = ln_Cantidad
    End Sub

    Private Sub frm_ActualizarLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCodigo.Text = CodigoMat
            txtMaterial.Text = Material
            num_Cantidad.Value = Cantidad
            mt_ListarLotes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mt_ListarLotes()
        Try
            oeAlmMaterial = New e_MaterialAlmacen
            olAlmMaterial = New l_MaterialAlmacen
            oeAlmMaterial.TipoOperacion = "A"
            oeAlmMaterial.IdMaterial = IdMaterial
            loAlmMaterial = olAlmMaterial.Listar_(oeAlmMaterial)
            griAlmMaterial.DataSource = loAlmMaterial.Where(Function(i) i.StockActual > 0).ToList
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If griAlmMaterial.Selected.Rows.Count = 0 Then Throw New Exception("Seleccione Almacen")
            oeAlmMaterial = griAlmMaterial.ActiveRow.ListObject
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub griAlmMaterial_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griAlmMaterial.DoubleClickRow
        btnAceptar.PerformClick()
    End Sub

    Private Sub griAlmMaterial_KeyDown(sender As Object, e As KeyEventArgs) Handles griAlmMaterial.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub

End Class