Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Material_DisenoNeu

#Region "Instancia"

    Sub New(ByVal oeMDN As e_Material_DisenoNeu, ByVal TipOpe As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oeMatDisNeu = New e_Material_DisenoNeu
        oeMatDisNeu.Material = oeMDN.Material
        oeMatDisNeu.IdDisenoNeumatico = oeMDN.IdDisenoNeumatico
        oeMatDisNeu.TipoBanda = oeMDN.TipoBanda
        oeMatDisNeu.EstadoNeu = oeMDN.EstadoNeu
        'Select oeMDN.EstadoNeu
        _Ope = TipOpe
    End Sub

#End Region

#Region "Declaracion de variables"

    Private oeMarcaNeu As New e_Marca
    Private olMarcaNeu As New l_Marca
    Private leMarcaNeu As New List(Of e_Marca)

    Private oeMedidaNeu As New e_MedidaNeumatico
    Private olMedidaNeu As New l_MedidaNeumatico
    Private leMedidaNeu As New List(Of e_MedidaNeumatico)

    Private oeDisenoNeu As New e_DiseñoNeumatico
    Private olDisenoNeu As New l_DiseñoNeumatico
    Private leDisenoNeu As New List(Of e_DiseñoNeumatico)

    Private oeMatDisNeu As New e_Material_DisenoNeu

    Private _Ope As Integer = 0
    Private _NombreMat As String = ""
    Private _Estado As String


#End Region

#Region "Eventos"

    Private Sub frm_Material_DisenoNeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombo()
            cboMedida.Enabled = False
            cboDiseño.Enabled = False
            cboTipoBanda.Enabled = False
            verCambia.Checked = False
            If _Ope = 1 Then
                ' MostrarTabs(0, ficDisenoNeu)
                Me.Height = 233
                Dim _leDN = leDisenoNeu.Where(Function(it) it.Id = oeMatDisNeu.IdDisenoNeumatico).ToList
                If _leDN.Count > 0 Then
                    cboMedida.Enabled = True
                    cboDiseño.Enabled = True
                    cboMarcaNeu.Value = _leDN(0).IdMarca
                    cboMedida.Value = _leDN(0).IdMedidaNeumatico
                    cboDiseño.Value = _leDN(0).Id
                    cboTipoBanda.Text = oeMatDisNeu.TipoBanda
                End If
            Else
                ' MostrarTabs(0, ficDisenoNeu)
                Me.Height = 480
                verCambia.Checked = True
                cboMarcaNeu.Enabled = False
                For Each oeMar In leMarcaNeu
                    If oeMatDisNeu.Material.Contains(oeMar.Nombre) Then
                        cboMarcaNeu.Value = oeMar.Id
                        Exit For
                    End If
                Next
                Dim _leDiseGri = leDisenoNeu.Where(Function(it) it.IdMarca = cboMarcaNeu.Value).ToList
                CargarDiseño(_leDiseGri)
                txtMaterialNuevo.Text = oeMatDisNeu.Material
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMaterialNuevo.Text.Trim <> "" Then
            oeMDNAux = New e_Material_DisenoNeu
            If verCambia.Checked Then
                If MessageBox.Show("¿Desea Cambiar el Nombre de Material: " & txtMaterialNuevo.Text.Trim & _
                                   Environment.NewLine & " Por el Nombre Generado: " & txtNombreCambiar.Text.Trim & _
                                   "?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    oeMDNAux.Material = txtNombreCambiar.Text.Trim
                Else
                    oeMDNAux.Material = txtMaterialNuevo.Text.Trim
                End If
            Else
                oeMDNAux.Material = txtMaterialNuevo.Text.Trim
            End If
            oeMDNAux.IdDisenoNeumatico = cboDiseño.Value
            oeMDNAux.TipoBanda = cboTipoBanda.Text.Trim
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Ingrese Datos!!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboMarcaNeu_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarcaNeu.ValueChanged
        Try
            If cboMarcaNeu.SelectedIndex > -1 Then
                If _Ope = 1 Then cboMedida.Enabled = True
                Dim _leMedida = leMedidaNeu.Where(Function(it) it.UsuarioCreacion = cboMarcaNeu.Value).ToList
                LlenarCombo(cboMedida, "Nombre", _leMedida, -1)
            Else
                cboMedida.SelectedIndex = -1
                cboMedida.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.ValueChanged
        Try
            If cboMedida.SelectedIndex > -1 Then
                If _Ope = 1 Then cboDiseño.Enabled = True
                Dim _leDiseno = leDisenoNeu.Where(Function(it) it.IdMarca = cboMarcaNeu.Value And it.IdMedidaNeumatico = cboMedida.Value).ToList
                LlenarCombo(cboDiseño, "Nombre", _leDiseno, -1)
            Else
                cboDiseño.SelectedIndex = -1
                cboDiseño.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDiseño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiseño.ValueChanged
        If cboDiseño.SelectedIndex > -1 Then
            cboTipoBanda.Enabled = True
        Else
            cboTipoBanda.SelectedIndex = -1
            cboTipoBanda.Enabled = False
        End If
    End Sub

    Private Sub cboTipoBanda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoBanda.ValueChanged
        If cboTipoBanda.SelectedIndex > -1 Then
            If _Ope = 1 Then
                txtMaterialNuevo.Text = "LLANTA " & cboMarcaNeu.Text.Trim & " " & cboDiseño.Text.Trim & " " & _
            cboMedida.Text.Trim & " " & cboTipoBanda.Text.Trim & " (" & oeMatDisNeu.EstadoNeu & ")"
            Else
                txtNombreCambiar.Text = "LLANTA " & cboMarcaNeu.Text.Trim & " " & cboDiseño.Text.Trim & " " & _
            cboMedida.Text.Trim & " " & cboTipoBanda.Text.Trim & " (" & oeMatDisNeu.EstadoNeu & ")"
            End If
        Else
            If _Ope = 1 Then txtMaterialNuevo.Text = String.Empty

        End If
    End Sub

    Private Sub griDisenoNeu_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDisenoNeu.DoubleClick
        With griDisenoNeu
            If .Rows.Count > 0 Then
                cboTipoBanda.SelectedIndex = -1
                cboMedida.Value = .ActiveRow.Cells("IdMedidaNeumatico").Value
                cboDiseño.Value = .ActiveRow.Cells("Id").Value
                If txtMaterialNuevo.Text.Contains("DIRECCIONAL") Then
                    cboTipoBanda.Text = "DIRECCIONAL"
                ElseIf txtMaterialNuevo.Text.Contains("TRACCION") Then
                    cboTipoBanda.Text = "TRACCION"
                ElseIf txtMaterialNuevo.Text.Contains("MIXTA") Then
                    cboTipoBanda.Text = "MIXTA"
                Else
                    cboTipoBanda.SelectedIndex = -1
                End If

            End If
        End With
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombo()
        Try
            oeMarcaNeu = New e_Marca
            oeMarcaNeu.TipoOperacion = "N"
            leMarcaNeu = olMarcaNeu.Listar(oeMarcaNeu)
            LlenarCombo(cboMarcaNeu, "Nombre", leMarcaNeu, -1)
            ' LlenarCombo(cboMarcaBus, "Nombre", leMarcaNeu, -1)

            oeMedidaNeu = New e_MedidaNeumatico
            oeMedidaNeu.TipoOperacion = "N"
            leMedidaNeu = olMedidaNeu.Listar(oeMedidaNeu)

            oeDisenoNeu = New e_DiseñoNeumatico
            oeDisenoNeu.TipoOperacion = ""
            oeDisenoNeu.Activo = True
            leDisenoNeu = olDisenoNeu.Listar(oeDisenoNeu)

            cboTipoBanda.Items.Clear()
            cboTipoBanda.Items.Add(0, "DIRECCIONAL")
            cboTipoBanda.Items.Add(1, "TRACCION")
            cboTipoBanda.Items.Add(2, "MIXTA")
            cboTipoBanda.Items.Add(3, "PISTERA")
            cboTipoBanda.SelectedIndex = -1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDiseño(ByVal leDis As List(Of e_DiseñoNeumatico))
        Try
            With griDisenoNeu

                .Text = "LISTADO DE DISEÑO DE NEUMATICO"
                .DataSource = leDis

                For Each Col In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Codigo" Or Col.Key = "Nombre" Or Col.Key = "MedidaNeumatico" Then
                        Col.Hidden = False
                    Else
                        Col.Hidden = True
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("MedidaNeumatico").Header.VisiblePosition = 3

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 90
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
                .DisplayLayout.Bands(0).Columns("MedidaNeumatico").Width = 150

                .DisplayLayout.Bands(0).Columns("Nombre").CellActivation = Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("MedidaNeumatico").CellActivation = Activation.NoEdit

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class