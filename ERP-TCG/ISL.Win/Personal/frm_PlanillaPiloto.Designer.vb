<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PlanillaPiloto
    Inherits ISL.Win.frm_MenuPadre

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanillaPiloto")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCopiloto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPiloto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPago")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaPiloto")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAyudante")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retorno")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaCoPiloto")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPlanillaPiloto")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCopiloto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoPiloto")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoSolo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoAcompañado")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeCopiloto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoSolo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoCruceroPiloto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BonoCruceroCopiloto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPago")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaPiloto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoAyudante")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Retorno")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaCoPiloto")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanillaPiloto")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCopiloto")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPiloto")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPago")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaPiloto")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAyudante")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retorno")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaCoPiloto")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanillaPiloto")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCopiloto")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPiloto")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoSolo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAcompañado")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeCopiloto")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoSolo")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroPiloto")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BonoCruceroCopiloto")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPago")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaPiloto")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAyudante")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retorno")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaCoPiloto")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("⁯IdPlanillaPiloto")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoTotal")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTrabajador")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("⁯IdPlanillaPiloto")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoTotal")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTrabajador")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("⁯IdPlanillaPiloto")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoTotal")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTrabajador")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("⁯IdPlanillaPiloto")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoTotal")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTrabajador")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPlanilla")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Planilla")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPlanilla")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Planilla")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaViajesN = New ISL.Controles.Grilla(Me.components)
        Me.mnuPlanillaViaje = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.odPlanillaViajes = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaViajesP = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaViajesL = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaPilotosDetN = New ISL.Controles.Grilla(Me.components)
        Me.odPlanillaDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaPilotosDetP = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion13 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaPilotosDetL = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficPlanillaViaje = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnVerificar = New Infragistics.Win.Misc.UltraButton()
        Me.btnActualizar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtPlanilla = New System.Windows.Forms.TextBox()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.btnConsolidar = New Infragistics.Win.Misc.UltraButton()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecViajeTermino = New System.Windows.Forms.DateTimePicker()
        Me.fecViajeInicio = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficPlanillaPilotoDet = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.numMontoTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.griPlanillaPilotos = New ISL.Controles.Grilla(Me.components)
        Me.mnuPlanillaPiloto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEnviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.odPlanillaPilotos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficMantenimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ficPlanillaPiloto = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.griPlanillaViajesN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPlanillaViaje.SuspendLayout()
        CType(Me.odPlanillaViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.griPlanillaViajesP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.griPlanillaViajesL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.griPlanillaPilotosDetN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odPlanillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.griPlanillaPilotosDetP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion13.SuspendLayout()
        CType(Me.griPlanillaPilotosDetL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ficPlanillaViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPlanillaViaje.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ficPlanillaPilotoDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPlanillaPilotoDet.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.numMontoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.griPlanillaPilotos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPlanillaPiloto.SuspendLayout()
        CType(Me.odPlanillaPilotos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMantenimiento.SuspendLayout()
        CType(Me.ficPlanillaPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPlanillaPiloto.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1234, 264)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.griPlanillaViajesN)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1234, 264)
        Me.Agrupacion5.TabIndex = 32
        Me.Agrupacion5.Text = "ListaViajesNacional"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaViajesN
        '
        Me.griPlanillaViajesN.ContextMenuStrip = Me.mnuPlanillaViaje
        Me.griPlanillaViajesN.DataSource = Me.odPlanillaViajes
        UltraGridColumn182.Header.VisiblePosition = 0
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 1
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 2
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.VisiblePosition = 3
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.Header.VisiblePosition = 10
        UltraGridColumn186.Width = 241
        UltraGridColumn187.Header.VisiblePosition = 12
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 6
        UltraGridColumn188.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn188.Width = 73
        UltraGridColumn189.Header.VisiblePosition = 13
        UltraGridColumn189.Width = 207
        UltraGridColumn190.Header.VisiblePosition = 14
        UltraGridColumn190.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn191.CellAppearance = Appearance1
        UltraGridColumn191.Header.VisiblePosition = 15
        UltraGridColumn191.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn192.CellAppearance = Appearance2
        UltraGridColumn192.Header.VisiblePosition = 11
        UltraGridColumn192.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn192.Width = 73
        UltraGridColumn193.Header.VisiblePosition = 16
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 7
        UltraGridColumn194.Width = 104
        UltraGridColumn195.Header.VisiblePosition = 17
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 18
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 19
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 20
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 21
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 8
        UltraGridColumn200.Width = 196
        UltraGridColumn201.Header.VisiblePosition = 9
        UltraGridColumn201.Width = 218
        UltraGridColumn202.Header.VisiblePosition = 22
        UltraGridColumn202.Hidden = True
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn203.CellAppearance = Appearance3
        UltraGridColumn203.Header.VisiblePosition = 23
        UltraGridColumn203.MaskInput = "{double:3.2}"
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn203.Width = 62
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn204.CellAppearance = Appearance4
        UltraGridColumn204.Header.Caption = "CruceroPiloto"
        UltraGridColumn204.Header.VisiblePosition = 24
        UltraGridColumn204.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn205.CellAppearance = Appearance5
        UltraGridColumn205.Header.Caption = "CruceroCopiloto"
        UltraGridColumn205.Header.VisiblePosition = 25
        UltraGridColumn205.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn206.CellAppearance = Appearance6
        UltraGridColumn206.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn206.Header.VisiblePosition = 4
        UltraGridColumn206.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn206.Width = 48
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn207.CellAppearance = Appearance7
        UltraGridColumn207.Header.VisiblePosition = 26
        UltraGridColumn207.MaskInput = "-nn"
        UltraGridColumn207.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn207.Width = 75
        UltraGridColumn208.Header.VisiblePosition = 27
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 28
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 29
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 30
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 31
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 5
        UltraGridColumn213.Width = 50
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn214.CellAppearance = Appearance8
        UltraGridColumn214.Header.VisiblePosition = 32
        UltraGridColumn214.Hidden = True
        UltraGridColumn214.MaskInput = "-nn"
        UltraGridColumn214.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214})
        Me.griPlanillaViajesN.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griPlanillaViajesN.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaViajesN.DisplayLayout.GroupByBox.Appearance = Appearance9
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesN.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance10
        Me.griPlanillaViajesN.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaViajesN.DisplayLayout.GroupByBox.Hidden = True
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance11.BackColor2 = System.Drawing.SystemColors.Control
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesN.DisplayLayout.GroupByBox.PromptAppearance = Appearance11
        Me.griPlanillaViajesN.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaViajesN.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaViajesN.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesN.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesN.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaViajesN.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesN.DisplayLayout.Override.CellAppearance = Appearance12
        Me.griPlanillaViajesN.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaViajesN.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaViajesN.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaViajesN.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaViajesN.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaViajesN.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Left"
        Me.griPlanillaViajesN.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.griPlanillaViajesN.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesN.DisplayLayout.Override.RowAppearance = Appearance15
        Me.griPlanillaViajesN.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaViajesN.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaViajesN.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaViajesN.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaViajesN.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaViajesN.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaViajesN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaViajesN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaViajesN.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaViajesN.Name = "griPlanillaViajesN"
        Me.griPlanillaViajesN.Size = New System.Drawing.Size(1228, 245)
        Me.griPlanillaViajesN.TabIndex = 14
        Me.griPlanillaViajesN.TabStop = False
        Me.griPlanillaViajesN.Text = "Grilla1"
        '
        'mnuPlanillaViaje
        '
        Me.mnuPlanillaViaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnuPlanillaViaje.Name = "ContextMenuStrip1"
        Me.mnuPlanillaViaje.Size = New System.Drawing.Size(163, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItem1.Text = "CrearMontoRuta"
        '
        'odPlanillaViajes
        '
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Short)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Short)
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Short)
        Me.odPlanillaViajes.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion10)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1234, 264)
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.griPlanillaViajesP)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(1234, 264)
        Me.Agrupacion10.TabIndex = 33
        Me.Agrupacion10.Text = "ListaViajesPacasmayo"
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaViajesP
        '
        Me.griPlanillaViajesP.ContextMenuStrip = Me.mnuPlanillaViaje
        Me.griPlanillaViajesP.DataSource = Me.odPlanillaViajes
        UltraGridColumn138.Header.VisiblePosition = 0
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 1
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 2
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.Header.VisiblePosition = 3
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 10
        UltraGridColumn142.Width = 241
        UltraGridColumn143.Header.VisiblePosition = 12
        UltraGridColumn143.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 5
        UltraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn144.Header.VisiblePosition = 13
        UltraGridColumn144.Width = 207
        UltraGridColumn145.Header.VisiblePosition = 14
        UltraGridColumn145.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn146.CellAppearance = Appearance16
        UltraGridColumn146.Header.VisiblePosition = 15
        UltraGridColumn146.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn147.CellAppearance = Appearance17
        UltraGridColumn147.Header.VisiblePosition = 11
        UltraGridColumn147.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn147.Width = 93
        UltraGridColumn148.Header.VisiblePosition = 16
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 7
        UltraGridColumn149.Width = 104
        UltraGridColumn150.Header.VisiblePosition = 17
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 18
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 19
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 20
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 21
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 8
        UltraGridColumn155.Width = 196
        UltraGridColumn156.Header.VisiblePosition = 9
        UltraGridColumn156.Width = 218
        UltraGridColumn157.Header.VisiblePosition = 22
        UltraGridColumn157.Hidden = True
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn158.CellAppearance = Appearance18
        UltraGridColumn158.Header.VisiblePosition = 23
        UltraGridColumn158.Hidden = True
        UltraGridColumn158.MaskInput = "{double:3.2}"
        UltraGridColumn158.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn158.Width = 62
        Appearance19.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn159.CellAppearance = Appearance19
        UltraGridColumn159.Header.Caption = "CruceroPiloto"
        UltraGridColumn159.Header.VisiblePosition = 24
        UltraGridColumn159.Hidden = True
        UltraGridColumn159.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance20.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn160.CellAppearance = Appearance20
        UltraGridColumn160.Header.Caption = "CruceroCopiloto"
        UltraGridColumn160.Header.VisiblePosition = 25
        UltraGridColumn160.Hidden = True
        UltraGridColumn160.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn161.CellAppearance = Appearance21
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn161.Header.VisiblePosition = 4
        UltraGridColumn161.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn161.Width = 48
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn162.CellAppearance = Appearance22
        UltraGridColumn162.Header.VisiblePosition = 26
        UltraGridColumn162.MaskInput = "-nn"
        UltraGridColumn162.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn162.Width = 83
        UltraGridColumn48.Header.VisiblePosition = 27
        UltraGridColumn48.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 28
        UltraGridColumn53.Hidden = True
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn54.CellAppearance = Appearance23
        UltraGridColumn54.Header.VisiblePosition = 29
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn67.Header.VisiblePosition = 30
        UltraGridColumn67.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 31
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 6
        UltraGridColumn72.Hidden = True
        UltraGridColumn72.Width = 48
        Appearance24.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn106.CellAppearance = Appearance24
        UltraGridColumn106.Header.VisiblePosition = 32
        UltraGridColumn106.MaskInput = "-nn"
        UltraGridColumn106.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn113, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn48, UltraGridColumn53, UltraGridColumn54, UltraGridColumn67, UltraGridColumn71, UltraGridColumn72, UltraGridColumn106})
        Me.griPlanillaViajesP.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griPlanillaViajesP.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaViajesP.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesP.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.griPlanillaViajesP.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaViajesP.DisplayLayout.GroupByBox.Hidden = True
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesP.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.griPlanillaViajesP.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaViajesP.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaViajesP.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesP.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesP.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaViajesP.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesP.DisplayLayout.Override.CellAppearance = Appearance28
        Me.griPlanillaViajesP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaViajesP.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaViajesP.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaViajesP.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaViajesP.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaViajesP.DisplayLayout.Override.GroupByRowAppearance = Appearance29
        Appearance30.TextHAlignAsString = "Left"
        Me.griPlanillaViajesP.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.griPlanillaViajesP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance31.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesP.DisplayLayout.Override.RowAppearance = Appearance31
        Me.griPlanillaViajesP.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaViajesP.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaViajesP.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaViajesP.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaViajesP.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaViajesP.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaViajesP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaViajesP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaViajesP.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaViajesP.Name = "griPlanillaViajesP"
        Me.griPlanillaViajesP.Size = New System.Drawing.Size(1228, 245)
        Me.griPlanillaViajesP.TabIndex = 15
        Me.griPlanillaViajesP.TabStop = False
        Me.griPlanillaViajesP.Text = "Grilla1"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion11)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1234, 264)
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.griPlanillaViajesL)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(1234, 264)
        Me.Agrupacion11.TabIndex = 33
        Me.Agrupacion11.Text = "ListaViajesLima"
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaViajesL
        '
        Me.griPlanillaViajesL.ContextMenuStrip = Me.mnuPlanillaViaje
        Me.griPlanillaViajesL.DataSource = Me.odPlanillaViajes
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridColumn18.Width = 241
        UltraGridColumn19.Header.VisiblePosition = 10
        UltraGridColumn19.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 32
        UltraGridColumn20.Header.VisiblePosition = 11
        UltraGridColumn20.Width = 207
        UltraGridColumn21.Header.VisiblePosition = 12
        UltraGridColumn21.Hidden = True
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance32
        UltraGridColumn22.Header.VisiblePosition = 13
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance33
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn23.Width = 73
        UltraGridColumn24.Header.VisiblePosition = 14
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.Width = 104
        UltraGridColumn27.Header.VisiblePosition = 15
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 16
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 17
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 18
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 19
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 6
        UltraGridColumn32.Width = 196
        UltraGridColumn33.Header.VisiblePosition = 7
        UltraGridColumn33.Width = 218
        UltraGridColumn34.Header.VisiblePosition = 20
        UltraGridColumn34.Hidden = True
        Appearance34.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance34
        UltraGridColumn35.Header.VisiblePosition = 21
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.MaskInput = "{double:3.2}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 62
        Appearance35.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance35
        UltraGridColumn36.Header.Caption = "CruceroPiloto"
        UltraGridColumn36.Header.VisiblePosition = 22
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance36.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance36
        UltraGridColumn43.Header.Caption = "CruceroCopiloto"
        UltraGridColumn43.Header.VisiblePosition = 23
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance37.TextHAlignAsString = "Center"
        UltraGridColumn44.CellAppearance = Appearance37
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn44.Header.VisiblePosition = 4
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn44.Width = 48
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance38
        UltraGridColumn45.Header.VisiblePosition = 26
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn45.Width = 45
        UltraGridColumn49.Header.VisiblePosition = 27
        UltraGridColumn49.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 24
        UltraGridColumn55.Width = 189
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn56.CellAppearance = Appearance39
        UltraGridColumn56.Header.VisiblePosition = 25
        UltraGridColumn56.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn56.Width = 90
        UltraGridColumn68.Header.VisiblePosition = 28
        UltraGridColumn68.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 29
        UltraGridColumn97.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 30
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 46
        UltraGridColumn109.Header.VisiblePosition = 31
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn9, UltraGridColumn14, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn114, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn49, UltraGridColumn55, UltraGridColumn56, UltraGridColumn68, UltraGridColumn97, UltraGridColumn100, UltraGridColumn109})
        Me.griPlanillaViajesL.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griPlanillaViajesL.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaViajesL.DisplayLayout.GroupByBox.Appearance = Appearance40
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesL.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance41
        Me.griPlanillaViajesL.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaViajesL.DisplayLayout.GroupByBox.Hidden = True
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance42.BackColor2 = System.Drawing.SystemColors.Control
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaViajesL.DisplayLayout.GroupByBox.PromptAppearance = Appearance42
        Me.griPlanillaViajesL.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaViajesL.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaViajesL.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesL.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaViajesL.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaViajesL.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesL.DisplayLayout.Override.CellAppearance = Appearance43
        Me.griPlanillaViajesL.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaViajesL.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaViajesL.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaViajesL.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaViajesL.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaViajesL.DisplayLayout.Override.GroupByRowAppearance = Appearance44
        Appearance45.TextHAlignAsString = "Left"
        Me.griPlanillaViajesL.DisplayLayout.Override.HeaderAppearance = Appearance45
        Me.griPlanillaViajesL.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance46.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaViajesL.DisplayLayout.Override.RowAppearance = Appearance46
        Me.griPlanillaViajesL.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaViajesL.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaViajesL.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaViajesL.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaViajesL.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaViajesL.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaViajesL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaViajesL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaViajesL.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaViajesL.Name = "griPlanillaViajesL"
        Me.griPlanillaViajesL.Size = New System.Drawing.Size(1228, 245)
        Me.griPlanillaViajesL.TabIndex = 15
        Me.griPlanillaViajesL.TabStop = False
        Me.griPlanillaViajesL.Text = "Grilla1"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1234, 268)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.griPlanillaPilotosDetN)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1234, 268)
        Me.Agrupacion9.TabIndex = 37
        Me.Agrupacion9.Text = "Consolidado Pilotos"
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaPilotosDetN
        '
        Me.griPlanillaPilotosDetN.DataSource = Me.odPlanillaDetalle
        UltraGridColumn61.Header.VisiblePosition = 0
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 1
        UltraGridColumn62.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 8
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 2
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 4
        UltraGridColumn83.Width = 368
        UltraGridColumn84.Header.VisiblePosition = 7
        UltraGridColumn84.Hidden = True
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance47
        UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn85.Format = "#,###,###,##0.00"
        UltraGridColumn85.Header.VisiblePosition = 5
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn86.Header.VisiblePosition = 6
        UltraGridColumn86.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 9
        UltraGridColumn1.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 10
        UltraGridColumn4.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 11
        UltraGridColumn63.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 3
        UltraGridColumn115.Width = 80
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn62, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn1, UltraGridColumn4, UltraGridColumn63, UltraGridColumn115})
        Me.griPlanillaPilotosDetN.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griPlanillaPilotosDetN.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaPilotosDetN.DisplayLayout.GroupByBox.Appearance = Appearance48
        Appearance49.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetN.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance49
        Me.griPlanillaPilotosDetN.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaPilotosDetN.DisplayLayout.GroupByBox.Hidden = True
        Appearance50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance50.BackColor2 = System.Drawing.SystemColors.Control
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetN.DisplayLayout.GroupByBox.PromptAppearance = Appearance50
        Me.griPlanillaPilotosDetN.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaPilotosDetN.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.CellAppearance = Appearance51
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.GroupByRowAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Left"
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance54.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.RowAppearance = Appearance54
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaPilotosDetN.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaPilotosDetN.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaPilotosDetN.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaPilotosDetN.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaPilotosDetN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaPilotosDetN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaPilotosDetN.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaPilotosDetN.Name = "griPlanillaPilotosDetN"
        Me.griPlanillaPilotosDetN.Size = New System.Drawing.Size(1228, 249)
        Me.griPlanillaPilotosDetN.TabIndex = 15
        Me.griPlanillaPilotosDetN.TabStop = False
        Me.griPlanillaPilotosDetN.Text = "Grilla1"
        '
        'odPlanillaDetalle
        '
        UltraDataColumn39.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn41.DataType = GetType(Boolean)
        Me.odPlanillaDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45})
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1234, 268)
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.griPlanillaPilotosDetP)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1234, 268)
        Me.Agrupacion12.TabIndex = 38
        Me.Agrupacion12.Text = "Consolidado Pilotos"
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaPilotosDetP
        '
        Me.griPlanillaPilotosDetP.DataSource = Me.odPlanillaDetalle
        UltraGridColumn87.Header.VisiblePosition = 0
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 1
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 8
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 2
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 4
        UltraGridColumn91.Width = 368
        UltraGridColumn92.Header.VisiblePosition = 7
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn93.CellAppearance = Appearance55
        UltraGridColumn93.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn93.Format = "#,###,###,##0.00"
        UltraGridColumn93.Header.VisiblePosition = 5
        UltraGridColumn93.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn94.Header.VisiblePosition = 6
        UltraGridColumn94.Hidden = True
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance56
        UltraGridColumn2.Header.VisiblePosition = 9
        UltraGridColumn2.MaskInput = "nnn"
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn5.Header.VisiblePosition = 10
        UltraGridColumn5.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 11
        UltraGridColumn64.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 3
        UltraGridColumn116.Width = 80
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn2, UltraGridColumn5, UltraGridColumn64, UltraGridColumn116})
        Me.griPlanillaPilotosDetP.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griPlanillaPilotosDetP.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance57.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaPilotosDetP.DisplayLayout.GroupByBox.Appearance = Appearance57
        Appearance58.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetP.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance58
        Me.griPlanillaPilotosDetP.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaPilotosDetP.DisplayLayout.GroupByBox.Hidden = True
        Appearance59.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance59.BackColor2 = System.Drawing.SystemColors.Control
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance59.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetP.DisplayLayout.GroupByBox.PromptAppearance = Appearance59
        Me.griPlanillaPilotosDetP.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaPilotosDetP.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance60.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.CellAppearance = Appearance60
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.GroupByRowAppearance = Appearance61
        Appearance62.TextHAlignAsString = "Left"
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.HeaderAppearance = Appearance62
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance63.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.RowAppearance = Appearance63
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaPilotosDetP.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaPilotosDetP.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaPilotosDetP.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaPilotosDetP.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaPilotosDetP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaPilotosDetP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaPilotosDetP.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaPilotosDetP.Name = "griPlanillaPilotosDetP"
        Me.griPlanillaPilotosDetP.Size = New System.Drawing.Size(1228, 249)
        Me.griPlanillaPilotosDetP.TabIndex = 15
        Me.griPlanillaPilotosDetP.TabStop = False
        Me.griPlanillaPilotosDetP.Text = "Grilla1"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.Agrupacion13)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1234, 268)
        '
        'Agrupacion13
        '
        Me.Agrupacion13.Controls.Add(Me.griPlanillaPilotosDetL)
        Me.Agrupacion13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion13.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion13.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion13.Name = "Agrupacion13"
        Me.Agrupacion13.Size = New System.Drawing.Size(1234, 268)
        Me.Agrupacion13.TabIndex = 38
        Me.Agrupacion13.Text = "Consolidado Pilotos"
        Me.Agrupacion13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaPilotosDetL
        '
        Me.griPlanillaPilotosDetL.DataSource = Me.odPlanillaDetalle
        UltraGridColumn73.Header.VisiblePosition = 0
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 1
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 8
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 4
        UltraGridColumn77.Width = 368
        UltraGridColumn78.Header.VisiblePosition = 7
        UltraGridColumn78.Hidden = True
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn79.CellAppearance = Appearance64
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn79.Header.VisiblePosition = 5
        UltraGridColumn79.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn80.Header.VisiblePosition = 6
        UltraGridColumn80.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 9
        UltraGridColumn6.Header.VisiblePosition = 10
        UltraGridColumn6.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 11
        UltraGridColumn65.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 3
        UltraGridColumn117.Width = 80
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn3, UltraGridColumn6, UltraGridColumn65, UltraGridColumn117})
        Me.griPlanillaPilotosDetL.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griPlanillaPilotosDetL.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance65.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance65.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance65.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaPilotosDetL.DisplayLayout.GroupByBox.Appearance = Appearance65
        Appearance66.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetL.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance66
        Me.griPlanillaPilotosDetL.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaPilotosDetL.DisplayLayout.GroupByBox.Hidden = True
        Appearance67.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance67.BackColor2 = System.Drawing.SystemColors.Control
        Appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance67.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotosDetL.DisplayLayout.GroupByBox.PromptAppearance = Appearance67
        Me.griPlanillaPilotosDetL.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaPilotosDetL.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance68.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.CellAppearance = Appearance68
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.GroupByRowAppearance = Appearance69
        Appearance70.TextHAlignAsString = "Left"
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.HeaderAppearance = Appearance70
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.RowAppearance = Appearance71
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaPilotosDetL.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaPilotosDetL.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaPilotosDetL.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaPilotosDetL.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaPilotosDetL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaPilotosDetL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaPilotosDetL.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaPilotosDetL.Name = "griPlanillaPilotosDetL"
        Me.griPlanillaPilotosDetL.Size = New System.Drawing.Size(1228, 249)
        Me.griPlanillaPilotosDetL.TabIndex = 15
        Me.griPlanillaPilotosDetL.TabStop = False
        Me.griPlanillaPilotosDetL.Text = "Grilla1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ficPlanillaViaje)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1236, 364)
        '
        'ficPlanillaViaje
        '
        Me.ficPlanillaViaje.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficPlanillaViaje.Controls.Add(Me.UltraTabPageControl5)
        Me.ficPlanillaViaje.Controls.Add(Me.UltraTabPageControl6)
        Me.ficPlanillaViaje.Controls.Add(Me.UltraTabPageControl7)
        Me.ficPlanillaViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPlanillaViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPlanillaViaje.Location = New System.Drawing.Point(0, 77)
        Me.ficPlanillaViaje.Name = "ficPlanillaViaje"
        Me.ficPlanillaViaje.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficPlanillaViaje.Size = New System.Drawing.Size(1236, 287)
        Me.ficPlanillaViaje.TabIndex = 31
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Nacional"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Pacasmayo"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Lima"
        Me.ficPlanillaViaje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab7})
        Me.ficPlanillaViaje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1234, 264)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.btnVerificar)
        Me.Agrupacion6.Controls.Add(Me.btnActualizar)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion6.Controls.Add(Me.txtPlanilla)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion6.Controls.Add(Me.Colores4)
        Me.Agrupacion6.Controls.Add(Me.btnConsolidar)
        Me.Agrupacion6.Controls.Add(Me.btnConsultar)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion6.Controls.Add(Me.fecViajeTermino)
        Me.Agrupacion6.Controls.Add(Me.fecViajeInicio)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1236, 77)
        Me.Agrupacion6.TabIndex = 30
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnVerificar
        '
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnVerificar.Appearance = Appearance72
        Me.btnVerificar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnVerificar.Location = New System.Drawing.Point(440, 42)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(96, 30)
        Me.btnVerificar.TabIndex = 44
        Me.btnVerificar.Text = "Verificar"
        '
        'btnActualizar
        '
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.btnActualizar.Appearance = Appearance73
        Me.btnActualizar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnActualizar.Location = New System.Drawing.Point(338, 42)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 30)
        Me.btnActualizar.TabIndex = 43
        Me.btnActualizar.Text = "Actualizar"
        '
        'Etiqueta8
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Red
        Me.Etiqueta8.Appearance = Appearance74
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(552, 9)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(79, 21)
        Me.Etiqueta8.TabIndex = 42
        Me.Etiqueta8.Text = "Etiqueta8"
        '
        'txtPlanilla
        '
        Me.txtPlanilla.Location = New System.Drawing.Point(6, 25)
        Me.txtPlanilla.Name = "txtPlanilla"
        Me.txtPlanilla.ReadOnly = True
        Me.txtPlanilla.Size = New System.Drawing.Size(100, 20)
        Me.txtPlanilla.TabIndex = 41
        '
        'Etiqueta7
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance75
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 6)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta7.TabIndex = 40
        Me.Etiqueta7.Text = "Planilla:"
        '
        'Etiqueta3
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance76
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(545, 50)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(86, 14)
        Me.Etiqueta3.TabIndex = 39
        Me.Etiqueta3.Text = "Rutas sin Monto:"
        '
        'Colores4
        '
        Me.Colores4.Color = System.Drawing.Color.LightCoral
        Me.Colores4.Location = New System.Drawing.Point(637, 47)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(45, 21)
        Me.Colores4.TabIndex = 38
        Me.Colores4.Text = "LightCoral"
        '
        'btnConsolidar
        '
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Appearance77.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.btnConsolidar.Appearance = Appearance77
        Me.btnConsolidar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsolidar.Location = New System.Drawing.Point(440, 6)
        Me.btnConsolidar.Name = "btnConsolidar"
        Me.btnConsolidar.Size = New System.Drawing.Size(96, 30)
        Me.btnConsolidar.TabIndex = 22
        Me.btnConsolidar.Text = "Consolidar"
        '
        'btnConsultar
        '
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance78
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(338, 6)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(96, 30)
        Me.btnConsultar.TabIndex = 21
        Me.btnConsultar.Text = "Consultar"
        '
        'Etiqueta4
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance79
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(129, 6)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Fecha Desde:"
        '
        'Etiqueta5
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance80
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(129, 35)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta5.TabIndex = 7
        Me.Etiqueta5.Text = "Fecha Hasta:"
        '
        'fecViajeTermino
        '
        Me.fecViajeTermino.Enabled = False
        Me.fecViajeTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecViajeTermino.Location = New System.Drawing.Point(207, 32)
        Me.fecViajeTermino.Name = "fecViajeTermino"
        Me.fecViajeTermino.Size = New System.Drawing.Size(96, 20)
        Me.fecViajeTermino.TabIndex = 5
        '
        'fecViajeInicio
        '
        Me.fecViajeInicio.Enabled = False
        Me.fecViajeInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecViajeInicio.Location = New System.Drawing.Point(207, 6)
        Me.fecViajeInicio.Name = "fecViajeInicio"
        Me.fecViajeInicio.Size = New System.Drawing.Size(96, 20)
        Me.fecViajeInicio.TabIndex = 4
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ficPlanillaPilotoDet)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion7)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1236, 364)
        '
        'ficPlanillaPilotoDet
        '
        Me.ficPlanillaPilotoDet.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficPlanillaPilotoDet.Controls.Add(Me.UltraTabPageControl8)
        Me.ficPlanillaPilotoDet.Controls.Add(Me.UltraTabPageControl9)
        Me.ficPlanillaPilotoDet.Controls.Add(Me.UltraTabPageControl10)
        Me.ficPlanillaPilotoDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPlanillaPilotoDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPlanillaPilotoDet.Location = New System.Drawing.Point(0, 73)
        Me.ficPlanillaPilotoDet.Name = "ficPlanillaPilotoDet"
        Me.ficPlanillaPilotoDet.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficPlanillaPilotoDet.Size = New System.Drawing.Size(1236, 291)
        Me.ficPlanillaPilotoDet.TabIndex = 36
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "RutaNacional"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Pacasmayo"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Lima"
        Me.ficPlanillaPilotoDet.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab9, UltraTab10})
        Me.ficPlanillaPilotoDet.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1234, 268)
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion7.Controls.Add(Me.numMontoTotal)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(1236, 73)
        Me.Agrupacion7.TabIndex = 35
        Me.Agrupacion7.Text = "Consolidad Pilotos"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta6
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance81
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(16, 37)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta6.TabIndex = 43
        Me.Etiqueta6.Text = "Total Planilla:"
        '
        'numMontoTotal
        '
        Appearance82.ForeColor = System.Drawing.Color.Black
        Me.numMontoTotal.Appearance = Appearance82
        Me.numMontoTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numMontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMontoTotal.ForeColor = System.Drawing.Color.Black
        Me.numMontoTotal.FormatString = "#,##0.00"
        Me.numMontoTotal.Location = New System.Drawing.Point(92, 33)
        Me.numMontoTotal.Name = "numMontoTotal"
        Me.numMontoTotal.Nullable = True
        Me.numMontoTotal.NullText = "0.00"
        Me.numMontoTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numMontoTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numMontoTotal.ReadOnly = True
        Me.numMontoTotal.Size = New System.Drawing.Size(81, 21)
        Me.numMontoTotal.TabIndex = 42
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1244, 393)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1244, 393)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.griPlanillaPilotos)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 84)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1238, 306)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.Text = "Lista"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPlanillaPilotos
        '
        Me.griPlanillaPilotos.ContextMenuStrip = Me.mnuPlanillaPiloto
        Me.griPlanillaPilotos.DataSource = Me.odPlanillaPilotos
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn12.Hidden = True
        Appearance83.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance83
        UltraGridColumn13.Format = "#,###,###,##0.00"
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn13.Header.Appearance = Appearance84
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.Width = 87
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 10
        UltraGridColumn16.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.Width = 438
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.VisiblePosition = 2
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn38.Width = 85
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn39.Width = 80
        UltraGridColumn40.Header.VisiblePosition = 12
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn15, UltraGridColumn16, UltraGridColumn26, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41})
        Me.griPlanillaPilotos.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griPlanillaPilotos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance85.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance85.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance85.BorderColor = System.Drawing.SystemColors.Window
        Me.griPlanillaPilotos.DisplayLayout.GroupByBox.Appearance = Appearance85
        Appearance86.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance86
        Me.griPlanillaPilotos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPlanillaPilotos.DisplayLayout.GroupByBox.Hidden = True
        Appearance87.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance87.BackColor2 = System.Drawing.SystemColors.Control
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance87.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPlanillaPilotos.DisplayLayout.GroupByBox.PromptAppearance = Appearance87
        Me.griPlanillaPilotos.DisplayLayout.MaxColScrollRegions = 1
        Me.griPlanillaPilotos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPlanillaPilotos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPlanillaPilotos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPlanillaPilotos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance88.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotos.DisplayLayout.Override.CellAppearance = Appearance88
        Me.griPlanillaPilotos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPlanillaPilotos.DisplayLayout.Override.CellPadding = 0
        Me.griPlanillaPilotos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPlanillaPilotos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPlanillaPilotos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPlanillaPilotos.DisplayLayout.Override.GroupByRowAppearance = Appearance89
        Appearance90.TextHAlignAsString = "Left"
        Me.griPlanillaPilotos.DisplayLayout.Override.HeaderAppearance = Appearance90
        Me.griPlanillaPilotos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance91.BorderColor = System.Drawing.Color.Silver
        Me.griPlanillaPilotos.DisplayLayout.Override.RowAppearance = Appearance91
        Me.griPlanillaPilotos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPlanillaPilotos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPlanillaPilotos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPlanillaPilotos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPlanillaPilotos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPlanillaPilotos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPlanillaPilotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPlanillaPilotos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPlanillaPilotos.Location = New System.Drawing.Point(3, 16)
        Me.griPlanillaPilotos.Name = "griPlanillaPilotos"
        Me.griPlanillaPilotos.Size = New System.Drawing.Size(1232, 287)
        Me.griPlanillaPilotos.TabIndex = 13
        Me.griPlanillaPilotos.TabStop = False
        Me.griPlanillaPilotos.Text = "Grilla1"
        '
        'mnuPlanillaPiloto
        '
        Me.mnuPlanillaPiloto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuNuevo, Me.ToolStripMenuEditar, Me.ToolStripMenuEliminar, Me.ToolStripEnviar})
        Me.mnuPlanillaPiloto.Name = "ContextMenuStrip1"
        Me.mnuPlanillaPiloto.Size = New System.Drawing.Size(118, 92)
        '
        'ToolStripMenuNuevo
        '
        Me.ToolStripMenuNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuNuevo.Name = "ToolStripMenuNuevo"
        Me.ToolStripMenuNuevo.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuNuevo.Text = "Nuevo"
        '
        'ToolStripMenuEditar
        '
        Me.ToolStripMenuEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        Me.ToolStripMenuEditar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuEditar.Text = "Editar"
        '
        'ToolStripMenuEliminar
        '
        Me.ToolStripMenuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuEliminar.Name = "ToolStripMenuEliminar"
        Me.ToolStripMenuEliminar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuEliminar.Text = "Eliminar"
        '
        'ToolStripEnviar
        '
        Me.ToolStripEnviar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.ToolStripEnviar.Name = "ToolStripEnviar"
        Me.ToolStripEnviar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripEnviar.Text = "Enviar"
        '
        'odPlanillaPilotos
        '
        UltraDataColumn50.DataType = GetType(Double)
        UltraDataColumn51.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Boolean)
        UltraDataColumn54.DataType = GetType(Date)
        UltraDataColumn55.DataType = GetType(Date)
        UltraDataColumn56.DataType = GetType(Date)
        Me.odPlanillaPilotos.Band.Columns.AddRange(New Object() {UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Agrupacion8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.fecHasta)
        Me.Agrupacion2.Controls.Add(Me.fecDesde)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1238, 81)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion8.Controls.Add(Me.Colores3)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion8.Controls.Add(Me.Colores2)
        Me.Agrupacion8.Controls.Add(Me.Colores1)
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(160, 27)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(419, 34)
        Me.Agrupacion8.TabIndex = 39
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta15
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Appearance = Appearance92
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(23, 9)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta15.TabIndex = 36
        Me.Etiqueta15.Text = "Generado:"
        '
        'Colores3
        '
        Me.Colores3.Color = System.Drawing.Color.LightGreen
        Me.Colores3.Location = New System.Drawing.Point(349, 6)
        Me.Colores3.Name = "Colores3"
        Me.Colores3.Size = New System.Drawing.Size(43, 21)
        Me.Colores3.TabIndex = 37
        Me.Colores3.Text = "LightGreen"
        '
        'Etiqueta14
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Appearance93.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Appearance = Appearance93
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(148, 9)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta14.TabIndex = 33
        Me.Etiqueta14.Text = "Consolidada:"
        '
        'Etiqueta16
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Appearance94.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Appearance = Appearance94
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(282, 9)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta16.TabIndex = 38
        Me.Etiqueta16.Text = "Enviado:"
        '
        'Colores2
        '
        Me.Colores2.Color = System.Drawing.Color.LightSteelBlue
        Me.Colores2.Location = New System.Drawing.Point(220, 6)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(43, 21)
        Me.Colores2.TabIndex = 32
        Me.Colores2.Text = "LightSteelBlue"
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.White
        Me.Colores1.Location = New System.Drawing.Point(86, 6)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(43, 21)
        Me.Colores1.TabIndex = 35
        Me.Colores1.Text = "White"
        '
        'Etiqueta2
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance95
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 49)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance96
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 24)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Desde:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(50, 46)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(104, 20)
        Me.fecHasta.TabIndex = 1
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(50, 21)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(104, 20)
        Me.fecDesde.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1244, 393)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.ficMantenimiento)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1244, 393)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficMantenimiento
        '
        Me.ficMantenimiento.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl3)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMantenimiento.Location = New System.Drawing.Point(3, 3)
        Me.ficMantenimiento.Name = "ficMantenimiento"
        Me.ficMantenimiento.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficMantenimiento.Size = New System.Drawing.Size(1238, 387)
        Me.ficMantenimiento.TabIndex = 34
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Viajes"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Consolidado"
        Me.ficMantenimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficMantenimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1236, 364)
        '
        'ficPlanillaPiloto
        '
        Me.ficPlanillaPiloto.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficPlanillaPiloto.Controls.Add(Me.UltraTabPageControl1)
        Me.ficPlanillaPiloto.Controls.Add(Me.UltraTabPageControl2)
        Me.ficPlanillaPiloto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPlanillaPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficPlanillaPiloto.Location = New System.Drawing.Point(0, 0)
        Me.ficPlanillaPiloto.Name = "ficPlanillaPiloto"
        Me.ficPlanillaPiloto.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficPlanillaPiloto.Size = New System.Drawing.Size(1246, 416)
        Me.ficPlanillaPiloto.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficPlanillaPiloto.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficPlanillaPiloto.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1244, 393)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(425, 174)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 15
        Me.ugb_Espera.Visible = False
        '
        'frm_PlanillaPiloto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 416)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficPlanillaPiloto)
        Me.Name = "frm_PlanillaPiloto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla Piloto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.griPlanillaViajesN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPlanillaViaje.ResumeLayout(False)
        CType(Me.odPlanillaViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.griPlanillaViajesP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        CType(Me.griPlanillaViajesL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.griPlanillaPilotosDetN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odPlanillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        CType(Me.griPlanillaPilotosDetP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.Agrupacion13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion13.ResumeLayout(False)
        CType(Me.griPlanillaPilotosDetL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ficPlanillaViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPlanillaViaje.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ficPlanillaPilotoDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPlanillaPilotoDet.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.numMontoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.griPlanillaPilotos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPlanillaPiloto.ResumeLayout(False)
        CType(Me.odPlanillaPilotos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMantenimiento.ResumeLayout(False)
        CType(Me.ficPlanillaPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPlanillaPiloto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficPlanillaPiloto As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents griPlanillaPilotos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Colores3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents odPlanillaViajes As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents odPlanillaDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents ficMantenimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents btnConsolidar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecViajeTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecViajeInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents numMontoTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents txtPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents odPlanillaPilotos As ISL.Controles.OrigenDatos
    Private WithEvents mnuPlanillaPiloto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripEnviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ficPlanillaViaje As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents griPlanillaViajesN As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents ficPlanillaPilotoDet As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents griPlanillaPilotosDetN As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents griPlanillaPilotosDetP As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion13 As ISL.Controles.Agrupacion
    Friend WithEvents griPlanillaPilotosDetL As ISL.Controles.Grilla
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents btnActualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griPlanillaViajesP As ISL.Controles.Grilla
    Private WithEvents mnuPlanillaViaje As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griPlanillaViajesL As ISL.Controles.Grilla
    Friend WithEvents btnVerificar As Infragistics.Win.Misc.UltraButton
End Class
