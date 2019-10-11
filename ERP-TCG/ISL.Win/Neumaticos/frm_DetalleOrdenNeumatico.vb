'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_DetalleOrdenNeumatico

#Region "Instancia"

    Sub New(ByVal oeDON As e_DetalleOrdenNeumatico, ByVal oeMat As e_Material, _
            ByVal oeOrdenI As e_Orden, ByVal leDONAux As List(Of e_DetalleOrdenNeumatico), _
            ByVal _Tipo As Integer)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oeDetOrdNeu = oeDON
        oeMatAux = oeMat
        oeOrdenIAux = oeOrdenI
        _cant = oeDON.CantMat
        _idReqMat = oeDON.IdReqMat
        _idOrdenMat = oeDON.IdOrdenMaterial
        leDetOrdNeu = leDONAux
        _tp = _Tipo
    End Sub

#End Region

#Region "Declaracion de Variables"

    Private oeDetOrdNeu As New e_DetalleOrdenNeumatico
    Private olDetOrdNeu As New l_DetalleOrdenNeumatico
    Private leDetOrdNeu As New List(Of e_DetalleOrdenNeumatico)

    Private oeDisenoNeu As New e_DiseñoNeumatico
    Private olDisenoNeu As New l_DiseñoNeumatico

    Private oeMatAux As New e_Material
    Private oeOrdenIAux As New e_Orden
    Private oeNeumatico As New e_Neumatico

    Private oeOrdenMat As New e_OrdenMaterial
    Private olOrdenMat As New l_OrdenMaterial

    Private _cant As Double
    Private _idOrdenMat As String
    Private _idReqMat As String

    Private _tp As Integer

#End Region

#Region "Eventos"

    Private Sub frm_DetalleOrdenNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim _cadaux As String
            Dim _nroaux As Integer
            txtMaterial.Text = oeMatAux.Nombre
            txtProveedor.Text = oeOrdenIAux.NombreProveedor
            If _tp = 1 Then
                oeOrdenMat = New e_OrdenMaterial
                oeOrdenMat.Id = oeMatAux.Id
                oeOrdenMat.TipoOperacion = "F"
                oeOrdenMat = olOrdenMat.Obtener(oeOrdenMat)
                txtProveedor.Text = oeOrdenMat.Almacen
            End If
            
            If leDetOrdNeu.Count = 0 Then
                oeDetOrdNeu = New e_DetalleOrdenNeumatico
                oeDetOrdNeu.TipoOperacion = "U"
                oeDetOrdNeu = olDetOrdNeu.Obtener(oeDetOrdNeu)
                If oeDetOrdNeu IsNot Nothing AndAlso oeDetOrdNeu.CodNeumatico <> "" Then
                    _cadaux = oeDetOrdNeu.CodNeumatico.Substring(2, oeDetOrdNeu.CodNeumatico.Length - 2)
                    _nroaux = CInt(_cadaux) + oeOrdenIAux.Total
                End If
                For i = 0 To _cant - 1
                    oeDetOrdNeu = New e_DetalleOrdenNeumatico
                    oeDetOrdNeu.CodNeumatico = "NI" & FormatoDocumento(_nroaux + i, 6)
                    oeDetOrdNeu.IdReqMat = _idReqMat
                    leDetOrdNeu.Add(oeDetOrdNeu)
                Next
            End If
            CargarNeumatico(leDetOrdNeu)
            If _tp = 1 Then
                spContenedor.Panel2Collapsed = False
            Else
                spContenedor.Panel2Collapsed = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            griPreRegistro.UpdateData()
            leNOD = New List(Of e_DetalleOrdenNeumatico)
            If MessageBox.Show("¿Desea Guardar los Cambios?", "Mesaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                If leDetOrdNeu.Count > 0 Then
                    'oeDisenoNeu = New e_DiseñoNeumatico
                    'oeDisenoNeu.Id = oeMatAux.oeMaterial_DisenoNeu.IdDisenoNeumatico
                    'oeDisenoNeu = olDisenoNeu.Obtener(oeDisenoNeu)
                    For Each oeDet In leDetOrdNeu
                        If oeDet.CodNeumatico.Trim = "" Then
                            Throw New Exception("Ingrese Codigo para Pre Registro de Neumatico")
                        End If
                        oeDet.IdOrdenMaterial = _idOrdenMat
                        oeDet.UsuarioCreacion = gUsuarioSGI.Id
                        oeDet.oeNeumatico = New e_Neumatico
                        oeDet.oeNeumatico.Codigo = oeDet.CodNeumatico
                        oeDet.oeNeumatico.IdDiseño = oeMatAux.oeMaterial_DisenoNeu.IdDisenoNeumatico
                        oeDet.oeNeumatico.IdMaterial = oeMatAux.Id
                        oeDet.oeNeumatico.IdProveedor = oeOrdenMat.IdAlmacen
                        oeDet.oeNeumatico.TipoBanda = oeMatAux.oeMaterial_DisenoNeu.TipoBanda
                        oeDet.oeNeumatico.UsuarioCreacion = gUsuarioSGI.Id
                        oeDet.oeNeumatico.KilometrajeActual = 0
                        oeDet.oeNeumatico.FechaIngreso = Date.Now.Date
                        oeDet.oeNeumatico.FechaIngresoAlmacen = Date.Now.Date
                        oeDet.oeNeumatico.TipoCambio = TipoCambio(Date.Now.Date)(1)
                        If oeDet.oeNeumatico.TipoCambio = 0 Then
                            oeDet.oeNeumatico.TipoCambio = TipoCambio(Date.Now.Date, True)(1)
                        End If
                        oeDet.oeNeumatico.CocadaMinima = 0
                        If oeOrdenIAux.Moneda = "SOLES" Then
                            oeDet.oeNeumatico.CostoTotalSoles = oeOrdenMat.PrecioUnitario
                            oeDet.oeNeumatico.CostoTotalDolares = oeOrdenMat.PrecioUnitario / oeDet.oeNeumatico.TipoCambio
                        Else
                            oeDet.oeNeumatico.CostoTotalDolares = oeOrdenMat.PrecioUnitario
                            oeDet.oeNeumatico.CostoTotalSoles = oeOrdenMat.PrecioUnitario * oeDet.oeNeumatico.TipoCambio
                        End If
                    Next
                    leNOD = leDetOrdNeu
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub griPreRegistro_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPreRegistro.AfterCellUpdate
        Try
            If griPreRegistro.ActiveRow.Index > -1 Then
                Dim _CodNeu As String
                _CodNeu = griPreRegistro.ActiveRow.Cells("CodNeumatico").Value
                If _CodNeu.Length < 8 Then
                    griPreRegistro.ActiveRow.Cells("CodNeumatico").Value = FormatoDocumento(_CodNeu, 8)
                End If
                griPreRegistro.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarNeumatico(ByVal leDON As List(Of e_DetalleOrdenNeumatico))
        Try
            With griPreRegistro

                .DataSource = leDON

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "CodNeumatico" Then
                        If _tp = 1 Then
                            col.CellActivation = Activation.AllowEdit
                        Else
                            col.CellActivation = Activation.NoEdit
                        End If
                    Else
                        col.CellActivation = Activation.NoEdit
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOrdenMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdNeumatico").Hidden = True
                .DisplayLayout.Bands(0).Columns("Descripcion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaOrden").Hidden = True
                .DisplayLayout.Bands(0).Columns("NroOrden").Hidden = True

                .DisplayLayout.Bands(0).Columns("Confirmacion").Style = ColumnStyle.CheckBox

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
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