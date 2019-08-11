Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Seleccionar

#Region "Declaracion de Variables"

    Private oeGSancion As New e_GrupoSancion, olGSancion As New l_GrupoSancion, leGSancion As New List(Of e_GrupoSancion)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area)
    Private sIdEstado As String = ""

#End Region

#Region "Instancia"

    Public Sub New(ls_Tipo As String, Optional ls_Estado As String = "", Optional ls_IdArea As String = "")

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        CargarCombos()

        If leEstado.Count > 0 AndAlso ls_Estado.Trim <> "" Then
            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = ls_Estado).ToList
            If _leEstAux.Count > 0 Then sIdEstado = _leEstAux(0).Id
        End If

        Select Case ls_Tipo
            Case "GSancion"
                oeGSancion = New e_GrupoSancion
                oeGSancion.TipoOperacion = ""
                oeGSancion.IdEstado = sIdEstado
                leGSancion = olGSancion.Listar(oeGSancion)
        End Select

        'If gUsuarioSGI.Controlado = 1 Then
        cboArea.Value = ls_IdArea
        cboArea.ReadOnly = True
        Dim _leGrupo = leGSancion.Where(Function(it) it.IdArea = ls_IdArea).ToList
        If _leGrupo.Count > 0 Then LlenarCombo(cboGrupo, "Codigo", _leGrupo, -1)
        ' Else
        ' cboArea.ReadOnly = False
        ' End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Selecionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub cboArea_ValueChanged(sender As Object, e As EventArgs) Handles cboArea.ValueChanged
        If cboArea.SelectedIndex > -1 Then
            Dim _leGrupo = leGSancion.Where(Function(it) it.IdArea = cboArea.Value).ToList
            If _leGrupo.Count > 0 Then LlenarCombo(cboGrupo, "Codigo", _leGrupo, -1)
        End If
    End Sub

    Private Sub cboGrupo_ValueChanged(sender As Object, e As EventArgs) Handles cboGrupo.ValueChanged
        ls_IdGSancion = IIf(cboGrupo.SelectedIndex > -1, cboGrupo.Value, "")
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oeEstado = New e_Estado
            oeEstado.Activo = True
            leEstado = olEstado.Listar(oeEstado)

            oeArea = New e_Area
            oeArea.TipoOperacion = ""
            oeArea.IndSector = -1
            oeArea.Activo = True
            leArea = olArea.Listar(oeArea)
            LlenarCombo(cboArea, "Nombre", leArea, -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class