﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
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
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis ")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal ")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCierreTurno ")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grupo ")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rubro ")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion ")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConcepto ")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto ")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorInicial ")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorFinal ")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorDiferencia ")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorERP ")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorReal ")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux1 ")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorAux2 ")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa ")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inicio")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fin")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorApertura")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Inicio")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fin")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TrabajadorApertura")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Combustibles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCierreTurnoDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_ContometroAnalogico = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_ContometroDigital = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Almacenes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox17 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_VentasxCombustibleResumen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_VentasxCombustible = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_ResumenVentas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox15 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_DetalleVenta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_VentasAnuladas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Calibraciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Trabajadores = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.udg_ComprasCombustibles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.udg_DepositosBoveda = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odCierreTurno = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox16 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaCierre_Imprimir = New System.Windows.Forms.DateTimePicker()
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
        Me.tab_Detalles = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox20 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_DepositosBoveda = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraGroupBox19 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboTrabajadorApertura = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox18 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_VentasCredito_Galones = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_VentasContado_Galones = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_VentasCredito_Importe = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.nud_VentasContado_Importe = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.btn_AgregarDetalles = New System.Windows.Forms.Button()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaNuevo = New System.Windows.Forms.DateTimePicker()
        Me.cboTrabajadorCierre = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_TurnoNuevo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnCrearCtaCte = New Infragistics.Win.Misc.UltraButton()
        Me.tab_Principal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
        CType(Me.udg_Combustibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCierreTurnoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.UltraGroupBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox17.SuspendLayout()
        CType(Me.udg_VentasxCombustibleResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.udg_ResumenVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGroupBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox15.SuspendLayout()
        CType(Me.udg_DetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.udg_ComprasCombustibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.udg_DepositosBoveda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCierreTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox16.SuspendLayout()
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
        CType(Me.tab_Detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Detalles.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.UltraGroupBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox20.SuspendLayout()
        CType(Me.nud_DepositosBoveda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox19.SuspendLayout()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox18.SuspendLayout()
        CType(Me.nud_VentasCredito_Galones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_VentasContado_Galones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_VentasCredito_Importe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_VentasContado_Importe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TurnoNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox14)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1360, 474)
        '
        'UltraGroupBox14
        '
        Me.UltraGroupBox14.Controls.Add(Me.udg_Combustibles)
        Me.UltraGroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox14.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(1360, 474)
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
        Me.udg_Combustibles.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_Combustibles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Combustibles.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
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
        Me.udg_Combustibles.Size = New System.Drawing.Size(1354, 454)
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
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.udg_ContometroAnalogico)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1387, 474)
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
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance15
        UltraGridColumn13.Format = "#,###,###,##0.00"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.MaskInput = "{double:9.2}"
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance16
        UltraGridColumn14.Format = "#,###,###,##0.00"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.MaskInput = "{double:9.2}"
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance17
        UltraGridColumn15.Format = "#,###,###,##0.00"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.MaskInput = "{double:9.2}"
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance18
        UltraGridColumn16.Format = "#,###,###,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.MaskInput = "{double:9.2}"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.udg_ContometroAnalogico.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_ContometroAnalogico.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Hidden = True
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.udg_ContometroAnalogico.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.udg_ContometroAnalogico.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowAppearance = Appearance22
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroAnalogico.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroAnalogico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroAnalogico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroAnalogico.Location = New System.Drawing.Point(3, 17)
        Me.udg_ContometroAnalogico.Name = "udg_ContometroAnalogico"
        Me.udg_ContometroAnalogico.Size = New System.Drawing.Size(1381, 454)
        Me.udg_ContometroAnalogico.TabIndex = 2
        Me.udg_ContometroAnalogico.Text = "Grilla2"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.udg_ContometroDigital)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.Text = "Contometro Digital"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_ContometroDigital
        '
        Me.udg_ContometroDigital.DataSource = Me.odCierreTurnoDetalle
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ContometroDigital.DisplayLayout.Appearance = Appearance23
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
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance24
        UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn55.Format = "#,###,###,##0.00"
        UltraGridColumn55.Header.Caption = "V.Inicial "
        UltraGridColumn55.Header.VisiblePosition = 9
        UltraGridColumn55.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn271.CellAppearance = Appearance25
        UltraGridColumn271.Format = "#,###,###,##0.00"
        UltraGridColumn271.Header.VisiblePosition = 10
        UltraGridColumn271.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn272.CellAppearance = Appearance26
        UltraGridColumn272.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn272.Format = "#,###,###,##0.00"
        UltraGridColumn272.Header.VisiblePosition = 11
        UltraGridColumn272.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        UltraGridColumn273.Format = "#,###,###,##0.00"
        UltraGridColumn273.Header.VisiblePosition = 12
        UltraGridColumn273.Hidden = True
        UltraGridColumn273.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        UltraGridColumn274.Format = "#,###,###,##0.00"
        UltraGridColumn274.Header.VisiblePosition = 13
        UltraGridColumn274.Hidden = True
        UltraGridColumn274.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        UltraGridColumn275.Format = "#,###,###,##0.00"
        UltraGridColumn275.Header.VisiblePosition = 14
        UltraGridColumn275.Hidden = True
        UltraGridColumn275.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        UltraGridColumn276.Format = "#,###,###,##0.00"
        UltraGridColumn276.Header.VisiblePosition = 15
        UltraGridColumn276.Hidden = True
        UltraGridColumn276.MaskInput = "{LOC}$ -n,nnn,nnn.nn"
        UltraGridColumn277.Header.VisiblePosition = 16
        UltraGridColumn277.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277})
        Me.udg_ContometroDigital.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.udg_ContometroDigital.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Hidden = True
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.udg_ContometroDigital.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ContometroDigital.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_ContometroDigital.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroDigital.DisplayLayout.Override.RowAppearance = Appearance30
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroDigital.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroDigital.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroDigital.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroDigital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroDigital.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroDigital.Location = New System.Drawing.Point(3, 17)
        Me.udg_ContometroDigital.Name = "udg_ContometroDigital"
        Me.udg_ContometroDigital.Size = New System.Drawing.Size(1381, 454)
        Me.udg_ContometroDigital.TabIndex = 2
        Me.udg_ContometroDigital.Text = "Grilla2"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox13)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.udg_Almacenes)
        Me.UltraGroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox13.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox13.TabIndex = 4
        Me.UltraGroupBox13.Text = "Varillaje"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Almacenes
        '
        Me.udg_Almacenes.DataSource = Me.odCierreTurnoDetalle
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Almacenes.DisplayLayout.Appearance = Appearance31
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
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance32
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn27.MaskInput = "{double:9.2}"
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance33
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.MaskInput = "{double:9.2}"
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance34
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
        Appearance35.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Appearance = Appearance35
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance36
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Hidden = True
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance37.BackColor2 = System.Drawing.SystemColors.Control
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.PromptAppearance = Appearance37
        Me.udg_Almacenes.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Almacenes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Almacenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Almacenes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_Almacenes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Almacenes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_Almacenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.udg_Almacenes.DisplayLayout.Override.RowAppearance = Appearance38
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Almacenes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Almacenes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Almacenes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Almacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Almacenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Almacenes.Location = New System.Drawing.Point(3, 17)
        Me.udg_Almacenes.Name = "udg_Almacenes"
        Me.udg_Almacenes.Size = New System.Drawing.Size(1381, 454)
        Me.udg_Almacenes.TabIndex = 2
        Me.udg_Almacenes.Text = "Grilla2"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGroupBox17)
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox17
        '
        Me.UltraGroupBox17.Controls.Add(Me.udg_VentasxCombustibleResumen)
        Me.UltraGroupBox17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox17.Location = New System.Drawing.Point(775, 0)
        Me.UltraGroupBox17.Name = "UltraGroupBox17"
        Me.UltraGroupBox17.Size = New System.Drawing.Size(612, 474)
        Me.UltraGroupBox17.TabIndex = 2
        Me.UltraGroupBox17.Text = "Ventas x Combustible (Resumen)"
        Me.UltraGroupBox17.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_VentasxCombustibleResumen
        '
        Me.udg_VentasxCombustibleResumen.DataSource = Me.odCierreTurnoDetalle
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Appearance39.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Appearance = Appearance39
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 2
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 3
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 4
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 5
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 6
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 7
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 8
        UltraGridColumn75.Width = 167
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance40
        UltraGridColumn76.Header.VisiblePosition = 9
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.MaskInput = "{double:9.2}"
        UltraGridColumn77.Header.VisiblePosition = 10
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.MaskInput = "{double:9.2}"
        UltraGridColumn78.Header.VisiblePosition = 11
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.MaskInput = "{double:9.2}"
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn79.CellAppearance = Appearance41
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn79.Header.VisiblePosition = 12
        UltraGridColumn79.MaskInput = "{double:9.2}"
        UltraGridColumn80.Format = "#,###,###,##0.00"
        UltraGridColumn80.Header.VisiblePosition = 13
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 14
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 15
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 16
        UltraGridColumn83.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83})
        Me.udg_VentasxCombustibleResumen.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.udg_VentasxCombustibleResumen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustibleResumen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasxCombustibleResumen.DisplayLayout.GroupByBox.Appearance = Appearance42
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustibleResumen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance43
        Me.udg_VentasxCombustibleResumen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustibleResumen.DisplayLayout.GroupByBox.Hidden = True
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance44.BackColor2 = System.Drawing.SystemColors.Control
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustibleResumen.DisplayLayout.GroupByBox.PromptAppearance = Appearance44
        Me.udg_VentasxCombustibleResumen.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasxCombustibleResumen.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance45.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.RowAppearance = Appearance45
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasxCombustibleResumen.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasxCombustibleResumen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasxCombustibleResumen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasxCombustibleResumen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasxCombustibleResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasxCombustibleResumen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasxCombustibleResumen.Location = New System.Drawing.Point(3, 17)
        Me.udg_VentasxCombustibleResumen.Name = "udg_VentasxCombustibleResumen"
        Me.udg_VentasxCombustibleResumen.Size = New System.Drawing.Size(606, 454)
        Me.udg_VentasxCombustibleResumen.TabIndex = 3
        Me.udg_VentasxCombustibleResumen.Text = "Grilla2"
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.udg_VentasxCombustible)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(775, 474)
        Me.UltraGroupBox8.TabIndex = 1
        Me.UltraGroupBox8.Text = "Ventas x Combustible"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_VentasxCombustible
        '
        Me.udg_VentasxCombustible.DataSource = Me.odCierreTurnoDetalle
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Appearance46.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasxCombustible.DisplayLayout.Appearance = Appearance46
        UltraGridColumn137.Header.VisiblePosition = 0
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 1
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 2
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 3
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.Header.VisiblePosition = 4
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 5
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 6
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 7
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 8
        UltraGridColumn145.Width = 167
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn146.CellAppearance = Appearance47
        UltraGridColumn146.Header.VisiblePosition = 9
        UltraGridColumn146.Hidden = True
        UltraGridColumn146.MaskInput = "{double:9.2}"
        UltraGridColumn147.Header.VisiblePosition = 10
        UltraGridColumn147.Hidden = True
        UltraGridColumn147.MaskInput = "{double:9.2}"
        UltraGridColumn148.Header.VisiblePosition = 11
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.MaskInput = "{double:9.2}"
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn149.CellAppearance = Appearance48
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn149.Header.VisiblePosition = 12
        UltraGridColumn149.MaskInput = "{double:9.2}"
        UltraGridColumn150.Format = "#,###,###,##0.000"
        UltraGridColumn150.Header.VisiblePosition = 13
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 14
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 15
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 16
        UltraGridColumn153.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153})
        Me.udg_VentasxCombustible.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.udg_VentasxCombustible.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Appearance = Appearance49
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance50
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Hidden = True
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance51.BackColor2 = System.Drawing.SystemColors.Control
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.PromptAppearance = Appearance51
        Me.udg_VentasxCombustible.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_VentasxCombustible.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_VentasxCombustible.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance52.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowAppearance = Appearance52
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasxCombustible.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasxCombustible.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasxCombustible.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasxCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasxCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasxCombustible.Location = New System.Drawing.Point(3, 17)
        Me.udg_VentasxCombustible.Name = "udg_VentasxCombustible"
        Me.udg_VentasxCombustible.Size = New System.Drawing.Size(769, 454)
        Me.udg_VentasxCombustible.TabIndex = 2
        Me.udg_VentasxCombustible.Text = "Grilla2"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox9)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.udg_ResumenVentas)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox9.TabIndex = 2
        Me.UltraGroupBox9.Text = "Resumen de Ventas"
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_ResumenVentas
        '
        Me.udg_ResumenVentas.DataSource = Me.odCierreTurnoDetalle
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ResumenVentas.DisplayLayout.Appearance = Appearance53
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
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn286.CellAppearance = Appearance54
        UltraGridColumn286.Header.VisiblePosition = 9
        UltraGridColumn286.Hidden = True
        UltraGridColumn286.MaskInput = "{double:9.2}"
        UltraGridColumn287.Header.VisiblePosition = 10
        UltraGridColumn287.Hidden = True
        UltraGridColumn287.MaskInput = "{double:9.2}"
        UltraGridColumn288.Header.VisiblePosition = 11
        UltraGridColumn288.Hidden = True
        UltraGridColumn288.MaskInput = "{double:9.2}"
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn289.CellAppearance = Appearance55
        UltraGridColumn289.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn289.Header.VisiblePosition = 12
        UltraGridColumn289.MaskInput = "{double:9.2}"
        UltraGridColumn290.Format = "#,###,###,##0.00"
        UltraGridColumn290.Header.VisiblePosition = 13
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 14
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 15
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.Header.VisiblePosition = 16
        UltraGridColumn293.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293})
        Me.udg_ResumenVentas.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.udg_ResumenVentas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ResumenVentas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance56.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance56.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ResumenVentas.DisplayLayout.GroupByBox.Appearance = Appearance56
        Appearance57.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ResumenVentas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance57
        Me.udg_ResumenVentas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ResumenVentas.DisplayLayout.GroupByBox.Hidden = True
        Appearance58.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance58.BackColor2 = System.Drawing.SystemColors.Control
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance58.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ResumenVentas.DisplayLayout.GroupByBox.PromptAppearance = Appearance58
        Me.udg_ResumenVentas.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ResumenVentas.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ResumenVentas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ResumenVentas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ResumenVentas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ResumenVentas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ResumenVentas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_ResumenVentas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ResumenVentas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_ResumenVentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ResumenVentas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_ResumenVentas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.udg_ResumenVentas.DisplayLayout.Override.RowAppearance = Appearance59
        Me.udg_ResumenVentas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ResumenVentas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ResumenVentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ResumenVentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ResumenVentas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ResumenVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ResumenVentas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ResumenVentas.Location = New System.Drawing.Point(3, 17)
        Me.udg_ResumenVentas.Name = "udg_ResumenVentas"
        Me.udg_ResumenVentas.Size = New System.Drawing.Size(1381, 454)
        Me.udg_ResumenVentas.TabIndex = 3
        Me.udg_ResumenVentas.Text = "Grilla2"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGroupBox15)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox15
        '
        Me.UltraGroupBox15.Controls.Add(Me.udg_DetalleVenta)
        Me.UltraGroupBox15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox15.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox15.Name = "UltraGroupBox15"
        Me.UltraGroupBox15.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox15.TabIndex = 2
        Me.UltraGroupBox15.Text = "Ventas x Combustible"
        Me.UltraGroupBox15.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_DetalleVenta
        '
        Me.udg_DetalleVenta.DataSource = Me.odCierreTurnoDetalle
        Appearance60.BackColor = System.Drawing.SystemColors.Window
        Appearance60.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_DetalleVenta.DisplayLayout.Appearance = Appearance60
        UltraGridColumn102.Header.VisiblePosition = 0
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 1
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 2
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 3
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 4
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 5
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 6
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 7
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 8
        UltraGridColumn110.Width = 167
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn111.CellAppearance = Appearance61
        UltraGridColumn111.Header.VisiblePosition = 9
        UltraGridColumn111.Hidden = True
        UltraGridColumn111.MaskInput = "{double:9.2}"
        UltraGridColumn112.Header.VisiblePosition = 10
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.MaskInput = "{double:9.2}"
        UltraGridColumn113.Header.VisiblePosition = 11
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.MaskInput = "{double:9.2}"
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn114.CellAppearance = Appearance62
        UltraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn114.Header.VisiblePosition = 12
        UltraGridColumn114.MaskInput = "{double:9.2}"
        UltraGridColumn115.Format = "#,###,###,##0.00"
        UltraGridColumn115.Header.VisiblePosition = 13
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 14
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 15
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 16
        UltraGridColumn118.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118})
        Me.udg_DetalleVenta.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.udg_DetalleVenta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DetalleVenta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance63.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance63.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_DetalleVenta.DisplayLayout.GroupByBox.Appearance = Appearance63
        Appearance64.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DetalleVenta.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance64
        Me.udg_DetalleVenta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DetalleVenta.DisplayLayout.GroupByBox.Hidden = True
        Appearance65.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance65.BackColor2 = System.Drawing.SystemColors.Control
        Appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance65.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DetalleVenta.DisplayLayout.GroupByBox.PromptAppearance = Appearance65
        Me.udg_DetalleVenta.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_DetalleVenta.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_DetalleVenta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DetalleVenta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DetalleVenta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DetalleVenta.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DetalleVenta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_DetalleVenta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_DetalleVenta.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_DetalleVenta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_DetalleVenta.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_DetalleVenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance66.BorderColor = System.Drawing.Color.Silver
        Me.udg_DetalleVenta.DisplayLayout.Override.RowAppearance = Appearance66
        Me.udg_DetalleVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_DetalleVenta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_DetalleVenta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_DetalleVenta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_DetalleVenta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_DetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_DetalleVenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_DetalleVenta.Location = New System.Drawing.Point(3, 17)
        Me.udg_DetalleVenta.Name = "udg_DetalleVenta"
        Me.udg_DetalleVenta.Size = New System.Drawing.Size(1381, 454)
        Me.udg_DetalleVenta.TabIndex = 2
        Me.udg_DetalleVenta.Text = "Grilla2"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGroupBox11)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.udg_VentasAnuladas)
        Me.UltraGroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox11.TabIndex = 3
        Me.UltraGroupBox11.Text = "Ventas Anuladas"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_VentasAnuladas
        '
        Me.udg_VentasAnuladas.DataSource = Me.odCierreTurnoDetalle
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Appearance67.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasAnuladas.DisplayLayout.Appearance = Appearance67
        UltraGridColumn84.Header.VisiblePosition = 0
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 1
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 2
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 3
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 4
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 5
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 6
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 7
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 8
        UltraGridColumn92.Width = 162
        UltraGridColumn93.Header.VisiblePosition = 9
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 10
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 11
        UltraGridColumn95.Hidden = True
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance68
        UltraGridColumn97.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn97.Header.VisiblePosition = 12
        UltraGridColumn97.MaskInput = "{double:9.2}"
        UltraGridColumn98.Format = "#,###,###,##0.00"
        UltraGridColumn98.Header.VisiblePosition = 13
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 14
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 15
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 16
        UltraGridColumn101.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101})
        Me.udg_VentasAnuladas.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.udg_VentasAnuladas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance69.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Appearance = Appearance69
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance70
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Hidden = True
        Appearance71.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance71.BackColor2 = System.Drawing.SystemColors.Control
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance71.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.PromptAppearance = Appearance71
        Me.udg_VentasAnuladas.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_VentasAnuladas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_VentasAnuladas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance72.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowAppearance = Appearance72
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasAnuladas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasAnuladas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasAnuladas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasAnuladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasAnuladas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasAnuladas.Location = New System.Drawing.Point(3, 17)
        Me.udg_VentasAnuladas.Name = "udg_VentasAnuladas"
        Me.udg_VentasAnuladas.Size = New System.Drawing.Size(1381, 454)
        Me.udg_VentasAnuladas.TabIndex = 2
        Me.udg_VentasAnuladas.Text = "Grilla2"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1387, 474)
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.udg_Calibraciones)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(1387, 474)
        Me.UltraGroupBox10.TabIndex = 3
        Me.UltraGroupBox10.Text = "Calibraciones"
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Calibraciones
        '
        Me.udg_Calibraciones.DataSource = Me.odCierreTurnoDetalle
        Appearance73.BackColor = System.Drawing.SystemColors.Window
        Appearance73.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Calibraciones.DisplayLayout.Appearance = Appearance73
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
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn356.CellAppearance = Appearance74
        UltraGridColumn356.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn356.Header.VisiblePosition = 12
        UltraGridColumn356.MaskInput = "{double:9.2}"
        UltraGridColumn357.Format = "#,###,###,##0.00"
        UltraGridColumn357.Header.VisiblePosition = 13
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 14
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.VisiblePosition = 15
        UltraGridColumn359.Hidden = True
        UltraGridColumn360.Header.VisiblePosition = 16
        UltraGridColumn360.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn201, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360})
        Me.udg_Calibraciones.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.udg_Calibraciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance75.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance75.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance75.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Appearance = Appearance75
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance76
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Hidden = True
        Appearance77.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance77.BackColor2 = System.Drawing.SystemColors.Control
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance77.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.PromptAppearance = Appearance77
        Me.udg_Calibraciones.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Calibraciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Calibraciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Calibraciones.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_Calibraciones.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Calibraciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_Calibraciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance78.BorderColor = System.Drawing.Color.Silver
        Me.udg_Calibraciones.DisplayLayout.Override.RowAppearance = Appearance78
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Calibraciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Calibraciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Calibraciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Calibraciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Calibraciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Calibraciones.Location = New System.Drawing.Point(3, 17)
        Me.udg_Calibraciones.Name = "udg_Calibraciones"
        Me.udg_Calibraciones.Size = New System.Drawing.Size(1381, 454)
        Me.udg_Calibraciones.TabIndex = 2
        Me.udg_Calibraciones.Text = "Grilla2"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGroupBox12)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1360, 552)
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.udg_Trabajadores)
        Me.UltraGroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(1360, 552)
        Me.UltraGroupBox12.TabIndex = 0
        Me.UltraGroupBox12.Text = "Trabajadores"
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Trabajadores
        '
        Me.udg_Trabajadores.DataSource = Me.odCierreTurnoDetalle
        Appearance79.BackColor = System.Drawing.SystemColors.Window
        Appearance79.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Trabajadores.DisplayLayout.Appearance = Appearance79
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
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46})
        Me.udg_Trabajadores.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.udg_Trabajadores.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance80.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance80.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance80.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Appearance = Appearance80
        Appearance81.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance81
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Hidden = True
        Appearance82.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance82.BackColor2 = System.Drawing.SystemColors.Control
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance82.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.PromptAppearance = Appearance82
        Me.udg_Trabajadores.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Trabajadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Trabajadores.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Trabajadores.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_Trabajadores.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Trabajadores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_Trabajadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance83.BorderColor = System.Drawing.Color.Silver
        Me.udg_Trabajadores.DisplayLayout.Override.RowAppearance = Appearance83
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Trabajadores.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Trabajadores.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Trabajadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Trabajadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Trabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Trabajadores.Location = New System.Drawing.Point(3, 17)
        Me.udg_Trabajadores.Name = "udg_Trabajadores"
        Me.udg_Trabajadores.Size = New System.Drawing.Size(1354, 532)
        Me.udg_Trabajadores.TabIndex = 2
        Me.udg_Trabajadores.Text = "Grilla2"
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.udg_ComprasCombustibles)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1387, 474)
        '
        'udg_ComprasCombustibles
        '
        Me.udg_ComprasCombustibles.DataSource = Me.odCierreTurnoDetalle
        Appearance84.BackColor = System.Drawing.SystemColors.Window
        Appearance84.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ComprasCombustibles.DisplayLayout.Appearance = Appearance84
        UltraGridColumn154.Header.VisiblePosition = 0
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 1
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 2
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 3
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 4
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 5
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 6
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 7
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 8
        UltraGridColumn162.Width = 167
        Appearance85.TextHAlignAsString = "Right"
        UltraGridColumn163.CellAppearance = Appearance85
        UltraGridColumn163.Header.VisiblePosition = 9
        UltraGridColumn163.Hidden = True
        UltraGridColumn163.MaskInput = "{double:9.2}"
        UltraGridColumn164.Header.VisiblePosition = 10
        UltraGridColumn164.Hidden = True
        UltraGridColumn164.MaskInput = "{double:9.2}"
        UltraGridColumn165.Header.VisiblePosition = 11
        UltraGridColumn165.Hidden = True
        UltraGridColumn165.MaskInput = "{double:9.2}"
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn166.CellAppearance = Appearance86
        UltraGridColumn166.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn166.Header.VisiblePosition = 12
        UltraGridColumn166.MaskInput = "{double:9.2}"
        UltraGridColumn167.Format = "#,###,###,##0.000"
        UltraGridColumn167.Header.VisiblePosition = 13
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 14
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 15
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 16
        UltraGridColumn170.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170})
        Me.udg_ComprasCombustibles.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.udg_ComprasCombustibles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ComprasCombustibles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance87.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance87.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance87.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ComprasCombustibles.DisplayLayout.GroupByBox.Appearance = Appearance87
        Appearance88.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ComprasCombustibles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance88
        Me.udg_ComprasCombustibles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ComprasCombustibles.DisplayLayout.GroupByBox.Hidden = True
        Appearance89.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance89.BackColor2 = System.Drawing.SystemColors.Control
        Appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance89.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ComprasCombustibles.DisplayLayout.GroupByBox.PromptAppearance = Appearance89
        Me.udg_ComprasCombustibles.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ComprasCombustibles.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ComprasCombustibles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ComprasCombustibles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ComprasCombustibles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ComprasCombustibles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ComprasCombustibles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_ComprasCombustibles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ComprasCombustibles.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_ComprasCombustibles.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ComprasCombustibles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_ComprasCombustibles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance90.BorderColor = System.Drawing.Color.Silver
        Me.udg_ComprasCombustibles.DisplayLayout.Override.RowAppearance = Appearance90
        Me.udg_ComprasCombustibles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ComprasCombustibles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ComprasCombustibles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ComprasCombustibles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ComprasCombustibles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ComprasCombustibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ComprasCombustibles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ComprasCombustibles.Location = New System.Drawing.Point(0, 0)
        Me.udg_ComprasCombustibles.Name = "udg_ComprasCombustibles"
        Me.udg_ComprasCombustibles.Size = New System.Drawing.Size(1387, 474)
        Me.udg_ComprasCombustibles.TabIndex = 3
        Me.udg_ComprasCombustibles.Text = "Grilla2"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.udg_DepositosBoveda)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(1360, 572)
        '
        'udg_DepositosBoveda
        '
        Me.udg_DepositosBoveda.DataSource = Me.odCierreTurnoDetalle
        Appearance91.BackColor = System.Drawing.SystemColors.Window
        Appearance91.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_DepositosBoveda.DisplayLayout.Appearance = Appearance91
        UltraGridColumn119.Header.VisiblePosition = 0
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 1
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 2
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 3
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 4
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 5
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 6
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 7
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 8
        UltraGridColumn127.Width = 167
        Appearance92.TextHAlignAsString = "Right"
        UltraGridColumn128.CellAppearance = Appearance92
        UltraGridColumn128.Header.VisiblePosition = 9
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.MaskInput = "{double:9.2}"
        UltraGridColumn129.Header.VisiblePosition = 10
        UltraGridColumn129.Hidden = True
        UltraGridColumn129.MaskInput = "{double:9.2}"
        UltraGridColumn130.Header.VisiblePosition = 11
        UltraGridColumn130.Hidden = True
        UltraGridColumn130.MaskInput = "{double:9.2}"
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn132.CellAppearance = Appearance93
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn132.Header.VisiblePosition = 12
        UltraGridColumn132.MaskInput = "{double:9.2}"
        UltraGridColumn133.Format = "#,###,###,##0.000"
        UltraGridColumn133.Header.VisiblePosition = 13
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 14
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 15
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 16
        UltraGridColumn136.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136})
        Me.udg_DepositosBoveda.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.udg_DepositosBoveda.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DepositosBoveda.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance94.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance94.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_DepositosBoveda.DisplayLayout.GroupByBox.Appearance = Appearance94
        Appearance95.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DepositosBoveda.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance95
        Me.udg_DepositosBoveda.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_DepositosBoveda.DisplayLayout.GroupByBox.Hidden = True
        Appearance96.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance96.BackColor2 = System.Drawing.SystemColors.Control
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance96.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_DepositosBoveda.DisplayLayout.GroupByBox.PromptAppearance = Appearance96
        Me.udg_DepositosBoveda.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_DepositosBoveda.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_DepositosBoveda.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DepositosBoveda.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_DepositosBoveda.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DepositosBoveda.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_DepositosBoveda.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_DepositosBoveda.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_DepositosBoveda.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.udg_DepositosBoveda.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_DepositosBoveda.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.udg_DepositosBoveda.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance97.BorderColor = System.Drawing.Color.Silver
        Me.udg_DepositosBoveda.DisplayLayout.Override.RowAppearance = Appearance97
        Me.udg_DepositosBoveda.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_DepositosBoveda.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_DepositosBoveda.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_DepositosBoveda.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_DepositosBoveda.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_DepositosBoveda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_DepositosBoveda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_DepositosBoveda.Location = New System.Drawing.Point(0, 0)
        Me.udg_DepositosBoveda.Name = "udg_DepositosBoveda"
        Me.udg_DepositosBoveda.Size = New System.Drawing.Size(1360, 572)
        Me.udg_DepositosBoveda.TabIndex = 4
        Me.udg_DepositosBoveda.Text = "Grilla2"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1368, 726)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 108)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1368, 618)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Me.griOrdenComercial.DataSource = Me.odCierreTurno
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Appearance98.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance98
        UltraGridColumn236.Header.VisiblePosition = 0
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridColumn62.Header.VisiblePosition = 2
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn64.Header.VisiblePosition = 4
        UltraGridColumn65.Header.VisiblePosition = 5
        UltraGridColumn66.Header.VisiblePosition = 6
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn236, UltraGridColumn60, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance99.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance99.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance99
        Appearance100.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance100
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance101.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance101.BackColor2 = System.Drawing.SystemColors.Control
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance101.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance101
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance102.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance102
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(1362, 612)
        Me.griOrdenComercial.TabIndex = 1
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'odCierreTurno
        '
        Me.odCierreTurno.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox16)
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
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1368, 108)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox16
        '
        Appearance103.BackColor = System.Drawing.Color.White
        Appearance103.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox16.ContentAreaAppearance = Appearance103
        Me.UltraGroupBox16.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox16.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox16.Controls.Add(Me.dtp_FechaCierre_Imprimir)
        Me.UltraGroupBox16.Location = New System.Drawing.Point(337, 22)
        Me.UltraGroupBox16.Name = "UltraGroupBox16"
        Me.UltraGroupBox16.Size = New System.Drawing.Size(204, 78)
        Me.UltraGroupBox16.TabIndex = 371
        Me.UltraGroupBox16.Text = "Cierre de Caja Completo"
        Me.UltraGroupBox16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(7, 46)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(187, 23)
        Me.UltraButton1.TabIndex = 359
        Me.UltraButton1.Text = "Imprimir Cierre Total"
        '
        'UltraLabel10
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Appearance104.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance104
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(6, 22)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(86, 15)
        Me.UltraLabel10.TabIndex = 358
        Me.UltraLabel10.Text = "Fecha de Cierre:"
        '
        'dtp_FechaCierre_Imprimir
        '
        Me.dtp_FechaCierre_Imprimir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCierre_Imprimir.Location = New System.Drawing.Point(98, 20)
        Me.dtp_FechaCierre_Imprimir.Name = "dtp_FechaCierre_Imprimir"
        Me.dtp_FechaCierre_Imprimir.Size = New System.Drawing.Size(96, 21)
        Me.dtp_FechaCierre_Imprimir.TabIndex = 357
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
        Appearance105.BackColor = System.Drawing.Color.White
        Appearance105.BackColor2 = System.Drawing.Color.White
        Me.grbDatosBasicos.ContentAreaAppearance = Appearance105
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
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Appearance106.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance106
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
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Appearance107.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance107
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
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Appearance108.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance108
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
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance109
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
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Appearance110.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance110
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
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance111
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
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Appearance112.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance112
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
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1368, 726)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.tab_Detalles)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 125)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1368, 601)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tab_Detalles
        '
        Me.tab_Detalles.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl3)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl4)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl5)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl6)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl7)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl8)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl9)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl10)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl11)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl12)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl13)
        Me.tab_Detalles.Controls.Add(Me.UltraTabPageControl14)
        Me.tab_Detalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Detalles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_Detalles.Location = New System.Drawing.Point(3, 3)
        Me.tab_Detalles.Name = "tab_Detalles"
        Me.tab_Detalles.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tab_Detalles.Size = New System.Drawing.Size(1362, 595)
        Me.tab_Detalles.TabIndex = 6
        Appearance113.BackColor = System.Drawing.Color.White
        UltraTab1.Appearance = Appearance113
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Precios"
        Appearance114.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraTab11.Appearance = Appearance114
        UltraTab11.TabPage = Me.UltraTabPageControl11
        UltraTab11.Text = "Contometros Mecanicos"
        Appearance115.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraTab2.Appearance = Appearance115
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Contometros Digitales"
        Appearance116.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraTab3.Appearance = Appearance116
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Varillajes"
        Appearance117.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab12.Appearance = Appearance117
        UltraTab12.TabPage = Me.UltraTabPageControl12
        UltraTab12.Text = "Ventas"
        Appearance118.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab6.Appearance = Appearance118
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Resumen de Ventas"
        Appearance119.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab10.Appearance = Appearance119
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Detalle de Ventas"
        Appearance120.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab9.Appearance = Appearance120
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Ventas Anuladas"
        Appearance121.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab7.Appearance = Appearance121
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Calibraciones"
        Appearance122.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraTab8.Appearance = Appearance122
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Trabajadores"
        UltraTab8.Visible = False
        Appearance123.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraTab13.Appearance = Appearance123
        UltraTab13.TabPage = Me.UltraTabPageControl13
        UltraTab13.Text = "Compras"
        Appearance124.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance124.BorderColor = System.Drawing.Color.White
        UltraTab14.Appearance = Appearance124
        UltraTab14.TabPage = Me.UltraTabPageControl14
        UltraTab14.Text = "Depósitos a Bóveda"
        Me.tab_Detalles.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab11, UltraTab2, UltraTab3, UltraTab12, UltraTab6, UltraTab10, UltraTab9, UltraTab7, UltraTab8, UltraTab13, UltraTab14})
        Me.tab_Detalles.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1360, 572)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox20)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox19)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox18)
        Me.UltraGroupBox4.Controls.Add(Me.btn_AgregarDetalles)
        Me.UltraGroupBox4.Controls.Add(Me.btnCrearCtaCte)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1368, 125)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox20
        '
        Appearance125.BackColor = System.Drawing.Color.White
        Appearance125.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox20.ContentAreaAppearance = Appearance125
        Me.UltraGroupBox20.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox20.Controls.Add(Me.nud_DepositosBoveda)
        Me.UltraGroupBox20.Location = New System.Drawing.Point(921, 76)
        Me.UltraGroupBox20.Name = "UltraGroupBox20"
        Me.UltraGroupBox20.Size = New System.Drawing.Size(350, 49)
        Me.UltraGroupBox20.TabIndex = 34
        Me.UltraGroupBox20.Text = "Depositos a Boveda (Totales)"
        Me.UltraGroupBox20.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel25
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance126
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(4, 24)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel25.TabIndex = 27
        Me.UltraLabel25.Text = "Contado S/:"
        '
        'nud_DepositosBoveda
        '
        Me.nud_DepositosBoveda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_DepositosBoveda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_DepositosBoveda.Location = New System.Drawing.Point(69, 20)
        Me.nud_DepositosBoveda.MaskInput = "{double:9.2}"
        Me.nud_DepositosBoveda.Name = "nud_DepositosBoveda"
        Me.nud_DepositosBoveda.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_DepositosBoveda.ReadOnly = True
        Me.nud_DepositosBoveda.Size = New System.Drawing.Size(100, 22)
        Me.nud_DepositosBoveda.TabIndex = 26
        '
        'UltraGroupBox19
        '
        Appearance127.BackColor = System.Drawing.Color.White
        Appearance127.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox19.ContentAreaAppearance = Appearance127
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox19.Controls.Add(Me.cmb_Turno)
        Me.UltraGroupBox19.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox19.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox19.Controls.Add(Me.cmb_Estado)
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox19.Controls.Add(Me.dtpHoraFin)
        Me.UltraGroupBox19.Controls.Add(Me.dtpHoraInicio)
        Me.UltraGroupBox19.Controls.Add(Me.cboTrabajadorApertura)
        Me.UltraGroupBox19.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox19.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox19.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox19.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox19.Name = "UltraGroupBox19"
        Me.UltraGroupBox19.Size = New System.Drawing.Size(916, 119)
        Me.UltraGroupBox19.TabIndex = 379
        Me.UltraGroupBox19.Text = "Turno Actual"
        Me.UltraGroupBox19.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel3
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Appearance128.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance128
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(4, 27)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Turno:"
        '
        'cmb_Turno
        '
        Me.cmb_Turno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_Turno.Location = New System.Drawing.Point(45, 24)
        Me.cmb_Turno.Name = "cmb_Turno"
        Me.cmb_Turno.Size = New System.Drawing.Size(100, 22)
        Me.cmb_Turno.TabIndex = 7
        Me.cmb_Turno.ValueMember = "Id"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(45, 49)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'UltraLabel4
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance129
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(201, 95)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 374
        Me.UltraLabel4.Text = "Estado:"
        '
        'UltraLabel2
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Appearance134.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance134
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(4, 52)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Fecha:"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Estado.Location = New System.Drawing.Point(245, 91)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(134, 22)
        Me.cmb_Estado.TabIndex = 373
        Me.cmb_Estado.ValueMember = "Id"
        '
        'UltraLabel5
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Appearance135.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance135
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(7, 76)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "Inicio:"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(45, 95)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.Size = New System.Drawing.Size(100, 21)
        Me.dtpHoraFin.TabIndex = 372
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(45, 73)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.Size = New System.Drawing.Size(100, 21)
        Me.dtpHoraInicio.TabIndex = 16
        '
        'cboTrabajadorApertura
        '
        Me.cboTrabajadorApertura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance136.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton3.Appearance = Appearance136
        Me.cboTrabajadorApertura.ButtonsRight.Add(EditorButton3)
        Me.cboTrabajadorApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorApertura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorApertura.Location = New System.Drawing.Point(245, 25)
        Me.cboTrabajadorApertura.Name = "cboTrabajadorApertura"
        Me.cboTrabajadorApertura.Size = New System.Drawing.Size(300, 22)
        Me.cboTrabajadorApertura.TabIndex = 367
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(245, 49)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(300, 35)
        Me.txtGlosa.TabIndex = 20
        '
        'UltraLabel11
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Appearance137.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance137
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(150, 29)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel11.TabIndex = 366
        Me.UltraLabel11.Text = "Trabajador (TA):"
        '
        'UltraLabel6
        '
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Appearance138.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance138
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(205, 53)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Glosa:"
        '
        'UltraGroupBox18
        '
        Appearance139.BackColor = System.Drawing.Color.White
        Appearance139.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox18.ContentAreaAppearance = Appearance139
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox18.Controls.Add(Me.nud_VentasCredito_Galones)
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox18.Controls.Add(Me.nud_VentasContado_Galones)
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox18.Controls.Add(Me.nud_VentasCredito_Importe)
        Me.UltraGroupBox18.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox18.Controls.Add(Me.nud_VentasContado_Importe)
        Me.UltraGroupBox18.Location = New System.Drawing.Point(921, 3)
        Me.UltraGroupBox18.Name = "UltraGroupBox18"
        Me.UltraGroupBox18.Size = New System.Drawing.Size(350, 72)
        Me.UltraGroupBox18.TabIndex = 3
        Me.UltraGroupBox18.Text = "Ventas de Combustibles (Totales)"
        Me.UltraGroupBox18.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel18
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Appearance140.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance140
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(178, 49)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel18.TabIndex = 33
        Me.UltraLabel18.Text = "Credito Gls:"
        '
        'nud_VentasCredito_Galones
        '
        Me.nud_VentasCredito_Galones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_VentasCredito_Galones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_VentasCredito_Galones.Location = New System.Drawing.Point(246, 45)
        Me.nud_VentasCredito_Galones.MaskInput = "{double:9.2}"
        Me.nud_VentasCredito_Galones.Name = "nud_VentasCredito_Galones"
        Me.nud_VentasCredito_Galones.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_VentasCredito_Galones.ReadOnly = True
        Me.nud_VentasCredito_Galones.Size = New System.Drawing.Size(100, 22)
        Me.nud_VentasCredito_Galones.TabIndex = 32
        '
        'UltraLabel19
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Appearance141.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance141
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(172, 24)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel19.TabIndex = 31
        Me.UltraLabel19.Text = "Contado Gls:"
        '
        'nud_VentasContado_Galones
        '
        Me.nud_VentasContado_Galones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_VentasContado_Galones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_VentasContado_Galones.Location = New System.Drawing.Point(246, 20)
        Me.nud_VentasContado_Galones.MaskInput = "{double:9.2}"
        Me.nud_VentasContado_Galones.Name = "nud_VentasContado_Galones"
        Me.nud_VentasContado_Galones.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_VentasContado_Galones.ReadOnly = True
        Me.nud_VentasContado_Galones.Size = New System.Drawing.Size(100, 22)
        Me.nud_VentasContado_Galones.TabIndex = 30
        '
        'UltraLabel17
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Appearance142.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance142
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(8, 49)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(58, 15)
        Me.UltraLabel17.TabIndex = 29
        Me.UltraLabel17.Text = "Credito S/:"
        '
        'nud_VentasCredito_Importe
        '
        Me.nud_VentasCredito_Importe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_VentasCredito_Importe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_VentasCredito_Importe.Location = New System.Drawing.Point(69, 45)
        Me.nud_VentasCredito_Importe.MaskInput = "{double:9.2}"
        Me.nud_VentasCredito_Importe.Name = "nud_VentasCredito_Importe"
        Me.nud_VentasCredito_Importe.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_VentasCredito_Importe.ReadOnly = True
        Me.nud_VentasCredito_Importe.Size = New System.Drawing.Size(100, 22)
        Me.nud_VentasCredito_Importe.TabIndex = 28
        '
        'UltraLabel12
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Appearance143.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance143
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(2, 24)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(64, 15)
        Me.UltraLabel12.TabIndex = 27
        Me.UltraLabel12.Text = "Contado S/:"
        '
        'nud_VentasContado_Importe
        '
        Me.nud_VentasContado_Importe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nud_VentasContado_Importe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_VentasContado_Importe.Location = New System.Drawing.Point(69, 20)
        Me.nud_VentasContado_Importe.MaskInput = "{double:9.2}"
        Me.nud_VentasContado_Importe.Name = "nud_VentasContado_Importe"
        Me.nud_VentasContado_Importe.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nud_VentasContado_Importe.ReadOnly = True
        Me.nud_VentasContado_Importe.Size = New System.Drawing.Size(100, 22)
        Me.nud_VentasContado_Importe.TabIndex = 26
        '
        'btn_AgregarDetalles
        '
        Me.btn_AgregarDetalles.Location = New System.Drawing.Point(1181, 10)
        Me.btn_AgregarDetalles.Name = "btn_AgregarDetalles"
        Me.btn_AgregarDetalles.Size = New System.Drawing.Size(10, 10)
        Me.btn_AgregarDetalles.TabIndex = 378
        Me.btn_AgregarDetalles.UseVisualStyleBackColor = True
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.dtp_FechaNuevo)
        Me.UltraGroupBox2.Controls.Add(Me.cboTrabajadorCierre)
        Me.UltraGroupBox2.Controls.Add(Me.cmb_TurnoNuevo)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.ForeColor = System.Drawing.Color.Black
        Me.UltraGroupBox2.Location = New System.Drawing.Point(549, 17)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(364, 99)
        Me.UltraGroupBox2.TabIndex = 377
        Me.UltraGroupBox2.Text = "Datos de Turno Nuevo"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel9
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Appearance130.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance130
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(17, 25)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel9.TabIndex = 378
        Me.UltraLabel9.Text = "Fecha:"
        '
        'UltraLabel1
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Appearance131.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance131
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(17, 50)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 378
        Me.UltraLabel1.Text = "Turno:"
        '
        'dtp_FechaNuevo
        '
        Me.dtp_FechaNuevo.Enabled = False
        Me.dtp_FechaNuevo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNuevo.Location = New System.Drawing.Point(58, 22)
        Me.dtp_FechaNuevo.Name = "dtp_FechaNuevo"
        Me.dtp_FechaNuevo.Size = New System.Drawing.Size(113, 21)
        Me.dtp_FechaNuevo.TabIndex = 379
        '
        'cboTrabajadorCierre
        '
        Me.cboTrabajadorCierre.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance132.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton2.Appearance = Appearance132
        Me.cboTrabajadorCierre.ButtonsRight.Add(EditorButton2)
        Me.cboTrabajadorCierre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorCierre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorCierre.Location = New System.Drawing.Point(58, 70)
        Me.cboTrabajadorCierre.Name = "cboTrabajadorCierre"
        Me.cboTrabajadorCierre.Size = New System.Drawing.Size(300, 22)
        Me.cboTrabajadorCierre.TabIndex = 376
        '
        'cmb_TurnoNuevo
        '
        Me.cmb_TurnoNuevo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TurnoNuevo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_TurnoNuevo.Location = New System.Drawing.Point(58, 46)
        Me.cmb_TurnoNuevo.Name = "cmb_TurnoNuevo"
        Me.cmb_TurnoNuevo.Size = New System.Drawing.Size(94, 22)
        Me.cmb_TurnoNuevo.TabIndex = 379
        Me.cmb_TurnoNuevo.ValueMember = "Id"
        '
        'UltraLabel7
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Appearance133.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance133
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(4, 73)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(51, 15)
        Me.UltraLabel7.TabIndex = 375
        Me.UltraLabel7.Text = "Apertura:"
        '
        'btnCrearCtaCte
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCtaCte.Appearance = Appearance144
        Me.btnCrearCtaCte.AutoSize = True
        Me.btnCrearCtaCte.Enabled = False
        Me.btnCrearCtaCte.Location = New System.Drawing.Point(1168, 12)
        Me.btnCrearCtaCte.Name = "btnCrearCtaCte"
        Me.btnCrearCtaCte.Size = New System.Drawing.Size(10, 10)
        Me.btnCrearCtaCte.TabIndex = 28
        Me.btnCrearCtaCte.Visible = False
        '
        'tab_Principal
        '
        Me.tab_Principal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tab_Principal.Controls.Add(Me.UltraTabPageControl1)
        Me.tab_Principal.Controls.Add(Me.UltraTabPageControl2)
        Me.tab_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tab_Principal.Name = "tab_Principal"
        Me.tab_Principal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tab_Principal.Size = New System.Drawing.Size(1370, 749)
        Me.tab_Principal.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Mantenimiento"
        Me.tab_Principal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.tab_Principal.TabStop = False
        Me.tab_Principal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1368, 726)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_CierreTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.tab_Principal)
        Me.Name = "frm_CierreTurno"
        Me.Text = "frm_CierreTurno"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        CType(Me.udg_Combustibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCierreTurnoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.UltraGroupBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox17.ResumeLayout(False)
        CType(Me.udg_VentasxCombustibleResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        CType(Me.udg_ResumenVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGroupBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox15.ResumeLayout(False)
        CType(Me.udg_DetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.udg_ComprasCombustibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        CType(Me.udg_DepositosBoveda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCierreTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox16.ResumeLayout(False)
        Me.UltraGroupBox16.PerformLayout()
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
        CType(Me.tab_Detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Detalles.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.UltraGroupBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox20.ResumeLayout(False)
        Me.UltraGroupBox20.PerformLayout()
        CType(Me.nud_DepositosBoveda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox19.ResumeLayout(False)
        Me.UltraGroupBox19.PerformLayout()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox18.ResumeLayout(False)
        Me.UltraGroupBox18.PerformLayout()
        CType(Me.nud_VentasCredito_Galones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_VentasContado_Galones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_VentasCredito_Importe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_VentasContado_Importe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TurnoNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Principal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_Principal As Infragistics.Win.UltraWinTabControl.UltraTabControl
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
    Friend WithEvents tab_Detalles As Infragistics.Win.UltraWinTabControl.UltraTabControl
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
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_TurnoNuevo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaNuevo As DateTimePicker
    Friend WithEvents udg_ResumenVentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox15 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_DetalleVenta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents udg_VentasxCombustibleResumen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Filtro1 As Controles.Filtro
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents btn_AgregarDetalles As Button
    Friend WithEvents UltraGroupBox16 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaCierre_Imprimir As DateTimePicker
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents udg_ComprasCombustibles As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents udg_DepositosBoveda As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox17 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox18 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nud_VentasCredito_Importe As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nud_VentasContado_Importe As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraGroupBox20 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nud_DepositosBoveda As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraGroupBox19 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nud_VentasCredito_Galones As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents nud_VentasContado_Galones As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
