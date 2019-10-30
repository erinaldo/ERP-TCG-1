<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegistroConsumoCombustible
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloTracto")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROrigen")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RDestino")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGls")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rutas")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModif")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModif")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqOrigen")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EqDestino")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Credito")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Credito")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModeloTracto")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ROrigen")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RDestino")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGls")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rutas")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Credito")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModif")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModif")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqOrigen")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EqDestino")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RegistroConsumoCombustible))
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KilometrosTanqueo")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGalon")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCredito")
        Dim UltraGridColumn434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim UltraGridColumn435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoGls")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomGrifo")
        Dim UltraGridColumn454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomDireccion")
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomLugar")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueoNoAsoc")
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIsl")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodViaje")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KilometrosTanqueo")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGalon")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGrifo")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDireccion")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCredito")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueo")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRegistroInventario")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoGls")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrifo")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaVeh")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMaterial")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomGrifo")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomDireccion")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NomLugar")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTanqueoNoAsoc")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIsl")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KilometrosTanqueo")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGalon")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCredito")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoGls")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomGrifo")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomDireccion")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomLugar")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueoNoAsoc")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIsl")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance250 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance251 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance252 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance253 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance254 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance255 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance256 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance257 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance258 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance259 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance260 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance261 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance262 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance263 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance264 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KilometrosTanqueo")
        Dim Appearance265 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGalon")
        Dim Appearance266 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim Appearance267 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance268 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance269 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance270 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccion")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCredito")
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueo")
        Dim UltraGridColumn511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegistroInventario")
        Dim UltraGridColumn514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoGls")
        Dim UltraGridColumn516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrifo")
        Dim UltraGridColumn523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance271 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomGrifo")
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomDireccion")
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NomLugar")
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTanqueoNoAsoc")
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIsl")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CodViaje", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdVehiculo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaTanqueo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KilometrosTanqueo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CantidadGalon", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NroVale", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PrecioUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEmpresaGrifo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDireccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdLugar", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCredito", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndTanqueo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdRegistroInventario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SaldoGls", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdViaje", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdGrifo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PlacaVeh", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CodMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Material", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaViaje", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NomGrifo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NomDireccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NomLugar", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndTanqueoNoAsoc", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndIsl", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance272 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance273 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance274 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance275 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance276 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance277 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance278 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance279 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance280 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance281 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance282 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance283 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance284 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance285 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance286 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance287 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance288 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance289 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance290 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance291 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance292 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance293 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance294 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance295 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance296 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance297 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance298 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance299 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance300 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance301 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance302 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance303 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance304 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance305 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance306 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance307 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance308 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance309 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance310 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance311 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance312 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance313 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance314 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance315 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance316 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance317 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance318 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance319 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance320 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance321 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance322 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance323 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance324 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance325 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.Grilla1 = New ISL.Controles.Grilla(Me.components)
        Me.odCombo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea14 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea15 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea16 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea17 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea18 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea19 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea20 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenesdeTransferencia = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_ListadoTanqueo = New ISL.Controles.Grilla(Me.components)
        Me.MenuTanqueo = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesasociarTanqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsociarTanqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TanquearConSurtidor1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TanquearConSurtidor2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRegConsumoCombustible = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.lblExpande = New Infragistics.Win.Misc.UltraLabel()
        Me.btnExpande1 = New ISL.Controles.Boton(Me.components)
        Me.btnExpande2 = New ISL.Controles.Boton(Me.components)
        Me.btnExpande3 = New ISL.Controles.Boton(Me.components)
        Me.btnExporta2 = New ISL.Controles.Boton(Me.components)
        Me.btnExporta1 = New ISL.Controles.Boton(Me.components)
        Me.chkVisualiza = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.gbTanqueosNoAsociados = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btn_ListarTanqNoAsoc = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.grid_TanqNoAsoc = New ISL.Controles.Grilla(Me.components)
        Me.odTanqueosNoAsociados = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraToolbarsDockArea21 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea22 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea23 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea24 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea11 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea12 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea9 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea10 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ag_Datos = New ISL.Controles.Agrupacion(Me.components)
        Me.chk_Credito = New System.Windows.Forms.CheckBox()
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaTanqueo = New ISL.Controles.Texto(Me.components)
        Me.fecFechaTanqueo = New ISL.Controles.Fecha(Me.components)
        Me.PanelGrifo = New Infragistics.Win.Misc.UltraPanel()
        Me.PanelImagen = New Infragistics.Win.Misc.UltraPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNumManguera = New Infragistics.Win.Misc.UltraLabel()
        Me.PanelManguera = New Infragistics.Win.Misc.UltraPanel()
        Me.OptManguera1 = New System.Windows.Forms.RadioButton()
        Me.OptNinguno = New System.Windows.Forms.RadioButton()
        Me.OptManguera2 = New System.Windows.Forms.RadioButton()
        Me.lblRango = New ISL.Controles.Etiqueta(Me.components)
        Me.cmb_TipoCombustible = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txt_NroVale = New ISL.Controles.Texto(Me.components)
        Me.nd_PrecioUnitario = New ISL.Controles.NumeroDecimal(Me.components)
        Me.nd_CantGalones = New ISL.Controles.NumeroDecimal(Me.components)
        Me.nd_KmTanqueo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.opt_IndTanqueo = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.ag_DatosGrifo = New ISL.Controles.Agrupacion(Me.components)
        Me.eti_Galones = New ISL.Controles.Etiqueta(Me.components)
        Me.dtp_FecViaje = New ISL.Controles.Fecha(Me.components)
        Me.etiStock = New ISL.Controles.Etiqueta(Me.components)
        Me.decStock = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDireccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLugar = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGrifo = New ISL.Controles.ComboMaestros(Me.components)
        Me.ag_Operacion = New ISL.Controles.Agrupacion(Me.components)
        Me.VerISL = New System.Windows.Forms.CheckBox()
        Me.txtPiloto = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.decOdometro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtViaje = New ISL.Controles.Texto(Me.components)
        Me.cboVehiculo = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_RegTanqNoAsoc = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDireccionTNA = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLugarTNA = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGrifoTNA = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnImportar = New ISL.Controles.Boton(Me.components)
        Me.btnGuardar = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaTanqueo1 = New ISL.Controles.Texto(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.nd_CantGalonesS1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.TxtCodigoSurtidorS1 = New ISL.Controles.Texto(Me.components)
        Me.dtp_FechaTanqueoS1 = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.nd_KmTanqueoS1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Opt_IndTanqueoS1 = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.BtnLimpiaS1 = New Infragistics.Win.Misc.UltraButton()
        Me.dtp_FechaViajeS1 = New ISL.Controles.Fecha(Me.components)
        Me.BtnGuardarS1 = New Infragistics.Win.Misc.UltraButton()
        Me.Txt_IdPilotoS1 = New ISL.Controles.Texto(Me.components)
        Me.TxT_IdViajeS1 = New ISL.Controles.Texto(Me.components)
        Me.TxtPilotoS1 = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.nd_OdometroS1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtViajeS1 = New ISL.Controles.Texto(Me.components)
        Me.CboVehiculoS1 = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaTanqueo2 = New ISL.Controles.Texto(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.TxtCodigoSurtidorS2 = New ISL.Controles.Texto(Me.components)
        Me.dtp_FechaTanqueoS2 = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.nd_CantGalonesS2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.nd_KmTanqueoS2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.Opt_IndTanqueoS2 = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.BtnLimpiaS2 = New Infragistics.Win.Misc.UltraButton()
        Me.dtp_FechaViajeS2 = New ISL.Controles.Fecha(Me.components)
        Me.BtnGuardarS2 = New Infragistics.Win.Misc.UltraButton()
        Me.Txt_IdPilotoS2 = New ISL.Controles.Texto(Me.components)
        Me.TxT_IdViajeS2 = New ISL.Controles.Texto(Me.components)
        Me.TxtPilotoS2 = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.nd_OdometroS2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtViajeS2 = New ISL.Controles.Texto(Me.components)
        Me.CboVehiculoS2 = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSotckS = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.nd_PrecioUnitarioS = New ISL.Controles.NumeroDecimal(Me.components)
        Me.CboDireccionS = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboLugarS = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboGrifoS = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraCheckEditor2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.griTanqueosPecsa = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorKm = New ISL.Controles.Colores(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorSPlaca = New ISL.Controles.Colores(Me.components)
        Me.btnLimpiar = New ISL.Controles.Boton(Me.components)
        Me.btnGuardarPecsa = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecInicioTanqueo = New System.Windows.Forms.DateTimePicker()
        Me.fecFinTanqueo = New System.Windows.Forms.DateTimePicker()
        Me.ColoresDup = New ISL.Controles.Colores(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Vehiculos = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Pilotos = New ISL.Controles.Grilla(Me.components)
        Me.utpMarcaModelo = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_TipoeVeh = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Zona = New ISL.Controles.Grilla(Me.components)
        Me.MenuEnvioSurtidor = New ISL.Controles.MenuContextual(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarASurtidor2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.RangoFechas1 = New ISL.Controles.RangoFechas()
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf = New ISL.Controles.Etiqueta(Me.components)
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d = New ISL.Controles.Etiqueta(Me.components)
        Me.FechaHasta = New ISL.Controles.Fecha(Me.components)
        Me.FechaDesde = New ISL.Controles.Fecha(Me.components)
        Me.Ficha2 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TiempoManguera = New System.Windows.Forms.Timer(Me.components)
        Me.TiempoSurtidor = New System.Windows.Forms.Timer(Me.components)
        Me.ficConCombustible = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.gbeConsultar = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.ChkSeleccion = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grFiltro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ndKmxVuelta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorKmVuelta = New ISL.Controles.Colores(Me.components)
        Me.ColorRendMenor = New ISL.Controles.Colores(Me.components)
        Me.ColorRendMayor = New ISL.Controles.Colores(Me.components)
        Me.nd_RendMenor = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nd_RendMayor = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ColorSinRend = New ISL.Controles.Colores(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDistNegativo = New ISL.Controles.Colores(Me.components)
        Me.chkColores = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnActualizaRend = New ISL.Controles.Boton(Me.components)
        Me.chk_TanqNoAsoc = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.griData = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.rfHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ficFiltros = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenesdeTransferencia.SuspendLayout()
        CType(Me.grid_ListadoTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTanqueo.SuspendLayout()
        CType(Me.odRegConsumoCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.chkVisualiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTanqueosNoAsociados.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.grid_TanqNoAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.ag_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ag_Datos.SuspendLayout()
        CType(Me.txtGlosaTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrifo.ClientArea.SuspendLayout()
        Me.PanelGrifo.SuspendLayout()
        Me.PanelImagen.ClientArea.SuspendLayout()
        Me.PanelImagen.SuspendLayout()
        Me.PanelManguera.ClientArea.SuspendLayout()
        Me.PanelManguera.SuspendLayout()
        CType(Me.cmb_TipoCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NroVale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_PrecioUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_CantGalones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_KmTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opt_IndTanqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ag_DatosGrifo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ag_DatosGrifo.SuspendLayout()
        CType(Me.dtp_FecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrifo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ag_Operacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ag_Operacion.SuspendLayout()
        CType(Me.txtPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decOdometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.grid_RegTanqNoAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.cboDireccionTNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarTNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrifoTNA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.txtGlosaTanqueo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nd_CantGalonesS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigoSurtidorS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_KmTanqueoS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Opt_IndTanqueoS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.dtp_FechaViajeS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_IdPilotoS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxT_IdViajeS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPilotoS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_OdometroS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtViajeS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboVehiculoS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.txtGlosaTanqueo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TxtCodigoSurtidorS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_CantGalonesS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_KmTanqueoS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Opt_IndTanqueoS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.dtp_FechaViajeS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_IdPilotoS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxT_IdViajeS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPilotoS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_OdometroS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtViajeS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboVehiculoS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.decSotckS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_PrecioUnitarioS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboDireccionS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboLugarS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboGrifoS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griTanqueosPecsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.ColorKm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresDup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Grid_Vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.Grid_Pilotos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMarcaModelo.SuspendLayout()
        CType(Me.Grid_TipoeVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Grid_Zona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuEnvioSurtidor.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        Me.RangoFechas1.SuspendLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha2.SuspendLayout()
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficConCombustible.SuspendLayout()
        CType(Me.gbeConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeConsultar.SuspendLayout()
        Me.ChkSeleccion.SuspendLayout()
        CType(Me.grFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grFiltro.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.ndKmxVuelta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorKmVuelta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRendMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRendMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_RendMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_RendMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSinRend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDistNegativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_TanqNoAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(401, 116)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.Grilla1)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(401, 116)
        Me.Agrupacion5.TabIndex = 5
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Grilla1
        '
        Me.Grilla1.DataSource = Me.odCombo
        Me.Grilla1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grilla1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grilla1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grilla1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grilla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla1.Location = New System.Drawing.Point(2, 2)
        Me.Grilla1.Name = "Grilla1"
        Me.Grilla1.Size = New System.Drawing.Size(397, 112)
        Me.Grilla1.TabIndex = 2
        '
        'odCombo
        '
        Me.odCombo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea13)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea14)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea15)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea16)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea17)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea18)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea19)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraToolbarsDockArea20)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(401, 116)
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(401, 0)
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(0, 116)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(401, 0)
        '
        'UltraToolbarsDockArea15
        '
        Me.UltraToolbarsDockArea15.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea15.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea15.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea15.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea15.Name = "UltraToolbarsDockArea15"
        Me.UltraToolbarsDockArea15.Size = New System.Drawing.Size(0, 116)
        '
        'UltraToolbarsDockArea16
        '
        Me.UltraToolbarsDockArea16.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea16.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea16.Location = New System.Drawing.Point(401, 0)
        Me.UltraToolbarsDockArea16.Name = "UltraToolbarsDockArea16"
        Me.UltraToolbarsDockArea16.Size = New System.Drawing.Size(0, 116)
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(0, 116)
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(401, 0)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(0, 116)
        '
        'UltraToolbarsDockArea19
        '
        Me.UltraToolbarsDockArea19.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea19.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea19.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea19.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea19.Name = "UltraToolbarsDockArea19"
        Me.UltraToolbarsDockArea19.Size = New System.Drawing.Size(401, 0)
        '
        'UltraToolbarsDockArea20
        '
        Me.UltraToolbarsDockArea20.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea20.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea20.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea20.Location = New System.Drawing.Point(0, 116)
        Me.UltraToolbarsDockArea20.Name = "UltraToolbarsDockArea20"
        Me.UltraToolbarsDockArea20.Size = New System.Drawing.Size(401, 0)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(401, 116)
        Me.UltraGroupBox2.TabIndex = 202
        Me.UltraGroupBox2.Text = "Datos Generales"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenesdeTransferencia)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1193, 411)
        '
        'agrOrdenesdeTransferencia
        '
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.grid_ListadoTanqueo)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenesdeTransferencia.Controls.Add(Me.gbTanqueosNoAsociados)
        Me.agrOrdenesdeTransferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenesdeTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenesdeTransferencia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenesdeTransferencia.Location = New System.Drawing.Point(0, 0)
        Me.agrOrdenesdeTransferencia.Name = "agrOrdenesdeTransferencia"
        Me.agrOrdenesdeTransferencia.Size = New System.Drawing.Size(1193, 411)
        Me.agrOrdenesdeTransferencia.TabIndex = 0
        Me.agrOrdenesdeTransferencia.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grid_ListadoTanqueo
        '
        Me.grid_ListadoTanqueo.AllowDrop = True
        Me.grid_ListadoTanqueo.ContextMenuStrip = Me.MenuTanqueo
        Me.grid_ListadoTanqueo.DataSource = Me.odRegConsumoCombustible
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn33.CellAppearance = Appearance1
        UltraGridColumn33.Header.Fixed = True
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 8
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn34.CellAppearance = Appearance2
        UltraGridColumn34.Header.Caption = "Placa/Viaje/NroVale"
        UltraGridColumn34.Header.Fixed = True
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Width = 110
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn35.CellAppearance = Appearance3
        UltraGridColumn35.Header.Caption = "Marca/F. Viaje/ F. Tanqueo"
        UltraGridColumn35.Header.Fixed = True
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Width = 119
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn1.CellAppearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 46
        UltraGridColumn1.Hidden = True
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn73.CellAppearance = Appearance5
        UltraGridColumn73.Header.VisiblePosition = 3
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.Width = 80
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn59.CellAppearance = Appearance6
        UltraGridColumn59.Header.Caption = "Modelo/Carreta"
        UltraGridColumn59.Header.VisiblePosition = 4
        UltraGridColumn59.Width = 80
        Appearance7.TextVAlignAsString = "Middle"
        UltraGridColumn69.CellAppearance = Appearance7
        UltraGridColumn69.Header.VisiblePosition = 5
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Width = 60
        Appearance8.TextVAlignAsString = "Middle"
        UltraGridColumn36.CellAppearance = Appearance8
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Width = 172
        Appearance9.TextVAlignAsString = "Middle"
        UltraGridColumn70.CellAppearance = Appearance9
        UltraGridColumn70.Header.VisiblePosition = 7
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.Width = 8
        Appearance10.TextVAlignAsString = "Middle"
        UltraGridColumn37.CellAppearance = Appearance10
        UltraGridColumn37.Header.VisiblePosition = 8
        UltraGridColumn37.Width = 173
        Appearance11.TextVAlignAsString = "Middle"
        UltraGridColumn38.CellAppearance = Appearance11
        UltraGridColumn38.Header.VisiblePosition = 9
        UltraGridColumn38.Width = 150
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn49.CellAppearance = Appearance12
        UltraGridColumn49.Header.VisiblePosition = 10
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.Width = 8
        Appearance13.TextVAlignAsString = "Middle"
        UltraGridColumn51.CellAppearance = Appearance13
        UltraGridColumn51.Header.VisiblePosition = 11
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.Width = 8
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn58.CellAppearance = Appearance14
        UltraGridColumn58.Header.VisiblePosition = 12
        UltraGridColumn58.Width = 35
        Appearance15.TextVAlignAsString = "Middle"
        UltraGridColumn74.CellAppearance = Appearance15
        UltraGridColumn74.Header.VisiblePosition = 15
        UltraGridColumn74.Hidden = True
        Appearance16.TextVAlignAsString = "Middle"
        UltraGridColumn60.CellAppearance = Appearance16
        UltraGridColumn60.Header.VisiblePosition = 16
        UltraGridColumn60.Width = 150
        Appearance17.TextVAlignAsString = "Middle"
        UltraGridColumn128.CellAppearance = Appearance17
        UltraGridColumn128.Header.VisiblePosition = 17
        Appearance18.TextVAlignAsString = "Middle"
        UltraGridColumn61.CellAppearance = Appearance18
        UltraGridColumn61.Header.VisiblePosition = 18
        UltraGridColumn61.Width = 100
        Appearance19.TextVAlignAsString = "Middle"
        UltraGridColumn62.CellAppearance = Appearance19
        UltraGridColumn62.Header.Caption = "Full"
        UltraGridColumn62.Header.VisiblePosition = 20
        UltraGridColumn62.Width = 30
        Appearance20.TextVAlignAsString = "Middle"
        UltraGridColumn63.CellAppearance = Appearance20
        UltraGridColumn63.Header.Caption = "Gls"
        UltraGridColumn63.Header.VisiblePosition = 21
        UltraGridColumn63.Width = 65
        Appearance21.TextVAlignAsString = "Middle"
        UltraGridColumn64.CellAppearance = Appearance21
        UltraGridColumn64.Header.VisiblePosition = 22
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 63
        Appearance22.TextVAlignAsString = "Middle"
        UltraGridColumn65.CellAppearance = Appearance22
        UltraGridColumn65.Header.VisiblePosition = 23
        UltraGridColumn65.Width = 60
        Appearance23.BackColor = System.Drawing.Color.SkyBlue
        Appearance23.TextVAlignAsString = "Middle"
        UltraGridColumn66.CellAppearance = Appearance23
        UltraGridColumn66.Header.VisiblePosition = 19
        UltraGridColumn66.Width = 80
        Appearance24.TextVAlignAsString = "Middle"
        UltraGridColumn67.CellAppearance = Appearance24
        UltraGridColumn67.Header.VisiblePosition = 24
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 81
        Appearance25.TextVAlignAsString = "Middle"
        UltraGridColumn68.CellAppearance = Appearance25
        UltraGridColumn68.Header.VisiblePosition = 25
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.Width = 84
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.TextHAlignAsString = "Right"
        Appearance26.TextVAlignAsString = "Middle"
        UltraGridColumn75.CellAppearance = Appearance26
        UltraGridColumn75.Header.VisiblePosition = 26
        UltraGridColumn75.Width = 45
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.TextHAlignAsString = "Right"
        Appearance27.TextVAlignAsString = "Middle"
        UltraGridColumn76.CellAppearance = Appearance27
        UltraGridColumn76.Header.VisiblePosition = 27
        UltraGridColumn76.Width = 45
        Appearance28.TextVAlignAsString = "Middle"
        UltraGridColumn77.CellAppearance = Appearance28
        UltraGridColumn77.Header.VisiblePosition = 28
        UltraGridColumn77.Width = 45
        Appearance29.TextVAlignAsString = "Middle"
        UltraGridColumn78.CellAppearance = Appearance29
        UltraGridColumn78.Header.Caption = "Metas"
        UltraGridColumn78.Header.VisiblePosition = 29
        UltraGridColumn78.Width = 150
        Appearance30.TextVAlignAsString = "Middle"
        UltraGridColumn79.CellAppearance = Appearance30
        UltraGridColumn79.Header.VisiblePosition = 30
        UltraGridColumn79.Width = 150
        Appearance31.TextVAlignAsString = "Middle"
        UltraGridColumn131.CellAppearance = Appearance31
        UltraGridColumn131.Header.VisiblePosition = 13
        UltraGridColumn131.Width = 220
        UltraGridColumn132.Header.Caption = "Carga"
        UltraGridColumn132.Header.VisiblePosition = 14
        UltraGridColumn132.Width = 125
        UltraGridColumn86.Header.VisiblePosition = 31
        UltraGridColumn86.Width = 50
        UltraGridColumn87.Header.VisiblePosition = 32
        UltraGridColumn87.Width = 50
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance32.FontData.BoldAsString = "True"
        Appearance32.TextHAlignAsString = "Right"
        Appearance32.TextVAlignAsString = "Middle"
        UltraGridColumn88.CellAppearance = Appearance32
        UltraGridColumn88.Header.VisiblePosition = 33
        UltraGridColumn88.Width = 50
        UltraGridColumn80.Header.VisiblePosition = 34
        UltraGridColumn80.Width = 150
        UltraGridColumn81.Header.VisiblePosition = 35
        UltraGridColumn81.Width = 35
        UltraGridColumn84.Header.VisiblePosition = 36
        UltraGridColumn84.Width = 45
        UltraGridColumn85.Header.VisiblePosition = 37
        UltraGridColumn71.Header.Caption = "Usuario Crea"
        UltraGridColumn71.Header.VisiblePosition = 38
        UltraGridColumn71.Width = 70
        UltraGridColumn72.Header.Caption = "Fecha Crea"
        UltraGridColumn72.Header.VisiblePosition = 39
        UltraGridColumn72.Width = 100
        UltraGridColumn121.Header.Caption = "Usuario Modif"
        UltraGridColumn121.Header.VisiblePosition = 40
        UltraGridColumn121.Width = 70
        UltraGridColumn123.Header.Caption = "Fecha Modif"
        UltraGridColumn123.Header.VisiblePosition = 41
        UltraGridColumn123.Width = 100
        UltraGridColumn82.Header.VisiblePosition = 42
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 43
        UltraGridColumn83.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 44
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 45
        UltraGridColumn130.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 47
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn1, UltraGridColumn73, UltraGridColumn59, UltraGridColumn69, UltraGridColumn36, UltraGridColumn70, UltraGridColumn37, UltraGridColumn38, UltraGridColumn49, UltraGridColumn51, UltraGridColumn58, UltraGridColumn74, UltraGridColumn60, UltraGridColumn128, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn131, UltraGridColumn132, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn80, UltraGridColumn81, UltraGridColumn84, UltraGridColumn85, UltraGridColumn71, UltraGridColumn72, UltraGridColumn121, UltraGridColumn123, UltraGridColumn82, UltraGridColumn83, UltraGridColumn129, UltraGridColumn130, UltraGridColumn133})
        Appearance33.TextVAlignAsString = "Middle"
        UltraGridBand1.Header.Appearance = Appearance33
        UltraGridBand1.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance34.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        UltraGridBand1.Override.RowAppearance = Appearance34
        UltraGridBand2.ColHeadersVisible = False
        Appearance35.TextVAlignAsString = "Middle"
        UltraGridColumn134.CellAppearance = Appearance35
        UltraGridColumn134.Header.Fixed = True
        UltraGridColumn134.Header.VisiblePosition = 2
        UltraGridColumn134.Hidden = True
        Appearance36.TextVAlignAsString = "Middle"
        UltraGridColumn135.CellAppearance = Appearance36
        UltraGridColumn135.Header.Fixed = True
        UltraGridColumn135.Header.VisiblePosition = 3
        UltraGridColumn135.Hidden = True
        Appearance37.BackColor = System.Drawing.Color.Khaki
        Appearance37.TextVAlignAsString = "Middle"
        UltraGridColumn136.CellAppearance = Appearance37
        UltraGridColumn136.Header.Fixed = True
        UltraGridColumn136.Header.VisiblePosition = 0
        UltraGridColumn136.Width = 91
        Appearance38.TextHAlignAsString = "Center"
        Appearance38.TextVAlignAsString = "Middle"
        UltraGridColumn137.CellAppearance = Appearance38
        UltraGridColumn137.Format = ""
        UltraGridColumn137.Header.Fixed = True
        UltraGridColumn137.Header.VisiblePosition = 1
        UltraGridColumn137.Width = 119
        Appearance39.TextVAlignAsString = "Middle"
        UltraGridColumn349.CellAppearance = Appearance39
        UltraGridColumn349.Header.VisiblePosition = 4
        UltraGridColumn349.Hidden = True
        UltraGridColumn349.Width = 60
        Appearance40.TextHAlignAsString = "Center"
        Appearance40.TextVAlignAsString = "Middle"
        UltraGridColumn142.CellAppearance = Appearance40
        UltraGridColumn142.Header.VisiblePosition = 5
        UltraGridColumn142.Width = 80
        Appearance41.TextVAlignAsString = "Middle"
        UltraGridColumn149.CellAppearance = Appearance41
        UltraGridColumn149.Header.VisiblePosition = 6
        UltraGridColumn149.Hidden = True
        Appearance42.TextVAlignAsString = "Middle"
        UltraGridColumn138.CellAppearance = Appearance42
        UltraGridColumn138.Header.VisiblePosition = 7
        UltraGridColumn138.Width = 172
        Appearance43.TextVAlignAsString = "Middle"
        UltraGridColumn150.CellAppearance = Appearance43
        UltraGridColumn150.Header.VisiblePosition = 8
        UltraGridColumn150.Hidden = True
        Appearance44.TextVAlignAsString = "Middle"
        UltraGridColumn139.CellAppearance = Appearance44
        UltraGridColumn139.Header.VisiblePosition = 9
        UltraGridColumn139.Width = 173
        Appearance45.TextVAlignAsString = "Middle"
        UltraGridColumn140.CellAppearance = Appearance45
        UltraGridColumn140.Header.VisiblePosition = 10
        UltraGridColumn140.Width = 150
        Appearance46.TextVAlignAsString = "Middle"
        UltraGridColumn147.CellAppearance = Appearance46
        UltraGridColumn147.Header.VisiblePosition = 11
        UltraGridColumn147.Hidden = True
        Appearance47.TextVAlignAsString = "Middle"
        UltraGridColumn148.CellAppearance = Appearance47
        UltraGridColumn148.Header.VisiblePosition = 12
        UltraGridColumn148.Hidden = True
        Appearance48.TextHAlignAsString = "Right"
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn141.CellAppearance = Appearance48
        UltraGridColumn141.Format = "#,##0.00"
        UltraGridColumn141.Header.VisiblePosition = 13
        UltraGridColumn141.Width = 35
        Appearance49.TextVAlignAsString = "Middle"
        UltraGridColumn370.CellAppearance = Appearance49
        UltraGridColumn370.Header.VisiblePosition = 14
        UltraGridColumn370.Width = 220
        Appearance50.TextVAlignAsString = "Middle"
        UltraGridColumn371.CellAppearance = Appearance50
        UltraGridColumn371.Header.Caption = "Carga"
        UltraGridColumn371.Header.VisiblePosition = 15
        UltraGridColumn371.Width = 125
        Appearance51.TextVAlignAsString = "Middle"
        UltraGridColumn350.CellAppearance = Appearance51
        UltraGridColumn350.Header.VisiblePosition = 16
        UltraGridColumn350.Hidden = True
        Appearance52.TextVAlignAsString = "Middle"
        UltraGridColumn143.CellAppearance = Appearance52
        UltraGridColumn143.Header.VisiblePosition = 17
        UltraGridColumn143.Width = 150
        Appearance53.TextVAlignAsString = "Middle"
        UltraGridColumn367.CellAppearance = Appearance53
        UltraGridColumn367.Header.VisiblePosition = 18
        Appearance54.TextVAlignAsString = "Middle"
        UltraGridColumn144.CellAppearance = Appearance54
        UltraGridColumn144.Header.VisiblePosition = 19
        UltraGridColumn144.Width = 100
        Appearance55.BackColor = System.Drawing.Color.SkyBlue
        Appearance55.TextHAlignAsString = "Right"
        Appearance55.TextVAlignAsString = "Middle"
        UltraGridColumn153.CellAppearance = Appearance55
        UltraGridColumn153.Format = "#,##0.00"
        UltraGridColumn153.Header.VisiblePosition = 20
        UltraGridColumn153.Width = 80
        Appearance56.TextVAlignAsString = "Middle"
        UltraGridColumn146.CellAppearance = Appearance56
        UltraGridColumn146.Header.VisiblePosition = 21
        UltraGridColumn146.Width = 30
        Appearance57.TextVAlignAsString = "Middle"
        UltraGridColumn145.CellAppearance = Appearance57
        UltraGridColumn145.Header.VisiblePosition = 22
        UltraGridColumn145.Width = 65
        Appearance58.TextVAlignAsString = "Middle"
        UltraGridColumn151.CellAppearance = Appearance58
        UltraGridColumn151.Header.VisiblePosition = 23
        UltraGridColumn151.Hidden = True
        UltraGridColumn151.Width = 63
        Appearance59.TextVAlignAsString = "Middle"
        UltraGridColumn152.CellAppearance = Appearance59
        UltraGridColumn152.Header.VisiblePosition = 24
        UltraGridColumn152.Width = 60
        Appearance60.TextVAlignAsString = "Middle"
        UltraGridColumn345.CellAppearance = Appearance60
        UltraGridColumn345.Header.VisiblePosition = 25
        UltraGridColumn345.Hidden = True
        UltraGridColumn345.Width = 81
        Appearance61.TextVAlignAsString = "Middle"
        UltraGridColumn346.CellAppearance = Appearance61
        UltraGridColumn346.Header.VisiblePosition = 26
        UltraGridColumn346.Hidden = True
        UltraGridColumn346.Width = 84
        Appearance62.TextVAlignAsString = "Middle"
        UltraGridColumn351.CellAppearance = Appearance62
        UltraGridColumn351.Header.VisiblePosition = 27
        UltraGridColumn351.Width = 45
        Appearance63.BackColor = System.Drawing.Color.Silver
        Appearance63.TextHAlignAsString = "Right"
        Appearance63.TextVAlignAsString = "Middle"
        UltraGridColumn352.CellAppearance = Appearance63
        UltraGridColumn352.Header.VisiblePosition = 28
        UltraGridColumn352.Width = 45
        Appearance64.TextVAlignAsString = "Middle"
        UltraGridColumn353.CellAppearance = Appearance64
        UltraGridColumn353.Header.VisiblePosition = 29
        UltraGridColumn353.Width = 45
        Appearance65.TextVAlignAsString = "Middle"
        UltraGridColumn354.CellAppearance = Appearance65
        UltraGridColumn354.Header.Caption = "Metas"
        UltraGridColumn354.Header.VisiblePosition = 30
        UltraGridColumn354.Width = 150
        Appearance66.TextVAlignAsString = "Middle"
        UltraGridColumn355.CellAppearance = Appearance66
        UltraGridColumn355.Header.VisiblePosition = 31
        UltraGridColumn355.Width = 150
        Appearance67.TextVAlignAsString = "Middle"
        UltraGridColumn362.CellAppearance = Appearance67
        UltraGridColumn362.Header.VisiblePosition = 32
        UltraGridColumn362.Width = 50
        Appearance68.TextVAlignAsString = "Middle"
        UltraGridColumn363.CellAppearance = Appearance68
        UltraGridColumn363.Header.VisiblePosition = 33
        UltraGridColumn363.Width = 50
        Appearance69.TextVAlignAsString = "Middle"
        UltraGridColumn364.CellAppearance = Appearance69
        UltraGridColumn364.Header.VisiblePosition = 34
        UltraGridColumn364.Width = 50
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn356.CellAppearance = Appearance70
        UltraGridColumn356.Header.VisiblePosition = 35
        UltraGridColumn356.Width = 150
        Appearance71.TextVAlignAsString = "Middle"
        UltraGridColumn357.CellAppearance = Appearance71
        UltraGridColumn357.Header.VisiblePosition = 36
        UltraGridColumn357.Width = 35
        Appearance72.TextVAlignAsString = "Middle"
        UltraGridColumn360.CellAppearance = Appearance72
        UltraGridColumn360.Header.VisiblePosition = 37
        UltraGridColumn360.Width = 45
        Appearance73.TextVAlignAsString = "Middle"
        UltraGridColumn361.CellAppearance = Appearance73
        UltraGridColumn361.Header.VisiblePosition = 38
        Appearance74.TextVAlignAsString = "Middle"
        UltraGridColumn347.CellAppearance = Appearance74
        UltraGridColumn347.Header.VisiblePosition = 39
        UltraGridColumn347.Width = 70
        Appearance75.TextVAlignAsString = "Middle"
        UltraGridColumn348.CellAppearance = Appearance75
        UltraGridColumn348.Header.VisiblePosition = 40
        UltraGridColumn348.Width = 100
        Appearance76.TextVAlignAsString = "Middle"
        UltraGridColumn365.CellAppearance = Appearance76
        UltraGridColumn365.Header.VisiblePosition = 41
        UltraGridColumn365.Width = 70
        Appearance77.TextVAlignAsString = "Middle"
        UltraGridColumn366.CellAppearance = Appearance77
        UltraGridColumn366.Header.VisiblePosition = 42
        UltraGridColumn366.Width = 100
        Appearance78.TextVAlignAsString = "Middle"
        UltraGridColumn358.CellAppearance = Appearance78
        UltraGridColumn358.Header.VisiblePosition = 43
        UltraGridColumn358.Hidden = True
        Appearance79.TextVAlignAsString = "Middle"
        UltraGridColumn359.CellAppearance = Appearance79
        UltraGridColumn359.Header.VisiblePosition = 44
        UltraGridColumn359.Hidden = True
        Appearance80.TextVAlignAsString = "Middle"
        UltraGridColumn368.CellAppearance = Appearance80
        UltraGridColumn368.Header.VisiblePosition = 45
        UltraGridColumn368.Hidden = True
        Appearance81.TextVAlignAsString = "Middle"
        UltraGridColumn369.CellAppearance = Appearance81
        UltraGridColumn369.Header.VisiblePosition = 46
        UltraGridColumn369.Hidden = True
        UltraGridColumn372.Header.VisiblePosition = 47
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn349, UltraGridColumn142, UltraGridColumn149, UltraGridColumn138, UltraGridColumn150, UltraGridColumn139, UltraGridColumn140, UltraGridColumn147, UltraGridColumn148, UltraGridColumn141, UltraGridColumn370, UltraGridColumn371, UltraGridColumn350, UltraGridColumn143, UltraGridColumn367, UltraGridColumn144, UltraGridColumn153, UltraGridColumn146, UltraGridColumn145, UltraGridColumn151, UltraGridColumn152, UltraGridColumn345, UltraGridColumn346, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn356, UltraGridColumn357, UltraGridColumn360, UltraGridColumn361, UltraGridColumn347, UltraGridColumn348, UltraGridColumn365, UltraGridColumn366, UltraGridColumn358, UltraGridColumn359, UltraGridColumn368, UltraGridColumn369, UltraGridColumn372})
        Appearance82.TextVAlignAsString = "Middle"
        UltraGridBand2.Header.Appearance = Appearance82
        UltraGridBand2.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        UltraGridBand3.ColHeadersVisible = False
        Appearance83.TextVAlignAsString = "Middle"
        UltraGridColumn399.CellAppearance = Appearance83
        UltraGridColumn399.Header.VisiblePosition = 4
        UltraGridColumn399.Hidden = True
        UltraGridColumn399.Width = 8
        Appearance84.TextVAlignAsString = "Middle"
        UltraGridColumn398.CellAppearance = Appearance84
        UltraGridColumn398.Header.VisiblePosition = 3
        UltraGridColumn398.Hidden = True
        UltraGridColumn398.Width = 87
        Appearance85.TextVAlignAsString = "Middle"
        UltraGridColumn397.CellAppearance = Appearance85
        UltraGridColumn397.Header.VisiblePosition = 2
        UltraGridColumn397.Hidden = True
        UltraGridColumn397.Width = 31
        Appearance86.BackColor = System.Drawing.Color.Khaki
        Appearance86.TextHAlignAsString = "Right"
        Appearance86.TextVAlignAsString = "Middle"
        UltraGridColumn373.CellAppearance = Appearance86
        UltraGridColumn373.Header.Fixed = True
        UltraGridColumn373.Header.VisiblePosition = 0
        UltraGridColumn373.Width = 72
        UltraGridColumn374.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance87.TextHAlignAsString = "Center"
        Appearance87.TextVAlignAsString = "Middle"
        UltraGridColumn374.CellAppearance = Appearance87
        UltraGridColumn374.Header.Fixed = True
        UltraGridColumn374.Header.VisiblePosition = 1
        UltraGridColumn374.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn374.Width = 119
        Appearance88.TextVAlignAsString = "Middle"
        UltraGridColumn400.CellAppearance = Appearance88
        UltraGridColumn400.Header.VisiblePosition = 5
        UltraGridColumn400.Hidden = True
        UltraGridColumn400.Width = 60
        Appearance89.TextVAlignAsString = "Middle"
        UltraGridColumn386.CellAppearance = Appearance89
        UltraGridColumn386.Header.VisiblePosition = 6
        UltraGridColumn386.Width = 80
        Appearance90.TextVAlignAsString = "Middle"
        UltraGridColumn388.CellAppearance = Appearance90
        UltraGridColumn388.Header.VisiblePosition = 7
        UltraGridColumn388.Hidden = True
        Appearance91.TextVAlignAsString = "Middle"
        UltraGridColumn376.CellAppearance = Appearance91
        UltraGridColumn376.Header.VisiblePosition = 8
        UltraGridColumn376.Width = 172
        Appearance92.TextVAlignAsString = "Middle"
        UltraGridColumn389.CellAppearance = Appearance92
        UltraGridColumn389.Header.VisiblePosition = 9
        UltraGridColumn389.Hidden = True
        Appearance93.TextVAlignAsString = "Middle"
        UltraGridColumn377.CellAppearance = Appearance93
        UltraGridColumn377.Header.VisiblePosition = 10
        UltraGridColumn377.Width = 173
        Appearance94.TextVAlignAsString = "Middle"
        UltraGridColumn378.CellAppearance = Appearance94
        UltraGridColumn378.Header.VisiblePosition = 11
        UltraGridColumn378.Width = 150
        Appearance95.TextVAlignAsString = "Middle"
        UltraGridColumn380.CellAppearance = Appearance95
        UltraGridColumn380.Header.VisiblePosition = 15
        UltraGridColumn380.Hidden = True
        Appearance96.TextVAlignAsString = "Middle"
        UltraGridColumn381.CellAppearance = Appearance96
        UltraGridColumn381.Header.VisiblePosition = 16
        UltraGridColumn381.Hidden = True
        Appearance97.TextVAlignAsString = "Middle"
        UltraGridColumn384.CellAppearance = Appearance97
        UltraGridColumn384.Header.VisiblePosition = 12
        UltraGridColumn384.Width = 35
        Appearance98.TextVAlignAsString = "Middle"
        UltraGridColumn385.CellAppearance = Appearance98
        UltraGridColumn385.Header.VisiblePosition = 13
        UltraGridColumn385.Width = 220
        Appearance99.TextVAlignAsString = "Middle"
        UltraGridColumn420.CellAppearance = Appearance99
        UltraGridColumn420.Header.Caption = "Carga"
        UltraGridColumn420.Header.VisiblePosition = 14
        UltraGridColumn420.Width = 125
        Appearance100.TextVAlignAsString = "Middle"
        UltraGridColumn401.CellAppearance = Appearance100
        UltraGridColumn401.Header.VisiblePosition = 17
        UltraGridColumn401.Hidden = True
        Appearance101.TextVAlignAsString = "Middle"
        UltraGridColumn382.CellAppearance = Appearance101
        UltraGridColumn382.Header.VisiblePosition = 18
        UltraGridColumn382.Width = 150
        Appearance102.TextVAlignAsString = "Middle"
        UltraGridColumn417.CellAppearance = Appearance102
        UltraGridColumn417.Header.VisiblePosition = 19
        Appearance103.TextVAlignAsString = "Middle"
        UltraGridColumn383.CellAppearance = Appearance103
        UltraGridColumn383.Header.VisiblePosition = 20
        UltraGridColumn383.Width = 100
        Appearance104.BackColor = System.Drawing.Color.SkyBlue
        Appearance104.TextHAlignAsString = "Right"
        Appearance104.TextVAlignAsString = "Middle"
        UltraGridColumn392.CellAppearance = Appearance104
        UltraGridColumn392.Format = "#,##0.00"
        UltraGridColumn392.Header.VisiblePosition = 21
        UltraGridColumn392.Width = 80
        Appearance105.TextVAlignAsString = "Middle"
        UltraGridColumn387.CellAppearance = Appearance105
        UltraGridColumn387.Header.VisiblePosition = 22
        UltraGridColumn387.Width = 30
        Appearance106.TextHAlignAsString = "Right"
        Appearance106.TextVAlignAsString = "Middle"
        UltraGridColumn375.CellAppearance = Appearance106
        UltraGridColumn375.Header.VisiblePosition = 23
        UltraGridColumn375.Width = 65
        Appearance107.TextVAlignAsString = "Middle"
        UltraGridColumn390.CellAppearance = Appearance107
        UltraGridColumn390.Header.VisiblePosition = 24
        UltraGridColumn390.Hidden = True
        UltraGridColumn390.Width = 63
        Appearance108.TextVAlignAsString = "Middle"
        UltraGridColumn391.CellAppearance = Appearance108
        UltraGridColumn391.Header.VisiblePosition = 25
        UltraGridColumn391.Width = 60
        Appearance109.TextVAlignAsString = "Middle"
        UltraGridColumn393.CellAppearance = Appearance109
        UltraGridColumn393.Header.VisiblePosition = 26
        UltraGridColumn393.Hidden = True
        Appearance110.TextVAlignAsString = "Middle"
        UltraGridColumn394.CellAppearance = Appearance110
        UltraGridColumn394.Header.VisiblePosition = 27
        UltraGridColumn394.Hidden = True
        Appearance111.TextHAlignAsString = "Right"
        Appearance111.TextVAlignAsString = "Middle"
        UltraGridColumn402.CellAppearance = Appearance111
        UltraGridColumn402.Format = "#,##0.00"
        UltraGridColumn402.Header.VisiblePosition = 28
        UltraGridColumn402.Width = 45
        Appearance112.BackColor = System.Drawing.Color.Silver
        Appearance112.TextHAlignAsString = "Right"
        Appearance112.TextVAlignAsString = "Middle"
        UltraGridColumn403.CellAppearance = Appearance112
        UltraGridColumn403.Format = "#,##0.00"
        UltraGridColumn403.Header.VisiblePosition = 29
        UltraGridColumn403.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn403.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn403.Width = 45
        Appearance113.TextHAlignAsString = "Right"
        Appearance113.TextVAlignAsString = "Middle"
        UltraGridColumn404.CellAppearance = Appearance113
        UltraGridColumn404.Header.VisiblePosition = 30
        UltraGridColumn404.Width = 45
        Appearance114.TextVAlignAsString = "Middle"
        UltraGridColumn405.CellAppearance = Appearance114
        UltraGridColumn405.Header.Caption = "Metas"
        UltraGridColumn405.Header.VisiblePosition = 31
        UltraGridColumn405.Width = 150
        Appearance115.TextVAlignAsString = "Middle"
        UltraGridColumn406.CellAppearance = Appearance115
        UltraGridColumn406.Header.VisiblePosition = 32
        UltraGridColumn406.Width = 150
        Appearance116.TextHAlignAsString = "Right"
        Appearance116.TextVAlignAsString = "Middle"
        UltraGridColumn412.CellAppearance = Appearance116
        UltraGridColumn412.Format = "#,##0.00"
        UltraGridColumn412.Header.VisiblePosition = 33
        UltraGridColumn412.MaskInput = "{double:6.2}"
        UltraGridColumn412.Width = 50
        Appearance117.TextHAlignAsString = "Right"
        Appearance117.TextVAlignAsString = "Middle"
        UltraGridColumn413.CellAppearance = Appearance117
        UltraGridColumn413.Format = "#,##0.00"
        UltraGridColumn413.Header.VisiblePosition = 34
        UltraGridColumn413.MaskInput = "{double:6.2}"
        UltraGridColumn413.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn413.Width = 50
        Appearance118.TextHAlignAsString = "Right"
        Appearance118.TextVAlignAsString = "Middle"
        UltraGridColumn414.CellAppearance = Appearance118
        UltraGridColumn414.Format = "#,##0.00"
        UltraGridColumn414.Header.VisiblePosition = 35
        UltraGridColumn414.MaskInput = "{double:6.2}"
        UltraGridColumn414.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn414.Width = 50
        Appearance119.TextVAlignAsString = "Middle"
        UltraGridColumn407.CellAppearance = Appearance119
        UltraGridColumn407.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn407.Header.VisiblePosition = 36
        UltraGridColumn407.Width = 150
        Appearance120.TextVAlignAsString = "Middle"
        UltraGridColumn408.CellAppearance = Appearance120
        UltraGridColumn408.Header.VisiblePosition = 37
        UltraGridColumn408.Width = 35
        Appearance121.TextHAlignAsString = "Center"
        Appearance121.TextVAlignAsString = "Middle"
        UltraGridColumn411.CellAppearance = Appearance121
        UltraGridColumn411.Header.VisiblePosition = 38
        UltraGridColumn411.Width = 45
        Appearance122.TextHAlignAsString = "Center"
        Appearance122.TextVAlignAsString = "Middle"
        UltraGridColumn379.CellAppearance = Appearance122
        UltraGridColumn379.Header.VisiblePosition = 39
        Appearance123.TextVAlignAsString = "Middle"
        UltraGridColumn395.CellAppearance = Appearance123
        UltraGridColumn395.Header.VisiblePosition = 40
        UltraGridColumn395.Width = 70
        UltraGridColumn396.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance124.TextHAlignAsString = "Center"
        Appearance124.TextVAlignAsString = "Middle"
        UltraGridColumn396.CellAppearance = Appearance124
        UltraGridColumn396.Header.VisiblePosition = 41
        UltraGridColumn396.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn396.Width = 100
        Appearance125.TextVAlignAsString = "Middle"
        UltraGridColumn415.CellAppearance = Appearance125
        UltraGridColumn415.Header.VisiblePosition = 42
        UltraGridColumn415.Width = 70
        UltraGridColumn416.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance126.TextHAlignAsString = "Center"
        Appearance126.TextVAlignAsString = "Middle"
        UltraGridColumn416.CellAppearance = Appearance126
        UltraGridColumn416.Header.VisiblePosition = 43
        UltraGridColumn416.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn416.Width = 100
        Appearance127.TextVAlignAsString = "Middle"
        UltraGridColumn409.CellAppearance = Appearance127
        UltraGridColumn409.Header.VisiblePosition = 44
        UltraGridColumn409.Hidden = True
        Appearance128.TextVAlignAsString = "Middle"
        UltraGridColumn410.CellAppearance = Appearance128
        UltraGridColumn410.Header.VisiblePosition = 45
        UltraGridColumn410.Hidden = True
        Appearance129.TextVAlignAsString = "Middle"
        UltraGridColumn418.CellAppearance = Appearance129
        UltraGridColumn418.Header.VisiblePosition = 46
        UltraGridColumn418.Hidden = True
        Appearance130.TextVAlignAsString = "Middle"
        UltraGridColumn419.CellAppearance = Appearance130
        UltraGridColumn419.Header.VisiblePosition = 47
        UltraGridColumn419.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn399, UltraGridColumn398, UltraGridColumn397, UltraGridColumn373, UltraGridColumn374, UltraGridColumn400, UltraGridColumn386, UltraGridColumn388, UltraGridColumn376, UltraGridColumn389, UltraGridColumn377, UltraGridColumn378, UltraGridColumn380, UltraGridColumn381, UltraGridColumn384, UltraGridColumn385, UltraGridColumn420, UltraGridColumn401, UltraGridColumn382, UltraGridColumn417, UltraGridColumn383, UltraGridColumn392, UltraGridColumn387, UltraGridColumn375, UltraGridColumn390, UltraGridColumn391, UltraGridColumn393, UltraGridColumn394, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn407, UltraGridColumn408, UltraGridColumn411, UltraGridColumn379, UltraGridColumn395, UltraGridColumn396, UltraGridColumn415, UltraGridColumn416, UltraGridColumn409, UltraGridColumn410, UltraGridColumn418, UltraGridColumn419})
        Appearance131.TextVAlignAsString = "Middle"
        UltraGridBand3.Header.Appearance = Appearance131
        UltraGridBand3.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Me.grid_ListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_ListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_ListadoTanqueo.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_ListadoTanqueo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListadoTanqueo.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ListadoTanqueo.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_ListadoTanqueo.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid_ListadoTanqueo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ListadoTanqueo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ListadoTanqueo.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Me.grid_ListadoTanqueo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ListadoTanqueo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ListadoTanqueo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.grid_ListadoTanqueo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ListadoTanqueo.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
        Me.grid_ListadoTanqueo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ListadoTanqueo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_ListadoTanqueo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ListadoTanqueo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_ListadoTanqueo.DisplayLayout.UseFixedHeaders = True
        Me.grid_ListadoTanqueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ListadoTanqueo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ListadoTanqueo.Location = New System.Drawing.Point(2, 25)
        Me.grid_ListadoTanqueo.Name = "grid_ListadoTanqueo"
        Me.grid_ListadoTanqueo.Size = New System.Drawing.Size(1189, 173)
        Me.grid_ListadoTanqueo.TabIndex = 1
        '
        'MenuTanqueo
        '
        Me.MenuTanqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTanqueo.ForeColor = System.Drawing.Color.Black
        Me.MenuTanqueo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.DesasociarTanqueoToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.AsociarTanqueoToolStripMenuItem, Me.TanquearConSurtidor1ToolStripMenuItem, Me.TanquearConSurtidor2ToolStripMenuItem})
        Me.MenuTanqueo.Name = "MenuContextual1"
        Me.MenuTanqueo.Size = New System.Drawing.Size(167, 180)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'DesasociarTanqueoToolStripMenuItem
        '
        Me.DesasociarTanqueoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.DesasociarTanqueoToolStripMenuItem.Name = "DesasociarTanqueoToolStripMenuItem"
        Me.DesasociarTanqueoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DesasociarTanqueoToolStripMenuItem.Text = "Desasociar Tanqueo"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'AsociarTanqueoToolStripMenuItem
        '
        Me.AsociarTanqueoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.AsociarTanqueoToolStripMenuItem.Name = "AsociarTanqueoToolStripMenuItem"
        Me.AsociarTanqueoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AsociarTanqueoToolStripMenuItem.Text = "Asociar Tanqueo"
        '
        'TanquearConSurtidor1ToolStripMenuItem
        '
        Me.TanquearConSurtidor1ToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Surtidor1
        Me.TanquearConSurtidor1ToolStripMenuItem.Name = "TanquearConSurtidor1ToolStripMenuItem"
        Me.TanquearConSurtidor1ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TanquearConSurtidor1ToolStripMenuItem.Text = "Tanquear con Surtidor 1"
        '
        'TanquearConSurtidor2ToolStripMenuItem
        '
        Me.TanquearConSurtidor2ToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Surtidor1
        Me.TanquearConSurtidor2ToolStripMenuItem.Name = "TanquearConSurtidor2ToolStripMenuItem"
        Me.TanquearConSurtidor2ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TanquearConSurtidor2ToolStripMenuItem.Text = "Tanquear con Surtidor 2"
        '
        'odRegConsumoCombustible
        '
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn34.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn45.DataType = GetType(Date)
        UltraDataColumn45.DefaultValue = New Date(CType(0, Long))
        UltraDataColumn47.DataType = GetType(Date)
        UltraDataColumn47.DefaultValue = New Date(CType(0, Long))
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51})
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn55.DataType = GetType(Date)
        UltraDataColumn65.DataType = GetType(Double)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98})
        Me.odRegConsumoCombustible.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.odRegConsumoCombustible.Band.Columns.AddRange(New Object() {UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None
        Me.agrMenuLista.Controls.Add(Me.lblExpande)
        Me.agrMenuLista.Controls.Add(Me.btnExpande1)
        Me.agrMenuLista.Controls.Add(Me.btnExpande2)
        Me.agrMenuLista.Controls.Add(Me.btnExpande3)
        Me.agrMenuLista.Controls.Add(Me.btnExporta2)
        Me.agrMenuLista.Controls.Add(Me.btnExporta1)
        Me.agrMenuLista.Controls.Add(Me.chkVisualiza)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(2, 2)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1189, 23)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'lblExpande
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.TextVAlignAsString = "Middle"
        Me.lblExpande.Appearance = Appearance132
        Me.lblExpande.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblExpande.Location = New System.Drawing.Point(1008, 0)
        Me.lblExpande.Name = "lblExpande"
        Me.lblExpande.Size = New System.Drawing.Size(100, 23)
        Me.lblExpande.TabIndex = 3
        Me.lblExpande.Text = "Expandir en nivel:"
        '
        'btnExpande1
        '
        Appearance133.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande1.Appearance = Appearance133
        Me.btnExpande1.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande1.ForeColor = System.Drawing.Color.Black
        Me.btnExpande1.Location = New System.Drawing.Point(1108, 0)
        Me.btnExpande1.Name = "btnExpande1"
        Me.btnExpande1.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande1.TabIndex = 4
        Me.btnExpande1.Text = "1"
        Me.btnExpande1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExpande2
        '
        Appearance134.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande2.Appearance = Appearance134
        Me.btnExpande2.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande2.ForeColor = System.Drawing.Color.Black
        Me.btnExpande2.Location = New System.Drawing.Point(1135, 0)
        Me.btnExpande2.Name = "btnExpande2"
        Me.btnExpande2.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande2.TabIndex = 5
        Me.btnExpande2.Text = "2"
        Me.btnExpande2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExpande3
        '
        Appearance135.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExpande3.Appearance = Appearance135
        Me.btnExpande3.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExpande3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExpande3.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExpande3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpande3.ForeColor = System.Drawing.Color.Black
        Me.btnExpande3.Location = New System.Drawing.Point(1162, 0)
        Me.btnExpande3.Name = "btnExpande3"
        Me.btnExpande3.Size = New System.Drawing.Size(27, 23)
        Me.btnExpande3.TabIndex = 6
        Me.btnExpande3.Text = "3"
        Me.btnExpande3.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExporta2
        '
        Appearance136.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance136.Image = Global.ISL.Win.My.Resources.Resources.kspread
        Me.btnExporta2.Appearance = Appearance136
        Me.btnExporta2.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExporta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExporta2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExporta2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporta2.ForeColor = System.Drawing.Color.Black
        Me.btnExporta2.Location = New System.Drawing.Point(199, 0)
        Me.btnExporta2.Name = "btnExporta2"
        Me.btnExporta2.Size = New System.Drawing.Size(99, 23)
        Me.btnExporta2.TabIndex = 2
        Me.btnExporta2.Text = "Exportar Tipo 2"
        Me.btnExporta2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnExporta1
        '
        Appearance137.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance137.Image = Global.ISL.Win.My.Resources.Resources.kspread
        Me.btnExporta1.Appearance = Appearance137
        Me.btnExporta1.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExporta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExporta1.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExporta1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporta1.ForeColor = System.Drawing.Color.Black
        Me.btnExporta1.Location = New System.Drawing.Point(100, 0)
        Me.btnExporta1.Name = "btnExporta1"
        Me.btnExporta1.Size = New System.Drawing.Size(99, 23)
        Me.btnExporta1.TabIndex = 1
        Me.btnExporta1.Text = "Exportar Tipo 1"
        Me.btnExporta1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'chkVisualiza
        '
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Me.chkVisualiza.Appearance = Appearance138
        Me.chkVisualiza.BackColor = System.Drawing.Color.Transparent
        Me.chkVisualiza.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkVisualiza.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.chkVisualiza.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkVisualiza.Location = New System.Drawing.Point(0, 0)
        Me.chkVisualiza.Name = "chkVisualiza"
        Me.chkVisualiza.Size = New System.Drawing.Size(100, 23)
        Me.chkVisualiza.TabIndex = 0
        Me.chkVisualiza.Text = "Vista resumida"
        '
        'gbTanqueosNoAsociados
        '
        Me.gbTanqueosNoAsociados.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbTanqueosNoAsociados.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gbTanqueosNoAsociados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbTanqueosNoAsociados.ExpandedSize = New System.Drawing.Size(1189, 211)
        Me.gbTanqueosNoAsociados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTanqueosNoAsociados.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.gbTanqueosNoAsociados.Location = New System.Drawing.Point(2, 198)
        Me.gbTanqueosNoAsociados.Name = "gbTanqueosNoAsociados"
        Me.gbTanqueosNoAsociados.Size = New System.Drawing.Size(1189, 211)
        Me.gbTanqueosNoAsociados.TabIndex = 2
        Me.gbTanqueosNoAsociados.Text = "Tanqueos no asociados"
        Me.gbTanqueosNoAsociados.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btn_ListarTanqNoAsoc)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.grid_TanqNoAsoc)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 25)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(1183, 183)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'btn_ListarTanqNoAsoc
        '
        Appearance139.TextVAlignAsString = "Top"
        Me.btn_ListarTanqNoAsoc.Appearance = Appearance139
        Me.btn_ListarTanqNoAsoc.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btn_ListarTanqNoAsoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn_ListarTanqNoAsoc.ImageList = Me.imagenes
        Me.btn_ListarTanqNoAsoc.Location = New System.Drawing.Point(3, 2)
        Me.btn_ListarTanqNoAsoc.Name = "btn_ListarTanqNoAsoc"
        Me.btn_ListarTanqNoAsoc.Size = New System.Drawing.Size(31, 15)
        Me.btn_ListarTanqNoAsoc.TabIndex = 0
        Me.btn_ListarTanqNoAsoc.Text = "* * *"
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        Me.imagenes.Images.SetKeyName(15, "Surtidor.png")
        Me.imagenes.Images.SetKeyName(16, "16 (Clear).ico")
        '
        'grid_TanqNoAsoc
        '
        Me.grid_TanqNoAsoc.ContextMenuStrip = Me.MenuTanqueo
        Me.grid_TanqNoAsoc.DataSource = Me.odTanqueosNoAsociados
        UltraGridColumn421.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn421.Header.VisiblePosition = 0
        UltraGridColumn421.Hidden = True
        UltraGridColumn421.Width = 27
        UltraGridColumn422.Header.VisiblePosition = 20
        UltraGridColumn422.Hidden = True
        UltraGridColumn423.Header.Caption = "Viaje"
        UltraGridColumn423.Header.VisiblePosition = 1
        UltraGridColumn423.Hidden = True
        UltraGridColumn423.Width = 125
        UltraGridColumn424.Header.VisiblePosition = 2
        UltraGridColumn424.Hidden = True
        UltraGridColumn425.Header.Caption = "Fecha"
        UltraGridColumn425.Header.VisiblePosition = 3
        UltraGridColumn425.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn425.Width = 151
        Appearance140.TextHAlignAsString = "Right"
        UltraGridColumn426.CellAppearance = Appearance140
        UltraGridColumn426.Header.Caption = "KM Tanqueo"
        UltraGridColumn426.Header.VisiblePosition = 5
        UltraGridColumn426.MaskInput = "{double:9.4}"
        UltraGridColumn426.Width = 82
        Appearance141.TextHAlignAsString = "Right"
        UltraGridColumn427.CellAppearance = Appearance141
        UltraGridColumn427.Header.Caption = "Can(Gls)"
        UltraGridColumn427.Header.VisiblePosition = 6
        UltraGridColumn427.MaskInput = "{double:9.4}"
        UltraGridColumn427.Width = 77
        UltraGridColumn428.Header.Caption = "Nro Vale"
        UltraGridColumn428.Header.VisiblePosition = 8
        UltraGridColumn428.Width = 113
        UltraGridColumn429.Header.VisiblePosition = 9
        UltraGridColumn429.Hidden = True
        UltraGridColumn430.Header.VisiblePosition = 10
        UltraGridColumn430.Hidden = True
        UltraGridColumn431.Header.VisiblePosition = 11
        UltraGridColumn431.Hidden = True
        UltraGridColumn432.Header.VisiblePosition = 12
        UltraGridColumn432.Hidden = True
        UltraGridColumn433.Header.VisiblePosition = 13
        UltraGridColumn433.Hidden = True
        UltraGridColumn434.Header.Caption = "Full/Rell"
        UltraGridColumn434.Header.VisiblePosition = 7
        UltraGridColumn434.Width = 63
        UltraGridColumn435.Header.VisiblePosition = 14
        UltraGridColumn435.Hidden = True
        UltraGridColumn436.Header.VisiblePosition = 15
        UltraGridColumn436.Hidden = True
        UltraGridColumn437.Header.VisiblePosition = 16
        UltraGridColumn437.Hidden = True
        UltraGridColumn438.Header.VisiblePosition = 17
        UltraGridColumn438.Hidden = True
        Appearance142.TextHAlignAsString = "Right"
        UltraGridColumn439.CellAppearance = Appearance142
        UltraGridColumn439.Header.Caption = "Saldo(Gls)"
        UltraGridColumn439.Header.VisiblePosition = 18
        UltraGridColumn439.Hidden = True
        UltraGridColumn439.Width = 74
        UltraGridColumn440.Header.VisiblePosition = 19
        UltraGridColumn440.Hidden = True
        UltraGridColumn441.Header.VisiblePosition = 21
        UltraGridColumn441.Hidden = True
        UltraGridColumn442.Header.VisiblePosition = 22
        UltraGridColumn442.Hidden = True
        UltraGridColumn443.Header.VisiblePosition = 23
        UltraGridColumn443.Hidden = True
        UltraGridColumn444.Header.VisiblePosition = 24
        UltraGridColumn444.Hidden = True
        UltraGridColumn445.Header.VisiblePosition = 25
        UltraGridColumn445.Hidden = True
        UltraGridColumn446.Header.VisiblePosition = 26
        UltraGridColumn446.Hidden = True
        Appearance143.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn447.CellAppearance = Appearance143
        UltraGridColumn447.Header.Caption = "Tracto"
        UltraGridColumn447.Header.VisiblePosition = 4
        UltraGridColumn447.Width = 87
        UltraGridColumn448.Header.VisiblePosition = 27
        UltraGridColumn448.Hidden = True
        UltraGridColumn449.Header.VisiblePosition = 28
        UltraGridColumn449.Hidden = True
        UltraGridColumn450.Header.VisiblePosition = 29
        UltraGridColumn450.Hidden = True
        UltraGridColumn451.Header.VisiblePosition = 30
        UltraGridColumn452.Header.VisiblePosition = 31
        UltraGridColumn452.Hidden = True
        UltraGridColumn452.Width = 71
        UltraGridColumn453.Header.Caption = "Grifo"
        UltraGridColumn453.Header.VisiblePosition = 32
        UltraGridColumn453.Width = 238
        UltraGridColumn454.Header.Caption = "Direccion"
        UltraGridColumn454.Header.VisiblePosition = 34
        UltraGridColumn454.Width = 241
        UltraGridColumn455.Header.Caption = "Lugar"
        UltraGridColumn455.Header.VisiblePosition = 33
        UltraGridColumn455.Width = 166
        UltraGridColumn456.Header.VisiblePosition = 35
        UltraGridColumn456.Hidden = True
        UltraGridColumn457.Header.VisiblePosition = 36
        UltraGridColumn457.Hidden = True
        UltraGridColumn458.Header.VisiblePosition = 37
        UltraGridColumn458.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429, UltraGridColumn430, UltraGridColumn431, UltraGridColumn432, UltraGridColumn433, UltraGridColumn434, UltraGridColumn435, UltraGridColumn436, UltraGridColumn437, UltraGridColumn438, UltraGridColumn439, UltraGridColumn440, UltraGridColumn441, UltraGridColumn442, UltraGridColumn443, UltraGridColumn444, UltraGridColumn445, UltraGridColumn446, UltraGridColumn447, UltraGridColumn448, UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn452, UltraGridColumn453, UltraGridColumn454, UltraGridColumn455, UltraGridColumn456, UltraGridColumn457, UltraGridColumn458})
        Me.grid_TanqNoAsoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_TanqNoAsoc.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_TanqNoAsoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_TanqNoAsoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_TanqNoAsoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_TanqNoAsoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_TanqNoAsoc.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_TanqNoAsoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_TanqNoAsoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_TanqNoAsoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_TanqNoAsoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_TanqNoAsoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_TanqNoAsoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_TanqNoAsoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_TanqNoAsoc.Location = New System.Drawing.Point(0, 0)
        Me.grid_TanqNoAsoc.Name = "grid_TanqNoAsoc"
        Me.grid_TanqNoAsoc.Size = New System.Drawing.Size(1183, 183)
        Me.grid_TanqNoAsoc.TabIndex = 1
        '
        'odTanqueosNoAsociados
        '
        UltraDataColumn146.DataType = GetType(Boolean)
        UltraDataColumn159.DataType = GetType(Boolean)
        Me.odTanqueosNoAsociados.Band.Columns.AddRange(New Object() {UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea21)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea22)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea23)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea24)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea11)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea12)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea9)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraToolbarsDockArea10)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1193, 411)
        '
        'UltraToolbarsDockArea21
        '
        Me.UltraToolbarsDockArea21.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea21.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea21.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea21.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea21.Name = "UltraToolbarsDockArea21"
        Me.UltraToolbarsDockArea21.Size = New System.Drawing.Size(1193, 0)
        '
        'UltraToolbarsDockArea22
        '
        Me.UltraToolbarsDockArea22.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea22.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea22.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea22.Location = New System.Drawing.Point(0, 411)
        Me.UltraToolbarsDockArea22.Name = "UltraToolbarsDockArea22"
        Me.UltraToolbarsDockArea22.Size = New System.Drawing.Size(1193, 0)
        '
        'UltraToolbarsDockArea23
        '
        Me.UltraToolbarsDockArea23.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea23.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea23.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea23.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea23.Name = "UltraToolbarsDockArea23"
        Me.UltraToolbarsDockArea23.Size = New System.Drawing.Size(0, 411)
        '
        'UltraToolbarsDockArea24
        '
        Me.UltraToolbarsDockArea24.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea24.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea24.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea24.Location = New System.Drawing.Point(1193, 0)
        Me.UltraToolbarsDockArea24.Name = "UltraToolbarsDockArea24"
        Me.UltraToolbarsDockArea24.Size = New System.Drawing.Size(0, 411)
        '
        'UltraToolbarsDockArea11
        '
        Me.UltraToolbarsDockArea11.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea11.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea11.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea11.Name = "UltraToolbarsDockArea11"
        Me.UltraToolbarsDockArea11.Size = New System.Drawing.Size(0, 411)
        '
        'UltraToolbarsDockArea12
        '
        Me.UltraToolbarsDockArea12.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea12.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea12.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea12.Location = New System.Drawing.Point(1193, 0)
        Me.UltraToolbarsDockArea12.Name = "UltraToolbarsDockArea12"
        Me.UltraToolbarsDockArea12.Size = New System.Drawing.Size(0, 411)
        '
        'UltraToolbarsDockArea9
        '
        Me.UltraToolbarsDockArea9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea9.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea9.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea9.Location = New System.Drawing.Point(0, 0)
        Me.UltraToolbarsDockArea9.Name = "UltraToolbarsDockArea9"
        Me.UltraToolbarsDockArea9.Size = New System.Drawing.Size(1193, 0)
        '
        'UltraToolbarsDockArea10
        '
        Me.UltraToolbarsDockArea10.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea10.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea10.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea10.Location = New System.Drawing.Point(0, 411)
        Me.UltraToolbarsDockArea10.Name = "UltraToolbarsDockArea10"
        Me.UltraToolbarsDockArea10.Size = New System.Drawing.Size(1193, 0)
        '
        'agrDatoGeneral
        '
        Appearance144.BackColor = System.Drawing.Color.White
        Appearance144.BackColor2 = System.Drawing.Color.White
        Me.agrDatoGeneral.ContentAreaAppearance = Appearance144
        Me.agrDatoGeneral.Controls.Add(Me.ag_Datos)
        Me.agrDatoGeneral.Controls.Add(Me.ag_DatosGrifo)
        Me.agrDatoGeneral.Controls.Add(Me.ag_Operacion)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1193, 411)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Ticket Combustible"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ag_Datos
        '
        Me.ag_Datos.Controls.Add(Me.chk_Credito)
        Me.ag_Datos.Controls.Add(Me.Etiqueta47)
        Me.ag_Datos.Controls.Add(Me.txtGlosaTanqueo)
        Me.ag_Datos.Controls.Add(Me.fecFechaTanqueo)
        Me.ag_Datos.Controls.Add(Me.PanelGrifo)
        Me.ag_Datos.Controls.Add(Me.lblRango)
        Me.ag_Datos.Controls.Add(Me.cmb_TipoCombustible)
        Me.ag_Datos.Controls.Add(Me.Etiqueta9)
        Me.ag_Datos.Controls.Add(Me.txt_NroVale)
        Me.ag_Datos.Controls.Add(Me.nd_PrecioUnitario)
        Me.ag_Datos.Controls.Add(Me.nd_CantGalones)
        Me.ag_Datos.Controls.Add(Me.nd_KmTanqueo)
        Me.ag_Datos.Controls.Add(Me.Etiqueta2)
        Me.ag_Datos.Controls.Add(Me.opt_IndTanqueo)
        Me.ag_Datos.Controls.Add(Me.Etiqueta15)
        Me.ag_Datos.Controls.Add(Me.Etiqueta17)
        Me.ag_Datos.Controls.Add(Me.Etiqueta5)
        Me.ag_Datos.Controls.Add(Me.Etiqueta4)
        Me.ag_Datos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag_Datos.ForeColor = System.Drawing.Color.Black
        Me.ag_Datos.Location = New System.Drawing.Point(11, 140)
        Me.ag_Datos.Name = "ag_Datos"
        Me.ag_Datos.Size = New System.Drawing.Size(466, 251)
        Me.ag_Datos.TabIndex = 1
        Me.ag_Datos.Text = "Datos a Ingresar"
        Me.ag_Datos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chk_Credito
        '
        Me.chk_Credito.AutoSize = True
        Me.chk_Credito.BackColor = System.Drawing.Color.Transparent
        Me.chk_Credito.ForeColor = System.Drawing.Color.Navy
        Me.chk_Credito.Location = New System.Drawing.Point(349, 25)
        Me.chk_Credito.Name = "chk_Credito"
        Me.chk_Credito.Size = New System.Drawing.Size(61, 17)
        Me.chk_Credito.TabIndex = 335
        Me.chk_Credito.Text = "Credito"
        Me.chk_Credito.UseVisualStyleBackColor = False
        '
        'Etiqueta47
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta47.Appearance = Appearance145
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta47.Location = New System.Drawing.Point(50, 197)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta47.TabIndex = 14
        Me.Etiqueta47.Text = "Glosa:"
        '
        'txtGlosaTanqueo
        '
        Appearance146.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo.Appearance = Appearance146
        Me.txtGlosaTanqueo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaTanqueo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaTanqueo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaTanqueo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosaTanqueo.Location = New System.Drawing.Point(95, 195)
        Me.txtGlosaTanqueo.MaxLength = 60
        Me.txtGlosaTanqueo.Multiline = True
        Me.txtGlosaTanqueo.Name = "txtGlosaTanqueo"
        Me.txtGlosaTanqueo.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaTanqueo.Size = New System.Drawing.Size(363, 40)
        Me.txtGlosaTanqueo.TabIndex = 15
        Me.txtGlosaTanqueo.Tag = "0"
        '
        'fecFechaTanqueo
        '
        Appearance147.ForeColor = System.Drawing.Color.Black
        Me.fecFechaTanqueo.Appearance = Appearance147
        Me.fecFechaTanqueo.DateTime = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.fecFechaTanqueo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaTanqueo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaTanqueo.ForeColor = System.Drawing.Color.Black
        Me.fecFechaTanqueo.Location = New System.Drawing.Point(98, 23)
        Me.fecFechaTanqueo.MaskInput = "{date} {time}"
        Me.fecFechaTanqueo.Name = "fecFechaTanqueo"
        Me.fecFechaTanqueo.Size = New System.Drawing.Size(144, 22)
        Me.fecFechaTanqueo.TabIndex = 1
        Me.fecFechaTanqueo.Value = New Date(2014, 9, 29, 0, 0, 0, 0)
        '
        'PanelGrifo
        '
        Appearance148.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelGrifo.Appearance = Appearance148
        Me.PanelGrifo.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched
        '
        'PanelGrifo.ClientArea
        '
        Me.PanelGrifo.ClientArea.Controls.Add(Me.PanelImagen)
        Me.PanelGrifo.ClientArea.Controls.Add(Me.PanelManguera)
        Me.PanelGrifo.Location = New System.Drawing.Point(349, 46)
        Me.PanelGrifo.Name = "PanelGrifo"
        Me.PanelGrifo.Size = New System.Drawing.Size(111, 143)
        Me.PanelGrifo.TabIndex = 334
        Me.PanelGrifo.Visible = False
        '
        'PanelImagen
        '
        Appearance149.BackColor = System.Drawing.Color.Beige
        Me.PanelImagen.Appearance = Appearance149
        '
        'PanelImagen.ClientArea
        '
        Me.PanelImagen.ClientArea.Controls.Add(Me.Panel3)
        Me.PanelImagen.ClientArea.Controls.Add(Me.TxtNumManguera)
        Me.PanelImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImagen.Location = New System.Drawing.Point(0, 0)
        Me.PanelImagen.Name = "PanelImagen"
        Me.PanelImagen.Size = New System.Drawing.Size(107, 67)
        Me.PanelImagen.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(60, 67)
        Me.Panel3.TabIndex = 0
        '
        'TxtNumManguera
        '
        Appearance150.ForeColor = System.Drawing.Color.Red
        Me.TxtNumManguera.Appearance = Appearance150
        Me.TxtNumManguera.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.TxtNumManguera.Location = New System.Drawing.Point(66, 12)
        Me.TxtNumManguera.Name = "TxtNumManguera"
        Me.TxtNumManguera.Size = New System.Drawing.Size(34, 36)
        Me.TxtNumManguera.TabIndex = 1
        '
        'PanelManguera
        '
        Appearance151.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelManguera.Appearance = Appearance151
        Me.PanelManguera.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched
        '
        'PanelManguera.ClientArea
        '
        Me.PanelManguera.ClientArea.Controls.Add(Me.OptManguera1)
        Me.PanelManguera.ClientArea.Controls.Add(Me.OptNinguno)
        Me.PanelManguera.ClientArea.Controls.Add(Me.OptManguera2)
        Me.PanelManguera.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelManguera.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelManguera.Location = New System.Drawing.Point(0, 67)
        Me.PanelManguera.Name = "PanelManguera"
        Me.PanelManguera.Size = New System.Drawing.Size(107, 72)
        Me.PanelManguera.TabIndex = 0
        '
        'OptManguera1
        '
        Me.OptManguera1.AutoSize = True
        Me.OptManguera1.Location = New System.Drawing.Point(6, 4)
        Me.OptManguera1.Name = "OptManguera1"
        Me.OptManguera1.Size = New System.Drawing.Size(88, 17)
        Me.OptManguera1.TabIndex = 0
        Me.OptManguera1.Text = "Manguera 01"
        Me.OptManguera1.UseVisualStyleBackColor = True
        '
        'OptNinguno
        '
        Me.OptNinguno.AutoSize = True
        Me.OptNinguno.Checked = True
        Me.OptNinguno.Location = New System.Drawing.Point(6, 47)
        Me.OptNinguno.Name = "OptNinguno"
        Me.OptNinguno.Size = New System.Drawing.Size(64, 17)
        Me.OptNinguno.TabIndex = 2
        Me.OptNinguno.TabStop = True
        Me.OptNinguno.Text = "Ninguno"
        Me.OptNinguno.UseVisualStyleBackColor = True
        '
        'OptManguera2
        '
        Me.OptManguera2.AutoSize = True
        Me.OptManguera2.Location = New System.Drawing.Point(6, 27)
        Me.OptManguera2.Name = "OptManguera2"
        Me.OptManguera2.Size = New System.Drawing.Size(88, 17)
        Me.OptManguera2.TabIndex = 1
        Me.OptManguera2.Text = "Manguera 02"
        Me.OptManguera2.UseVisualStyleBackColor = True
        '
        'lblRango
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Me.lblRango.Appearance = Appearance152
        Me.lblRango.AutoSize = True
        Me.lblRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRango.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRango.Location = New System.Drawing.Point(186, 54)
        Me.lblRango.Name = "lblRango"
        Me.lblRango.Size = New System.Drawing.Size(0, 0)
        Me.lblRango.TabIndex = 4
        '
        'cmb_TipoCombustible
        '
        Appearance153.ForeColor = System.Drawing.Color.Black
        Me.cmb_TipoCombustible.Appearance = Appearance153
        Me.cmb_TipoCombustible.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmb_TipoCombustible.DisplayMember = "Nombre"
        Me.cmb_TipoCombustible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TipoCombustible.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_TipoCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipoCombustible.ForeColor = System.Drawing.Color.Black
        Me.cmb_TipoCombustible.Location = New System.Drawing.Point(217, 79)
        Me.cmb_TipoCombustible.Name = "cmb_TipoCombustible"
        Me.cmb_TipoCombustible.Size = New System.Drawing.Size(90, 22)
        Me.cmb_TipoCombustible.TabIndex = 7
        Me.cmb_TipoCombustible.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance154
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(9, 168)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(76, 15)
        Me.Etiqueta9.TabIndex = 12
        Me.Etiqueta9.Text = "Ind. Tanqueo:"
        '
        'txt_NroVale
        '
        Appearance155.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_NroVale.Appearance = Appearance155
        Me.txt_NroVale.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NroVale.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_NroVale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroVale.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_NroVale.Location = New System.Drawing.Point(98, 107)
        Me.txt_NroVale.MaxLength = 10
        Me.txt_NroVale.Name = "txt_NroVale"
        Me.txt_NroVale.Size = New System.Drawing.Size(84, 22)
        Me.txt_NroVale.TabIndex = 9
        '
        'nd_PrecioUnitario
        '
        Appearance156.ForeColor = System.Drawing.Color.Black
        Me.nd_PrecioUnitario.Appearance = Appearance156
        Me.nd_PrecioUnitario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_PrecioUnitario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_PrecioUnitario.ForeColor = System.Drawing.Color.Black
        Me.nd_PrecioUnitario.Location = New System.Drawing.Point(98, 135)
        Me.nd_PrecioUnitario.MaskInput = "{double:3.4}"
        Me.nd_PrecioUnitario.Name = "nd_PrecioUnitario"
        Me.nd_PrecioUnitario.NullText = "0.00"
        Me.nd_PrecioUnitario.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_PrecioUnitario.Size = New System.Drawing.Size(84, 22)
        Me.nd_PrecioUnitario.TabIndex = 11
        Me.nd_PrecioUnitario.Visible = False
        '
        'nd_CantGalones
        '
        Appearance157.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalones.Appearance = Appearance157
        Me.nd_CantGalones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_CantGalones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_CantGalones.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalones.Location = New System.Drawing.Point(98, 79)
        Me.nd_CantGalones.MaskInput = "{double:3.4}"
        Me.nd_CantGalones.Name = "nd_CantGalones"
        Me.nd_CantGalones.NullText = "0.00"
        Me.nd_CantGalones.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_CantGalones.Size = New System.Drawing.Size(84, 22)
        Me.nd_CantGalones.TabIndex = 6
        '
        'nd_KmTanqueo
        '
        Appearance158.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueo.Appearance = Appearance158
        Me.nd_KmTanqueo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_KmTanqueo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_KmTanqueo.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueo.Location = New System.Drawing.Point(98, 51)
        Me.nd_KmTanqueo.MaskInput = "{double:9.2}"
        Me.nd_KmTanqueo.Name = "nd_KmTanqueo"
        Me.nd_KmTanqueo.NullText = "0.00"
        Me.nd_KmTanqueo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_KmTanqueo.Size = New System.Drawing.Size(84, 22)
        Me.nd_KmTanqueo.TabIndex = 3
        '
        'Etiqueta2
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance159
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(44, 83)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Galones:"
        '
        'opt_IndTanqueo
        '
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Appearance160.ForeColor = System.Drawing.Color.Navy
        Me.opt_IndTanqueo.Appearance = Appearance160
        Me.opt_IndTanqueo.BackColor = System.Drawing.Color.Transparent
        Me.opt_IndTanqueo.BackColorInternal = System.Drawing.Color.Transparent
        Me.opt_IndTanqueo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opt_IndTanqueo.CheckedIndex = 0
        Me.opt_IndTanqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_IndTanqueo.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "ValueListItem1"
        ValueListItem1.DisplayText = "Full:"
        ValueListItem2.DataValue = False
        ValueListItem2.DisplayText = "Relleno:"
        Me.opt_IndTanqueo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.opt_IndTanqueo.ItemSpacingHorizontal = 30
        Me.opt_IndTanqueo.ItemSpacingVertical = 20
        Me.opt_IndTanqueo.Location = New System.Drawing.Point(95, 163)
        Me.opt_IndTanqueo.Name = "opt_IndTanqueo"
        Me.opt_IndTanqueo.Size = New System.Drawing.Size(162, 24)
        Me.opt_IndTanqueo.TabIndex = 13
        Me.opt_IndTanqueo.Text = "Full:"
        '
        'Etiqueta15
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance161
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(27, 55)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(65, 15)
        Me.Etiqueta15.TabIndex = 2
        Me.Etiqueta15.Text = "Kilometraje:"
        '
        'Etiqueta17
        '
        Appearance162.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta17.Appearance = Appearance162
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(7, 27)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(85, 15)
        Me.Etiqueta17.TabIndex = 0
        Me.Etiqueta17.Text = "Fecha Tanqueo:"
        '
        'Etiqueta5
        '
        Appearance163.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance163
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(11, 139)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(81, 15)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Precio Unitario:"
        Me.Etiqueta5.Visible = False
        '
        'Etiqueta4
        '
        Appearance164.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance164
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(41, 111)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Nro Vale:"
        '
        'ag_DatosGrifo
        '
        Me.ag_DatosGrifo.Controls.Add(Me.eti_Galones)
        Me.ag_DatosGrifo.Controls.Add(Me.dtp_FecViaje)
        Me.ag_DatosGrifo.Controls.Add(Me.etiStock)
        Me.ag_DatosGrifo.Controls.Add(Me.decStock)
        Me.ag_DatosGrifo.Controls.Add(Me.Etiqueta7)
        Me.ag_DatosGrifo.Controls.Add(Me.cboDireccion)
        Me.ag_DatosGrifo.Controls.Add(Me.Etiqueta6)
        Me.ag_DatosGrifo.Controls.Add(Me.cboLugar)
        Me.ag_DatosGrifo.Controls.Add(Me.Etiqueta3)
        Me.ag_DatosGrifo.Controls.Add(Me.cboGrifo)
        Me.ag_DatosGrifo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag_DatosGrifo.ForeColor = System.Drawing.Color.Black
        Me.ag_DatosGrifo.Location = New System.Drawing.Point(483, 23)
        Me.ag_DatosGrifo.Name = "ag_DatosGrifo"
        Me.ag_DatosGrifo.Size = New System.Drawing.Size(376, 368)
        Me.ag_DatosGrifo.TabIndex = 2
        Me.ag_DatosGrifo.Text = "Datos Grifo"
        Me.ag_DatosGrifo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'eti_Galones
        '
        Appearance165.BackColor = System.Drawing.Color.Transparent
        Me.eti_Galones.Appearance = Appearance165
        Me.eti_Galones.AutoSize = True
        Me.eti_Galones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti_Galones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.eti_Galones.Location = New System.Drawing.Point(193, 110)
        Me.eti_Galones.Name = "eti_Galones"
        Me.eti_Galones.Size = New System.Drawing.Size(24, 14)
        Me.eti_Galones.TabIndex = 8
        Me.eti_Galones.Text = "Gls."
        Me.eti_Galones.Visible = False
        '
        'dtp_FecViaje
        '
        Appearance166.ForeColor = System.Drawing.Color.Black
        Me.dtp_FecViaje.Appearance = Appearance166
        Me.dtp_FecViaje.DateTime = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtp_FecViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FecViaje.ForeColor = System.Drawing.Color.Black
        Me.dtp_FecViaje.Location = New System.Drawing.Point(6, 331)
        Me.dtp_FecViaje.MaskInput = "{date} {time}"
        Me.dtp_FecViaje.Name = "dtp_FecViaje"
        Me.dtp_FecViaje.Size = New System.Drawing.Size(131, 22)
        Me.dtp_FecViaje.TabIndex = 9
        Me.dtp_FecViaje.Value = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FecViaje.Visible = False
        '
        'etiStock
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Me.etiStock.Appearance = Appearance167
        Me.etiStock.AutoSize = True
        Me.etiStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiStock.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiStock.Location = New System.Drawing.Point(37, 110)
        Me.etiStock.Name = "etiStock"
        Me.etiStock.Size = New System.Drawing.Size(35, 15)
        Me.etiStock.TabIndex = 6
        Me.etiStock.Text = "Stock:"
        Me.etiStock.Visible = False
        '
        'decStock
        '
        Appearance168.ForeColor = System.Drawing.Color.Black
        Me.decStock.Appearance = Appearance168
        Me.decStock.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decStock.Enabled = False
        Me.decStock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decStock.ForeColor = System.Drawing.Color.Black
        Me.decStock.Location = New System.Drawing.Point(78, 106)
        Me.decStock.MaskInput = "{double:9.4}"
        Me.decStock.Name = "decStock"
        Me.decStock.NullText = "0.00"
        Me.decStock.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decStock.Size = New System.Drawing.Size(109, 22)
        Me.decStock.TabIndex = 7
        Me.decStock.Visible = False
        '
        'Etiqueta7
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance169
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(10, 83)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "EE.SS./Dir.:"
        '
        'cboDireccion
        '
        Appearance170.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Appearance = Appearance170
        Me.cboDireccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDireccion.DisplayMember = "Nombre"
        Me.cboDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccion.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Location = New System.Drawing.Point(78, 79)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(279, 22)
        Me.cboDireccion.TabIndex = 5
        Me.cboDireccion.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Appearance171.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance171
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(36, 58)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Lugar:"
        '
        'cboLugar
        '
        Appearance172.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance172
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayMember = "Nombre"
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboLugar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(78, 54)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(279, 22)
        Me.cboLugar.TabIndex = 3
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance173.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance173
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(40, 31)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Grifo:"
        '
        'cboGrifo
        '
        Appearance174.ForeColor = System.Drawing.Color.Black
        Me.cboGrifo.Appearance = Appearance174
        Me.cboGrifo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboGrifo.DisplayMember = "Nombre"
        Me.cboGrifo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGrifo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrifo.ForeColor = System.Drawing.Color.Black
        Me.cboGrifo.Location = New System.Drawing.Point(78, 27)
        Me.cboGrifo.Name = "cboGrifo"
        Me.cboGrifo.Size = New System.Drawing.Size(279, 22)
        Me.cboGrifo.TabIndex = 1
        Me.cboGrifo.ValueMember = "Id"
        '
        'ag_Operacion
        '
        Me.ag_Operacion.Controls.Add(Me.VerISL)
        Me.ag_Operacion.Controls.Add(Me.txtPiloto)
        Me.ag_Operacion.Controls.Add(Me.Etiqueta10)
        Me.ag_Operacion.Controls.Add(Me.decOdometro)
        Me.ag_Operacion.Controls.Add(Me.Etiqueta1)
        Me.ag_Operacion.Controls.Add(Me.Etiqueta20)
        Me.ag_Operacion.Controls.Add(Me.Etiqueta16)
        Me.ag_Operacion.Controls.Add(Me.txtViaje)
        Me.ag_Operacion.Controls.Add(Me.cboVehiculo)
        Me.ag_Operacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag_Operacion.ForeColor = System.Drawing.Color.Black
        Me.ag_Operacion.Location = New System.Drawing.Point(11, 23)
        Me.ag_Operacion.Name = "ag_Operacion"
        Me.ag_Operacion.Size = New System.Drawing.Size(466, 111)
        Me.ag_Operacion.TabIndex = 0
        Me.ag_Operacion.Text = "Operacion"
        Me.ag_Operacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'VerISL
        '
        Me.VerISL.AutoSize = True
        Me.VerISL.BackColor = System.Drawing.Color.Transparent
        Me.VerISL.ForeColor = System.Drawing.Color.Navy
        Me.VerISL.Location = New System.Drawing.Point(340, 30)
        Me.VerISL.Name = "VerISL"
        Me.VerISL.Size = New System.Drawing.Size(68, 17)
        Me.VerISL.TabIndex = 9
        Me.VerISL.Text = "VER EMP"
        Me.VerISL.UseVisualStyleBackColor = False
        '
        'txtPiloto
        '
        Appearance175.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPiloto.Appearance = Appearance175
        Me.txtPiloto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPiloto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiloto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPiloto.Location = New System.Drawing.Point(95, 81)
        Me.txtPiloto.MaxLength = 200
        Me.txtPiloto.Name = "txtPiloto"
        Me.txtPiloto.ReadOnly = True
        Me.txtPiloto.Size = New System.Drawing.Size(324, 22)
        Me.txtPiloto.TabIndex = 5
        '
        'Etiqueta10
        '
        Appearance176.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance176
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(53, 83)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta10.TabIndex = 4
        Me.Etiqueta10.Text = "Piloto:"
        '
        'decOdometro
        '
        Appearance177.ForeColor = System.Drawing.Color.Black
        Me.decOdometro.Appearance = Appearance177
        Me.decOdometro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decOdometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decOdometro.ForeColor = System.Drawing.Color.Black
        Me.decOdometro.Location = New System.Drawing.Point(340, 54)
        Me.decOdometro.Name = "decOdometro"
        Me.decOdometro.NullText = "0.00"
        Me.decOdometro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decOdometro.ReadOnly = True
        Me.decOdometro.Size = New System.Drawing.Size(79, 21)
        Me.decOdometro.TabIndex = 8
        '
        'Etiqueta1
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance178
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(276, 58)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta1.TabIndex = 7
        Me.Etiqueta1.Text = "Odometro:"
        '
        'Etiqueta20
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta20.Appearance = Appearance179
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(56, 31)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta20.TabIndex = 0
        Me.Etiqueta20.Text = "Viaje:"
        '
        'Etiqueta16
        '
        Appearance180.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance180
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(39, 60)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta16.TabIndex = 2
        Me.Etiqueta16.Text = "Vehiculo:"
        '
        'txtViaje
        '
        Appearance181.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtViaje.Appearance = Appearance181
        Me.txtViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtViaje.Location = New System.Drawing.Point(95, 27)
        Me.txtViaje.MaxLength = 200
        Me.txtViaje.Name = "txtViaje"
        Me.txtViaje.ReadOnly = True
        Me.txtViaje.Size = New System.Drawing.Size(103, 22)
        Me.txtViaje.TabIndex = 1
        '
        'cboVehiculo
        '
        Appearance182.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Appearance = Appearance182
        Me.cboVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboVehiculo.DisplayMember = "Nombre"
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Location = New System.Drawing.Point(95, 54)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(103, 21)
        Me.cboVehiculo.TabIndex = 3
        Me.cboVehiculo.ValueMember = "Id"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.grid_RegTanqNoAsoc)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1193, 411)
        '
        'grid_RegTanqNoAsoc
        '
        Me.grid_RegTanqNoAsoc.ContextMenuStrip = Me.MenuTanqueo
        Me.grid_RegTanqNoAsoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid_RegTanqNoAsoc.DataSource = Me.odTanqueosNoAsociados
        UltraGridColumn459.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn459.Header.VisiblePosition = 0
        UltraGridColumn459.Hidden = True
        UltraGridColumn459.Width = 27
        UltraGridColumn460.Header.VisiblePosition = 20
        UltraGridColumn460.Hidden = True
        UltraGridColumn461.Header.Caption = "Viaje"
        UltraGridColumn461.Header.VisiblePosition = 1
        UltraGridColumn461.Hidden = True
        UltraGridColumn461.Width = 125
        UltraGridColumn462.Header.VisiblePosition = 2
        UltraGridColumn462.Hidden = True
        UltraGridColumn463.Header.Caption = "Fecha"
        UltraGridColumn463.Header.VisiblePosition = 3
        UltraGridColumn463.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn463.Width = 165
        Appearance183.TextHAlignAsString = "Right"
        UltraGridColumn464.CellAppearance = Appearance183
        UltraGridColumn464.Header.Caption = "KM Tanqueo"
        UltraGridColumn464.Header.VisiblePosition = 5
        UltraGridColumn464.MaskInput = "{double:9.4}"
        UltraGridColumn464.Width = 101
        Appearance184.TextHAlignAsString = "Right"
        UltraGridColumn465.CellAppearance = Appearance184
        UltraGridColumn465.Header.Caption = "Can(Gls)"
        UltraGridColumn465.Header.VisiblePosition = 6
        UltraGridColumn465.MaskInput = "{double:9.4}"
        UltraGridColumn465.Width = 95
        UltraGridColumn466.Header.Caption = "Nro Vale"
        UltraGridColumn466.Header.VisiblePosition = 8
        UltraGridColumn466.Width = 113
        UltraGridColumn467.Header.VisiblePosition = 9
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 10
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 11
        UltraGridColumn469.Hidden = True
        UltraGridColumn470.Header.VisiblePosition = 12
        UltraGridColumn470.Hidden = True
        UltraGridColumn471.Header.VisiblePosition = 13
        UltraGridColumn471.Hidden = True
        UltraGridColumn472.Header.Caption = "Full/Rell"
        UltraGridColumn472.Header.VisiblePosition = 7
        UltraGridColumn472.Width = 63
        UltraGridColumn473.Header.VisiblePosition = 14
        UltraGridColumn473.Hidden = True
        UltraGridColumn474.Header.VisiblePosition = 15
        UltraGridColumn474.Hidden = True
        UltraGridColumn475.Header.VisiblePosition = 16
        UltraGridColumn475.Hidden = True
        UltraGridColumn476.Header.VisiblePosition = 17
        UltraGridColumn476.Hidden = True
        Appearance185.TextHAlignAsString = "Right"
        UltraGridColumn477.CellAppearance = Appearance185
        UltraGridColumn477.Header.Caption = "Saldo(Gls)"
        UltraGridColumn477.Header.VisiblePosition = 18
        UltraGridColumn477.Hidden = True
        UltraGridColumn477.Width = 74
        UltraGridColumn478.Header.VisiblePosition = 19
        UltraGridColumn478.Hidden = True
        UltraGridColumn479.Header.VisiblePosition = 21
        UltraGridColumn479.Hidden = True
        UltraGridColumn480.Header.VisiblePosition = 22
        UltraGridColumn480.Hidden = True
        UltraGridColumn481.Header.VisiblePosition = 23
        UltraGridColumn481.Hidden = True
        UltraGridColumn482.Header.VisiblePosition = 24
        UltraGridColumn482.Hidden = True
        UltraGridColumn483.Header.VisiblePosition = 25
        UltraGridColumn483.Hidden = True
        UltraGridColumn484.Header.VisiblePosition = 26
        UltraGridColumn484.Hidden = True
        Appearance186.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn485.CellAppearance = Appearance186
        UltraGridColumn485.Header.Caption = "Tracto"
        UltraGridColumn485.Header.VisiblePosition = 4
        UltraGridColumn485.Width = 87
        UltraGridColumn486.Header.VisiblePosition = 27
        UltraGridColumn486.Hidden = True
        UltraGridColumn487.Header.VisiblePosition = 28
        UltraGridColumn487.Hidden = True
        UltraGridColumn488.Header.VisiblePosition = 29
        UltraGridColumn488.Hidden = True
        UltraGridColumn489.Header.VisiblePosition = 30
        UltraGridColumn489.Hidden = True
        UltraGridColumn490.Header.VisiblePosition = 31
        UltraGridColumn490.Hidden = True
        UltraGridColumn491.Header.Caption = "Grifo"
        UltraGridColumn491.Header.VisiblePosition = 32
        UltraGridColumn491.Width = 252
        UltraGridColumn492.Header.Caption = "Direccion"
        UltraGridColumn492.Header.VisiblePosition = 34
        UltraGridColumn492.Width = 216
        UltraGridColumn493.Header.Caption = "Lugar"
        UltraGridColumn493.Header.VisiblePosition = 33
        UltraGridColumn493.Hidden = True
        UltraGridColumn493.Width = 150
        UltraGridColumn494.Header.VisiblePosition = 35
        UltraGridColumn495.Header.VisiblePosition = 36
        UltraGridColumn496.Header.VisiblePosition = 37
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496})
        Me.grid_RegTanqNoAsoc.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_RegTanqNoAsoc.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_RegTanqNoAsoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_RegTanqNoAsoc.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_RegTanqNoAsoc.Location = New System.Drawing.Point(0, 38)
        Me.grid_RegTanqNoAsoc.Name = "grid_RegTanqNoAsoc"
        Me.grid_RegTanqNoAsoc.Size = New System.Drawing.Size(1193, 373)
        Me.grid_RegTanqNoAsoc.TabIndex = 1
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion6.Controls.Add(Me.cboDireccionTNA)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion6.Controls.Add(Me.cboLugarTNA)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion6.Controls.Add(Me.cboGrifoTNA)
        Me.Agrupacion6.Controls.Add(Me.btnImportar)
        Me.Agrupacion6.Controls.Add(Me.btnGuardar)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1193, 38)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta8
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance187
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(808, 12)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta8.TabIndex = 6
        Me.Etiqueta8.Text = "Direccion:"
        Me.Etiqueta8.Visible = False
        '
        'cboDireccionTNA
        '
        Appearance188.ForeColor = System.Drawing.Color.Black
        Me.cboDireccionTNA.Appearance = Appearance188
        Me.cboDireccionTNA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDireccionTNA.DisplayMember = "Nombre"
        Me.cboDireccionTNA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccionTNA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccionTNA.ForeColor = System.Drawing.Color.Black
        Me.cboDireccionTNA.Location = New System.Drawing.Point(868, 8)
        Me.cboDireccionTNA.Name = "cboDireccionTNA"
        Me.cboDireccionTNA.Size = New System.Drawing.Size(279, 22)
        Me.cboDireccionTNA.TabIndex = 7
        Me.cboDireccionTNA.ValueMember = "Id"
        Me.cboDireccionTNA.Visible = False
        '
        'Etiqueta11
        '
        Appearance189.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance189
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(528, 12)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta11.TabIndex = 4
        Me.Etiqueta11.Text = "Lugar:"
        Me.Etiqueta11.Visible = False
        '
        'cboLugarTNA
        '
        Appearance190.ForeColor = System.Drawing.Color.Black
        Me.cboLugarTNA.Appearance = Appearance190
        Me.cboLugarTNA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarTNA.DisplayMember = "Nombre"
        Me.cboLugarTNA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarTNA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarTNA.ForeColor = System.Drawing.Color.Black
        Me.cboLugarTNA.Location = New System.Drawing.Point(570, 8)
        Me.cboLugarTNA.Name = "cboLugarTNA"
        Me.cboLugarTNA.Size = New System.Drawing.Size(232, 22)
        Me.cboLugarTNA.TabIndex = 5
        Me.cboLugarTNA.ValueMember = "Id"
        Me.cboLugarTNA.Visible = False
        '
        'Etiqueta12
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance191
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(205, 12)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta12.TabIndex = 2
        Me.Etiqueta12.Text = "Grifo:"
        Me.Etiqueta12.Visible = False
        '
        'cboGrifoTNA
        '
        Appearance192.ForeColor = System.Drawing.Color.Black
        Me.cboGrifoTNA.Appearance = Appearance192
        Me.cboGrifoTNA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboGrifoTNA.DisplayMember = "Nombre"
        Me.cboGrifoTNA.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGrifoTNA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrifoTNA.ForeColor = System.Drawing.Color.Black
        Me.cboGrifoTNA.Location = New System.Drawing.Point(243, 8)
        Me.cboGrifoTNA.Name = "cboGrifoTNA"
        Me.cboGrifoTNA.Size = New System.Drawing.Size(279, 22)
        Me.cboGrifoTNA.TabIndex = 3
        Me.cboGrifoTNA.ValueMember = "Id"
        Me.cboGrifoTNA.Visible = False
        '
        'btnImportar
        '
        Appearance193.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnImportar.Appearance = Appearance193
        Me.btnImportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnImportar.Location = New System.Drawing.Point(6, 6)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(92, 26)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        '
        'btnGuardar
        '
        Appearance194.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance194
        Me.btnGuardar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnGuardar.Location = New System.Drawing.Point(104, 6)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 26)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl9.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1193, 411)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 55)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraGroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1193, 356)
        Me.SplitContainer1.SplitterDistance = 597
        Me.SplitContainer1.TabIndex = 311
        '
        'UltraGroupBox1
        '
        Appearance195.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Appearance = Appearance195
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance196.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance196
        Me.UltraGroupBox1.Controls.Add(Me.Agrupacion2)
        Me.UltraGroupBox1.Controls.Add(Me.Agrupacion4)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(597, 356)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "MANGUERA 1"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion2
        '
        Appearance197.BackColor = System.Drawing.Color.LightGray
        Me.Agrupacion2.Appearance = Appearance197
        Me.Agrupacion2.Controls.Add(Me.Etiqueta45)
        Me.Agrupacion2.Controls.Add(Me.txtGlosaTanqueo1)
        Me.Agrupacion2.Controls.Add(Me.Panel1)
        Me.Agrupacion2.Controls.Add(Me.nd_CantGalonesS1)
        Me.Agrupacion2.Controls.Add(Me.TxtCodigoSurtidorS1)
        Me.Agrupacion2.Controls.Add(Me.dtp_FechaTanqueoS1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion2.Controls.Add(Me.nd_KmTanqueoS1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion2.Controls.Add(Me.Opt_IndTanqueoS1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta26)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 99)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(591, 254)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Datos a Ingresar"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta45
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance198
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta45.Location = New System.Drawing.Point(28, 129)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(82, 22)
        Me.Etiqueta45.TabIndex = 6
        Me.Etiqueta45.Text = "Glosa(60):"
        '
        'txtGlosaTanqueo1
        '
        Appearance199.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo1.Appearance = Appearance199
        Me.txtGlosaTanqueo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaTanqueo1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaTanqueo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaTanqueo1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo1.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosaTanqueo1.Location = New System.Drawing.Point(116, 126)
        Me.txtGlosaTanqueo1.MaxLength = 60
        Me.txtGlosaTanqueo1.Multiline = True
        Me.txtGlosaTanqueo1.Name = "txtGlosaTanqueo1"
        Me.txtGlosaTanqueo1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaTanqueo1.Size = New System.Drawing.Size(208, 64)
        Me.txtGlosaTanqueo1.TabIndex = 7
        Me.txtGlosaTanqueo1.Tag = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Location = New System.Drawing.Point(366, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 165)
        Me.Panel1.TabIndex = 11
        '
        'UltraLabel1
        '
        Appearance200.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance200
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(59, 66)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 68)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "1"
        '
        'nd_CantGalonesS1
        '
        Appearance201.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance201.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalonesS1.Appearance = Appearance201
        Me.nd_CantGalonesS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nd_CantGalonesS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_CantGalonesS1.Enabled = False
        Me.nd_CantGalonesS1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_CantGalonesS1.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalonesS1.Location = New System.Drawing.Point(116, 56)
        Me.nd_CantGalonesS1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        Me.nd_CantGalonesS1.MaskInput = "nnnnn.nnn"
        Me.nd_CantGalonesS1.Name = "nd_CantGalonesS1"
        Me.nd_CantGalonesS1.NullText = "0.00"
        Me.nd_CantGalonesS1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_CantGalonesS1.ReadOnly = True
        Me.nd_CantGalonesS1.Size = New System.Drawing.Size(149, 29)
        Me.nd_CantGalonesS1.TabIndex = 3
        '
        'TxtCodigoSurtidorS1
        '
        Appearance202.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigoSurtidorS1.Appearance = Appearance202
        Me.TxtCodigoSurtidorS1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoSurtidorS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCodigoSurtidorS1.Enabled = False
        Me.TxtCodigoSurtidorS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoSurtidorS1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigoSurtidorS1.Location = New System.Drawing.Point(271, 97)
        Me.TxtCodigoSurtidorS1.MaxLength = 200
        Me.TxtCodigoSurtidorS1.Name = "TxtCodigoSurtidorS1"
        Me.TxtCodigoSurtidorS1.ReadOnly = True
        Me.TxtCodigoSurtidorS1.Size = New System.Drawing.Size(26, 21)
        Me.TxtCodigoSurtidorS1.TabIndex = 10
        Me.TxtCodigoSurtidorS1.Visible = False
        '
        'dtp_FechaTanqueoS1
        '
        Me.dtp_FechaTanqueoS1.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaTanqueoS1.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtp_FechaTanqueoS1.CalendarTitleForeColor = System.Drawing.Color.Navy
        Me.dtp_FechaTanqueoS1.CustomFormat = "dd/MM/yyyy h:mm tt"
        Me.dtp_FechaTanqueoS1.Enabled = False
        Me.dtp_FechaTanqueoS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaTanqueoS1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FechaTanqueoS1.Location = New System.Drawing.Point(116, 24)
        Me.dtp_FechaTanqueoS1.Name = "dtp_FechaTanqueoS1"
        Me.dtp_FechaTanqueoS1.Size = New System.Drawing.Size(208, 26)
        Me.dtp_FechaTanqueoS1.TabIndex = 1
        '
        'Etiqueta22
        '
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(197, 36)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta22.TabIndex = 319
        '
        'Etiqueta23
        '
        Appearance203.BackColor = System.Drawing.Color.Transparent
        Appearance203.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance203
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(28, 189)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(80, 22)
        Me.Etiqueta23.TabIndex = 8
        Me.Etiqueta23.Text = "Indicador:"
        '
        'nd_KmTanqueoS1
        '
        Appearance204.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance204.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueoS1.Appearance = Appearance204
        Me.nd_KmTanqueoS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nd_KmTanqueoS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_KmTanqueoS1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_KmTanqueoS1.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueoS1.Location = New System.Drawing.Point(116, 91)
        Me.nd_KmTanqueoS1.MaskInput = "{double:9.2}"
        Me.nd_KmTanqueoS1.Name = "nd_KmTanqueoS1"
        Me.nd_KmTanqueoS1.NullText = "0.00"
        Me.nd_KmTanqueoS1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_KmTanqueoS1.Size = New System.Drawing.Size(149, 29)
        Me.nd_KmTanqueoS1.TabIndex = 5
        '
        'Etiqueta24
        '
        Appearance205.BackColor = System.Drawing.Color.Transparent
        Appearance205.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance205
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.Location = New System.Drawing.Point(41, 61)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(69, 22)
        Me.Etiqueta24.TabIndex = 2
        Me.Etiqueta24.Text = "Galones:"
        '
        'Opt_IndTanqueoS1
        '
        Appearance206.BackColor = System.Drawing.Color.Transparent
        Appearance206.FontData.SizeInPoints = 13.0!
        Appearance206.ForeColor = System.Drawing.Color.Navy
        Me.Opt_IndTanqueoS1.Appearance = Appearance206
        Me.Opt_IndTanqueoS1.BackColor = System.Drawing.Color.Transparent
        Me.Opt_IndTanqueoS1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Opt_IndTanqueoS1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.Opt_IndTanqueoS1.CheckedIndex = 0
        Me.Opt_IndTanqueoS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_IndTanqueoS1.ForeColor = System.Drawing.Color.Black
        ValueListItem3.DataValue = True
        ValueListItem3.DisplayText = "Full"
        ValueListItem4.DataValue = False
        ValueListItem4.DisplayText = "Relleno"
        Me.Opt_IndTanqueoS1.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.Opt_IndTanqueoS1.ItemSpacingHorizontal = 30
        Me.Opt_IndTanqueoS1.ItemSpacingVertical = 20
        Me.Opt_IndTanqueoS1.Location = New System.Drawing.Point(116, 184)
        Me.Opt_IndTanqueoS1.Name = "Opt_IndTanqueoS1"
        Me.Opt_IndTanqueoS1.Size = New System.Drawing.Size(208, 27)
        Me.Opt_IndTanqueoS1.TabIndex = 9
        Me.Opt_IndTanqueoS1.Text = "Full"
        '
        'Etiqueta25
        '
        Appearance207.BackColor = System.Drawing.Color.Transparent
        Appearance207.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance207
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta25.Location = New System.Drawing.Point(70, 96)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(40, 22)
        Me.Etiqueta25.TabIndex = 4
        Me.Etiqueta25.Text = "Km.:"
        '
        'Etiqueta26
        '
        Appearance208.BackColor = System.Drawing.Color.Transparent
        Appearance208.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance208
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(36, 25)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(75, 22)
        Me.Etiqueta26.TabIndex = 0
        Me.Etiqueta26.Text = "Tanqueo:"
        '
        'Agrupacion4
        '
        Appearance209.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion4.Appearance = Appearance209
        Appearance210.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion4.ContentAreaAppearance = Appearance210
        Me.Agrupacion4.Controls.Add(Me.BtnLimpiaS1)
        Me.Agrupacion4.Controls.Add(Me.dtp_FechaViajeS1)
        Me.Agrupacion4.Controls.Add(Me.BtnGuardarS1)
        Me.Agrupacion4.Controls.Add(Me.Txt_IdPilotoS1)
        Me.Agrupacion4.Controls.Add(Me.TxT_IdViajeS1)
        Me.Agrupacion4.Controls.Add(Me.TxtPilotoS1)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta29)
        Me.Agrupacion4.Controls.Add(Me.nd_OdometroS1)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta30)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta32)
        Me.Agrupacion4.Controls.Add(Me.TxtViajeS1)
        Me.Agrupacion4.Controls.Add(Me.CboVehiculoS1)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(3, 17)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(591, 82)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Operacion"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'BtnLimpiaS1
        '
        Appearance211.Image = "16 (Clear).ico"
        Me.BtnLimpiaS1.Appearance = Appearance211
        Me.BtnLimpiaS1.ImageList = Me.imagenes
        Me.BtnLimpiaS1.Location = New System.Drawing.Point(339, 52)
        Me.BtnLimpiaS1.Name = "BtnLimpiaS1"
        Me.BtnLimpiaS1.Size = New System.Drawing.Size(24, 23)
        Me.BtnLimpiaS1.TabIndex = 8
        '
        'dtp_FechaViajeS1
        '
        Appearance212.ForeColor = System.Drawing.Color.Black
        Me.dtp_FechaViajeS1.Appearance = Appearance212
        Me.dtp_FechaViajeS1.DateTime = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FechaViajeS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtp_FechaViajeS1.Enabled = False
        Me.dtp_FechaViajeS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaViajeS1.ForeColor = System.Drawing.Color.Black
        Me.dtp_FechaViajeS1.Location = New System.Drawing.Point(401, 52)
        Me.dtp_FechaViajeS1.MaskInput = "{date} {time}"
        Me.dtp_FechaViajeS1.Name = "dtp_FechaViajeS1"
        Me.dtp_FechaViajeS1.Size = New System.Drawing.Size(41, 22)
        Me.dtp_FechaViajeS1.TabIndex = 9
        Me.dtp_FechaViajeS1.Value = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FechaViajeS1.Visible = False
        '
        'BtnGuardarS1
        '
        Appearance213.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance213.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance213.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.BtnGuardarS1.Appearance = Appearance213
        Me.BtnGuardarS1.ImageList = Me.imagenes
        Me.BtnGuardarS1.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnGuardarS1.Location = New System.Drawing.Point(482, 25)
        Me.BtnGuardarS1.Name = "BtnGuardarS1"
        Me.BtnGuardarS1.Size = New System.Drawing.Size(56, 48)
        Me.BtnGuardarS1.TabIndex = 10
        '
        'Txt_IdPilotoS1
        '
        Appearance214.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Txt_IdPilotoS1.Appearance = Appearance214
        Me.Txt_IdPilotoS1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_IdPilotoS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Txt_IdPilotoS1.Enabled = False
        Me.Txt_IdPilotoS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IdPilotoS1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Txt_IdPilotoS1.Location = New System.Drawing.Point(464, 52)
        Me.Txt_IdPilotoS1.MaxLength = 200
        Me.Txt_IdPilotoS1.Name = "Txt_IdPilotoS1"
        Me.Txt_IdPilotoS1.ReadOnly = True
        Me.Txt_IdPilotoS1.Size = New System.Drawing.Size(12, 22)
        Me.Txt_IdPilotoS1.TabIndex = 11
        Me.Txt_IdPilotoS1.Visible = False
        '
        'TxT_IdViajeS1
        '
        Appearance215.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxT_IdViajeS1.Appearance = Appearance215
        Me.TxT_IdViajeS1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxT_IdViajeS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxT_IdViajeS1.Enabled = False
        Me.TxT_IdViajeS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT_IdViajeS1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxT_IdViajeS1.Location = New System.Drawing.Point(448, 52)
        Me.TxT_IdViajeS1.MaxLength = 200
        Me.TxT_IdViajeS1.Name = "TxT_IdViajeS1"
        Me.TxT_IdViajeS1.ReadOnly = True
        Me.TxT_IdViajeS1.Size = New System.Drawing.Size(10, 22)
        Me.TxT_IdViajeS1.TabIndex = 320
        Me.TxT_IdViajeS1.Visible = False
        '
        'TxtPilotoS1
        '
        Appearance216.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPilotoS1.Appearance = Appearance216
        Me.TxtPilotoS1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPilotoS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPilotoS1.Enabled = False
        Me.TxtPilotoS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPilotoS1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPilotoS1.Location = New System.Drawing.Point(247, 25)
        Me.TxtPilotoS1.MaxLength = 200
        Me.TxtPilotoS1.Name = "TxtPilotoS1"
        Me.TxtPilotoS1.ReadOnly = True
        Me.TxtPilotoS1.Size = New System.Drawing.Size(229, 22)
        Me.TxtPilotoS1.TabIndex = 5
        '
        'Etiqueta29
        '
        Appearance217.BackColor = System.Drawing.Color.Transparent
        Appearance217.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance217
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(205, 31)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta29.TabIndex = 4
        Me.Etiqueta29.Text = "Piloto:"
        '
        'nd_OdometroS1
        '
        Appearance218.ForeColor = System.Drawing.Color.Black
        Me.nd_OdometroS1.Appearance = Appearance218
        Me.nd_OdometroS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_OdometroS1.Enabled = False
        Me.nd_OdometroS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_OdometroS1.ForeColor = System.Drawing.Color.Black
        Me.nd_OdometroS1.Location = New System.Drawing.Point(247, 52)
        Me.nd_OdometroS1.Name = "nd_OdometroS1"
        Me.nd_OdometroS1.NullText = "0.00"
        Me.nd_OdometroS1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_OdometroS1.ReadOnly = True
        Me.nd_OdometroS1.Size = New System.Drawing.Size(86, 22)
        Me.nd_OdometroS1.TabIndex = 7
        '
        'Etiqueta30
        '
        Appearance219.BackColor = System.Drawing.Color.Transparent
        Appearance219.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance219
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(185, 56)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta30.TabIndex = 6
        Me.Etiqueta30.Text = "Odometro:"
        '
        'Etiqueta31
        '
        Appearance220.BackColor = System.Drawing.Color.Transparent
        Appearance220.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance220
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(36, 31)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta31.TabIndex = 0
        Me.Etiqueta31.Text = "Viaje:"
        '
        'Etiqueta32
        '
        Appearance221.BackColor = System.Drawing.Color.Transparent
        Appearance221.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance221
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta32.Location = New System.Drawing.Point(19, 56)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta32.TabIndex = 2
        Me.Etiqueta32.Text = "Vehiculo:"
        '
        'TxtViajeS1
        '
        Appearance222.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtViajeS1.Appearance = Appearance222
        Me.TxtViajeS1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtViajeS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtViajeS1.Enabled = False
        Me.TxtViajeS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtViajeS1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtViajeS1.Location = New System.Drawing.Point(75, 25)
        Me.TxtViajeS1.MaxLength = 200
        Me.TxtViajeS1.Name = "TxtViajeS1"
        Me.TxtViajeS1.ReadOnly = True
        Me.TxtViajeS1.Size = New System.Drawing.Size(103, 22)
        Me.TxtViajeS1.TabIndex = 1
        '
        'CboVehiculoS1
        '
        Appearance223.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance223.ForeColor = System.Drawing.Color.Black
        Me.CboVehiculoS1.Appearance = Appearance223
        Me.CboVehiculoS1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CboVehiculoS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboVehiculoS1.DisplayMember = "Nombre"
        Me.CboVehiculoS1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboVehiculoS1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboVehiculoS1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVehiculoS1.ForeColor = System.Drawing.Color.Black
        Me.CboVehiculoS1.Location = New System.Drawing.Point(75, 52)
        Me.CboVehiculoS1.Name = "CboVehiculoS1"
        Me.CboVehiculoS1.Size = New System.Drawing.Size(103, 22)
        Me.CboVehiculoS1.TabIndex = 3
        Me.CboVehiculoS1.ValueMember = "Id"
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance224.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance224
        Me.UltraGroupBox3.Controls.Add(Me.Agrupacion7)
        Me.UltraGroupBox3.Controls.Add(Me.Agrupacion8)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(592, 356)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.Text = "MANGUERA 2"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion7
        '
        Appearance225.BackColor = System.Drawing.Color.LightGray
        Me.Agrupacion7.Appearance = Appearance225
        Me.Agrupacion7.Controls.Add(Me.Etiqueta46)
        Me.Agrupacion7.Controls.Add(Me.txtGlosaTanqueo2)
        Me.Agrupacion7.Controls.Add(Me.Panel2)
        Me.Agrupacion7.Controls.Add(Me.TxtCodigoSurtidorS2)
        Me.Agrupacion7.Controls.Add(Me.dtp_FechaTanqueoS2)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta33)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta34)
        Me.Agrupacion7.Controls.Add(Me.nd_CantGalonesS2)
        Me.Agrupacion7.Controls.Add(Me.nd_KmTanqueoS2)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta35)
        Me.Agrupacion7.Controls.Add(Me.Opt_IndTanqueoS2)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta36)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta37)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(3, 99)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(586, 254)
        Me.Agrupacion7.TabIndex = 1
        Me.Agrupacion7.Text = "Datos a Ingresar"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta46
        '
        Appearance226.BackColor = System.Drawing.Color.Transparent
        Appearance226.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance226
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta46.Location = New System.Drawing.Point(32, 129)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(82, 22)
        Me.Etiqueta46.TabIndex = 7
        Me.Etiqueta46.Text = "Glosa(60):"
        '
        'txtGlosaTanqueo2
        '
        Appearance227.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo2.Appearance = Appearance227
        Me.txtGlosaTanqueo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaTanqueo2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaTanqueo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaTanqueo2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosaTanqueo2.ImageTransparentColor = System.Drawing.Color.Empty
        Me.txtGlosaTanqueo2.Location = New System.Drawing.Point(120, 126)
        Me.txtGlosaTanqueo2.MaxLength = 60
        Me.txtGlosaTanqueo2.Multiline = True
        Me.txtGlosaTanqueo2.Name = "txtGlosaTanqueo2"
        Me.txtGlosaTanqueo2.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaTanqueo2.Size = New System.Drawing.Size(236, 64)
        Me.txtGlosaTanqueo2.TabIndex = 8
        Me.txtGlosaTanqueo2.Tag = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Location = New System.Drawing.Point(402, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 168)
        Me.Panel2.TabIndex = 11
        '
        'UltraLabel2
        '
        Appearance228.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance228
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(58, 66)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(61, 68)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "2"
        '
        'TxtCodigoSurtidorS2
        '
        Appearance229.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigoSurtidorS2.Appearance = Appearance229
        Me.TxtCodigoSurtidorS2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigoSurtidorS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtCodigoSurtidorS2.Enabled = False
        Me.TxtCodigoSurtidorS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoSurtidorS2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtCodigoSurtidorS2.Location = New System.Drawing.Point(275, 98)
        Me.TxtCodigoSurtidorS2.MaxLength = 200
        Me.TxtCodigoSurtidorS2.Name = "TxtCodigoSurtidorS2"
        Me.TxtCodigoSurtidorS2.ReadOnly = True
        Me.TxtCodigoSurtidorS2.Size = New System.Drawing.Size(26, 21)
        Me.TxtCodigoSurtidorS2.TabIndex = 6
        Me.TxtCodigoSurtidorS2.Visible = False
        '
        'dtp_FechaTanqueoS2
        '
        Me.dtp_FechaTanqueoS2.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtp_FechaTanqueoS2.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtp_FechaTanqueoS2.CalendarTitleForeColor = System.Drawing.Color.Navy
        Me.dtp_FechaTanqueoS2.CustomFormat = "dd/MM/yyyy h:mm tt"
        Me.dtp_FechaTanqueoS2.Enabled = False
        Me.dtp_FechaTanqueoS2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaTanqueoS2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FechaTanqueoS2.Location = New System.Drawing.Point(120, 20)
        Me.dtp_FechaTanqueoS2.Name = "dtp_FechaTanqueoS2"
        Me.dtp_FechaTanqueoS2.Size = New System.Drawing.Size(236, 27)
        Me.dtp_FechaTanqueoS2.TabIndex = 1
        '
        'Etiqueta33
        '
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta33.Location = New System.Drawing.Point(199, 32)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta33.TabIndex = 319
        '
        'Etiqueta34
        '
        Appearance230.BackColor = System.Drawing.Color.Transparent
        Appearance230.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance230
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(36, 199)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(80, 22)
        Me.Etiqueta34.TabIndex = 9
        Me.Etiqueta34.Text = "Indicador:"
        '
        'nd_CantGalonesS2
        '
        Appearance231.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance231.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalonesS2.Appearance = Appearance231
        Me.nd_CantGalonesS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nd_CantGalonesS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_CantGalonesS2.Enabled = False
        Me.nd_CantGalonesS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_CantGalonesS2.ForeColor = System.Drawing.Color.Black
        Me.nd_CantGalonesS2.Location = New System.Drawing.Point(120, 56)
        Me.nd_CantGalonesS2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        Me.nd_CantGalonesS2.MaskInput = "nnnnn.nnn"
        Me.nd_CantGalonesS2.Name = "nd_CantGalonesS2"
        Me.nd_CantGalonesS2.NullText = "0.00"
        Me.nd_CantGalonesS2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_CantGalonesS2.ReadOnly = True
        Me.nd_CantGalonesS2.Size = New System.Drawing.Size(149, 29)
        Me.nd_CantGalonesS2.TabIndex = 3
        '
        'nd_KmTanqueoS2
        '
        Appearance232.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance232.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueoS2.Appearance = Appearance232
        Me.nd_KmTanqueoS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nd_KmTanqueoS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_KmTanqueoS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_KmTanqueoS2.ForeColor = System.Drawing.Color.Black
        Me.nd_KmTanqueoS2.Location = New System.Drawing.Point(120, 92)
        Me.nd_KmTanqueoS2.MaskInput = "{double:9.2}"
        Me.nd_KmTanqueoS2.Name = "nd_KmTanqueoS2"
        Me.nd_KmTanqueoS2.NullText = "0.00"
        Me.nd_KmTanqueoS2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_KmTanqueoS2.Size = New System.Drawing.Size(149, 28)
        Me.nd_KmTanqueoS2.TabIndex = 5
        '
        'Etiqueta35
        '
        Appearance233.BackColor = System.Drawing.Color.Transparent
        Appearance233.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance233
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(43, 61)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(69, 22)
        Me.Etiqueta35.TabIndex = 2
        Me.Etiqueta35.Text = "Galones:"
        '
        'Opt_IndTanqueoS2
        '
        Appearance234.BackColor = System.Drawing.Color.Transparent
        Appearance234.FontData.SizeInPoints = 13.0!
        Appearance234.ForeColor = System.Drawing.Color.Navy
        Me.Opt_IndTanqueoS2.Appearance = Appearance234
        Me.Opt_IndTanqueoS2.BackColor = System.Drawing.Color.Transparent
        Me.Opt_IndTanqueoS2.BackColorInternal = System.Drawing.Color.Transparent
        Me.Opt_IndTanqueoS2.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.Opt_IndTanqueoS2.CheckedIndex = 0
        Me.Opt_IndTanqueoS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_IndTanqueoS2.ForeColor = System.Drawing.Color.Black
        ValueListItem5.DataValue = True
        ValueListItem5.DisplayText = "Full"
        ValueListItem6.DataValue = False
        ValueListItem6.DisplayText = "Relleno"
        Me.Opt_IndTanqueoS2.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.Opt_IndTanqueoS2.ItemSpacingHorizontal = 30
        Me.Opt_IndTanqueoS2.ItemSpacingVertical = 20
        Me.Opt_IndTanqueoS2.Location = New System.Drawing.Point(120, 189)
        Me.Opt_IndTanqueoS2.Name = "Opt_IndTanqueoS2"
        Me.Opt_IndTanqueoS2.Size = New System.Drawing.Size(198, 27)
        Me.Opt_IndTanqueoS2.TabIndex = 10
        Me.Opt_IndTanqueoS2.Text = "Full"
        '
        'Etiqueta36
        '
        Appearance235.BackColor = System.Drawing.Color.Transparent
        Appearance235.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance235
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(72, 97)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(40, 22)
        Me.Etiqueta36.TabIndex = 4
        Me.Etiqueta36.Text = "Km.:"
        '
        'Etiqueta37
        '
        Appearance236.BackColor = System.Drawing.Color.Transparent
        Appearance236.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta37.Appearance = Appearance236
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta37.Location = New System.Drawing.Point(34, 24)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(80, 22)
        Me.Etiqueta37.TabIndex = 0
        Me.Etiqueta37.Text = "Tanqueo :"
        '
        'Agrupacion8
        '
        Appearance237.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion8.Appearance = Appearance237
        Appearance238.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion8.ContentAreaAppearance = Appearance238
        Me.Agrupacion8.Controls.Add(Me.BtnLimpiaS2)
        Me.Agrupacion8.Controls.Add(Me.dtp_FechaViajeS2)
        Me.Agrupacion8.Controls.Add(Me.BtnGuardarS2)
        Me.Agrupacion8.Controls.Add(Me.Txt_IdPilotoS2)
        Me.Agrupacion8.Controls.Add(Me.TxT_IdViajeS2)
        Me.Agrupacion8.Controls.Add(Me.TxtPilotoS2)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta40)
        Me.Agrupacion8.Controls.Add(Me.nd_OdometroS2)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta41)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta42)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta43)
        Me.Agrupacion8.Controls.Add(Me.TxtViajeS2)
        Me.Agrupacion8.Controls.Add(Me.CboVehiculoS2)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(3, 17)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(586, 82)
        Me.Agrupacion8.TabIndex = 0
        Me.Agrupacion8.Text = "Operacion"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'BtnLimpiaS2
        '
        Appearance239.Image = "16 (Clear).ico"
        Me.BtnLimpiaS2.Appearance = Appearance239
        Me.BtnLimpiaS2.ImageList = Me.imagenes
        Me.BtnLimpiaS2.Location = New System.Drawing.Point(343, 52)
        Me.BtnLimpiaS2.Name = "BtnLimpiaS2"
        Me.BtnLimpiaS2.Size = New System.Drawing.Size(24, 23)
        Me.BtnLimpiaS2.TabIndex = 9
        '
        'dtp_FechaViajeS2
        '
        Appearance240.ForeColor = System.Drawing.Color.Black
        Me.dtp_FechaViajeS2.Appearance = Appearance240
        Me.dtp_FechaViajeS2.DateTime = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FechaViajeS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtp_FechaViajeS2.Enabled = False
        Me.dtp_FechaViajeS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaViajeS2.ForeColor = System.Drawing.Color.Black
        Me.dtp_FechaViajeS2.Location = New System.Drawing.Point(402, 52)
        Me.dtp_FechaViajeS2.MaskInput = "{date} {time}"
        Me.dtp_FechaViajeS2.Name = "dtp_FechaViajeS2"
        Me.dtp_FechaViajeS2.Size = New System.Drawing.Size(40, 21)
        Me.dtp_FechaViajeS2.TabIndex = 10
        Me.dtp_FechaViajeS2.Value = New Date(2014, 9, 29, 0, 0, 0, 0)
        Me.dtp_FechaViajeS2.Visible = False
        '
        'BtnGuardarS2
        '
        Appearance241.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance241.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance241.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.BtnGuardarS2.Appearance = Appearance241
        Me.BtnGuardarS2.ImageList = Me.imagenes
        Me.BtnGuardarS2.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnGuardarS2.Location = New System.Drawing.Point(482, 25)
        Me.BtnGuardarS2.Name = "BtnGuardarS2"
        Me.BtnGuardarS2.Size = New System.Drawing.Size(56, 48)
        Me.BtnGuardarS2.TabIndex = 12
        '
        'Txt_IdPilotoS2
        '
        Appearance242.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Txt_IdPilotoS2.Appearance = Appearance242
        Me.Txt_IdPilotoS2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_IdPilotoS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Txt_IdPilotoS2.Enabled = False
        Me.Txt_IdPilotoS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IdPilotoS2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Txt_IdPilotoS2.Location = New System.Drawing.Point(464, 52)
        Me.Txt_IdPilotoS2.MaxLength = 200
        Me.Txt_IdPilotoS2.Name = "Txt_IdPilotoS2"
        Me.Txt_IdPilotoS2.ReadOnly = True
        Me.Txt_IdPilotoS2.Size = New System.Drawing.Size(12, 21)
        Me.Txt_IdPilotoS2.TabIndex = 11
        Me.Txt_IdPilotoS2.Visible = False
        '
        'TxT_IdViajeS2
        '
        Appearance243.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxT_IdViajeS2.Appearance = Appearance243
        Me.TxT_IdViajeS2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxT_IdViajeS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxT_IdViajeS2.Enabled = False
        Me.TxT_IdViajeS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT_IdViajeS2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxT_IdViajeS2.Location = New System.Drawing.Point(448, 52)
        Me.TxT_IdViajeS2.MaxLength = 200
        Me.TxT_IdViajeS2.Name = "TxT_IdViajeS2"
        Me.TxT_IdViajeS2.ReadOnly = True
        Me.TxT_IdViajeS2.Size = New System.Drawing.Size(10, 21)
        Me.TxT_IdViajeS2.TabIndex = 321
        Me.TxT_IdViajeS2.Visible = False
        '
        'TxtPilotoS2
        '
        Appearance244.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPilotoS2.Appearance = Appearance244
        Me.TxtPilotoS2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPilotoS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtPilotoS2.Enabled = False
        Me.TxtPilotoS2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPilotoS2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtPilotoS2.Location = New System.Drawing.Point(248, 25)
        Me.TxtPilotoS2.MaxLength = 200
        Me.TxtPilotoS2.Name = "TxtPilotoS2"
        Me.TxtPilotoS2.ReadOnly = True
        Me.TxtPilotoS2.Size = New System.Drawing.Size(228, 22)
        Me.TxtPilotoS2.TabIndex = 4
        '
        'Etiqueta40
        '
        Appearance245.BackColor = System.Drawing.Color.Transparent
        Appearance245.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance245
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta40.Location = New System.Drawing.Point(206, 31)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta40.TabIndex = 2
        Me.Etiqueta40.Text = "Piloto:"
        '
        'nd_OdometroS2
        '
        Appearance246.ForeColor = System.Drawing.Color.Black
        Me.nd_OdometroS2.Appearance = Appearance246
        Me.nd_OdometroS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_OdometroS2.Enabled = False
        Me.nd_OdometroS2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_OdometroS2.ForeColor = System.Drawing.Color.Black
        Me.nd_OdometroS2.Location = New System.Drawing.Point(248, 52)
        Me.nd_OdometroS2.Name = "nd_OdometroS2"
        Me.nd_OdometroS2.NullText = "0.00"
        Me.nd_OdometroS2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_OdometroS2.ReadOnly = True
        Me.nd_OdometroS2.Size = New System.Drawing.Size(89, 22)
        Me.nd_OdometroS2.TabIndex = 8
        '
        'Etiqueta41
        '
        Appearance247.BackColor = System.Drawing.Color.Transparent
        Appearance247.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance247
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta41.Location = New System.Drawing.Point(186, 56)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta41.TabIndex = 7
        Me.Etiqueta41.Text = "Odometro:"
        '
        'Etiqueta42
        '
        Appearance248.BackColor = System.Drawing.Color.Transparent
        Appearance248.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance248
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta42.Location = New System.Drawing.Point(36, 29)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta42.TabIndex = 0
        Me.Etiqueta42.Text = "Viaje:"
        '
        'Etiqueta43
        '
        Appearance249.BackColor = System.Drawing.Color.Transparent
        Appearance249.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance249
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta43.Location = New System.Drawing.Point(19, 56)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta43.TabIndex = 5
        Me.Etiqueta43.Text = "Vehiculo:"
        '
        'TxtViajeS2
        '
        Appearance250.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtViajeS2.Appearance = Appearance250
        Me.TxtViajeS2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtViajeS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtViajeS2.Enabled = False
        Me.TxtViajeS2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtViajeS2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TxtViajeS2.Location = New System.Drawing.Point(75, 25)
        Me.TxtViajeS2.MaxLength = 200
        Me.TxtViajeS2.Name = "TxtViajeS2"
        Me.TxtViajeS2.ReadOnly = True
        Me.TxtViajeS2.Size = New System.Drawing.Size(103, 22)
        Me.TxtViajeS2.TabIndex = 1
        '
        'CboVehiculoS2
        '
        Appearance251.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance251.ForeColor = System.Drawing.Color.Black
        Me.CboVehiculoS2.Appearance = Appearance251
        Me.CboVehiculoS2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CboVehiculoS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboVehiculoS2.DisplayMember = "Nombre"
        Me.CboVehiculoS2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboVehiculoS2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboVehiculoS2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVehiculoS2.ForeColor = System.Drawing.Color.Black
        Me.CboVehiculoS2.Location = New System.Drawing.Point(75, 52)
        Me.CboVehiculoS2.Name = "CboVehiculoS2"
        Me.CboVehiculoS2.Size = New System.Drawing.Size(103, 22)
        Me.CboVehiculoS2.TabIndex = 6
        Me.CboVehiculoS2.ValueMember = "Id"
        '
        'Agrupacion1
        '
        Appearance252.BackColor = System.Drawing.Color.Transparent
        Appearance252.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Appearance = Appearance252
        Appearance253.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion1.ContentAreaAppearance = Appearance253
        Me.Agrupacion1.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion1.Controls.Add(Me.decSotckS)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion1.Controls.Add(Me.nd_PrecioUnitarioS)
        Me.Agrupacion1.Controls.Add(Me.CboDireccionS)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion1.Controls.Add(Me.CboLugarS)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion1.Controls.Add(Me.CboGrifoS)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1193, 55)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos Grifo"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta13
        '
        Appearance254.BackColor = System.Drawing.Color.Transparent
        Appearance254.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance254
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(1055, 27)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(24, 14)
        Me.Etiqueta13.TabIndex = 8
        Me.Etiqueta13.Text = "Gls."
        '
        'Etiqueta14
        '
        Appearance255.BackColor = System.Drawing.Color.Transparent
        Appearance255.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance255
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(947, 27)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta14.TabIndex = 6
        Me.Etiqueta14.Text = "Stock:"
        '
        'decSotckS
        '
        Appearance256.ForeColor = System.Drawing.Color.Black
        Me.decSotckS.Appearance = Appearance256
        Me.decSotckS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSotckS.Enabled = False
        Me.decSotckS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSotckS.ForeColor = System.Drawing.Color.Black
        Me.decSotckS.Location = New System.Drawing.Point(988, 23)
        Me.decSotckS.MaskInput = "{double:5.3}"
        Me.decSotckS.Name = "decSotckS"
        Me.decSotckS.NullText = "0.00"
        Me.decSotckS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSotckS.Size = New System.Drawing.Size(61, 22)
        Me.decSotckS.TabIndex = 7
        '
        'Etiqueta18
        '
        Appearance257.BackColor = System.Drawing.Color.Transparent
        Appearance257.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance257
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(604, 27)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta18.TabIndex = 4
        Me.Etiqueta18.Text = "EE.SS./Dir.:"
        '
        'nd_PrecioUnitarioS
        '
        Appearance258.ForeColor = System.Drawing.Color.Black
        Me.nd_PrecioUnitarioS.Appearance = Appearance258
        Me.nd_PrecioUnitarioS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_PrecioUnitarioS.Enabled = False
        Me.nd_PrecioUnitarioS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_PrecioUnitarioS.ForeColor = System.Drawing.Color.Black
        Me.nd_PrecioUnitarioS.Location = New System.Drawing.Point(1125, 23)
        Me.nd_PrecioUnitarioS.MaskInput = "{double:2.3}"
        Me.nd_PrecioUnitarioS.Name = "nd_PrecioUnitarioS"
        Me.nd_PrecioUnitarioS.NullText = "0.00"
        Me.nd_PrecioUnitarioS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_PrecioUnitarioS.ReadOnly = True
        Me.nd_PrecioUnitarioS.Size = New System.Drawing.Size(53, 22)
        Me.nd_PrecioUnitarioS.TabIndex = 10
        '
        'CboDireccionS
        '
        Appearance259.ForeColor = System.Drawing.Color.Black
        Me.CboDireccionS.Appearance = Appearance259
        Me.CboDireccionS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.CboDireccionS.DisplayMember = "Nombre"
        Me.CboDireccionS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboDireccionS.Enabled = False
        Me.CboDireccionS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDireccionS.ForeColor = System.Drawing.Color.Black
        ValueListItem7.DataValue = "1SI0000472"
        ValueListItem7.DisplayText = "GRIFO PYO 2016-03: CAR. PANAMERICANA NORTE KM. 664"
        Me.CboDireccionS.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7})
        Me.CboDireccionS.Location = New System.Drawing.Point(672, 23)
        Me.CboDireccionS.Name = "CboDireccionS"
        Me.CboDireccionS.Size = New System.Drawing.Size(269, 22)
        Me.CboDireccionS.TabIndex = 5
        Me.CboDireccionS.ValueMember = "Id"
        '
        'Etiqueta19
        '
        Appearance260.BackColor = System.Drawing.Color.Transparent
        Appearance260.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance260
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(301, 27)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta19.TabIndex = 2
        Me.Etiqueta19.Text = "Lugar:"
        '
        'CboLugarS
        '
        Appearance261.ForeColor = System.Drawing.Color.Black
        Me.CboLugarS.Appearance = Appearance261
        Me.CboLugarS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.CboLugarS.DisplayMember = "Nombre"
        Me.CboLugarS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboLugarS.Enabled = False
        Me.CboLugarS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLugarS.ForeColor = System.Drawing.Color.Black
        ValueListItem8.DataValue = "1CH0001173"
        ValueListItem8.DisplayText = "PACASMAYO"
        Me.CboLugarS.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem8})
        Me.CboLugarS.Location = New System.Drawing.Point(343, 23)
        Me.CboLugarS.Name = "CboLugarS"
        Me.CboLugarS.Size = New System.Drawing.Size(255, 22)
        Me.CboLugarS.TabIndex = 3
        Me.CboLugarS.ValueMember = "Id"
        '
        'Etiqueta21
        '
        Appearance262.BackColor = System.Drawing.Color.Transparent
        Appearance262.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance262
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(14, 27)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta21.TabIndex = 0
        Me.Etiqueta21.Text = "Grifo:"
        '
        'CboGrifoS
        '
        Appearance263.ForeColor = System.Drawing.Color.Black
        Me.CboGrifoS.Appearance = Appearance263
        Me.CboGrifoS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.CboGrifoS.DisplayMember = "Nombre"
        Me.CboGrifoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboGrifoS.Enabled = False
        Me.CboGrifoS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGrifoS.ForeColor = System.Drawing.Color.Black
        ValueListItem9.DataValue = "1CH000006026"
        ValueListItem9.DisplayText = "INDUAMÉRICA SERVICIOS LOGÍSTICOS SAC"
        Me.CboGrifoS.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem9})
        Me.CboGrifoS.Location = New System.Drawing.Point(52, 23)
        Me.CboGrifoS.Name = "CboGrifoS"
        Me.CboGrifoS.Size = New System.Drawing.Size(243, 22)
        Me.CboGrifoS.TabIndex = 1
        Me.CboGrifoS.ValueMember = "Id"
        '
        'Etiqueta27
        '
        Appearance264.BackColor = System.Drawing.Color.Transparent
        Appearance264.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance264
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(1080, 27)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta27.TabIndex = 9
        Me.Etiqueta27.Text = "C. Un.:"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1193, 411)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraCheckEditor2)
        Me.UltraGroupBox5.Controls.Add(Me.griTanqueosPecsa)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1193, 371)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.Text = "Tanqueos PECSA"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraCheckEditor2
        '
        Me.UltraCheckEditor2.Location = New System.Drawing.Point(48, 19)
        Me.UltraCheckEditor2.Name = "UltraCheckEditor2"
        Me.UltraCheckEditor2.Size = New System.Drawing.Size(14, 14)
        Me.UltraCheckEditor2.TabIndex = 1
        '
        'griTanqueosPecsa
        '
        Me.griTanqueosPecsa.DataSource = Me.odTanqueosNoAsociados
        UltraGridColumn497.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn497.Header.Caption = ""
        UltraGridColumn497.Header.VisiblePosition = 0
        UltraGridColumn497.Width = 35
        UltraGridColumn498.Header.VisiblePosition = 1
        UltraGridColumn498.Hidden = True
        UltraGridColumn499.Header.VisiblePosition = 2
        UltraGridColumn499.Hidden = True
        UltraGridColumn500.Header.VisiblePosition = 4
        UltraGridColumn500.Hidden = True
        UltraGridColumn501.Header.VisiblePosition = 5
        UltraGridColumn501.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn501.Width = 124
        Appearance265.TextHAlignAsString = "Right"
        UltraGridColumn502.CellAppearance = Appearance265
        UltraGridColumn502.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn502.Header.Caption = "KM Tanqueo"
        UltraGridColumn502.Header.VisiblePosition = 7
        UltraGridColumn502.MaskInput = "{double:9.4}"
        UltraGridColumn503.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance266.TextHAlignAsString = "Right"
        UltraGridColumn503.CellAppearance = Appearance266
        UltraGridColumn503.Header.Caption = "Can(Gls)"
        UltraGridColumn503.Header.VisiblePosition = 8
        UltraGridColumn503.MaskInput = "{double:9.4}"
        UltraGridColumn503.Width = 87
        Appearance267.TextHAlignAsString = "Center"
        UltraGridColumn504.CellAppearance = Appearance267
        Appearance268.TextHAlignAsString = "Center"
        UltraGridColumn504.Header.Appearance = Appearance268
        UltraGridColumn504.Header.VisiblePosition = 11
        UltraGridColumn504.Width = 91
        Appearance269.TextHAlignAsString = "Right"
        UltraGridColumn505.CellAppearance = Appearance269
        Appearance270.TextHAlignAsString = "Right"
        UltraGridColumn505.Header.Appearance = Appearance270
        UltraGridColumn505.Header.Caption = "P. Unit."
        UltraGridColumn505.Header.VisiblePosition = 13
        UltraGridColumn505.MaskInput = "{double:9.4}"
        UltraGridColumn506.Header.VisiblePosition = 15
        UltraGridColumn506.Hidden = True
        UltraGridColumn507.Header.VisiblePosition = 16
        UltraGridColumn507.Hidden = True
        UltraGridColumn508.Header.VisiblePosition = 18
        UltraGridColumn508.Hidden = True
        UltraGridColumn509.Header.VisiblePosition = 19
        UltraGridColumn509.Hidden = True
        UltraGridColumn510.Header.Caption = "Full/Rell"
        UltraGridColumn510.Header.VisiblePosition = 9
        UltraGridColumn511.Header.VisiblePosition = 34
        UltraGridColumn511.Hidden = True
        UltraGridColumn512.Header.VisiblePosition = 33
        UltraGridColumn512.Hidden = True
        UltraGridColumn513.Header.VisiblePosition = 20
        UltraGridColumn513.Hidden = True
        UltraGridColumn514.Header.VisiblePosition = 21
        UltraGridColumn514.Hidden = True
        UltraGridColumn515.Header.VisiblePosition = 22
        UltraGridColumn515.Hidden = True
        UltraGridColumn516.Header.VisiblePosition = 14
        UltraGridColumn516.Hidden = True
        UltraGridColumn516.Width = 95
        UltraGridColumn517.Header.VisiblePosition = 3
        UltraGridColumn517.Hidden = True
        UltraGridColumn518.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn518.Header.VisiblePosition = 10
        UltraGridColumn518.Hidden = True
        UltraGridColumn519.Header.VisiblePosition = 17
        UltraGridColumn519.Hidden = True
        UltraGridColumn520.Header.VisiblePosition = 25
        UltraGridColumn520.Hidden = True
        UltraGridColumn521.Header.VisiblePosition = 27
        UltraGridColumn521.Hidden = True
        UltraGridColumn522.Header.VisiblePosition = 23
        UltraGridColumn522.Hidden = True
        UltraGridColumn523.Header.Caption = "Tracto"
        UltraGridColumn523.Header.VisiblePosition = 6
        UltraGridColumn523.Width = 72
        UltraGridColumn524.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Appearance271.TextHAlignAsString = "Left"
        Appearance271.TextVAlignAsString = "Middle"
        UltraGridColumn524.CellAppearance = Appearance271
        UltraGridColumn524.Header.VisiblePosition = 12
        UltraGridColumn524.Hidden = True
        UltraGridColumn524.Width = 224
        UltraGridColumn525.Header.VisiblePosition = 24
        UltraGridColumn525.Hidden = True
        UltraGridColumn526.Header.VisiblePosition = 26
        UltraGridColumn526.Hidden = True
        UltraGridColumn527.Header.VisiblePosition = 29
        UltraGridColumn527.Hidden = True
        UltraGridColumn528.Header.VisiblePosition = 28
        UltraGridColumn528.Hidden = True
        UltraGridColumn529.Header.VisiblePosition = 30
        UltraGridColumn529.Hidden = True
        UltraGridColumn530.Header.Caption = "Direccion"
        UltraGridColumn530.Header.VisiblePosition = 32
        UltraGridColumn530.Width = 425
        UltraGridColumn531.Header.Caption = "Estacion"
        UltraGridColumn531.Header.VisiblePosition = 31
        UltraGridColumn531.Width = 167
        UltraGridColumn532.Header.VisiblePosition = 35
        UltraGridColumn532.Hidden = True
        UltraGridColumn533.Header.VisiblePosition = 36
        UltraGridColumn533.Hidden = True
        UltraGridColumn534.Header.VisiblePosition = 37
        UltraGridColumn534.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn511, UltraGridColumn512, UltraGridColumn513, UltraGridColumn514, UltraGridColumn515, UltraGridColumn516, UltraGridColumn517, UltraGridColumn518, UltraGridColumn519, UltraGridColumn520, UltraGridColumn521, UltraGridColumn522, UltraGridColumn523, UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528, UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534})
        UltraGridBand6.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand6.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand6.SummaryFooterCaption = "Totales"
        Me.griTanqueosPecsa.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griTanqueosPecsa.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griTanqueosPecsa.DisplayLayout.MaxColScrollRegions = 1
        Me.griTanqueosPecsa.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griTanqueosPecsa.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTanqueosPecsa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTanqueosPecsa.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTanqueosPecsa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTanqueosPecsa.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTanqueosPecsa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTanqueosPecsa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTanqueosPecsa.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        Me.griTanqueosPecsa.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTanqueosPecsa.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTanqueosPecsa.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griTanqueosPecsa.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griTanqueosPecsa.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTanqueosPecsa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTanqueosPecsa.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTanqueosPecsa.Location = New System.Drawing.Point(3, 17)
        Me.griTanqueosPecsa.Name = "griTanqueosPecsa"
        Me.griTanqueosPecsa.Size = New System.Drawing.Size(1187, 351)
        Me.griTanqueosPecsa.TabIndex = 0
        Me.griTanqueosPecsa.TabStop = False
        Me.griTanqueosPecsa.Tag = ""
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta39)
        Me.UltraGroupBox4.Controls.Add(Me.ColorKm)
        Me.UltraGroupBox4.Controls.Add(Me.btnEliminar)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta44)
        Me.UltraGroupBox4.Controls.Add(Me.ColorSPlaca)
        Me.UltraGroupBox4.Controls.Add(Me.btnLimpiar)
        Me.UltraGroupBox4.Controls.Add(Me.btnGuardarPecsa)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta38)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox4.Controls.Add(Me.fecInicioTanqueo)
        Me.UltraGroupBox4.Controls.Add(Me.fecFinTanqueo)
        Me.UltraGroupBox4.Controls.Add(Me.ColoresDup)
        Me.UltraGroupBox4.Controls.Add(Me.etiGenerada)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1193, 40)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta39
        '
        Appearance272.BackColor = System.Drawing.Color.Transparent
        Appearance272.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta39.Appearance = Appearance272
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(826, 12)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta39.TabIndex = 11
        Me.Etiqueta39.Text = "KM 0"
        '
        'ColorKm
        '
        Me.ColorKm.Location = New System.Drawing.Point(860, 8)
        Me.ColorKm.Name = "ColorKm"
        Me.ColorKm.Size = New System.Drawing.Size(46, 22)
        Me.ColorKm.TabIndex = 12
        Me.ColorKm.Text = "Control"
        '
        'btnEliminar
        '
        Appearance273.BackColor = System.Drawing.Color.Transparent
        Appearance273.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance273.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminar.Appearance = Appearance273
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(514, 7)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 24)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Etiqueta44
        '
        Appearance274.BackColor = System.Drawing.Color.Transparent
        Appearance274.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta44.Appearance = Appearance274
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(710, 12)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta44.TabIndex = 9
        Me.Etiqueta44.Text = "Duplicados"
        '
        'ColorSPlaca
        '
        Me.ColorSPlaca.Location = New System.Drawing.Point(648, 8)
        Me.ColorSPlaca.Name = "ColorSPlaca"
        Me.ColorSPlaca.Size = New System.Drawing.Size(46, 22)
        Me.ColorSPlaca.TabIndex = 8
        Me.ColorSPlaca.Text = "Control"
        '
        'btnLimpiar
        '
        Appearance275.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance275.Image = Global.ISL.Win.My.Resources.Resources.content_reorder
        Me.btnLimpiar.Appearance = Appearance275
        Me.btnLimpiar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(346, 7)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 24)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnGuardarPecsa
        '
        Appearance276.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance276.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardarPecsa.Appearance = Appearance276
        Me.btnGuardarPecsa.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardarPecsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarPecsa.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPecsa.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarPecsa.Location = New System.Drawing.Point(430, 7)
        Me.btnGuardarPecsa.Name = "btnGuardarPecsa"
        Me.btnGuardarPecsa.Size = New System.Drawing.Size(78, 24)
        Me.btnGuardarPecsa.TabIndex = 5
        Me.btnGuardarPecsa.Text = "Guardar"
        Me.btnGuardarPecsa.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Etiqueta38
        '
        Appearance277.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta38.Appearance = Appearance277
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta38.Location = New System.Drawing.Point(184, 12)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta38.TabIndex = 2
        Me.Etiqueta38.Text = "Hasta:"
        '
        'Etiqueta28
        '
        Appearance278.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta28.Appearance = Appearance278
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.Location = New System.Drawing.Point(11, 12)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta28.TabIndex = 0
        Me.Etiqueta28.Text = "Desde:"
        '
        'fecInicioTanqueo
        '
        Me.fecInicioTanqueo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicioTanqueo.Location = New System.Drawing.Point(56, 10)
        Me.fecInicioTanqueo.Name = "fecInicioTanqueo"
        Me.fecInicioTanqueo.Size = New System.Drawing.Size(108, 21)
        Me.fecInicioTanqueo.TabIndex = 1
        '
        'fecFinTanqueo
        '
        Me.fecFinTanqueo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFinTanqueo.Location = New System.Drawing.Point(227, 10)
        Me.fecFinTanqueo.Name = "fecFinTanqueo"
        Me.fecFinTanqueo.Size = New System.Drawing.Size(108, 21)
        Me.fecFinTanqueo.TabIndex = 3
        '
        'ColoresDup
        '
        Me.ColoresDup.Location = New System.Drawing.Point(772, 8)
        Me.ColoresDup.Name = "ColoresDup"
        Me.ColoresDup.Size = New System.Drawing.Size(46, 22)
        Me.ColoresDup.TabIndex = 10
        Me.ColoresDup.Text = "Control"
        '
        'etiGenerada
        '
        Appearance279.BackColor = System.Drawing.Color.Transparent
        Appearance279.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance279
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(598, 12)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(44, 15)
        Me.etiGenerada.TabIndex = 7
        Me.etiGenerada.Text = "SinPlaca"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Grid_Vehiculos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(355, 156)
        '
        'Grid_Vehiculos
        '
        Me.Grid_Vehiculos.DataSource = Me.odCombo
        Appearance280.TextHAlignAsString = "Left"
        Appearance280.TextVAlignAsString = "Middle"
        UltraGridColumn535.CellAppearance = Appearance280
        UltraGridColumn535.Header.VisiblePosition = 0
        UltraGridColumn535.Hidden = True
        Appearance281.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance281.TextHAlignAsString = "Left"
        Appearance281.TextVAlignAsString = "Middle"
        UltraGridColumn536.CellAppearance = Appearance281
        Appearance282.TextHAlignAsString = "Center"
        UltraGridColumn536.Header.Appearance = Appearance282
        UltraGridColumn536.Header.Caption = "Placa"
        UltraGridColumn536.Header.VisiblePosition = 3
        UltraGridColumn536.MaxWidth = 300
        UltraGridColumn536.Width = 232
        Appearance283.TextHAlignAsString = "Left"
        Appearance283.TextVAlignAsString = "Middle"
        UltraGridColumn537.CellAppearance = Appearance283
        UltraGridColumn537.Header.VisiblePosition = 2
        UltraGridColumn537.Hidden = True
        UltraGridColumn537.Width = 195
        Appearance284.TextHAlignAsString = "Center"
        Appearance284.TextVAlignAsString = "Middle"
        UltraGridColumn547.CellAppearance = Appearance284
        UltraGridColumn547.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn547.DataType = GetType(Boolean)
        UltraGridColumn547.DefaultCellValue = False
        Appearance285.TextHAlignAsString = "Center"
        UltraGridColumn547.Header.Appearance = Appearance285
        UltraGridColumn547.Header.Caption = "Sel."
        UltraGridColumn547.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn547.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn547.Header.VisiblePosition = 1
        UltraGridColumn547.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn547.Width = 52
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn547})
        Me.Grid_Vehiculos.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.Grid_Vehiculos.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Vehiculos.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Vehiculos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Vehiculos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Vehiculos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Vehiculos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Vehiculos.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Vehiculos.Name = "Grid_Vehiculos"
        Me.Grid_Vehiculos.Size = New System.Drawing.Size(355, 156)
        Me.Grid_Vehiculos.TabIndex = 0
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Grid_Pilotos)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(355, 156)
        '
        'Grid_Pilotos
        '
        Me.Grid_Pilotos.DataSource = Me.odCombo
        Appearance286.TextHAlignAsString = "Left"
        Appearance286.TextVAlignAsString = "Middle"
        UltraGridColumn539.CellAppearance = Appearance286
        UltraGridColumn539.Header.VisiblePosition = 0
        UltraGridColumn539.Hidden = True
        Appearance287.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance287.TextHAlignAsString = "Left"
        Appearance287.TextVAlignAsString = "Middle"
        UltraGridColumn540.CellAppearance = Appearance287
        Appearance288.TextHAlignAsString = "Center"
        UltraGridColumn540.Header.Appearance = Appearance288
        UltraGridColumn540.Header.Caption = "Piloto/Copiloto"
        UltraGridColumn540.Header.VisiblePosition = 3
        UltraGridColumn540.MaxWidth = 300
        UltraGridColumn540.Width = 232
        Appearance289.TextHAlignAsString = "Left"
        Appearance289.TextVAlignAsString = "Middle"
        UltraGridColumn541.CellAppearance = Appearance289
        UltraGridColumn541.Header.VisiblePosition = 2
        UltraGridColumn541.Hidden = True
        UltraGridColumn541.Width = 195
        Appearance290.TextHAlignAsString = "Center"
        Appearance290.TextVAlignAsString = "Middle"
        UltraGridColumn548.CellAppearance = Appearance290
        UltraGridColumn548.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn548.DataType = GetType(Boolean)
        UltraGridColumn548.DefaultCellValue = False
        Appearance291.TextHAlignAsString = "Center"
        UltraGridColumn548.Header.Appearance = Appearance291
        UltraGridColumn548.Header.Caption = "Sel."
        UltraGridColumn548.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn548.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn548.Header.VisiblePosition = 1
        UltraGridColumn548.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn548.Width = 52
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn539, UltraGridColumn540, UltraGridColumn541, UltraGridColumn548})
        Me.Grid_Pilotos.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.Grid_Pilotos.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Pilotos.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Pilotos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Pilotos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Pilotos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Pilotos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Pilotos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Pilotos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Pilotos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Pilotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Pilotos.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Pilotos.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Pilotos.Name = "Grid_Pilotos"
        Me.Grid_Pilotos.Size = New System.Drawing.Size(355, 156)
        Me.Grid_Pilotos.TabIndex = 0
        '
        'utpMarcaModelo
        '
        Me.utpMarcaModelo.Controls.Add(Me.Grid_TipoeVeh)
        Me.utpMarcaModelo.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpMarcaModelo.Name = "utpMarcaModelo"
        Me.utpMarcaModelo.Size = New System.Drawing.Size(355, 156)
        '
        'Grid_TipoeVeh
        '
        Me.Grid_TipoeVeh.DataSource = Me.odCombo
        Appearance292.TextHAlignAsString = "Left"
        Appearance292.TextVAlignAsString = "Middle"
        UltraGridColumn543.CellAppearance = Appearance292
        UltraGridColumn543.Header.VisiblePosition = 0
        UltraGridColumn543.Hidden = True
        Appearance293.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance293.TextHAlignAsString = "Left"
        Appearance293.TextVAlignAsString = "Middle"
        UltraGridColumn544.CellAppearance = Appearance293
        Appearance294.TextHAlignAsString = "Center"
        UltraGridColumn544.Header.Appearance = Appearance294
        UltraGridColumn544.Header.Caption = "Tipo Vehículo"
        UltraGridColumn544.Header.VisiblePosition = 3
        UltraGridColumn544.MaxWidth = 300
        UltraGridColumn544.Width = 232
        Appearance295.TextHAlignAsString = "Left"
        Appearance295.TextVAlignAsString = "Middle"
        UltraGridColumn545.CellAppearance = Appearance295
        UltraGridColumn545.Header.VisiblePosition = 2
        UltraGridColumn545.Hidden = True
        UltraGridColumn545.Width = 195
        Appearance296.TextHAlignAsString = "Center"
        Appearance296.TextVAlignAsString = "Middle"
        UltraGridColumn549.CellAppearance = Appearance296
        UltraGridColumn549.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn549.DataType = GetType(Boolean)
        UltraGridColumn549.DefaultCellValue = False
        Appearance297.TextHAlignAsString = "Center"
        UltraGridColumn549.Header.Appearance = Appearance297
        UltraGridColumn549.Header.Caption = "Sel."
        UltraGridColumn549.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn549.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn549.Header.VisiblePosition = 1
        UltraGridColumn549.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn549.Width = 52
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn543, UltraGridColumn544, UltraGridColumn545, UltraGridColumn549})
        Me.Grid_TipoeVeh.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.Grid_TipoeVeh.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_TipoeVeh.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_TipoeVeh.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_TipoeVeh.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_TipoeVeh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_TipoeVeh.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_TipoeVeh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_TipoeVeh.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_TipoeVeh.Location = New System.Drawing.Point(0, 0)
        Me.Grid_TipoeVeh.Name = "Grid_TipoeVeh"
        Me.Grid_TipoeVeh.Size = New System.Drawing.Size(355, 156)
        Me.Grid_TipoeVeh.TabIndex = 0
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Grid_Zona)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(355, 156)
        '
        'Grid_Zona
        '
        Me.Grid_Zona.DataSource = Me.odCombo
        Appearance298.TextHAlignAsString = "Left"
        Appearance298.TextVAlignAsString = "Middle"
        UltraGridColumn29.CellAppearance = Appearance298
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        Appearance299.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance299.TextHAlignAsString = "Left"
        Appearance299.TextVAlignAsString = "Middle"
        UltraGridColumn30.CellAppearance = Appearance299
        Appearance300.TextHAlignAsString = "Center"
        UltraGridColumn30.Header.Appearance = Appearance300
        UltraGridColumn30.Header.Caption = "Flota"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.MaxWidth = 300
        UltraGridColumn30.Width = 232
        Appearance301.TextHAlignAsString = "Left"
        Appearance301.TextVAlignAsString = "Middle"
        UltraGridColumn31.CellAppearance = Appearance301
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.Width = 195
        Appearance302.TextHAlignAsString = "Center"
        Appearance302.TextVAlignAsString = "Middle"
        UltraGridColumn550.CellAppearance = Appearance302
        UltraGridColumn550.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn550.DataType = GetType(Boolean)
        UltraGridColumn550.DefaultCellValue = False
        Appearance303.TextHAlignAsString = "Center"
        UltraGridColumn550.Header.Appearance = Appearance303
        UltraGridColumn550.Header.Caption = "Sel."
        UltraGridColumn550.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn550.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn550.Header.VisiblePosition = 1
        UltraGridColumn550.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn550.Width = 52
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn550})
        Me.Grid_Zona.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.Grid_Zona.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Zona.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Zona.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Zona.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Zona.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Zona.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Zona.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Zona.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Zona.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Zona.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Zona.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Zona.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Zona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Zona.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Zona.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Zona.Name = "Grid_Zona"
        Me.Grid_Zona.Size = New System.Drawing.Size(355, 156)
        Me.Grid_Zona.TabIndex = 0
        '
        'MenuEnvioSurtidor
        '
        Me.MenuEnvioSurtidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEnvioSurtidor.ForeColor = System.Drawing.Color.Black
        Me.MenuEnvioSurtidor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EnviarASurtidor2ToolStripMenuItem})
        Me.MenuEnvioSurtidor.Name = "MenuContextual1"
        Me.MenuEnvioSurtidor.Size = New System.Drawing.Size(162, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Surtidor1
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem1.Text = "Enviar a Surtidor 1"
        '
        'EnviarASurtidor2ToolStripMenuItem
        '
        Me.EnviarASurtidor2ToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Surtidor1
        Me.EnviarASurtidor2ToolStripMenuItem.Name = "EnviarASurtidor2ToolStripMenuItem"
        Me.EnviarASurtidor2ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EnviarASurtidor2ToolStripMenuItem.Text = "Enviar a Surtidor 2"
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.RangoFechas1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Ficha2)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1140, 183)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'RangoFechas1
        '
        Me.RangoFechas1.Controls.Add(Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf)
        Me.RangoFechas1.Controls.Add(Me.object_42630089_f836_4a75_a642_b22c3a63ea5d)
        Me.RangoFechas1.Controls.Add(Me.FechaHasta)
        Me.RangoFechas1.Controls.Add(Me.FechaDesde)
        Me.RangoFechas1.Desde = New Date(2012, 2, 5, 0, 0, 0, 0)
        Me.RangoFechas1.Hasta = New Date(2012, 2, 5, 0, 0, 0, 0)
        Me.RangoFechas1.Location = New System.Drawing.Point(10, 9)
        Me.RangoFechas1.Name = "RangoFechas1"
        Me.RangoFechas1.Size = New System.Drawing.Size(297, 23)
        Me.RangoFechas1.TabIndex = 54
        '
        'object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf
        '
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.AutoSize = True
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.ForeColor = System.Drawing.Color.Navy
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.Location = New System.Drawing.Point(161, 7)
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.Name = "object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf"
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.Size = New System.Drawing.Size(33, 14)
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.TabIndex = 3
        Me.object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf.Text = "Hasta"
        '
        'object_42630089_f836_4a75_a642_b22c3a63ea5d
        '
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.AutoSize = True
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.ForeColor = System.Drawing.Color.Navy
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.Location = New System.Drawing.Point(5, 6)
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.Name = "object_42630089_f836_4a75_a642_b22c3a63ea5d"
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.Size = New System.Drawing.Size(36, 14)
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.TabIndex = 2
        Me.object_42630089_f836_4a75_a642_b22c3a63ea5d.Text = "Desde"
        '
        'FechaHasta
        '
        Appearance304.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaHasta.Appearance = Appearance304
        Me.FechaHasta.DateTime = New Date(2012, 2, 5, 0, 0, 0, 0)
        Me.FechaHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaHasta.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaHasta.Location = New System.Drawing.Point(197, 0)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(84, 23)
        Me.FechaHasta.TabIndex = 1
        Me.FechaHasta.Value = New Date(2012, 2, 5, 0, 0, 0, 0)
        '
        'FechaDesde
        '
        Appearance305.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaDesde.Appearance = Appearance305
        Me.FechaDesde.DateTime = New Date(2012, 2, 5, 0, 0, 0, 0)
        Me.FechaDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDesde.ForeColor = System.Drawing.Color.SteelBlue
        Me.FechaDesde.Location = New System.Drawing.Point(51, 0)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(88, 23)
        Me.FechaDesde.TabIndex = 0
        Me.FechaDesde.Value = New Date(2012, 2, 5, 0, 0, 0, 0)
        '
        'Ficha2
        '
        Me.Ficha2.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl5)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl6)
        Me.Ficha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha2.Location = New System.Drawing.Point(10, 38)
        Me.Ficha2.Name = "Ficha2"
        Me.Ficha2.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.Ficha2.Size = New System.Drawing.Size(403, 139)
        Me.Ficha2.TabIndex = 12
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Tractos"
        UltraTab4.TabPage = Me.UltraTabPageControl6
        UltraTab4.Text = ".."
        Me.Ficha2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.Ficha2.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(401, 116)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TiempoManguera
        '
        Me.TiempoManguera.Interval = 10000
        '
        'TiempoSurtidor
        '
        Me.TiempoSurtidor.Interval = 10000
        '
        'ficConCombustible
        '
        Me.ficConCombustible.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl1)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl2)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl7)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl9)
        Me.ficConCombustible.Controls.Add(Me.UltraTabPageControl10)
        Me.ficConCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficConCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficConCombustible.Location = New System.Drawing.Point(0, 206)
        Me.ficConCombustible.Name = "ficConCombustible"
        Me.ficConCombustible.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficConCombustible.Size = New System.Drawing.Size(1195, 434)
        Me.ficConCombustible.TabIndex = 1
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Cargar Combustible"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Tanqueos No Asociados"
        UltraTab8.TabPage = Me.UltraTabPageControl9
        UltraTab8.Text = "Cargar Surtidor"
        UltraTab9.TabPage = Me.UltraTabPageControl10
        UltraTab9.Text = "Pecsa"
        Me.ficConCombustible.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9})
        Me.ficConCombustible.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1193, 411)
        '
        'gbeConsultar
        '
        Me.gbeConsultar.Controls.Add(Me.ChkSeleccion)
        Me.gbeConsultar.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbeConsultar.ExpandedSize = New System.Drawing.Size(1195, 206)
        Me.gbeConsultar.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.gbeConsultar.Location = New System.Drawing.Point(0, 0)
        Me.gbeConsultar.Name = "gbeConsultar"
        Me.gbeConsultar.Size = New System.Drawing.Size(1195, 206)
        Me.gbeConsultar.TabIndex = 0
        Me.gbeConsultar.Text = "Consultar "
        Me.gbeConsultar.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ChkSeleccion
        '
        Me.ChkSeleccion.Controls.Add(Me.grFiltro)
        Me.ChkSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSeleccion.Location = New System.Drawing.Point(3, 20)
        Me.ChkSeleccion.Name = "ChkSeleccion"
        Me.ChkSeleccion.Size = New System.Drawing.Size(1189, 183)
        Me.ChkSeleccion.TabIndex = 0
        '
        'grFiltro
        '
        Appearance306.BackColor = System.Drawing.Color.White
        Appearance306.BackColor2 = System.Drawing.Color.White
        Me.grFiltro.ContentAreaAppearance = Appearance306
        Me.grFiltro.Controls.Add(Me.UltraGroupBox6)
        Me.grFiltro.Controls.Add(Me.ficFiltros)
        Me.grFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFiltro.Location = New System.Drawing.Point(0, 0)
        Me.grFiltro.Name = "grFiltro"
        Me.grFiltro.Size = New System.Drawing.Size(1189, 183)
        Me.grFiltro.TabIndex = 0
        Me.grFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox6
        '
        Appearance307.BackColor = System.Drawing.Color.White
        Appearance307.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption
        Me.UltraGroupBox6.ContentAreaAppearance = Appearance307
        Me.UltraGroupBox6.Controls.Add(Me.ndKmxVuelta)
        Me.UltraGroupBox6.Controls.Add(Me.Label7)
        Me.UltraGroupBox6.Controls.Add(Me.ColorKmVuelta)
        Me.UltraGroupBox6.Controls.Add(Me.ColorRendMenor)
        Me.UltraGroupBox6.Controls.Add(Me.ColorRendMayor)
        Me.UltraGroupBox6.Controls.Add(Me.nd_RendMenor)
        Me.UltraGroupBox6.Controls.Add(Me.Label5)
        Me.UltraGroupBox6.Controls.Add(Me.Label4)
        Me.UltraGroupBox6.Controls.Add(Me.nd_RendMayor)
        Me.UltraGroupBox6.Controls.Add(Me.ColorSinRend)
        Me.UltraGroupBox6.Controls.Add(Me.Label6)
        Me.UltraGroupBox6.Controls.Add(Me.Label3)
        Me.UltraGroupBox6.Controls.Add(Me.ColorDistNegativo)
        Me.UltraGroupBox6.Controls.Add(Me.chkColores)
        Me.UltraGroupBox6.Controls.Add(Me.btnActualizaRend)
        Me.UltraGroupBox6.Controls.Add(Me.chk_TanqNoAsoc)
        Me.UltraGroupBox6.Controls.Add(Me.griData)
        Me.UltraGroupBox6.Controls.Add(Me.Label1)
        Me.UltraGroupBox6.Controls.Add(Me.UltraGrid1)
        Me.UltraGroupBox6.Controls.Add(Me.rfHasta)
        Me.UltraGroupBox6.Controls.Add(Me.rfDesde)
        Me.UltraGroupBox6.Controls.Add(Me.Label2)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(359, 2)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(828, 179)
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ndKmxVuelta
        '
        Appearance308.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndKmxVuelta.Appearance = Appearance308
        Me.ndKmxVuelta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKmxVuelta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKmxVuelta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndKmxVuelta.Location = New System.Drawing.Point(330, 69)
        Me.ndKmxVuelta.MaskInput = "{double:3.2}"
        Me.ndKmxVuelta.Name = "ndKmxVuelta"
        Me.ndKmxVuelta.NullText = "0.00"
        Me.ndKmxVuelta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKmxVuelta.Size = New System.Drawing.Size(38, 22)
        Me.ndKmxVuelta.TabIndex = 10
        Me.ndKmxVuelta.Value = 137.5R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(215, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Py - Tembladera - Py"
        '
        'ColorKmVuelta
        '
        Me.ColorKmVuelta.Color = System.Drawing.Color.Aqua
        Me.ColorKmVuelta.Location = New System.Drawing.Point(374, 69)
        Me.ColorKmVuelta.Name = "ColorKmVuelta"
        Me.ColorKmVuelta.Size = New System.Drawing.Size(45, 22)
        Me.ColorKmVuelta.TabIndex = 11
        Me.ColorKmVuelta.Text = "Aqua"
        '
        'ColorRendMenor
        '
        Me.ColorRendMenor.Color = System.Drawing.Color.LightCoral
        Me.ColorRendMenor.Location = New System.Drawing.Point(374, 123)
        Me.ColorRendMenor.Name = "ColorRendMenor"
        Me.ColorRendMenor.Size = New System.Drawing.Size(45, 22)
        Me.ColorRendMenor.TabIndex = 16
        Me.ColorRendMenor.Text = "LightCoral"
        '
        'ColorRendMayor
        '
        Me.ColorRendMayor.Color = System.Drawing.Color.LightCoral
        Me.ColorRendMayor.Location = New System.Drawing.Point(374, 150)
        Me.ColorRendMayor.Name = "ColorRendMayor"
        Me.ColorRendMayor.Size = New System.Drawing.Size(45, 22)
        Me.ColorRendMayor.TabIndex = 19
        Me.ColorRendMayor.Text = "LightCoral"
        '
        'nd_RendMenor
        '
        Appearance309.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMenor.Appearance = Appearance309
        Me.nd_RendMenor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_RendMenor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_RendMenor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMenor.Location = New System.Drawing.Point(330, 123)
        Me.nd_RendMenor.MaskInput = "{double:2.2}"
        Me.nd_RendMenor.Name = "nd_RendMenor"
        Me.nd_RendMenor.NullText = "0.00"
        Me.nd_RendMenor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_RendMenor.Size = New System.Drawing.Size(38, 22)
        Me.nd_RendMenor.TabIndex = 15
        Me.nd_RendMenor.Value = 5.0R
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(215, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Rendimiento mayor a:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(214, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Rendimiento menor a:"
        '
        'nd_RendMayor
        '
        Appearance310.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMayor.Appearance = Appearance310
        Me.nd_RendMayor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_RendMayor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_RendMayor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMayor.Location = New System.Drawing.Point(330, 150)
        Me.nd_RendMayor.MaskInput = "{double:2.2}"
        Me.nd_RendMayor.Name = "nd_RendMayor"
        Me.nd_RendMayor.NullText = "0.00"
        Me.nd_RendMayor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_RendMayor.Size = New System.Drawing.Size(38, 22)
        Me.nd_RendMayor.TabIndex = 18
        Me.nd_RendMayor.Value = 17.0R
        '
        'ColorSinRend
        '
        Me.ColorSinRend.Color = System.Drawing.Color.Yellow
        Me.ColorSinRend.Location = New System.Drawing.Point(374, 96)
        Me.ColorSinRend.Name = "ColorSinRend"
        Me.ColorSinRend.Size = New System.Drawing.Size(45, 22)
        Me.ColorSinRend.TabIndex = 13
        Me.ColorSinRend.Text = "Yellow"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(215, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Parametros para Rend.Esp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(215, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Distancias en negativo:"
        '
        'ColorDistNegativo
        '
        Me.ColorDistNegativo.Color = System.Drawing.Color.Red
        Me.ColorDistNegativo.Location = New System.Drawing.Point(374, 42)
        Me.ColorDistNegativo.Name = "ColorDistNegativo"
        Me.ColorDistNegativo.Size = New System.Drawing.Size(45, 22)
        Me.ColorDistNegativo.TabIndex = 8
        Me.ColorDistNegativo.Text = "Red"
        '
        'chkColores
        '
        Appearance311.BackColor = System.Drawing.Color.Transparent
        Appearance311.ForeColor = System.Drawing.Color.Navy
        Me.chkColores.Appearance = Appearance311
        Me.chkColores.BackColor = System.Drawing.Color.Transparent
        Me.chkColores.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkColores.Checked = True
        Me.chkColores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColores.Location = New System.Drawing.Point(193, 22)
        Me.chkColores.Name = "chkColores"
        Me.chkColores.Size = New System.Drawing.Size(192, 14)
        Me.chkColores.TabIndex = 6
        Me.chkColores.Text = "Visualizar colores:"
        '
        'btnActualizaRend
        '
        Appearance312.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance312.Image = "266.png"
        Me.btnActualizaRend.Appearance = Appearance312
        Me.btnActualizaRend.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActualizaRend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizaRend.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizaRend.ForeColor = System.Drawing.Color.Black
        Me.btnActualizaRend.ImageList = Me.imagenes
        Me.btnActualizaRend.Location = New System.Drawing.Point(20, 146)
        Me.btnActualizaRend.Name = "btnActualizaRend"
        Me.btnActualizaRend.Size = New System.Drawing.Size(137, 23)
        Me.btnActualizaRend.TabIndex = 5
        Me.btnActualizaRend.Text = "Actualizar Metas"
        Me.btnActualizaRend.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'chk_TanqNoAsoc
        '
        Appearance313.ForeColor = System.Drawing.Color.Navy
        Appearance313.TextHAlignAsString = "Center"
        Appearance313.TextVAlignAsString = "Middle"
        Me.chk_TanqNoAsoc.Appearance = Appearance313
        Me.chk_TanqNoAsoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TanqNoAsoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_TanqNoAsoc.BorderStyle = Infragistics.Win.UIElementBorderStyle.Etched
        Me.chk_TanqNoAsoc.Location = New System.Drawing.Point(20, 91)
        Me.chk_TanqNoAsoc.Name = "chk_TanqNoAsoc"
        Me.chk_TanqNoAsoc.Size = New System.Drawing.Size(137, 21)
        Me.chk_TanqNoAsoc.TabIndex = 4
        Me.chk_TanqNoAsoc.Text = "Tanqueos No Asoc."
        '
        'griData
        '
        Me.griData.DisplayLayout.MaxColScrollRegions = 1
        Me.griData.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griData.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griData.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griData.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griData.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griData.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griData.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griData.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griData.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griData.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griData.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griData.Location = New System.Drawing.Point(749, 54)
        Me.griData.Name = "griData"
        Me.griData.Size = New System.Drawing.Size(38, 45)
        Me.griData.TabIndex = 21
        Me.griData.TabStop = False
        Me.griData.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'UltraGrid1
        '
        Appearance314.BackColor = System.Drawing.SystemColors.Window
        Appearance314.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance314
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance315.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance315.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance315.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance315.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance315
        Appearance316.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance316
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance317.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance317.BackColor2 = System.Drawing.SystemColors.Control
        Appearance317.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance317.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance317
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance318.BackColor = System.Drawing.SystemColors.Window
        Appearance318.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance318
        Appearance319.BackColor = System.Drawing.SystemColors.Highlight
        Appearance319.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance319
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance320.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance320
        Appearance321.BorderColor = System.Drawing.Color.Silver
        Appearance321.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance321
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
        Appearance322.BackColor = System.Drawing.SystemColors.Control
        Appearance322.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance322.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance322.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance322.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance322
        Appearance323.TextHAlignAsString = "Left"
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance323
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance324.BackColor = System.Drawing.SystemColors.Window
        Appearance324.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance324
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance325.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance325
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.Location = New System.Drawing.Point(749, 6)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(38, 42)
        Me.UltraGrid1.TabIndex = 20
        Me.UltraGrid1.Text = "UltraGrid1"
        Me.UltraGrid1.Visible = False
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(62, 54)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(95, 21)
        Me.rfHasta.TabIndex = 3
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(61, 22)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(96, 21)
        Me.rfDesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'ficFiltros
        '
        Me.ficFiltros.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl3)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl8)
        Me.ficFiltros.Controls.Add(Me.utpMarcaModelo)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl4)
        Me.ficFiltros.Dock = System.Windows.Forms.DockStyle.Left
        Me.ficFiltros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFiltros.Location = New System.Drawing.Point(2, 2)
        Me.ficFiltros.Name = "ficFiltros"
        Me.ficFiltros.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficFiltros.Size = New System.Drawing.Size(357, 179)
        Me.ficFiltros.TabIndex = 0
        UltraTab10.TabPage = Me.UltraTabPageControl3
        UltraTab10.Text = "Vehículos"
        UltraTab11.TabPage = Me.UltraTabPageControl8
        UltraTab11.Text = "Pilotos"
        UltraTab12.TabPage = Me.utpMarcaModelo
        UltraTab12.Text = "Tipo Vehículo"
        UltraTab13.TabPage = Me.UltraTabPageControl4
        UltraTab13.Text = "Flota"
        Me.ficFiltros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11, UltraTab12, UltraTab13})
        Me.ficFiltros.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(355, 156)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(399, 286)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 3
        Me.ugb_Espera.Visible = False
        '
        'frm_RegistroConsumoCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 640)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficConCombustible)
        Me.Controls.Add(Me.gbeConsultar)
        Me.Name = "frm_RegistroConsumoCombustible"
        Me.Text = "Consumo de Combustible"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenesdeTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenesdeTransferencia.ResumeLayout(False)
        CType(Me.grid_ListadoTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTanqueo.ResumeLayout(False)
        CType(Me.odRegConsumoCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.chkVisualiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTanqueosNoAsociados.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.grid_TanqNoAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odTanqueosNoAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        CType(Me.ag_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ag_Datos.ResumeLayout(False)
        Me.ag_Datos.PerformLayout()
        CType(Me.txtGlosaTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrifo.ClientArea.ResumeLayout(False)
        Me.PanelGrifo.ResumeLayout(False)
        Me.PanelImagen.ClientArea.ResumeLayout(False)
        Me.PanelImagen.ResumeLayout(False)
        Me.PanelManguera.ClientArea.ResumeLayout(False)
        Me.PanelManguera.ClientArea.PerformLayout()
        Me.PanelManguera.ResumeLayout(False)
        CType(Me.cmb_TipoCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NroVale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_PrecioUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_CantGalones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_KmTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opt_IndTanqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ag_DatosGrifo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ag_DatosGrifo.ResumeLayout(False)
        Me.ag_DatosGrifo.PerformLayout()
        CType(Me.dtp_FecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrifo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ag_Operacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ag_Operacion.ResumeLayout(False)
        Me.ag_Operacion.PerformLayout()
        CType(Me.txtPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decOdometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.grid_RegTanqNoAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.cboDireccionTNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarTNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrifoTNA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.txtGlosaTanqueo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.nd_CantGalonesS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigoSurtidorS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_KmTanqueoS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Opt_IndTanqueoS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.dtp_FechaViajeS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_IdPilotoS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxT_IdViajeS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPilotoS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_OdometroS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtViajeS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboVehiculoS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.txtGlosaTanqueo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TxtCodigoSurtidorS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_CantGalonesS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_KmTanqueoS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Opt_IndTanqueoS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.dtp_FechaViajeS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_IdPilotoS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxT_IdViajeS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPilotoS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_OdometroS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtViajeS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboVehiculoS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.decSotckS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_PrecioUnitarioS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboDireccionS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboLugarS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboGrifoS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.UltraCheckEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griTanqueosPecsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.ColorKm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresDup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Grid_Vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.Grid_Pilotos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMarcaModelo.ResumeLayout(False)
        CType(Me.Grid_TipoeVeh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Grid_Zona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuEnvioSurtidor.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.RangoFechas1.ResumeLayout(False)
        Me.RangoFechas1.PerformLayout()
        CType(Me.FechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha2.ResumeLayout(False)
        CType(Me.ficConCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficConCombustible.ResumeLayout(False)
        CType(Me.gbeConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeConsultar.ResumeLayout(False)
        Me.ChkSeleccion.ResumeLayout(False)
        CType(Me.grFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grFiltro.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.ndKmxVuelta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorKmVuelta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRendMenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRendMayor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_RendMenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_RendMayor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSinRend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDistNegativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_TanqNoAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraToolbarsDockArea21 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea22 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea23 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea24 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ag_DatosGrifo As ISL.Controles.Agrupacion
    Friend WithEvents ag_Operacion As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents cboVehiculo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolbarsDockArea11 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea12 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea9 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea10 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenesdeTransferencia As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents ficConCombustible As ISL.Controles.Ficha
    Friend WithEvents gbeConsultar As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents ChkSeleccion As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents odRegConsumoCombustible As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ag_Datos As ISL.Controles.Agrupacion
    Friend WithEvents ficFiltros As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents odCombo As ISL.Controles.OrigenDatos
    Friend WithEvents nd_PrecioUnitario As ISL.Controles.NumeroDecimal
    Friend WithEvents nd_CantGalones As ISL.Controles.NumeroDecimal
    Friend WithEvents nd_KmTanqueo As ISL.Controles.NumeroDecimal
    Friend WithEvents txt_NroVale As ISL.Controles.Texto
    Friend WithEvents txtViaje As ISL.Controles.Texto
    Friend WithEvents decOdometro As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboGrifo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboDireccion As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cboLugar As ISL.Controles.ComboMaestros
    Friend WithEvents opt_IndTanqueo As ISL.Controles.Opciones
    Friend WithEvents etiStock As ISL.Controles.Etiqueta
    Friend WithEvents decStock As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents RangoFechas1 As ISL.Controles.RangoFechas
    Friend WithEvents object_7f6ed894_68f8_4960_99b6_d861cbd1c3cf As ISL.Controles.Etiqueta
    Friend WithEvents object_42630089_f836_4a75_a642_b22c3a63ea5d As ISL.Controles.Etiqueta
    Friend WithEvents FechaHasta As ISL.Controles.Fecha
    Friend WithEvents FechaDesde As ISL.Controles.Fecha
    Friend WithEvents Ficha2 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Grilla1 As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea15 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea16 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea19 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea20 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents txtPiloto As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents grid_ListadoTanqueo As ISL.Controles.Grilla
    Friend WithEvents gbTanqueosNoAsociados As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents MenuTanqueo As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtp_FecViaje As ISL.Controles.Fecha
    Friend WithEvents grid_TanqNoAsoc As ISL.Controles.Grilla
    Friend WithEvents odTanqueosNoAsociados As ISL.Controles.OrigenDatos
    Friend WithEvents eti_Galones As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents lblRango As ISL.Controles.Etiqueta
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesasociarTanqueoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_RegTanqNoAsoc As ISL.Controles.Grilla
    Friend WithEvents btnGuardar As ISL.Controles.Boton
    Friend WithEvents btnImportar As ISL.Controles.Boton
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboDireccionTNA As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboLugarTNA As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents cboGrifoTNA As ISL.Controles.ComboMaestros
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_TipoCombustible As ISL.Controles.ComboMaestros
    Friend WithEvents utpMarcaModelo As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AsociarTanqueoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grFiltro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents PanelGrifo As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents PanelManguera As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents OptManguera1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents OptManguera2 As System.Windows.Forms.RadioButton
    Friend WithEvents TiempoManguera As System.Windows.Forms.Timer
    Friend WithEvents PanelImagen As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents TxtNumManguera As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents decSotckS As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents nd_PrecioUnitarioS As ISL.Controles.NumeroDecimal
    Friend WithEvents CboDireccionS As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents CboLugarS As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents CboGrifoS As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents dtp_FechaTanqueoS1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents nd_KmTanqueoS1 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Opt_IndTanqueoS1 As ISL.Controles.Opciones
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Txt_IdPilotoS1 As ISL.Controles.Texto
    Friend WithEvents TxT_IdViajeS1 As ISL.Controles.Texto
    Friend WithEvents TxtPilotoS1 As ISL.Controles.Texto
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents nd_OdometroS1 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents TxtViajeS1 As ISL.Controles.Texto
    Friend WithEvents CboVehiculoS1 As ISL.Controles.ComboMaestros
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents dtp_FechaTanqueoS2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents nd_CantGalonesS2 As ISL.Controles.NumeroDecimal
    Friend WithEvents nd_KmTanqueoS2 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents Opt_IndTanqueoS2 As ISL.Controles.Opciones
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Txt_IdPilotoS2 As ISL.Controles.Texto
    Friend WithEvents TxT_IdViajeS2 As ISL.Controles.Texto
    Friend WithEvents TxtPilotoS2 As ISL.Controles.Texto
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents nd_OdometroS2 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents TxtViajeS2 As ISL.Controles.Texto
    Friend WithEvents CboVehiculoS2 As ISL.Controles.ComboMaestros
    Friend WithEvents TiempoSurtidor As System.Windows.Forms.Timer
    Friend WithEvents MenuEnvioSurtidor As ISL.Controles.MenuContextual
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarASurtidor2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TanquearConSurtidor1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TanquearConSurtidor2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtCodigoSurtidorS1 As ISL.Controles.Texto
    Friend WithEvents TxtCodigoSurtidorS2 As ISL.Controles.Texto
    Friend WithEvents BtnGuardarS1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnGuardarS2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents nd_CantGalonesS1 As ISL.Controles.NumeroDecimal
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtp_FechaViajeS1 As ISL.Controles.Fecha
    Friend WithEvents dtp_FechaViajeS2 As ISL.Controles.Fecha
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnLimpiaS1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnLimpiaS2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_TanqNoAsoc As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btn_ListarTanqNoAsoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fecFechaTanqueo As ISL.Controles.Fecha
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents fecInicioTanqueo As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFinTanqueo As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnGuardarPecsa As ISL.Controles.Boton
    Friend WithEvents griTanqueosPecsa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnLimpiar As ISL.Controles.Boton
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents ColorSPlaca As ISL.Controles.Colores
    Friend WithEvents ColoresDup As ISL.Controles.Colores
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents ColorKm As ISL.Controles.Colores
    Friend WithEvents UltraCheckEditor2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents griData As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Grid_Pilotos As ISL.Controles.Grilla
    Friend WithEvents Grid_Vehiculos As ISL.Controles.Grilla
    Friend WithEvents Grid_TipoeVeh As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_Zona As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnExporta2 As ISL.Controles.Boton
    Friend WithEvents btnExporta1 As ISL.Controles.Boton
    Friend WithEvents chkVisualiza As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnExpande1 As ISL.Controles.Boton
    Friend WithEvents btnExpande2 As ISL.Controles.Boton
    Friend WithEvents btnExpande3 As ISL.Controles.Boton
    Friend WithEvents lblExpande As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ColorDistNegativo As ISL.Controles.Colores
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nd_RendMenor As ISL.Controles.NumeroDecimal
    Friend WithEvents ColorRendMayor As ISL.Controles.Colores
    Friend WithEvents ColorRendMenor As ISL.Controles.Colores
    Friend WithEvents nd_RendMayor As ISL.Controles.NumeroDecimal
    Friend WithEvents btnActualizaRend As ISL.Controles.Boton
    Friend WithEvents chkColores As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ColorSinRend As ISL.Controles.Colores
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorKmVuelta As ISL.Controles.Colores
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ndKmxVuelta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaTanqueo1 As ISL.Controles.Texto
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaTanqueo2 As ISL.Controles.Texto
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaTanqueo As ISL.Controles.Texto
    Friend WithEvents VerISL As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Credito As System.Windows.Forms.CheckBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
