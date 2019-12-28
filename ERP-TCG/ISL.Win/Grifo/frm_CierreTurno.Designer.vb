<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CierreTurno
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis ")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal ")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCierreTurno ")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grupo ")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rubro ")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion ")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConcepto ")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto ")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorInicial ")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorFinal ")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorDiferencia ")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorERP ")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorReal ")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorAux1 ")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorAux2 ")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa ")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inicio")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fin")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorApertura")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Inicio")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fin")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorApertura")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Combustibles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCierreTurnoDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_ContometroAnalogico = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_ContometroDigital = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Almacenes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_VentasAnuladas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_VentasxCombustible = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Calibraciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Trabajadores = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCierreTurno = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.rdbDatosBasicos = New System.Windows.Forms.RadioButton()
        Me.grbDatosBasicos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorEvaluado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorParcial = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.cmb_TrabajadorApertura_Buscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_TurnoBuscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_EstadoBuscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboTrabajadorCierre = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTrabajadorApertura = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnCrearCtaCte = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ficOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
        CType(Me.udg_Combustibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCierreTurnoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCierreTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosBasicos.SuspendLayout()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TrabajadorApertura_Buscado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TurnoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EstadoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenComercial.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox14)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox14
        '
        Me.UltraGroupBox14.Controls.Add(Me.udg_Combustibles)
        Me.UltraGroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox14.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(972, 598)
        Me.UltraGroupBox14.TabIndex = 5
        Me.UltraGroupBox14.Text = "Precios de Combustibles"
        Me.UltraGroupBox14.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Combustibles
        '
        Me.udg_Combustibles.DataSource = Me.odCierreTurnoDetalle
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Combustibles.DisplayLayout.Appearance = Appearance1
        UltraGridColumn297.Header.VisiblePosition = 0
        UltraGridColumn297.Hidden = True
        UltraGridColumn361.Header.VisiblePosition = 1
        UltraGridColumn361.Hidden = True
        UltraGridColumn362.Header.VisiblePosition = 2
        UltraGridColumn362.Hidden = True
        UltraGridColumn363.Header.VisiblePosition = 3
        UltraGridColumn363.Hidden = True
        UltraGridColumn364.Header.VisiblePosition = 4
        UltraGridColumn364.Hidden = True
        UltraGridColumn365.Header.VisiblePosition = 5
        UltraGridColumn365.Hidden = True
        UltraGridColumn366.Header.VisiblePosition = 6
        UltraGridColumn366.Hidden = True
        UltraGridColumn367.Header.VisiblePosition = 7
        UltraGridColumn367.Hidden = True
        UltraGridColumn368.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn368.Header.VisiblePosition = 8
        UltraGridColumn368.Width = 218
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn369.CellAppearance = Appearance2
        UltraGridColumn369.Header.VisiblePosition = 9
        UltraGridColumn369.Hidden = True
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn370.CellAppearance = Appearance3
        UltraGridColumn370.Header.VisiblePosition = 10
        UltraGridColumn370.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn371.CellAppearance = Appearance4
        UltraGridColumn371.Header.VisiblePosition = 11
        UltraGridColumn371.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn372.CellAppearance = Appearance5
        UltraGridColumn372.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn372.Format = "#,###,###,##0.00"
        UltraGridColumn372.Header.VisiblePosition = 12
        UltraGridColumn372.MaskInput = "{double:9.2}"
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn373.CellAppearance = Appearance6
        UltraGridColumn373.Header.VisiblePosition = 13
        UltraGridColumn373.Hidden = True
        UltraGridColumn374.Header.VisiblePosition = 14
        UltraGridColumn374.Hidden = True
        UltraGridColumn375.Header.VisiblePosition = 15
        UltraGridColumn375.Hidden = True
        UltraGridColumn376.Header.VisiblePosition = 16
        UltraGridColumn376.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn297, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376})
        Me.udg_Combustibles.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udg_Combustibles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Combustibles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Combustibles.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Combustibles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.udg_Combustibles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Combustibles.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Combustibles.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.udg_Combustibles.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Combustibles.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Combustibles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Combustibles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Combustibles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Combustibles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Combustibles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Combustibles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Combustibles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Me.udg_Combustibles.DisplayLayout.Override.RowAppearance = Appearance10
        Me.udg_Combustibles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Combustibles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Combustibles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Combustibles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Combustibles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Combustibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Combustibles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Combustibles.Location = New System.Drawing.Point(3, 17)
        Me.udg_Combustibles.Name = "udg_Combustibles"
        Me.udg_Combustibles.Size = New System.Drawing.Size(966, 578)
        Me.udg_Combustibles.TabIndex = 2
        Me.udg_Combustibles.Text = "Grilla2"
        '
        'odCierreTurnoDetalle
        '
        UltraDataColumn8.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn10.DataType = GetType(Decimal)
        UltraDataColumn11.DataType = GetType(Decimal)
        UltraDataColumn12.DataType = GetType(Decimal)
        UltraDataColumn13.DataType = GetType(Decimal)
        UltraDataColumn14.DataType = GetType(Decimal)
        UltraDataColumn15.DataType = GetType(Decimal)
        UltraDataColumn16.DataType = GetType(Decimal)
        Me.odCierreTurnoDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.udg_ContometroAnalogico)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(541, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(431, 598)
        Me.UltraGroupBox7.TabIndex = 2
        Me.UltraGroupBox7.Text = "Contometro Mecanico"
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_ContometroAnalogico
        '
        Me.udg_ContometroAnalogico.DataSource = Me.odCierreTurnoDetalle
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ContometroAnalogico.DisplayLayout.Appearance = Appearance11
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn96.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.VisiblePosition = 8
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance12
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn10.Format = "#,###,###,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskInput = "{double:9.2}"
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance13
        UltraGridColumn11.Format = "#,###,###,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.MaskInput = "{double:9.2}"
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance14
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Format = "#,###,###,##0.00"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.MaskInput = "{double:9.2}"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.udg_ContometroAnalogico.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_ContometroAnalogico.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Hidden = True
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.udg_ContometroAnalogico.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroAnalogico.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowAppearance = Appearance18
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroAnalogico.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroAnalogico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroAnalogico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroAnalogico.Location = New System.Drawing.Point(3, 17)
        Me.udg_ContometroAnalogico.Name = "udg_ContometroAnalogico"
        Me.udg_ContometroAnalogico.Size = New System.Drawing.Size(425, 578)
        Me.udg_ContometroAnalogico.TabIndex = 2
        Me.udg_ContometroAnalogico.Text = "Grilla2"
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.udg_ContometroDigital)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(541, 598)
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.Text = "Contometro Digital"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_ContometroDigital
        '
        Me.udg_ContometroDigital.DataSource = Me.odCierreTurnoDetalle
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ContometroDigital.DisplayLayout.Appearance = Appearance19
        UltraGridColumn61.Header.VisiblePosition = 0
        UltraGridColumn61.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 1
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 3
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn50.Header.VisiblePosition = 7
        UltraGridColumn50.Width = 71
        UltraGridColumn51.Header.VisiblePosition = 4
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 5
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 6
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn54.Header.VisiblePosition = 8
        UltraGridColumn54.Width = 118
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance20
        UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn55.Format = "#,###,###,##0.00"
        UltraGridColumn55.Header.Caption = "V.Inicial "
        UltraGridColumn55.Header.VisiblePosition = 9
        UltraGridColumn55.MaskInput = "{double:9.2}"
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn271.CellAppearance = Appearance21
        UltraGridColumn271.Format = "#,###,###,##0.00"
        UltraGridColumn271.Header.VisiblePosition = 10
        UltraGridColumn271.MaskInput = "{double:9.2}"
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn272.CellAppearance = Appearance22
        UltraGridColumn272.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn272.Format = "#,###,###,##0.00"
        UltraGridColumn272.Header.VisiblePosition = 11
        UltraGridColumn272.MaskInput = "{double:9.2}"
        UltraGridColumn273.Header.VisiblePosition = 12
        UltraGridColumn273.Hidden = True
        UltraGridColumn273.MaskInput = "{double:9.2}"
        UltraGridColumn274.Header.VisiblePosition = 13
        UltraGridColumn274.Hidden = True
        UltraGridColumn274.MaskInput = "{double:9.2}"
        UltraGridColumn275.Header.VisiblePosition = 14
        UltraGridColumn275.Hidden = True
        UltraGridColumn275.MaskInput = "{double:9.2}"
        UltraGridColumn276.Header.VisiblePosition = 15
        UltraGridColumn276.Hidden = True
        UltraGridColumn276.MaskInput = "{double:9.2}"
        UltraGridColumn277.Header.VisiblePosition = 16
        UltraGridColumn277.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277})
        Me.udg_ContometroDigital.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.udg_ContometroDigital.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance23.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Appearance = Appearance23
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance24
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Hidden = True
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance25.BackColor2 = System.Drawing.SystemColors.Control
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.PromptAppearance = Appearance25
        Me.udg_ContometroDigital.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroDigital.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroDigital.DisplayLayout.Override.RowAppearance = Appearance26
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroDigital.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroDigital.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroDigital.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroDigital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroDigital.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroDigital.Location = New System.Drawing.Point(3, 17)
        Me.udg_ContometroDigital.Name = "udg_ContometroDigital"
        Me.udg_ContometroDigital.Size = New System.Drawing.Size(535, 578)
        Me.udg_ContometroDigital.TabIndex = 2
        Me.udg_ContometroDigital.Text = "Grilla2"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox13)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.udg_Almacenes)
        Me.UltraGroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox13.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(972, 598)
        Me.UltraGroupBox13.TabIndex = 4
        Me.UltraGroupBox13.Text = "Varillaje"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Almacenes
        '
        Me.udg_Almacenes.DataSource = Me.odCierreTurnoDetalle
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Almacenes.DisplayLayout.Appearance = Appearance27
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.Width = 179
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance28
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn27.MaskInput = "{double:9.2}"
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance29
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.MaskInput = "{double:9.2}"
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance30
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.MaskInput = "{double:9.2}"
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn30.Header.VisiblePosition = 12
        UltraGridColumn30.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 13
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 14
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 15
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 16
        UltraGridColumn59.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        Me.udg_Almacenes.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.udg_Almacenes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Almacenes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance31.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Appearance = Appearance31
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance32
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Hidden = True
        Appearance33.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance33.BackColor2 = System.Drawing.SystemColors.Control
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.PromptAppearance = Appearance33
        Me.udg_Almacenes.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Almacenes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Almacenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Almacenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Me.udg_Almacenes.DisplayLayout.Override.RowAppearance = Appearance34
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Almacenes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Almacenes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Almacenes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Almacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Almacenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Almacenes.Location = New System.Drawing.Point(3, 17)
        Me.udg_Almacenes.Name = "udg_Almacenes"
        Me.udg_Almacenes.Size = New System.Drawing.Size(966, 578)
        Me.udg_Almacenes.TabIndex = 2
        Me.udg_Almacenes.Text = "Grilla2"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox9)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.udg_VentasAnuladas)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox9.Location = New System.Drawing.Point(449, 0)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(523, 598)
        Me.UltraGroupBox9.TabIndex = 2
        Me.UltraGroupBox9.Text = "Ventas Anuladas"
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_VentasAnuladas
        '
        Me.udg_VentasAnuladas.DataSource = Me.odCierreTurnoDetalle
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasAnuladas.DisplayLayout.Appearance = Appearance35
        UltraGridColumn166.Header.VisiblePosition = 0
        UltraGridColumn166.Hidden = True
        UltraGridColumn294.Header.VisiblePosition = 1
        UltraGridColumn294.Hidden = True
        UltraGridColumn295.Header.VisiblePosition = 2
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.VisiblePosition = 3
        UltraGridColumn296.Hidden = True
        UltraGridColumn332.Header.VisiblePosition = 4
        UltraGridColumn332.Hidden = True
        UltraGridColumn333.Header.VisiblePosition = 5
        UltraGridColumn333.Hidden = True
        UltraGridColumn334.Header.VisiblePosition = 6
        UltraGridColumn334.Hidden = True
        UltraGridColumn335.Header.VisiblePosition = 7
        UltraGridColumn335.Hidden = True
        UltraGridColumn336.Header.VisiblePosition = 8
        UltraGridColumn336.Width = 162
        UltraGridColumn337.Header.VisiblePosition = 9
        UltraGridColumn337.Hidden = True
        UltraGridColumn338.Header.VisiblePosition = 10
        UltraGridColumn338.Hidden = True
        UltraGridColumn339.Header.VisiblePosition = 11
        UltraGridColumn339.Hidden = True
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn340.CellAppearance = Appearance36
        UltraGridColumn340.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn340.Header.VisiblePosition = 12
        UltraGridColumn340.MaskInput = "{double:9.2}"
        UltraGridColumn341.Header.VisiblePosition = 13
        UltraGridColumn341.Hidden = True
        UltraGridColumn342.Header.VisiblePosition = 14
        UltraGridColumn342.Hidden = True
        UltraGridColumn343.Header.VisiblePosition = 15
        UltraGridColumn343.Hidden = True
        UltraGridColumn344.Header.VisiblePosition = 16
        UltraGridColumn344.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn166, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344})
        Me.udg_VentasAnuladas.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.udg_VentasAnuladas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Appearance = Appearance37
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance38
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Hidden = True
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance39.BackColor2 = System.Drawing.SystemColors.Control
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.PromptAppearance = Appearance39
        Me.udg_VentasAnuladas.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasAnuladas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowAppearance = Appearance40
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasAnuladas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasAnuladas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasAnuladas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasAnuladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasAnuladas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasAnuladas.Location = New System.Drawing.Point(3, 17)
        Me.udg_VentasAnuladas.Name = "udg_VentasAnuladas"
        Me.udg_VentasAnuladas.Size = New System.Drawing.Size(517, 578)
        Me.udg_VentasAnuladas.TabIndex = 2
        Me.udg_VentasAnuladas.Text = "Grilla2"
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.udg_VentasxCombustible)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(449, 598)
        Me.UltraGroupBox8.TabIndex = 1
        Me.UltraGroupBox8.Text = "Ventas x Combustible"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_VentasxCombustible
        '
        Me.udg_VentasxCombustible.DataSource = Me.odCierreTurnoDetalle
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasxCombustible.DisplayLayout.Appearance = Appearance41
        UltraGridColumn131.Header.VisiblePosition = 0
        UltraGridColumn131.Hidden = True
        UltraGridColumn278.Header.VisiblePosition = 1
        UltraGridColumn278.Hidden = True
        UltraGridColumn279.Header.VisiblePosition = 2
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 3
        UltraGridColumn280.Hidden = True
        UltraGridColumn281.Header.VisiblePosition = 4
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.VisiblePosition = 5
        UltraGridColumn282.Hidden = True
        UltraGridColumn283.Header.VisiblePosition = 6
        UltraGridColumn283.Hidden = True
        UltraGridColumn284.Header.VisiblePosition = 7
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.VisiblePosition = 8
        UltraGridColumn285.Width = 167
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn286.CellAppearance = Appearance42
        UltraGridColumn286.Header.VisiblePosition = 9
        UltraGridColumn286.Hidden = True
        UltraGridColumn286.MaskInput = "{double:9.2}"
        UltraGridColumn287.Header.VisiblePosition = 10
        UltraGridColumn287.Hidden = True
        UltraGridColumn287.MaskInput = "{double:9.2}"
        UltraGridColumn288.Header.VisiblePosition = 11
        UltraGridColumn288.Hidden = True
        UltraGridColumn288.MaskInput = "{double:9.2}"
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn289.CellAppearance = Appearance43
        UltraGridColumn289.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn289.Header.VisiblePosition = 12
        UltraGridColumn289.MaskInput = "{double:9.2}"
        UltraGridColumn290.Header.VisiblePosition = 13
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 14
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 15
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.Header.VisiblePosition = 16
        UltraGridColumn293.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293})
        Me.udg_VentasxCombustible.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.udg_VentasxCombustible.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance44.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Appearance = Appearance44
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance45
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Hidden = True
        Appearance46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance46.BackColor2 = System.Drawing.SystemColors.Control
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.PromptAppearance = Appearance46
        Me.udg_VentasxCombustible.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasxCombustible.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowAppearance = Appearance47
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasxCombustible.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasxCombustible.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasxCombustible.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasxCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasxCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasxCombustible.Location = New System.Drawing.Point(3, 17)
        Me.udg_VentasxCombustible.Name = "udg_VentasxCombustible"
        Me.udg_VentasxCombustible.Size = New System.Drawing.Size(443, 578)
        Me.udg_VentasxCombustible.TabIndex = 2
        Me.udg_VentasxCombustible.Text = "Grilla2"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.udg_Calibraciones)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(972, 598)
        Me.UltraGroupBox10.TabIndex = 3
        Me.UltraGroupBox10.Text = "Calibraciones"
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Calibraciones
        '
        Me.udg_Calibraciones.DataSource = Me.odCierreTurnoDetalle
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Calibraciones.DisplayLayout.Appearance = Appearance48
        UltraGridColumn201.Header.VisiblePosition = 0
        UltraGridColumn201.Hidden = True
        UltraGridColumn345.Header.VisiblePosition = 1
        UltraGridColumn345.Hidden = True
        UltraGridColumn346.Header.VisiblePosition = 2
        UltraGridColumn346.Hidden = True
        UltraGridColumn347.Header.VisiblePosition = 3
        UltraGridColumn347.Hidden = True
        UltraGridColumn348.Header.VisiblePosition = 4
        UltraGridColumn348.Hidden = True
        UltraGridColumn349.Header.VisiblePosition = 5
        UltraGridColumn349.Hidden = True
        UltraGridColumn350.Header.VisiblePosition = 6
        UltraGridColumn350.Hidden = True
        UltraGridColumn351.Header.VisiblePosition = 7
        UltraGridColumn351.Hidden = True
        UltraGridColumn352.Header.VisiblePosition = 8
        UltraGridColumn352.Width = 277
        UltraGridColumn353.Header.VisiblePosition = 9
        UltraGridColumn353.Hidden = True
        UltraGridColumn354.Header.VisiblePosition = 10
        UltraGridColumn354.Hidden = True
        UltraGridColumn355.Header.VisiblePosition = 11
        UltraGridColumn355.Hidden = True
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn356.CellAppearance = Appearance49
        UltraGridColumn356.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn356.Header.VisiblePosition = 12
        UltraGridColumn356.MaskInput = "{double:9.2}"
        UltraGridColumn357.Header.VisiblePosition = 13
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 14
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.VisiblePosition = 15
        UltraGridColumn359.Hidden = True
        UltraGridColumn360.Header.VisiblePosition = 16
        UltraGridColumn360.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn201, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360})
        Me.udg_Calibraciones.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.udg_Calibraciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Hidden = True
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.udg_Calibraciones.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Calibraciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Calibraciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Calibraciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance53.BorderColor = System.Drawing.Color.Silver
        Me.udg_Calibraciones.DisplayLayout.Override.RowAppearance = Appearance53
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Calibraciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Calibraciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Calibraciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Calibraciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Calibraciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Calibraciones.Location = New System.Drawing.Point(3, 17)
        Me.udg_Calibraciones.Name = "udg_Calibraciones"
        Me.udg_Calibraciones.Size = New System.Drawing.Size(966, 578)
        Me.udg_Calibraciones.TabIndex = 2
        Me.udg_Calibraciones.Text = "Grilla2"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGroupBox12)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.udg_Trabajadores)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(972, 598)
        Me.UltraGroupBox12.TabIndex = 0
        Me.UltraGroupBox12.Text = "Trabajadores"
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Trabajadores
        '
        Me.udg_Trabajadores.DataSource = Me.odCierreTurnoDetalle
        Appearance54.BackColor = System.Drawing.SystemColors.Window
        Appearance54.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Trabajadores.DisplayLayout.Appearance = Appearance54
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.Width = 801
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 14
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 16
        UltraGridColumn46.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46})
        Me.udg_Trabajadores.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.udg_Trabajadores.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance55.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance55.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Appearance = Appearance55
        Appearance56.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance56
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Hidden = True
        Appearance57.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance57.BackColor2 = System.Drawing.SystemColors.Control
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.PromptAppearance = Appearance57
        Me.udg_Trabajadores.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Trabajadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Trabajadores.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Trabajadores.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Trabajadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance58.BorderColor = System.Drawing.Color.Silver
        Me.udg_Trabajadores.DisplayLayout.Override.RowAppearance = Appearance58
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Trabajadores.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Trabajadores.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Trabajadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Trabajadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Trabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Trabajadores.Location = New System.Drawing.Point(3, 17)
        Me.udg_Trabajadores.Name = "udg_Trabajadores"
        Me.udg_Trabajadores.Size = New System.Drawing.Size(966, 578)
        Me.udg_Trabajadores.TabIndex = 2
        Me.udg_Trabajadores.Text = "Grilla2"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(982, 726)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 108)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(982, 618)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Me.griOrdenComercial.DataSource = Me.odCierreTurno
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance59
        UltraGridColumn236.Header.VisiblePosition = 0
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridColumn62.Header.VisiblePosition = 2
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn64.Header.VisiblePosition = 4
        UltraGridColumn65.Header.VisiblePosition = 5
        UltraGridColumn66.Header.VisiblePosition = 6
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn236, UltraGridColumn60, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance60
        Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance61
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance62.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance62.BackColor2 = System.Drawing.SystemColors.Control
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance62.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance62
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance63.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance63
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(976, 612)
        Me.griOrdenComercial.TabIndex = 1
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'odCierreTurno
        '
        Me.odCierreTurno.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.rdbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.grbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.cmb_TrabajadorApertura_Buscado)
        Me.UltraGroupBox1.Controls.Add(Me.cmb_TurnoBuscado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox1.Controls.Add(Me.cmb_EstadoBuscado)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(982, 108)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rdbDatosBasicos
        '
        Me.rdbDatosBasicos.AutoSize = True
        Me.rdbDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosBasicos.Checked = True
        Me.rdbDatosBasicos.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosBasicos.Location = New System.Drawing.Point(11, 18)
        Me.rdbDatosBasicos.Name = "rdbDatosBasicos"
        Me.rdbDatosBasicos.Size = New System.Drawing.Size(88, 17)
        Me.rdbDatosBasicos.TabIndex = 341
        Me.rdbDatosBasicos.TabStop = True
        Me.rdbDatosBasicos.Text = "DatosBasicos"
        Me.rdbDatosBasicos.UseVisualStyleBackColor = False
        '
        'grbDatosBasicos
        '
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel23)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel22)
        Me.grbDatosBasicos.Controls.Add(Me.colorEvaluado)
        Me.grbDatosBasicos.Controls.Add(Me.colorParcial)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel15)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel16)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaInicio)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaFin)
        Me.grbDatosBasicos.Location = New System.Drawing.Point(11, 35)
        Me.grbDatosBasicos.Name = "grbDatosBasicos"
        Me.grbDatosBasicos.Size = New System.Drawing.Size(320, 65)
        Me.grbDatosBasicos.TabIndex = 340
        Me.grbDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel23
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance64
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(198, 37)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel23.TabIndex = 356
        Me.UltraLabel23.Text = "Cerrado"
        '
        'UltraLabel22
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance65
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(201, 11)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(40, 15)
        Me.UltraLabel22.TabIndex = 355
        Me.UltraLabel22.Text = "Abierto"
        '
        'colorEvaluado
        '
        Me.colorEvaluado.Color = System.Drawing.Color.PaleGoldenrod
        Me.colorEvaluado.Location = New System.Drawing.Point(247, 6)
        Me.colorEvaluado.Name = "colorEvaluado"
        Me.colorEvaluado.Size = New System.Drawing.Size(46, 22)
        Me.colorEvaluado.TabIndex = 354
        Me.colorEvaluado.Text = "PaleGoldenrod"
        '
        'colorParcial
        '
        Me.colorParcial.Color = System.Drawing.Color.PaleTurquoise
        Me.colorParcial.Location = New System.Drawing.Point(247, 32)
        Me.colorParcial.Name = "colorParcial"
        Me.colorParcial.Size = New System.Drawing.Size(46, 22)
        Me.colorParcial.TabIndex = 353
        Me.colorParcial.Text = "PaleTurquoise"
        '
        'UltraLabel15
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Appearance66.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance66
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel15.TabIndex = 337
        Me.UltraLabel15.Text = "Desde:"
        '
        'UltraLabel16
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance67
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 35)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel16.TabIndex = 338
        Me.UltraLabel16.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(51, 6)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(51, 32)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 21)
        Me.dtpFechaFin.TabIndex = 2
        '
        'cmb_TrabajadorApertura_Buscado
        '
        Me.cmb_TrabajadorApertura_Buscado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmb_TrabajadorApertura_Buscado.ButtonsRight.Add(EditorButton1)
        Me.cmb_TrabajadorApertura_Buscado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_TrabajadorApertura_Buscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TrabajadorApertura_Buscado.Location = New System.Drawing.Point(863, 83)
        Me.cmb_TrabajadorApertura_Buscado.Name = "cmb_TrabajadorApertura_Buscado"
        Me.cmb_TrabajadorApertura_Buscado.Size = New System.Drawing.Size(62, 22)
        Me.cmb_TrabajadorApertura_Buscado.TabIndex = 369
        Me.cmb_TrabajadorApertura_Buscado.Visible = False
        '
        'cmb_TurnoBuscado
        '
        Me.cmb_TurnoBuscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TurnoBuscado.Location = New System.Drawing.Point(863, 31)
        Me.cmb_TurnoBuscado.Name = "cmb_TurnoBuscado"
        Me.cmb_TurnoBuscado.Size = New System.Drawing.Size(62, 22)
        Me.cmb_TurnoBuscado.TabIndex = 0
        Me.cmb_TurnoBuscado.Visible = False
        '
        'UltraLabel8
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance68
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(794, 88)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel8.TabIndex = 368
        Me.UltraLabel8.Text = "Trabajador:"
        Me.UltraLabel8.Visible = False
        '
        'UltraLabel13
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Appearance69.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance69
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(809, 35)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel13.TabIndex = 335
        Me.UltraLabel13.Text = "Turno:"
        Me.UltraLabel13.Visible = False
        '
        'cmb_EstadoBuscado
        '
        Me.cmb_EstadoBuscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_EstadoBuscado.Location = New System.Drawing.Point(863, 57)
        Me.cmb_EstadoBuscado.Name = "cmb_EstadoBuscado"
        Me.cmb_EstadoBuscado.Size = New System.Drawing.Size(62, 22)
        Me.cmb_EstadoBuscado.TabIndex = 3
        Me.cmb_EstadoBuscado.ValueMember = "Id"
        Me.cmb_EstadoBuscado.Visible = False
        '
        'UltraLabel14
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance70
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(815, 61)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel14.TabIndex = 336
        Me.UltraLabel14.Text = "Estado:"
        Me.UltraLabel14.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(982, 726)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraTabControl1)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 96)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(982, 630)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(976, 624)
        Me.UltraTabControl1.TabIndex = 6
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Precios"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Contometros"
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Varillajes"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Ventas"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Calibraciones"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Trabajadores"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(972, 598)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cboTrabajadorCierre)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.cmb_Estado)
        Me.UltraGroupBox4.Controls.Add(Me.dtpHoraFin)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.cboTrabajadorApertura)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.btnCrearCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox4.Controls.Add(Me.dtpHoraInicio)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox4.Controls.Add(Me.cmb_Turno)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(982, 96)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTrabajadorCierre
        '
        Me.cboTrabajadorCierre.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajadorCierre.ButtonsRight.Add(EditorButton2)
        Me.cboTrabajadorCierre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorCierre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorCierre.Location = New System.Drawing.Point(315, 63)
        Me.cboTrabajadorCierre.Name = "cboTrabajadorCierre"
        Me.cboTrabajadorCierre.Size = New System.Drawing.Size(247, 22)
        Me.cboTrabajadorCierre.TabIndex = 376
        '
        'UltraLabel7
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Appearance71.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance71
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(220, 69)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(89, 15)
        Me.UltraLabel7.TabIndex = 375
        Me.UltraLabel7.Text = "Trabajador (TN):"
        '
        'UltraLabel4
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance72
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(19, 66)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 374
        Me.UltraLabel4.Text = "Estado:"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Estado.Location = New System.Drawing.Point(67, 62)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(134, 22)
        Me.cmb_Estado.TabIndex = 373
        Me.cmb_Estado.ValueMember = "Id"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Enabled = False
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(459, 10)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.Size = New System.Drawing.Size(103, 21)
        Me.dtpHoraFin.TabIndex = 372
        '
        'UltraLabel1
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance73
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(430, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(23, 15)
        Me.UltraLabel1.TabIndex = 371
        Me.UltraLabel1.Text = "Fin:"
        '
        'cboTrabajadorApertura
        '
        Me.cboTrabajadorApertura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajadorApertura.ButtonsRight.Add(EditorButton3)
        Me.cboTrabajadorApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorApertura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorApertura.Location = New System.Drawing.Point(315, 36)
        Me.cboTrabajadorApertura.Name = "cboTrabajadorApertura"
        Me.cboTrabajadorApertura.Size = New System.Drawing.Size(247, 22)
        Me.cboTrabajadorApertura.TabIndex = 367
        '
        'UltraLabel11
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance74
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(220, 40)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel11.TabIndex = 366
        Me.UltraLabel11.Text = "Trabajador (TA):"
        '
        'btnCrearCtaCte
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCtaCte.Appearance = Appearance75
        Me.btnCrearCtaCte.AutoSize = True
        Me.btnCrearCtaCte.Enabled = False
        Me.btnCrearCtaCte.Location = New System.Drawing.Point(1191, 88)
        Me.btnCrearCtaCte.Name = "btnCrearCtaCte"
        Me.btnCrearCtaCte.Size = New System.Drawing.Size(10, 10)
        Me.btnCrearCtaCte.TabIndex = 28
        Me.btnCrearCtaCte.Visible = False
        '
        'UltraLabel6
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance76
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(578, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(619, 6)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(258, 76)
        Me.txtGlosa.TabIndex = 20
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Enabled = False
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(315, 9)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.Size = New System.Drawing.Size(103, 21)
        Me.dtpHoraInicio.TabIndex = 16
        '
        'UltraLabel5
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Appearance77.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance77
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(274, 14)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "Inicio:"
        '
        'UltraLabel3
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance78
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(23, 38)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Turno:"
        '
        'UltraLabel2
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance79
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(23, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(67, 10)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'cmb_Turno
        '
        Me.cmb_Turno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_Turno.Location = New System.Drawing.Point(67, 35)
        Me.cmb_Turno.Name = "cmb_Turno"
        Me.cmb_Turno.Size = New System.Drawing.Size(134, 22)
        Me.cmb_Turno.TabIndex = 7
        Me.cmb_Turno.ValueMember = "Id"
        '
        'ficOrdenComercial
        '
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenComercial.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenComercial.Name = "ficOrdenComercial"
        Me.ficOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenComercial.Size = New System.Drawing.Size(984, 749)
        Me.ficOrdenComercial.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Mantenimiento"
        Me.ficOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.ficOrdenComercial.TabStop = False
        Me.ficOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 726)
        '
        'frm_CierreTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 749)
        Me.Controls.Add(Me.ficOrdenComercial)
        Me.Name = "frm_CierreTurno"
        Me.Text = "frm_CierreTurno"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        CType(Me.udg_Combustibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCierreTurnoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCierreTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosBasicos.ResumeLayout(False)
        Me.grbDatosBasicos.PerformLayout()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TrabajadorApertura_Buscado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TurnoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EstadoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenComercial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ficOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents rdbDatosBasicos As RadioButton
    Friend WithEvents grbDatosBasicos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_TurnoBuscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_EstadoBuscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboTrabajadorApertura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCrearCtaCte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpHoraInicio As DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmb_Turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpHoraFin As DateTimePicker
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTrabajadorCierre As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udg_Almacenes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_Calibraciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_VentasAnuladas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_VentasxCombustible As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_ContometroAnalogico As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_ContometroDigital As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_Trabajadores As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmb_TrabajadorApertura_Buscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odCierreTurnoDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_Combustibles As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents odCierreTurno As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorEvaluado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorParcial As Infragistics.Win.UltraWinEditors.UltraColorPicker
End Class
