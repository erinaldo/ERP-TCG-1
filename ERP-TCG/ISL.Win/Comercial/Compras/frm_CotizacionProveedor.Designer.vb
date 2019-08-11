<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CotizacionProveedor
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
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoProveedor")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAprobado")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoProveedor")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCotizacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAprobado")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPersonaEmpresa")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActividad")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocumento")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CotizacionProveedor))
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAtencion")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaterialServicio")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoRequerimiento")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoRequerimiento")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaAtencion")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioAtencion")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OpcionFecha")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAtencion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MaterialServicio")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoRequerimiento")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoRequerimiento")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaAtencion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioAtencion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OpcionFecha")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinal")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMaterial")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMaterial")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Familia")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubFamilia")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUnidadMedida")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medida")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serial")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfectoIgv")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Peso")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombre")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBarras")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacen")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDivisible")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMaterial")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMaterial")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Familia")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubFamilia")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoUnidadMedida")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medida")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serial")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AfectoIgv")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Peso")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombre")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBarras")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacen")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDivisible")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaServicio")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CategoriaServicio")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacion")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCotizacion")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMat")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoCotizacion")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCotizacion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCotizacion")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoMaterial")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PosMat")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoCotizacion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacion")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoServicio")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoServicio")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacionProveedor")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCotizacion")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoServicio")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRequerimientoServicio")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCotizacionProveedor")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndMaterialServicio")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndMaterialServicio")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListadoProveedoresCotizar = New ISL.Controles.Grilla(Me.components)
        Me.odCotizacionProveedor = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion10 = New ISL.Controles.Agrupacion(Me.components)
        Me.griListadoProveedor = New ISL.Controles.Grilla(Me.components)
        Me.ordProveedor = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuCotizacionProveedor = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaRequerimiento = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRequerimientos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListarMaterialesReq = New ISL.Controles.Boton(Me.components)
        Me.dtpReqHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpReqDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaMateriales = New ISL.Controles.Grilla(Me.components)
        Me.odMaterial = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.txtBuscarMateriales = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaServicio = New ISL.Controles.Grilla(Me.components)
        Me.odServicio = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCategoria = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCategoriaServicios = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListadoCotizacionDetalle = New ISL.Controles.Grilla(Me.components)
        Me.odCotizacionDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCotizacionDetalleSer = New ISL.Controles.Grilla(Me.components)
        Me.odCotizacionDetalleSer = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrRequerimientos = New ISL.Controles.Agrupacion(Me.components)
        Me.griCotizacion = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual2 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odCotizaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresAtendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ColoresEvaluado = New ISL.Controles.Colores(Me.components)
        Me.cboRequerimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.dtpFechaCotHasta = New System.Windows.Forms.DateTimePicker()
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFechaCotDesde = New System.Windows.Forms.DateTimePicker()
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficDetalles = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ficCotizacionDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.numTotalCotizacion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtEquipo = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.Boton1 = New ISL.Controles.Boton(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficCotizacionProveedor = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.griListadoProveedoresCotizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCotizacionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion10.SuspendLayout()
        CType(Me.griListadoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuCotizacionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griListaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.griCotizacionDetalleSer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCotizacionDetalleSer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRequerimientos.SuspendLayout()
        CType(Me.griCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual2.SuspendLayout()
        CType(Me.odCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ficDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalles.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.ficCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCotizacionDetalle.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.numTotalCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficCotizacionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCotizacionProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1094, 203)
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.Agrupacion11)
        Me.Agrupacion9.Controls.Add(Me.Agrupacion10)
        Me.Agrupacion9.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion9.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.Agrupacion9.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.Agrupacion9.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1094, 203)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.griListadoProveedoresCotizar)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(3, 29)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(586, 171)
        Me.Agrupacion11.TabIndex = 0
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListadoProveedoresCotizar
        '
        Me.griListadoProveedoresCotizar.DataSource = Me.odCotizacionProveedor
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.Width = 220
        UltraGridColumn20.Header.VisiblePosition = 5
        Appearance1.BackColor = System.Drawing.Color.LemonChiffon
        UltraGridColumn21.CellAppearance = Appearance1
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Width = 186
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn48.Header.Appearance = Appearance2
        UltraGridColumn48.Header.VisiblePosition = 9
        UltraGridColumn48.Hidden = True
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn49.Header.Appearance = Appearance3
        UltraGridColumn49.Header.VisiblePosition = 10
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn50.Header.Appearance = Appearance4
        UltraGridColumn50.Header.Caption = "Fecha"
        UltraGridColumn50.Header.VisiblePosition = 6
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.MaskInput = "{LOC}dd/mm/yyyy hh:mm:ss tt"
        UltraGridColumn50.Width = 168
        UltraGridColumn51.Header.VisiblePosition = 7
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 8
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn53.Header.VisiblePosition = 1
        UltraGridColumn54.Header.VisiblePosition = 11
        UltraGridColumn54.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54})
        Me.griListadoProveedoresCotizar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListadoProveedoresCotizar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.griListadoProveedoresCotizar.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoProveedoresCotizar.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.griListadoProveedoresCotizar.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListadoProveedoresCotizar.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoProveedoresCotizar.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.griListadoProveedoresCotizar.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoProveedoresCotizar.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.CellAppearance = Appearance8
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.CellPadding = 0
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.RowAppearance = Appearance11
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoProveedoresCotizar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoProveedoresCotizar.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListadoProveedoresCotizar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoProveedoresCotizar.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListadoProveedoresCotizar.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListadoProveedoresCotizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoProveedoresCotizar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoProveedoresCotizar.Location = New System.Drawing.Point(3, 3)
        Me.griListadoProveedoresCotizar.Name = "griListadoProveedoresCotizar"
        Me.griListadoProveedoresCotizar.Size = New System.Drawing.Size(580, 165)
        Me.griListadoProveedoresCotizar.TabIndex = 0
        Me.griListadoProveedoresCotizar.Text = "Grilla1"
        '
        'odCotizacionProveedor
        '
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Boolean)
        Me.odCotizacionProveedor.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'Agrupacion10
        '
        Me.Agrupacion10.Controls.Add(Me.griListadoProveedor)
        Me.Agrupacion10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Agrupacion10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion10.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion10.Location = New System.Drawing.Point(589, 29)
        Me.Agrupacion10.Name = "Agrupacion10"
        Me.Agrupacion10.Size = New System.Drawing.Size(502, 171)
        Me.Agrupacion10.TabIndex = 1
        Me.Agrupacion10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griListadoProveedor
        '
        Me.griListadoProveedor.DataSource = Me.ordProveedor
        UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn55.Header.VisiblePosition = 0
        UltraGridColumn55.Width = 46
        UltraGridColumn56.Header.VisiblePosition = 1
        UltraGridColumn56.Hidden = True
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn57.Header.Appearance = Appearance12
        UltraGridColumn57.Header.VisiblePosition = 2
        UltraGridColumn57.Width = 73
        UltraGridColumn58.Header.VisiblePosition = 3
        UltraGridColumn58.Width = 180
        UltraGridColumn59.Header.VisiblePosition = 4
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 5
        UltraGridColumn60.Width = 161
        UltraGridColumn61.Header.VisiblePosition = 6
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 7
        UltraGridColumn62.Hidden = True
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn63.Header.Appearance = Appearance13
        UltraGridColumn63.Header.VisiblePosition = 11
        UltraGridColumn63.Hidden = True
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn64.Header.Appearance = Appearance14
        UltraGridColumn64.Header.VisiblePosition = 12
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 8
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 9
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 10
        UltraGridColumn67.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67})
        Me.griListadoProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListadoProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.griListadoProveedor.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.griListadoProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListadoProveedor.DisplayLayout.GroupByBox.Hidden = True
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoProveedor.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.griListadoProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoProveedor.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListadoProveedor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoProveedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListadoProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.griListadoProveedor.DisplayLayout.Override.CellAppearance = Appearance18
        Me.griListadoProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoProveedor.DisplayLayout.Override.CellPadding = 0
        Me.griListadoProveedor.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoProveedor.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListadoProveedor.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListadoProveedor.DisplayLayout.Override.GroupByRowAppearance = Appearance19
        Appearance20.TextHAlignAsString = "Left"
        Me.griListadoProveedor.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.griListadoProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Me.griListadoProveedor.DisplayLayout.Override.RowAppearance = Appearance21
        Me.griListadoProveedor.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoProveedor.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoProveedor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListadoProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoProveedor.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListadoProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListadoProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoProveedor.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoProveedor.Location = New System.Drawing.Point(2, 2)
        Me.griListadoProveedor.Name = "griListadoProveedor"
        Me.griListadoProveedor.Size = New System.Drawing.Size(498, 167)
        Me.griListadoProveedor.TabIndex = 0
        Me.griListadoProveedor.Text = "Grilla1"
        '
        'ordProveedor
        '
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn22.DataType = GetType(Boolean)
        Me.ordProveedor.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1088, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'mnuCotizacionProveedor
        '
        Appearance22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnuCotizacionProveedor.Appearance = Appearance22
        Me.mnuCotizacionProveedor.DesignerFlags = 1
        Me.mnuCotizacionProveedor.DockWithinContainer = Me
        Me.mnuCotizacionProveedor.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.mnuCotizacionProveedor.MdiMergeable = False
        Me.mnuCotizacionProveedor.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.mnuCotizacionProveedor.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(252, 298)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(447, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool19})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnuCotizacionProveedor.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance140.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance140
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance141.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance141
        ButtonTool7.SharedPropsInternal.Caption = "Editar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance142.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool8.SharedPropsInternal.AppearancesSmall.Appearance = Appearance142
        ButtonTool8.SharedPropsInternal.Caption = "Eliminar"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance143.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance143
        ButtonTool9.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance144.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance144
        ButtonTool10.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool11.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool12.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool13.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance145.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool14.SharedPropsInternal.AppearancesSmall.Appearance = Appearance145
        ButtonTool14.SharedPropsInternal.Caption = "Consultar"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance146.Image = CType(resources.GetObject("Appearance146.Image"), Object)
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance146
        ButtonTool15.SharedPropsInternal.Caption = "Exportar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance147.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance147
        ButtonTool17.SharedPropsInternal.Caption = "Modificar"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance148.Image = Global.ISL.Win.My.Resources.Resources.Excel
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance148
        ButtonTool5.SharedPropsInternal.Caption = "Importar"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuCotizacionProveedor.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool17, ButtonTool5})
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(3, 200)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1088, 0)
        Me.UltraToolbarsDockArea2.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(3, 3)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 197)
        Me.UltraToolbarsDockArea3.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1091, 3)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 197)
        Me.UltraToolbarsDockArea4.ToolbarsManager = Me.mnuCotizacionProveedor
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaRequerimiento)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1094, 203)
        '
        'griListaRequerimiento
        '
        Me.griListaRequerimiento.ContextMenuStrip = Me.MenuContextual1
        Me.griListaRequerimiento.DataSource = Me.odRequerimientos
        Appearance43.TextHAlignAsString = "Center"
        UltraGridColumn81.Header.Appearance = Appearance43
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.Hidden = True
        Appearance44.TextHAlignAsString = "Center"
        UltraGridColumn82.Header.Appearance = Appearance44
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridColumn82.Width = 97
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance45.TextHAlignAsString = "Center"
        UltraGridColumn83.Header.Appearance = Appearance45
        UltraGridColumn83.Header.Caption = "Fecha de atención"
        UltraGridColumn83.Header.VisiblePosition = 20
        UltraGridColumn83.Hidden = True
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn84.Header.Appearance = Appearance46
        UltraGridColumn84.Header.Caption = "Tipo requerimiento"
        UltraGridColumn84.Header.VisiblePosition = 2
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.Width = 312
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn85.Header.Appearance = Appearance47
        UltraGridColumn85.Header.VisiblePosition = 3
        UltraGridColumn85.Hidden = True
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn86.Header.Appearance = Appearance48
        UltraGridColumn86.Header.Caption = "Estado"
        UltraGridColumn86.Header.VisiblePosition = 6
        UltraGridColumn86.Width = 124
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn87.Header.Appearance = Appearance49
        UltraGridColumn87.Header.Caption = "Descripción"
        UltraGridColumn87.Header.VisiblePosition = 7
        UltraGridColumn87.Width = 227
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn88.Header.Appearance = Appearance50
        UltraGridColumn88.Header.VisiblePosition = 8
        UltraGridColumn88.Hidden = True
        Appearance51.TextHAlignAsString = "Center"
        UltraGridColumn89.Header.Appearance = Appearance51
        UltraGridColumn89.Header.VisiblePosition = 12
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.Width = 108
        Appearance52.TextHAlignAsString = "Center"
        UltraGridColumn90.Header.Appearance = Appearance52
        UltraGridColumn90.Header.VisiblePosition = 10
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Width = 123
        Appearance53.TextHAlignAsString = "Center"
        UltraGridColumn91.Header.Appearance = Appearance53
        UltraGridColumn91.Header.Caption = "Equipo"
        UltraGridColumn91.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        UltraGridColumn91.Header.VisiblePosition = 4
        UltraGridColumn91.Width = 102
        Appearance54.TextHAlignAsString = "Center"
        UltraGridColumn92.Header.Appearance = Appearance54
        UltraGridColumn92.Header.Caption = "Glosa atención"
        UltraGridColumn92.Header.VisiblePosition = 13
        UltraGridColumn92.Hidden = True
        UltraGridColumn92.Width = 156
        Appearance55.TextHAlignAsString = "Center"
        UltraGridColumn93.Header.Appearance = Appearance55
        UltraGridColumn93.Header.Caption = "Atendido Por"
        UltraGridColumn93.Header.VisiblePosition = 14
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.Width = 161
        Appearance56.TextHAlignAsString = "Center"
        UltraGridColumn94.Header.Appearance = Appearance56
        UltraGridColumn94.Header.VisiblePosition = 15
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance57.TextHAlignAsString = "Center"
        UltraGridColumn95.Header.Appearance = Appearance57
        UltraGridColumn95.Header.Caption = "Fecha"
        UltraGridColumn95.Header.VisiblePosition = 5
        UltraGridColumn95.MaskInput = "{LOC}dd/mm/yyyy hh:mm:ss tt"
        UltraGridColumn95.Width = 168
        Appearance58.TextHAlignAsString = "Center"
        UltraGridColumn96.Header.Appearance = Appearance58
        UltraGridColumn96.Header.VisiblePosition = 16
        UltraGridColumn96.Hidden = True
        Appearance59.TextHAlignAsString = "Center"
        UltraGridColumn97.Header.Appearance = Appearance59
        UltraGridColumn97.Header.VisiblePosition = 17
        UltraGridColumn97.Hidden = True
        Appearance60.TextHAlignAsString = "Center"
        UltraGridColumn98.Header.Appearance = Appearance60
        UltraGridColumn98.Header.VisiblePosition = 18
        UltraGridColumn98.Hidden = True
        Appearance61.TextHAlignAsString = "Center"
        UltraGridColumn99.Header.Appearance = Appearance61
        UltraGridColumn99.Header.VisiblePosition = 19
        UltraGridColumn99.Hidden = True
        Appearance62.TextHAlignAsString = "Center"
        UltraGridColumn100.Header.Appearance = Appearance62
        UltraGridColumn100.Header.VisiblePosition = 11
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 201
        UltraGridColumn101.Header.VisiblePosition = 21
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 22
        UltraGridColumn102.Hidden = True
        Appearance63.TextHAlignAsString = "Center"
        UltraGridColumn103.Header.Appearance = Appearance63
        UltraGridColumn103.Header.Caption = "Tipo Referencia"
        UltraGridColumn103.Header.VisiblePosition = 9
        UltraGridColumn103.Hidden = True
        UltraGridColumn103.Width = 128
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103})
        Me.griListaRequerimiento.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaRequerimiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance64.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance64.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaRequerimiento.DisplayLayout.GroupByBox.Appearance = Appearance64
        Appearance65.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaRequerimiento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance65
        Me.griListaRequerimiento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaRequerimiento.DisplayLayout.GroupByBox.Hidden = True
        Appearance66.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance66.BackColor2 = System.Drawing.SystemColors.Control
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance66.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaRequerimiento.DisplayLayout.GroupByBox.PromptAppearance = Appearance66
        Me.griListaRequerimiento.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaRequerimiento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaRequerimiento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimiento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRequerimiento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaRequerimiento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance67.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimiento.DisplayLayout.Override.CellAppearance = Appearance67
        Me.griListaRequerimiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaRequerimiento.DisplayLayout.Override.CellPadding = 0
        Me.griListaRequerimiento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaRequerimiento.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaRequerimiento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaRequerimiento.DisplayLayout.Override.GroupByRowAppearance = Appearance68
        Appearance69.TextHAlignAsString = "Left"
        Me.griListaRequerimiento.DisplayLayout.Override.HeaderAppearance = Appearance69
        Me.griListaRequerimiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance70.BorderColor = System.Drawing.Color.Silver
        Me.griListaRequerimiento.DisplayLayout.Override.RowAppearance = Appearance70
        Me.griListaRequerimiento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaRequerimiento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaRequerimiento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaRequerimiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaRequerimiento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaRequerimiento.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaRequerimiento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaRequerimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaRequerimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaRequerimiento.Location = New System.Drawing.Point(0, 35)
        Me.griListaRequerimiento.Name = "griListaRequerimiento"
        Me.griListaRequerimiento.Size = New System.Drawing.Size(1094, 168)
        Me.griListaRequerimiento.TabIndex = 1
        Me.griListaRequerimiento.Text = "Grilla1"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(105, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EliminarToolStripMenuItem.Text = "Quitar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'odRequerimientos
        '
        UltraDataColumn44.DataType = GetType(Date)
        UltraDataColumn44.ReadOnly = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn56.DataType = GetType(Date)
        UltraDataColumn57.DataType = GetType(Boolean)
        UltraDataColumn57.DefaultValue = False
        Me.odRequerimientos.Band.Columns.AddRange(New Object() {UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64})
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.btnListarMaterialesReq)
        Me.Agrupacion5.Controls.Add(Me.dtpReqHasta)
        Me.Agrupacion5.Controls.Add(Me.dtpReqDesde)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1094, 35)
        Me.Agrupacion5.TabIndex = 0
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListarMaterialesReq
        '
        Appearance71.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMaterialesReq.Appearance = Appearance71
        Me.btnListarMaterialesReq.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMaterialesReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMaterialesReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMaterialesReq.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMaterialesReq.Location = New System.Drawing.Point(317, 7)
        Me.btnListarMaterialesReq.Name = "btnListarMaterialesReq"
        Me.btnListarMaterialesReq.Size = New System.Drawing.Size(30, 22)
        Me.btnListarMaterialesReq.TabIndex = 4
        '
        'dtpReqHasta
        '
        Me.dtpReqHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReqHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReqHasta.Location = New System.Drawing.Point(206, 9)
        Me.dtpReqHasta.Name = "dtpReqHasta"
        Me.dtpReqHasta.Size = New System.Drawing.Size(105, 20)
        Me.dtpReqHasta.TabIndex = 3
        '
        'dtpReqDesde
        '
        Me.dtpReqDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReqDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReqDesde.Location = New System.Drawing.Point(56, 9)
        Me.dtpReqDesde.Name = "dtpReqDesde"
        Me.dtpReqDesde.Size = New System.Drawing.Size(103, 20)
        Me.dtpReqDesde.TabIndex = 1
        '
        'Etiqueta3
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance72
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(165, 11)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Hasta:"
        '
        'Etiqueta4
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance73
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(12, 12)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Desde:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griListaMateriales)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1094, 203)
        '
        'griListaMateriales
        '
        Me.griListaMateriales.DataSource = Me.odMaterial
        UltraGridColumn104.Header.VisiblePosition = 0
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 1
        UltraGridColumn105.Hidden = True
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn106.Header.Appearance = Appearance74
        UltraGridColumn106.Header.VisiblePosition = 2
        UltraGridColumn106.Width = 97
        UltraGridColumn107.Header.VisiblePosition = 3
        UltraGridColumn107.Width = 325
        UltraGridColumn108.Header.VisiblePosition = 4
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 5
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 6
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.Width = 214
        UltraGridColumn111.Header.VisiblePosition = 7
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 8
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 9
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 10
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 11
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 12
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 13
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 14
        UltraGridColumn118.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 15
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 16
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 18
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 19
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 20
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 21
        UltraGridColumn8.Hidden = True
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn9.Header.Appearance = Appearance75
        UltraGridColumn9.Header.VisiblePosition = 17
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 22
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 23
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 24
        UltraGridColumn12.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 25
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 26
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 27
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 28
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 29
        UltraGridColumn133.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133})
        Me.griListaMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griListaMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance76.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance76.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance76.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaMateriales.DisplayLayout.GroupByBox.Appearance = Appearance76
        Appearance77.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance77
        Me.griListaMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaMateriales.DisplayLayout.GroupByBox.Hidden = True
        Appearance78.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance78.BackColor2 = System.Drawing.SystemColors.Control
        Appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance78.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaMateriales.DisplayLayout.GroupByBox.PromptAppearance = Appearance78
        Me.griListaMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaMateriales.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaMateriales.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListaMateriales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance79.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.CellAppearance = Appearance79
        Me.griListaMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaMateriales.DisplayLayout.Override.CellPadding = 0
        Me.griListaMateriales.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaMateriales.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaMateriales.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListaMateriales.DisplayLayout.Override.GroupByRowAppearance = Appearance80
        Appearance81.TextHAlignAsString = "Left"
        Me.griListaMateriales.DisplayLayout.Override.HeaderAppearance = Appearance81
        Me.griListaMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance82.BorderColor = System.Drawing.Color.Silver
        Me.griListaMateriales.DisplayLayout.Override.RowAppearance = Appearance82
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaMateriales.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaMateriales.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListaMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaMateriales.Location = New System.Drawing.Point(0, 35)
        Me.griListaMateriales.Name = "griListaMateriales"
        Me.griListaMateriales.Size = New System.Drawing.Size(1094, 168)
        Me.griListaMateriales.TabIndex = 1
        Me.griListaMateriales.Text = "Grilla1"
        '
        'odMaterial
        '
        UltraDataColumn65.DataType = GetType(Boolean)
        UltraDataColumn84.DefaultValue = "False"
        UltraDataColumn86.DataType = GetType(Boolean)
        Me.odMaterial.Band.Columns.AddRange(New Object() {UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94})
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion6.Controls.Add(Me.cboAlmacen)
        Me.Agrupacion6.Controls.Add(Me.cboCentro)
        Me.Agrupacion6.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion6.Controls.Add(Me.txtBuscarMateriales)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1094, 35)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta6
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance83
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(370, 11)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta6.TabIndex = 3
        Me.Etiqueta6.Text = "Centro"
        Me.Etiqueta6.Visible = False
        '
        'Etiqueta13
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance84
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(524, 11)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta13.TabIndex = 5
        Me.Etiqueta13.Text = "Almacen"
        Me.Etiqueta13.Visible = False
        '
        'cboAlmacen
        '
        Appearance85.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance85
        Me.cboAlmacen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownListWidth = 280
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(577, 7)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(275, 21)
        Me.cboAlmacen.TabIndex = 6
        Me.cboAlmacen.ValueMember = "Id"
        Me.cboAlmacen.Visible = False
        '
        'cboCentro
        '
        Appearance86.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance86
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownListWidth = 180
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(415, 7)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(94, 21)
        Me.cboCentro.TabIndex = 4
        Me.cboCentro.ValueMember = "Id"
        Me.cboCentro.Visible = False
        '
        'btnListarMateriales
        '
        Appearance87.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMateriales.Appearance = Appearance87
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.Location = New System.Drawing.Point(327, 7)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(26, 22)
        Me.btnListarMateriales.TabIndex = 2
        '
        'txtBuscarMateriales
        '
        Me.txtBuscarMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBuscarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMateriales.Location = New System.Drawing.Point(63, 7)
        Me.txtBuscarMateriales.Name = "txtBuscarMateriales"
        Me.txtBuscarMateriales.Size = New System.Drawing.Size(258, 21)
        Me.txtBuscarMateriales.TabIndex = 1
        '
        'Etiqueta5
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance88
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(11, 11)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Material:"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griListaServicio)
        Me.UltraTabPageControl6.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1094, 203)
        '
        'griListaServicio
        '
        Me.griListaServicio.DataSource = Me.odServicio
        UltraGridColumn119.Header.VisiblePosition = 0
        UltraGridColumn119.Hidden = True
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn120.Header.Appearance = Appearance89
        UltraGridColumn120.Header.VisiblePosition = 2
        UltraGridColumn120.Width = 83
        UltraGridColumn121.Header.VisiblePosition = 3
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.Caption = "Categoria"
        UltraGridColumn122.Header.VisiblePosition = 5
        UltraGridColumn122.Hidden = True
        UltraGridColumn122.Width = 136
        UltraGridColumn123.Header.VisiblePosition = 4
        UltraGridColumn123.Width = 471
        UltraGridColumn124.Header.VisiblePosition = 6
        UltraGridColumn124.Hidden = True
        UltraGridColumn124.Width = 71
        UltraGridColumn125.Header.VisiblePosition = 7
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.Width = 117
        UltraGridColumn126.Header.VisiblePosition = 9
        UltraGridColumn126.Hidden = True
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn127.Header.Appearance = Appearance90
        UltraGridColumn127.Header.VisiblePosition = 8
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn128.Header.Caption = "Seleccionar"
        UltraGridColumn128.Header.VisiblePosition = 1
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.Width = 38
        UltraGridColumn14.Header.VisiblePosition = 10
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn14, UltraGridColumn15})
        Me.griListaServicio.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griListaServicio.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance91.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance91.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.GroupByBox.Appearance = Appearance91
        Appearance92.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServicio.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance92
        Me.griListaServicio.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.GroupByBox.Hidden = True
        Appearance93.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance93.BackColor2 = System.Drawing.SystemColors.Control
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance93.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaServicio.DisplayLayout.GroupByBox.PromptAppearance = Appearance93
        Me.griListaServicio.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaServicio.DisplayLayout.MaxRowScrollRegions = 1
        Appearance94.BackColor = System.Drawing.SystemColors.Window
        Appearance94.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griListaServicio.DisplayLayout.Override.ActiveCellAppearance = Appearance94
        Appearance95.BackColor = System.Drawing.SystemColors.Highlight
        Appearance95.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griListaServicio.DisplayLayout.Override.ActiveRowAppearance = Appearance95
        Me.griListaServicio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaServicio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaServicio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance96.BackColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.Override.CardAreaAppearance = Appearance96
        Appearance97.BorderColor = System.Drawing.Color.Silver
        Appearance97.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griListaServicio.DisplayLayout.Override.CellAppearance = Appearance97
        Me.griListaServicio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaServicio.DisplayLayout.Override.CellPadding = 0
        Me.griListaServicio.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaServicio.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaServicio.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance98.BackColor = System.Drawing.SystemColors.Control
        Appearance98.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance98.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance98.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaServicio.DisplayLayout.Override.GroupByRowAppearance = Appearance98
        Appearance99.TextHAlignAsString = "Left"
        Me.griListaServicio.DisplayLayout.Override.HeaderAppearance = Appearance99
        Me.griListaServicio.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaServicio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance100.BackColor = System.Drawing.SystemColors.Window
        Appearance100.BorderColor = System.Drawing.Color.Silver
        Me.griListaServicio.DisplayLayout.Override.RowAppearance = Appearance100
        Me.griListaServicio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaServicio.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaServicio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Appearance101.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griListaServicio.DisplayLayout.Override.TemplateAddRowAppearance = Appearance101
        Me.griListaServicio.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaServicio.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaServicio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaServicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaServicio.Location = New System.Drawing.Point(0, 62)
        Me.griListaServicio.Name = "griListaServicio"
        Me.griListaServicio.Size = New System.Drawing.Size(1094, 141)
        Me.griListaServicio.TabIndex = 1
        Me.griListaServicio.Text = "Grilla1"
        '
        'odServicio
        '
        UltraDataColumn103.DataType = GetType(Boolean)
        UltraDataColumn104.DataType = GetType(Boolean)
        UltraDataColumn104.DefaultValue = False
        Me.odServicio.Band.Columns.AddRange(New Object() {UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106})
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.btnCategoria)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion4.Controls.Add(Me.cboCategoriaServicios)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1094, 62)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Agregar servicios:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCategoria
        '
        Appearance102.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance102.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance102.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnCategoria.Appearance = Appearance102
        Me.btnCategoria.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCategoria.Location = New System.Drawing.Point(423, 21)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(30, 32)
        Me.btnCategoria.TabIndex = 2
        '
        'Etiqueta8
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance103
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(25, 31)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta8.TabIndex = 0
        Me.Etiqueta8.Text = "Categoria:"
        '
        'cboCategoriaServicios
        '
        Appearance104.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCategoriaServicios.Appearance = Appearance104
        Me.cboCategoriaServicios.DisplayMember = "Nombre"
        Me.cboCategoriaServicios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCategoriaServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoriaServicios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCategoriaServicios.Location = New System.Drawing.Point(86, 27)
        Me.cboCategoriaServicios.Name = "cboCategoriaServicios"
        Me.cboCategoriaServicios.Size = New System.Drawing.Size(332, 21)
        Me.cboCategoriaServicios.TabIndex = 1
        Me.cboCategoriaServicios.ValueMember = "Id"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griListadoCotizacionDetalle)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1094, 209)
        '
        'griListadoCotizacionDetalle
        '
        Me.griListadoCotizacionDetalle.ContextMenuStrip = Me.MenuContextual1
        Me.griListadoCotizacionDetalle.DataSource = Me.odCotizacionDetalle
        UltraGridColumn134.Header.VisiblePosition = 0
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 1
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 2
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn137.Header.VisiblePosition = 4
        UltraGridColumn137.Width = 389
        Appearance105.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance105.TextHAlignAsString = "Right"
        UltraGridColumn138.CellAppearance = Appearance105
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance106.TextHAlignAsString = "Right"
        UltraGridColumn138.Header.Appearance = Appearance106
        UltraGridColumn138.Header.VisiblePosition = 5
        UltraGridColumn138.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn138.Width = 67
        Appearance107.TextHAlignAsString = "Center"
        UltraGridColumn139.Header.Appearance = Appearance107
        UltraGridColumn139.Header.VisiblePosition = 16
        UltraGridColumn139.Hidden = True
        Appearance108.TextHAlignAsString = "Center"
        UltraGridColumn140.Header.Appearance = Appearance108
        UltraGridColumn140.Header.VisiblePosition = 14
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance109.TextHAlignAsString = "Center"
        UltraGridColumn141.Header.Appearance = Appearance109
        UltraGridColumn141.Header.Caption = "Fecha"
        UltraGridColumn141.Header.VisiblePosition = 6
        UltraGridColumn141.Hidden = True
        UltraGridColumn141.MaskInput = "{LOC}dd/mm/yyyy hh:mm:ss tt"
        UltraGridColumn141.Width = 168
        UltraGridColumn142.Header.VisiblePosition = 7
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 9
        UltraGridColumn143.Width = 99
        UltraGridColumn144.Header.VisiblePosition = 10
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 11
        UltraGridColumn145.Width = 192
        UltraGridColumn146.Header.VisiblePosition = 3
        UltraGridColumn162.Header.VisiblePosition = 12
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 13
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 15
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 17
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 18
        UltraGridColumn166.Hidden = True
        Appearance110.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance110.TextHAlignAsString = "Right"
        UltraGridColumn167.CellAppearance = Appearance110
        UltraGridColumn167.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn167.Format = "#,###,###,##0.0000"
        Appearance111.TextHAlignAsString = "Right"
        UltraGridColumn167.Header.Appearance = Appearance111
        UltraGridColumn167.Header.VisiblePosition = 8
        UltraGridColumn167.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn167.Width = 101
        UltraGridColumn168.Header.VisiblePosition = 19
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 20
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 21
        UltraGridColumn170.Hidden = True
        Appearance112.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn171.CellAppearance = Appearance112
        UltraGridColumn171.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn171.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn171.Header.VisiblePosition = 22
        UltraGridColumn171.Width = 283
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171})
        Me.griListadoCotizacionDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griListadoCotizacionDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance113.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance113.BorderColor = System.Drawing.SystemColors.Window
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.Appearance = Appearance113
        Appearance114.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance114
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.Hidden = True
        Appearance115.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance115.BackColor2 = System.Drawing.SystemColors.Control
        Appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance115.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance115
        Me.griListadoCotizacionDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoCotizacionDetalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance116.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellAppearance = Appearance116
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellPadding = 0
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.GroupByRowAppearance = Appearance117
        Appearance118.TextHAlignAsString = "Left"
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderAppearance = Appearance118
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance119.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowAppearance = Appearance119
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoCotizacionDetalle.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griListadoCotizacionDetalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListadoCotizacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoCotizacionDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoCotizacionDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griListadoCotizacionDetalle.Name = "griListadoCotizacionDetalle"
        Me.griListadoCotizacionDetalle.Size = New System.Drawing.Size(1094, 209)
        Me.griListadoCotizacionDetalle.TabIndex = 0
        Me.griListadoCotizacionDetalle.Text = "Grilla1"
        '
        'odCotizacionDetalle
        '
        UltraDataColumn109.DataType = GetType(Date)
        UltraDataColumn126.DataType = GetType(Boolean)
        UltraDataColumn126.DefaultValue = False
        Me.odCotizacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.griCotizacionDetalleSer)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1094, 209)
        '
        'griCotizacionDetalleSer
        '
        Me.griCotizacionDetalleSer.ContextMenuStrip = Me.MenuContextual1
        Me.griCotizacionDetalleSer.DataSource = Me.odCotizacionDetalleSer
        UltraGridColumn172.Header.VisiblePosition = 0
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 1
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 2
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn175.Header.VisiblePosition = 4
        UltraGridColumn175.Width = 389
        Appearance120.BackColor = System.Drawing.Color.White
        Appearance120.TextHAlignAsString = "Right"
        UltraGridColumn176.CellAppearance = Appearance120
        UltraGridColumn176.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance121.TextHAlignAsString = "Right"
        UltraGridColumn176.Header.Appearance = Appearance121
        UltraGridColumn176.Header.VisiblePosition = 5
        UltraGridColumn176.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn176.Width = 83
        Appearance122.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance122.TextHAlignAsString = "Right"
        UltraGridColumn177.CellAppearance = Appearance122
        UltraGridColumn177.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance123.TextHAlignAsString = "Right"
        UltraGridColumn177.Header.Appearance = Appearance123
        UltraGridColumn177.Header.VisiblePosition = 6
        UltraGridColumn177.MaskInput = "{double:9.4}"
        UltraGridColumn177.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn177.Width = 85
        UltraGridColumn178.Header.VisiblePosition = 7
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 8
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 9
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 3
        UltraGridColumn182.Header.VisiblePosition = 10
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 11
        UltraGridColumn183.Hidden = True
        Appearance124.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn184.CellAppearance = Appearance124
        UltraGridColumn184.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn184.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn184.Header.VisiblePosition = 12
        UltraGridColumn184.Width = 471
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184})
        Me.griCotizacionDetalleSer.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griCotizacionDetalleSer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance125.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance125.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance125.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance125.BorderColor = System.Drawing.SystemColors.Window
        Me.griCotizacionDetalleSer.DisplayLayout.GroupByBox.Appearance = Appearance125
        Appearance126.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCotizacionDetalleSer.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance126
        Me.griCotizacionDetalleSer.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCotizacionDetalleSer.DisplayLayout.GroupByBox.Hidden = True
        Appearance127.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance127.BackColor2 = System.Drawing.SystemColors.Control
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance127.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCotizacionDetalleSer.DisplayLayout.GroupByBox.PromptAppearance = Appearance127
        Me.griCotizacionDetalleSer.DisplayLayout.MaxColScrollRegions = 1
        Me.griCotizacionDetalleSer.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCotizacionDetalleSer.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griCotizacionDetalleSer.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCotizacionDetalleSer.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCotizacionDetalleSer.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance128.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacionDetalleSer.DisplayLayout.Override.CellAppearance = Appearance128
        Me.griCotizacionDetalleSer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCotizacionDetalleSer.DisplayLayout.Override.CellPadding = 0
        Me.griCotizacionDetalleSer.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCotizacionDetalleSer.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griCotizacionDetalleSer.DisplayLayout.Override.GroupByRowAppearance = Appearance129
        Appearance130.TextHAlignAsString = "Left"
        Me.griCotizacionDetalleSer.DisplayLayout.Override.HeaderAppearance = Appearance130
        Me.griCotizacionDetalleSer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance131.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacionDetalleSer.DisplayLayout.Override.RowAppearance = Appearance131
        Me.griCotizacionDetalleSer.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCotizacionDetalleSer.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCotizacionDetalleSer.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCotizacionDetalleSer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCotizacionDetalleSer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCotizacionDetalleSer.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griCotizacionDetalleSer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griCotizacionDetalleSer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCotizacionDetalleSer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCotizacionDetalleSer.Location = New System.Drawing.Point(0, 0)
        Me.griCotizacionDetalleSer.Name = "griCotizacionDetalleSer"
        Me.griCotizacionDetalleSer.Size = New System.Drawing.Size(1094, 209)
        Me.griCotizacionDetalleSer.TabIndex = 0
        Me.griCotizacionDetalleSer.Text = "Grilla1"
        '
        'odCotizacionDetalleSer
        '
        UltraDataColumn132.DataType = GetType(Date)
        UltraDataColumn135.DataType = GetType(Double)
        Me.odCotizacionDetalleSer.Band.Columns.AddRange(New Object() {UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrRequerimientos)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1102, 556)
        '
        'agrRequerimientos
        '
        Me.agrRequerimientos.Controls.Add(Me.griCotizacion)
        Me.agrRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRequerimientos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRequerimientos.Location = New System.Drawing.Point(0, 64)
        Me.agrRequerimientos.Name = "agrRequerimientos"
        Me.agrRequerimientos.Size = New System.Drawing.Size(1102, 492)
        Me.agrRequerimientos.TabIndex = 1
        Me.agrRequerimientos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griCotizacion
        '
        Me.griCotizacion.ContextMenuStrip = Me.MenuContextual2
        Me.griCotizacion.DataSource = Me.odCotizaciones
        UltraGridColumn68.Header.VisiblePosition = 0
        UltraGridColumn68.Hidden = True
        Appearance23.TextHAlignAsString = "Center"
        UltraGridColumn69.Header.Appearance = Appearance23
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridColumn69.Width = 97
        UltraGridColumn70.Header.VisiblePosition = 5
        UltraGridColumn70.Width = 281
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn71.Header.Appearance = Appearance24
        UltraGridColumn71.Header.VisiblePosition = 9
        UltraGridColumn71.Hidden = True
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn72.Header.Appearance = Appearance25
        UltraGridColumn72.Header.VisiblePosition = 8
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn73.Header.Appearance = Appearance26
        UltraGridColumn73.Header.Caption = "Fecha"
        UltraGridColumn73.Header.VisiblePosition = 6
        UltraGridColumn73.MaskInput = "{date}"
        UltraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn73.Width = 88
        UltraGridColumn74.Header.VisiblePosition = 10
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 4
        UltraGridColumn75.Width = 83
        UltraGridColumn76.Header.Caption = "Tipo"
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Width = 48
        UltraGridColumn77.Header.VisiblePosition = 11
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 12
        UltraGridColumn78.Width = 122
        UltraGridColumn79.Header.VisiblePosition = 13
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 14
        UltraGridColumn80.Width = 382
        UltraGridColumn1.Header.VisiblePosition = 15
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Width = 80
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance27
        UltraGridColumn13.Format = "#,###,###,##0.0000"
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn13.Header.Appearance = Appearance28
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.MaskInput = "{double:9.4}"
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.Width = 105
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn1, UltraGridColumn2, UltraGridColumn13})
        Me.griCotizacion.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griCotizacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance29.BorderColor = System.Drawing.SystemColors.Window
        Me.griCotizacion.DisplayLayout.GroupByBox.Appearance = Appearance29
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCotizacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance30
        Me.griCotizacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griCotizacion.DisplayLayout.GroupByBox.Hidden = True
        Appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance31.BackColor2 = System.Drawing.SystemColors.Control
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griCotizacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance31
        Me.griCotizacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griCotizacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griCotizacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCotizacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCotizacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griCotizacion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacion.DisplayLayout.Override.CellAppearance = Appearance32
        Me.griCotizacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCotizacion.DisplayLayout.Override.CellPadding = 0
        Me.griCotizacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCotizacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCotizacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griCotizacion.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.griCotizacion.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.griCotizacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.griCotizacion.DisplayLayout.Override.RowAppearance = Appearance35
        Me.griCotizacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCotizacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCotizacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCotizacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griCotizacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCotizacion.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griCotizacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCotizacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCotizacion.Location = New System.Drawing.Point(3, 3)
        Me.griCotizacion.Name = "griCotizacion"
        Me.griCotizacion.Size = New System.Drawing.Size(1096, 486)
        Me.griCotizacion.TabIndex = 0
        Me.griCotizacion.Text = "Grilla1"
        '
        'MenuContextual2
        '
        Me.MenuContextual2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual2.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ToolStripMenuItem1, Me.AprobarToolStripMenuItem})
        Me.MenuContextual2.Name = "MenuContextual1"
        Me.MenuContextual2.Size = New System.Drawing.Size(122, 92)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Requerimiento"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EditarToolStripMenuItem.Text = "Actualizar"
        Me.EditarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Requerimiento seleccionado"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ToolStripMenuItem1.Text = "Eliminar"
        Me.ToolStripMenuItem1.ToolTipText = "Eliminar el Requerimiento seleccionado"
        '
        'AprobarToolStripMenuItem
        '
        Me.AprobarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.AprobarToolStripMenuItem.Name = "AprobarToolStripMenuItem"
        Me.AprobarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AprobarToolStripMenuItem.Text = "Aprobar"
        '
        'odCotizaciones
        '
        UltraDataColumn41.DataType = GetType(Double)
        Me.odCotizaciones.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.ColoresAtendido)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion1.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion1.Controls.Add(Me.ColoresEvaluado)
        Me.Agrupacion1.Controls.Add(Me.cboRequerimiento)
        Me.Agrupacion1.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion1.Controls.Add(Me.dtpFechaCotHasta)
        Me.Agrupacion1.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion1.Controls.Add(Me.dtpFechaCotDesde)
        Me.Agrupacion1.Controls.Add(Me.etiGenerada)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1102, 64)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresAtendido
        '
        Me.ColoresAtendido.Color = System.Drawing.Color.LightGreen
        Me.ColoresAtendido.Location = New System.Drawing.Point(824, 21)
        Me.ColoresAtendido.Name = "ColoresAtendido"
        Me.ColoresAtendido.ReadOnly = True
        Me.ColoresAtendido.Size = New System.Drawing.Size(46, 21)
        Me.ColoresAtendido.TabIndex = 11
        Me.ColoresAtendido.Text = "LightGreen"
        '
        'Etiqueta10
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Appearance = Appearance36
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(762, 25)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta10.TabIndex = 10
        Me.Etiqueta10.Text = "Terminada"
        '
        'UltraLabel5
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance37
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(316, 27)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(30, 15)
        Me.UltraLabel5.TabIndex = 4
        Me.UltraLabel5.Text = "Tipo:"
        '
        'ColoresEvaluado
        '
        Me.ColoresEvaluado.Color = System.Drawing.Color.Khaki
        Me.ColoresEvaluado.Location = New System.Drawing.Point(713, 21)
        Me.ColoresEvaluado.Name = "ColoresEvaluado"
        Me.ColoresEvaluado.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEvaluado.TabIndex = 9
        Me.ColoresEvaluado.Text = "Khaki"
        '
        'cboRequerimiento
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.cboRequerimiento.Appearance = Appearance38
        Me.cboRequerimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboRequerimiento.DisplayMember = "Nombre"
        Me.cboRequerimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRequerimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRequerimiento.ForeColor = System.Drawing.Color.Black
        ValueListItem3.DataValue = "M"
        ValueListItem3.DisplayText = "MATERIALES"
        ValueListItem4.DataValue = "S"
        ValueListItem4.DisplayText = "SERVICIOS"
        Me.cboRequerimiento.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.cboRequerimiento.Location = New System.Drawing.Point(352, 23)
        Me.cboRequerimiento.Name = "cboRequerimiento"
        Me.cboRequerimiento.Size = New System.Drawing.Size(167, 21)
        Me.cboRequerimiento.TabIndex = 5
        Me.cboRequerimiento.ValueMember = "Id"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Color = System.Drawing.Color.White
        Me.ColoresGenerado.Location = New System.Drawing.Point(605, 21)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 7
        Me.ColoresGenerado.Text = "White"
        '
        'dtpFechaCotHasta
        '
        Me.dtpFechaCotHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCotHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCotHasta.Location = New System.Drawing.Point(195, 24)
        Me.dtpFechaCotHasta.Name = "dtpFechaCotHasta"
        Me.dtpFechaCotHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaCotHasta.TabIndex = 3
        '
        'etiEnProceso
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance39
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(657, 25)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(50, 15)
        Me.etiEnProceso.TabIndex = 8
        Me.etiEnProceso.Text = "Aprobada"
        '
        'dtpFechaCotDesde
        '
        Me.dtpFechaCotDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCotDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCotDesde.Location = New System.Drawing.Point(52, 25)
        Me.dtpFechaCotDesde.Name = "dtpFechaCotDesde"
        Me.dtpFechaCotDesde.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaCotDesde.TabIndex = 1
        '
        'etiGenerada
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance40
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(548, 25)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(51, 15)
        Me.etiGenerada.TabIndex = 6
        Me.etiGenerada.Text = "Generado"
        '
        'Etiqueta21
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance41
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(155, 27)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta2
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance42
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 27)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Desde:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion7)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1102, 556)
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.ficDetalles)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(0, 324)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(1102, 232)
        Me.Agrupacion7.TabIndex = 2
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetalles
        '
        Me.ficDetalles.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalles.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalles.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalles.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalles.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalles.Location = New System.Drawing.Point(3, 3)
        Me.ficDetalles.Name = "ficDetalles"
        Me.ficDetalles.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalles.Size = New System.Drawing.Size(1096, 226)
        Me.ficDetalles.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Proveedores"
        UltraTab1.Key = "1"
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Requerimientos"
        UltraTab2.Key = "2"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Materiales"
        UltraTab4.TabPage = Me.UltraTabPageControl6
        UltraTab4.Text = "Servicios"
        Me.ficDetalles.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab1, UltraTab2, UltraTab4})
        Me.ficDetalles.TabStop = False
        Me.ficDetalles.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1094, 203)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.ficCotizacionDetalle)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 86)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1102, 238)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficCotizacionDetalle
        '
        Me.ficCotizacionDetalle.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficCotizacionDetalle.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCotizacionDetalle.Controls.Add(Me.UltraTabPageControl8)
        Me.ficCotizacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCotizacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCotizacionDetalle.Location = New System.Drawing.Point(3, 3)
        Me.ficCotizacionDetalle.Name = "ficCotizacionDetalle"
        Me.ficCotizacionDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficCotizacionDetalle.Size = New System.Drawing.Size(1096, 232)
        Me.ficCotizacionDetalle.TabIndex = 0
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "CotizacionMaterial"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "CotizacionServicio"
        Me.ficCotizacionDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab8})
        Me.ficCotizacionDetalle.TabStop = False
        Me.ficCotizacionDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1094, 209)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.numTotalCotizacion)
        Me.Agrupacion2.Controls.Add(Me.txtEquipo)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.txtProveedor)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.cboMoneda)
        Me.Agrupacion2.Controls.Add(Me.Boton1)
        Me.Agrupacion2.Controls.Add(Me.txtGlosa)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1102, 86)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel3
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Appearance132.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance132
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(759, 64)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Total:"
        '
        'numTotalCotizacion
        '
        Appearance133.ForeColor = System.Drawing.Color.Black
        Me.numTotalCotizacion.Appearance = Appearance133
        Me.numTotalCotizacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalCotizacion.ForeColor = System.Drawing.Color.Black
        Me.numTotalCotizacion.Location = New System.Drawing.Point(798, 60)
        Me.numTotalCotizacion.Name = "numTotalCotizacion"
        Me.numTotalCotizacion.NullText = "0.00"
        Me.numTotalCotizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalCotizacion.ReadOnly = True
        Me.numTotalCotizacion.Size = New System.Drawing.Size(100, 21)
        Me.numTotalCotizacion.TabIndex = 10
        '
        'txtEquipo
        '
        Me.txtEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEquipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipo.Location = New System.Drawing.Point(653, 60)
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.ReadOnly = True
        Me.txtEquipo.Size = New System.Drawing.Size(100, 21)
        Me.txtEquipo.TabIndex = 8
        '
        'UltraLabel2
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Appearance134.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance134
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(605, 64)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "Equipo:"
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(653, 33)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(322, 21)
        Me.txtProveedor.TabIndex = 6
        '
        'UltraLabel1
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Appearance135.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance135
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(579, 37)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Proveedor:"
        '
        'UltraLabel6
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance136
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(579, 13)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance137.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance137
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(653, 10)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(138, 21)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.ValueMember = "Id"
        '
        'Boton1
        '
        Appearance138.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.Boton1.Appearance = Appearance138
        Me.Boton1.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Boton1.Location = New System.Drawing.Point(868, 8)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(107, 22)
        Me.Boton1.TabIndex = 4
        Me.Boton1.Text = "Enviar Correo"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(48, 9)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(525, 71)
        Me.txtGlosa.TabIndex = 1
        '
        'Etiqueta1
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance139
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 13)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Glosa:"
        '
        'ficCotizacionProveedor
        '
        Me.ficCotizacionProveedor.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCotizacionProveedor.Controls.Add(Me.UltraTabPageControl1)
        Me.ficCotizacionProveedor.Controls.Add(Me.UltraTabPageControl2)
        Me.ficCotizacionProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCotizacionProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCotizacionProveedor.Location = New System.Drawing.Point(0, 0)
        Me.ficCotizacionProveedor.Name = "ficCotizacionProveedor"
        Me.ficCotizacionProveedor.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCotizacionProveedor.Size = New System.Drawing.Size(1104, 579)
        Me.ficCotizacionProveedor.TabIndex = 0
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl1
        UltraTab6.Text = "Lista"
        UltraTab7.Key = "Mantenimiento"
        UltraTab7.TabPage = Me.UltraTabPageControl2
        UltraTab7.Text = "Mantenimiento"
        Me.ficCotizacionProveedor.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficCotizacionProveedor.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1102, 556)
        '
        'frm_CotizacionProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 579)
        Me.Controls.Add(Me.ficCotizacionProveedor)
        Me.Name = "frm_CotizacionProveedor"
        Me.Text = "Cotizacion Proveedor"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        CType(Me.griListadoProveedoresCotizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCotizacionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion10.ResumeLayout(False)
        CType(Me.griListadoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuCotizacionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griListaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscarMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griListaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboCategoriaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.griCotizacionDetalleSer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCotizacionDetalleSer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRequerimientos.ResumeLayout(False)
        CType(Me.griCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual2.ResumeLayout(False)
        CType(Me.odCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.ColoresAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        CType(Me.ficDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalles.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.ficCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCotizacionDetalle.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.numTotalCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficCotizacionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCotizacionProveedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficCotizacionProveedor As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrRequerimientos As ISL.Controles.Agrupacion
    Friend WithEvents griCotizacion As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents dtpFechaCotHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaCotDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents mnuCotizacionProveedor As ISL.Controles.Menu
    Friend WithEvents odCotizaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odCotizacionProveedor As ISL.Controles.OrigenDatos
    Friend WithEvents ordProveedor As ISL.Controles.OrigenDatos
    Friend WithEvents odCotizacionDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents Boton1 As ISL.Controles.Boton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ficDetalles As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarMaterialesReq As ISL.Controles.Boton
    Friend WithEvents dtpReqHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReqDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaMateriales As ISL.Controles.Grilla
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents txtBuscarMateriales As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents griListadoProveedoresCotizar As ISL.Controles.Grilla
    Friend WithEvents Agrupacion10 As ISL.Controles.Agrupacion
    Friend WithEvents griListadoProveedor As ISL.Controles.Grilla
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficCotizacionDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListadoCotizacionDetalle As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboRequerimiento As ISL.Controles.ComboMaestros
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents odCotizacionDetalleSer As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ColoresAtendido As ISL.Controles.Colores
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEvaluado As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents MenuContextual2 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AprobarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtEquipo As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griListaRequerimiento As ISL.Controles.Grilla
    Friend WithEvents odRequerimientos As ISL.Controles.OrigenDatos
    Friend WithEvents griCotizacionDetalleSer As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btnCategoria As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboCategoriaServicios As ISL.Controles.ComboMaestros
    Friend WithEvents griListaServicio As ISL.Controles.Grilla
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numTotalCotizacion As ISL.Controles.NumeroDecimal
    Friend WithEvents odServicio As ISL.Controles.OrigenDatos
End Class
