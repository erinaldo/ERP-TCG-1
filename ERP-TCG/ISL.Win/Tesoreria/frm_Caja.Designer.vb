<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Caja
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCaja")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCuenta")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCuentaBancaria")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCaja")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCuenta")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoCuentaBancaria")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreBanco")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCuenta")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreMoneda")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoInicial")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactoTelefono")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaActiva")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaPasiva")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LineaCredito")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreBanco")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCuenta")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreMoneda")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoInicial")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ContactoTelefono")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaActiva")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaPasiva")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LineaCredito")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCorrelativo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCaja")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCaja")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuarios")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abreviatura")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuarios")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sexo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaNacimiento")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargo")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCese")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMontoCaja = New ISL.Controles.Grilla(Me.components)
        Me.mcMovimientosCaja = New ISL.Controles.MenuContextual(Me.components)
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdCajaMonto = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.spcCuentaBancaria = New System.Windows.Forms.SplitContainer()
        Me.agrRegistroMonto = New ISL.Controles.Agrupacion(Me.components)
        Me.decSaldoCuenta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnMostrarCuentaBancaria = New ISL.Controles.Boton(Me.components)
        Me.fecFecha = New ISL.Controles.Fecha(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCaja = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCuentaBancaria = New ISL.Controles.Texto(Me.components)
        Me.decMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verActivoMonto = New ISL.Controles.Chequear(Me.components)
        Me.griListaCuentaBancaria = New ISL.Controles.Grilla(Me.components)
        Me.ogdCuentaBancaria = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficMontoCaja = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.griUsuarioCaja = New ISL.Controles.Grilla(Me.components)
        Me.menContextualUsuariosCaja = New ISL.Controles.MenuContextual(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdUsuarioCaja = New ISL.Controles.OrigenDatos(Me.components)
        Me.griTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalCaja = New ISL.Controles.Agrupacion(Me.components)
        Me.griListaCaja = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdCaja = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrMovimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.ficMovimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuMovimiento = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Gb_DatoGeneralDemanda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtAbreviatura = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ordTrabajador = New ISL.Controles.OrigenDatos(Me.components)
        Me.tcCaja = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.frm_MenuPadre_Fill_Panel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griMontoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcMovimientosCaja.SuspendLayout()
        CType(Me.ogdCajaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.spcCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcCuentaBancaria.Panel1.SuspendLayout()
        Me.spcCuentaBancaria.Panel2.SuspendLayout()
        Me.spcCuentaBancaria.SuspendLayout()
        CType(Me.agrRegistroMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRegistroMonto.SuspendLayout()
        CType(Me.decSaldoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivoMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griListaCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ficMontoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMontoCaja.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.griUsuarioCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menContextualUsuariosCaja.SuspendLayout()
        CType(Me.ogdUsuarioCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalCaja.SuspendLayout()
        CType(Me.griListaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ogdCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMovimiento.SuspendLayout()
        CType(Me.ficMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMovimiento.SuspendLayout()
        CType(Me.MenuMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralDemanda.SuspendLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCaja.SuspendLayout()
        Me.frm_MenuPadre_Fill_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griMontoCaja)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1137, 250)
        '
        'griMontoCaja
        '
        Me.griMontoCaja.ContextMenuStrip = Me.mcMovimientosCaja
        Me.griMontoCaja.DataSource = Me.ogdCajaMonto
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 101
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 80
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn7.Header.Caption = "Numero Cuenta"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn7.Width = 287
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 57
        UltraGridColumn10.Header.Caption = "Saldo Cuenta Bancaria"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.griMontoCaja.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griMontoCaja.DisplayLayout.MaxColScrollRegions = 1
        Me.griMontoCaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMontoCaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMontoCaja.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMontoCaja.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMontoCaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMontoCaja.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMontoCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMontoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMontoCaja.Location = New System.Drawing.Point(0, 0)
        Me.griMontoCaja.Name = "griMontoCaja"
        Me.griMontoCaja.Size = New System.Drawing.Size(1137, 250)
        Me.griMontoCaja.TabIndex = 2
        Me.griMontoCaja.Text = "Listado de Montos"
        '
        'mcMovimientosCaja
        '
        Me.mcMovimientosCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcMovimientosCaja.ForeColor = System.Drawing.Color.Black
        Me.mcMovimientosCaja.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcMovimientosCaja.Name = "mcMovimientosCaja"
        Me.mcMovimientosCaja.Size = New System.Drawing.Size(119, 92)
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'ogdCajaMonto
        '
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn4.DataType = GetType(Decimal)
        UltraDataColumn6.DataType = GetType(Boolean)
        Me.ogdCajaMonto.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.spcCuentaBancaria)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1137, 250)
        '
        'spcCuentaBancaria
        '
        Me.spcCuentaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCuentaBancaria.Location = New System.Drawing.Point(0, 0)
        Me.spcCuentaBancaria.Name = "spcCuentaBancaria"
        '
        'spcCuentaBancaria.Panel1
        '
        Me.spcCuentaBancaria.Panel1.Controls.Add(Me.agrRegistroMonto)
        '
        'spcCuentaBancaria.Panel2
        '
        Me.spcCuentaBancaria.Panel2.Controls.Add(Me.griListaCuentaBancaria)
        Me.spcCuentaBancaria.Panel2MinSize = 30
        Me.spcCuentaBancaria.Size = New System.Drawing.Size(1137, 250)
        Me.spcCuentaBancaria.SplitterDistance = 369
        Me.spcCuentaBancaria.TabIndex = 0
        '
        'agrRegistroMonto
        '
        Me.agrRegistroMonto.Controls.Add(Me.decSaldoCuenta)
        Me.agrRegistroMonto.Controls.Add(Me.UltraLabel1)
        Me.agrRegistroMonto.Controls.Add(Me.btnMostrarCuentaBancaria)
        Me.agrRegistroMonto.Controls.Add(Me.fecFecha)
        Me.agrRegistroMonto.Controls.Add(Me.UltraLabel3)
        Me.agrRegistroMonto.Controls.Add(Me.UltraLabel8)
        Me.agrRegistroMonto.Controls.Add(Me.cboCaja)
        Me.agrRegistroMonto.Controls.Add(Me.Etiqueta2)
        Me.agrRegistroMonto.Controls.Add(Me.Etiqueta6)
        Me.agrRegistroMonto.Controls.Add(Me.txtCuentaBancaria)
        Me.agrRegistroMonto.Controls.Add(Me.decMonto)
        Me.agrRegistroMonto.Controls.Add(Me.verActivoMonto)
        Me.agrRegistroMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrRegistroMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRegistroMonto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRegistroMonto.Location = New System.Drawing.Point(0, 0)
        Me.agrRegistroMonto.Name = "agrRegistroMonto"
        Me.agrRegistroMonto.Size = New System.Drawing.Size(369, 250)
        Me.agrRegistroMonto.TabIndex = 22
        Me.agrRegistroMonto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decSaldoCuenta
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldoCuenta.Appearance = Appearance1
        Me.decSaldoCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.decSaldoCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldoCuenta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldoCuenta.Location = New System.Drawing.Point(101, 78)
        Me.decSaldoCuenta.MaskInput = "{double:9.2}"
        Me.decSaldoCuenta.Name = "decSaldoCuenta"
        Me.decSaldoCuenta.NullText = "0.00"
        Me.decSaldoCuenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.decSaldoCuenta.ReadOnly = True
        Me.decSaldoCuenta.Size = New System.Drawing.Size(100, 21)
        Me.decSaldoCuenta.TabIndex = 23
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(25, 78)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel1.TabIndex = 22
        Me.UltraLabel1.Text = "Saldo Cuenta"
        '
        'btnMostrarCuentaBancaria
        '
        Me.btnMostrarCuentaBancaria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMostrarCuentaBancaria.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMostrarCuentaBancaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarCuentaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMostrarCuentaBancaria.Location = New System.Drawing.Point(349, 62)
        Me.btnMostrarCuentaBancaria.Name = "btnMostrarCuentaBancaria"
        Me.btnMostrarCuentaBancaria.Size = New System.Drawing.Size(15, 81)
        Me.btnMostrarCuentaBancaria.TabIndex = 20
        Me.btnMostrarCuentaBancaria.Text = "<>"
        '
        'fecFecha
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFecha.Appearance = Appearance3
        Me.fecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFecha.Location = New System.Drawing.Point(101, 55)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(100, 21)
        Me.fecFecha.TabIndex = 5
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(59, 105)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Monto:"
        '
        'UltraLabel8
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance5
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(59, 59)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel8.TabIndex = 4
        Me.UltraLabel8.Text = "Fecha:"
        '
        'cboCaja
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaja.Appearance = Appearance6
        Me.cboCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCaja.DisplayMember = "Nombre"
        Me.cboCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCaja.Location = New System.Drawing.Point(101, 9)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(250, 21)
        Me.cboCaja.TabIndex = 1
        Me.cboCaja.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(7, 36)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(92, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Cuenta Bancaria:"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(69, 13)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta6.TabIndex = 0
        Me.Etiqueta6.Text = "Caja:"
        '
        'txtCuentaBancaria
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuentaBancaria.Appearance = Appearance7
        Me.txtCuentaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(101, 32)
        Me.txtCuentaBancaria.MaxLength = 30
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.ReadOnly = True
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(250, 21)
        Me.txtCuentaBancaria.TabIndex = 3
        '
        'decMonto
        '
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMonto.Appearance = Appearance8
        Me.decMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.decMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMonto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decMonto.Location = New System.Drawing.Point(101, 101)
        Me.decMonto.MaskInput = "{double:9.2}"
        Me.decMonto.Name = "decMonto"
        Me.decMonto.NullText = "0.00"
        Me.decMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.decMonto.Size = New System.Drawing.Size(100, 21)
        Me.decMonto.TabIndex = 7
        '
        'verActivoMonto
        '
        Me.verActivoMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivoMonto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivoMonto.Location = New System.Drawing.Point(101, 127)
        Me.verActivoMonto.Name = "verActivoMonto"
        Me.verActivoMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivoMonto.Size = New System.Drawing.Size(57, 21)
        Me.verActivoMonto.TabIndex = 8
        Me.verActivoMonto.Text = "Activo"
        Me.verActivoMonto.Visible = False
        '
        'griListaCuentaBancaria
        '
        Me.griListaCuentaBancaria.DataSource = Me.ogdCuentaBancaria
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Banco"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.Caption = "Numero Cuenta"
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Moneda"
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn17.Header.Caption = "Saldo"
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Contacto Telefono"
        UltraGridColumn19.Header.VisiblePosition = 9
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.Caption = "Tasa Activa"
        UltraGridColumn20.Header.VisiblePosition = 10
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Tasa Pasiva"
        UltraGridColumn21.Header.VisiblePosition = 11
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Linea Credito"
        UltraGridColumn22.Header.VisiblePosition = 12
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 13
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 14
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn25.Header.Caption = "Select"
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Width = 42
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.griListaCuentaBancaria.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaCuentaBancaria.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCuentaBancaria.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaCuentaBancaria.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaCuentaBancaria.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaCuentaBancaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaCuentaBancaria.Location = New System.Drawing.Point(0, 0)
        Me.griListaCuentaBancaria.Name = "griListaCuentaBancaria"
        Me.griListaCuentaBancaria.Size = New System.Drawing.Size(764, 250)
        Me.griListaCuentaBancaria.TabIndex = 2
        Me.griListaCuentaBancaria.Text = "Información de Cuenta Bancaria"
        '
        'ogdCuentaBancaria
        '
        UltraDataColumn11.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn12.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn13.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn14.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn15.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn16.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn17.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn18.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn19.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn20.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn21.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn22.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn23.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn24.DataType = GetType(Boolean)
        UltraDataColumn24.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        Me.ogdCuentaBancaria.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        Me.ogdCuentaBancaria.Band.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ficMontoCaja)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1139, 273)
        '
        'ficMontoCaja
        '
        Me.ficMontoCaja.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficMontoCaja.Controls.Add(Me.UltraTabPageControl3)
        Me.ficMontoCaja.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMontoCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMontoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMontoCaja.Location = New System.Drawing.Point(0, 0)
        Me.ficMontoCaja.Name = "ficMontoCaja"
        Me.ficMontoCaja.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficMontoCaja.Size = New System.Drawing.Size(1139, 273)
        Me.ficMontoCaja.TabIndex = 0
        UltraTab9.TabPage = Me.UltraTabPageControl3
        UltraTab9.Text = "Lista"
        UltraTab10.TabPage = Me.UltraTabPageControl4
        UltraTab10.Text = "Registro"
        Me.ficMontoCaja.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10})
        Me.ficMontoCaja.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1137, 250)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1139, 273)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.griUsuarioCaja)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.griTrabajador)
        Me.SplitContainer1.Size = New System.Drawing.Size(1139, 273)
        Me.SplitContainer1.SplitterDistance = 465
        Me.SplitContainer1.TabIndex = 0
        '
        'griUsuarioCaja
        '
        Me.griUsuarioCaja.ContextMenuStrip = Me.menContextualUsuariosCaja
        Me.griUsuarioCaja.DataSource = Me.ogdUsuarioCaja
        UltraGridColumn26.Header.VisiblePosition = 0
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 1
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn28.Width = 81
        UltraGridColumn29.Header.VisiblePosition = 4
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.Width = 163
        UltraGridColumn31.Header.VisiblePosition = 5
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 6
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 8
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridColumn34.Width = 323
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        UltraGridBand3.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griUsuarioCaja.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griUsuarioCaja.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griUsuarioCaja.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griUsuarioCaja.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griUsuarioCaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griUsuarioCaja.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griUsuarioCaja.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griUsuarioCaja.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griUsuarioCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griUsuarioCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.85!)
        Me.griUsuarioCaja.Location = New System.Drawing.Point(0, 0)
        Me.griUsuarioCaja.Name = "griUsuarioCaja"
        Me.griUsuarioCaja.Size = New System.Drawing.Size(465, 273)
        Me.griUsuarioCaja.TabIndex = 4
        Me.griUsuarioCaja.Text = "Lista Trabajadores por Caja"
        '
        'menContextualUsuariosCaja
        '
        Me.menContextualUsuariosCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menContextualUsuariosCaja.ForeColor = System.Drawing.Color.Black
        Me.menContextualUsuariosCaja.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.menContextualUsuariosCaja.Name = "mcMovimientosCaja"
        Me.menContextualUsuariosCaja.Size = New System.Drawing.Size(103, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem4.Text = "Quitar"
        Me.ToolStripMenuItem4.ToolTipText = "Si necesita quitar el usuario... deselecciónelo de la lista ubicada a la derecha " & _
    ""
        '
        'ogdUsuarioCaja
        '
        UltraDataColumn31.DataType = GetType(Date)
        Me.ogdUsuarioCaja.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34})
        '
        'griTrabajador
        '
        Me.griTrabajador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTrabajador.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTrabajador.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTrabajador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTrabajador.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTrabajador.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.griTrabajador.Name = "griTrabajador"
        Me.griTrabajador.Size = New System.Drawing.Size(670, 273)
        Me.griTrabajador.TabIndex = 2
        Me.griTrabajador.Text = "Información de trabajadores"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalCaja)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1145, 478)
        '
        'agrTotalCaja
        '
        Me.agrTotalCaja.Controls.Add(Me.griListaCaja)
        Me.agrTotalCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalCaja.ForeColor = System.Drawing.Color.Black
        Me.agrTotalCaja.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalCaja.Name = "agrTotalCaja"
        Me.agrTotalCaja.Size = New System.Drawing.Size(1145, 478)
        Me.agrTotalCaja.TabIndex = 1
        Me.agrTotalCaja.Text = "Total de Cajas"
        Me.agrTotalCaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListaCaja
        '
        Me.griListaCaja.ContextMenuStrip = Me.MenuContextual1
        Me.griListaCaja.DataSource = Me.ogdCaja
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn35.Header.VisiblePosition = 0
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.VisiblePosition = 1
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn37.Header.VisiblePosition = 2
        UltraGridColumn37.Width = 266
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn38.Header.VisiblePosition = 3
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 4
        UltraGridColumn39.Hidden = True
        Appearance9.BackColor2 = System.Drawing.Color.White
        UltraGridColumn40.CellButtonAppearance = Appearance9
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn40.Header.VisiblePosition = 5
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        Me.griListaCaja.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaCaja.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaCaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaCaja.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaCaja.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griListaCaja.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaCaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaCaja.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griListaCaja.Location = New System.Drawing.Point(2, 18)
        Me.griListaCaja.Name = "griListaCaja"
        Me.griListaCaja.Size = New System.Drawing.Size(1141, 458)
        Me.griListaCaja.TabIndex = 1
        Me.griListaCaja.Text = "Listado de Cajas"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Caja"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar la Caja seleccionada"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar la Caja seleccionada"
        '
        'ogdCaja
        '
        UltraDataColumn39.DataType = GetType(Boolean)
        Me.ogdCaja.Band.Columns.AddRange(New Object() {UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrMovimiento)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralDemanda)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1145, 478)
        '
        'agrMovimiento
        '
        Me.agrMovimiento.Controls.Add(Me.ficMovimiento)
        Me.agrMovimiento.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.agrMovimiento.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.agrMovimiento.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.agrMovimiento.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.agrMovimiento.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.agrMovimiento.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.agrMovimiento.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.agrMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMovimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMovimiento.Location = New System.Drawing.Point(0, 152)
        Me.agrMovimiento.Name = "agrMovimiento"
        Me.agrMovimiento.Size = New System.Drawing.Size(1145, 326)
        Me.agrMovimiento.TabIndex = 2
        Me.agrMovimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ficMovimiento
        '
        Me.ficMovimiento.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficMovimiento.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMovimiento.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMovimiento.Location = New System.Drawing.Point(2, 28)
        Me.ficMovimiento.Name = "ficMovimiento"
        Me.ficMovimiento.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficMovimiento.Size = New System.Drawing.Size(1141, 296)
        Me.ficMovimiento.TabIndex = 21
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Montos"
        UltraTab3.Visible = False
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Usuarios"
        Me.ficMovimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficMovimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1139, 273)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1141, 26)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ToolbarsManager = Me.MenuMovimiento
        '
        'MenuMovimiento
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MenuMovimiento.Appearance = Appearance10
        Me.MenuMovimiento.DesignerFlags = 1
        Me.MenuMovimiento.DockWithinContainer = Me
        Me.MenuMovimiento.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuMovimiento.MdiMergeable = False
        Me.MenuMovimiento.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.MenuMovimiento.Office2007UICompatibility = False
        Me.MenuMovimiento.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(418, 177)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(447, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool7, ButtonTool8, ButtonTool11, ButtonTool13, ButtonTool14})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuMovimiento.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance11.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool20.SharedPropsInternal.AppearancesSmall.Appearance = Appearance11
        ButtonTool20.SharedPropsInternal.Caption = "Guardar"
        ButtonTool20.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool21.SharedPropsInternal.AppearancesSmall.Appearance = Appearance12
        ButtonTool21.SharedPropsInternal.Caption = "Modificar"
        ButtonTool21.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance13
        ButtonTool22.SharedPropsInternal.Caption = "Quitar"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance14
        ButtonTool23.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance15
        ButtonTool24.SharedPropsInternal.Caption = "Agregar"
        ButtonTool24.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool24.SharedPropsInternal.Visible = False
        ButtonTool25.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool26.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool27.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance16.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool28.SharedPropsInternal.AppearancesSmall.Appearance = Appearance16
        ButtonTool28.SharedPropsInternal.Caption = "Consultar"
        ButtonTool28.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool28.SharedPropsInternal.Visible = False
        Me.MenuMovimiento.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool20, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28})
        Me.MenuMovimiento.Visible = False
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(2, 324)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1141, 0)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.MenuMovimiento
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(0, 322)
        Me.UltraToolbarsDockArea2.ToolbarsManager = Me.MenuMovimiento
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(1143, 2)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 322)
        Me.UltraToolbarsDockArea3.ToolbarsManager = Me.MenuMovimiento
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(2, 324)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1141, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 322)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1143, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 322)
        '
        'Gb_DatoGeneralDemanda
        '
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.cboCentro)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtCodigo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.verActivo)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel5)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtAbreviatura)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.txtNombre)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel2)
        Me.Gb_DatoGeneralDemanda.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralDemanda.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralDemanda.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralDemanda.Name = "Gb_DatoGeneralDemanda"
        Me.Gb_DatoGeneralDemanda.Size = New System.Drawing.Size(1145, 152)
        Me.Gb_DatoGeneralDemanda.TabIndex = 0
        Me.Gb_DatoGeneralDemanda.Text = "Datos"
        Me.Gb_DatoGeneralDemanda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboCentro
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentro.Appearance = Appearance17
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentro.Location = New System.Drawing.Point(96, 99)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(144, 21)
        Me.cboCentro.TabIndex = 100
        Me.cboCentro.ValueMember = "Id"
        '
        'txtCodigo
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance18
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(96, 25)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'verActivo
        '
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(96, 122)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.verActivo.Size = New System.Drawing.Size(57, 20)
        Me.verActivo.TabIndex = 9
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'UltraLabel5
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance19
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(25, 75)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel5.TabIndex = 5
        Me.UltraLabel5.Text = "Abreviatura:"
        '
        'txtAbreviatura
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Appearance = Appearance20
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAbreviatura.Location = New System.Drawing.Point(96, 75)
        Me.txtAbreviatura.MaxLength = 5
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(90, 21)
        Me.txtAbreviatura.TabIndex = 6
        '
        'txtNombre
        '
        Appearance21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance21
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(96, 50)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 21)
        Me.txtNombre.TabIndex = 4
        '
        'UltraLabel22
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance22
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(42, 52)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 3
        Me.UltraLabel22.Text = "Nombre:"
        '
        'UltraLabel2
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance23
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(47, 99)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Centro:"
        '
        'UltraLabel4
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance24
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(47, 29)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 1
        Me.UltraLabel4.Text = "Código:"
        '
        'ordTrabajador
        '
        UltraDataColumn49.DataType = GetType(Date)
        UltraDataColumn51.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Date)
        UltraDataColumn53.DataType = GetType(Boolean)
        Me.ordTrabajador.Band.Columns.AddRange(New Object() {UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53})
        '
        'tcCaja
        '
        Me.tcCaja.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcCaja.Controls.Add(Me.UltraTabPageControl7)
        Me.tcCaja.Controls.Add(Me.utpDetalle)
        Me.tcCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCaja.Location = New System.Drawing.Point(0, 0)
        Me.tcCaja.Name = "tcCaja"
        Me.tcCaja.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcCaja.Size = New System.Drawing.Size(1147, 501)
        Me.tcCaja.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcCaja.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcCaja.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1145, 478)
        '
        'frm_MenuPadre_Fill_Panel
        '
        Me.frm_MenuPadre_Fill_Panel.Controls.Add(Me.tcCaja)
        Me.frm_MenuPadre_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.frm_MenuPadre_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_MenuPadre_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.frm_MenuPadre_Fill_Panel.Name = "frm_MenuPadre_Fill_Panel"
        Me.frm_MenuPadre_Fill_Panel.Size = New System.Drawing.Size(1147, 501)
        Me.frm_MenuPadre_Fill_Panel.TabIndex = 15
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje del sistema"
        '
        'frm_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 501)
        Me.ContextMenuStrip = Me.MenuContextual1
        Me.Controls.Add(Me.frm_MenuPadre_Fill_Panel)
        Me.Name = "frm_Caja"
        Me.Text = "Caja"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griMontoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcMovimientosCaja.ResumeLayout(False)
        CType(Me.ogdCajaMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.spcCuentaBancaria.Panel1.ResumeLayout(False)
        Me.spcCuentaBancaria.Panel2.ResumeLayout(False)
        CType(Me.spcCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCuentaBancaria.ResumeLayout(False)
        CType(Me.agrRegistroMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRegistroMonto.ResumeLayout(False)
        Me.agrRegistroMonto.PerformLayout()
        CType(Me.decSaldoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivoMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griListaCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ficMontoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMontoCaja.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.griUsuarioCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menContextualUsuariosCaja.ResumeLayout(False)
        CType(Me.ogdUsuarioCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalCaja.ResumeLayout(False)
        CType(Me.griListaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ogdCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMovimiento.ResumeLayout(False)
        CType(Me.ficMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMovimiento.ResumeLayout(False)
        CType(Me.MenuMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralDemanda.ResumeLayout(False)
        Me.Gb_DatoGeneralDemanda.PerformLayout()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreviatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCaja.ResumeLayout(False)
        Me.frm_MenuPadre_Fill_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcCaja As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalCaja As ISL.Controles.Agrupacion
    Friend WithEvents griListaCaja As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Gb_DatoGeneralDemanda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtAbreviatura As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdCaja As ISL.Controles.OrigenDatos
    Friend WithEvents frm_MenuPadre_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents ogdCajaMonto As ISL.Controles.OrigenDatos
    Friend WithEvents MenuMovimiento As ISL.Controles.Menu
    Friend WithEvents ogdCuentaBancaria As ISL.Controles.OrigenDatos
    Friend WithEvents ogdUsuarioCaja As ISL.Controles.OrigenDatos
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcMovimientosCaja As ISL.Controles.MenuContextual
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ordTrabajador As ISL.Controles.OrigenDatos
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents agrMovimiento As ISL.Controles.Agrupacion
    Friend WithEvents ficMovimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficMontoCaja As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMontoCaja As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents spcCuentaBancaria As System.Windows.Forms.SplitContainer
    Friend WithEvents agrRegistroMonto As ISL.Controles.Agrupacion
    Friend WithEvents decSaldoCuenta As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnMostrarCuentaBancaria As ISL.Controles.Boton
    Friend WithEvents fecFecha As ISL.Controles.Fecha
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCaja As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtCuentaBancaria As ISL.Controles.Texto
    Friend WithEvents decMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents verActivoMonto As ISL.Controles.Chequear
    Friend WithEvents griListaCuentaBancaria As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents griUsuarioCaja As ISL.Controles.Grilla
    Friend WithEvents griTrabajador As ISL.Controles.Grilla
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents menContextualUsuariosCaja As ISL.Controles.MenuContextual
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
End Class
