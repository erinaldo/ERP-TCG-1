<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimiento
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimiento")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorRecepciona")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RecibeBolsa")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoTotal")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EgresoTotal")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoTotal")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTransa")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTRB")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GastosRendidos")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLiquidacion")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaReembolso")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasAtrasados")
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimiento")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorRecepciona")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RecibeBolsa")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoTotal")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EgresoTotal")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoTotal")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTransa")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTRB")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GastosRendidos")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLiquidacion")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaReembolso")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasAtrasados")
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimiento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Balancin")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorRecepciona")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RecibeBolsa")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRecepcion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaBalancin")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EgresoTotal")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoTotal")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTransa")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Movimiento))
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTRB")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaDestino")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GastosRendidos")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaLiquidacion")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaReembolso")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FecSalOrigen")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FecLleDestino")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasAtrasados")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdMovimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdViaje", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ruta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ingreso", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Egreso", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Saldo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Usuario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Balancin", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTrabajadorRecepciona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "RecibeBolsa", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaRecepcion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo39 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaBalancin", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo40 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoTotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo41 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EgresoTotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo42 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SaldoTotal", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo43 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoTransa", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo44 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Glosa", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo45 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Voucher", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo46 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoTRB", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo47 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo48 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Empresa", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo49 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoDocumento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo50 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoDocumento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo51 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GastosRendidos", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo52 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaLiquidacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo53 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FechaReembolso", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo54 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FecSalOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo55 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FecLleDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo56 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo57 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Descuento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo58 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiasAtrasados", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo59 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Viaje", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimiento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Balancin")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorRecepciona")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RecibeBolsa")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaRecepcion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaBalancin")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoTotal")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EgresoTotal")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoTotal")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTransa")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTRB")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaDestino")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GastosRendidos")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaLiquidacion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaReembolso")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FecSalOrigen")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FecLleDestino")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasAtrasados")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimiento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTransa")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorCuentaCorriente")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoTotal")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EgresoTotal")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoTotal")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GastosRendidos")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorrienteO")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaOrigen")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorrienteD")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaDestino")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimiento")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTransa")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorCuentaCorriente")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoTotal")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EgresoTotal")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoTotal")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GastosRendidos")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorrienteO")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaOrigen")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorrienteD")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaDestino")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ticket")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHasta")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugar")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresado")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGuardado")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoOperacion")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLugar")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreLugar")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaISL")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroTarjeta")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ticket")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHasta")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lugar")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresado")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndGuardado")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoOperacion")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLugar")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreLugar")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaISL")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCompra")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMoneda")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn205 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn206 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn207 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn208 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn209 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn210 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn211 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn212 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn213 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn214 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn215 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn216 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn217 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn218 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn219 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn220 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn221 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrupo")
        Dim UltraDataColumn222 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCerrado")
        Dim UltraDataColumn223 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn224 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn225 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nro")
        Dim UltraDataColumn226 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn227 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn228 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn229 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn230 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn231 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDoc")
        Dim UltraDataColumn232 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn233 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn234 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn235 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn236 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn237 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn238 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn239 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn240 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn241 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn242 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn243 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn244 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn245 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn246 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn247 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn248 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn249 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroGrupo")
        Dim UltraDataColumn250 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsiento")
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txtAyudanteDescuento = New ISL.Controles.Texto(Me.components)
        Me.opcTrabajadorDescuento = New ISL.Controles.Opciones(Me.components)
        Me.txtPilotoDescuento = New ISL.Controles.Texto(Me.components)
        Me.txtCopilotoDescuento = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMovimiento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraCalcManager = New Infragistics.Win.UltraWinCalcManager.UltraCalcManager(Me.components)
        Me.MenuContextualFlete = New ISL.Controles.MenuContextual(Me.components)
        Me.MnuIngresoFlete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuIngresoFleteCta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdMovimiento = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBoxMovCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnDocumentos = New ISL.Controles.Boton(Me.components)
        Me.btnDescuento = New ISL.Controles.Boton(Me.components)
        Me.btnPrestamos = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.verGlosaDestino = New ISL.Controles.Chequear(Me.components)
        Me.verGlosaOrigen = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta60 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFecLleDestino = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta56 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFecSalOrigen = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta58 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCarga = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEstadoAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaViajeAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRutaPrestamo = New ISL.Controles.Etiqueta(Me.components)
        Me.eti = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFecha = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRutaAsociada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldoViaje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboViaje = New ISL.Controles.Combo(Me.components)
        Me.txtGlosaDestino = New ISL.Controles.Texto(Me.components)
        Me.txtGlosaOrigen = New ISL.Controles.Texto(Me.components)
        Me.fechaPrestamo = New ISL.Controles.Fecha(Me.components)
        Me.decImportePrestamo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTrabajadorPrestamo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.numCuotas = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta71 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConceptoDsct = New ISL.Controles.Combo(Me.components)
        Me.verGlosa = New ISL.Controles.Chequear(Me.components)
        Me.FicTrabajadorDescuento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage6 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.decImporteDescuento = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtGlosaDescuento = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaDescuento = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoCarga = New ISL.Controles.Texto(Me.components)
        Me.txtComisionista = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta64 = New ISL.Controles.Etiqueta(Me.components)
        Me.decComision = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta63 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCliente = New ISL.Controles.Texto(Me.components)
        Me.txtCarga = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.decMontoMaximo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta67 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMontoNormal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta66 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMontoMinimo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.opcVerPiloto = New System.Windows.Forms.RadioButton()
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.opcVerAyudante = New System.Windows.Forms.RadioButton()
        Me.opcVerCopiloto = New System.Windows.Forms.RadioButton()
        Me.opcVerOtro = New System.Windows.Forms.RadioButton()
        Me.fechaRecibidor = New ISL.Controles.Fecha(Me.components)
        Me.etiFechaRecepcion = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.decSaldoCuenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiNroChequeAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCheque = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta57 = New ISL.Controles.Etiqueta(Me.components)
        Me.decHabEfectivo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaDocumentoCompra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta65 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosaOC = New ISL.Controles.Texto(Me.components)
        Me.txt_NroOrden = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta59 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.Texto1 = New ISL.Controles.Texto(Me.components)
        Me.Texto2 = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrViajesProgramados = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MnContMovimiento = New ISL.Controles.MenuContextual(Me.components)
        Me.HabilitarBolsaDeViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmpliacionBolsaDeViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteFondoFijoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdMovimientoViaje = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMovimientoCaja = New ISL.Controles.Agrupacion(Me.components)
        Me.GriCuentaAdministrativa = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MnAdministrativo = New ISL.Controles.MenuContextual(Me.components)
        Me.HabilitarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDocumentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarGrupoFlete = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadreCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdAdministrativo = New ISL.Controles.OrigenDatos(Me.components)
        Me.expIngresoFF = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.decIngresoFF = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtGlosaFF = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecIngresoFF = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta53 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta55 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMovimientoDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.agrCuentaIzq = New ISL.Controles.Agrupacion(Me.components)
        Me.ficMovimientoDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.expGlosa = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaGlosa = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.agrSalida = New ISL.Controles.Agrupacion(Me.components)
        Me.agrDefinicion = New ISL.Controles.Agrupacion(Me.components)
        Me.FicObservacion = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage7 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrMuestraCuenta = New ISL.Controles.Agrupacion(Me.components)
        Me.agrCuentaInferior = New ISL.Controles.Agrupacion(Me.components)
        Me.btnLiquidar = New ISL.Controles.Boton(Me.components)
        Me.agrCuenta = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiGastosRendidos = New ISL.Controles.Etiqueta(Me.components)
        Me.decEgresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTotalGastos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decIngresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.agrIEFF = New ISL.Controles.Agrupacion(Me.components)
        Me.fechaMovimiento = New ISL.Controles.Fecha(Me.components)
        Me.decImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.opcSalidaEntrada = New ISL.Controles.Opciones(Me.components)
        Me.etiLiquidar = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDatosViaje = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCantidadPeajes = New ISL.Controles.NumeroDecimal(Me.components)
        Me.lblCantidadPeajes = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoVehiculo = New ISL.Controles.Texto(Me.components)
        Me.btnAgregarCostoEstiba = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta70 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCostoEstiba = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtCarreta = New ISL.Controles.Texto(Me.components)
        Me.txtAyudante = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta69 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta68 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta62 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnActPeso = New ISL.Controles.Boton(Me.components)
        Me.decPeso = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta61 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCopiloto = New ISL.Controles.Texto(Me.components)
        Me.txtTracto = New ISL.Controles.Texto(Me.components)
        Me.txtViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.fecFechaViaje = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtPiloto = New ISL.Controles.Texto(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtRuta = New ISL.Controles.Texto(Me.components)
        Me.FicDatos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.cboCaja = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.opcDefinicion = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.fechaBalancin = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.opcTipoMovimiento = New ISL.Controles.Opciones(Me.components)
        Me.ExpGroupBoxReceptor = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.upbFoto = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.picRecibidor = New System.Windows.Forms.PictureBox()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalleGasto = New ISL.Controles.Agrupacion(Me.components)
        Me.agrGastoOperacion = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griGastoOperacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.agrDatos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agrContenedor1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboLugarL = New ISL.Controles.Combo(Me.components)
        Me.expTarjetaMovimiento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griMovTarjeta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsMovimientoTarjeta = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnListar = New Infragistics.Win.Misc.UltraButton()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.expDocumento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage8 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboDocumentoAlmacen = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarDocumento = New ISL.Controles.Boton(Me.components)
        Me.gbNroDoc = New System.Windows.Forms.GroupBox()
        Me.txtSerieDoc = New ISL.Controles.Texto(Me.components)
        Me.txtNumeroDoc = New ISL.Controles.Texto(Me.components)
        Me.cboProveedores = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.fecHoraPeaje = New System.Windows.Forms.DateTimePicker()
        Me.etiRuta = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFecVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.btnNuevoProveedor = New ISL.Controles.Boton(Me.components)
        Me.ExpRegistroConsumoCombustible = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLugar = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboDireccion = New ISL.Controles.ComboMaestros(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecCantidadGalones = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboMaterial = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRuta = New ISL.Controles.Combo(Me.components)
        Me.etiTipoGasto = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRuc = New ISL.Controles.Etiqueta(Me.components)
        Me.agrTotalGasto = New ISL.Controles.Agrupacion(Me.components)
        Me.etiTotalCubrir = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalAgregado = New ISL.Controles.Etiqueta(Me.components)
        Me.numCubrir = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numAgregado = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboGrupo = New ISL.Controles.Combo(Me.components)
        Me.etiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechavencimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNroGrupo = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPeriodo = New ISL.Controles.Fecha(Me.components)
        Me.txtRUC = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.etiProveedor = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.etiGlosa = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.etiNumero = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnLimpiar = New ISL.Controles.Boton(Me.components)
        Me.btnCancelarDetalle = New ISL.Controles.Boton(Me.components)
        Me.btnAceptarDetalle = New ISL.Controles.Boton(Me.components)
        Me.txtGlosa2 = New ISL.Controles.Texto(Me.components)
        Me.etiSerie = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaDoc = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTipoDocumento = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDatoOperacion = New ISL.Controles.Agrupacion(Me.components)
        Me.cboArea = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.ChkVehiculoProper = New System.Windows.Forms.CheckBox()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAutoriza = New ISL.Controles.Combo(Me.components)
        Me.etiPlaca = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGastoFuncion = New ISL.Controles.Combo(Me.components)
        Me.etiCentroCosto = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentroCosto = New ISL.Controles.Combo(Me.components)
        Me.etiGastoFuncion = New ISL.Controles.Etiqueta(Me.components)
        Me.etiAutoriza = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador2 = New ISL.Controles.Combo(Me.components)
        Me.cboPlaca = New ISL.Controles.Combo(Me.components)
        Me.cboTipoGasto = New ISL.Controles.Combo(Me.components)
        Me.etiFlujoCaja = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAutorizaGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecPercepcion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecNoGravada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta54 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.Importe = New ISL.Controles.Etiqueta(Me.components)
        Me.etiIGV = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecPagoxCaja = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numGasto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiTipoCambio = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.etiMoneda = New ISL.Controles.Etiqueta(Me.components)
        Me.chkPagoxCaja = New System.Windows.Forms.CheckBox()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Ficha2 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage9 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.Combo4 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.Boton3 = New ISL.Controles.Boton(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Texto3 = New ISL.Controles.Texto(Me.components)
        Me.Texto4 = New ISL.Controles.Texto(Me.components)
        Me.cboOpcionGasto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboReferencia = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.AgrupacionFooter = New ISL.Controles.Agrupacion(Me.components)
        Me.ficTipoMovimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkBuscarCopiloto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboEstadoViaje = New ISL.Controles.Combo(Me.components)
        Me.etiEstado = New Infragistics.Win.Misc.UltraLabel()
        Me.agrOtrosIngresos = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalOtrosIngresos = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.txtCodViaje = New ISL.Controles.Texto(Me.components)
        Me.etitracto = New Infragistics.Win.Misc.UltraLabel()
        Me.agrTotalFF = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalFF = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTrabajadorMovimiento = New ISL.Controles.Combo(Me.components)
        Me.etiTrabajadorCuenta = New ISL.Controles.Etiqueta(Me.components)
        Me.agrVales = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalVales = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiViaje = New Infragistics.Win.Misc.UltraLabel()
        Me.agrGastosAdm = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.decGastosAdm = New ISL.Controles.NumeroDecimal(Me.components)
        Me.chkViajeVacio = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.agrSaldo = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.decSaldoCuentaAdm = New ISL.Controles.NumeroDecimal(Me.components)
        Me.btnReporteFondoFijo = New ISL.Controles.Boton(Me.components)
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorReembolsado = New ISL.Controles.Colores(Me.components)
        Me.ColorPendiente = New ISL.Controles.Colores(Me.components)
        Me.ColorHabilitada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorLiquidada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorNoReembolsado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficMovimientoViaje = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.CalendarioInfo = New Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(Me.components)
        Me.CalendarioVista = New Infragistics.Win.UltraWinSchedule.UltraCalendarLook(Me.components)
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.etiTotalGasto = New ISL.Controles.Etiqueta(Me.components)
        Me.MnuFleteAdm = New ISL.Controles.MenuContextual(Me.components)
        Me.MnuCargarFleteAdmn = New System.Windows.Forms.ToolStripMenuItem()
        Me.orgCuentaCorriente = New ISL.Controles.OrigenDatos(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Combo1 = New ISL.Controles.Combo(Me.components)
        Me.Combo2 = New ISL.Controles.Combo(Me.components)
        Me.Combo3 = New ISL.Controles.Combo(Me.components)
        Me.UltraMonthViewMulti1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.UltraMonthViewMulti2 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.Chequear1 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear2 = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.Chequear3 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear4 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear5 = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Chequear6 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear7 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear8 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear9 = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.Chequear10 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear11 = New ISL.Controles.Chequear(Me.components)
        Me.Chequear12 = New ISL.Controles.Chequear(Me.components)
        Me.UltraMonthViewMulti3 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.Boton2 = New ISL.Controles.Boton(Me.components)
        Me.ogdGastoOperacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.ficMovimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTip = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl12.SuspendLayout
        CType(Me.txtAyudanteDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcTrabajadorDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPilotoDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCopilotoDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl5.SuspendLayout
        CType(Me.griMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraCalcManager, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuContextualFlete.SuspendLayout
        CType(Me.ogdMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBoxMovCuenta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBoxMovCuenta.SuspendLayout
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion8.SuspendLayout
        Me.UltraTabPageControl6.SuspendLayout
        CType(Me.verGlosaDestino, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verGlosaOrigen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion1.SuspendLayout
        CType(Me.decSaldoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaDestino, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaOrigen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fechaPrestamo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decImportePrestamo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTrabajadorPrestamo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl7.SuspendLayout
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboConceptoDsct, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.verGlosa, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FicTrabajadorDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FicTrabajadorDescuento.SuspendLayout
        CType(Me.decImporteDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fecFechaDescuento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl15.SuspendLayout
        CType(Me.txtTipoCarga, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtComisionista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decComision, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCarga, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl14.SuspendLayout
        CType(Me.decMontoMaximo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decMontoNormal, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decMontoMinimo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl10.SuspendLayout
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fechaRecibidor, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl11.SuspendLayout
        CType(Me.decSaldoCuenta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl17.SuspendLayout
        CType(Me.decHabEfectivo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl18.SuspendLayout
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl19.SuspendLayout
        CType(Me.txtGlosaOC, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt_NroOrden, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl13.SuspendLayout
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl16.SuspendLayout
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Texto2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl8.SuspendLayout
        CType(Me.agrViajesProgramados, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrViajesProgramados.SuspendLayout
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MnContMovimiento.SuspendLayout
        CType(Me.ogdMovimientoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl9.SuspendLayout
        CType(Me.agrMovimientoCaja, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrMovimientoCaja.SuspendLayout
        CType(Me.GriCuentaAdministrativa, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MnAdministrativo.SuspendLayout
        CType(Me.ogdAdministrativo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expIngresoFF, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expIngresoFF.SuspendLayout
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion10.SuspendLayout
        CType(Me.decIngresoFF, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosaFF, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fecIngresoFF, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl3.SuspendLayout
        CType(Me.agrMovimientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrMovimientoDetalle.SuspendLayout
        CType(Me.agrCuentaIzq, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrCuentaIzq.SuspendLayout
        CType(Me.ficMovimientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficMovimientoDetalle.SuspendLayout
        CType(Me.expGlosa, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expGlosa.SuspendLayout
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrSalida, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrSalida.SuspendLayout
        CType(Me.agrDefinicion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDefinicion.SuspendLayout
        CType(Me.FicObservacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FicObservacion.SuspendLayout
        CType(Me.agrMuestraCuenta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrMuestraCuenta.SuspendLayout
        CType(Me.agrCuentaInferior, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrCuentaInferior.SuspendLayout
        CType(Me.agrCuenta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrCuenta.SuspendLayout
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decEgresos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decTotalGastos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decIngresos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrIEFF, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrIEFF.SuspendLayout
        CType(Me.fechaMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decImporte, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcSalidaEntrada, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrDatosViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDatosViaje.SuspendLayout
        CType(Me.txtCantidadPeajes, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numCostoEstiba, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCarreta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAyudante, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decPeso, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCopiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fecFechaViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRuta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FicDatos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FicDatos.SuspendLayout
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcDefinicion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fechaBalancin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ExpGroupBoxReceptor, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ExpGroupBoxReceptor.SuspendLayout
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout
        CType(Me.picRecibidor, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl4.SuspendLayout
        CType(Me.agrDetalleGasto, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDetalleGasto.SuspendLayout
        CType(Me.agrGastoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrGastoOperacion.SuspendLayout
        CType(Me.griGastoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDatos.SuspendLayout
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout
        CType(Me.agrContenedor1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrContenedor1.SuspendLayout
        CType(Me.cboLugarL, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expTarjetaMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expTarjetaMovimiento.SuspendLayout
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout
        CType(Me.griMovTarjeta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.udsMovimientoTarjeta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraGroupBox1.SuspendLayout
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.expDocumento.SuspendLayout
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Ficha1.SuspendLayout
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion9.SuspendLayout
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbNroDoc.SuspendLayout
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ExpRegistroConsumoCombustible, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ExpRegistroConsumoCombustible.SuspendLayout
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion4.SuspendLayout
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion2.SuspendLayout
        CType(Me.DecCantidadGalones, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrTotalGasto, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrTotalGasto.SuspendLayout
        CType(Me.numCubrir, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numAgregado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion3.SuspendLayout
        CType(Me.txtGlosa2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrDatoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDatoOperacion.SuspendLayout
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAutoriza, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTrabajador2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboAutorizaGasto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DecPercepcion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DecNoGravada, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numIGV, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DecPagoxCaja, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numGasto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox1.SuspendLayout
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Ficha2.SuspendLayout
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion11.SuspendLayout
        CType(Me.Combo4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.Texto3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Texto4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboOpcionGasto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboReferencia, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl1.SuspendLayout
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrListaRegistro.SuspendLayout
        CType(Me.AgrupacionFooter, System.ComponentModel.ISupportInitialize).BeginInit
        Me.AgrupacionFooter.SuspendLayout
        CType(Me.ficTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficTipoMovimiento.SuspendLayout
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrBusqueda.SuspendLayout
        CType(Me.chkBuscarCopiloto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboEstadoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrOtrosIngresos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrOtrosIngresos.SuspendLayout
        CType(Me.decTotalOtrosIngresos, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCodViaje, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrTotalFF, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrTotalFF.SuspendLayout
        CType(Me.decTotalFF, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboTrabajadorMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrVales, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrVales.SuspendLayout
        CType(Me.decTotalVales, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrGastosAdm, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrGastosAdm.SuspendLayout
        CType(Me.decGastosAdm, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkViajeVacio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrSaldo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrSaldo.SuspendLayout
        CType(Me.decSaldoCuentaAdm, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.grupoEstado.SuspendLayout
        CType(Me.ColorReembolsado, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorHabilitada, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorLiquidada, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ColorNoReembolsado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl2.SuspendLayout
        CType(Me.ficMovimientoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficMovimientoViaje.SuspendLayout
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.MnuFleteAdm.SuspendLayout
        CType(Me.orgCuentaCorriente, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraExpandableGroupBox2.SuspendLayout
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout
        CType(Me.Combo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Combo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Combo3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraMonthViewMulti2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion5.SuspendLayout
        CType(Me.Chequear3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion6.SuspendLayout
        CType(Me.Chequear6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion7.SuspendLayout
        CType(Me.Chequear10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Chequear12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraMonthViewMulti3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdGastoOperacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ficMovimiento, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficMovimiento.SuspendLayout
        Me.SuspendLayout
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.txtAyudanteDescuento)
        Me.UltraTabPageControl12.Controls.Add(Me.opcTrabajadorDescuento)
        Me.UltraTabPageControl12.Controls.Add(Me.txtPilotoDescuento)
        Me.UltraTabPageControl12.Controls.Add(Me.txtCopilotoDescuento)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(361, 76)
        '
        'txtAyudanteDescuento
        '
        Me.txtAyudanteDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAyudanteDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAyudanteDescuento.Enabled = False
        Me.txtAyudanteDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAyudanteDescuento.Location = New System.Drawing.Point(76, 49)
        Me.txtAyudanteDescuento.Name = "txtAyudanteDescuento"
        Me.txtAyudanteDescuento.Size = New System.Drawing.Size(279, 22)
        Me.txtAyudanteDescuento.TabIndex = 112
        '
        'opcTrabajadorDescuento
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.opcTrabajadorDescuento.Appearance = Appearance1
        Me.opcTrabajadorDescuento.BackColor = System.Drawing.Color.Transparent
        Me.opcTrabajadorDescuento.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcTrabajadorDescuento.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcTrabajadorDescuento.CheckedIndex = 0
        Me.opcTrabajadorDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcTrabajadorDescuento.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "Piloto"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Copiloto"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "Ayudante"
        Me.opcTrabajadorDescuento.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.opcTrabajadorDescuento.ItemSpacingVertical = 8
        Me.opcTrabajadorDescuento.Location = New System.Drawing.Point(3, 3)
        Me.opcTrabajadorDescuento.Name = "opcTrabajadorDescuento"
        Me.opcTrabajadorDescuento.Size = New System.Drawing.Size(70, 70)
        Me.opcTrabajadorDescuento.TabIndex = 111
        Me.opcTrabajadorDescuento.Text = "Piloto"
        '
        'txtPilotoDescuento
        '
        Me.txtPilotoDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPilotoDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPilotoDescuento.Enabled = False
        Me.txtPilotoDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPilotoDescuento.Location = New System.Drawing.Point(76, 3)
        Me.txtPilotoDescuento.Name = "txtPilotoDescuento"
        Me.txtPilotoDescuento.Size = New System.Drawing.Size(279, 22)
        Me.txtPilotoDescuento.TabIndex = 103
        '
        'txtCopilotoDescuento
        '
        Me.txtCopilotoDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCopilotoDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCopilotoDescuento.Enabled = False
        Me.txtCopilotoDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopilotoDescuento.Location = New System.Drawing.Point(76, 26)
        Me.txtCopilotoDescuento.Name = "txtCopilotoDescuento"
        Me.txtCopilotoDescuento.Size = New System.Drawing.Size(279, 22)
        Me.txtCopilotoDescuento.TabIndex = 103
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griMovimiento)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraExpandableGroupBoxMovCuenta)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1141, 300)
        '
        'griMovimiento
        '
        Me.griMovimiento.CalcManager = Me.UltraCalcManager
        Me.griMovimiento.ContextMenuStrip = Me.MenuContextualFlete
        Me.griMovimiento.DataSource = Me.ogdMovimiento
        Appearance232.BackColor = System.Drawing.SystemColors.Window
        Appearance232.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griMovimiento.DisplayLayout.Appearance = Appearance232
        UltraGridColumn122.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn122.Header.VisiblePosition = 0
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn123.Header.VisiblePosition = 1
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn124.Header.VisiblePosition = 2
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn125.Header.VisiblePosition = 6
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn126.Header.VisiblePosition = 7
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn127.Header.VisiblePosition = 9
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn128.Header.VisiblePosition = 10
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.VisiblePosition = 11
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn130.Header.VisiblePosition = 12
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn131.Header.VisiblePosition = 13
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn132.Header.VisiblePosition = 14
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn133.Header.VisiblePosition = 15
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn134.Header.VisiblePosition = 16
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn135.Header.VisiblePosition = 3
        UltraGridColumn135.Width = 60
        UltraGridColumn136.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn136.Header.VisiblePosition = 17
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn137.Header.VisiblePosition = 18
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn138.Header.VisiblePosition = 19
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn139.Header.VisiblePosition = 20
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn140.Header.VisiblePosition = 21
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn141.Header.VisiblePosition = 22
        UltraGridColumn141.Hidden = True
        Appearance233.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance233.TextHAlignAsString = "Right"
        UltraGridColumn142.CellAppearance = Appearance233
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn142.Header.VisiblePosition = 23
        Appearance234.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance234.TextHAlignAsString = "Right"
        UltraGridColumn143.CellAppearance = Appearance234
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn143.Header.VisiblePosition = 24
        Appearance235.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance235.TextHAlignAsString = "Right"
        UltraGridColumn144.CellAppearance = Appearance235
        UltraGridColumn144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn144.Header.Caption = "Otros"
        UltraGridColumn144.Header.VisiblePosition = 25
        UltraGridColumn145.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn145.Header.VisiblePosition = 26
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn146.Header.VisiblePosition = 27
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn147.Header.VisiblePosition = 28
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn148.Header.VisiblePosition = 29
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn149.Header.VisiblePosition = 30
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn150.Header.VisiblePosition = 31
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn151.Header.VisiblePosition = 32
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn152.Header.VisiblePosition = 33
        UltraGridColumn152.Hidden = True
        Appearance236.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn153.CellAppearance = Appearance236
        UltraGridColumn153.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn153.Header.VisiblePosition = 8
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn154.Header.VisiblePosition = 34
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn155.Header.VisiblePosition = 35
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn156.Header.VisiblePosition = 39
        UltraGridColumn156.Width = 245
        UltraGridColumn157.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn157.Header.VisiblePosition = 37
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn158.Header.VisiblePosition = 40
        UltraGridColumn158.Width = 247
        UltraGridColumn159.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn159.Header.VisiblePosition = 41
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn160.Header.VisiblePosition = 42
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn161.Header.VisiblePosition = 43
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn162.Header.VisiblePosition = 44
        UltraGridColumn162.Hidden = True
        Appearance237.Image = CType(resources.GetObject("Appearance237.Image"), Object)
        Appearance237.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn163.CellAppearance = Appearance237
        Appearance238.Image = CType(resources.GetObject("Appearance238.Image"), Object)
        UltraGridColumn163.CellButtonAppearance = Appearance238
        UltraGridColumn163.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn163.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn163.Header.ToolTipText = "Modificar Glosa"
        UltraGridColumn163.Header.VisiblePosition = 5
        UltraGridColumn163.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn163.Width = 453
        UltraGridColumn164.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn164.Header.VisiblePosition = 4
        UltraGridColumn164.Hidden = True
        UltraGridColumn164.Width = 118
        UltraGridColumn181.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn181.Header.VisiblePosition = 45
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn182.Header.VisiblePosition = 36
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn183.Header.VisiblePosition = 46
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn184.Header.VisiblePosition = 47
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn185.Header.VisiblePosition = 48
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn186.Header.VisiblePosition = 49
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 50
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 51
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 52
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn190.Header.VisiblePosition = 38
        UltraGridColumn190.Width = 157
        UltraGridColumn226.Header.VisiblePosition = 53
        UltraGridColumn226.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn226})
        UltraGridBand7.SummaryFooterCaption = "Totales"
        Me.griMovimiento.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griMovimiento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMovimiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance239.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance239.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance239.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance239.BorderColor = System.Drawing.SystemColors.Window
        Me.griMovimiento.DisplayLayout.GroupByBox.Appearance = Appearance239
        Appearance240.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMovimiento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance240
        Me.griMovimiento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMovimiento.DisplayLayout.GroupByBox.Hidden = True
        Appearance241.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance241.BackColor2 = System.Drawing.SystemColors.Control
        Appearance241.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance241.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMovimiento.DisplayLayout.GroupByBox.PromptAppearance = Appearance241
        Me.griMovimiento.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimiento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMovimiento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimiento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovimiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griMovimiento.DisplayLayout.Override.CellPadding = 0
        Me.griMovimiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance242.BackColor = System.Drawing.SystemColors.Window
        Appearance242.BorderColor = System.Drawing.Color.Silver
        Me.griMovimiento.DisplayLayout.Override.RowAppearance = Appearance242
        Me.griMovimiento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimiento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimiento.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.griMovimiento.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.griMovimiento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMovimiento.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griMovimiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMovimiento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMovimiento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimiento.Location = New System.Drawing.Point(119, 0)
        Me.griMovimiento.Name = "griMovimiento"
        Me.griMovimiento.Size = New System.Drawing.Size(1022, 300)
        Me.griMovimiento.TabIndex = 0
        Me.griMovimiento.TabStop = False
        Me.griMovimiento.Text = "Grilla1"
        '
        'UltraCalcManager
        '
        Me.UltraCalcManager.ContainingControl = Me
        '
        'MenuContextualFlete
        '
        Me.MenuContextualFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextualFlete.ForeColor = System.Drawing.Color.Black
        Me.MenuContextualFlete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuIngresoFlete, Me.MnuIngresoFleteCta})
        Me.MenuContextualFlete.Name = "MenuContextual1"
        Me.MenuContextualFlete.Size = New System.Drawing.Size(182, 48)
        '
        'MnuIngresoFlete
        '
        Me.MnuIngresoFlete.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.MnuIngresoFlete.Name = "MnuIngresoFlete"
        Me.MnuIngresoFlete.Size = New System.Drawing.Size(181, 22)
        Me.MnuIngresoFlete.Text = "Ingreso Flete a FF"
        '
        'MnuIngresoFleteCta
        '
        Me.MnuIngresoFleteCta.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.MnuIngresoFleteCta.Name = "MnuIngresoFleteCta"
        Me.MnuIngresoFleteCta.Size = New System.Drawing.Size(181, 22)
        Me.MnuIngresoFleteCta.Text = "Ingreso Flete a Cuenta"
        '
        'ogdMovimiento
        '
        UltraDataColumn120.DataType = GetType(Date)
        UltraDataColumn127.DataType = GetType(Double)
        UltraDataColumn128.DataType = GetType(Double)
        UltraDataColumn129.DataType = GetType(Double)
        UltraDataColumn139.DataType = GetType(Boolean)
        UltraDataColumn144.DataType = GetType(Date)
        UltraDataColumn157.DataType = GetType(Date)
        UltraDataColumn158.DataType = GetType(Date)
        UltraDataColumn160.DataType = GetType(Short)
        Me.ogdMovimiento.Band.Columns.AddRange(New Object() {UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160})
        '
        'UltraExpandableGroupBoxMovCuenta
        '
        Me.UltraExpandableGroupBoxMovCuenta.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Me.UltraExpandableGroupBoxMovCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBoxMovCuenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBoxMovCuenta.ExpandedSize = New System.Drawing.Size(119, 300)
        Me.UltraExpandableGroupBoxMovCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBoxMovCuenta.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBoxMovCuenta.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBoxMovCuenta.Name = "UltraExpandableGroupBoxMovCuenta"
        Me.UltraExpandableGroupBoxMovCuenta.Size = New System.Drawing.Size(119, 300)
        Me.UltraExpandableGroupBoxMovCuenta.TabIndex = 1
        Me.UltraExpandableGroupBoxMovCuenta.Text = "Movimiento - Opciones"
        Me.UltraExpandableGroupBoxMovCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion8)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(96, 294)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.btnDocumentos)
        Me.Agrupacion8.Controls.Add(Me.btnDescuento)
        Me.Agrupacion8.Controls.Add(Me.btnPrestamos)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(96, 294)
        Me.Agrupacion8.TabIndex = 2
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnDocumentos
        '
        Appearance243.ForeColor = System.Drawing.Color.Navy
        Appearance243.TextHAlignAsString = "Left"
        Me.btnDocumentos.Appearance = Appearance243
        Me.btnDocumentos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentos.ForeColor = System.Drawing.Color.Black
        Me.btnDocumentos.Location = New System.Drawing.Point(6, 6)
        Me.btnDocumentos.Name = "btnDocumentos"
        Me.btnDocumentos.Size = New System.Drawing.Size(80, 25)
        Me.btnDocumentos.TabIndex = 1
        Me.btnDocumentos.Text = "Documentos"
        '
        'btnDescuento
        '
        Appearance244.ForeColor = System.Drawing.Color.Navy
        Appearance244.TextHAlignAsString = "Left"
        Me.btnDescuento.Appearance = Appearance244
        Me.btnDescuento.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuento.ForeColor = System.Drawing.Color.Black
        Me.btnDescuento.Location = New System.Drawing.Point(6, 68)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(80, 25)
        Me.btnDescuento.TabIndex = 1
        Me.btnDescuento.Text = "Descuentos"
        '
        'btnPrestamos
        '
        Appearance245.ForeColor = System.Drawing.Color.Navy
        Appearance245.TextHAlignAsString = "Left"
        Me.btnPrestamos.Appearance = Appearance245
        Me.btnPrestamos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrestamos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestamos.ForeColor = System.Drawing.Color.Black
        Me.btnPrestamos.Location = New System.Drawing.Point(6, 37)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(80, 25)
        Me.btnPrestamos.TabIndex = 1
        Me.btnPrestamos.Text = "Prestamos"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.verGlosaDestino)
        Me.UltraTabPageControl6.Controls.Add(Me.verGlosaOrigen)
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl6.Controls.Add(Me.txtGlosaDestino)
        Me.UltraTabPageControl6.Controls.Add(Me.txtGlosaOrigen)
        Me.UltraTabPageControl6.Controls.Add(Me.fechaPrestamo)
        Me.UltraTabPageControl6.Controls.Add(Me.decImportePrestamo)
        Me.UltraTabPageControl6.Controls.Add(Me.cboTrabajadorPrestamo)
        Me.UltraTabPageControl6.Controls.Add(Me.Etiqueta16)
        Me.UltraTabPageControl6.Controls.Add(Me.Etiqueta17)
        Me.UltraTabPageControl6.Controls.Add(Me.Etiqueta18)
        Me.UltraTabPageControl6.Controls.Add(Me.Etiqueta21)
        Me.UltraTabPageControl6.Controls.Add(Me.Etiqueta23)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1141, 300)
        '
        'verGlosaDestino
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.verGlosaDestino.Appearance = Appearance46
        Me.verGlosaDestino.BackColor = System.Drawing.Color.Transparent
        Me.verGlosaDestino.BackColorInternal = System.Drawing.Color.Transparent
        Me.verGlosaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verGlosaDestino.ForeColor = System.Drawing.Color.Black
        Me.verGlosaDestino.Location = New System.Drawing.Point(657, 170)
        Me.verGlosaDestino.Name = "verGlosaDestino"
        Me.verGlosaDestino.Size = New System.Drawing.Size(120, 20)
        Me.verGlosaDestino.TabIndex = 99
        Me.verGlosaDestino.Text = "Glosa Destino >>"
        '
        'verGlosaOrigen
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.verGlosaOrigen.Appearance = Appearance47
        Me.verGlosaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.verGlosaOrigen.BackColorInternal = System.Drawing.Color.Transparent
        Me.verGlosaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verGlosaOrigen.ForeColor = System.Drawing.Color.Black
        Me.verGlosaOrigen.Location = New System.Drawing.Point(658, 95)
        Me.verGlosaOrigen.Name = "verGlosaOrigen"
        Me.verGlosaOrigen.Size = New System.Drawing.Size(120, 20)
        Me.verGlosaOrigen.TabIndex = 99
        Me.verGlosaOrigen.Text = "Glosa Origen >>"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta60)
        Me.Agrupacion1.Controls.Add(Me.etiFecLleDestino)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta56)
        Me.Agrupacion1.Controls.Add(Me.etiFecSalOrigen)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta58)
        Me.Agrupacion1.Controls.Add(Me.etiCarga)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion1.Controls.Add(Me.etiEstadoAsociado)
        Me.Agrupacion1.Controls.Add(Me.etiFechaViajeAsociado)
        Me.Agrupacion1.Controls.Add(Me.etiRutaPrestamo)
        Me.Agrupacion1.Controls.Add(Me.eti)
        Me.Agrupacion1.Controls.Add(Me.etiFecha)
        Me.Agrupacion1.Controls.Add(Me.etiRutaAsociada)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.decSaldoViaje)
        Me.Agrupacion1.Controls.Add(Me.cboViaje)
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(5, 28)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(320, 204)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Datos Viaje Asociado"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta60
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta60.Appearance = Appearance48
        Me.Etiqueta60.AutoSize = True
        Me.Etiqueta60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta60.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta60.Location = New System.Drawing.Point(11, 179)
        Me.Etiqueta60.Name = "Etiqueta60"
        Me.Etiqueta60.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta60.TabIndex = 112
        Me.Etiqueta60.Text = "FecLleDestino"
        '
        'etiFecLleDestino
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.etiFecLleDestino.Appearance = Appearance49
        Me.etiFecLleDestino.AutoSize = True
        Me.etiFecLleDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecLleDestino.ForeColor = System.Drawing.Color.Black
        Me.etiFecLleDestino.Location = New System.Drawing.Point(101, 179)
        Me.etiFecLleDestino.Name = "etiFecLleDestino"
        Me.etiFecLleDestino.Size = New System.Drawing.Size(0, 0)
        Me.etiFecLleDestino.TabIndex = 111
        '
        'Etiqueta56
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta56.Appearance = Appearance50
        Me.Etiqueta56.AutoSize = True
        Me.Etiqueta56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta56.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta56.Location = New System.Drawing.Point(14, 158)
        Me.Etiqueta56.Name = "Etiqueta56"
        Me.Etiqueta56.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta56.TabIndex = 110
        Me.Etiqueta56.Text = "FecSalOrigen"
        '
        'etiFecSalOrigen
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.etiFecSalOrigen.Appearance = Appearance51
        Me.etiFecSalOrigen.AutoSize = True
        Me.etiFecSalOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecSalOrigen.ForeColor = System.Drawing.Color.Black
        Me.etiFecSalOrigen.Location = New System.Drawing.Point(101, 158)
        Me.etiFecSalOrigen.Name = "etiFecSalOrigen"
        Me.etiFecSalOrigen.Size = New System.Drawing.Size(0, 0)
        Me.etiFecSalOrigen.TabIndex = 109
        '
        'Etiqueta58
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta58.Appearance = Appearance52
        Me.Etiqueta58.AutoSize = True
        Me.Etiqueta58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta58.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta58.Location = New System.Drawing.Point(51, 136)
        Me.Etiqueta58.Name = "Etiqueta58"
        Me.Etiqueta58.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta58.TabIndex = 108
        Me.Etiqueta58.Text = "Carga"
        '
        'etiCarga
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.etiCarga.Appearance = Appearance53
        Me.etiCarga.AutoSize = True
        Me.etiCarga.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCarga.ForeColor = System.Drawing.Color.Black
        Me.etiCarga.Location = New System.Drawing.Point(101, 138)
        Me.etiCarga.Name = "etiCarga"
        Me.etiCarga.Size = New System.Drawing.Size(0, 0)
        Me.etiCarga.TabIndex = 107
        '
        'Etiqueta20
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance54
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(6, 25)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(76, 15)
        Me.Etiqueta20.TabIndex = 99
        Me.Etiqueta20.Text = "Viaje Asociado"
        '
        'etiEstadoAsociado
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.etiEstadoAsociado.Appearance = Appearance55
        Me.etiEstadoAsociado.AutoSize = True
        Me.etiEstadoAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstadoAsociado.ForeColor = System.Drawing.Color.Black
        Me.etiEstadoAsociado.Location = New System.Drawing.Point(99, 89)
        Me.etiEstadoAsociado.Name = "etiEstadoAsociado"
        Me.etiEstadoAsociado.Size = New System.Drawing.Size(0, 0)
        Me.etiEstadoAsociado.TabIndex = 100
        '
        'etiFechaViajeAsociado
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaViajeAsociado.Appearance = Appearance56
        Me.etiFechaViajeAsociado.AutoSize = True
        Me.etiFechaViajeAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaViajeAsociado.ForeColor = System.Drawing.Color.Black
        Me.etiFechaViajeAsociado.Location = New System.Drawing.Point(99, 70)
        Me.etiFechaViajeAsociado.Name = "etiFechaViajeAsociado"
        Me.etiFechaViajeAsociado.Size = New System.Drawing.Size(0, 0)
        Me.etiFechaViajeAsociado.TabIndex = 100
        '
        'etiRutaPrestamo
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.etiRutaPrestamo.Appearance = Appearance57
        Me.etiRutaPrestamo.AutoSize = True
        Me.etiRutaPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRutaPrestamo.ForeColor = System.Drawing.Color.Black
        Me.etiRutaPrestamo.Location = New System.Drawing.Point(99, 50)
        Me.etiRutaPrestamo.Name = "etiRutaPrestamo"
        Me.etiRutaPrestamo.Size = New System.Drawing.Size(0, 0)
        Me.etiRutaPrestamo.TabIndex = 100
        '
        'eti
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.eti.Appearance = Appearance58
        Me.eti.AutoSize = True
        Me.eti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eti.ForeColor = System.Drawing.Color.Black
        Me.eti.Location = New System.Drawing.Point(45, 89)
        Me.eti.Name = "eti"
        Me.eti.Size = New System.Drawing.Size(38, 15)
        Me.eti.TabIndex = 100
        Me.eti.Text = "Estado"
        '
        'etiFecha
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.etiFecha.Appearance = Appearance59
        Me.etiFecha.AutoSize = True
        Me.etiFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFecha.ForeColor = System.Drawing.Color.Black
        Me.etiFecha.Location = New System.Drawing.Point(48, 70)
        Me.etiFecha.Name = "etiFecha"
        Me.etiFecha.Size = New System.Drawing.Size(34, 15)
        Me.etiFecha.TabIndex = 100
        Me.etiFecha.Text = "Fecha"
        '
        'etiRutaAsociada
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.etiRutaAsociada.Appearance = Appearance60
        Me.etiRutaAsociada.AutoSize = True
        Me.etiRutaAsociada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRutaAsociada.ForeColor = System.Drawing.Color.Black
        Me.etiRutaAsociada.Location = New System.Drawing.Point(56, 50)
        Me.etiRutaAsociada.Name = "etiRutaAsociada"
        Me.etiRutaAsociada.Size = New System.Drawing.Size(27, 15)
        Me.etiRutaAsociada.TabIndex = 100
        Me.etiRutaAsociada.Text = "Ruta"
        '
        'Etiqueta4
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance61
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(5, 109)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta4.TabIndex = 101
        Me.Etiqueta4.Text = "Saldo Asociado"
        '
        'decSaldoViaje
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.decSaldoViaje.Appearance = Appearance62
        Me.decSaldoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoViaje.ForeColor = System.Drawing.Color.Black
        Me.decSaldoViaje.Location = New System.Drawing.Point(99, 105)
        Me.decSaldoViaje.MaskInput = "{double:9.2}"
        Me.decSaldoViaje.Name = "decSaldoViaje"
        Me.decSaldoViaje.NullText = "0.00"
        Me.decSaldoViaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoViaje.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoViaje.ReadOnly = True
        Me.decSaldoViaje.Size = New System.Drawing.Size(114, 22)
        Me.decSaldoViaje.TabIndex = 104
        '
        'cboViaje
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Appearance = Appearance63
        Me.cboViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboViaje.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViaje.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Location = New System.Drawing.Point(99, 21)
        Me.cboViaje.Name = "cboViaje"
        Me.cboViaje.Size = New System.Drawing.Size(202, 22)
        Me.cboViaje.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboViaje.TabIndex = 1
        Me.cboViaje.ValueMember = "Id"
        '
        'txtGlosaDestino
        '
        Me.txtGlosaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaDestino.Location = New System.Drawing.Point(409, 117)
        Me.txtGlosaDestino.Multiline = True
        Me.txtGlosaDestino.Name = "txtGlosaDestino"
        Me.txtGlosaDestino.Size = New System.Drawing.Size(247, 71)
        Me.txtGlosaDestino.TabIndex = 5
        '
        'txtGlosaOrigen
        '
        Me.txtGlosaOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaOrigen.Location = New System.Drawing.Point(409, 28)
        Me.txtGlosaOrigen.Multiline = True
        Me.txtGlosaOrigen.Name = "txtGlosaOrigen"
        Me.txtGlosaOrigen.Size = New System.Drawing.Size(247, 84)
        Me.txtGlosaOrigen.TabIndex = 4
        '
        'fechaPrestamo
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.fechaPrestamo.Appearance = Appearance64
        Me.fechaPrestamo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fechaPrestamo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaPrestamo.ForeColor = System.Drawing.Color.Black
        Me.fechaPrestamo.Location = New System.Drawing.Point(556, 4)
        Me.fechaPrestamo.Name = "fechaPrestamo"
        Me.fechaPrestamo.ReadOnly = True
        Me.fechaPrestamo.Size = New System.Drawing.Size(100, 22)
        Me.fechaPrestamo.TabIndex = 3
        '
        'decImportePrestamo
        '
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance65.ForeColor = System.Drawing.Color.Black
        Me.decImportePrestamo.Appearance = Appearance65
        Me.decImportePrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decImportePrestamo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImportePrestamo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImportePrestamo.ForeColor = System.Drawing.Color.Black
        Me.decImportePrestamo.Location = New System.Drawing.Point(409, 4)
        Me.decImportePrestamo.MaskInput = "{double:9.2}"
        Me.decImportePrestamo.Name = "decImportePrestamo"
        Me.decImportePrestamo.Nullable = True
        Me.decImportePrestamo.NullText = "0.00"
        Me.decImportePrestamo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImportePrestamo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImportePrestamo.Size = New System.Drawing.Size(100, 22)
        Me.decImportePrestamo.TabIndex = 2
        '
        'cboTrabajadorPrestamo
        '
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorPrestamo.Appearance = Appearance66
        Me.cboTrabajadorPrestamo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadorPrestamo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorPrestamo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorPrestamo.Location = New System.Drawing.Point(46, 4)
        Me.cboTrabajadorPrestamo.Name = "cboTrabajadorPrestamo"
        Me.cboTrabajadorPrestamo.Size = New System.Drawing.Size(279, 21)
        Me.cboTrabajadorPrestamo.TabIndex = 0
        Me.cboTrabajadorPrestamo.ValueMember = "Id"
        '
        'Etiqueta16
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance67
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(330, 119)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta16.TabIndex = 95
        Me.Etiqueta16.Text = "Glosa Destino"
        '
        'Etiqueta17
        '
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance68
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(515, 7)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta17.TabIndex = 94
        Me.Etiqueta17.Text = "Fecha"
        '
        'Etiqueta18
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance69
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(335, 30)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta18.TabIndex = 97
        Me.Etiqueta18.Text = "Glosa Origen"
        '
        'Etiqueta21
        '
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance70
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(359, 8)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta21.TabIndex = 98
        Me.Etiqueta21.Text = "Importe"
        '
        'Etiqueta23
        '
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance71
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(8, 8)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta23.TabIndex = 96
        Me.Etiqueta23.Text = "Piloto"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.numCuotas)
        Me.UltraTabPageControl7.Controls.Add(Me.Etiqueta71)
        Me.UltraTabPageControl7.Controls.Add(Me.Etiqueta49)
        Me.UltraTabPageControl7.Controls.Add(Me.cboConceptoDsct)
        Me.UltraTabPageControl7.Controls.Add(Me.verGlosa)
        Me.UltraTabPageControl7.Controls.Add(Me.FicTrabajadorDescuento)
        Me.UltraTabPageControl7.Controls.Add(Me.decImporteDescuento)
        Me.UltraTabPageControl7.Controls.Add(Me.txtGlosaDescuento)
        Me.UltraTabPageControl7.Controls.Add(Me.Etiqueta24)
        Me.UltraTabPageControl7.Controls.Add(Me.fecFechaDescuento)
        Me.UltraTabPageControl7.Controls.Add(Me.Etiqueta25)
        Me.UltraTabPageControl7.Controls.Add(Me.Etiqueta26)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1141, 300)
        '
        'numCuotas
        '
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.numCuotas.Appearance = Appearance72
        Me.numCuotas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuotas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuotas.ForeColor = System.Drawing.Color.Black
        Me.numCuotas.Location = New System.Drawing.Point(266, 135)
        Me.numCuotas.MaskInput = "nnnn"
        Me.numCuotas.MaxValue = 100
        Me.numCuotas.MinValue = 0
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.NullText = "0"
        Me.numCuotas.Size = New System.Drawing.Size(42, 22)
        Me.numCuotas.TabIndex = 2
        Me.numCuotas.Value = 1
        '
        'Etiqueta71
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta71.Appearance = Appearance73
        Me.Etiqueta71.AutoSize = True
        Me.Etiqueta71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta71.Location = New System.Drawing.Point(216, 139)
        Me.Etiqueta71.Name = "Etiqueta71"
        Me.Etiqueta71.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta71.TabIndex = 116
        Me.Etiqueta71.Text = "Cuotas:"
        Me.Etiqueta71.Visible = False
        '
        'Etiqueta49
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta49.Appearance = Appearance74
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta49.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta49.Location = New System.Drawing.Point(40, 166)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta49.TabIndex = 115
        Me.Etiqueta49.Text = "Concepto"
        '
        'cboConceptoDsct
        '
        Appearance75.ForeColor = System.Drawing.Color.Black
        Me.cboConceptoDsct.Appearance = Appearance75
        Me.cboConceptoDsct.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConceptoDsct.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConceptoDsct.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConceptoDsct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptoDsct.ForeColor = System.Drawing.Color.Black
        Me.cboConceptoDsct.Location = New System.Drawing.Point(97, 162)
        Me.cboConceptoDsct.Name = "cboConceptoDsct"
        Me.cboConceptoDsct.Size = New System.Drawing.Size(211, 22)
        Me.cboConceptoDsct.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending
        Me.cboConceptoDsct.TabIndex = 3
        Me.cboConceptoDsct.ValueMember = "Id"
        '
        'verGlosa
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.verGlosa.Appearance = Appearance76
        Me.verGlosa.BackColor = System.Drawing.Color.Transparent
        Me.verGlosa.BackColorInternal = System.Drawing.Color.Transparent
        Me.verGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verGlosa.ForeColor = System.Drawing.Color.Black
        Me.verGlosa.Location = New System.Drawing.Point(383, 216)
        Me.verGlosa.Name = "verGlosa"
        Me.verGlosa.Size = New System.Drawing.Size(78, 20)
        Me.verGlosa.TabIndex = 113
        Me.verGlosa.Text = "Glosa >>"
        '
        'FicTrabajadorDescuento
        '
        Me.FicTrabajadorDescuento.Controls.Add(Me.UltraTabSharedControlsPage6)
        Me.FicTrabajadorDescuento.Controls.Add(Me.UltraTabPageControl12)
        Me.FicTrabajadorDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FicTrabajadorDescuento.Location = New System.Drawing.Point(21, 3)
        Me.FicTrabajadorDescuento.Name = "FicTrabajadorDescuento"
        Me.FicTrabajadorDescuento.SharedControlsPage = Me.UltraTabSharedControlsPage6
        Me.FicTrabajadorDescuento.Size = New System.Drawing.Size(363, 99)
        Me.FicTrabajadorDescuento.TabIndex = 112
        UltraTab3.TabPage = Me.UltraTabPageControl12
        UltraTab3.Text = "Pilotos"
        Me.FicTrabajadorDescuento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        Me.FicTrabajadorDescuento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage6
        '
        Me.UltraTabSharedControlsPage6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage6.Name = "UltraTabSharedControlsPage6"
        Me.UltraTabSharedControlsPage6.Size = New System.Drawing.Size(361, 76)
        '
        'decImporteDescuento
        '
        Appearance77.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.decImporteDescuento.Appearance = Appearance77
        Me.decImporteDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decImporteDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteDescuento.ForeColor = System.Drawing.Color.Black
        Me.decImporteDescuento.Location = New System.Drawing.Point(98, 108)
        Me.decImporteDescuento.MaskInput = "{double:9.2}"
        Me.decImporteDescuento.Name = "decImporteDescuento"
        Me.decImporteDescuento.Nullable = True
        Me.decImporteDescuento.NullText = "0.00"
        Me.decImporteDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteDescuento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImporteDescuento.Size = New System.Drawing.Size(100, 22)
        Me.decImporteDescuento.TabIndex = 0
        '
        'txtGlosaDescuento
        '
        Me.txtGlosaDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaDescuento.Location = New System.Drawing.Point(97, 189)
        Me.txtGlosaDescuento.Multiline = True
        Me.txtGlosaDescuento.Name = "txtGlosaDescuento"
        Me.txtGlosaDescuento.Size = New System.Drawing.Size(279, 51)
        Me.txtGlosaDescuento.TabIndex = 4
        '
        'Etiqueta24
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance78
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(23, 191)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta24.TabIndex = 108
        Me.Etiqueta24.Text = "Glosa Origen"
        '
        'fecFechaDescuento
        '
        Appearance79.ForeColor = System.Drawing.Color.Black
        Me.fecFechaDescuento.Appearance = Appearance79
        Me.fecFechaDescuento.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fecFechaDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaDescuento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaDescuento.ForeColor = System.Drawing.Color.Black
        Me.fecFechaDescuento.Location = New System.Drawing.Point(97, 135)
        Me.fecFechaDescuento.Name = "fecFechaDescuento"
        Me.fecFechaDescuento.Size = New System.Drawing.Size(100, 22)
        Me.fecFechaDescuento.TabIndex = 1
        Me.fecFechaDescuento.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        '
        'Etiqueta25
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance80
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(57, 139)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta25.TabIndex = 106
        Me.Etiqueta25.Text = "Fecha"
        '
        'Etiqueta26
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance81
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(48, 112)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta26.TabIndex = 104
        Me.Etiqueta26.Text = "Importe"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.Etiqueta40)
        Me.UltraTabPageControl15.Controls.Add(Me.txtTipoCarga)
        Me.UltraTabPageControl15.Controls.Add(Me.txtComisionista)
        Me.UltraTabPageControl15.Controls.Add(Me.Etiqueta64)
        Me.UltraTabPageControl15.Controls.Add(Me.decComision)
        Me.UltraTabPageControl15.Controls.Add(Me.Etiqueta63)
        Me.UltraTabPageControl15.Controls.Add(Me.Etiqueta44)
        Me.UltraTabPageControl15.Controls.Add(Me.Etiqueta37)
        Me.UltraTabPageControl15.Controls.Add(Me.txtCliente)
        Me.UltraTabPageControl15.Controls.Add(Me.txtCarga)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(449, 67)
        '
        'Etiqueta40
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance82
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta40.Location = New System.Drawing.Point(0, 29)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta40.TabIndex = 33
        Me.Etiqueta40.Text = "Tipo Carga:"
        '
        'txtTipoCarga
        '
        Me.txtTipoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoCarga.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCarga.Location = New System.Drawing.Point(68, 25)
        Me.txtTipoCarga.Name = "txtTipoCarga"
        Me.txtTipoCarga.ReadOnly = True
        Me.txtTipoCarga.Size = New System.Drawing.Size(200, 19)
        Me.txtTipoCarga.TabIndex = 32
        Me.txtTipoCarga.TabStop = False
        '
        'txtComisionista
        '
        Me.txtComisionista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComisionista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComisionista.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComisionista.Location = New System.Drawing.Point(310, 25)
        Me.txtComisionista.Name = "txtComisionista"
        Me.txtComisionista.ReadOnly = True
        Me.txtComisionista.Size = New System.Drawing.Size(133, 19)
        Me.txtComisionista.TabIndex = 31
        Me.txtComisionista.TabStop = False
        '
        'Etiqueta64
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta64.Appearance = Appearance83
        Me.Etiqueta64.AutoSize = True
        Me.Etiqueta64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta64.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta64.Location = New System.Drawing.Point(274, 27)
        Me.Etiqueta64.Name = "Etiqueta64"
        Me.Etiqueta64.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta64.TabIndex = 30
        Me.Etiqueta64.Text = "Csta:"
        '
        'decComision
        '
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.decComision.Appearance = Appearance84
        Me.decComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decComision.ForeColor = System.Drawing.Color.Black
        Me.decComision.Location = New System.Drawing.Point(369, 2)
        Me.decComision.MaskInput = "{double:4.2}"
        Me.decComision.Name = "decComision"
        Me.decComision.NullText = "0.00"
        Me.decComision.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decComision.ReadOnly = True
        Me.decComision.Size = New System.Drawing.Size(74, 21)
        Me.decComision.TabIndex = 29
        Me.decComision.TabStop = False
        '
        'Etiqueta63
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta63.Appearance = Appearance85
        Me.Etiqueta63.AutoSize = True
        Me.Etiqueta63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta63.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta63.Location = New System.Drawing.Point(310, 6)
        Me.Etiqueta63.Name = "Etiqueta63"
        Me.Etiqueta63.Size = New System.Drawing.Size(53, 15)
        Me.Etiqueta63.TabIndex = 10
        Me.Etiqueta63.Text = "Comision:"
        '
        'Etiqueta44
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta44.Appearance = Appearance86
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(20, 48)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta44.TabIndex = 9
        Me.Etiqueta44.Text = "Cliente:"
        '
        'Etiqueta37
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta37.Appearance = Appearance87
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta37.Location = New System.Drawing.Point(14, 8)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta37.TabIndex = 9
        Me.Etiqueta37.Text = "Material:"
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCliente.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(68, 46)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(375, 19)
        Me.txtCliente.TabIndex = 8
        Me.txtCliente.TabStop = False
        '
        'txtCarga
        '
        Me.txtCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCarga.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarga.Location = New System.Drawing.Point(68, 4)
        Me.txtCarga.Name = "txtCarga"
        Me.txtCarga.ReadOnly = True
        Me.txtCarga.Size = New System.Drawing.Size(200, 19)
        Me.txtCarga.TabIndex = 8
        Me.txtCarga.TabStop = False
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.decMontoMaximo)
        Me.UltraTabPageControl14.Controls.Add(Me.Etiqueta67)
        Me.UltraTabPageControl14.Controls.Add(Me.decMontoNormal)
        Me.UltraTabPageControl14.Controls.Add(Me.Etiqueta66)
        Me.UltraTabPageControl14.Controls.Add(Me.Etiqueta35)
        Me.UltraTabPageControl14.Controls.Add(Me.decMontoMinimo)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(449, 67)
        '
        'decMontoMaximo
        '
        Appearance88.ForeColor = System.Drawing.Color.Black
        Me.decMontoMaximo.Appearance = Appearance88
        Me.decMontoMaximo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoMaximo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoMaximo.ForeColor = System.Drawing.Color.Black
        Me.decMontoMaximo.Location = New System.Drawing.Point(260, 8)
        Me.decMontoMaximo.MaskInput = "{double:8.2}"
        Me.decMontoMaximo.Name = "decMontoMaximo"
        Me.decMontoMaximo.Nullable = True
        Me.decMontoMaximo.NullText = "0.00"
        Me.decMontoMaximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoMaximo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoMaximo.ReadOnly = True
        Me.decMontoMaximo.Size = New System.Drawing.Size(68, 22)
        Me.decMontoMaximo.TabIndex = 123
        Me.decMontoMaximo.TabStop = False
        '
        'Etiqueta67
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta67.Appearance = Appearance89
        Me.Etiqueta67.AutoSize = True
        Me.Etiqueta67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta67.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta67.Location = New System.Drawing.Point(178, 12)
        Me.Etiqueta67.Name = "Etiqueta67"
        Me.Etiqueta67.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta67.TabIndex = 122
        Me.Etiqueta67.Text = "MontoMaximo:"
        '
        'decMontoNormal
        '
        Appearance90.ForeColor = System.Drawing.Color.Black
        Me.decMontoNormal.Appearance = Appearance90
        Me.decMontoNormal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoNormal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoNormal.ForeColor = System.Drawing.Color.Black
        Me.decMontoNormal.Location = New System.Drawing.Point(94, 32)
        Me.decMontoNormal.MaskInput = "{double:8.2}"
        Me.decMontoNormal.Name = "decMontoNormal"
        Me.decMontoNormal.Nullable = True
        Me.decMontoNormal.NullText = "0.00"
        Me.decMontoNormal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoNormal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoNormal.ReadOnly = True
        Me.decMontoNormal.Size = New System.Drawing.Size(68, 22)
        Me.decMontoNormal.TabIndex = 121
        Me.decMontoNormal.TabStop = False
        '
        'Etiqueta66
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta66.Appearance = Appearance91
        Me.Etiqueta66.AutoSize = True
        Me.Etiqueta66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta66.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta66.Location = New System.Drawing.Point(15, 12)
        Me.Etiqueta66.Name = "Etiqueta66"
        Me.Etiqueta66.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta66.TabIndex = 120
        Me.Etiqueta66.Text = "MontoMinimo:"
        '
        'Etiqueta35
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance92
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta35.Location = New System.Drawing.Point(15, 36)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(73, 14)
        Me.Etiqueta35.TabIndex = 119
        Me.Etiqueta35.Text = "MontoNormal:"
        '
        'decMontoMinimo
        '
        Appearance93.ForeColor = System.Drawing.Color.Black
        Me.decMontoMinimo.Appearance = Appearance93
        Me.decMontoMinimo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoMinimo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoMinimo.ForeColor = System.Drawing.Color.Black
        Me.decMontoMinimo.Location = New System.Drawing.Point(94, 8)
        Me.decMontoMinimo.MaskInput = "{double:8.2}"
        Me.decMontoMinimo.Name = "decMontoMinimo"
        Me.decMontoMinimo.Nullable = True
        Me.decMontoMinimo.NullText = "0.00"
        Me.decMontoMinimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoMinimo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoMinimo.ReadOnly = True
        Me.decMontoMinimo.Size = New System.Drawing.Size(68, 22)
        Me.decMontoMinimo.TabIndex = 13
        Me.decMontoMinimo.TabStop = False
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.opcVerPiloto)
        Me.UltraTabPageControl10.Controls.Add(Me.cboTrabajador)
        Me.UltraTabPageControl10.Controls.Add(Me.opcVerAyudante)
        Me.UltraTabPageControl10.Controls.Add(Me.opcVerCopiloto)
        Me.UltraTabPageControl10.Controls.Add(Me.opcVerOtro)
        Me.UltraTabPageControl10.Controls.Add(Me.fechaRecibidor)
        Me.UltraTabPageControl10.Controls.Add(Me.etiFechaRecepcion)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(248, 74)
        '
        'opcVerPiloto
        '
        Me.opcVerPiloto.AutoSize = True
        Me.opcVerPiloto.BackColor = System.Drawing.Color.Transparent
        Me.opcVerPiloto.ForeColor = System.Drawing.Color.Navy
        Me.opcVerPiloto.Location = New System.Drawing.Point(13, 3)
        Me.opcVerPiloto.Name = "opcVerPiloto"
        Me.opcVerPiloto.Size = New System.Drawing.Size(51, 17)
        Me.opcVerPiloto.TabIndex = 1
        Me.opcVerPiloto.Text = "Piloto"
        Me.opcVerPiloto.UseVisualStyleBackColor = False
        '
        'cboTrabajador
        '
        Appearance130.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance130
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Location = New System.Drawing.Point(64, 23)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(170, 22)
        Me.cboTrabajador.TabIndex = 5
        Me.cboTrabajador.TabStop = False
        Me.cboTrabajador.ValueMember = "Id"
        Me.cboTrabajador.Visible = False
        '
        'opcVerAyudante
        '
        Me.opcVerAyudante.AutoSize = True
        Me.opcVerAyudante.BackColor = System.Drawing.Color.Transparent
        Me.opcVerAyudante.ForeColor = System.Drawing.Color.Navy
        Me.opcVerAyudante.Location = New System.Drawing.Point(134, 3)
        Me.opcVerAyudante.Name = "opcVerAyudante"
        Me.opcVerAyudante.Size = New System.Drawing.Size(72, 17)
        Me.opcVerAyudante.TabIndex = 2
        Me.opcVerAyudante.Text = "Ayudante"
        Me.opcVerAyudante.UseVisualStyleBackColor = False
        Me.opcVerAyudante.Visible = False
        '
        'opcVerCopiloto
        '
        Me.opcVerCopiloto.AutoSize = True
        Me.opcVerCopiloto.BackColor = System.Drawing.Color.Transparent
        Me.opcVerCopiloto.ForeColor = System.Drawing.Color.Navy
        Me.opcVerCopiloto.Location = New System.Drawing.Point(64, 3)
        Me.opcVerCopiloto.Name = "opcVerCopiloto"
        Me.opcVerCopiloto.Size = New System.Drawing.Size(64, 17)
        Me.opcVerCopiloto.TabIndex = 3
        Me.opcVerCopiloto.Text = "Copiloto"
        Me.opcVerCopiloto.UseVisualStyleBackColor = False
        '
        'opcVerOtro
        '
        Me.opcVerOtro.AutoSize = True
        Me.opcVerOtro.BackColor = System.Drawing.Color.Transparent
        Me.opcVerOtro.ForeColor = System.Drawing.Color.Navy
        Me.opcVerOtro.Location = New System.Drawing.Point(13, 25)
        Me.opcVerOtro.Name = "opcVerOtro"
        Me.opcVerOtro.Size = New System.Drawing.Size(47, 17)
        Me.opcVerOtro.TabIndex = 4
        Me.opcVerOtro.Text = "Otro"
        Me.opcVerOtro.UseVisualStyleBackColor = False
        '
        'fechaRecibidor
        '
        Appearance131.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fechaRecibidor.Appearance = Appearance131
        Me.fechaRecibidor.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fechaRecibidor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fechaRecibidor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaRecibidor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fechaRecibidor.Location = New System.Drawing.Point(64, 48)
        Me.fechaRecibidor.MaskInput = "{date} {time}"
        Me.fechaRecibidor.Name = "fechaRecibidor"
        Me.fechaRecibidor.Size = New System.Drawing.Size(140, 22)
        Me.fechaRecibidor.TabIndex = 0
        Me.fechaRecibidor.TabStop = False
        Me.fechaRecibidor.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fechaRecibidor.Visible = False
        '
        'etiFechaRecepcion
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Me.etiFechaRecepcion.Appearance = Appearance132
        Me.etiFechaRecepcion.AutoSize = True
        Me.etiFechaRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaRecepcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiFechaRecepcion.Location = New System.Drawing.Point(13, 51)
        Me.etiFechaRecepcion.Name = "etiFechaRecepcion"
        Me.etiFechaRecepcion.Size = New System.Drawing.Size(35, 14)
        Me.etiFechaRecepcion.TabIndex = 97
        Me.etiFechaRecepcion.Text = "Fecha"
        Me.etiFechaRecepcion.Visible = False
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.decSaldoCuenta)
        Me.UltraTabPageControl11.Controls.Add(Me.etiNroChequeAsociado)
        Me.UltraTabPageControl11.Controls.Add(Me.etiCheque)
        Me.UltraTabPageControl11.Controls.Add(Me.Etiqueta14)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(248, 74)
        '
        'decSaldoCuenta
        '
        Appearance133.ForeColor = System.Drawing.Color.Black
        Me.decSaldoCuenta.Appearance = Appearance133
        Me.decSaldoCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoCuenta.Enabled = False
        Me.decSaldoCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoCuenta.ForeColor = System.Drawing.Color.Black
        Me.decSaldoCuenta.Location = New System.Drawing.Point(132, 3)
        Me.decSaldoCuenta.MaskInput = "{double:8.2}"
        Me.decSaldoCuenta.Name = "decSaldoCuenta"
        Me.decSaldoCuenta.Nullable = True
        Me.decSaldoCuenta.NullText = "0.00"
        Me.decSaldoCuenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoCuenta.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoCuenta.Size = New System.Drawing.Size(90, 22)
        Me.decSaldoCuenta.TabIndex = 12
        Me.decSaldoCuenta.TabStop = False
        '
        'etiNroChequeAsociado
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Me.etiNroChequeAsociado.Appearance = Appearance134
        Me.etiNroChequeAsociado.AutoSize = True
        Me.etiNroChequeAsociado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroChequeAsociado.ForeColor = System.Drawing.Color.Black
        Me.etiNroChequeAsociado.Location = New System.Drawing.Point(6, 30)
        Me.etiNroChequeAsociado.Name = "etiNroChequeAsociado"
        Me.etiNroChequeAsociado.Size = New System.Drawing.Size(120, 15)
        Me.etiNroChequeAsociado.TabIndex = 11
        Me.etiNroChequeAsociado.Text = "Nro Cheque Asociados:"
        '
        'etiCheque
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Me.etiCheque.Appearance = Appearance135
        Me.etiCheque.AutoSize = True
        Me.etiCheque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCheque.ForeColor = System.Drawing.Color.Black
        Me.etiCheque.Location = New System.Drawing.Point(132, 30)
        Me.etiCheque.Name = "etiCheque"
        Me.etiCheque.Size = New System.Drawing.Size(0, 0)
        Me.etiCheque.TabIndex = 11
        '
        'Etiqueta14
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance136
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(6, 7)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(70, 15)
        Me.Etiqueta14.TabIndex = 11
        Me.Etiqueta14.Text = "Saldo Cuenta"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.Etiqueta57)
        Me.UltraTabPageControl17.Controls.Add(Me.decHabEfectivo)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(248, 74)
        '
        'Etiqueta57
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta57.Appearance = Appearance137
        Me.Etiqueta57.AutoSize = True
        Me.Etiqueta57.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta57.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta57.Location = New System.Drawing.Point(10, 7)
        Me.Etiqueta57.Name = "Etiqueta57"
        Me.Etiqueta57.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta57.TabIndex = 74
        Me.Etiqueta57.Text = "Importe:"
        '
        'decHabEfectivo
        '
        Appearance138.ForeColor = System.Drawing.Color.Black
        Me.decHabEfectivo.Appearance = Appearance138
        Me.decHabEfectivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decHabEfectivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decHabEfectivo.ForeColor = System.Drawing.Color.Black
        Me.decHabEfectivo.Location = New System.Drawing.Point(64, 3)
        Me.decHabEfectivo.MaskInput = "{double:8.2}"
        Me.decHabEfectivo.MinValue = 0
        Me.decHabEfectivo.Name = "decHabEfectivo"
        Me.decHabEfectivo.Nullable = True
        Me.decHabEfectivo.NullText = "0.00"
        Me.decHabEfectivo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decHabEfectivo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decHabEfectivo.Size = New System.Drawing.Size(90, 22)
        Me.decHabEfectivo.TabIndex = 13
        Me.decHabEfectivo.TabStop = False
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.griListaDocumentoCompra)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(648, 168)
        '
        'griListaDocumentoCompra
        '
        Me.griListaDocumentoCompra.CalcManager = Me.UltraCalcManager
        Appearance149.BackColor = System.Drawing.SystemColors.Window
        Appearance149.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaDocumentoCompra.DisplayLayout.Appearance = Appearance149
        UltraGridColumn191.Header.VisiblePosition = 0
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 1
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 2
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 3
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 9
        UltraGridColumn195.Hidden = True
        UltraGridColumn195.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn196.Header.VisiblePosition = 10
        UltraGridColumn196.Hidden = True
        UltraGridColumn196.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn197.Header.VisiblePosition = 12
        UltraGridColumn197.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn198.Header.VisiblePosition = 8
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 13
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 14
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 15
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 7
        UltraGridColumn203.Header.VisiblePosition = 16
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 17
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 18
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 5
        UltraGridColumn206.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn207.Header.VisiblePosition = 6
        UltraGridColumn207.Hidden = True
        UltraGridColumn207.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn208.Header.VisiblePosition = 11
        UltraGridColumn208.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn209.Header.VisiblePosition = 19
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 20
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 21
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 22
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 23
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 24
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 25
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 26
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 27
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 28
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 4
        UltraGridColumn219.Width = 270
        UltraGridColumn220.Header.VisiblePosition = 29
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.VisiblePosition = 30
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.VisiblePosition = 31
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 32
        UltraGridColumn223.Hidden = True
        UltraGridColumn224.Header.VisiblePosition = 33
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 34
        UltraGridColumn225.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225})
        Me.griListaDocumentoCompra.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaDocumentoCompra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Hidden = True
        Me.griListaDocumentoCompra.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.griListaDocumentoCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaDocumentoCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaDocumentoCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaDocumentoCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.griListaDocumentoCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaDocumentoCompra.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaDocumentoCompra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaDocumentoCompra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaDocumentoCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaDocumentoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaDocumentoCompra.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaDocumentoCompra.Location = New System.Drawing.Point(0, 0)
        Me.griListaDocumentoCompra.Name = "griListaDocumentoCompra"
        Me.griListaDocumentoCompra.Size = New System.Drawing.Size(648, 168)
        Me.griListaDocumentoCompra.TabIndex = 4
        Me.griListaDocumentoCompra.TabStop = False
        Me.griListaDocumentoCompra.Text = "UltraGrid1"
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.Etiqueta65)
        Me.UltraTabPageControl19.Controls.Add(Me.txtGlosaOC)
        Me.UltraTabPageControl19.Controls.Add(Me.txt_NroOrden)
        Me.UltraTabPageControl19.Controls.Add(Me.Etiqueta59)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(648, 168)
        '
        'Etiqueta65
        '
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta65.Appearance = Appearance150
        Me.Etiqueta65.AutoSize = True
        Me.Etiqueta65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta65.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta65.Location = New System.Drawing.Point(27, 44)
        Me.Etiqueta65.Name = "Etiqueta65"
        Me.Etiqueta65.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta65.TabIndex = 3
        Me.Etiqueta65.Text = "Glosa: "
        '
        'txtGlosaOC
        '
        Me.txtGlosaOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaOC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaOC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaOC.Location = New System.Drawing.Point(68, 42)
        Me.txtGlosaOC.Multiline = True
        Me.txtGlosaOC.Name = "txtGlosaOC"
        Me.txtGlosaOC.ReadOnly = True
        Me.txtGlosaOC.Size = New System.Drawing.Size(307, 43)
        Me.txtGlosaOC.TabIndex = 2
        '
        'txt_NroOrden
        '
        Appearance151.TextHAlignAsString = "Right"
        Me.txt_NroOrden.Appearance = Appearance151
        Me.txt_NroOrden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_NroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroOrden.Location = New System.Drawing.Point(68, 11)
        Me.txt_NroOrden.Name = "txt_NroOrden"
        Me.txt_NroOrden.ReadOnly = True
        Me.txt_NroOrden.Size = New System.Drawing.Size(121, 22)
        Me.txt_NroOrden.TabIndex = 1
        Me.txt_NroOrden.TabStop = False
        '
        'Etiqueta59
        '
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta59.Appearance = Appearance152
        Me.Etiqueta59.AutoSize = True
        Me.Etiqueta59.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta59.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta59.Location = New System.Drawing.Point(5, 14)
        Me.Etiqueta59.Name = "Etiqueta59"
        Me.Etiqueta59.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta59.TabIndex = 0
        Me.Etiqueta59.Text = "NroOrden: "
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1103, 168)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.CalcManager = Me.UltraCalcManager
        Appearance223.BackColor = System.Drawing.SystemColors.Window
        Appearance223.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance223
        UltraGridColumn86.Header.VisiblePosition = 0
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 1
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 2
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 3
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 9
        UltraGridColumn90.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn91.Header.VisiblePosition = 10
        UltraGridColumn91.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn92.Header.VisiblePosition = 12
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn93.Header.VisiblePosition = 8
        UltraGridColumn94.Header.VisiblePosition = 13
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 14
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 15
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 7
        UltraGridColumn98.Header.VisiblePosition = 16
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 17
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 18
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 5
        UltraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn102.Header.VisiblePosition = 6
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn103.Header.VisiblePosition = 11
        UltraGridColumn103.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn104.Header.VisiblePosition = 19
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 20
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 21
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 22
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 23
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 24
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 25
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 26
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 27
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 28
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 4
        UltraGridColumn114.Width = 270
        UltraGridColumn115.Header.VisiblePosition = 29
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 30
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 31
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 32
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 33
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 34
        UltraGridColumn120.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGrid1.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.GroupByBox.Hidden = True
        Me.UltraGrid1.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.UltraGrid1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.UltraGrid1.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.UltraGrid1.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.None
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.None
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(1103, 168)
        Me.UltraGrid1.TabIndex = 4
        Me.UltraGrid1.TabStop = False
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.Etiqueta41)
        Me.UltraTabPageControl16.Controls.Add(Me.Texto1)
        Me.UltraTabPageControl16.Controls.Add(Me.Texto2)
        Me.UltraTabPageControl16.Controls.Add(Me.Etiqueta42)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(1103, 168)
        '
        'Etiqueta41
        '
        Appearance224.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance224
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta41.Location = New System.Drawing.Point(21, 44)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta41.TabIndex = 3
        Me.Etiqueta41.Text = "Glosa: "
        '
        'Texto1
        '
        Me.Texto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto1.Location = New System.Drawing.Point(65, 44)
        Me.Texto1.Multiline = True
        Me.Texto1.Name = "Texto1"
        Me.Texto1.ReadOnly = True
        Me.Texto1.Size = New System.Drawing.Size(307, 43)
        Me.Texto1.TabIndex = 2
        '
        'Texto2
        '
        Appearance225.TextHAlignAsString = "Right"
        Me.Texto2.Appearance = Appearance225
        Me.Texto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto2.Location = New System.Drawing.Point(65, 10)
        Me.Texto2.Name = "Texto2"
        Me.Texto2.ReadOnly = True
        Me.Texto2.Size = New System.Drawing.Size(121, 21)
        Me.Texto2.TabIndex = 1
        Me.Texto2.TabStop = False
        '
        'Etiqueta42
        '
        Appearance226.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance226
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta42.Location = New System.Drawing.Point(5, 14)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta42.TabIndex = 0
        Me.Etiqueta42.Text = "NroOrden: "
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.agrViajesProgramados)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1165, 437)
        '
        'agrViajesProgramados
        '
        Me.agrViajesProgramados.Controls.Add(Me.griLista)
        Me.agrViajesProgramados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrViajesProgramados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrViajesProgramados.ForeColor = System.Drawing.Color.Black
        Me.agrViajesProgramados.Location = New System.Drawing.Point(0, 0)
        Me.agrViajesProgramados.Name = "agrViajesProgramados"
        Me.agrViajesProgramados.Size = New System.Drawing.Size(1165, 437)
        Me.agrViajesProgramados.TabIndex = 1
        Me.agrViajesProgramados.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griLista
        '
        Me.griLista.CalcManager = Me.UltraCalcManager
        Me.griLista.ContextMenuStrip = Me.MnContMovimiento
        Me.griLista.DataSource = Me.ogdMovimientoViaje
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.Width = 224
        UltraGridColumn7.Header.VisiblePosition = 10
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 11
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 36
        UltraGridColumn9.Width = 218
        UltraGridColumn10.Header.VisiblePosition = 12
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 13
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn14.CellAppearance = Appearance3
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn14.Width = 60
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 27
        UltraGridColumn19.Width = 175
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 22
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 32
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn25.Width = 74
        UltraGridColumn26.Header.VisiblePosition = 28
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 29
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 88
        UltraGridColumn28.Header.VisiblePosition = 30
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 5
        UltraGridColumn29.Width = 71
        UltraGridColumn30.Header.VisiblePosition = 31
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridColumn31.Width = 95
        UltraGridColumn32.Header.VisiblePosition = 39
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 40
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 41
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 38
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.Width = 156
        UltraGridColumn36.Header.VisiblePosition = 42
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 43
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 194
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn39.CellAppearance = Appearance4
        UltraGridColumn39.Header.VisiblePosition = 44
        UltraGridColumn39.Hidden = True
        Appearance5.TextHAlignAsString = "Center"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn40.CellAppearance = Appearance5
        UltraGridColumn40.Header.VisiblePosition = 45
        UltraGridColumn40.Hidden = True
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance6
        UltraGridColumn41.Format = "#,###,###,##0.00"
        UltraGridColumn41.Header.VisiblePosition = 24
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn41.Width = 76
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance7
        UltraGridColumn42.Format = "#,###,###,##0.00"
        UltraGridColumn42.Header.VisiblePosition = 25
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn42.Width = 76
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance8
        UltraGridColumn43.Format = "#,###,###,##0.00"
        UltraGridColumn43.Header.VisiblePosition = 26
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn43.Width = 82
        UltraGridColumn44.Header.VisiblePosition = 46
        UltraGridColumn44.Hidden = True
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn45.CellAppearance = Appearance9
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        UltraGridColumn45.CellButtonAppearance = Appearance10
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn45.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn45.Header.Caption = "Glosa Referencial"
        UltraGridColumn45.Header.VisiblePosition = 47
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn45.Width = 267
        UltraGridColumn46.Header.VisiblePosition = 48
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 49
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 50
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 51
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 52
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 53
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 54
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 55
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 56
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 33
        UltraGridColumn56.Header.VisiblePosition = 34
        UltraGridColumn57.Header.VisiblePosition = 35
        UltraGridColumn58.Header.VisiblePosition = 57
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 58
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 3
        UltraGridColumn60.Width = 119
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38, RowLayoutColumnInfo39, RowLayoutColumnInfo40, RowLayoutColumnInfo41, RowLayoutColumnInfo42, RowLayoutColumnInfo43, RowLayoutColumnInfo44, RowLayoutColumnInfo45, RowLayoutColumnInfo46, RowLayoutColumnInfo47, RowLayoutColumnInfo48, RowLayoutColumnInfo49, RowLayoutColumnInfo50, RowLayoutColumnInfo51, RowLayoutColumnInfo52, RowLayoutColumnInfo53, RowLayoutColumnInfo54, RowLayoutColumnInfo55, RowLayoutColumnInfo56, RowLayoutColumnInfo57, RowLayoutColumnInfo58, RowLayoutColumnInfo59})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand1.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(2, 2)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1161, 433)
        Me.griLista.TabIndex = 0
        Me.griLista.TabStop = False
        Me.griLista.Tag = ""
        '
        'MnContMovimiento
        '
        Me.MnContMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnContMovimiento.ForeColor = System.Drawing.Color.Black
        Me.MnContMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HabilitarBolsaDeViajeToolStripMenuItem, Me.AmpliacionBolsaDeViajeToolStripMenuItem, Me.LiquidarToolStripMenuItem, Me.ReporteFondoFijoToolStripMenuItem})
        Me.MnContMovimiento.Name = "MenuContextual1"
        Me.MnContMovimiento.Size = New System.Drawing.Size(196, 92)
        '
        'HabilitarBolsaDeViajeToolStripMenuItem
        '
        Me.HabilitarBolsaDeViajeToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.HabilitarBolsaDeViajeToolStripMenuItem.Name = "HabilitarBolsaDeViajeToolStripMenuItem"
        Me.HabilitarBolsaDeViajeToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.HabilitarBolsaDeViajeToolStripMenuItem.Text = "Habilitar Bolsa de Viaje"
        '
        'AmpliacionBolsaDeViajeToolStripMenuItem
        '
        Me.AmpliacionBolsaDeViajeToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.AmpliacionBolsaDeViajeToolStripMenuItem.Name = "AmpliacionBolsaDeViajeToolStripMenuItem"
        Me.AmpliacionBolsaDeViajeToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AmpliacionBolsaDeViajeToolStripMenuItem.Text = "Ampliacion Bolsa de Viaje"
        '
        'LiquidarToolStripMenuItem
        '
        Me.LiquidarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.LiquidarToolStripMenuItem.Name = "LiquidarToolStripMenuItem"
        Me.LiquidarToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.LiquidarToolStripMenuItem.Text = "Liquidar"
        '
        'ReporteFondoFijoToolStripMenuItem
        '
        Me.ReporteFondoFijoToolStripMenuItem.Name = "ReporteFondoFijoToolStripMenuItem"
        Me.ReporteFondoFijoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ReporteFondoFijoToolStripMenuItem.Text = "Reporte Fondo Fijo"
        '
        'ogdMovimientoViaje
        '
        UltraDataColumn13.DataType = GetType(Date)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Boolean)
        UltraDataColumn38.DataType = GetType(Date)
        UltraDataColumn39.DataType = GetType(Date)
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn52.DataType = GetType(Date)
        UltraDataColumn53.DataType = GetType(Date)
        UltraDataColumn54.DataType = GetType(Date)
        UltraDataColumn55.DataType = GetType(Date)
        UltraDataColumn58.DataType = GetType(Short)
        Me.ogdMovimientoViaje.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.agrMovimientoCaja)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1165, 437)
        '
        'agrMovimientoCaja
        '
        Me.agrMovimientoCaja.Controls.Add(Me.GriCuentaAdministrativa)
        Me.agrMovimientoCaja.Controls.Add(Me.expIngresoFF)
        Me.agrMovimientoCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMovimientoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMovimientoCaja.ForeColor = System.Drawing.Color.Black
        Me.agrMovimientoCaja.Location = New System.Drawing.Point(0, 0)
        Me.agrMovimientoCaja.Name = "agrMovimientoCaja"
        Me.agrMovimientoCaja.Size = New System.Drawing.Size(1165, 437)
        Me.agrMovimientoCaja.TabIndex = 0
        Me.agrMovimientoCaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GriCuentaAdministrativa
        '
        Me.GriCuentaAdministrativa.CalcManager = Me.UltraCalcManager
        Me.GriCuentaAdministrativa.ContextMenuStrip = Me.MnAdministrativo
        Me.GriCuentaAdministrativa.DataSource = Me.ogdAdministrativo
        UltraGridColumn61.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn61.Header.VisiblePosition = 0
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.MaskInput = "{date} {time}"
        UltraGridColumn62.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn62.Width = 118
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 3
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 4
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn66.Header.VisiblePosition = 2
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn67.Header.VisiblePosition = 5
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 321
        UltraGridColumn68.Header.VisiblePosition = 8
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Format = "#,###,###,##0.00"
        UltraGridColumn69.Header.VisiblePosition = 9
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.MaskInput = ""
        UltraGridColumn70.Format = "#,###,###,##0.00"
        UltraGridColumn70.Header.VisiblePosition = 10
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.MaskInput = ""
        UltraGridColumn71.Header.VisiblePosition = 11
        UltraGridColumn71.Hidden = True
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn72.CellAppearance = Appearance11
        UltraGridColumn72.Format = "#,###,###,##0.00"
        UltraGridColumn72.Header.VisiblePosition = 12
        UltraGridColumn72.MaskInput = "{currency:9.2}"
        UltraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn72.Width = 87
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn73.CellAppearance = Appearance12
        UltraGridColumn73.Format = "#,###,###,##0.00"
        UltraGridColumn73.Header.VisiblePosition = 13
        UltraGridColumn73.MaskInput = "{currency:9.2}"
        UltraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn73.Width = 81
        Appearance13.BackColor = System.Drawing.Color.White
        UltraGridColumn74.CellAppearance = Appearance13
        UltraGridColumn74.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn74.Header.VisiblePosition = 14
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn75.Header.VisiblePosition = 7
        UltraGridColumn75.Width = 672
        UltraGridColumn76.Header.VisiblePosition = 15
        UltraGridColumn76.Width = 100
        UltraGridColumn77.Header.VisiblePosition = 16
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 17
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 18
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 19
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 20
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 21
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 22
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 23
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 24
        UltraGridColumn85.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 25
        UltraGridColumn121.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn121})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.GriCuentaAdministrativa.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GriCuentaAdministrativa.DisplayLayout.MaxColScrollRegions = 1
        Me.GriCuentaAdministrativa.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GriCuentaAdministrativa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GriCuentaAdministrativa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GriCuentaAdministrativa.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GriCuentaAdministrativa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GriCuentaAdministrativa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GriCuentaAdministrativa.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GriCuentaAdministrativa.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GriCuentaAdministrativa.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.GriCuentaAdministrativa.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.GriCuentaAdministrativa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GriCuentaAdministrativa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GriCuentaAdministrativa.Location = New System.Drawing.Point(2, 2)
        Me.GriCuentaAdministrativa.Name = "GriCuentaAdministrativa"
        Me.GriCuentaAdministrativa.Size = New System.Drawing.Size(1133, 433)
        Me.GriCuentaAdministrativa.TabIndex = 6
        '
        'MnAdministrativo
        '
        Me.MnAdministrativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnAdministrativo.ForeColor = System.Drawing.Color.Black
        Me.MnAdministrativo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HabilitarCuentaToolStripMenuItem, Me.tsmiDocumentos, Me.CierreCuentaToolStripMenuItem, Me.GenerarGrupoFlete, Me.CuadreCajaToolStripMenuItem})
        Me.MnAdministrativo.Name = "MnAdministrativo"
        Me.MnAdministrativo.Size = New System.Drawing.Size(171, 114)
        '
        'HabilitarCuentaToolStripMenuItem
        '
        Me.HabilitarCuentaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.HabilitarCuentaToolStripMenuItem.Name = "HabilitarCuentaToolStripMenuItem"
        Me.HabilitarCuentaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HabilitarCuentaToolStripMenuItem.Text = "Habilitar Cuenta"
        '
        'tsmiDocumentos
        '
        Me.tsmiDocumentos.Enabled = False
        Me.tsmiDocumentos.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.tsmiDocumentos.Name = "tsmiDocumentos"
        Me.tsmiDocumentos.Size = New System.Drawing.Size(170, 22)
        Me.tsmiDocumentos.Text = "Documentos"
        '
        'CierreCuentaToolStripMenuItem
        '
        Me.CierreCuentaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.CierreCuentaToolStripMenuItem.Name = "CierreCuentaToolStripMenuItem"
        Me.CierreCuentaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CierreCuentaToolStripMenuItem.Text = "Cierre Cuenta"
        '
        'GenerarGrupoFlete
        '
        Me.GenerarGrupoFlete.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.GenerarGrupoFlete.Name = "GenerarGrupoFlete"
        Me.GenerarGrupoFlete.Size = New System.Drawing.Size(170, 22)
        Me.GenerarGrupoFlete.Text = "Generar Grupo Flete"
        Me.GenerarGrupoFlete.Visible = False
        '
        'CuadreCajaToolStripMenuItem
        '
        Me.CuadreCajaToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.CuadreCajaToolStripMenuItem.Name = "CuadreCajaToolStripMenuItem"
        Me.CuadreCajaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CuadreCajaToolStripMenuItem.Text = "Cuadre Caja"
        '
        'ogdAdministrativo
        '
        UltraDataColumn61.DataType = GetType(Date)
        UltraDataColumn68.DataType = GetType(Decimal)
        UltraDataColumn69.DataType = GetType(Decimal)
        UltraDataColumn70.DataType = GetType(Decimal)
        UltraDataColumn71.DataType = GetType(Decimal)
        UltraDataColumn72.DataType = GetType(Decimal)
        UltraDataColumn73.DataType = GetType(Decimal)
        Me.ogdAdministrativo.Band.Columns.AddRange(New Object() {UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85})
        '
        'expIngresoFF
        '
        Me.expIngresoFF.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.expIngresoFF.Dock = System.Windows.Forms.DockStyle.Right
        Me.expIngresoFF.Expanded = False
        Me.expIngresoFF.ExpandedSize = New System.Drawing.Size(417, 433)
        Me.expIngresoFF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expIngresoFF.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightInsideBorder
        Me.expIngresoFF.Location = New System.Drawing.Point(1135, 2)
        Me.expIngresoFF.Name = "expIngresoFF"
        Me.expIngresoFF.Size = New System.Drawing.Size(28, 433)
        Me.expIngresoFF.TabIndex = 5
        Me.expIngresoFF.Text = "Ingreso a FF de Caja Externa"
        Me.expIngresoFF.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.expIngresoFF.Visible = False
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Agrupacion10)
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(394, 390)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel12.Visible = False
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.decIngresoFF)
        Me.Agrupacion10.Controls.Add(Me.txtGlosaFF)
        Me.Agrupacion10.Controls.Add(Me.Etiqueta52)
        Me.Agrupacion10.Controls.Add(Me.fecIngresoFF)
        Me.Agrupacion10.Controls.Add(Me.Etiqueta53)
        Me.Agrupacion10.Controls.Add(Me.Etiqueta55)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(394, 390)
        Me.Agrupacion10.TabIndex = 0
        Me.Agrupacion10.Text = "Ingreso a FF de Caja Externa"
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decIngresoFF
        '
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.decIngresoFF.Appearance = Appearance14
        Me.decIngresoFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decIngresoFF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIngresoFF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIngresoFF.ForeColor = System.Drawing.Color.Black
        Me.decIngresoFF.Location = New System.Drawing.Point(88, 25)
        Me.decIngresoFF.MaskInput = "{double:9.2}"
        Me.decIngresoFF.MinValue = 0
        Me.decIngresoFF.Name = "decIngresoFF"
        Me.decIngresoFF.Nullable = True
        Me.decIngresoFF.NullText = "0.00"
        Me.decIngresoFF.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIngresoFF.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decIngresoFF.Size = New System.Drawing.Size(100, 22)
        Me.decIngresoFF.TabIndex = 125
        '
        'txtGlosaFF
        '
        Me.txtGlosaFF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaFF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaFF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaFF.Location = New System.Drawing.Point(88, 81)
        Me.txtGlosaFF.Multiline = True
        Me.txtGlosaFF.Name = "txtGlosaFF"
        Me.txtGlosaFF.Size = New System.Drawing.Size(279, 51)
        Me.txtGlosaFF.TabIndex = 124
        '
        'Etiqueta52
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta52.Appearance = Appearance15
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(14, 83)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta52.TabIndex = 123
        Me.Etiqueta52.Text = "Glosa Origen"
        '
        'fecIngresoFF
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.fecIngresoFF.Appearance = Appearance16
        Me.fecIngresoFF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecIngresoFF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecIngresoFF.ForeColor = System.Drawing.Color.Black
        Me.fecIngresoFF.Location = New System.Drawing.Point(88, 53)
        Me.fecIngresoFF.Name = "fecIngresoFF"
        Me.fecIngresoFF.Size = New System.Drawing.Size(100, 22)
        Me.fecIngresoFF.TabIndex = 122
        '
        'Etiqueta53
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta53.Appearance = Appearance17
        Me.Etiqueta53.AutoSize = True
        Me.Etiqueta53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta53.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta53.Location = New System.Drawing.Point(48, 57)
        Me.Etiqueta53.Name = "Etiqueta53"
        Me.Etiqueta53.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta53.TabIndex = 121
        Me.Etiqueta53.Text = "Fecha"
        '
        'Etiqueta55
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta55.Appearance = Appearance18
        Me.Etiqueta55.AutoSize = True
        Me.Etiqueta55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta55.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta55.Location = New System.Drawing.Point(38, 29)
        Me.Etiqueta55.Name = "Etiqueta55"
        Me.Etiqueta55.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta55.TabIndex = 120
        Me.Etiqueta55.Text = "Importe"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.agrMovimientoDetalle)
        Me.UltraTabPageControl3.Controls.Add(Me.agrSalida)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1175, 601)
        '
        'agrMovimientoDetalle
        '
        Me.agrMovimientoDetalle.Controls.Add(Me.agrCuentaIzq)
        Me.agrMovimientoDetalle.Controls.Add(Me.expGlosa)
        Me.agrMovimientoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMovimientoDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMovimientoDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrMovimientoDetalle.Location = New System.Drawing.Point(0, 254)
        Me.agrMovimientoDetalle.Name = "agrMovimientoDetalle"
        Me.agrMovimientoDetalle.Size = New System.Drawing.Size(1175, 347)
        Me.agrMovimientoDetalle.TabIndex = 0
        Me.agrMovimientoDetalle.Text = "Cuenta"
        Me.agrMovimientoDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrCuentaIzq
        '
        Me.agrCuentaIzq.Controls.Add(Me.ficMovimientoDetalle)
        Me.agrCuentaIzq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrCuentaIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCuentaIzq.ForeColor = System.Drawing.Color.Black
        Me.agrCuentaIzq.Location = New System.Drawing.Point(3, 17)
        Me.agrCuentaIzq.Name = "agrCuentaIzq"
        Me.agrCuentaIzq.Size = New System.Drawing.Size(1147, 327)
        Me.agrCuentaIzq.TabIndex = 111
        Me.agrCuentaIzq.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ficMovimientoDetalle
        '
        Me.ficMovimientoDetalle.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficMovimientoDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficMovimientoDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.ficMovimientoDetalle.Controls.Add(Me.UltraTabPageControl7)
        Me.ficMovimientoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimientoDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimientoDetalle.Location = New System.Drawing.Point(2, 2)
        Me.ficMovimientoDetalle.Name = "ficMovimientoDetalle"
        Me.ficMovimientoDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficMovimientoDetalle.Size = New System.Drawing.Size(1143, 323)
        Me.ficMovimientoDetalle.TabIndex = 2
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Detalle"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Préstamo"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Descuento"
        Me.ficMovimientoDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab7})
        Me.ficMovimientoDetalle.TabStop = False
        Me.ficMovimientoDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1141, 300)
        '
        'expGlosa
        '
        Me.expGlosa.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.expGlosa.Dock = System.Windows.Forms.DockStyle.Right
        Me.expGlosa.Expanded = False
        Me.expGlosa.ExpandedSize = New System.Drawing.Size(387, 327)
        Me.expGlosa.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOnBorder
        Me.expGlosa.Location = New System.Drawing.Point(1150, 17)
        Me.expGlosa.Name = "expGlosa"
        Me.expGlosa.Size = New System.Drawing.Size(22, 327)
        Me.expGlosa.TabIndex = 110
        Me.expGlosa.Text = "Glosa"
        Me.expGlosa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.griListaGlosa)
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(364, 245)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel7.Visible = False
        '
        'griListaGlosa
        '
        Me.griListaGlosa.CalcManager = Me.UltraCalcManager
        Me.griListaGlosa.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaGlosa.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGlosa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaGlosa.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaGlosa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaGlosa.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaGlosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaGlosa.Location = New System.Drawing.Point(0, 0)
        Me.griListaGlosa.Name = "griListaGlosa"
        Me.griListaGlosa.Size = New System.Drawing.Size(364, 245)
        Me.griListaGlosa.TabIndex = 1
        Me.griListaGlosa.Text = "Listado de Glosas"
        '
        'agrSalida
        '
        Me.agrSalida.Controls.Add(Me.agrDefinicion)
        Me.agrSalida.Controls.Add(Me.ExpGroupBoxReceptor)
        Me.agrSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrSalida.ForeColor = System.Drawing.Color.Black
        Me.agrSalida.Location = New System.Drawing.Point(0, 0)
        Me.agrSalida.Name = "agrSalida"
        Me.agrSalida.Size = New System.Drawing.Size(1175, 254)
        Me.agrSalida.TabIndex = 0
        Me.agrSalida.Text = "Movimiento Caja"
        Me.agrSalida.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrDefinicion
        '
        Me.agrDefinicion.Controls.Add(Me.FicObservacion)
        Me.agrDefinicion.Controls.Add(Me.agrMuestraCuenta)
        Me.agrDefinicion.Controls.Add(Me.agrDatosViaje)
        Me.agrDefinicion.Controls.Add(Me.FicDatos)
        Me.agrDefinicion.Controls.Add(Me.cboCaja)
        Me.agrDefinicion.Controls.Add(Me.Etiqueta1)
        Me.agrDefinicion.Controls.Add(Me.txtGlosa)
        Me.agrDefinicion.Controls.Add(Me.opcDefinicion)
        Me.agrDefinicion.Controls.Add(Me.Etiqueta28)
        Me.agrDefinicion.Controls.Add(Me.fechaBalancin)
        Me.agrDefinicion.Controls.Add(Me.Etiqueta29)
        Me.agrDefinicion.Controls.Add(Me.opcTipoMovimiento)
        Me.agrDefinicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDefinicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDefinicion.ForeColor = System.Drawing.Color.Black
        Me.agrDefinicion.Location = New System.Drawing.Point(158, 17)
        Me.agrDefinicion.Name = "agrDefinicion"
        Me.agrDefinicion.Size = New System.Drawing.Size(1014, 234)
        Me.agrDefinicion.TabIndex = 99
        Me.agrDefinicion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'FicObservacion
        '
        Me.FicObservacion.Controls.Add(Me.UltraTabSharedControlsPage7)
        Me.FicObservacion.Controls.Add(Me.UltraTabPageControl15)
        Me.FicObservacion.Controls.Add(Me.UltraTabPageControl14)
        Me.FicObservacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FicObservacion.Location = New System.Drawing.Point(543, 139)
        Me.FicObservacion.Name = "FicObservacion"
        Me.FicObservacion.SharedControlsPage = Me.UltraTabSharedControlsPage7
        Me.FicObservacion.Size = New System.Drawing.Size(451, 90)
        Me.FicObservacion.TabIndex = 117
        UltraTab9.TabPage = Me.UltraTabPageControl15
        UltraTab9.Text = "Otros Datos Viaje"
        UltraTab19.TabPage = Me.UltraTabPageControl14
        UltraTab19.Text = "BolsaRuta"
        Me.FicObservacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab19})
        Me.FicObservacion.TabStop = False
        Me.FicObservacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage7
        '
        Me.UltraTabSharedControlsPage7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage7.Name = "UltraTabSharedControlsPage7"
        Me.UltraTabSharedControlsPage7.Size = New System.Drawing.Size(449, 67)
        '
        'agrMuestraCuenta
        '
        Me.agrMuestraCuenta.Controls.Add(Me.agrCuentaInferior)
        Me.agrMuestraCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMuestraCuenta.ForeColor = System.Drawing.Color.Black
        Me.agrMuestraCuenta.Location = New System.Drawing.Point(256, 6)
        Me.agrMuestraCuenta.Name = "agrMuestraCuenta"
        Me.agrMuestraCuenta.Size = New System.Drawing.Size(281, 223)
        Me.agrMuestraCuenta.TabIndex = 116
        Me.agrMuestraCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrCuentaInferior
        '
        Me.agrCuentaInferior.Controls.Add(Me.btnLiquidar)
        Me.agrCuentaInferior.Controls.Add(Me.agrCuenta)
        Me.agrCuentaInferior.Controls.Add(Me.agrIEFF)
        Me.agrCuentaInferior.Controls.Add(Me.etiLiquidar)
        Me.agrCuentaInferior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrCuentaInferior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCuentaInferior.ForeColor = System.Drawing.Color.Transparent
        Me.agrCuentaInferior.Location = New System.Drawing.Point(3, 3)
        Me.agrCuentaInferior.Name = "agrCuentaInferior"
        Me.agrCuentaInferior.Size = New System.Drawing.Size(275, 217)
        Me.agrCuentaInferior.TabIndex = 26
        Me.agrCuentaInferior.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnLiquidar
        '
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.btnLiquidar.Appearance = Appearance94
        Me.btnLiquidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnLiquidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLiquidar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidar.ForeColor = System.Drawing.Color.Black
        Me.btnLiquidar.Location = New System.Drawing.Point(180, 123)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(90, 25)
        Me.btnLiquidar.TabIndex = 115
        Me.btnLiquidar.TabStop = False
        Me.btnLiquidar.Text = "LIQUIDAR"
        '
        'agrCuenta
        '
        Me.agrCuenta.Controls.Add(Me.Etiqueta13)
        Me.agrCuenta.Controls.Add(Me.Etiqueta12)
        Me.agrCuenta.Controls.Add(Me.Etiqueta11)
        Me.agrCuenta.Controls.Add(Me.decSaldo)
        Me.agrCuenta.Controls.Add(Me.etiGastosRendidos)
        Me.agrCuenta.Controls.Add(Me.decEgresos)
        Me.agrCuenta.Controls.Add(Me.decTotalGastos)
        Me.agrCuenta.Controls.Add(Me.decIngresos)
        Me.agrCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCuenta.ForeColor = System.Drawing.Color.Black
        Me.agrCuenta.Location = New System.Drawing.Point(3, 3)
        Me.agrCuenta.Name = "agrCuenta"
        Me.agrCuenta.Size = New System.Drawing.Size(269, 65)
        Me.agrCuenta.TabIndex = 81
        Me.agrCuenta.Text = "Cuenta"
        Me.agrCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta13
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance95
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(141, 24)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta13.TabIndex = 0
        Me.Etiqueta13.Text = "Saldo"
        '
        'Etiqueta12
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance96
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(6, 20)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta12.TabIndex = 0
        Me.Etiqueta12.Text = "Egresos"
        '
        'Etiqueta11
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance97
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(5, 41)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta11.TabIndex = 0
        Me.Etiqueta11.Text = "Ingresos"
        '
        'decSaldo
        '
        Appearance98.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance98
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(178, 19)
        Me.decSaldo.MaskInput = "{double:6.2}"
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(79, 22)
        Me.decSaldo.TabIndex = 5
        Me.decSaldo.TabStop = False
        '
        'etiGastosRendidos
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Appearance99.ForeColor = System.Drawing.Color.Navy
        Appearance99.TextHAlignAsString = "Right"
        Me.etiGastosRendidos.Appearance = Appearance99
        Me.etiGastosRendidos.AutoSize = True
        Me.etiGastosRendidos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGastosRendidos.ForeColor = System.Drawing.Color.Black
        Me.etiGastosRendidos.Location = New System.Drawing.Point(137, 45)
        Me.etiGastosRendidos.Name = "etiGastosRendidos"
        Me.etiGastosRendidos.Size = New System.Drawing.Size(38, 15)
        Me.etiGastosRendidos.TabIndex = 0
        Me.etiGastosRendidos.Text = "Gastos"
        '
        'decEgresos
        '
        Appearance100.ForeColor = System.Drawing.Color.Black
        Me.decEgresos.Appearance = Appearance100
        Me.decEgresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decEgresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decEgresos.ForeColor = System.Drawing.Color.Black
        Me.decEgresos.Location = New System.Drawing.Point(54, 41)
        Me.decEgresos.MaskInput = "{double:6.2}"
        Me.decEgresos.Name = "decEgresos"
        Me.decEgresos.NullText = "0.00"
        Me.decEgresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decEgresos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decEgresos.ReadOnly = True
        Me.decEgresos.Size = New System.Drawing.Size(79, 22)
        Me.decEgresos.TabIndex = 5
        Me.decEgresos.TabStop = False
        '
        'decTotalGastos
        '
        Appearance101.ForeColor = System.Drawing.Color.Black
        Me.decTotalGastos.Appearance = Appearance101
        Me.decTotalGastos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalGastos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalGastos.ForeColor = System.Drawing.Color.Black
        Me.decTotalGastos.Location = New System.Drawing.Point(178, 41)
        Me.decTotalGastos.MaskInput = "{double:6.2}"
        Me.decTotalGastos.Name = "decTotalGastos"
        Me.decTotalGastos.NullText = "0.00"
        Me.decTotalGastos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalGastos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotalGastos.ReadOnly = True
        Me.decTotalGastos.Size = New System.Drawing.Size(79, 22)
        Me.decTotalGastos.TabIndex = 5
        Me.decTotalGastos.TabStop = False
        '
        'decIngresos
        '
        Appearance102.ForeColor = System.Drawing.Color.Black
        Me.decIngresos.Appearance = Appearance102
        Me.decIngresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIngresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIngresos.ForeColor = System.Drawing.Color.Black
        Me.decIngresos.Location = New System.Drawing.Point(54, 19)
        Me.decIngresos.MaskInput = "{double:6.2}"
        Me.decIngresos.Name = "decIngresos"
        Me.decIngresos.NullText = "0.00"
        Me.decIngresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIngresos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decIngresos.ReadOnly = True
        Me.decIngresos.Size = New System.Drawing.Size(79, 22)
        Me.decIngresos.TabIndex = 5
        Me.decIngresos.TabStop = False
        '
        'agrIEFF
        '
        Me.agrIEFF.Controls.Add(Me.fechaMovimiento)
        Me.agrIEFF.Controls.Add(Me.decImporte)
        Me.agrIEFF.Controls.Add(Me.Etiqueta2)
        Me.agrIEFF.Controls.Add(Me.Etiqueta30)
        Me.agrIEFF.Controls.Add(Me.opcSalidaEntrada)
        Me.agrIEFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrIEFF.ForeColor = System.Drawing.Color.Navy
        Me.agrIEFF.Location = New System.Drawing.Point(3, 69)
        Me.agrIEFF.Name = "agrIEFF"
        Me.agrIEFF.Size = New System.Drawing.Size(268, 53)
        Me.agrIEFF.TabIndex = 114
        Me.agrIEFF.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fechaMovimiento
        '
        Appearance103.ForeColor = System.Drawing.Color.Black
        Me.fechaMovimiento.Appearance = Appearance103
        Me.fechaMovimiento.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fechaMovimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fechaMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaMovimiento.ForeColor = System.Drawing.Color.Black
        Me.fechaMovimiento.Location = New System.Drawing.Point(164, 5)
        Me.fechaMovimiento.Name = "fechaMovimiento"
        Me.fechaMovimiento.ReadOnly = True
        Me.fechaMovimiento.Size = New System.Drawing.Size(96, 22)
        Me.fechaMovimiento.TabIndex = 3
        Me.fechaMovimiento.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        '
        'decImporte
        '
        Appearance104.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance104.ForeColor = System.Drawing.Color.Black
        Me.decImporte.Appearance = Appearance104
        Me.decImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.decImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporte.ForeColor = System.Drawing.Color.Black
        Me.decImporte.Location = New System.Drawing.Point(164, 26)
        Me.decImporte.MaskInput = "{double:6.2}"
        Me.decImporte.Name = "decImporte"
        Me.decImporte.Nullable = True
        Me.decImporte.NullText = "0.00"
        Me.decImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImporte.Size = New System.Drawing.Size(96, 22)
        Me.decImporte.TabIndex = 1
        '
        'Etiqueta2
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance105
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(107, 30)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta2.TabIndex = 70
        Me.Etiqueta2.Text = "Importe"
        '
        'Etiqueta30
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance106
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(113, 9)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta30.TabIndex = 70
        Me.Etiqueta30.Text = "Fecha"
        '
        'opcSalidaEntrada
        '
        Me.opcSalidaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.opcSalidaEntrada.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcSalidaEntrada.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcSalidaEntrada.CheckedIndex = 0
        Me.opcSalidaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcSalidaEntrada.ForeColor = System.Drawing.Color.Black
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        ValueListItem6.Appearance = Appearance107
        ValueListItem6.DataValue = "Default Item"
        ValueListItem6.DisplayText = "Salida de Caja"
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        ValueListItem7.Appearance = Appearance108
        ValueListItem7.DataValue = "ValueListItem1"
        ValueListItem7.DisplayText = "Ingreso a Caja"
        Me.opcSalidaEntrada.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7})
        Me.opcSalidaEntrada.ItemSpacingVertical = 5
        Me.opcSalidaEntrada.Location = New System.Drawing.Point(3, 8)
        Me.opcSalidaEntrada.Name = "opcSalidaEntrada"
        Me.opcSalidaEntrada.Size = New System.Drawing.Size(259, 40)
        Me.opcSalidaEntrada.TabIndex = 82
        Me.opcSalidaEntrada.Text = "Salida de Caja"
        '
        'etiLiquidar
        '
        Appearance109.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.etiLiquidar.Appearance = Appearance109
        Me.etiLiquidar.AutoSize = True
        Me.etiLiquidar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiLiquidar.ForeColor = System.Drawing.Color.Black
        Me.etiLiquidar.Location = New System.Drawing.Point(4, 128)
        Me.etiLiquidar.Name = "etiLiquidar"
        Me.etiLiquidar.Size = New System.Drawing.Size(174, 15)
        Me.etiLiquidar.TabIndex = 110
        Me.etiLiquidar.Text = "DISPONIBLE PARA LIQUIDAR"
        Me.etiLiquidar.Visible = False
        '
        'agrDatosViaje
        '
        Appearance110.BackColor = System.Drawing.Color.White
        Appearance110.BackColor2 = System.Drawing.Color.White
        Me.agrDatosViaje.ContentAreaAppearance = Appearance110
        Me.agrDatosViaje.Controls.Add(Me.txtCantidadPeajes)
        Me.agrDatosViaje.Controls.Add(Me.lblCantidadPeajes)
        Me.agrDatosViaje.Controls.Add(Me.txtTipoVehiculo)
        Me.agrDatosViaje.Controls.Add(Me.btnAgregarCostoEstiba)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta70)
        Me.agrDatosViaje.Controls.Add(Me.numCostoEstiba)
        Me.agrDatosViaje.Controls.Add(Me.txtCarreta)
        Me.agrDatosViaje.Controls.Add(Me.txtAyudante)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta69)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta68)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta62)
        Me.agrDatosViaje.Controls.Add(Me.btnActPeso)
        Me.agrDatosViaje.Controls.Add(Me.decPeso)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta61)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta5)
        Me.agrDatosViaje.Controls.Add(Me.UltraLabel1)
        Me.agrDatosViaje.Controls.Add(Me.txtCopiloto)
        Me.agrDatosViaje.Controls.Add(Me.txtTracto)
        Me.agrDatosViaje.Controls.Add(Me.txtViaje)
        Me.agrDatosViaje.Controls.Add(Me.fecFechaViaje)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta15)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta6)
        Me.agrDatosViaje.Controls.Add(Me.txtPiloto)
        Me.agrDatosViaje.Controls.Add(Me.txtEstado)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta8)
        Me.agrDatosViaje.Controls.Add(Me.UltraLabel3)
        Me.agrDatosViaje.Controls.Add(Me.Etiqueta10)
        Me.agrDatosViaje.Controls.Add(Me.txtRuta)
        Me.agrDatosViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosViaje.ForeColor = System.Drawing.Color.Black
        Me.agrDatosViaje.Location = New System.Drawing.Point(544, 5)
        Me.agrDatosViaje.Name = "agrDatosViaje"
        Me.agrDatosViaje.Size = New System.Drawing.Size(450, 135)
        Me.agrDatosViaje.TabIndex = 113
        Me.agrDatosViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCantidadPeajes
        '
        Appearance111.ForeColor = System.Drawing.Color.Black
        Me.txtCantidadPeajes.Appearance = Appearance111
        Me.txtCantidadPeajes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidadPeajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPeajes.ForeColor = System.Drawing.Color.Black
        Me.txtCantidadPeajes.Location = New System.Drawing.Point(333, 86)
        Me.txtCantidadPeajes.MaskInput = "{LOC}n,nnn"
        Me.txtCantidadPeajes.Name = "txtCantidadPeajes"
        Me.txtCantidadPeajes.NullText = "0.00"
        Me.txtCantidadPeajes.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtCantidadPeajes.ReadOnly = True
        Me.txtCantidadPeajes.Size = New System.Drawing.Size(43, 19)
        Me.txtCantidadPeajes.TabIndex = 123
        Me.txtCantidadPeajes.TabStop = False
        Me.txtCantidadPeajes.Visible = False
        '
        'lblCantidadPeajes
        '
        Appearance112.BackColor = System.Drawing.Color.Transparent
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidadPeajes.Appearance = Appearance112
        Me.lblCantidadPeajes.AutoSize = True
        Me.lblCantidadPeajes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPeajes.ForeColor = System.Drawing.Color.Black
        Me.lblCantidadPeajes.Location = New System.Drawing.Point(291, 91)
        Me.lblCantidadPeajes.Name = "lblCantidadPeajes"
        Me.lblCantidadPeajes.Size = New System.Drawing.Size(41, 15)
        Me.lblCantidadPeajes.TabIndex = 122
        Me.lblCantidadPeajes.Text = "Peajes:"
        Me.ToolTip1.SetToolTip(Me.lblCantidadPeajes, "Total de Peajes Configurados")
        Me.lblCantidadPeajes.Visible = False
        '
        'txtTipoVehiculo
        '
        Me.txtTipoVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(333, 68)
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.ReadOnly = True
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(110, 19)
        Me.txtTipoVehiculo.TabIndex = 121
        Me.txtTipoVehiculo.TabStop = False
        '
        'btnAgregarCostoEstiba
        '
        Appearance113.Image = CType(resources.GetObject("Appearance113.Image"), Object)
        Me.btnAgregarCostoEstiba.Appearance = Appearance113
        Me.btnAgregarCostoEstiba.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAgregarCostoEstiba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarCostoEstiba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCostoEstiba.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarCostoEstiba.Location = New System.Drawing.Point(413, 1)
        Me.btnAgregarCostoEstiba.Name = "btnAgregarCostoEstiba"
        Me.btnAgregarCostoEstiba.Size = New System.Drawing.Size(25, 23)
        Me.btnAgregarCostoEstiba.TabIndex = 121
        Me.btnAgregarCostoEstiba.TabStop = False
        '
        'Etiqueta70
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta70.Appearance = Appearance114
        Me.Etiqueta70.AutoSize = True
        Me.Etiqueta70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta70.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta70.Location = New System.Drawing.Point(303, 70)
        Me.Etiqueta70.Name = "Etiqueta70"
        Me.Etiqueta70.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta70.TabIndex = 120
        Me.Etiqueta70.Text = "Tipo:"
        '
        'numCostoEstiba
        '
        Appearance115.ForeColor = System.Drawing.Color.Black
        Me.numCostoEstiba.Appearance = Appearance115
        Me.numCostoEstiba.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCostoEstiba.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCostoEstiba.ForeColor = System.Drawing.Color.Black
        Me.numCostoEstiba.Location = New System.Drawing.Point(333, 3)
        Me.numCostoEstiba.MaskInput = "{double:4.2}"
        Me.numCostoEstiba.Name = "numCostoEstiba"
        Me.numCostoEstiba.NullText = "0.00"
        Me.numCostoEstiba.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCostoEstiba.Size = New System.Drawing.Size(54, 19)
        Me.numCostoEstiba.TabIndex = 120
        Me.numCostoEstiba.TabStop = False
        '
        'txtCarreta
        '
        Me.txtCarreta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarreta.Location = New System.Drawing.Point(333, 48)
        Me.txtCarreta.Name = "txtCarreta"
        Me.txtCarreta.ReadOnly = True
        Me.txtCarreta.Size = New System.Drawing.Size(77, 19)
        Me.txtCarreta.TabIndex = 119
        Me.txtCarreta.TabStop = False
        '
        'txtAyudante
        '
        Me.txtAyudante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAyudante.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAyudante.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAyudante.Location = New System.Drawing.Point(58, 88)
        Me.txtAyudante.Name = "txtAyudante"
        Me.txtAyudante.ReadOnly = True
        Me.txtAyudante.Size = New System.Drawing.Size(226, 19)
        Me.txtAyudante.TabIndex = 119
        Me.txtAyudante.TabStop = False
        '
        'Etiqueta69
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta69.Appearance = Appearance116
        Me.Etiqueta69.AutoSize = True
        Me.Etiqueta69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta69.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta69.Location = New System.Drawing.Point(288, 51)
        Me.Etiqueta69.Name = "Etiqueta69"
        Me.Etiqueta69.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta69.TabIndex = 118
        Me.Etiqueta69.Text = "Carreta:"
        '
        'Etiqueta68
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta68.Appearance = Appearance117
        Me.Etiqueta68.AutoSize = True
        Me.Etiqueta68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta68.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta68.Location = New System.Drawing.Point(295, 7)
        Me.Etiqueta68.Name = "Etiqueta68"
        Me.Etiqueta68.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta68.TabIndex = 119
        Me.Etiqueta68.Text = "C.Est.:"
        '
        'Etiqueta62
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta62.Appearance = Appearance118
        Me.Etiqueta62.AutoSize = True
        Me.Etiqueta62.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta62.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta62.Location = New System.Drawing.Point(3, 91)
        Me.Etiqueta62.Name = "Etiqueta62"
        Me.Etiqueta62.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta62.TabIndex = 118
        Me.Etiqueta62.Text = "Ayudante:"
        '
        'btnActPeso
        '
        Appearance119.Image = CType(resources.GetObject("Appearance119.Image"), Object)
        Me.btnActPeso.Appearance = Appearance119
        Me.btnActPeso.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActPeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActPeso.ForeColor = System.Drawing.Color.Black
        Me.btnActPeso.Location = New System.Drawing.Point(259, 3)
        Me.btnActPeso.Name = "btnActPeso"
        Me.btnActPeso.Size = New System.Drawing.Size(25, 23)
        Me.btnActPeso.TabIndex = 118
        Me.btnActPeso.TabStop = False
        Me.btnActPeso.Visible = False
        '
        'decPeso
        '
        Appearance120.ForeColor = System.Drawing.Color.Black
        Me.decPeso.Appearance = Appearance120
        Me.decPeso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPeso.ForeColor = System.Drawing.Color.Black
        Me.decPeso.Location = New System.Drawing.Point(214, 4)
        Me.decPeso.MaskInput = "{double:2.3}"
        Me.decPeso.Name = "decPeso"
        Me.decPeso.NullText = "0.00"
        Me.decPeso.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPeso.Size = New System.Drawing.Size(43, 19)
        Me.decPeso.TabIndex = 28
        Me.decPeso.TabStop = False
        Me.decPeso.Visible = False
        '
        'Etiqueta61
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta61.Appearance = Appearance121
        Me.Etiqueta61.AutoSize = True
        Me.Etiqueta61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta61.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta61.Location = New System.Drawing.Point(180, 7)
        Me.Etiqueta61.Name = "Etiqueta61"
        Me.Etiqueta61.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta61.TabIndex = 26
        Me.Etiqueta61.Text = "Peso:"
        Me.Etiqueta61.Visible = False
        '
        'Etiqueta5
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance122
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(288, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta5.TabIndex = 10
        Me.Etiqueta5.Text = "Tracto:"
        '
        'UltraLabel1
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Appearance123.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance123
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 7)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel1.TabIndex = 25
        Me.UltraLabel1.Text = "Estado:"
        '
        'txtCopiloto
        '
        Me.txtCopiloto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCopiloto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopiloto.Location = New System.Drawing.Point(58, 68)
        Me.txtCopiloto.Name = "txtCopiloto"
        Me.txtCopiloto.ReadOnly = True
        Me.txtCopiloto.Size = New System.Drawing.Size(226, 19)
        Me.txtCopiloto.TabIndex = 3
        Me.txtCopiloto.TabStop = False
        '
        'txtTracto
        '
        Me.txtTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTracto.Location = New System.Drawing.Point(333, 27)
        Me.txtTracto.Name = "txtTracto"
        Me.txtTracto.ReadOnly = True
        Me.txtTracto.Size = New System.Drawing.Size(77, 19)
        Me.txtTracto.TabIndex = 4
        Me.txtTracto.TabStop = False
        '
        'txtViaje
        '
        Me.txtViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViaje.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViaje.Location = New System.Drawing.Point(58, 28)
        Me.txtViaje.Name = "txtViaje"
        Me.txtViaje.ReadOnly = True
        Me.txtViaje.Size = New System.Drawing.Size(110, 19)
        Me.txtViaje.TabIndex = 1
        Me.txtViaje.TabStop = False
        '
        'fecFechaViaje
        '
        Appearance124.ForeColor = System.Drawing.Color.Black
        Me.fecFechaViaje.Appearance = Appearance124
        Me.fecFechaViaje.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fecFechaViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaViaje.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecFechaViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaViaje.ForeColor = System.Drawing.Color.Black
        Me.fecFechaViaje.Location = New System.Drawing.Point(214, 27)
        Me.fecFechaViaje.Name = "fecFechaViaje"
        Me.fecFechaViaje.ReadOnly = True
        Me.fecFechaViaje.Size = New System.Drawing.Size(70, 19)
        Me.fecFechaViaje.TabIndex = 8
        Me.fecFechaViaje.TabStop = False
        Me.fecFechaViaje.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        '
        'Etiqueta15
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance125
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(8, 70)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta15.TabIndex = 9
        Me.Etiqueta15.Text = "Copiloto:"
        '
        'Etiqueta6
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance126
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(26, 112)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta6.TabIndex = 7
        Me.Etiqueta6.Text = "Ruta:"
        '
        'txtPiloto
        '
        Me.txtPiloto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPiloto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiloto.Location = New System.Drawing.Point(58, 48)
        Me.txtPiloto.Name = "txtPiloto"
        Me.txtPiloto.ReadOnly = True
        Me.txtPiloto.Size = New System.Drawing.Size(226, 19)
        Me.txtPiloto.TabIndex = 2
        Me.txtPiloto.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(58, 5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(110, 19)
        Me.txtEstado.TabIndex = 2
        Me.txtEstado.TabStop = False
        '
        'Etiqueta8
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance127
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(174, 30)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta8.TabIndex = 14
        Me.Etiqueta8.Text = "Fecha:"
        '
        'UltraLabel3
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Appearance128.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance128
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(9, 31)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel3.TabIndex = 25
        Me.UltraLabel3.Text = "N° Viaje:"
        '
        'Etiqueta10
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance129
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(21, 51)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "Piloto:"
        '
        'txtRuta
        '
        Me.txtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(58, 108)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(385, 19)
        Me.txtRuta.TabIndex = 5
        Me.txtRuta.TabStop = False
        '
        'FicDatos
        '
        Me.FicDatos.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.FicDatos.Controls.Add(Me.UltraTabPageControl10)
        Me.FicDatos.Controls.Add(Me.UltraTabPageControl11)
        Me.FicDatos.Controls.Add(Me.UltraTabPageControl17)
        Me.FicDatos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FicDatos.Location = New System.Drawing.Point(1, 133)
        Me.FicDatos.Name = "FicDatos"
        Me.FicDatos.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.FicDatos.Size = New System.Drawing.Size(250, 97)
        Me.FicDatos.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.FicDatos.TabIndex = 112
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Recepcion Dinero"
        UltraTab11.TabPage = Me.UltraTabPageControl11
        UltraTab11.Text = "Cheque"
        UltraTab12.TabPage = Me.UltraTabPageControl17
        UltraTab12.Text = "Efectivo"
        Me.FicDatos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11, UltraTab12})
        Me.FicDatos.TabStop = False
        Me.FicDatos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(248, 74)
        '
        'cboCaja
        '
        Appearance139.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaja.Appearance = Appearance139
        Me.cboCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCaja.DisplayMember = "Nombre"
        Me.cboCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCaja.Enabled = False
        Me.cboCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaja.Location = New System.Drawing.Point(48, 3)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(202, 22)
        Me.cboCaja.TabIndex = 1
        Me.cboCaja.TabStop = False
        Me.cboCaja.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance140
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(7, 38)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta1.TabIndex = 72
        Me.Etiqueta1.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(48, 36)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(203, 87)
        Me.txtGlosa.TabIndex = 7
        '
        'opcDefinicion
        '
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Me.opcDefinicion.Appearance = Appearance141
        Me.opcDefinicion.BackColor = System.Drawing.Color.Transparent
        Me.opcDefinicion.BackColorInternal = System.Drawing.Color.Transparent
        Me.opcDefinicion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcDefinicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcDefinicion.ForeColor = System.Drawing.Color.Black
        ValueListItem8.DataValue = "Default Item"
        ValueListItem8.DisplayText = "Caja"
        Me.opcDefinicion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem8})
        Me.opcDefinicion.ItemSpacingVertical = 13
        Me.opcDefinicion.Location = New System.Drawing.Point(6, -1)
        Me.opcDefinicion.Name = "opcDefinicion"
        Me.opcDefinicion.Size = New System.Drawing.Size(71, 28)
        Me.opcDefinicion.TabIndex = 0
        Me.opcDefinicion.TabStop = False
        '
        'Etiqueta28
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance142
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(848, 242)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(16, 14)
        Me.Etiqueta28.TabIndex = 70
        Me.Etiqueta28.Text = "Nº"
        Me.Etiqueta28.Visible = False
        '
        'fechaBalancin
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.fechaBalancin.Appearance = Appearance143
        Me.fechaBalancin.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fechaBalancin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fechaBalancin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaBalancin.ForeColor = System.Drawing.Color.Black
        Me.fechaBalancin.Location = New System.Drawing.Point(869, 254)
        Me.fechaBalancin.Name = "fechaBalancin"
        Me.fechaBalancin.Size = New System.Drawing.Size(10, 21)
        Me.fechaBalancin.TabIndex = 6
        Me.fechaBalancin.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fechaBalancin.Visible = False
        '
        'Etiqueta29
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance144
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(848, 260)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta29.TabIndex = 71
        Me.Etiqueta29.Text = "Fec"
        Me.Etiqueta29.Visible = False
        '
        'opcTipoMovimiento
        '
        Me.opcTipoMovimiento.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.opcTipoMovimiento.CheckedIndex = 0
        Me.opcTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcTipoMovimiento.ForeColor = System.Drawing.Color.Black
        ValueListItem10.DataValue = "Default Item"
        ValueListItem10.DisplayText = "Viaje"
        ValueListItem11.DataValue = "ValueListItem1"
        ValueListItem11.DisplayText = "Administrativo"
        ValueListItem12.DataValue = "ValueListItem2"
        ValueListItem12.DisplayText = "Caja"
        Me.opcTipoMovimiento.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem10, ValueListItem11, ValueListItem12})
        Me.opcTipoMovimiento.Location = New System.Drawing.Point(73, 169)
        Me.opcTipoMovimiento.Name = "opcTipoMovimiento"
        Me.opcTipoMovimiento.Size = New System.Drawing.Size(163, 41)
        Me.opcTipoMovimiento.TabIndex = 82
        Me.opcTipoMovimiento.Text = "Viaje"
        '
        'ExpGroupBoxReceptor
        '
        Me.ExpGroupBoxReceptor.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.ExpGroupBoxReceptor.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpGroupBoxReceptor.ExpandedSize = New System.Drawing.Size(155, 234)
        Me.ExpGroupBoxReceptor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpGroupBoxReceptor.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.ExpGroupBoxReceptor.Location = New System.Drawing.Point(3, 17)
        Me.ExpGroupBoxReceptor.Name = "ExpGroupBoxReceptor"
        Me.ExpGroupBoxReceptor.Size = New System.Drawing.Size(155, 234)
        Me.ExpGroupBoxReceptor.TabIndex = 26
        Me.ExpGroupBoxReceptor.TabStop = False
        Me.ExpGroupBoxReceptor.Text = "Persona quien recibe la bolsa"
        Me.ExpGroupBoxReceptor.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.upbFoto)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.picRecibidor)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(127, 228)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'upbFoto
        '
        Me.upbFoto.BorderShadowColor = System.Drawing.Color.Empty
        Me.upbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upbFoto.Location = New System.Drawing.Point(0, 0)
        Me.upbFoto.Name = "upbFoto"
        Me.upbFoto.Size = New System.Drawing.Size(127, 228)
        Me.upbFoto.TabIndex = 105
        '
        'picRecibidor
        '
        Me.picRecibidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRecibidor.Location = New System.Drawing.Point(8, 45)
        Me.picRecibidor.Name = "picRecibidor"
        Me.picRecibidor.Size = New System.Drawing.Size(116, 137)
        Me.picRecibidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRecibidor.TabIndex = 104
        Me.picRecibidor.TabStop = False
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.agrDetalleGasto)
        Me.UltraTabPageControl4.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1175, 601)
        '
        'agrDetalleGasto
        '
        Me.agrDetalleGasto.Controls.Add(Me.agrGastoOperacion)
        Me.agrDetalleGasto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalleGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalleGasto.ForeColor = System.Drawing.Color.Black
        Me.agrDetalleGasto.Location = New System.Drawing.Point(0, 330)
        Me.agrDetalleGasto.Name = "agrDetalleGasto"
        Me.agrDetalleGasto.Size = New System.Drawing.Size(1175, 271)
        Me.agrDetalleGasto.TabIndex = 1
        Me.agrDetalleGasto.Text = "Detalle Gasto:"
        Me.agrDetalleGasto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrGastoOperacion
        '
        Me.agrGastoOperacion.Controls.Add(Me.ugb_Espera)
        Me.agrGastoOperacion.Controls.Add(Me.griGastoOperacion)
        Me.agrGastoOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrGastoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGastoOperacion.ForeColor = System.Drawing.Color.Black
        Me.agrGastoOperacion.Location = New System.Drawing.Point(3, 16)
        Me.agrGastoOperacion.Name = "agrGastoOperacion"
        Me.agrGastoOperacion.Size = New System.Drawing.Size(1169, 252)
        Me.agrGastoOperacion.TabIndex = 0
        Me.agrGastoOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(408, 36)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 10
        Me.ugb_Espera.Visible = False
        '
        'griGastoOperacion
        '
        Me.griGastoOperacion.CalcManager = Me.UltraCalcManager
        Me.griGastoOperacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griGastoOperacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griGastoOperacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGastoOperacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griGastoOperacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griGastoOperacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griGastoOperacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griGastoOperacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griGastoOperacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griGastoOperacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griGastoOperacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griGastoOperacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griGastoOperacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griGastoOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGastoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGastoOperacion.Location = New System.Drawing.Point(2, 2)
        Me.griGastoOperacion.Name = "griGastoOperacion"
        Me.griGastoOperacion.Size = New System.Drawing.Size(1165, 248)
        Me.griGastoOperacion.TabIndex = 0
        Me.griGastoOperacion.TabStop = False
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.ExpandedSize = New System.Drawing.Size(1175, 330)
        Me.agrDatos.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Far
        Me.agrDatos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.HeaderClickAction = Infragistics.Win.Misc.GroupBoxHeaderClickAction.None
        Me.agrDatos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.ShowFocus = False
        Me.agrDatos.Size = New System.Drawing.Size(1175, 330)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.TabStop = False
        Me.agrDatos.Text = "Datos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.agrContenedor1)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(1169, 307)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'agrContenedor1
        '
        Me.agrContenedor1.Controls.Add(Me.cboLugarL)
        Me.agrContenedor1.Controls.Add(Me.expTarjetaMovimiento)
        Me.agrContenedor1.Controls.Add(Me.expDocumento)
        Me.agrContenedor1.Controls.Add(Me.cboProveedores)
        Me.agrContenedor1.Controls.Add(Me.fecHoraPeaje)
        Me.agrContenedor1.Controls.Add(Me.etiRuta)
        Me.agrContenedor1.Controls.Add(Me.dtpFecVencimiento)
        Me.agrContenedor1.Controls.Add(Me.dtpFechaEmision)
        Me.agrContenedor1.Controls.Add(Me.btnNuevoProveedor)
        Me.agrContenedor1.Controls.Add(Me.ExpRegistroConsumoCombustible)
        Me.agrContenedor1.Controls.Add(Me.cboRuta)
        Me.agrContenedor1.Controls.Add(Me.etiTipoGasto)
        Me.agrContenedor1.Controls.Add(Me.etiRuc)
        Me.agrContenedor1.Controls.Add(Me.agrTotalGasto)
        Me.agrContenedor1.Controls.Add(Me.cboGrupo)
        Me.agrContenedor1.Controls.Add(Me.etiPeriodo)
        Me.agrContenedor1.Controls.Add(Me.etiFechavencimiento)
        Me.agrContenedor1.Controls.Add(Me.etiNroGrupo)
        Me.agrContenedor1.Controls.Add(Me.fecPeriodo)
        Me.agrContenedor1.Controls.Add(Me.txtRUC)
        Me.agrContenedor1.Controls.Add(Me.cboTipoDocumento)
        Me.agrContenedor1.Controls.Add(Me.etiProveedor)
        Me.agrContenedor1.Controls.Add(Me.cboFlujoCaja)
        Me.agrContenedor1.Controls.Add(Me.txtNumero)
        Me.agrContenedor1.Controls.Add(Me.etiGlosa)
        Me.agrContenedor1.Controls.Add(Me.txtSerie)
        Me.agrContenedor1.Controls.Add(Me.etiNumero)
        Me.agrContenedor1.Controls.Add(Me.Agrupacion3)
        Me.agrContenedor1.Controls.Add(Me.txtGlosa2)
        Me.agrContenedor1.Controls.Add(Me.etiSerie)
        Me.agrContenedor1.Controls.Add(Me.etiFechaDoc)
        Me.agrContenedor1.Controls.Add(Me.etiTipoDocumento)
        Me.agrContenedor1.Controls.Add(Me.agrDatoOperacion)
        Me.agrContenedor1.Controls.Add(Me.cboTipoGasto)
        Me.agrContenedor1.Controls.Add(Me.etiFlujoCaja)
        Me.agrContenedor1.Controls.Add(Me.cboAutorizaGasto)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta34)
        Me.agrContenedor1.Controls.Add(Me.DecPercepcion)
        Me.agrContenedor1.Controls.Add(Me.DecNoGravada)
        Me.agrContenedor1.Controls.Add(Me.numIGV)
        Me.agrContenedor1.Controls.Add(Me.numTotal)
        Me.agrContenedor1.Controls.Add(Me.numImporte)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta54)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta47)
        Me.agrContenedor1.Controls.Add(Me.Importe)
        Me.agrContenedor1.Controls.Add(Me.etiIGV)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta36)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta19)
        Me.agrContenedor1.Controls.Add(Me.DecPagoxCaja)
        Me.agrContenedor1.Controls.Add(Me.numGasto)
        Me.agrContenedor1.Controls.Add(Me.numTipoCambio)
        Me.agrContenedor1.Controls.Add(Me.etiTipoCambio)
        Me.agrContenedor1.Controls.Add(Me.cboMoneda)
        Me.agrContenedor1.Controls.Add(Me.etiMoneda)
        Me.agrContenedor1.Controls.Add(Me.chkPagoxCaja)
        Me.agrContenedor1.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.agrContenedor1.Controls.Add(Me.cboOpcionGasto)
        Me.agrContenedor1.Controls.Add(Me.cboReferencia)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta48)
        Me.agrContenedor1.Controls.Add(Me.Etiqueta45)
        Me.agrContenedor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrContenedor1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrContenedor1.ForeColor = System.Drawing.Color.Black
        Me.agrContenedor1.Location = New System.Drawing.Point(0, 0)
        Me.agrContenedor1.Name = "agrContenedor1"
        Me.agrContenedor1.Size = New System.Drawing.Size(1169, 307)
        Me.agrContenedor1.TabIndex = 0
        Me.agrContenedor1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboLugarL
        '
        Appearance145.ForeColor = System.Drawing.Color.Black
        Me.cboLugarL.Appearance = Appearance145
        Me.cboLugarL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance146.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        EditorButton2.Appearance = Appearance146
        Me.cboLugarL.ButtonsRight.Add(EditorButton2)
        Me.cboLugarL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarL.DropDownListWidth = 350
        Me.cboLugarL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarL.ForeColor = System.Drawing.Color.Black
        Me.cboLugarL.Location = New System.Drawing.Point(27, 100)
        Me.cboLugarL.Name = "cboLugarL"
        Me.cboLugarL.Size = New System.Drawing.Size(169, 22)
        Me.cboLugarL.TabIndex = 21
        Me.cboLugarL.ValueMember = "Id"
        Me.cboLugarL.Visible = False
        '
        'expTarjetaMovimiento
        '
        Me.expTarjetaMovimiento.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.expTarjetaMovimiento.Dock = System.Windows.Forms.DockStyle.Right
        Me.expTarjetaMovimiento.Expanded = False
        Me.expTarjetaMovimiento.ExpandedSize = New System.Drawing.Size(400, 301)
        Me.expTarjetaMovimiento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder
        Me.expTarjetaMovimiento.Location = New System.Drawing.Point(1120, 3)
        Me.expTarjetaMovimiento.Name = "expTarjetaMovimiento"
        Me.expTarjetaMovimiento.Size = New System.Drawing.Size(23, 301)
        Me.expTarjetaMovimiento.TabIndex = 49
        Me.expTarjetaMovimiento.TabStop = False
        Me.expTarjetaMovimiento.Text = "Agregar Peaje "
        Me.expTarjetaMovimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.griMovTarjeta)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(372, 295)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel6.Visible = False
        '
        'griMovTarjeta
        '
        Me.griMovTarjeta.CalcManager = Me.UltraCalcManager
        Me.griMovTarjeta.DataSource = Me.udsMovimientoTarjeta
        UltraGridColumn227.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn227.Header.VisiblePosition = 0
        UltraGridColumn227.Hidden = True
        UltraGridColumn227.Width = 27
        UltraGridColumn228.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn228.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn228.Header.VisiblePosition = 1
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn229.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn229.Header.VisiblePosition = 2
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn230.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn230.Header.VisiblePosition = 4
        UltraGridColumn230.Width = 61
        UltraGridColumn231.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn231.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn231.Format = "dd/MM/yyyy hh:mm:ss tt"
        UltraGridColumn231.Header.VisiblePosition = 3
        UltraGridColumn231.Width = 123
        UltraGridColumn232.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn232.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn232.Header.VisiblePosition = 16
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance147.TextHAlignAsString = "Right"
        UltraGridColumn233.CellAppearance = Appearance147
        UltraGridColumn233.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn233.Format = "###,##0.00"
        UltraGridColumn233.Header.Caption = "Monto (S/.)"
        UltraGridColumn233.Header.VisiblePosition = 5
        UltraGridColumn233.Width = 57
        UltraGridColumn234.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn234.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn234.Header.VisiblePosition = 6
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn235.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn235.Header.Caption = "CodLugar"
        UltraGridColumn235.Header.VisiblePosition = 7
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn236.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn236.Header.VisiblePosition = 9
        UltraGridColumn236.Width = 62
        UltraGridColumn237.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn237.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn237.Header.VisiblePosition = 10
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn238.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn238.Header.VisiblePosition = 17
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn239.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn239.Header.VisiblePosition = 11
        UltraGridColumn239.Hidden = True
        UltraGridColumn240.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn240.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn240.Header.VisiblePosition = 12
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.VisiblePosition = 13
        UltraGridColumn241.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 14
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 15
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 18
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 19
        UltraGridColumn245.Hidden = True
        UltraGridColumn246.Header.Caption = "Lugar"
        UltraGridColumn246.Header.VisiblePosition = 8
        UltraGridColumn246.Width = 118
        UltraGridColumn247.Header.VisiblePosition = 20
        UltraGridColumn247.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247})
        Me.griMovTarjeta.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griMovTarjeta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMovTarjeta.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovTarjeta.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griMovTarjeta.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovTarjeta.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovTarjeta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovTarjeta.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovTarjeta.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMovTarjeta.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovTarjeta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovTarjeta.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never
        Me.griMovTarjeta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovTarjeta.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovTarjeta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMovTarjeta.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griMovTarjeta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMovTarjeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovTarjeta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovTarjeta.Location = New System.Drawing.Point(0, 35)
        Me.griMovTarjeta.Name = "griMovTarjeta"
        Me.griMovTarjeta.Size = New System.Drawing.Size(372, 260)
        Me.griMovTarjeta.TabIndex = 10
        Me.griMovTarjeta.TabStop = False
        Me.griMovTarjeta.Tag = ""
        '
        'udsMovimientoTarjeta
        '
        UltraDataColumn86.DataType = GetType(Boolean)
        UltraDataColumn90.DataType = GetType(Date)
        UltraDataColumn92.DataType = GetType(Decimal)
        UltraDataColumn96.DataType = GetType(Boolean)
        UltraDataColumn99.DataType = GetType(Date)
        UltraDataColumn101.DataType = GetType(Date)
        UltraDataColumn102.DataType = GetType(Boolean)
        Me.udsMovimientoTarjeta.Band.Columns.AddRange(New Object() {UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnListar)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDesde)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.dtpHasta)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(372, 35)
        Me.UltraGroupBox1.TabIndex = 8
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListar
        '
        Appearance148.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListar.Appearance = Appearance148
        Me.btnListar.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(233, 6)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "Listar"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(38, 9)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(79, 18)
        Me.dtpDesde.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 11)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(151, 9)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(76, 18)
        Me.dtpHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 11)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'expDocumento
        '
        Me.expDocumento.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.expDocumento.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.expDocumento.Dock = System.Windows.Forms.DockStyle.Left
        Me.expDocumento.Expanded = False
        Me.expDocumento.ExpandedSize = New System.Drawing.Size(678, 301)
        Me.expDocumento.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.expDocumento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.expDocumento.Location = New System.Drawing.Point(3, 3)
        Me.expDocumento.Name = "expDocumento"
        Me.expDocumento.Size = New System.Drawing.Size(23, 301)
        Me.expDocumento.TabIndex = 0
        Me.expDocumento.TabStop = False
        Me.expDocumento.Text = "Compras para Almacen"
        Me.expDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.expDocumento.Visible = False
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Ficha1)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Agrupacion9)
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(650, 295)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel11.Visible = False
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage8)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl18)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl19)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 104)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage8
        Me.Ficha1.Size = New System.Drawing.Size(650, 191)
        Me.Ficha1.TabIndex = 319
        UltraTab4.TabPage = Me.UltraTabPageControl18
        UltraTab4.Text = "Documento"
        UltraTab8.TabPage = Me.UltraTabPageControl19
        UltraTab8.Text = "OrdenAsociada"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab8})
        Me.Ficha1.TabStop = False
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage8
        '
        Me.UltraTabSharedControlsPage8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage8.Name = "UltraTabSharedControlsPage8"
        Me.UltraTabSharedControlsPage8.Size = New System.Drawing.Size(648, 168)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.cboDocumentoAlmacen)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta46)
        Me.Agrupacion9.Controls.Add(Me.btnBuscarDocumento)
        Me.Agrupacion9.Controls.Add(Me.gbNroDoc)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(650, 104)
        Me.Agrupacion9.TabIndex = 318
        Me.Agrupacion9.Text = "Documento"
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboDocumentoAlmacen
        '
        Appearance153.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Appearance = Appearance153
        Me.cboDocumentoAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDocumentoAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDocumentoAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDocumentoAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocumentoAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboDocumentoAlmacen.Location = New System.Drawing.Point(13, 53)
        Me.cboDocumentoAlmacen.Name = "cboDocumentoAlmacen"
        Me.cboDocumentoAlmacen.Size = New System.Drawing.Size(261, 22)
        Me.cboDocumentoAlmacen.TabIndex = 1
        Me.cboDocumentoAlmacen.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta46
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance154
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(14, 36)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta46.TabIndex = 332
        Me.Etiqueta46.Text = "Tipo Documento:"
        '
        'btnBuscarDocumento
        '
        Me.btnBuscarDocumento.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDocumento.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarDocumento.Location = New System.Drawing.Point(467, 50)
        Me.btnBuscarDocumento.Name = "btnBuscarDocumento"
        Me.btnBuscarDocumento.Size = New System.Drawing.Size(83, 25)
        Me.btnBuscarDocumento.TabIndex = 999
        Me.btnBuscarDocumento.Text = "Buscar"
        '
        'gbNroDoc
        '
        Me.gbNroDoc.BackColor = System.Drawing.Color.Transparent
        Me.gbNroDoc.Controls.Add(Me.txtSerieDoc)
        Me.gbNroDoc.Controls.Add(Me.txtNumeroDoc)
        Me.gbNroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNroDoc.ForeColor = System.Drawing.Color.Navy
        Me.gbNroDoc.Location = New System.Drawing.Point(283, 31)
        Me.gbNroDoc.Name = "gbNroDoc"
        Me.gbNroDoc.Size = New System.Drawing.Size(178, 51)
        Me.gbNroDoc.TabIndex = 328
        Me.gbNroDoc.TabStop = False
        Me.gbNroDoc.Text = "N° de Documento:"
        '
        'txtSerieDoc
        '
        Me.txtSerieDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieDoc.Location = New System.Drawing.Point(20, 22)
        Me.txtSerieDoc.MaxLength = 4
        Me.txtSerieDoc.Name = "txtSerieDoc"
        Me.txtSerieDoc.Size = New System.Drawing.Size(42, 22)
        Me.txtSerieDoc.TabIndex = 2
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDoc.Location = New System.Drawing.Point(68, 22)
        Me.txtNumeroDoc.MaxLength = 10
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(102, 22)
        Me.txtNumeroDoc.TabIndex = 3
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance155.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton3.Appearance = Appearance155
        Me.cboProveedores.ButtonsRight.Add(EditorButton3)
        Me.cboProveedores.CalcManager = Me.UltraCalcManager
        Me.cboProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedores.CheckedListSettings.ListSeparator = ","
        Me.cboProveedores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn165.Header.VisiblePosition = 0
        UltraGridColumn165.Hidden = True
        UltraGridColumn165.Width = 19
        UltraGridColumn166.Header.VisiblePosition = 1
        UltraGridColumn166.Hidden = True
        UltraGridColumn166.Width = 18
        UltraGridColumn167.Header.VisiblePosition = 2
        UltraGridColumn167.Hidden = True
        UltraGridColumn167.Width = 31
        UltraGridColumn168.Header.VisiblePosition = 3
        UltraGridColumn168.Hidden = True
        UltraGridColumn168.Width = 28
        UltraGridColumn169.Header.VisiblePosition = 4
        UltraGridColumn169.Hidden = True
        UltraGridColumn169.Width = 25
        UltraGridColumn170.Header.VisiblePosition = 5
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.Width = 17
        UltraGridColumn171.Header.VisiblePosition = 6
        UltraGridColumn171.Hidden = True
        UltraGridColumn171.Width = 25
        UltraGridColumn172.Header.VisiblePosition = 7
        UltraGridColumn172.Hidden = True
        UltraGridColumn172.Width = 25
        UltraGridColumn173.Header.VisiblePosition = 8
        UltraGridColumn173.Hidden = True
        UltraGridColumn173.Width = 25
        UltraGridColumn174.Header.VisiblePosition = 9
        UltraGridColumn174.Hidden = True
        UltraGridColumn174.Width = 54
        UltraGridColumn175.Header.VisiblePosition = 10
        UltraGridColumn175.Width = 200
        UltraGridColumn176.Header.VisiblePosition = 11
        UltraGridColumn176.Hidden = True
        UltraGridColumn176.Width = 54
        UltraGridColumn177.Header.VisiblePosition = 12
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.Width = 55
        UltraGridColumn178.Header.VisiblePosition = 13
        UltraGridColumn178.Width = 198
        UltraGridColumn179.Header.VisiblePosition = 14
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 15
        UltraGridColumn180.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180})
        Me.cboProveedores.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cboProveedores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedores.DropDownWidth = 400
        Me.cboProveedores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedores.Location = New System.Drawing.Point(293, 99)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(250, 23)
        Me.cboProveedores.TabIndex = 25
        '
        'fecHoraPeaje
        '
        Me.fecHoraPeaje.CustomFormat = "HH:mm"
        Me.fecHoraPeaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecHoraPeaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecHoraPeaje.Location = New System.Drawing.Point(615, 60)
        Me.fecHoraPeaje.Name = "fecHoraPeaje"
        Me.fecHoraPeaje.ShowUpDown = True
        Me.fecHoraPeaje.Size = New System.Drawing.Size(53, 21)
        Me.fecHoraPeaje.TabIndex = 18
        Me.fecHoraPeaje.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        Me.fecHoraPeaje.Visible = False
        '
        'etiRuta
        '
        Appearance156.BackColor = System.Drawing.Color.Transparent
        Appearance156.ForeColor = System.Drawing.Color.Navy
        Me.etiRuta.Appearance = Appearance156
        Me.etiRuta.AutoSize = True
        Me.etiRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuta.ForeColor = System.Drawing.Color.Black
        Me.etiRuta.Location = New System.Drawing.Point(807, 217)
        Me.etiRuta.Name = "etiRuta"
        Me.etiRuta.Size = New System.Drawing.Size(30, 14)
        Me.etiRuta.TabIndex = 44
        Me.etiRuta.Text = "Ruta:"
        Me.etiRuta.Visible = False
        '
        'dtpFecVencimiento
        '
        Me.dtpFecVencimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVencimiento.Location = New System.Drawing.Point(631, 60)
        Me.dtpFecVencimiento.Name = "dtpFecVencimiento"
        Me.dtpFecVencimiento.Size = New System.Drawing.Size(85, 21)
        Me.dtpFecVencimiento.TabIndex = 19
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(530, 61)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(79, 21)
        Me.dtpFechaEmision.TabIndex = 16
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(543, 97)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(25, 25)
        Me.btnNuevoProveedor.TabIndex = 26
        Me.btnNuevoProveedor.TabStop = False
        Me.btnNuevoProveedor.Text = "Reg. Proveedor"
        '
        'ExpRegistroConsumoCombustible
        '
        Me.ExpRegistroConsumoCombustible.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.ExpRegistroConsumoCombustible.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpRegistroConsumoCombustible.Expanded = False
        Me.ExpRegistroConsumoCombustible.ExpandedSize = New System.Drawing.Size(294, 301)
        Me.ExpRegistroConsumoCombustible.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder
        Me.ExpRegistroConsumoCombustible.Location = New System.Drawing.Point(1143, 3)
        Me.ExpRegistroConsumoCombustible.Name = "ExpRegistroConsumoCombustible"
        Me.ExpRegistroConsumoCombustible.Size = New System.Drawing.Size(23, 301)
        Me.ExpRegistroConsumoCombustible.TabIndex = 48
        Me.ExpRegistroConsumoCombustible.TabStop = False
        Me.ExpRegistroConsumoCombustible.Text = "Registro Consumo de Combustible"
        Me.ExpRegistroConsumoCombustible.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.ExpRegistroConsumoCombustible.Visible = False
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Agrupacion4)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(266, 295)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel8.Visible = False
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Etiqueta38)
        Me.Agrupacion4.Controls.Add(Me.cboLugar)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta39)
        Me.Agrupacion4.Controls.Add(Me.cboDireccion)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 75)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(266, 220)
        Me.Agrupacion4.TabIndex = 315
        Me.Agrupacion4.Text = "Datos Grifo"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta38
        '
        Appearance157.BackColor = System.Drawing.Color.Transparent
        Appearance157.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance157
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(18, 26)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta38.TabIndex = 21
        Me.Etiqueta38.Text = "Lugar:"
        '
        'cboLugar
        '
        Appearance158.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance158
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayMember = "Nombre"
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboLugar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(59, 21)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(201, 22)
        Me.cboLugar.TabIndex = 311
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta39
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Appearance159.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance159
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(6, 48)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta39.TabIndex = 21
        Me.Etiqueta39.Text = "Direccion:"
        '
        'cboDireccion
        '
        Appearance160.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Appearance = Appearance160
        Me.cboDireccion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboDireccion.DisplayMember = "Nombre"
        Me.cboDireccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDireccion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDireccion.ForeColor = System.Drawing.Color.Black
        Me.cboDireccion.Location = New System.Drawing.Point(6, 68)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(257, 22)
        Me.cboDireccion.TabIndex = 313
        Me.cboDireccion.ValueMember = "Id"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Controls.Add(Me.DecCantidadGalones)
        Me.Agrupacion2.Controls.Add(Me.cboMaterial)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(266, 75)
        Me.Agrupacion2.TabIndex = 314
        Me.Agrupacion2.Text = "Datos a Ingresar"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta22
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Appearance161.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance161
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(4, 23)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(111, 15)
        Me.Etiqueta22.TabIndex = 21
        Me.Etiqueta22.Text = "Cantidad de Galones:"
        '
        'DecCantidadGalones
        '
        Appearance162.ForeColor = System.Drawing.Color.Black
        Me.DecCantidadGalones.Appearance = Appearance162
        Me.DecCantidadGalones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecCantidadGalones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecCantidadGalones.ForeColor = System.Drawing.Color.Black
        Me.DecCantidadGalones.Location = New System.Drawing.Point(121, 19)
        Me.DecCantidadGalones.MaskInput = "{double:4.3}"
        Me.DecCantidadGalones.MaxValue = 1000.0R
        Me.DecCantidadGalones.MinValue = 0R
        Me.DecCantidadGalones.Name = "DecCantidadGalones"
        Me.DecCantidadGalones.NullText = "0.00"
        Me.DecCantidadGalones.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecCantidadGalones.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecCantidadGalones.Size = New System.Drawing.Size(54, 22)
        Me.DecCantidadGalones.TabIndex = 26
        '
        'cboMaterial
        '
        Appearance163.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Appearance = Appearance163
        Me.cboMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMaterial.DisplayMember = "Nombre"
        Me.cboMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterial.ForeColor = System.Drawing.Color.Black
        Me.cboMaterial.Location = New System.Drawing.Point(56, 46)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(204, 22)
        Me.cboMaterial.TabIndex = 27
        Me.cboMaterial.ValueMember = "Id"
        '
        'Etiqueta27
        '
        Appearance164.BackColor = System.Drawing.Color.Transparent
        Appearance164.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance164
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(4, 50)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta27.TabIndex = 21
        Me.Etiqueta27.Text = "Material:"
        '
        'cboRuta
        '
        Appearance165.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Appearance = Appearance165
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.Black
        Me.cboRuta.Location = New System.Drawing.Point(843, 214)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(245, 21)
        Me.cboRuta.TabIndex = 45
        Me.cboRuta.TabStop = False
        Me.cboRuta.ValueMember = "Id"
        Me.cboRuta.Visible = False
        '
        'etiTipoGasto
        '
        Appearance166.BackColor = System.Drawing.Color.Transparent
        Appearance166.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoGasto.Appearance = Appearance166
        Me.etiTipoGasto.AutoSize = True
        Me.etiTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.etiTipoGasto.Location = New System.Drawing.Point(234, 5)
        Me.etiTipoGasto.Name = "etiTipoGasto"
        Me.etiTipoGasto.Size = New System.Drawing.Size(62, 15)
        Me.etiTipoGasto.TabIndex = 5
        Me.etiTipoGasto.Text = "Tipo Gasto:"
        '
        'etiRuc
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Me.etiRuc.Appearance = Appearance167
        Me.etiRuc.AutoSize = True
        Me.etiRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRuc.ForeColor = System.Drawing.Color.Black
        Me.etiRuc.Location = New System.Drawing.Point(201, 86)
        Me.etiRuc.Name = "etiRuc"
        Me.etiRuc.Size = New System.Drawing.Size(51, 15)
        Me.etiRuc.TabIndex = 22
        Me.etiRuc.Text = "Nro RUC:"
        '
        'agrTotalGasto
        '
        Me.agrTotalGasto.Controls.Add(Me.etiTotalCubrir)
        Me.agrTotalGasto.Controls.Add(Me.etiTotalAgregado)
        Me.agrTotalGasto.Controls.Add(Me.numCubrir)
        Me.agrTotalGasto.Controls.Add(Me.numAgregado)
        Me.agrTotalGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalGasto.ForeColor = System.Drawing.Color.Black
        Me.agrTotalGasto.Location = New System.Drawing.Point(722, 5)
        Me.agrTotalGasto.Name = "agrTotalGasto"
        Me.agrTotalGasto.Size = New System.Drawing.Size(95, 102)
        Me.agrTotalGasto.TabIndex = 47
        Me.agrTotalGasto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiTotalCubrir
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Me.etiTotalCubrir.Appearance = Appearance168
        Me.etiTotalCubrir.AutoSize = True
        Me.etiTotalCubrir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalCubrir.ForeColor = System.Drawing.Color.Black
        Me.etiTotalCubrir.Location = New System.Drawing.Point(7, 55)
        Me.etiTotalCubrir.Name = "etiTotalCubrir"
        Me.etiTotalCubrir.Size = New System.Drawing.Size(76, 15)
        Me.etiTotalCubrir.TabIndex = 2
        Me.etiTotalCubrir.Text = "Total x Cubrir:"
        '
        'etiTotalAgregado
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Appearance169.ForeColor = System.Drawing.Color.Navy
        Me.etiTotalAgregado.Appearance = Appearance169
        Me.etiTotalAgregado.AutoSize = True
        Me.etiTotalAgregado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalAgregado.ForeColor = System.Drawing.Color.Black
        Me.etiTotalAgregado.Location = New System.Drawing.Point(6, 14)
        Me.etiTotalAgregado.Name = "etiTotalAgregado"
        Me.etiTotalAgregado.Size = New System.Drawing.Size(85, 15)
        Me.etiTotalAgregado.TabIndex = 0
        Me.etiTotalAgregado.Text = "Total Agregado:"
        '
        'numCubrir
        '
        Appearance170.ForeColor = System.Drawing.Color.Black
        Me.numCubrir.Appearance = Appearance170
        Me.numCubrir.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCubrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCubrir.ForeColor = System.Drawing.Color.Black
        Me.numCubrir.Location = New System.Drawing.Point(6, 74)
        Me.numCubrir.MaskInput = "{double:6.2}"
        Me.numCubrir.Name = "numCubrir"
        Me.numCubrir.NullText = "0.00"
        Me.numCubrir.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCubrir.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCubrir.ReadOnly = True
        Me.numCubrir.Size = New System.Drawing.Size(80, 21)
        Me.numCubrir.TabIndex = 3
        Me.numCubrir.TabStop = False
        '
        'numAgregado
        '
        Appearance171.ForeColor = System.Drawing.Color.Black
        Me.numAgregado.Appearance = Appearance171
        Me.numAgregado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAgregado.ForeColor = System.Drawing.Color.Black
        Me.numAgregado.Location = New System.Drawing.Point(5, 29)
        Me.numAgregado.MaskInput = "{double:6.2}"
        Me.numAgregado.Name = "numAgregado"
        Me.numAgregado.NullText = "0.00"
        Me.numAgregado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numAgregado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numAgregado.ReadOnly = True
        Me.numAgregado.Size = New System.Drawing.Size(81, 21)
        Me.numAgregado.TabIndex = 1
        Me.numAgregado.TabStop = False
        '
        'cboGrupo
        '
        Appearance172.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Appearance = Appearance172
        Me.cboGrupo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboGrupo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGrupo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGrupo.Enabled = False
        Me.cboGrupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.ForeColor = System.Drawing.Color.Black
        Me.cboGrupo.Location = New System.Drawing.Point(116, 20)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(115, 22)
        Me.cboGrupo.TabIndex = 4
        Me.cboGrupo.ValueMember = "Id"
        '
        'etiPeriodo
        '
        Appearance173.BackColor = System.Drawing.Color.Transparent
        Appearance173.ForeColor = System.Drawing.Color.Navy
        Me.etiPeriodo.Appearance = Appearance173
        Me.etiPeriodo.AutoSize = True
        Me.etiPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPeriodo.ForeColor = System.Drawing.Color.Black
        Me.etiPeriodo.Location = New System.Drawing.Point(27, 5)
        Me.etiPeriodo.Name = "etiPeriodo"
        Me.etiPeriodo.Size = New System.Drawing.Size(46, 15)
        Me.etiPeriodo.TabIndex = 1
        Me.etiPeriodo.Text = "Periodo:"
        '
        'etiFechavencimiento
        '
        Appearance174.BackColor = System.Drawing.Color.Transparent
        Appearance174.ForeColor = System.Drawing.Color.Navy
        Me.etiFechavencimiento.Appearance = Appearance174
        Me.etiFechavencimiento.AutoSize = True
        Me.etiFechavencimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechavencimiento.ForeColor = System.Drawing.Color.Black
        Me.etiFechavencimiento.Location = New System.Drawing.Point(615, 44)
        Me.etiFechavencimiento.Name = "etiFechavencimiento"
        Me.etiFechavencimiento.Size = New System.Drawing.Size(55, 15)
        Me.etiFechavencimiento.TabIndex = 17
        Me.etiFechavencimiento.Text = "Fec. Ven.:"
        '
        'etiNroGrupo
        '
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Appearance175.ForeColor = System.Drawing.Color.Navy
        Me.etiNroGrupo.Appearance = Appearance175
        Me.etiNroGrupo.AutoSize = True
        Me.etiNroGrupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNroGrupo.ForeColor = System.Drawing.Color.Black
        Me.etiNroGrupo.Location = New System.Drawing.Point(117, 6)
        Me.etiNroGrupo.Name = "etiNroGrupo"
        Me.etiNroGrupo.Size = New System.Drawing.Size(60, 15)
        Me.etiNroGrupo.TabIndex = 3
        Me.etiNroGrupo.Text = "Nro Grupo:"
        '
        'fecPeriodo
        '
        Appearance176.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Appearance = Appearance176
        Me.fecPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecPeriodo.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Location = New System.Drawing.Point(27, 20)
        Me.fecPeriodo.MaskInput = "mm/yyyy"
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(83, 22)
        Me.fecPeriodo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodo.TabIndex = 2
        Me.fecPeriodo.TabStop = False
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRUC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(198, 100)
        Me.txtRUC.MaxLength = 11
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(93, 22)
        Me.txtRUC.TabIndex = 23
        '
        'cboTipoDocumento
        '
        Appearance177.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance177
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownListWidth = 600
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(27, 60)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(241, 22)
        Me.cboTipoDocumento.TabIndex = 10
        Me.cboTipoDocumento.ValueMember = "IdTipoDocumento"
        '
        'etiProveedor
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Me.etiProveedor.Appearance = Appearance178
        Me.etiProveedor.AutoSize = True
        Me.etiProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProveedor.ForeColor = System.Drawing.Color.Black
        Me.etiProveedor.Location = New System.Drawing.Point(291, 86)
        Me.etiProveedor.Name = "etiProveedor"
        Me.etiProveedor.Size = New System.Drawing.Size(59, 15)
        Me.etiProveedor.TabIndex = 24
        Me.etiProveedor.Text = "Proveedor:"
        '
        'cboFlujoCaja
        '
        Appearance179.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Appearance = Appearance179
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance180.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton4.Appearance = Appearance180
        Me.cboFlujoCaja.ButtonsRight.Add(EditorButton4)
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownListWidth = 350
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Location = New System.Drawing.Point(462, 20)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(254, 22)
        Me.cboFlujoCaja.TabIndex = 8
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(408, 60)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(121, 22)
        Me.txtNumero.TabIndex = 14
        '
        'etiGlosa
        '
        Appearance181.BackColor = System.Drawing.Color.Transparent
        Appearance181.ForeColor = System.Drawing.Color.Navy
        Me.etiGlosa.Appearance = Appearance181
        Me.etiGlosa.AutoSize = True
        Me.etiGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGlosa.ForeColor = System.Drawing.Color.Black
        Me.etiGlosa.Location = New System.Drawing.Point(29, 173)
        Me.etiGlosa.Name = "etiGlosa"
        Me.etiGlosa.Size = New System.Drawing.Size(35, 15)
        Me.etiGlosa.TabIndex = 43
        Me.etiGlosa.Text = "Glosa:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(274, 60)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(128, 22)
        Me.txtSerie.TabIndex = 12
        '
        'etiNumero
        '
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Appearance182.ForeColor = System.Drawing.Color.Navy
        Me.etiNumero.Appearance = Appearance182
        Me.etiNumero.AutoSize = True
        Me.etiNumero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNumero.ForeColor = System.Drawing.Color.Black
        Me.etiNumero.Location = New System.Drawing.Point(409, 44)
        Me.etiNumero.Name = "etiNumero"
        Me.etiNumero.Size = New System.Drawing.Size(48, 15)
        Me.etiNumero.TabIndex = 13
        Me.etiNumero.Text = "Numero:"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnLimpiar)
        Me.Agrupacion3.Controls.Add(Me.btnCancelarDetalle)
        Me.Agrupacion3.Controls.Add(Me.btnAceptarDetalle)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(722, 165)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(259, 41)
        Me.Agrupacion3.TabIndex = 46
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnLimpiar
        '
        Appearance183.ForeColor = System.Drawing.Color.Navy
        Appearance183.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Appearance183.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance183.TextHAlignAsString = "Right"
        Me.btnLimpiar.Appearance = Appearance183
        Me.btnLimpiar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(92, 7)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 27)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.TabStop = False
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnCancelarDetalle
        '
        Appearance184.ForeColor = System.Drawing.Color.Navy
        Appearance184.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Appearance184.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance184.TextHAlignAsString = "Right"
        Me.btnCancelarDetalle.Appearance = Appearance184
        Me.btnCancelarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarDetalle.Location = New System.Drawing.Point(176, 7)
        Me.btnCancelarDetalle.Name = "btnCancelarDetalle"
        Me.btnCancelarDetalle.Size = New System.Drawing.Size(78, 27)
        Me.btnCancelarDetalle.TabIndex = 2
        Me.btnCancelarDetalle.TabStop = False
        Me.btnCancelarDetalle.Text = "Quitar"
        '
        'btnAceptarDetalle
        '
        Appearance185.ForeColor = System.Drawing.Color.Navy
        Appearance185.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Appearance185.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance185.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance185.TextHAlignAsString = "Right"
        Me.btnAceptarDetalle.Appearance = Appearance185
        Me.btnAceptarDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarDetalle.ForeColor = System.Drawing.Color.Black
        Me.btnAceptarDetalle.Location = New System.Drawing.Point(8, 6)
        Me.btnAceptarDetalle.Name = "btnAceptarDetalle"
        Me.btnAceptarDetalle.Size = New System.Drawing.Size(78, 29)
        Me.btnAceptarDetalle.TabIndex = 0
        Me.btnAceptarDetalle.Text = "Aceptar"
        '
        'txtGlosa2
        '
        Me.txtGlosa2.AccessibleDescription = ""
        Me.txtGlosa2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa2.Location = New System.Drawing.Point(68, 170)
        Me.txtGlosa2.Multiline = True
        Me.txtGlosa2.Name = "txtGlosa2"
        Me.txtGlosa2.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.txtGlosa2.Size = New System.Drawing.Size(648, 36)
        Me.txtGlosa2.TabIndex = 44
        '
        'etiSerie
        '
        Appearance186.BackColor = System.Drawing.Color.Transparent
        Appearance186.ForeColor = System.Drawing.Color.Navy
        Me.etiSerie.Appearance = Appearance186
        Me.etiSerie.AutoSize = True
        Me.etiSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSerie.ForeColor = System.Drawing.Color.Black
        Me.etiSerie.Location = New System.Drawing.Point(274, 43)
        Me.etiSerie.Name = "etiSerie"
        Me.etiSerie.Size = New System.Drawing.Size(33, 15)
        Me.etiSerie.TabIndex = 11
        Me.etiSerie.Text = "Serie:"
        '
        'etiFechaDoc
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Appearance187.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaDoc.Appearance = Appearance187
        Me.etiFechaDoc.AutoSize = True
        Me.etiFechaDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaDoc.ForeColor = System.Drawing.Color.Black
        Me.etiFechaDoc.Location = New System.Drawing.Point(531, 44)
        Me.etiFechaDoc.Name = "etiFechaDoc"
        Me.etiFechaDoc.Size = New System.Drawing.Size(71, 15)
        Me.etiFechaDoc.TabIndex = 15
        Me.etiFechaDoc.Text = "Fec. Emision:"
        '
        'etiTipoDocumento
        '
        Appearance188.BackColor = System.Drawing.Color.Transparent
        Appearance188.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoDocumento.Appearance = Appearance188
        Me.etiTipoDocumento.AutoSize = True
        Me.etiTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.etiTipoDocumento.Location = New System.Drawing.Point(28, 46)
        Me.etiTipoDocumento.Name = "etiTipoDocumento"
        Me.etiTipoDocumento.Size = New System.Drawing.Size(90, 15)
        Me.etiTipoDocumento.TabIndex = 9
        Me.etiTipoDocumento.Text = "Tipo Documento:"
        '
        'agrDatoOperacion
        '
        Me.agrDatoOperacion.Controls.Add(Me.cboArea)
        Me.agrDatoOperacion.Controls.Add(Me.Etiqueta33)
        Me.agrDatoOperacion.Controls.Add(Me.ChkVehiculoProper)
        Me.agrDatoOperacion.Controls.Add(Me.etiTrabajador)
        Me.agrDatoOperacion.Controls.Add(Me.cboAutoriza)
        Me.agrDatoOperacion.Controls.Add(Me.etiPlaca)
        Me.agrDatoOperacion.Controls.Add(Me.cboGastoFuncion)
        Me.agrDatoOperacion.Controls.Add(Me.etiCentroCosto)
        Me.agrDatoOperacion.Controls.Add(Me.cboCentroCosto)
        Me.agrDatoOperacion.Controls.Add(Me.etiGastoFuncion)
        Me.agrDatoOperacion.Controls.Add(Me.etiAutoriza)
        Me.agrDatoOperacion.Controls.Add(Me.cboTrabajador2)
        Me.agrDatoOperacion.Controls.Add(Me.cboPlaca)
        Me.agrDatoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatoOperacion.ForeColor = System.Drawing.Color.Black
        Me.agrDatoOperacion.Location = New System.Drawing.Point(37, 210)
        Me.agrDatoOperacion.Name = "agrDatoOperacion"
        Me.agrDatoOperacion.Size = New System.Drawing.Size(674, 83)
        Me.agrDatoOperacion.TabIndex = 45
        Me.agrDatoOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboArea
        '
        Appearance189.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Appearance = Appearance189
        Me.cboArea.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.Location = New System.Drawing.Point(423, 7)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(245, 22)
        Me.cboArea.TabIndex = 7
        Me.cboArea.ValueMember = "Id"
        '
        'Etiqueta33
        '
        Appearance190.BackColor = System.Drawing.Color.Transparent
        Appearance190.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance190
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(384, 11)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta33.TabIndex = 6
        Me.Etiqueta33.Text = "Area:"
        '
        'ChkVehiculoProper
        '
        Me.ChkVehiculoProper.AutoSize = True
        Me.ChkVehiculoProper.BackColor = System.Drawing.Color.Transparent
        Me.ChkVehiculoProper.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVehiculoProper.ForeColor = System.Drawing.Color.Navy
        Me.ChkVehiculoProper.Location = New System.Drawing.Point(563, 34)
        Me.ChkVehiculoProper.Name = "ChkVehiculoProper"
        Me.ChkVehiculoProper.Size = New System.Drawing.Size(55, 17)
        Me.ChkVehiculoProper.TabIndex = 10
        Me.ChkVehiculoProper.TabStop = False
        Me.ChkVehiculoProper.Text = "Varios"
        Me.ChkVehiculoProper.UseVisualStyleBackColor = False
        '
        'etiTrabajador
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Appearance191.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance191
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajador.Location = New System.Drawing.Point(29, 11)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajador.TabIndex = 0
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboAutoriza
        '
        Appearance192.ForeColor = System.Drawing.Color.Black
        Me.cboAutoriza.Appearance = Appearance192
        Me.cboAutoriza.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAutoriza.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAutoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAutoriza.ForeColor = System.Drawing.Color.Black
        Me.cboAutoriza.Location = New System.Drawing.Point(423, 54)
        Me.cboAutoriza.Name = "cboAutoriza"
        Me.cboAutoriza.Size = New System.Drawing.Size(245, 22)
        Me.cboAutoriza.TabIndex = 12
        Me.cboAutoriza.ValueMember = "Id"
        '
        'etiPlaca
        '
        Appearance193.BackColor = System.Drawing.Color.Transparent
        Appearance193.ForeColor = System.Drawing.Color.Navy
        Me.etiPlaca.Appearance = Appearance193
        Me.etiPlaca.AutoSize = True
        Me.etiPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPlaca.ForeColor = System.Drawing.Color.Black
        Me.etiPlaca.Location = New System.Drawing.Point(383, 34)
        Me.etiPlaca.Name = "etiPlaca"
        Me.etiPlaca.Size = New System.Drawing.Size(34, 15)
        Me.etiPlaca.TabIndex = 8
        Me.etiPlaca.Text = "Placa:"
        '
        'cboGastoFuncion
        '
        Appearance194.ForeColor = System.Drawing.Color.Black
        Me.cboGastoFuncion.Appearance = Appearance194
        Me.cboGastoFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboGastoFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGastoFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastoFuncion.ForeColor = System.Drawing.Color.Black
        Me.cboGastoFuncion.Location = New System.Drawing.Point(98, 30)
        Me.cboGastoFuncion.Name = "cboGastoFuncion"
        Me.cboGastoFuncion.Size = New System.Drawing.Size(266, 22)
        Me.cboGastoFuncion.TabIndex = 3
        Me.cboGastoFuncion.ValueMember = "Id"
        '
        'etiCentroCosto
        '
        Appearance195.BackColor = System.Drawing.Color.Transparent
        Appearance195.ForeColor = System.Drawing.Color.Navy
        Me.etiCentroCosto.Appearance = Appearance195
        Me.etiCentroCosto.AutoSize = True
        Me.etiCentroCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.etiCentroCosto.Location = New System.Drawing.Point(3, 58)
        Me.etiCentroCosto.Name = "etiCentroCosto"
        Me.etiCentroCosto.Size = New System.Drawing.Size(89, 15)
        Me.etiCentroCosto.TabIndex = 4
        Me.etiCentroCosto.Text = "Centro de Costo:"
        '
        'cboCentroCosto
        '
        Appearance196.ForeColor = System.Drawing.Color.Black
        Me.cboCentroCosto.Appearance = Appearance196
        Me.cboCentroCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentroCosto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.Color.Black
        Me.cboCentroCosto.Location = New System.Drawing.Point(98, 54)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(266, 22)
        Me.cboCentroCosto.TabIndex = 5
        Me.cboCentroCosto.ValueMember = "Id"
        '
        'etiGastoFuncion
        '
        Appearance197.BackColor = System.Drawing.Color.Transparent
        Appearance197.ForeColor = System.Drawing.Color.Navy
        Me.etiGastoFuncion.Appearance = Appearance197
        Me.etiGastoFuncion.AutoSize = True
        Me.etiGastoFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGastoFuncion.ForeColor = System.Drawing.Color.Black
        Me.etiGastoFuncion.Location = New System.Drawing.Point(13, 34)
        Me.etiGastoFuncion.Name = "etiGastoFuncion"
        Me.etiGastoFuncion.Size = New System.Drawing.Size(79, 15)
        Me.etiGastoFuncion.TabIndex = 2
        Me.etiGastoFuncion.Text = "Gasto Función:"
        '
        'etiAutoriza
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Me.etiAutoriza.Appearance = Appearance198
        Me.etiAutoriza.AutoSize = True
        Me.etiAutoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAutoriza.ForeColor = System.Drawing.Color.Black
        Me.etiAutoriza.Location = New System.Drawing.Point(371, 58)
        Me.etiAutoriza.Name = "etiAutoriza"
        Me.etiAutoriza.Size = New System.Drawing.Size(49, 15)
        Me.etiAutoriza.TabIndex = 11
        Me.etiAutoriza.Text = "Autoriza:"
        '
        'cboTrabajador2
        '
        Appearance199.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador2.Appearance = Appearance199
        Me.cboTrabajador2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador2.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador2.Location = New System.Drawing.Point(98, 7)
        Me.cboTrabajador2.Name = "cboTrabajador2"
        Me.cboTrabajador2.Size = New System.Drawing.Size(266, 22)
        Me.cboTrabajador2.TabIndex = 1
        Me.cboTrabajador2.ValueMember = "Id"
        '
        'cboPlaca
        '
        Appearance200.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Appearance = Appearance200
        Me.cboPlaca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlaca.ForeColor = System.Drawing.Color.Black
        Me.cboPlaca.Location = New System.Drawing.Point(424, 30)
        Me.cboPlaca.Name = "cboPlaca"
        Me.cboPlaca.Size = New System.Drawing.Size(135, 22)
        Me.cboPlaca.TabIndex = 9
        Me.cboPlaca.ValueMember = "Id"
        '
        'cboTipoGasto
        '
        Appearance201.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Appearance = Appearance201
        Me.cboTipoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance202.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton5.Appearance = Appearance202
        Me.cboTipoGasto.ButtonsRight.Add(EditorButton5)
        Me.cboTipoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoGasto.DropDownListWidth = 350
        Me.cboTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Location = New System.Drawing.Point(234, 20)
        Me.cboTipoGasto.Name = "cboTipoGasto"
        Me.cboTipoGasto.Size = New System.Drawing.Size(225, 22)
        Me.cboTipoGasto.TabIndex = 6
        Me.cboTipoGasto.ValueMember = "Id"
        '
        'etiFlujoCaja
        '
        Appearance203.BackColor = System.Drawing.Color.Transparent
        Appearance203.ForeColor = System.Drawing.Color.Navy
        Me.etiFlujoCaja.Appearance = Appearance203
        Me.etiFlujoCaja.AutoSize = True
        Me.etiFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.etiFlujoCaja.Location = New System.Drawing.Point(462, 6)
        Me.etiFlujoCaja.Name = "etiFlujoCaja"
        Me.etiFlujoCaja.Size = New System.Drawing.Size(74, 15)
        Me.etiFlujoCaja.TabIndex = 7
        Me.etiFlujoCaja.Text = "Flujo de Caja:"
        '
        'cboAutorizaGasto
        '
        Appearance204.ForeColor = System.Drawing.Color.Black
        Me.cboAutorizaGasto.Appearance = Appearance204
        Me.cboAutorizaGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAutorizaGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAutorizaGasto.Enabled = False
        Me.cboAutorizaGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAutorizaGasto.ForeColor = System.Drawing.Color.Black
        Me.cboAutorizaGasto.Location = New System.Drawing.Point(368, 143)
        Me.cboAutorizaGasto.Name = "cboAutorizaGasto"
        Me.cboAutorizaGasto.Size = New System.Drawing.Size(201, 22)
        Me.cboAutorizaGasto.TabIndex = 40
        Me.cboAutorizaGasto.ValueMember = "Id"
        Me.cboAutorizaGasto.Visible = False
        '
        'Etiqueta34
        '
        Appearance205.BackColor = System.Drawing.Color.Transparent
        Appearance205.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance205
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta34.Location = New System.Drawing.Point(368, 127)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(81, 15)
        Me.Etiqueta34.TabIndex = 39
        Me.Etiqueta34.Text = "Autoriza Gasto:"
        Me.Etiqueta34.Visible = False
        '
        'DecPercepcion
        '
        Appearance206.ForeColor = System.Drawing.Color.Black
        Me.DecPercepcion.Appearance = Appearance206
        Me.DecPercepcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecPercepcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecPercepcion.ForeColor = System.Drawing.Color.Black
        Me.DecPercepcion.FormatString = "#,##0.00"
        Me.DecPercepcion.Location = New System.Drawing.Point(221, 143)
        Me.DecPercepcion.Name = "DecPercepcion"
        Me.DecPercepcion.Nullable = True
        Me.DecPercepcion.NullText = "0.00"
        Me.DecPercepcion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecPercepcion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecPercepcion.ReadOnly = True
        Me.DecPercepcion.Size = New System.Drawing.Size(62, 22)
        Me.DecPercepcion.TabIndex = 36
        Me.DecPercepcion.TabStop = False
        Me.DecPercepcion.Value = Nothing
        '
        'DecNoGravada
        '
        Appearance207.ForeColor = System.Drawing.Color.Black
        Me.DecNoGravada.Appearance = Appearance207
        Me.DecNoGravada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecNoGravada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecNoGravada.ForeColor = System.Drawing.Color.Black
        Me.DecNoGravada.FormatString = "#,##0.00"
        Me.DecNoGravada.Location = New System.Drawing.Point(146, 143)
        Me.DecNoGravada.Name = "DecNoGravada"
        Me.DecNoGravada.Nullable = True
        Me.DecNoGravada.NullText = "0.00"
        Me.DecNoGravada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecNoGravada.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecNoGravada.Size = New System.Drawing.Size(66, 22)
        Me.DecNoGravada.TabIndex = 34
        Me.DecNoGravada.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DecNoGravada, "Cuando ademas de IGV, se " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quiere ingresar un monto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No gravadas")
        Me.DecNoGravada.Value = Nothing
        '
        'numIGV
        '
        Appearance208.ForeColor = System.Drawing.Color.Black
        Me.numIGV.Appearance = Appearance208
        Me.numIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numIGV.ForeColor = System.Drawing.Color.Black
        Me.numIGV.FormatString = "#,##0.00"
        Me.numIGV.Location = New System.Drawing.Point(98, 143)
        Me.numIGV.Name = "numIGV"
        Me.numIGV.Nullable = True
        Me.numIGV.NullText = "0.00"
        Me.numIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numIGV.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numIGV.Size = New System.Drawing.Size(43, 22)
        Me.numIGV.TabIndex = 32
        '
        'numTotal
        '
        Appearance209.ForeColor = System.Drawing.Color.Black
        Me.numTotal.Appearance = Appearance209
        Me.numTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotal.ForeColor = System.Drawing.Color.Black
        Me.numTotal.FormatString = "#,##0.00"
        Me.numTotal.Location = New System.Drawing.Point(288, 143)
        Me.numTotal.Name = "numTotal"
        Me.numTotal.Nullable = True
        Me.numTotal.NullText = "0.00"
        Me.numTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numTotal.ReadOnly = True
        Me.numTotal.Size = New System.Drawing.Size(74, 22)
        Me.numTotal.TabIndex = 38
        Me.numTotal.TabStop = False
        Me.numTotal.Value = Nothing
        '
        'numImporte
        '
        Appearance210.ForeColor = System.Drawing.Color.Black
        Me.numImporte.Appearance = Appearance210
        Me.numImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numImporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImporte.ForeColor = System.Drawing.Color.Black
        Me.numImporte.FormatString = "#,##0.00"
        Me.numImporte.Location = New System.Drawing.Point(28, 143)
        Me.numImporte.Name = "numImporte"
        Me.numImporte.Nullable = True
        Me.numImporte.NullText = "0.00"
        Me.numImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numImporte.Size = New System.Drawing.Size(66, 22)
        Me.numImporte.TabIndex = 30
        '
        'Etiqueta54
        '
        Appearance211.BackColor = System.Drawing.Color.Transparent
        Appearance211.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta54.Appearance = Appearance211
        Me.Etiqueta54.AutoSize = True
        Me.Etiqueta54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta54.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta54.Location = New System.Drawing.Point(221, 128)
        Me.Etiqueta54.Name = "Etiqueta54"
        Me.Etiqueta54.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta54.TabIndex = 35
        Me.Etiqueta54.Text = "Percepcion:"
        '
        'Etiqueta47
        '
        Appearance212.BackColor = System.Drawing.Color.Transparent
        Appearance212.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance212
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(146, 127)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta47.TabIndex = 33
        Me.Etiqueta47.Text = "No Gravada:"
        '
        'Importe
        '
        Appearance213.BackColor = System.Drawing.Color.Transparent
        Appearance213.ForeColor = System.Drawing.Color.Navy
        Me.Importe.Appearance = Appearance213
        Me.Importe.AutoSize = True
        Me.Importe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importe.ForeColor = System.Drawing.Color.Black
        Me.Importe.Location = New System.Drawing.Point(28, 128)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(56, 15)
        Me.Importe.TabIndex = 29
        Me.Importe.Text = "Sub Total:"
        '
        'etiIGV
        '
        Appearance214.BackColor = System.Drawing.Color.Transparent
        Appearance214.ForeColor = System.Drawing.Color.Navy
        Me.etiIGV.Appearance = Appearance214
        Me.etiIGV.AutoSize = True
        Me.etiIGV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIGV.ForeColor = System.Drawing.Color.Black
        Me.etiIGV.Location = New System.Drawing.Point(98, 127)
        Me.etiIGV.Name = "etiIGV"
        Me.etiIGV.Size = New System.Drawing.Size(27, 15)
        Me.etiIGV.TabIndex = 31
        Me.etiIGV.Text = "IGV:"
        '
        'Etiqueta36
        '
        Appearance215.BackColor = System.Drawing.Color.Transparent
        Appearance215.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance215
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta36.Location = New System.Drawing.Point(288, 128)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta36.TabIndex = 37
        Me.Etiqueta36.Text = "Total:"
        '
        'Etiqueta19
        '
        Appearance216.BackColor = System.Drawing.Color.Transparent
        Appearance216.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance216
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(27, 86)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta19.TabIndex = 20
        Me.Etiqueta19.Text = "Lugar:"
        Me.Etiqueta19.Visible = False
        '
        'DecPagoxCaja
        '
        Appearance217.ForeColor = System.Drawing.Color.Black
        Me.DecPagoxCaja.Appearance = Appearance217
        Me.DecPagoxCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecPagoxCaja.Enabled = False
        Me.DecPagoxCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecPagoxCaja.ForeColor = System.Drawing.Color.Black
        Me.DecPagoxCaja.FormatString = "#,##0.00"
        Me.DecPagoxCaja.Location = New System.Drawing.Point(936, 41)
        Me.DecPagoxCaja.Name = "DecPagoxCaja"
        Me.DecPagoxCaja.Nullable = True
        Me.DecPagoxCaja.NullText = "0.00"
        Me.DecPagoxCaja.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecPagoxCaja.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecPagoxCaja.Size = New System.Drawing.Size(88, 21)
        Me.DecPagoxCaja.TabIndex = 53
        Me.DecPagoxCaja.Visible = False
        '
        'numGasto
        '
        Appearance218.ForeColor = System.Drawing.Color.Black
        Me.numGasto.Appearance = Appearance218
        Me.numGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numGasto.ForeColor = System.Drawing.Color.Black
        Me.numGasto.Location = New System.Drawing.Point(828, 34)
        Me.numGasto.MaskInput = "{double:6.2}"
        Me.numGasto.Name = "numGasto"
        Me.numGasto.NullText = "0.00"
        Me.numGasto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numGasto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numGasto.ReadOnly = True
        Me.numGasto.Size = New System.Drawing.Size(81, 21)
        Me.numGasto.TabIndex = 47
        Me.numGasto.TabStop = False
        Me.numGasto.Visible = False
        '
        'numTipoCambio
        '
        Appearance219.ForeColor = System.Drawing.Color.Black
        Me.numTipoCambio.Appearance = Appearance219
        Me.numTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.numTipoCambio.Location = New System.Drawing.Point(898, 95)
        Me.numTipoCambio.MaskInput = "{double:2.3}"
        Me.numTipoCambio.MaxValue = 999.0R
        Me.numTipoCambio.MinValue = 0R
        Me.numTipoCambio.Name = "numTipoCambio"
        Me.numTipoCambio.Nullable = True
        Me.numTipoCambio.NullText = "0.00"
        Me.numTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTipoCambio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numTipoCambio.Size = New System.Drawing.Size(44, 21)
        Me.numTipoCambio.TabIndex = 51
        Me.numTipoCambio.TabStop = False
        Me.numTipoCambio.Visible = False
        '
        'etiTipoCambio
        '
        Appearance220.BackColor = System.Drawing.Color.Transparent
        Appearance220.ForeColor = System.Drawing.Color.Navy
        Me.etiTipoCambio.Appearance = Appearance220
        Me.etiTipoCambio.AutoSize = True
        Me.etiTipoCambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.etiTipoCambio.Location = New System.Drawing.Point(898, 81)
        Me.etiTipoCambio.Name = "etiTipoCambio"
        Me.etiTipoCambio.Size = New System.Drawing.Size(32, 15)
        Me.etiTipoCambio.TabIndex = 50
        Me.etiTipoCambio.Text = "T.C. :"
        Me.etiTipoCambio.Visible = False
        '
        'cboMoneda
        '
        Appearance221.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance221
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(834, 95)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(58, 21)
        Me.cboMoneda.TabIndex = 48
        Me.cboMoneda.TabStop = False
        Me.cboMoneda.ValueMember = "Id"
        Me.cboMoneda.Visible = False
        '
        'etiMoneda
        '
        Appearance222.BackColor = System.Drawing.Color.Transparent
        Appearance222.ForeColor = System.Drawing.Color.Navy
        Me.etiMoneda.Appearance = Appearance222
        Me.etiMoneda.AutoSize = True
        Me.etiMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiMoneda.ForeColor = System.Drawing.Color.Black
        Me.etiMoneda.Location = New System.Drawing.Point(834, 81)
        Me.etiMoneda.Name = "etiMoneda"
        Me.etiMoneda.Size = New System.Drawing.Size(48, 15)
        Me.etiMoneda.TabIndex = 49
        Me.etiMoneda.Text = "Moneda:"
        Me.etiMoneda.Visible = False
        '
        'chkPagoxCaja
        '
        Me.chkPagoxCaja.AutoSize = True
        Me.chkPagoxCaja.BackColor = System.Drawing.Color.Transparent
        Me.chkPagoxCaja.ForeColor = System.Drawing.Color.Navy
        Me.chkPagoxCaja.Location = New System.Drawing.Point(936, 24)
        Me.chkPagoxCaja.Name = "chkPagoxCaja"
        Me.chkPagoxCaja.Size = New System.Drawing.Size(84, 17)
        Me.chkPagoxCaja.TabIndex = 52
        Me.chkPagoxCaja.Text = "Pago x Caja"
        Me.chkPagoxCaja.UseVisualStyleBackColor = False
        Me.chkPagoxCaja.Visible = False
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.Expanded = False
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1133, 301)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(23, 301)
        Me.UltraExpandableGroupBox1.TabIndex = 2
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Compras para Almacen"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraExpandableGroupBox1.Visible = False
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Ficha2)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.Agrupacion11)
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(1105, 295)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel5.Visible = False
        '
        'Ficha2
        '
        Me.Ficha2.Controls.Add(Me.UltraTabSharedControlsPage9)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl13)
        Me.Ficha2.Controls.Add(Me.UltraTabPageControl16)
        Me.Ficha2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha2.Location = New System.Drawing.Point(0, 104)
        Me.Ficha2.Name = "Ficha2"
        Me.Ficha2.SharedControlsPage = Me.UltraTabSharedControlsPage9
        Me.Ficha2.Size = New System.Drawing.Size(1105, 191)
        Me.Ficha2.TabIndex = 319
        UltraTab13.TabPage = Me.UltraTabPageControl13
        UltraTab13.Text = "Documento"
        UltraTab14.TabPage = Me.UltraTabPageControl16
        UltraTab14.Text = "OrdenAsociada"
        Me.Ficha2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab13, UltraTab14})
        Me.Ficha2.TabStop = False
        Me.Ficha2.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage9
        '
        Me.UltraTabSharedControlsPage9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage9.Name = "UltraTabSharedControlsPage9"
        Me.UltraTabSharedControlsPage9.Size = New System.Drawing.Size(1103, 168)
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.Combo4)
        Me.Agrupacion11.Controls.Add(Me.Etiqueta43)
        Me.Agrupacion11.Controls.Add(Me.Boton3)
        Me.Agrupacion11.Controls.Add(Me.GroupBox1)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(1105, 104)
        Me.Agrupacion11.TabIndex = 318
        Me.Agrupacion11.Text = "Documento"
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Combo4
        '
        Appearance227.ForeColor = System.Drawing.Color.Black
        Me.Combo4.Appearance = Appearance227
        Me.Combo4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.Combo4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo4.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo4.ForeColor = System.Drawing.Color.Black
        Me.Combo4.Location = New System.Drawing.Point(13, 53)
        Me.Combo4.Name = "Combo4"
        Me.Combo4.Size = New System.Drawing.Size(261, 21)
        Me.Combo4.TabIndex = 1
        Me.Combo4.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta43
        '
        Appearance228.BackColor = System.Drawing.Color.Transparent
        Appearance228.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance228
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta43.Location = New System.Drawing.Point(14, 36)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta43.TabIndex = 332
        Me.Etiqueta43.Text = "Tipo Documento:"
        '
        'Boton3
        '
        Me.Boton3.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3.ForeColor = System.Drawing.Color.Black
        Me.Boton3.Location = New System.Drawing.Point(467, 50)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(83, 25)
        Me.Boton3.TabIndex = 999
        Me.Boton3.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Texto3)
        Me.GroupBox1.Controls.Add(Me.Texto4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(283, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 51)
        Me.GroupBox1.TabIndex = 328
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "N° de Documento:"
        '
        'Texto3
        '
        Me.Texto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto3.Location = New System.Drawing.Point(20, 22)
        Me.Texto3.MaxLength = 4
        Me.Texto3.Name = "Texto3"
        Me.Texto3.Size = New System.Drawing.Size(42, 21)
        Me.Texto3.TabIndex = 2
        '
        'Texto4
        '
        Me.Texto4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto4.Location = New System.Drawing.Point(68, 22)
        Me.Texto4.MaxLength = 10
        Me.Texto4.Name = "Texto4"
        Me.Texto4.Size = New System.Drawing.Size(102, 21)
        Me.Texto4.TabIndex = 3
        '
        'cboOpcionGasto
        '
        Me.cboOpcionGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOpcionGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOpcionGasto.Enabled = False
        Me.cboOpcionGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValueListItem18.DataValue = "0"
        ValueListItem18.DisplayText = "NINGUNO"
        ValueListItem19.DataValue = "1"
        ValueListItem19.DisplayText = "PREPAGO"
        ValueListItem20.DataValue = "2"
        ValueListItem20.DisplayText = "POSTPAGO"
        ValueListItem21.DataValue = "3"
        ValueListItem21.DisplayText = "ORDEN DE TRABAJO"
        Me.cboOpcionGasto.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem18, ValueListItem19, ValueListItem20, ValueListItem21})
        Me.cboOpcionGasto.Location = New System.Drawing.Point(575, 142)
        Me.cboOpcionGasto.Name = "cboOpcionGasto"
        Me.cboOpcionGasto.Size = New System.Drawing.Size(144, 22)
        Me.cboOpcionGasto.TabIndex = 42
        '
        'cboReferencia
        '
        Appearance229.ForeColor = System.Drawing.Color.Black
        Me.cboReferencia.Appearance = Appearance229
        Me.cboReferencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboReferencia.DropDownListWidth = -1
        Me.cboReferencia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboReferencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReferencia.ForeColor = System.Drawing.Color.Black
        Me.cboReferencia.Location = New System.Drawing.Point(575, 100)
        Me.cboReferencia.Name = "cboReferencia"
        Me.cboReferencia.Size = New System.Drawing.Size(141, 22)
        Me.cboReferencia.TabIndex = 28
        Me.cboReferencia.ValueMember = ""
        Me.cboReferencia.Visible = False
        '
        'Etiqueta48
        '
        Appearance230.BackColor = System.Drawing.Color.Transparent
        Appearance230.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance230
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(575, 86)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta48.TabIndex = 27
        Me.Etiqueta48.Text = "Referencia:"
        Me.Etiqueta48.Visible = False
        '
        'Etiqueta45
        '
        Appearance231.BackColor = System.Drawing.Color.Transparent
        Appearance231.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance231
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(573, 128)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta45.TabIndex = 41
        Me.Etiqueta45.Text = "Op. Gasto:"
        Me.ToolTip1.SetToolTip(Me.Etiqueta45, "Opcion Gasto")
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1177, 624)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.AgrupacionFooter)
        Me.agrListaRegistro.Controls.Add(Me.agrBusqueda)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 0)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1177, 624)
        Me.agrListaRegistro.TabIndex = 0
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'AgrupacionFooter
        '
        Me.AgrupacionFooter.Controls.Add(Me.ficTipoMovimiento)
        Me.AgrupacionFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgrupacionFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgrupacionFooter.ForeColor = System.Drawing.Color.Black
        Me.AgrupacionFooter.Location = New System.Drawing.Point(3, 157)
        Me.AgrupacionFooter.Name = "AgrupacionFooter"
        Me.AgrupacionFooter.Size = New System.Drawing.Size(1171, 464)
        Me.AgrupacionFooter.TabIndex = 4
        Me.AgrupacionFooter.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ficTipoMovimiento
        '
        Me.ficTipoMovimiento.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.ficTipoMovimiento.Controls.Add(Me.UltraTabPageControl8)
        Me.ficTipoMovimiento.Controls.Add(Me.UltraTabPageControl9)
        Me.ficTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTipoMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficTipoMovimiento.Location = New System.Drawing.Point(2, 2)
        Me.ficTipoMovimiento.Name = "ficTipoMovimiento"
        Me.ficTipoMovimiento.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.ficTipoMovimiento.Size = New System.Drawing.Size(1167, 460)
        Me.ficTipoMovimiento.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl8
        UltraTab1.Text = "Viaje"
        UltraTab2.TabPage = Me.UltraTabPageControl9
        UltraTab2.Text = "Administrativo"
        Me.ficTipoMovimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficTipoMovimiento.TabStop = False
        Me.ficTipoMovimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1165, 437)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.chkBuscarCopiloto)
        Me.agrBusqueda.Controls.Add(Me.cboEstadoViaje)
        Me.agrBusqueda.Controls.Add(Me.etiEstado)
        Me.agrBusqueda.Controls.Add(Me.agrOtrosIngresos)
        Me.agrBusqueda.Controls.Add(Me.cboTracto)
        Me.agrBusqueda.Controls.Add(Me.txtCodViaje)
        Me.agrBusqueda.Controls.Add(Me.etitracto)
        Me.agrBusqueda.Controls.Add(Me.agrTotalFF)
        Me.agrBusqueda.Controls.Add(Me.cboTrabajadorMovimiento)
        Me.agrBusqueda.Controls.Add(Me.etiTrabajadorCuenta)
        Me.agrBusqueda.Controls.Add(Me.agrVales)
        Me.agrBusqueda.Controls.Add(Me.etiViaje)
        Me.agrBusqueda.Controls.Add(Me.agrGastosAdm)
        Me.agrBusqueda.Controls.Add(Me.chkViajeVacio)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta51)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta50)
        Me.agrBusqueda.Controls.Add(Me.fecHasta)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.agrSaldo)
        Me.agrBusqueda.Controls.Add(Me.btnReporteFondoFijo)
        Me.agrBusqueda.Controls.Add(Me.grupoEstado)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(3, 17)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1171, 140)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Busqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkBuscarCopiloto
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.chkBuscarCopiloto.Appearance = Appearance19
        Me.chkBuscarCopiloto.BackColor = System.Drawing.Color.Transparent
        Me.chkBuscarCopiloto.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkBuscarCopiloto.Location = New System.Drawing.Point(703, 41)
        Me.chkBuscarCopiloto.Name = "chkBuscarCopiloto"
        Me.chkBuscarCopiloto.Size = New System.Drawing.Size(105, 36)
        Me.chkBuscarCopiloto.TabIndex = 13
        Me.chkBuscarCopiloto.TabStop = False
        Me.chkBuscarCopiloto.Text = "Buscar Copiloto"
        Me.chkBuscarCopiloto.Visible = False
        '
        'cboEstadoViaje
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoViaje.Appearance = Appearance20
        Me.cboEstadoViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoViaje.DisplayMember = ""
        Me.cboEstadoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoViaje.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoViaje.Location = New System.Drawing.Point(595, 50)
        Me.cboEstadoViaje.Name = "cboEstadoViaje"
        Me.cboEstadoViaje.Size = New System.Drawing.Size(98, 22)
        Me.cboEstadoViaje.TabIndex = 7
        Me.cboEstadoViaje.ValueMember = "Id"
        '
        'etiEstado
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.etiEstado.Appearance = Appearance21
        Me.etiEstado.AutoSize = True
        Me.etiEstado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstado.Location = New System.Drawing.Point(595, 37)
        Me.etiEstado.Name = "etiEstado"
        Me.etiEstado.Size = New System.Drawing.Size(42, 15)
        Me.etiEstado.TabIndex = 6
        Me.etiEstado.Text = "Estado:"
        '
        'agrOtrosIngresos
        '
        Me.agrOtrosIngresos.Controls.Add(Me.UltraLabel7)
        Me.agrOtrosIngresos.Controls.Add(Me.decTotalOtrosIngresos)
        Me.agrOtrosIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOtrosIngresos.ForeColor = System.Drawing.Color.Black
        Me.agrOtrosIngresos.Location = New System.Drawing.Point(815, 80)
        Me.agrOtrosIngresos.Name = "agrOtrosIngresos"
        Me.agrOtrosIngresos.Size = New System.Drawing.Size(105, 52)
        Me.agrOtrosIngresos.TabIndex = 16
        Me.agrOtrosIngresos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrOtrosIngresos.Visible = False
        '
        'UltraLabel7
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance22
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Otros Ings:"
        '
        'decTotalOtrosIngresos
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.decTotalOtrosIngresos.Appearance = Appearance23
        Me.decTotalOtrosIngresos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalOtrosIngresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalOtrosIngresos.ForeColor = System.Drawing.Color.Black
        Me.decTotalOtrosIngresos.Location = New System.Drawing.Point(5, 25)
        Me.decTotalOtrosIngresos.MaskInput = "{double:-9.2}"
        Me.decTotalOtrosIngresos.Name = "decTotalOtrosIngresos"
        Me.decTotalOtrosIngresos.Nullable = True
        Me.decTotalOtrosIngresos.NullText = "0.00"
        Me.decTotalOtrosIngresos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalOtrosIngresos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotalOtrosIngresos.ReadOnly = True
        Me.decTotalOtrosIngresos.Size = New System.Drawing.Size(90, 22)
        Me.decTotalOtrosIngresos.TabIndex = 1
        Me.decTotalOtrosIngresos.TabStop = False
        '
        'cboTracto
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance24
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTracto.DisplayMember = ""
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Location = New System.Drawing.Point(520, 50)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(69, 22)
        Me.cboTracto.TabIndex = 5
        Me.cboTracto.ValueMember = "Id"
        '
        'txtCodViaje
        '
        Me.txtCodViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodViaje.Location = New System.Drawing.Point(153, 50)
        Me.txtCodViaje.Name = "txtCodViaje"
        Me.txtCodViaje.Size = New System.Drawing.Size(100, 22)
        Me.txtCodViaje.TabIndex = 1
        '
        'etitracto
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.etitracto.Appearance = Appearance25
        Me.etitracto.AutoSize = True
        Me.etitracto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etitracto.Location = New System.Drawing.Point(520, 37)
        Me.etitracto.Name = "etitracto"
        Me.etitracto.Size = New System.Drawing.Size(40, 15)
        Me.etitracto.TabIndex = 4
        Me.etitracto.Text = "Tracto:"
        '
        'agrTotalFF
        '
        Me.agrTotalFF.Controls.Add(Me.UltraLabel6)
        Me.agrTotalFF.Controls.Add(Me.decTotalFF)
        Me.agrTotalFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalFF.ForeColor = System.Drawing.Color.Black
        Me.agrTotalFF.Location = New System.Drawing.Point(926, 79)
        Me.agrTotalFF.Name = "agrTotalFF"
        Me.agrTotalFF.Size = New System.Drawing.Size(105, 52)
        Me.agrTotalFF.TabIndex = 17
        Me.agrTotalFF.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrTotalFF.Visible = False
        '
        'UltraLabel6
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance26
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel6.TabIndex = 0
        Me.UltraLabel6.Text = "Fondo Fijo:"
        '
        'decTotalFF
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.decTotalFF.Appearance = Appearance27
        Me.decTotalFF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalFF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalFF.ForeColor = System.Drawing.Color.Black
        Me.decTotalFF.Location = New System.Drawing.Point(9, 26)
        Me.decTotalFF.MaskInput = "{double:-9.2}"
        Me.decTotalFF.Name = "decTotalFF"
        Me.decTotalFF.Nullable = True
        Me.decTotalFF.NullText = "0.00"
        Me.decTotalFF.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalFF.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotalFF.ReadOnly = True
        Me.decTotalFF.Size = New System.Drawing.Size(86, 22)
        Me.decTotalFF.TabIndex = 1
        Me.decTotalFF.TabStop = False
        '
        'cboTrabajadorMovimiento
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorMovimiento.Appearance = Appearance28
        Me.cboTrabajadorMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance29.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance29
        Me.cboTrabajadorMovimiento.ButtonsRight.Add(EditorButton1)
        Me.cboTrabajadorMovimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorMovimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajadorMovimiento.Location = New System.Drawing.Point(259, 50)
        Me.cboTrabajadorMovimiento.Name = "cboTrabajadorMovimiento"
        Me.cboTrabajadorMovimiento.Size = New System.Drawing.Size(255, 22)
        Me.cboTrabajadorMovimiento.TabIndex = 3
        Me.cboTrabajadorMovimiento.ValueMember = "Id"
        '
        'etiTrabajadorCuenta
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajadorCuenta.Appearance = Appearance30
        Me.etiTrabajadorCuenta.AutoSize = True
        Me.etiTrabajadorCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajadorCuenta.ForeColor = System.Drawing.Color.Black
        Me.etiTrabajadorCuenta.Location = New System.Drawing.Point(259, 37)
        Me.etiTrabajadorCuenta.Name = "etiTrabajadorCuenta"
        Me.etiTrabajadorCuenta.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajadorCuenta.TabIndex = 2
        Me.etiTrabajadorCuenta.Text = "Trabajador:"
        '
        'agrVales
        '
        Me.agrVales.Controls.Add(Me.UltraLabel5)
        Me.agrVales.Controls.Add(Me.decTotalVales)
        Me.agrVales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrVales.ForeColor = System.Drawing.Color.Black
        Me.agrVales.Location = New System.Drawing.Point(705, 80)
        Me.agrVales.Name = "agrVales"
        Me.agrVales.Size = New System.Drawing.Size(105, 52)
        Me.agrVales.TabIndex = 15
        Me.agrVales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrVales.Visible = False
        '
        'UltraLabel5
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance31
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Vales:"
        '
        'decTotalVales
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.decTotalVales.Appearance = Appearance32
        Me.decTotalVales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalVales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalVales.ForeColor = System.Drawing.Color.Black
        Me.decTotalVales.Location = New System.Drawing.Point(5, 25)
        Me.decTotalVales.MaskInput = "{double:-9.2}"
        Me.decTotalVales.Name = "decTotalVales"
        Me.decTotalVales.Nullable = True
        Me.decTotalVales.NullText = "0.00"
        Me.decTotalVales.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalVales.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotalVales.ReadOnly = True
        Me.decTotalVales.Size = New System.Drawing.Size(90, 22)
        Me.decTotalVales.TabIndex = 1
        Me.decTotalVales.TabStop = False
        '
        'etiViaje
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.etiViaje.Appearance = Appearance33
        Me.etiViaje.AutoSize = True
        Me.etiViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiViaje.Location = New System.Drawing.Point(154, 37)
        Me.etiViaje.Name = "etiViaje"
        Me.etiViaje.Size = New System.Drawing.Size(70, 15)
        Me.etiViaje.TabIndex = 0
        Me.etiViaje.Text = "Codigo Viaje:"
        '
        'agrGastosAdm
        '
        Me.agrGastosAdm.Controls.Add(Me.UltraLabel4)
        Me.agrGastosAdm.Controls.Add(Me.decGastosAdm)
        Me.agrGastosAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrGastosAdm.ForeColor = System.Drawing.Color.Black
        Me.agrGastosAdm.Location = New System.Drawing.Point(815, 24)
        Me.agrGastosAdm.Name = "agrGastosAdm"
        Me.agrGastosAdm.Size = New System.Drawing.Size(105, 52)
        Me.agrGastosAdm.TabIndex = 14
        Me.agrGastosAdm.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrGastosAdm.Visible = False
        '
        'UltraLabel4
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance34
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Gastos:"
        '
        'decGastosAdm
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.decGastosAdm.Appearance = Appearance35
        Me.decGastosAdm.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decGastosAdm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decGastosAdm.ForeColor = System.Drawing.Color.Black
        Me.decGastosAdm.Location = New System.Drawing.Point(5, 25)
        Me.decGastosAdm.MaskInput = "{double:-9.2}"
        Me.decGastosAdm.Name = "decGastosAdm"
        Me.decGastosAdm.Nullable = True
        Me.decGastosAdm.NullText = "0.00"
        Me.decGastosAdm.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decGastosAdm.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decGastosAdm.ReadOnly = True
        Me.decGastosAdm.Size = New System.Drawing.Size(90, 22)
        Me.decGastosAdm.TabIndex = 1
        Me.decGastosAdm.TabStop = False
        '
        'chkViajeVacio
        '
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.chkViajeVacio.Appearance = Appearance36
        Me.chkViajeVacio.BackColor = System.Drawing.Color.Transparent
        Me.chkViajeVacio.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkViajeVacio.Checked = True
        Me.chkViajeVacio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViajeVacio.Location = New System.Drawing.Point(708, 86)
        Me.chkViajeVacio.Name = "chkViajeVacio"
        Me.chkViajeVacio.Size = New System.Drawing.Size(90, 20)
        Me.chkViajeVacio.TabIndex = 11
        Me.chkViajeVacio.TabStop = False
        Me.chkViajeVacio.Text = "Incluir Vacios"
        '
        'Etiqueta51
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance37
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(14, 57)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta51.TabIndex = 10
        Me.Etiqueta51.Text = "Hasta:"
        '
        'Etiqueta50
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance38
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(14, 31)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta50.TabIndex = 8
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(59, 56)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(85, 21)
        Me.fecHasta.TabIndex = 11
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(59, 29)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(85, 21)
        Me.fecDesde.TabIndex = 9
        '
        'agrSaldo
        '
        Me.agrSaldo.Controls.Add(Me.UltraLabel2)
        Me.agrSaldo.Controls.Add(Me.decSaldoCuentaAdm)
        Me.agrSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrSaldo.ForeColor = System.Drawing.Color.Black
        Me.agrSaldo.Location = New System.Drawing.Point(704, 24)
        Me.agrSaldo.Name = "agrSaldo"
        Me.agrSaldo.Size = New System.Drawing.Size(105, 52)
        Me.agrSaldo.TabIndex = 12
        Me.agrSaldo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrSaldo.Visible = False
        '
        'UltraLabel2
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance39
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(6, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(40, 15)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Saldo:"
        '
        'decSaldoCuentaAdm
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.decSaldoCuentaAdm.Appearance = Appearance40
        Me.decSaldoCuentaAdm.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoCuentaAdm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoCuentaAdm.ForeColor = System.Drawing.Color.Black
        Me.decSaldoCuentaAdm.Location = New System.Drawing.Point(5, 25)
        Me.decSaldoCuentaAdm.MaskInput = "{double:-9.2}"
        Me.decSaldoCuentaAdm.Name = "decSaldoCuentaAdm"
        Me.decSaldoCuentaAdm.Nullable = True
        Me.decSaldoCuentaAdm.NullText = "0.00"
        Me.decSaldoCuentaAdm.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldoCuentaAdm.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSaldoCuentaAdm.ReadOnly = True
        Me.decSaldoCuentaAdm.Size = New System.Drawing.Size(90, 22)
        Me.decSaldoCuentaAdm.TabIndex = 0
        Me.decSaldoCuentaAdm.TabStop = False
        '
        'btnReporteFondoFijo
        '
        Me.btnReporteFondoFijo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnReporteFondoFijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReporteFondoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteFondoFijo.ForeColor = System.Drawing.Color.Black
        Me.btnReporteFondoFijo.Location = New System.Drawing.Point(820, 31)
        Me.btnReporteFondoFijo.Name = "btnReporteFondoFijo"
        Me.btnReporteFondoFijo.Size = New System.Drawing.Size(90, 36)
        Me.btnReporteFondoFijo.TabIndex = 3
        Me.btnReporteFondoFijo.TabStop = False
        Me.btnReporteFondoFijo.Text = "Reporte Fondo Fijo"
        Me.ToolTip1.SetToolTip(Me.btnReporteFondoFijo, "Movimiento del Fondo Fijo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnReporteFondoFijo.Visible = False
        '
        'grupoEstado
        '
        Me.grupoEstado.Controls.Add(Me.ColorReembolsado)
        Me.grupoEstado.Controls.Add(Me.ColorPendiente)
        Me.grupoEstado.Controls.Add(Me.ColorHabilitada)
        Me.grupoEstado.Controls.Add(Me.Etiqueta3)
        Me.grupoEstado.Controls.Add(Me.Etiqueta7)
        Me.grupoEstado.Controls.Add(Me.ColorLiquidada)
        Me.grupoEstado.Controls.Add(Me.Etiqueta9)
        Me.grupoEstado.Controls.Add(Me.ColorNoReembolsado)
        Me.grupoEstado.Controls.Add(Me.Etiqueta31)
        Me.grupoEstado.Controls.Add(Me.Etiqueta32)
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(14, 90)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(684, 41)
        Me.grupoEstado.TabIndex = 18
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorReembolsado
        '
        Me.ColorReembolsado.Location = New System.Drawing.Point(609, 9)
        Me.ColorReembolsado.Name = "ColorReembolsado"
        Me.ColorReembolsado.Size = New System.Drawing.Size(44, 21)
        Me.ColorReembolsado.TabIndex = 9
        Me.ColorReembolsado.TabStop = False
        Me.ColorReembolsado.Text = "Control"
        '
        'ColorPendiente
        '
        Me.ColorPendiente.Location = New System.Drawing.Point(74, 10)
        Me.ColorPendiente.Name = "ColorPendiente"
        Me.ColorPendiente.Size = New System.Drawing.Size(43, 21)
        Me.ColorPendiente.TabIndex = 1
        Me.ColorPendiente.TabStop = False
        Me.ColorPendiente.Text = "Control"
        '
        'ColorHabilitada
        '
        Me.ColorHabilitada.Location = New System.Drawing.Point(199, 10)
        Me.ColorHabilitada.Name = "ColorHabilitada"
        Me.ColorHabilitada.Size = New System.Drawing.Size(44, 21)
        Me.ColorHabilitada.TabIndex = 3
        Me.ColorHabilitada.TabStop = False
        Me.ColorHabilitada.Text = "Control"
        '
        'Etiqueta3
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance41
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(11, 14)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Pendiente:"
        '
        'Etiqueta7
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance42
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(137, 15)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Habilitada:"
        '
        'ColorLiquidada
        '
        Me.ColorLiquidada.Location = New System.Drawing.Point(336, 10)
        Me.ColorLiquidada.Name = "ColorLiquidada"
        Me.ColorLiquidada.Size = New System.Drawing.Size(43, 21)
        Me.ColorLiquidada.TabIndex = 5
        Me.ColorLiquidada.TabStop = False
        Me.ColorLiquidada.Text = "Control"
        '
        'Etiqueta9
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance43
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(528, 14)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(75, 15)
        Me.Etiqueta9.TabIndex = 8
        Me.Etiqueta9.Text = "Reembolsado:"
        '
        'ColorNoReembolsado
        '
        Me.ColorNoReembolsado.Location = New System.Drawing.Point(467, 10)
        Me.ColorNoReembolsado.Name = "ColorNoReembolsado"
        Me.ColorNoReembolsado.Size = New System.Drawing.Size(44, 21)
        Me.ColorNoReembolsado.TabIndex = 7
        Me.ColorNoReembolsado.TabStop = False
        Me.ColorNoReembolsado.Text = "Control"
        '
        'Etiqueta31
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance44
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(278, 14)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta31.TabIndex = 4
        Me.Etiqueta31.Text = "Liquidada:"
        '
        'Etiqueta32
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance45
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(405, 14)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta32.TabIndex = 6
        Me.Etiqueta32.Text = "Cancelado:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficMovimientoViaje)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1177, 624)
        '
        'ficMovimientoViaje
        '
        Me.ficMovimientoViaje.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficMovimientoViaje.Controls.Add(Me.UltraTabPageControl3)
        Me.ficMovimientoViaje.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMovimientoViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimientoViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimientoViaje.Location = New System.Drawing.Point(0, 0)
        Me.ficMovimientoViaje.Name = "ficMovimientoViaje"
        Me.ficMovimientoViaje.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficMovimientoViaje.Size = New System.Drawing.Size(1177, 624)
        Me.ficMovimientoViaje.TabIndex = 0
        UltraTab15.TabPage = Me.UltraTabPageControl3
        UltraTab15.Text = "Bolsa de Viaje"
        UltraTab16.TabPage = Me.UltraTabPageControl4
        UltraTab16.Text = "Rendicion de Gastos"
        Me.ficMovimientoViaje.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16})
        Me.ficMovimientoViaje.TabStop = False
        Me.ficMovimientoViaje.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1175, 601)
        '
        'CalendarioInfo
        '
        Me.CalendarioInfo.DataBindingsForAppointments.BindingContextControl = Me
        Me.CalendarioInfo.DataBindingsForOwners.BindingContextControl = Me
        '
        'odListadoDocumentos
        '
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195})
        '
        'etiTotalGasto
        '
        Appearance246.BackColor = System.Drawing.Color.Transparent
        Appearance246.ForeColor = System.Drawing.Color.Navy
        Me.etiTotalGasto.Appearance = Appearance246
        Me.etiTotalGasto.AutoSize = True
        Me.etiTotalGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalGasto.ForeColor = System.Drawing.Color.Black
        Me.etiTotalGasto.Location = New System.Drawing.Point(821, 20)
        Me.etiTotalGasto.Name = "etiTotalGasto"
        Me.etiTotalGasto.Size = New System.Drawing.Size(64, 14)
        Me.etiTotalGasto.TabIndex = 340
        Me.etiTotalGasto.Text = "Total Gasto:"
        Me.etiTotalGasto.Visible = False
        '
        'MnuFleteAdm
        '
        Me.MnuFleteAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuFleteAdm.ForeColor = System.Drawing.Color.Black
        Me.MnuFleteAdm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCargarFleteAdmn})
        Me.MnuFleteAdm.Name = "MenuContextual1"
        Me.MnuFleteAdm.Size = New System.Drawing.Size(106, 26)
        '
        'MnuCargarFleteAdmn
        '
        Me.MnuCargarFleteAdmn.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.MnuCargarFleteAdmn.Name = "MnuCargarFleteAdmn"
        Me.MnuCargarFleteAdmn.Size = New System.Drawing.Size(105, 22)
        Me.MnuCargarFleteAdmn.Text = "Cargar"
        '
        'orgCuentaCorriente
        '
        UltraDataColumn199.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn201.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn202.DataType = GetType(Decimal)
        UltraDataColumn202.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn203.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn207.DataType = GetType(Boolean)
        UltraDataColumn207.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.orgCuentaCorriente.Band.Columns.AddRange(New Object() {UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204, UltraDataColumn205, UltraDataColumn206, UltraDataColumn207})
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(0, 0)
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(398, -139)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(200, 185)
        Me.UltraExpandableGroupBox2.TabIndex = 115
        Me.UltraExpandableGroupBox2.Text = "UltraExpandableGroupBox2"
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(194, 163)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.AutoScroll = True
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Combo1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Combo2)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Combo3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraMonthViewMulti1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraMonthViewMulti2)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Chequear1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Chequear2)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Agrupacion5)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Agrupacion6)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Chequear9)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Agrupacion7)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraMonthViewMulti3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Boton1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Boton2)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(331, 349)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'Combo1
        '
        Appearance247.ForeColor = System.Drawing.Color.Black
        Me.Combo1.Appearance = Appearance247
        Me.Combo1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.Combo1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.Color.Black
        Me.Combo1.Location = New System.Drawing.Point(81, 312)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(230, 21)
        Me.Combo1.TabIndex = 29
        Me.Combo1.ValueMember = "Id"
        '
        'Combo2
        '
        Appearance248.ForeColor = System.Drawing.Color.Black
        Me.Combo2.Appearance = Appearance248
        Me.Combo2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.Combo2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo2.ForeColor = System.Drawing.Color.Black
        Me.Combo2.Location = New System.Drawing.Point(76, 157)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.Size = New System.Drawing.Size(235, 21)
        Me.Combo2.TabIndex = 28
        Me.Combo2.ValueMember = "Id"
        '
        'Combo3
        '
        Appearance249.ForeColor = System.Drawing.Color.Black
        Me.Combo3.Appearance = Appearance249
        Me.Combo3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.Combo3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo3.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo3.ForeColor = System.Drawing.Color.Black
        Me.Combo3.Location = New System.Drawing.Point(64, 1)
        Me.Combo3.Name = "Combo3"
        Me.Combo3.Size = New System.Drawing.Size(247, 21)
        Me.Combo3.TabIndex = 27
        Me.Combo3.ValueMember = "Id"
        '
        'UltraMonthViewMulti1
        '
        Me.UltraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraMonthViewMulti1.Location = New System.Drawing.Point(8, 338)
        Me.UltraMonthViewMulti1.Name = "UltraMonthViewMulti1"
        Me.UltraMonthViewMulti1.Size = New System.Drawing.Size(144, 128)
        Me.UltraMonthViewMulti1.TabIndex = 26
        '
        'UltraMonthViewMulti2
        '
        Me.UltraMonthViewMulti2.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti2.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraMonthViewMulti2.Location = New System.Drawing.Point(8, 181)
        Me.UltraMonthViewMulti2.Name = "UltraMonthViewMulti2"
        Me.UltraMonthViewMulti2.Size = New System.Drawing.Size(144, 128)
        Me.UltraMonthViewMulti2.TabIndex = 25
        '
        'Chequear1
        '
        Me.Chequear1.AutoSize = True
        Me.Chequear1.Checked = True
        Me.Chequear1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear1.ForeColor = System.Drawing.Color.Black
        Me.Chequear1.Location = New System.Drawing.Point(9, 3)
        Me.Chequear1.Name = "Chequear1"
        Me.Chequear1.Size = New System.Drawing.Size(49, 17)
        Me.Chequear1.TabIndex = 11
        Me.Chequear1.Text = "Piloto"
        '
        'Chequear2
        '
        Me.Chequear2.AutoSize = True
        Me.Chequear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear2.ForeColor = System.Drawing.Color.Black
        Me.Chequear2.Location = New System.Drawing.Point(8, 315)
        Me.Chequear2.Name = "Chequear2"
        Me.Chequear2.Size = New System.Drawing.Size(67, 17)
        Me.Chequear2.TabIndex = 22
        Me.Chequear2.Text = "Ayudante"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.Chequear3)
        Me.Agrupacion5.Controls.Add(Me.Chequear4)
        Me.Agrupacion5.Controls.Add(Me.Chequear5)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(156, 341)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(79, 81)
        Me.Agrupacion5.TabIndex = 24
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'Chequear3
        '
        Me.Chequear3.AutoSize = True
        Me.Chequear3.Checked = True
        Me.Chequear3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear3.ForeColor = System.Drawing.Color.Black
        Me.Chequear3.Location = New System.Drawing.Point(6, 9)
        Me.Chequear3.Name = "Chequear3"
        Me.Chequear3.Size = New System.Drawing.Size(71, 17)
        Me.Chequear3.TabIndex = 14
        Me.Chequear3.Text = "Desayuno"
        '
        'Chequear4
        '
        Me.Chequear4.AutoSize = True
        Me.Chequear4.Checked = True
        Me.Chequear4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear4.ForeColor = System.Drawing.Color.Black
        Me.Chequear4.Location = New System.Drawing.Point(6, 55)
        Me.Chequear4.Name = "Chequear4"
        Me.Chequear4.Size = New System.Drawing.Size(47, 17)
        Me.Chequear4.TabIndex = 15
        Me.Chequear4.Text = "Cena"
        '
        'Chequear5
        '
        Me.Chequear5.AutoSize = True
        Me.Chequear5.Checked = True
        Me.Chequear5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear5.ForeColor = System.Drawing.Color.Black
        Me.Chequear5.Location = New System.Drawing.Point(6, 32)
        Me.Chequear5.Name = "Chequear5"
        Me.Chequear5.Size = New System.Drawing.Size(68, 17)
        Me.Chequear5.TabIndex = 13
        Me.Chequear5.Text = "Almuerzo"
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.Chequear6)
        Me.Agrupacion6.Controls.Add(Me.Chequear7)
        Me.Agrupacion6.Controls.Add(Me.Chequear8)
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(158, 184)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(79, 81)
        Me.Agrupacion6.TabIndex = 2
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'Chequear6
        '
        Me.Chequear6.AutoSize = True
        Me.Chequear6.Checked = True
        Me.Chequear6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear6.ForeColor = System.Drawing.Color.Black
        Me.Chequear6.Location = New System.Drawing.Point(6, 10)
        Me.Chequear6.Name = "Chequear6"
        Me.Chequear6.Size = New System.Drawing.Size(71, 17)
        Me.Chequear6.TabIndex = 14
        Me.Chequear6.Text = "Desayuno"
        '
        'Chequear7
        '
        Me.Chequear7.AutoSize = True
        Me.Chequear7.Checked = True
        Me.Chequear7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear7.ForeColor = System.Drawing.Color.Black
        Me.Chequear7.Location = New System.Drawing.Point(6, 56)
        Me.Chequear7.Name = "Chequear7"
        Me.Chequear7.Size = New System.Drawing.Size(47, 17)
        Me.Chequear7.TabIndex = 15
        Me.Chequear7.Text = "Cena"
        '
        'Chequear8
        '
        Me.Chequear8.AutoSize = True
        Me.Chequear8.Checked = True
        Me.Chequear8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear8.ForeColor = System.Drawing.Color.Black
        Me.Chequear8.Location = New System.Drawing.Point(6, 33)
        Me.Chequear8.Name = "Chequear8"
        Me.Chequear8.Size = New System.Drawing.Size(68, 17)
        Me.Chequear8.TabIndex = 13
        Me.Chequear8.Text = "Almuerzo"
        '
        'Chequear9
        '
        Me.Chequear9.AutoSize = True
        Me.Chequear9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear9.ForeColor = System.Drawing.Color.Black
        Me.Chequear9.Location = New System.Drawing.Point(9, 160)
        Me.Chequear9.Name = "Chequear9"
        Me.Chequear9.Size = New System.Drawing.Size(61, 17)
        Me.Chequear9.TabIndex = 12
        Me.Chequear9.Text = "Copiloto"
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.Chequear10)
        Me.Agrupacion7.Controls.Add(Me.Chequear11)
        Me.Agrupacion7.Controls.Add(Me.Chequear12)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(157, 26)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(78, 81)
        Me.Agrupacion7.TabIndex = 23
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'Chequear10
        '
        Me.Chequear10.AutoSize = True
        Me.Chequear10.Checked = True
        Me.Chequear10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear10.ForeColor = System.Drawing.Color.Black
        Me.Chequear10.Location = New System.Drawing.Point(4, 8)
        Me.Chequear10.Name = "Chequear10"
        Me.Chequear10.Size = New System.Drawing.Size(71, 17)
        Me.Chequear10.TabIndex = 17
        Me.Chequear10.Text = "Desayuno"
        '
        'Chequear11
        '
        Me.Chequear11.AutoSize = True
        Me.Chequear11.Checked = True
        Me.Chequear11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear11.ForeColor = System.Drawing.Color.Black
        Me.Chequear11.Location = New System.Drawing.Point(4, 54)
        Me.Chequear11.Name = "Chequear11"
        Me.Chequear11.Size = New System.Drawing.Size(47, 17)
        Me.Chequear11.TabIndex = 18
        Me.Chequear11.Text = "Cena"
        '
        'Chequear12
        '
        Me.Chequear12.AutoSize = True
        Me.Chequear12.Checked = True
        Me.Chequear12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chequear12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear12.ForeColor = System.Drawing.Color.Black
        Me.Chequear12.Location = New System.Drawing.Point(4, 31)
        Me.Chequear12.Name = "Chequear12"
        Me.Chequear12.Size = New System.Drawing.Size(68, 17)
        Me.Chequear12.TabIndex = 16
        Me.Chequear12.Text = "Almuerzo"
        '
        'UltraMonthViewMulti3
        '
        Me.UltraMonthViewMulti3.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti3.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraMonthViewMulti3.CalendarInfo = Me.CalendarioInfo
        Me.UltraMonthViewMulti3.CalendarLook = Me.CalendarioVista
        Me.UltraMonthViewMulti3.Location = New System.Drawing.Point(8, 26)
        Me.UltraMonthViewMulti3.Name = "UltraMonthViewMulti3"
        Me.UltraMonthViewMulti3.Size = New System.Drawing.Size(144, 128)
        Me.UltraMonthViewMulti3.TabIndex = 0
        '
        'Boton1
        '
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.Black
        Me.Boton1.Location = New System.Drawing.Point(241, 57)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(70, 25)
        Me.Boton1.TabIndex = 18
        Me.Boton1.Text = "Cancelar"
        '
        'Boton2
        '
        Me.Boton2.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.ForeColor = System.Drawing.Color.Black
        Me.Boton2.Location = New System.Drawing.Point(241, 28)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(70, 25)
        Me.Boton2.TabIndex = 17
        Me.Boton2.Text = "Aceptar"
        '
        'ogdGastoOperacion
        '
        UltraDataColumn215.DataType = GetType(Double)
        UltraDataColumn217.DataType = GetType(Date)
        UltraDataColumn220.DataType = GetType(Date)
        UltraDataColumn226.DataType = GetType(Double)
        UltraDataColumn226.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn227.DataType = GetType(Double)
        UltraDataColumn232.DataType = GetType(Double)
        UltraDataColumn246.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.ogdGastoOperacion.Band.Columns.AddRange(New Object() {UltraDataColumn208, UltraDataColumn209, UltraDataColumn210, UltraDataColumn211, UltraDataColumn212, UltraDataColumn213, UltraDataColumn214, UltraDataColumn215, UltraDataColumn216, UltraDataColumn217, UltraDataColumn218, UltraDataColumn219, UltraDataColumn220, UltraDataColumn221, UltraDataColumn222, UltraDataColumn223, UltraDataColumn224, UltraDataColumn225, UltraDataColumn226, UltraDataColumn227, UltraDataColumn228, UltraDataColumn229, UltraDataColumn230, UltraDataColumn231, UltraDataColumn232, UltraDataColumn233, UltraDataColumn234, UltraDataColumn235, UltraDataColumn236, UltraDataColumn237, UltraDataColumn238, UltraDataColumn239, UltraDataColumn240, UltraDataColumn241, UltraDataColumn242, UltraDataColumn243, UltraDataColumn244, UltraDataColumn245, UltraDataColumn246, UltraDataColumn247, UltraDataColumn248, UltraDataColumn249, UltraDataColumn250})
        '
        'ficMovimiento
        '
        Me.ficMovimiento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMovimiento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMovimiento.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimiento.Location = New System.Drawing.Point(0, 0)
        Me.ficMovimiento.Name = "ficMovimiento"
        Me.ficMovimiento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMovimiento.Size = New System.Drawing.Size(1179, 647)
        Me.ficMovimiento.TabIndex = 0
        UltraTab17.TabPage = Me.UltraTabPageControl1
        UltraTab17.Text = "Viaje"
        UltraTab18.TabPage = Me.UltraTabPageControl2
        UltraTab18.Text = "Movimiento"
        Me.ficMovimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab17, UltraTab18})
        Me.ficMovimiento.TabStop = False
        Me.ficMovimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1177, 624)
        '
        'ToolTip
        '
        Me.ToolTip.ContainingControl = Me
        '
        'frm_Movimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 647)
        Me.Controls.Add(Me.ficMovimiento)
        Me.KeyPreview = True
        Me.Name = "frm_Movimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl12.ResumeLayout(False)
        Me.UltraTabPageControl12.PerformLayout
        CType(Me.txtAyudanteDescuento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcTrabajadorDescuento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPilotoDescuento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCopilotoDescuento, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraCalcManager, System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuContextualFlete.ResumeLayout(False)
        CType(Me.ogdMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBoxMovCuenta, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBoxMovCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion8.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl6.PerformLayout
        CType(Me.verGlosaDestino, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verGlosaOrigen, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout
        CType(Me.decSaldoViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaDestino, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaOrigen, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fechaPrestamo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decImportePrestamo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTrabajadorPrestamo, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.UltraTabPageControl7.PerformLayout
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboConceptoDsct, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.verGlosa, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FicTrabajadorDescuento, System.ComponentModel.ISupportInitialize).EndInit
        Me.FicTrabajadorDescuento.ResumeLayout(False)
        CType(Me.decImporteDescuento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaDescuento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fecFechaDescuento, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl15.ResumeLayout(False)
        Me.UltraTabPageControl15.PerformLayout
        CType(Me.txtTipoCarga, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtComisionista, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decComision, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCarga, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl14.PerformLayout
        CType(Me.decMontoMaximo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decMontoNormal, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decMontoMinimo, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl10.ResumeLayout(False)
        Me.UltraTabPageControl10.PerformLayout
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fechaRecibidor, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl11.ResumeLayout(False)
        Me.UltraTabPageControl11.PerformLayout
        CType(Me.decSaldoCuenta, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl17.ResumeLayout(False)
        Me.UltraTabPageControl17.PerformLayout
        CType(Me.decHabEfectivo, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.griListaDocumentoCompra, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl19.ResumeLayout(False)
        Me.UltraTabPageControl19.PerformLayout
        CType(Me.txtGlosaOC, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt_NroOrden, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl16.ResumeLayout(False)
        Me.UltraTabPageControl16.PerformLayout
        CType(Me.Texto1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Texto2, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.agrViajesProgramados, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrViajesProgramados.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit
        Me.MnContMovimiento.ResumeLayout(False)
        CType(Me.ogdMovimientoViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.agrMovimientoCaja, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrMovimientoCaja.ResumeLayout(False)
        CType(Me.GriCuentaAdministrativa, System.ComponentModel.ISupportInitialize).EndInit
        Me.MnAdministrativo.ResumeLayout(False)
        CType(Me.ogdAdministrativo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expIngresoFF, System.ComponentModel.ISupportInitialize).EndInit
        Me.expIngresoFF.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion10.ResumeLayout(False)
        Me.Agrupacion10.PerformLayout
        CType(Me.decIngresoFF, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosaFF, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fecIngresoFF, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.agrMovimientoDetalle, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrMovimientoDetalle.ResumeLayout(False)
        CType(Me.agrCuentaIzq, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrCuentaIzq.ResumeLayout(False)
        CType(Me.ficMovimientoDetalle, System.ComponentModel.ISupportInitialize).EndInit
        Me.ficMovimientoDetalle.ResumeLayout(False)
        CType(Me.expGlosa, System.ComponentModel.ISupportInitialize).EndInit
        Me.expGlosa.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrSalida, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrSalida.ResumeLayout(False)
        CType(Me.agrDefinicion, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDefinicion.ResumeLayout(False)
        Me.agrDefinicion.PerformLayout
        CType(Me.FicObservacion, System.ComponentModel.ISupportInitialize).EndInit
        Me.FicObservacion.ResumeLayout(False)
        CType(Me.agrMuestraCuenta, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrMuestraCuenta.ResumeLayout(False)
        CType(Me.agrCuentaInferior, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrCuentaInferior.ResumeLayout(False)
        Me.agrCuentaInferior.PerformLayout
        CType(Me.agrCuenta, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrCuenta.ResumeLayout(False)
        Me.agrCuenta.PerformLayout
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decEgresos, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decTotalGastos, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decIngresos, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrIEFF, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrIEFF.ResumeLayout(False)
        Me.agrIEFF.PerformLayout
        CType(Me.fechaMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decImporte, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcSalidaEntrada, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrDatosViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDatosViaje.ResumeLayout(False)
        Me.agrDatosViaje.PerformLayout
        CType(Me.txtCantidadPeajes, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numCostoEstiba, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCarreta, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAyudante, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decPeso, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCopiloto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTracto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fecFechaViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPiloto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRuta, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FicDatos, System.ComponentModel.ISupportInitialize).EndInit
        Me.FicDatos.ResumeLayout(False)
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcDefinicion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fechaBalancin, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ExpGroupBoxReceptor, System.ComponentModel.ISupportInitialize).EndInit
        Me.ExpGroupBoxReceptor.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.picRecibidor, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.agrDetalleGasto, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDetalleGasto.ResumeLayout(False)
        CType(Me.agrGastoOperacion, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrGastoOperacion.ResumeLayout(False)
        CType(Me.griGastoOperacion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDatos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.agrContenedor1, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrContenedor1.ResumeLayout(False)
        Me.agrContenedor1.PerformLayout
        CType(Me.cboLugarL, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expTarjetaMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        Me.expTarjetaMovimiento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.griMovTarjeta, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.udsMovimientoTarjeta, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout
        CType(Me.expDocumento, System.ComponentModel.ISupportInitialize).EndInit
        Me.expDocumento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit
        Me.Ficha1.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout
        CType(Me.cboDocumentoAlmacen, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbNroDoc.ResumeLayout(False)
        Me.gbNroDoc.PerformLayout
        CType(Me.txtSerieDoc, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNumeroDoc, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboProveedores, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ExpRegistroConsumoCombustible, System.ComponentModel.ISupportInitialize).EndInit
        Me.ExpRegistroConsumoCombustible.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboDireccion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout
        CType(Me.DecCantidadGalones, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrTotalGasto, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrTotalGasto.ResumeLayout(False)
        Me.agrTotalGasto.PerformLayout
        CType(Me.numCubrir, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numAgregado, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRUC, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.txtGlosa2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrDatoOperacion, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDatoOperacion.ResumeLayout(False)
        Me.agrDatoOperacion.PerformLayout
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAutoriza, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboGastoFuncion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTrabajador2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboPlaca, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboAutorizaGasto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DecPercepcion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DecNoGravada, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numIGV, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numImporte, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DecPagoxCaja, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numGasto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numTipoCambio, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        CType(Me.Ficha2, System.ComponentModel.ISupportInitialize).EndInit
        Me.Ficha2.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion11.ResumeLayout(False)
        Me.Agrupacion11.PerformLayout
        CType(Me.Combo4, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        CType(Me.Texto3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Texto4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboOpcionGasto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboReferencia, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.AgrupacionFooter, System.ComponentModel.ISupportInitialize).EndInit
        Me.AgrupacionFooter.ResumeLayout(False)
        CType(Me.ficTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        Me.ficTipoMovimiento.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout
        CType(Me.chkBuscarCopiloto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboEstadoViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrOtrosIngresos, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrOtrosIngresos.ResumeLayout(False)
        Me.agrOtrosIngresos.PerformLayout
        CType(Me.decTotalOtrosIngresos, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCodViaje, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrTotalFF, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrTotalFF.ResumeLayout(False)
        Me.agrTotalFF.PerformLayout
        CType(Me.decTotalFF, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboTrabajadorMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrVales, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrVales.ResumeLayout(False)
        Me.agrVales.PerformLayout
        CType(Me.decTotalVales, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrGastosAdm, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrGastosAdm.ResumeLayout(False)
        Me.agrGastosAdm.PerformLayout
        CType(Me.decGastosAdm, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkViajeVacio, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrSaldo, System.ComponentModel.ISupportInitialize).EndInit
        Me.agrSaldo.ResumeLayout(False)
        Me.agrSaldo.PerformLayout
        CType(Me.decSaldoCuentaAdm, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).EndInit
        Me.grupoEstado.ResumeLayout(False)
        Me.grupoEstado.PerformLayout
        CType(Me.ColorReembolsado, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorHabilitada, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorLiquidada, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ColorNoReembolsado, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficMovimientoViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.ficMovimientoViaje.ResumeLayout(False)
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit
        Me.MnuFleteAdm.ResumeLayout(False)
        CType(Me.orgCuentaCorriente, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout
        CType(Me.Combo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Combo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Combo3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraMonthViewMulti2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout
        CType(Me.Chequear3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout
        CType(Me.Chequear6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout
        CType(Me.Chequear10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Chequear12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraMonthViewMulti3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdGastoOperacion, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ficMovimiento, System.ComponentModel.ISupportInitialize).EndInit
        Me.ficMovimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMovimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ogdMovimientoViaje As ISL.Controles.OrigenDatos
    Friend WithEvents MnContMovimiento As ISL.Controles.MenuContextual
    Friend WithEvents ficMovimientoViaje As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrMovimientoDetalle As ISL.Controles.Agrupacion
    Friend WithEvents agrSalida As ISL.Controles.Agrupacion
    Friend WithEvents agrCuenta As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents etiGastosRendidos As ISL.Controles.Etiqueta
    Friend WithEvents decEgresos As ISL.Controles.NumeroDecimal
    Friend WithEvents decTotalGastos As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents opcDefinicion As ISL.Controles.Opciones
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboCaja As ISL.Controles.ComboMaestros
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents decImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents fechaMovimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents txtRuta As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtTracto As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents txtCopiloto As ISL.Controles.Texto
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents txtPiloto As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaViaje As ISL.Controles.Fecha
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents etiNumero As ISL.Controles.Etiqueta
    Friend WithEvents etiSerie As ISL.Controles.Etiqueta
    Friend WithEvents etiTipoDocumento As ISL.Controles.Etiqueta
    Friend WithEvents etiFlujoCaja As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents etiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As ISL.Controles.Fecha
    Friend WithEvents etiRuc As ISL.Controles.Etiqueta
    Friend WithEvents numIGV As ISL.Controles.NumeroDecimal
    Friend WithEvents etiIGV As ISL.Controles.Etiqueta
    Friend WithEvents numImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents Importe As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoGasto As ISL.Controles.Combo
    Friend WithEvents etiTipoGasto As ISL.Controles.Etiqueta
    Friend WithEvents etiProveedor As ISL.Controles.Etiqueta
    Friend WithEvents txtRUC As ISL.Controles.Texto
    Friend WithEvents txtGlosa2 As ISL.Controles.Texto
    Friend WithEvents etiGlosa As ISL.Controles.Etiqueta
    Friend WithEvents cboRuta As ISL.Controles.Combo
    Friend WithEvents cboPlaca As ISL.Controles.Combo
    Friend WithEvents cboTrabajador2 As ISL.Controles.Combo
    Friend WithEvents etiAutoriza As ISL.Controles.Etiqueta
    Friend WithEvents etiGastoFuncion As ISL.Controles.Etiqueta
    Friend WithEvents etiCentroCosto As ISL.Controles.Etiqueta
    Friend WithEvents etiRuta As ISL.Controles.Etiqueta
    Friend WithEvents etiPlaca As ISL.Controles.Etiqueta
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboAutoriza As ISL.Controles.Combo
    Friend WithEvents cboGastoFuncion As ISL.Controles.Combo
    Friend WithEvents cboCentroCosto As ISL.Controles.Combo
    Friend WithEvents griGastoOperacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents agrDatoOperacion As ISL.Controles.Agrupacion
    Friend WithEvents picRecibidor As System.Windows.Forms.PictureBox
    Friend WithEvents opcVerPiloto As System.Windows.Forms.RadioButton
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents fechaRecibidor As ISL.Controles.Fecha
    Friend WithEvents opcVerOtro As System.Windows.Forms.RadioButton
    Friend WithEvents etiFechaRecepcion As ISL.Controles.Etiqueta
    Friend WithEvents opcVerCopiloto As System.Windows.Forms.RadioButton
    Friend WithEvents txtViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ficMovimientoDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtGlosaDestino As ISL.Controles.Texto
    Friend WithEvents txtGlosaOrigen As ISL.Controles.Texto
    Friend WithEvents fechaPrestamo As ISL.Controles.Fecha
    Friend WithEvents cboViaje As ISL.Controles.Combo
    Friend WithEvents decSaldoViaje As ISL.Controles.NumeroDecimal
    Friend WithEvents decImportePrestamo As ISL.Controles.NumeroDecimal
    Friend WithEvents cboTrabajadorPrestamo As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents etiRutaAsociada As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaDescuento As ISL.Controles.Texto
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaDescuento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents txtPilotoDescuento As ISL.Controles.Texto
    Friend WithEvents fechaBalancin As ISL.Controles.Fecha
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents agrDefinicion As ISL.Controles.Agrupacion
    Friend WithEvents ExpGroupBoxReceptor As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents HabilitarBolsaDeViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmpliacionBolsaDeViajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents decIngresos As ISL.Controles.NumeroDecimal
    Friend WithEvents ogdMovimiento As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents opcVerAyudante As System.Windows.Forms.RadioButton
    Friend WithEvents griMovimiento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBoxMovCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnDescuento As ISL.Controles.Boton
    Friend WithEvents btnPrestamos As ISL.Controles.Boton
    Friend WithEvents btnDocumentos As ISL.Controles.Boton
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents etiRutaPrestamo As ISL.Controles.Etiqueta
    Friend WithEvents opcTipoMovimiento As ISL.Controles.Opciones
    Friend WithEvents UltraCalcManager As Infragistics.Win.UltraWinCalcManager.UltraCalcManager
    Friend WithEvents numTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents agrDatos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrDetalleGasto As ISL.Controles.Agrupacion
    Friend WithEvents etiFechaDoc As ISL.Controles.Etiqueta
    Friend WithEvents agrGastoOperacion As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents btnCancelarDetalle As ISL.Controles.Boton
    Friend WithEvents btnAceptarDetalle As ISL.Controles.Boton
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents numTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents etiTipoCambio As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents etiMoneda As ISL.Controles.Etiqueta
    Friend WithEvents etiNroGrupo As ISL.Controles.Etiqueta
    Friend WithEvents etiFechavencimiento As ISL.Controles.Etiqueta
    Friend WithEvents cboGrupo As ISL.Controles.Combo
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents decImporteDescuento As ISL.Controles.NumeroDecimal
    Friend WithEvents opcSalidaEntrada As ISL.Controles.Opciones
    Friend WithEvents agrTotalGasto As ISL.Controles.Agrupacion
    Friend WithEvents etiTotalCubrir As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalAgregado As ISL.Controles.Etiqueta
    Friend WithEvents numCubrir As ISL.Controles.NumeroDecimal
    Friend WithEvents numAgregado As ISL.Controles.NumeroDecimal
    Friend WithEvents LiquidarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents etiLiquidar As ISL.Controles.Etiqueta
    Friend WithEvents opcTrabajadorDescuento As ISL.Controles.Opciones
    Friend WithEvents txtCopilotoDescuento As ISL.Controles.Texto
    Friend WithEvents ficTipoMovimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents etiEstadoAsociado As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaViajeAsociado As ISL.Controles.Etiqueta
    Friend WithEvents eti As ISL.Controles.Etiqueta
    Friend WithEvents etiFecha As ISL.Controles.Etiqueta
    Friend WithEvents agrViajesProgramados As ISL.Controles.Agrupacion
    Friend WithEvents agrMovimientoCaja As ISL.Controles.Agrupacion
    Friend WithEvents ogdAdministrativo As ISL.Controles.OrigenDatos
    Friend WithEvents orgCuentaCorriente As ISL.Controles.OrigenDatos
    Friend WithEvents MnAdministrativo As ISL.Controles.MenuContextual
    Friend WithEvents FicDatos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatosViaje As ISL.Controles.Agrupacion
    Friend WithEvents decSaldoCuenta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents FicTrabajadorDescuento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage6 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrIEFF As ISL.Controles.Agrupacion
    Friend WithEvents AgrupacionFooter As ISL.Controles.Agrupacion
    Friend WithEvents tsmiDocumentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabilitarCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents expGlosa As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griListaGlosa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents agrCuentaIzq As ISL.Controles.Agrupacion
    Friend WithEvents ReporteFondoFijoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ExpRegistroConsumoCombustible As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents DecCantidadGalones As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents cboMaterial As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents cboDireccion As ISL.Controles.ComboMaestros
    Friend WithEvents cboLugar As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrMuestraCuenta As ISL.Controles.Agrupacion
    Friend WithEvents agrCuentaInferior As ISL.Controles.Agrupacion
    Friend WithEvents FicObservacion As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage7 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CalendarioVista As Infragistics.Win.UltraWinSchedule.UltraCalendarLook
    Friend WithEvents CalendarioInfo As Infragistics.Win.UltraWinSchedule.UltraCalendarInfo
    Friend WithEvents agrContenedor1 As ISL.Controles.Agrupacion
    Friend WithEvents etiNroChequeAsociado As ISL.Controles.Etiqueta
    Friend WithEvents etiCheque As ISL.Controles.Etiqueta
    Friend WithEvents ToolTip As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents txtCarga As ISL.Controles.Texto
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents txtCliente As ISL.Controles.Texto
    Friend WithEvents verGlosaDestino As ISL.Controles.Chequear
    Friend WithEvents verGlosaOrigen As ISL.Controles.Chequear
    Friend WithEvents verGlosa As ISL.Controles.Chequear
    Friend WithEvents MenuContextualFlete As ISL.Controles.MenuContextual
    Friend WithEvents MnuIngresoFlete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuFleteAdm As ISL.Controles.MenuContextual
    Friend WithEvents MnuCargarFleteAdmn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuIngresoFleteCta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents DecNoGravada As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta54 As ISL.Controles.Etiqueta
    Friend WithEvents DecPercepcion As ISL.Controles.NumeroDecimal
    Friend WithEvents ChkVehiculoProper As System.Windows.Forms.CheckBox
    Friend WithEvents btnNuevoProveedor As ISL.Controles.Boton
    Friend WithEvents btnLiquidar As ISL.Controles.Boton
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Combo1 As ISL.Controles.Combo
    Friend WithEvents Combo2 As ISL.Controles.Combo
    Friend WithEvents Combo3 As ISL.Controles.Combo
    Friend WithEvents UltraMonthViewMulti1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents UltraMonthViewMulti2 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents Chequear1 As ISL.Controles.Chequear
    Friend WithEvents Chequear2 As ISL.Controles.Chequear
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Chequear3 As ISL.Controles.Chequear
    Friend WithEvents Chequear4 As ISL.Controles.Chequear
    Friend WithEvents Chequear5 As ISL.Controles.Chequear
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Chequear6 As ISL.Controles.Chequear
    Friend WithEvents Chequear7 As ISL.Controles.Chequear
    Friend WithEvents Chequear8 As ISL.Controles.Chequear
    Friend WithEvents Chequear9 As ISL.Controles.Chequear
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents Chequear10 As ISL.Controles.Chequear
    Friend WithEvents Chequear11 As ISL.Controles.Chequear
    Friend WithEvents Chequear12 As ISL.Controles.Chequear
    Friend WithEvents UltraMonthViewMulti3 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents Boton2 As ISL.Controles.Boton
    Friend WithEvents expDocumento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents btnBuscarDocumento As ISL.Controles.Boton
    Friend WithEvents gbNroDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerieDoc As ISL.Controles.Texto
    Friend WithEvents txtNumeroDoc As ISL.Controles.Texto
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents cboDocumentoAlmacen As ISL.Controles.Combo
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents btnLimpiar As ISL.Controles.Boton
    Friend WithEvents dtpFecVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents CierreCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents expIngresoFF As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents decIngresoFF As ISL.Controles.NumeroDecimal
    Friend WithEvents txtGlosaFF As ISL.Controles.Texto
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents fecIngresoFF As ISL.Controles.Fecha
    Friend WithEvents Etiqueta53 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta55 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta57 As ISL.Controles.Etiqueta
    Friend WithEvents decHabEfectivo As ISL.Controles.NumeroDecimal
    Friend WithEvents GenerarGrupoFlete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ogdGastoOperacion As ISL.Controles.OrigenDatos
    Friend WithEvents etiTotalGasto As ISL.Controles.Etiqueta
    Friend WithEvents numGasto As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta56 As ISL.Controles.Etiqueta
    Friend WithEvents etiFecSalOrigen As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta58 As ISL.Controles.Etiqueta
    Friend WithEvents etiCarga As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta60 As ISL.Controles.Etiqueta
    Friend WithEvents etiFecLleDestino As ISL.Controles.Etiqueta
    Friend WithEvents txtAyudanteDescuento As ISL.Controles.Texto
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage8 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaDocumentoCompra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Etiqueta59 As ISL.Controles.Etiqueta
    Friend WithEvents txt_NroOrden As ISL.Controles.Texto
    Friend WithEvents decPeso As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta61 As ISL.Controles.Etiqueta
    Friend WithEvents btnActPeso As ISL.Controles.Boton
    Friend WithEvents fecHoraPeaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta62 As ISL.Controles.Etiqueta
    Friend WithEvents txtAyudante As ISL.Controles.Texto
    Friend WithEvents chkPagoxCaja As System.Windows.Forms.CheckBox
    Friend WithEvents DecPagoxCaja As ISL.Controles.NumeroDecimal
    Friend WithEvents decComision As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta63 As ISL.Controles.Etiqueta
    Friend WithEvents txtComisionista As ISL.Controles.Texto
    Friend WithEvents Etiqueta64 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta65 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosaOC As ISL.Controles.Texto
    Private WithEvents cboProveedores As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents GriCuentaAdministrativa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents agrOtrosIngresos As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalOtrosIngresos As ISL.Controles.NumeroDecimal
    Friend WithEvents agrTotalFF As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalFF As ISL.Controles.NumeroDecimal
    Friend WithEvents agrVales As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalVales As ISL.Controles.NumeroDecimal
    Friend WithEvents agrGastosAdm As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decGastosAdm As ISL.Controles.NumeroDecimal
    Friend WithEvents chkBuscarCopiloto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkViajeVacio As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents agrSaldo As ISL.Controles.Agrupacion
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decSaldoCuentaAdm As ISL.Controles.NumeroDecimal
    Friend WithEvents btnReporteFondoFijo As ISL.Controles.Boton
    Friend WithEvents cboEstadoViaje As ISL.Controles.Combo
    Friend WithEvents etiEstado As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodViaje As ISL.Controles.Texto
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents etiViaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTrabajadorMovimiento As ISL.Controles.Combo
    Friend WithEvents etiTrabajadorCuenta As ISL.Controles.Etiqueta
    Friend WithEvents etitracto As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents ColorReembolsado As ISL.Controles.Colores
    Friend WithEvents ColorPendiente As ISL.Controles.Colores
    Friend WithEvents ColorHabilitada As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorLiquidada As ISL.Controles.Colores
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents ColorNoReembolsado As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents cboArea As ISL.Controles.Combo
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents cboAutorizaGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents decMontoMaximo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta67 As ISL.Controles.Etiqueta
    Friend WithEvents decMontoNormal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta66 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents decMontoMinimo As ISL.Controles.NumeroDecimal
    Friend WithEvents btnAgregarCostoEstiba As ISL.Controles.Boton
    Friend WithEvents numCostoEstiba As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta68 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoVehiculo As ISL.Controles.Texto
    Friend WithEvents Etiqueta70 As ISL.Controles.Etiqueta
    Friend WithEvents txtCarreta As ISL.Controles.Texto
    Friend WithEvents Etiqueta69 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents cboLugarL As ISL.Controles.Combo
    Friend WithEvents CuadreCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoCarga As ISL.Controles.Texto
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Ficha2 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage9 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents Texto1 As ISL.Controles.Texto
    Friend WithEvents Texto2 As ISL.Controles.Texto
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents Combo4 As ISL.Controles.Combo
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents Boton3 As ISL.Controles.Boton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Texto3 As ISL.Controles.Texto
    Friend WithEvents Texto4 As ISL.Controles.Texto
    Friend WithEvents expTarjetaMovimiento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents griMovTarjeta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udsMovimientoTarjeta As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnListar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblCantidadPeajes As ISL.Controles.Etiqueta
    Friend WithEvents txtCantidadPeajes As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents cboReferencia As ISL.Controles.Combo
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents cboOpcionGasto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboConceptoDsct As ISL.Controles.Combo
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents numCuotas As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta71 As ISL.Controles.Etiqueta
    Friend WithEvents upbFoto As Infragistics.Win.UltraWinEditors.UltraPictureBox
End Class
