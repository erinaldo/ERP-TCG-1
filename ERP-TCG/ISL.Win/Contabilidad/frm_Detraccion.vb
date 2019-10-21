'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Detraccion
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Detraccion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Detraccion
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeAplicaDetrac As New e_AplicaDetraccion
    Dim olAplicaDetac As New l_AplicaDetraccion

    Dim leAplicacionDetrac As New List(Of e_AplicaDetraccion)
    Dim leSelec As New List(Of e_AplicaDetraccion)

    Dim oeInformeDetrac As New e_InformeDetrac
    Dim olInformeDetrac As New l_InformeDetrac

    Dim leDetraccionDet As New List(Of e_Detraccion_Det)
    Dim olDetraccionDet As New l_Detraccion_Det
    Dim oeDetraccionDet As New e_Detraccion_Det

    Dim oeInformeDetracDet As New e_InformeDetrac_Det

    Dim BandCargar As Boolean = True

    ' Dim leAplicado As New List(Of e_AplicaDetraccion)
    Dim leInforme As New List(Of e_AplicaDetraccion)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            Select Case ficDetraccion.SelectedTab.Index
                Case 0
                    If griDetraccion.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    If griInformeDetrac.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        MyBase.Guardar()
    End Sub

    Public Overrides Sub Cancelar()
        MyBase.Cancelar()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Dim grilla As New UltraGrid
            Select Case ficDetraccion.SelectedTab.Index
                Case 0
                    grilla = griDetraccion
                Case 1
                    grilla = griInformeDetrac
            End Select
            If grilla.Rows.Count = 0 Then Throw New Exception("No hay ninguna Detracción para exportar al Excel")
            Exportar_Excel(grilla)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            Dim id As String = griInformeDetrac.ActiveRow.Cells("Id").Value
            Dim ofrm As New frm_ReporteInformeDetrac
            ofrm.CargarDetalleInforme(id)
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Detraccion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Inicializa"
                Select Case ficDetraccion.SelectedTab.Index
                    Case 0
                        If griDetraccion.Rows.Count > 0 Then
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    Case 1
                        If griInformeDetrac.Rows.Count > 0 Then
                            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                End Select
        End Select
    End Sub

    Private Sub frm_Detraccion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Detraccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecDesde.Value = Date.Now.Date.AddDays(-5)
        fecHasta.Value = Date.Now.Date
        numAplica.Value = 5
        colorAplica.Color = Color.Gold
        etiAplica.Appearance.BackColor = colorAplica.Color
        colorFueraRango.Color = Color.LightCoral
        etiFueraRango.Appearance.BackColor = colorFueraRango.Color
        BandCargar = True
        CargarDetraccion(New List(Of e_AplicaDetraccion))
        CargarInformeDetrac(New List(Of e_InformeDetrac))
        BandCargar = False
    End Sub

    Private Sub griDetraccion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetraccion.CellChange
        griDetraccion.UpdateData()
    End Sub

    Private Sub griDetraccion_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetraccion.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key.ToUpper
                Case "INFORME"
                    With griDetraccion.Rows(e.Cell.Row.Index)
                        'IdOpeDet = .Cells("Id").Value
                        If .Cells("Informe").Value Then
                            .Appearance.BackColor = Color.LightGreen
                            .Fixed = True
                            ' AgregarCarga(IdOpeDet)
                        Else
                            .Appearance.BackColor = Color.White
                            .Fixed = False
                            'QuitarCarga(IdOpeDet)
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ficDetraccion_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetraccion.SelectedTabChanged
        Select Case ficDetraccion.SelectedTab.Index
            Case 0
                If griDetraccion.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                If griInformeDetrac.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub colorAplica_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorAplica.ColorChanged
        etiAplica.Appearance.BackColor = colorAplica.Color
    End Sub

    Private Sub colorFueraRango_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorFueraRango.ColorChanged
        etiFueraRango.Appearance.BackColor = colorFueraRango.Color
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Select Case ficDetraccion.SelectedTab.Index
                Case 0
                    griDetraccion.DataBind()
                    leInforme = leAplicacionDetrac.Where(Function(item) item.Informe = True).ToList
                    oeAplicaDetrac = New e_AplicaDetraccion
                    ValidarFechaDesde_Hasta(fecDesde, fecHasta)
                    oeAplicaDetrac._FechaInicio = fecDesde.Value.Date
                    oeAplicaDetrac._FechaFin = fecHasta.Value.Date
                    oeAplicaDetrac._IndAplicado = optEstadoDetrac.CheckedIndex
                    leAplicacionDetrac = olAplicaDetac.Listar(oeAplicaDetrac)
                    CargarDetraccion(leAplicacionDetrac)
                    CargaSeleccionados()
                Case 1
                    oeInformeDetrac = New e_InformeDetrac
                    CargarInformeDetrac(olInformeDetrac.Listar(oeInformeDetrac))
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griDetraccion.Focus()
    End Sub

    Private Sub CargarDetraccion(ByVal leAplicaDetrac As List(Of e_AplicaDetraccion))
        Try
            With griDetraccion

                If BandCargar Then
                    .ResetDisplayLayout()
                End If

                .DataSource = leAplicaDetrac

                If BandCargar Then
                    For Each col As UltraGridColumn In .DisplayLayout.Bands(0).Columns

                        If col.Header.Caption = "Aplicado" Or col.Header.Caption = "Informe" Then
                            col.CellActivation = Activation.AllowEdit
                            col.CellClickAction = CellClickAction.Edit
                        Else
                            col.CellActivation = Activation.NoEdit
                            col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Next

                    .DisplayLayout.Bands(0).Columns("IdMovimientoDocumento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdTipoMoneda").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdVenta").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DiasVen").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaUltimo").Hidden = True

                    .DisplayLayout.Bands(0).Columns("FechaEmision").SortIndicator = SortOrder.Ascending

                    .DisplayLayout.Bands(0).Columns("Serie").Width = 40
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("Cliente").Width = 250
                    .DisplayLayout.Bands(0).Columns("TipoMoneda").Width = 25
                    .DisplayLayout.Bands(0).Columns("Total").Width = 70
                    .DisplayLayout.Bands(0).Columns("Saldo").Width = 70
                    .DisplayLayout.Bands(0).Columns("Detraccion").Width = 70
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaCobro").Width = 110
                    .DisplayLayout.Bands(0).Columns("CuentaBancaria").Width = 150
                    .DisplayLayout.Bands(0).Columns("MontoCobro").Width = 110

                    .DisplayLayout.Bands(0).Columns("TipoMoneda").Header.Caption = "T.M."
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Header.Caption = "Saldo Detrac."

                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Detraccion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("FechaCobro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("CuentaBancaria").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("MontoCobro").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SumaCobro").CellAppearance.TextHAlign = HAlign.Right

                    .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Saldo").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Detraccion").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("SumaCobro").Format = "##,###,###0.0000"

                    .DisplayLayout.UseFixedHeaders = True
                    .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    .DisplayLayout.Bands(0).Columns("Serie").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Numero").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Fixed = True
                    .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True

                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End If

                If optEstadoDetrac.CheckedIndex = 0 Then
                    .DisplayLayout.Bands(0).Columns("Informe").Hidden = False
                    Dim xvar As Integer = numAplica.Value * -1
                    For Each fila As UltraGridRow In .Rows
                        If fila.Cells("Saldo").Value = 0 Then
                            If fila.Cells("DiasVen").Value > 0 Then
                                fila.CellAppearance.BackColor = colorFueraRango.Color
                            Else
                                If fila.Cells("DiasVen").Value >= xvar Then fila.CellAppearance.BackColor = colorAplica.Color
                            End If
                        End If
                    Next
                Else
                    .DisplayLayout.Bands(0).Columns("Informe").Hidden = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerificaSelecion(ByVal Tipo As Integer)
        griDetraccion.DataBind()
        leSelec = New List(Of e_AplicaDetraccion)
        If Tipo = 1 Then
            leSelec = leAplicacionDetrac.Where(Function(item) item.Aplicado = True).ToList
        Else
            leSelec = leAplicacionDetrac.Where(Function(item) item.Informe = True).ToList
        End If
        If leSelec.Count = 0 Then Throw New Exception("Debe seleccionar al menos un registro para: " & IIf(Tipo = 1, "Aplicar Detraccion", "Generar Informe"))

    End Sub

    Private Function ObtieneInformeDet(ByVal leApli As List(Of e_AplicaDetraccion)) As List(Of e_InformeDetrac_Det)
        Try
            Dim leInformeDet As New List(Of e_InformeDetrac_Det)
            For Each oeApli As e_AplicaDetraccion In leApli
                oeInformeDetracDet = New e_InformeDetrac_Det
                oeInformeDetracDet.IdVenta = oeApli.IdVenta
                oeInformeDetracDet.Monto = oeApli.Detraccion
                oeInformeDetracDet.UsuarioCreacion = gUsuarioSGI.Id
                oeInformeDetracDet.TipoOperacion = "I"
                leInformeDet.Add(oeInformeDetracDet)
            Next
            Return leInformeDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ObtieneDetraccionDet(ByVal leApli As List(Of e_AplicaDetraccion)) As List(Of e_Detraccion_Det)
        Try
            Dim leDetraccionDet As New List(Of e_Detraccion_Det)
            For Each oeApli As e_AplicaDetraccion In leApli
                oeDetraccionDet = New e_Detraccion_Det
                oeDetraccionDet.IdVenta = oeApli.IdVenta
                oeDetraccionDet.Monto = oeApli.Detraccion
                oeDetraccionDet.UsuarioCreacion = gUsuarioSGI.Id
                oeDetraccionDet.TipoOperacion = "I"
                oeDetraccionDet.PrefijoID = gs_PrefijoIdSucursal '@0001
                leDetraccionDet.Add(oeDetraccionDet)
            Next
            Return leDetraccionDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarInformeDetrac(ByVal leInforme As List(Of e_InformeDetrac))
        Try

            With griInformeDetrac

                If BandCargar Then
                    .ResetDisplayLayout()
                End If

                griInformeDetrac.DataSource = leInforme

                If BandCargar Then

                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("NroInforme").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 3

                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200

                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.0000"

                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1


                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaSeleccionados()
        Try
            If leInforme.Count > 0 Then

                For Each oeSel As e_AplicaDetraccion In leInforme
                    For Each fila As UltraGridRow In griDetraccion.Rows
                        If fila.Cells("Informe").Value = False AndAlso fila.Cells("IdMovimientoDocumento").Value = oeSel.IdMovimientoDocumento Then
                            fila.Cells("Informe").Value = True
                            griDetraccion.UpdateData()
                            Exit For
                        End If
                    Next
                Next

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuDetraccion_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuDetraccion.Opening
        If optEstadoDetrac.CheckedIndex = 0 Then
            mnuDetraccion.Items("tsmiAplicar").Visible = True
            mnuDetraccion.Items("tsmiGenerarInforme").Visible = True
            mnuDetraccion.Items("tsmiRestaurarDetraccion").Visible = False
        Else
            mnuDetraccion.Items("tsmiAplicar").Visible = False
            mnuDetraccion.Items("tsmiGenerarInforme").Visible = False
            mnuDetraccion.Items("tsmiRestaurarDetraccion").Visible = True
        End If
    End Sub

    Private Sub tsmiAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAplicar.Click
        Try
            VerificaSelecion(1)
            If MessageBox.Show("¿Desea Aplicar Detracción?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                leDetraccionDet = New List(Of e_Detraccion_Det)
                leDetraccionDet = ObtieneDetraccionDet(leSelec)
                olDetraccionDet.GuardarLista(leDetraccionDet)
                leSelec = New List(Of e_AplicaDetraccion)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiGenerarInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGenerarInforme.Click
        Try
            VerificaSelecion(2)
            If MessageBox.Show("¿Desea Generar Informe?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeInformeDetrac = New e_InformeDetrac
                oeInformeDetrac.TipoOperacion = "I"
                oeInformeDetrac.leInformeDetrac = ObtieneInformeDet(leSelec)
                oeInformeDetrac.Total = oeInformeDetrac.leInformeDetrac.Sum(Function(item) item.Monto)
                oeInformeDetrac.Glosa = "INFORME DE DETRACCION"
                oeInformeDetrac.UsuarioCreacion = gUsuarioSGI.Id
                oeInformeDetrac.PrefijoID = gs_PrefijoIdSucursal '@0001
                olInformeDetrac.Guardar(oeInformeDetrac)
                Dim idInforme As String = ""
                idInforme = oeInformeDetrac.Id
                Dim ofrm As New frm_ReporteInformeDetrac
                ofrm.CargarDetalleInforme(idInforme)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                Dim DetraccionMasiva As New frm_DetraccionesMasivas
                DetraccionMasiva = DetraccionMasiva.getInstancia()
                DetraccionMasiva.MdiParent = frm_Menu
                DetraccionMasiva.Show()
                DetraccionMasiva.NuevoProveedor()
                DetraccionMasiva.ListarDetProveedor()
                leSelec = New List(Of e_AplicaDetraccion)
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiRestaurarDetraccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRestaurarDetraccion.Click
        Try
            VerificaSelecion(1)
            If MessageBox.Show("¿Desea Restaurar la Aplicacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                leDetraccionDet = New List(Of e_Detraccion_Det)
                leDetraccionDet = ObtieneDetraccionDet(leSelec)
                olDetraccionDet.EliminarLista(leDetraccionDet)
                leSelec = New List(Of e_AplicaDetraccion)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region
    
End Class