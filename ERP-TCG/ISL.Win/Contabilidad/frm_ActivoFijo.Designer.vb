<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActivoFijo
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActivoFijo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaReadecuacion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInvertido")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAgregar")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VidaUtilAgregar")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorResidualAgregar")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActivoFijo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaReadecuacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInvertido")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoAgregar")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VidaUtilAgregar")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorResidualAgregar")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReadecuacionActivoFijo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTipoDoc")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReadecuacionActivoFijo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTipoDoc")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSedeEmpresa")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdResponsable")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPropiedad")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPropiedadActual")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionResumida")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionDetallada")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecActivacion")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActivacion")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConceptoIngreso")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGrupoActivo")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubGrupoActivo")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDepreciable")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRevalorizable")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPertenencia")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VidaUtil")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompra")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDocumento")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorCompra")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaSituacion")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorLibro")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RevalorizacionAcumulada")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DepreciacionAcumulada")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VidaUtilRemanente")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnhoMesRevalorizacion")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnhoMesDepreciacion")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBaja")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaBaja")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConceptoBaja")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionBaja")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaTecnica")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSedeEmpresa")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdResponsable")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPropiedad")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPropiedadActual")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescripcionResumida")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescripcionDetallada")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecActivacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActivacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConceptoIngreso")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrupoActivo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubGrupoActivo")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDepreciable")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndRevalorizable")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPertenencia")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VidaUtil")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCompra")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDocumento")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorCompra")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaSituacion")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorLibro")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RevalorizacionAcumulada")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DepreciacionAcumulada")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VidaUtilRemanente")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnhoMesRevalorizacion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnhoMesDepreciacion")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndBaja")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaBaja")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConceptoBaja")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescripcionBaja")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FichaTecnica")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo Fijo")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activ")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha Activ")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Deprec.")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor Activo")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor Residual")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vida Util (Años)")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaDebe")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cta Deprec. Debe")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion Cta Deprec. Debe")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaHaber")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cta Deprec. Haber")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion Cta Deprec. Haber")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F.Inicio Periodo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("F.Fin Periodo")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total Depreciacion")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total Deprec. Acumulada")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActivoFijo")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAFCuentaContable")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoActivoFijo")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoPeriodo")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoActivoFijo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTipoVehiculo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo Fijo")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activ")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha Activ")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Deprec.")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor Activo")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor Residual")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vida Util (Años)")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaDebe")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cta Deprec. Debe")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion Cta Deprec. Debe")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaHaber")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cta Deprec. Haber")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion Cta Deprec. Haber")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("F.Inicio Periodo")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("F.Fin Periodo")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total Depreciacion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total Deprec. Acumulada")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActivoFijo")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAFCuentaContable")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoActivoFijo")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoPeriodo")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoActivoFijo")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTipoVehiculo")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoAsiento")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaImprime")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDebe")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalHaber")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioBloquea")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoExtorno")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndOrigen")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoAsiento")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaImprime")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDebe")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalHaber")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioBloquea")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoExtorno")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndOrigen")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Guardar Depreciacion de Activo Fijos", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActivoFijo))
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActivoFijo")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInformacionContable")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAdquiere")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecActivacion")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActivacion")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleCompra")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleRevalorizacion")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbeDepreciacion")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCtbleReadeacuacion")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorResidual")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DepreciacionAcumulada")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAdquisicion")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpFinancia")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLeasing")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorCuota")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleCompra")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleRevalorizacion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbeDepreciacion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleReadeacuacion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ejercicio")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoActivo")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoActivo")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleCompraH")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleRevalorizacionH")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbeDepreciacionH")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleReadeacuacionH")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCtbleDesactivacionD")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GastoFuncion")
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup0", 164867782)
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 164867783)
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup2", 164867784)
        Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup3", 164867785)
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActivoFijo")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInformacionContable")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAdquiere")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecActivacion")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActivacion")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleCompra")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleRevalorizacion")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbeDepreciacion")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCtbleReadeacuacion")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorResidual")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DepreciacionAcumulada")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAdquisicion")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpFinancia")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLeasing")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorCuota")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleCompra")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleRevalorizacion")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbeDepreciacion")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleReadeacuacion")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ejercicio")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoActivo")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoActivo")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleCompraH")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleRevalorizacionH")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbeDepreciacionH")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleReadeacuacionH")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCtbleDesactivacionD")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GastoFuncion")
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
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActivoFijo")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAFCuentaContable")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AFCuentaContable")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaOrigen")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaDestino")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaOrigen")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaDestino")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsiento")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActivoFijo")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAFCuentaContable")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AFCuentaContable")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaOrigen")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaDestino")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaOrigen")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaDestino")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsiento")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab21 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.tapListaReadecuaciones = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griReadecuacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdReadecuacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tspListaReadecuaciones = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditarReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.tapMantReadecuaciones = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griReadecuacionAFDocumento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsReadecuacionAFDocumento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspDocAsocReadecuacion = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarReadecuacionDoc = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarReadecuacionDoc = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboTipoDocReadecuacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscarDocReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumeroReadecuacion = New ISL.Controles.Texto(Me.components)
        Me.txtSerieReadecuacion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecReadecuacion = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMontoAgregarActR = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta59 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta60 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta57 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtObservacionR = New ISL.Controles.Texto(Me.components)
        Me.cboMesR = New ISL.Controles.Combo(Me.components)
        Me.decMontoAgregarVR = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decVidaUtilAgregarR = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta58 = New ISL.Controles.Etiqueta(Me.components)
        Me.AñoR = New ISL.Win.Año()
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero6 = New ISL.Controles.NumeroEntero(Me.components)
        Me.tspMantReadecuaciones = New System.Windows.Forms.ToolStrip()
        Me.tsbAceptarReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelarReadecuacion = New System.Windows.Forms.ToolStripButton()
        Me.utpActivosFijos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmsListado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemReclasificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.udsActivoFijo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.utpDepreciarActivos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDepreciacionActivos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsDepActivos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorFilaEdit = New ISL.Controles.Colores(Me.components)
        Me.btnValidarDepreciacion = New System.Windows.Forms.Button()
        Me.AñoDepActivos = New ISL.Win.Año()
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero12 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero13 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero14 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero15 = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboMesDepActivos = New ISL.Controles.Combo(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.utpListaDAF = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAsiento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsAsiento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox17 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnExtornarAsiento = New System.Windows.Forms.Button()
        Me.btnEliminarDepreciaciones = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox11 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel14 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnConsultarAsiento = New Infragistics.Win.Misc.UltraButton()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtNroAsiento = New ISL.Controles.Texto(Me.components)
        Me.verNroAsiento = New ISL.Controles.Chequear(Me.components)
        Me.AñoListaDAF = New ISL.Win.Año()
        Me.Etiqueta93 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesListaDAF = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta94 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.rbtSituacionAFecha = New System.Windows.Forms.RadioButton()
        Me.ugbSinDocumento = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneCosto2012 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.uneDep2015 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.uneDep2014 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecSituacionCtble = New System.Windows.Forms.DateTimePicker()
        Me.decValorLibroSC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.decDepreciacionAcumuladaSC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.decVidaUtilRemanenteSC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.decRevalorizacionAcumuladaSC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.rbtInformacionCompra = New System.Windows.Forms.RadioButton()
        Me.ugbConDoc = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uneValorCompra = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtTipoDocumento = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtProveedor = New ISL.Controles.Texto(Me.components)
        Me.fecCompraIC = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarDoc = New System.Windows.Forms.Button()
        Me.opcTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiProveedor = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumentoIC = New ISL.Controles.Texto(Me.components)
        Me.decVidaUtilIC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta72 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta71 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroAutorizacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboMetodo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.numPorcentaje = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboDepreciacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCCUbicaciones = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cbgCentroCostoAF = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboSubGrupoAF = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uneValorResidual = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboGrupoAF = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboConceptoIngresoAF = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkDepreciable = New System.Windows.Forms.CheckBox()
        Me.fecActivacion = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.verIndFecActivacion = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkMaterial = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbgMaterial = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCantidadAF = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkConjuntoAF = New ISL.Controles.Chequear(Me.components)
        Me.uegbDatosBaja = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ugbDocumentoBaja = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtTipoDocBaja = New ISL.Controles.Texto(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscarDocBaja = New System.Windows.Forms.ToolStripButton()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerieBaja = New ISL.Controles.Texto(Me.components)
        Me.txtNumeroBaja = New ISL.Controles.Texto(Me.components)
        Me.fecBaja = New System.Windows.Forms.DateTimePicker()
        Me.cboConceptoBajaAF = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.verIndBaja = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDescripcionBaja = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAFCuentaContable = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udsAFCuentaContable = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspInformacionContable = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitar = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtGastoFuncion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaDesactivacionDD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaDesactivacionD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaReadecuacionHH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaDepreciacionHH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaRevalorizacionHH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaCompraHH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaReadecuacionDD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaDepreciacionDD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaRevalorizacionDD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaReadecuacionH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaDepreciacionH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta63 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta64 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaRevalorizacionH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta65 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaCompraH = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta68 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta70 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta85 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta86 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaCompraD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaReadecuacionD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaDepreciacionD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaRevalorizacionD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta87 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroLeasingIC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.opcTipoAdquisicion = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txtCtaCompraDD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta66 = New ISL.Controles.Etiqueta(Me.components)
        Me.AñoIC = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utcReadecuaciones = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDepreciacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdDepreciacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox16 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel19 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.cboAFCuentaContableD = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta69 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActualD = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboCtaDestinoD = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboCtaOrigenD = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtObservacionD = New ISL.Controles.Texto(Me.components)
        Me.btnAgregarD = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta61 = New ISL.Controles.Etiqueta(Me.components)
        Me.decImporteD = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decValorD = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta62 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCtaDestinoD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCtaOrigenD = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta55 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta56 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta53 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesD = New ISL.Controles.Combo(Me.components)
        Me.AñoD = New ISL.Win.Año()
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero7 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero8 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero9 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero10 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero11 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta54 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.decReadecuacionesV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.decValorLibroAlFecV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decVidaUtilRemanV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decDepreAcumuladaV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.decRevalAcumuladaV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraExpandableGroupBox8 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.fecConsultaV = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.btn_Valorizar = New Infragistics.Win.Misc.UltraButton()
        Me.decValorBrutoInicialV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.decValorCompraLibroV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabAdicionalAF = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDatosAF = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox12 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.expandablecabecera = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.agrDepende = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtActivoFijo = New ISL.Controles.Texto(Me.components)
        Me.cboActivoFijo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chkDepende = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtIdentificador = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstadoAF = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboCentro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboResponsable = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtDescripcionDetallada = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkPropio = New System.Windows.Forms.CheckBox()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta67 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDescripcionResumida = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficActivoFijo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.tapListaReadecuaciones.SuspendLayout()
        CType(Me.griReadecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdReadecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListaReadecuaciones.SuspendLayout()
        Me.tapMantReadecuaciones.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.griReadecuacionAFDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsReadecuacionAFDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspDocAsocReadecuacion.SuspendLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.cboTipoDocReadecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtNumeroReadecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieReadecuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.decMontoAgregarActR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoAgregarVR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decVidaUtilAgregarR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoR.SuspendLayout()
        CType(Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspMantReadecuaciones.SuspendLayout()
        Me.utpActivosFijos.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsListado.SuspendLayout()
        CType(Me.udsActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDepreciarActivos.SuspendLayout()
        CType(Me.griDepreciacionActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsDepActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.ColorFilaEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoDepActivos.SuspendLayout()
        CType(Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesDepActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpListaDAF.SuspendLayout()
        CType(Me.griAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox17.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout()
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox11.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel14.SuspendLayout()
        CType(Me.txtNroAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verNroAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesListaDAF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ugbSinDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbSinDocumento.SuspendLayout()
        CType(Me.uneCosto2012, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneDep2015, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneDep2014, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorLibroSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decDepreciacionAcumuladaSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decVidaUtilRemanenteSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decRevalorizacionAcumuladaSC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugbConDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbConDoc.SuspendLayout()
        CType(Me.uneValorCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumentoIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decVidaUtilIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMetodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCCUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgCentroCostoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSubGrupoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneValorResidual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptoIngresoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndFecActivacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantidadAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConjuntoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uegbDatosBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uegbDatosBaja.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.ugbDocumentoBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbDocumentoBaja.SuspendLayout()
        CType(Me.txtTipoDocBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.txtSerieBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptoBajaAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griAFCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsAFCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspInformacionContable.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.txtGastoFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDesactivacionDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDesactivacionD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaReadecuacionHH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDepreciacionHH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaRevalorizacionHH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCompraHH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaReadecuacionDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDepreciacionDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaRevalorizacionDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaReadecuacionH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDepreciacionH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaRevalorizacionH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCompraH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCompraD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaReadecuacionD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDepreciacionD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaRevalorizacionD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroLeasingIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcTipoAdquisicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaCompraDD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoIC.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.utcReadecuaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcReadecuaciones.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox16.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel19.SuspendLayout()
        CType(Me.cboAFCuentaContableD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActualD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaDestinoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaOrigenD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImporteD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaDestinoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCtaOrigenD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoD.SuspendLayout()
        CType(Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox9.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.decReadecuacionesV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorLibroAlFecV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decVidaUtilRemanV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decDepreAcumuladaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decRevalAcumuladaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox8.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        CType(Me.decValorBrutoInicialV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorCompraLibroV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.tabAdicionalAF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdicionalAF.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDatosAF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDatosAF.SuspendLayout()
        CType(Me.UltraExpandableGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox12.SuspendLayout()
        Me.expandablecabecera.SuspendLayout()
        CType(Me.agrDepende, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDepende.SuspendLayout()
        CType(Me.txtActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDepende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentificador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionDetallada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionResumida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficActivoFijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tapListaReadecuaciones
        '
        Me.tapListaReadecuaciones.Controls.Add(Me.griReadecuacion)
        Me.tapListaReadecuaciones.Controls.Add(Me.tspListaReadecuaciones)
        Me.tapListaReadecuaciones.Location = New System.Drawing.Point(2, 24)
        Me.tapListaReadecuaciones.Name = "tapListaReadecuaciones"
        Me.tapListaReadecuaciones.Size = New System.Drawing.Size(1149, 337)
        '
        'griReadecuacion
        '
        Me.griReadecuacion.DataSource = Me.ogdReadecuacion
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griReadecuacion.DisplayLayout.Appearance = Appearance1
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 2
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Header.Caption = "Fecha"
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.Width = 80
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance2
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn47.Format = "#,##0.00"
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.MaskInput = "{double:9.2}"
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn47.Width = 91
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance3
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Format = "#,##0.00"
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn48.MaskInput = "{double:-9.2}"
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn48.Width = 92
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance4
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn49.Format = "#,##0.00"
        UltraGridColumn49.Header.VisiblePosition = 8
        UltraGridColumn49.MaskInput = "{double:-5.2}"
        UltraGridColumn49.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn49.Width = 97
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn50.Header.VisiblePosition = 10
        UltraGridColumn50.Width = 439
        UltraGridColumn51.Header.VisiblePosition = 9
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 11
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 12
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 13
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 14
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 15
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 3
        UltraGridColumn57.Width = 75
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance5
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn58.Format = "#,##0.00"
        UltraGridColumn58.Header.VisiblePosition = 7
        UltraGridColumn58.MaskInput = "{double:-9.2}"
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn43, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
        Me.griReadecuacion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griReadecuacion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReadecuacion.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.griReadecuacion.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griReadecuacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.griReadecuacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReadecuacion.DisplayLayout.GroupByBox.Hidden = True
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griReadecuacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.griReadecuacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griReadecuacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griReadecuacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griReadecuacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griReadecuacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griReadecuacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griReadecuacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griReadecuacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griReadecuacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griReadecuacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griReadecuacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griReadecuacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griReadecuacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griReadecuacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReadecuacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griReadecuacion.Location = New System.Drawing.Point(0, 25)
        Me.griReadecuacion.Name = "griReadecuacion"
        Me.griReadecuacion.Size = New System.Drawing.Size(1149, 312)
        Me.griReadecuacion.TabIndex = 1
        '
        'ogdReadecuacion
        '
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Date)
        UltraDataColumn16.DataType = GetType(Double)
        Me.ogdReadecuacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tspListaReadecuaciones
        '
        Me.tspListaReadecuaciones.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspListaReadecuaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarReadecuacion, Me.tsbEditarReadecuacion, Me.tsbQuitarReadecuacion})
        Me.tspListaReadecuaciones.Location = New System.Drawing.Point(0, 0)
        Me.tspListaReadecuaciones.Name = "tspListaReadecuaciones"
        Me.tspListaReadecuaciones.Size = New System.Drawing.Size(1149, 25)
        Me.tspListaReadecuaciones.TabIndex = 341
        '
        'tsbAgregarReadecuacion
        '
        Me.tsbAgregarReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarReadecuacion.Name = "tsbAgregarReadecuacion"
        Me.tsbAgregarReadecuacion.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregarReadecuacion.Text = "Agregar"
        '
        'tsbEditarReadecuacion
        '
        Me.tsbEditarReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.tsbEditarReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditarReadecuacion.Name = "tsbEditarReadecuacion"
        Me.tsbEditarReadecuacion.Size = New System.Drawing.Size(57, 22)
        Me.tsbEditarReadecuacion.Text = "Editar"
        '
        'tsbQuitarReadecuacion
        '
        Me.tsbQuitarReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.tsbQuitarReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarReadecuacion.Name = "tsbQuitarReadecuacion"
        Me.tsbQuitarReadecuacion.Size = New System.Drawing.Size(60, 22)
        Me.tsbQuitarReadecuacion.Text = "Quitar"
        '
        'tapMantReadecuaciones
        '
        Me.tapMantReadecuaciones.Controls.Add(Me.UltraGroupBox4)
        Me.tapMantReadecuaciones.Controls.Add(Me.UltraGroupBox8)
        Me.tapMantReadecuaciones.Controls.Add(Me.tspMantReadecuaciones)
        Me.tapMantReadecuaciones.Location = New System.Drawing.Point(-10000, -10000)
        Me.tapMantReadecuaciones.Name = "tapMantReadecuaciones"
        Me.tapMantReadecuaciones.Size = New System.Drawing.Size(1149, 347)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.griReadecuacionAFDocumento)
        Me.UltraGroupBox4.Controls.Add(Me.tspDocAsocReadecuacion)
        Me.UltraGroupBox4.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 108)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1149, 239)
        Me.UltraGroupBox4.TabIndex = 319
        Me.UltraGroupBox4.Text = "Documento(s)"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'griReadecuacionAFDocumento
        '
        Me.griReadecuacionAFDocumento.DataSource = Me.udsReadecuacionAFDocumento
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griReadecuacionAFDocumento.DisplayLayout.Appearance = Appearance9
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Width = 231
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Width = 67
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Width = 141
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 12
        UltraGridColumn27.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 13
        UltraGridColumn32.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 14
        UltraGridColumn39.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn32, UltraGridColumn39})
        Me.griReadecuacionAFDocumento.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griReadecuacionAFDocumento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReadecuacionAFDocumento.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.griReadecuacionAFDocumento.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griReadecuacionAFDocumento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.griReadecuacionAFDocumento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griReadecuacionAFDocumento.DisplayLayout.GroupByBox.Hidden = True
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griReadecuacionAFDocumento.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.griReadecuacionAFDocumento.DisplayLayout.MaxColScrollRegions = 1
        Me.griReadecuacionAFDocumento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griReadecuacionAFDocumento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griReadecuacionAFDocumento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griReadecuacionAFDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griReadecuacionAFDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griReadecuacionAFDocumento.Location = New System.Drawing.Point(3, 82)
        Me.griReadecuacionAFDocumento.Name = "griReadecuacionAFDocumento"
        Me.griReadecuacionAFDocumento.Size = New System.Drawing.Size(1143, 154)
        Me.griReadecuacionAFDocumento.TabIndex = 2
        '
        'udsReadecuacionAFDocumento
        '
        UltraDataColumn26.DataType = GetType(Date)
        UltraDataColumn28.DataType = GetType(Date)
        UltraDataColumn29.DataType = GetType(Boolean)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn31.DataType = GetType(Integer)
        Me.udsReadecuacionAFDocumento.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31})
        '
        'tspDocAsocReadecuacion
        '
        Me.tspDocAsocReadecuacion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspDocAsocReadecuacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarReadecuacionDoc, Me.tsbQuitarReadecuacionDoc})
        Me.tspDocAsocReadecuacion.Location = New System.Drawing.Point(3, 57)
        Me.tspDocAsocReadecuacion.Name = "tspDocAsocReadecuacion"
        Me.tspDocAsocReadecuacion.Size = New System.Drawing.Size(1143, 25)
        Me.tspDocAsocReadecuacion.TabIndex = 341
        '
        'tsbAgregarReadecuacionDoc
        '
        Me.tsbAgregarReadecuacionDoc.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarReadecuacionDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarReadecuacionDoc.Name = "tsbAgregarReadecuacionDoc"
        Me.tsbAgregarReadecuacionDoc.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregarReadecuacionDoc.Text = "Agregar"
        '
        'tsbQuitarReadecuacionDoc
        '
        Me.tsbQuitarReadecuacionDoc.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.tsbQuitarReadecuacionDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarReadecuacionDoc.Name = "tsbQuitarReadecuacionDoc"
        Me.tsbQuitarReadecuacionDoc.Size = New System.Drawing.Size(60, 22)
        Me.tsbQuitarReadecuacionDoc.Text = "Quitar"
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.cboTipoDocReadecuacion)
        Me.UltraGroupBox9.Controls.Add(Me.ToolStrip1)
        Me.UltraGroupBox9.Controls.Add(Me.Etiqueta7)
        Me.UltraGroupBox9.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox9.Controls.Add(Me.txtNumeroReadecuacion)
        Me.UltraGroupBox9.Controls.Add(Me.txtSerieReadecuacion)
        Me.UltraGroupBox9.Controls.Add(Me.Etiqueta9)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox9.Location = New System.Drawing.Point(3, 17)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(1143, 40)
        Me.UltraGroupBox9.TabIndex = 325
        '
        'cboTipoDocReadecuacion
        '
        Me.cboTipoDocReadecuacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocReadecuacion.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboTipoDocReadecuacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocReadecuacion.DisplayMember = "Nombre"
        Me.cboTipoDocReadecuacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboTipoDocReadecuacion.DropDownListWidth = -1
        Me.cboTipoDocReadecuacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocReadecuacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValueListItem2.DataValue = "ValueListItem0"
        ValueListItem2.DisplayText = "DOCUMENTO"
        ValueListItem3.DataValue = "ValueListItem1"
        ValueListItem3.DisplayText = "ORDEN TRABAJO"
        Me.cboTipoDocReadecuacion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.cboTipoDocReadecuacion.Location = New System.Drawing.Point(68, 9)
        Me.cboTipoDocReadecuacion.Name = "cboTipoDocReadecuacion"
        Me.cboTipoDocReadecuacion.Size = New System.Drawing.Size(242, 22)
        Me.cboTipoDocReadecuacion.TabIndex = 0
        Me.cboTipoDocReadecuacion.ValueMember = "Id"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscarDocReadecuacion})
        Me.ToolStrip1.Location = New System.Drawing.Point(321, 8)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(98, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.TabStop = True
        '
        'tsbBuscarDocReadecuacion
        '
        Me.tsbBuscarDocReadecuacion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tsbBuscarDocReadecuacion.ForeColor = System.Drawing.Color.Black
        Me.tsbBuscarDocReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.consult
        Me.tsbBuscarDocReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarDocReadecuacion.Name = "tsbBuscarDocReadecuacion"
        Me.tsbBuscarDocReadecuacion.Size = New System.Drawing.Size(86, 22)
        Me.tsbBuscarDocReadecuacion.Text = "Buscar Doc"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 13)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta7.TabIndex = 323
        Me.Etiqueta7.Text = "Tipo Doc.:"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(433, 12)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta5.TabIndex = 324
        Me.Etiqueta5.Text = "Serie:"
        '
        'txtNumeroReadecuacion
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroReadecuacion.Appearance = Appearance13
        Me.txtNumeroReadecuacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroReadecuacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNumeroReadecuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroReadecuacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroReadecuacion.Location = New System.Drawing.Point(588, 9)
        Me.txtNumeroReadecuacion.MaxLength = 15
        Me.txtNumeroReadecuacion.Name = "txtNumeroReadecuacion"
        Me.txtNumeroReadecuacion.ReadOnly = True
        Me.txtNumeroReadecuacion.Size = New System.Drawing.Size(127, 21)
        Me.txtNumeroReadecuacion.TabIndex = 2
        '
        'txtSerieReadecuacion
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieReadecuacion.Appearance = Appearance14
        Me.txtSerieReadecuacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieReadecuacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtSerieReadecuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieReadecuacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieReadecuacion.Location = New System.Drawing.Point(470, 8)
        Me.txtSerieReadecuacion.MaxLength = 15
        Me.txtSerieReadecuacion.Name = "txtSerieReadecuacion"
        Me.txtSerieReadecuacion.ReadOnly = True
        Me.txtSerieReadecuacion.Size = New System.Drawing.Size(63, 21)
        Me.txtSerieReadecuacion.TabIndex = 1
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(539, 12)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta9.TabIndex = 322
        Me.Etiqueta9.Text = "Número:"
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.fecReadecuacion)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta52)
        Me.UltraGroupBox8.Controls.Add(Me.decMontoAgregarActR)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta59)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta44)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta60)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta57)
        Me.UltraGroupBox8.Controls.Add(Me.txtObservacionR)
        Me.UltraGroupBox8.Controls.Add(Me.cboMesR)
        Me.UltraGroupBox8.Controls.Add(Me.decMontoAgregarVR)
        Me.UltraGroupBox8.Controls.Add(Me.decVidaUtilAgregarR)
        Me.UltraGroupBox8.Controls.Add(Me.Etiqueta58)
        Me.UltraGroupBox8.Controls.Add(Me.AñoR)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 25)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1149, 83)
        Me.UltraGroupBox8.TabIndex = 320
        '
        'fecReadecuacion
        '
        Me.fecReadecuacion.CustomFormat = "dd/MM/yyyy"
        Me.fecReadecuacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecReadecuacion.Location = New System.Drawing.Point(61, 55)
        Me.fecReadecuacion.Name = "fecReadecuacion"
        Me.fecReadecuacion.Size = New System.Drawing.Size(87, 21)
        Me.fecReadecuacion.TabIndex = 318
        '
        'Etiqueta52
        '
        Appearance15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta52.Appearance = Appearance15
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(9, 10)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta52.TabIndex = 313
        Me.Etiqueta52.Text = "Ejercicio:"
        '
        'decMontoAgregarActR
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.decMontoAgregarActR.Appearance = Appearance16
        Me.decMontoAgregarActR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decMontoAgregarActR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoAgregarActR.ForeColor = System.Drawing.Color.Black
        Me.decMontoAgregarActR.Location = New System.Drawing.Point(294, 5)
        Me.decMontoAgregarActR.MaskInput = "{double:-9.2}"
        Me.decMontoAgregarActR.Name = "decMontoAgregarActR"
        Me.decMontoAgregarActR.NullText = "0.00"
        Me.decMontoAgregarActR.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoAgregarActR.Size = New System.Drawing.Size(90, 22)
        Me.decMontoAgregarActR.TabIndex = 3
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(398, 10)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta4.TabIndex = 317
        Me.Etiqueta4.Text = "Observación:"
        '
        'Etiqueta59
        '
        Me.Etiqueta59.AutoSize = True
        Me.Etiqueta59.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta59.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta59.Location = New System.Drawing.Point(21, 58)
        Me.Etiqueta59.Name = "Etiqueta59"
        Me.Etiqueta59.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta59.TabIndex = 295
        Me.Etiqueta59.Text = "Fecha:"
        '
        'Etiqueta44
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta44.Appearance = Appearance17
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(31, 34)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta44.TabIndex = 316
        Me.Etiqueta44.Text = "Mes:"
        '
        'Etiqueta60
        '
        Me.Etiqueta60.AutoSize = True
        Me.Etiqueta60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta60.Location = New System.Drawing.Point(163, 10)
        Me.Etiqueta60.Name = "Etiqueta60"
        Me.Etiqueta60.Size = New System.Drawing.Size(128, 15)
        Me.Etiqueta60.TabIndex = 311
        Me.Etiqueta60.Text = "Monto Agregar al Activo:"
        '
        'Etiqueta57
        '
        Me.Etiqueta57.AutoSize = True
        Me.Etiqueta57.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta57.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta57.Location = New System.Drawing.Point(198, 58)
        Me.Etiqueta57.Name = "Etiqueta57"
        Me.Etiqueta57.Size = New System.Drawing.Size(93, 15)
        Me.Etiqueta57.TabIndex = 301
        Me.Etiqueta57.Text = "Vida Útil Agregar:"
        '
        'txtObservacionR
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionR.Appearance = Appearance18
        Me.txtObservacionR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservacionR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionR.Location = New System.Drawing.Point(473, 8)
        Me.txtObservacionR.MaxLength = 500
        Me.txtObservacionR.Multiline = True
        Me.txtObservacionR.Name = "txtObservacionR"
        Me.txtObservacionR.Size = New System.Drawing.Size(313, 68)
        Me.txtObservacionR.TabIndex = 6
        '
        'cboMesR
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesR.Appearance = Appearance19
        Me.cboMesR.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMesR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMesR.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesR.Location = New System.Drawing.Point(61, 30)
        Me.cboMesR.Name = "cboMesR"
        Me.cboMesR.Size = New System.Drawing.Size(86, 21)
        Me.cboMesR.TabIndex = 1
        Me.cboMesR.ValueMember = "Id"
        '
        'decMontoAgregarVR
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.decMontoAgregarVR.Appearance = Appearance20
        Me.decMontoAgregarVR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decMontoAgregarVR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoAgregarVR.ForeColor = System.Drawing.Color.Black
        Me.decMontoAgregarVR.Location = New System.Drawing.Point(294, 29)
        Me.decMontoAgregarVR.MaskInput = "{double:-9.2}"
        Me.decMontoAgregarVR.Name = "decMontoAgregarVR"
        Me.decMontoAgregarVR.NullText = "0.00"
        Me.decMontoAgregarVR.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoAgregarVR.Size = New System.Drawing.Size(90, 22)
        Me.decMontoAgregarVR.TabIndex = 4
        '
        'decVidaUtilAgregarR
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilAgregarR.Appearance = Appearance21
        Me.decVidaUtilAgregarR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decVidaUtilAgregarR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decVidaUtilAgregarR.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilAgregarR.Location = New System.Drawing.Point(294, 54)
        Me.decVidaUtilAgregarR.MaskInput = "{double:-5.2}"
        Me.decVidaUtilAgregarR.Name = "decVidaUtilAgregarR"
        Me.decVidaUtilAgregarR.NullText = "0.00"
        Me.decVidaUtilAgregarR.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decVidaUtilAgregarR.Size = New System.Drawing.Size(90, 22)
        Me.decVidaUtilAgregarR.TabIndex = 5
        '
        'Etiqueta58
        '
        Me.Etiqueta58.AutoSize = True
        Me.Etiqueta58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta58.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta58.Location = New System.Drawing.Point(172, 33)
        Me.Etiqueta58.Name = "Etiqueta58"
        Me.Etiqueta58.Size = New System.Drawing.Size(119, 15)
        Me.Etiqueta58.TabIndex = 299
        Me.Etiqueta58.Text = "Monto Agregar al V.R.:"
        '
        'AñoR
        '
        Me.AñoR.Año = 2020
        Me.AñoR.AutoSize = True
        Me.AñoR.Controls.Add(Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781)
        Me.AñoR.Controls.Add(Me.NumeroEntero1)
        Me.AñoR.Controls.Add(Me.NumeroEntero4)
        Me.AñoR.Controls.Add(Me.NumeroEntero5)
        Me.AñoR.Controls.Add(Me.NumeroEntero6)
        Me.AñoR.Location = New System.Drawing.Point(61, 5)
        Me.AñoR.Name = "AñoR"
        Me.AñoR.Size = New System.Drawing.Size(56, 24)
        Me.AñoR.TabIndex = 0
        '
        'object_a3320913_f3cf_4a9f_9d48_683a67c44781
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Appearance = Appearance22
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.ForeColor = System.Drawing.Color.Black
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.FormatString = ""
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Location = New System.Drawing.Point(1, 0)
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.MaskInput = "nnnn"
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.MaxValue = 2020
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.MinValue = 2000
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Name = "object_a3320913_f3cf_4a9f_9d48_683a67c44781"
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.NullText = "0"
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Size = New System.Drawing.Size(52, 21)
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.TabIndex = 0
        Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781.Value = 2014
        '
        'NumeroEntero1
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance23
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2014
        '
        'NumeroEntero4
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance24
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2013
        '
        'NumeroEntero5
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance25
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2013
        '
        'NumeroEntero6
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero6.Appearance = Appearance26
        Me.NumeroEntero6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero6.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero6.FormatString = ""
        Me.NumeroEntero6.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero6.MaskInput = "nnnn"
        Me.NumeroEntero6.MaxValue = 2020
        Me.NumeroEntero6.MinValue = 2000
        Me.NumeroEntero6.Name = "NumeroEntero6"
        Me.NumeroEntero6.NullText = "0"
        Me.NumeroEntero6.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero6.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero6.TabIndex = 0
        Me.NumeroEntero6.Value = 2012
        '
        'tspMantReadecuaciones
        '
        Me.tspMantReadecuaciones.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspMantReadecuaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAceptarReadecuacion, Me.tsbCancelarReadecuacion})
        Me.tspMantReadecuaciones.Location = New System.Drawing.Point(0, 0)
        Me.tspMantReadecuaciones.Name = "tspMantReadecuaciones"
        Me.tspMantReadecuaciones.Size = New System.Drawing.Size(1149, 25)
        Me.tspMantReadecuaciones.TabIndex = 340
        '
        'tsbAceptarReadecuacion
        '
        Me.tsbAceptarReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.tsbAceptarReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptarReadecuacion.Name = "tsbAceptarReadecuacion"
        Me.tsbAceptarReadecuacion.Size = New System.Drawing.Size(68, 22)
        Me.tsbAceptarReadecuacion.Text = "Aceptar"
        '
        'tsbCancelarReadecuacion
        '
        Me.tsbCancelarReadecuacion.Image = Global.ISL.Win.My.Resources.Resources.undo_red
        Me.tsbCancelarReadecuacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelarReadecuacion.Name = "tsbCancelarReadecuacion"
        Me.tsbCancelarReadecuacion.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelarReadecuacion.Text = "Cancelar"
        '
        'utpActivosFijos
        '
        Me.utpActivosFijos.Controls.Add(Me.griLista)
        Me.utpActivosFijos.Location = New System.Drawing.Point(2, 21)
        Me.utpActivosFijos.Name = "utpActivosFijos"
        Me.utpActivosFijos.Size = New System.Drawing.Size(1157, 515)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.cmsListado
        Me.griLista.DataSource = Me.udsActivoFijo
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griLista.DisplayLayout.Appearance = Appearance27
        UltraGridColumn226.Header.VisiblePosition = 0
        UltraGridColumn227.Header.VisiblePosition = 1
        UltraGridColumn228.Header.VisiblePosition = 2
        UltraGridColumn229.Header.VisiblePosition = 3
        UltraGridColumn230.Header.VisiblePosition = 4
        UltraGridColumn231.Header.VisiblePosition = 5
        UltraGridColumn232.Header.VisiblePosition = 6
        UltraGridColumn233.Header.VisiblePosition = 7
        UltraGridColumn234.Header.VisiblePosition = 8
        UltraGridColumn235.Header.VisiblePosition = 9
        UltraGridColumn236.Header.VisiblePosition = 10
        UltraGridColumn237.Header.VisiblePosition = 11
        UltraGridColumn238.Header.VisiblePosition = 12
        UltraGridColumn239.Header.VisiblePosition = 13
        UltraGridColumn240.Header.VisiblePosition = 14
        UltraGridColumn241.Header.VisiblePosition = 15
        UltraGridColumn242.Header.VisiblePosition = 16
        UltraGridColumn243.Header.VisiblePosition = 17
        UltraGridColumn244.Header.VisiblePosition = 18
        UltraGridColumn245.Header.VisiblePosition = 19
        UltraGridColumn246.Header.VisiblePosition = 20
        UltraGridColumn247.Header.VisiblePosition = 21
        UltraGridColumn248.Header.VisiblePosition = 22
        UltraGridColumn249.Header.VisiblePosition = 23
        UltraGridColumn250.Header.VisiblePosition = 24
        UltraGridColumn251.Header.VisiblePosition = 25
        UltraGridColumn252.Header.VisiblePosition = 26
        UltraGridColumn253.Header.VisiblePosition = 27
        UltraGridColumn254.Header.VisiblePosition = 28
        UltraGridColumn255.Header.VisiblePosition = 29
        UltraGridColumn256.Header.VisiblePosition = 30
        UltraGridColumn257.Header.VisiblePosition = 31
        UltraGridColumn258.Header.VisiblePosition = 32
        UltraGridColumn259.Header.VisiblePosition = 33
        UltraGridColumn260.Header.VisiblePosition = 34
        UltraGridColumn261.Header.VisiblePosition = 35
        UltraGridColumn262.Header.VisiblePosition = 36
        UltraGridColumn262.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn263.Header.VisiblePosition = 37
        UltraGridColumn264.Header.VisiblePosition = 38
        UltraGridColumn265.Header.VisiblePosition = 39
        UltraGridColumn266.Header.VisiblePosition = 40
        UltraGridColumn267.Header.VisiblePosition = 41
        UltraGridColumn268.Header.VisiblePosition = 42
        UltraGridColumn269.Header.VisiblePosition = 43
        UltraGridColumn270.Header.VisiblePosition = 44
        UltraGridColumn271.Header.VisiblePosition = 45
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance28.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance28
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance29
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance30.BackColor2 = System.Drawing.SystemColors.Control
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance30
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1157, 515)
        Me.griLista.TabIndex = 314
        '
        'cmsListado
        '
        Me.cmsListado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemReclasificar, Me.itemBaja})
        Me.cmsListado.Name = "cmsListado"
        Me.cmsListado.Size = New System.Drawing.Size(134, 48)
        '
        'itemReclasificar
        '
        Me.itemReclasificar.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.itemReclasificar.Name = "itemReclasificar"
        Me.itemReclasificar.Size = New System.Drawing.Size(133, 22)
        Me.itemReclasificar.Text = "Reclasificar"
        Me.itemReclasificar.ToolTipText = "Reclasificar activo fijo seleccionado"
        '
        'itemBaja
        '
        Me.itemBaja.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.itemBaja.Name = "itemBaja"
        Me.itemBaja.Size = New System.Drawing.Size(133, 22)
        Me.itemBaja.Text = "Dar de Baja"
        '
        'udsActivoFijo
        '
        UltraDataColumn37.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn43.DataType = GetType(Boolean)
        UltraDataColumn44.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Double)
        UltraDataColumn53.DataType = GetType(Boolean)
        UltraDataColumn54.DataType = GetType(Boolean)
        UltraDataColumn55.DataType = GetType(Boolean)
        UltraDataColumn56.DataType = GetType(Double)
        UltraDataColumn57.DataType = GetType(Date)
        UltraDataColumn58.DataType = GetType(Integer)
        UltraDataColumn60.DataType = GetType(Double)
        UltraDataColumn61.DataType = GetType(Date)
        UltraDataColumn62.DataType = GetType(Double)
        UltraDataColumn63.DataType = GetType(Double)
        UltraDataColumn64.DataType = GetType(Double)
        UltraDataColumn65.DataType = GetType(Double)
        UltraDataColumn66.DataType = GetType(Date)
        UltraDataColumn67.DataType = GetType(Date)
        UltraDataColumn68.DataType = GetType(Boolean)
        UltraDataColumn69.DataType = GetType(Date)
        UltraDataColumn73.DataType = GetType(Boolean)
        UltraDataColumn75.DataType = GetType(Date)
        UltraDataColumn77.DataType = GetType(Date)
        Me.udsActivoFijo.Band.Columns.AddRange(New Object() {UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77})
        '
        'utpDepreciarActivos
        '
        Me.utpDepreciarActivos.Controls.Add(Me.griDepreciacionActivos)
        Me.utpDepreciarActivos.Controls.Add(Me.UltraGroupBox7)
        Me.utpDepreciarActivos.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDepreciarActivos.Name = "utpDepreciarActivos"
        Me.utpDepreciarActivos.Size = New System.Drawing.Size(1157, 515)
        '
        'griDepreciacionActivos
        '
        Me.griDepreciacionActivos.DataSource = Me.udsDepActivos
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDepreciacionActivos.DisplayLayout.Appearance = Appearance31
        UltraGridColumn63.Header.VisiblePosition = 0
        UltraGridColumn63.Width = 201
        UltraGridColumn64.Header.VisiblePosition = 1
        UltraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn65.Header.VisiblePosition = 2
        UltraGridColumn65.Width = 63
        UltraGridColumn66.Header.VisiblePosition = 3
        UltraGridColumn66.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn66.Width = 42
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn67.CellAppearance = Appearance32
        UltraGridColumn67.Format = "#,##0.00"
        UltraGridColumn67.Header.VisiblePosition = 4
        UltraGridColumn67.Width = 79
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn68.CellAppearance = Appearance33
        UltraGridColumn68.Format = "#,##0.00"
        UltraGridColumn68.Header.VisiblePosition = 5
        UltraGridColumn68.Width = 82
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn69.CellAppearance = Appearance34
        UltraGridColumn69.Format = "#,##0.00"
        UltraGridColumn69.Header.VisiblePosition = 6
        UltraGridColumn69.Width = 70
        UltraGridColumn70.Header.VisiblePosition = 7
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 8
        UltraGridColumn71.Width = 79
        UltraGridColumn72.Header.VisiblePosition = 9
        UltraGridColumn72.Width = 243
        UltraGridColumn87.Header.VisiblePosition = 16
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 10
        UltraGridColumn88.Width = 82
        UltraGridColumn110.Header.VisiblePosition = 11
        UltraGridColumn110.Width = 216
        UltraGridColumn73.Header.VisiblePosition = 12
        UltraGridColumn73.Width = 73
        UltraGridColumn74.Header.VisiblePosition = 13
        UltraGridColumn74.Width = 69
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance35
        UltraGridColumn75.Format = "#,##0.00"
        UltraGridColumn75.Header.Caption = "Depreciacion Mensual"
        UltraGridColumn75.Header.VisiblePosition = 14
        UltraGridColumn75.Width = 95
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance36
        UltraGridColumn76.Format = "#,##0.00"
        UltraGridColumn76.Header.Caption = "Depreciacion Acumulada"
        UltraGridColumn76.Header.VisiblePosition = 15
        UltraGridColumn76.Width = 113
        UltraGridColumn112.Header.VisiblePosition = 17
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 18
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 19
        UltraGridColumn114.Hidden = True
        UltraGridColumn111.Header.VisiblePosition = 20
        UltraGridColumn111.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 21
        UltraGridColumn122.Hidden = True
        UltraGridColumn131.Header.VisiblePosition = 22
        UltraGridColumn131.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 23
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 24
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 25
        UltraGridColumn31.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn87, UltraGridColumn88, UltraGridColumn110, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn111, UltraGridColumn122, UltraGridColumn131, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.griDepreciacionActivos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griDepreciacionActivos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDepreciacionActivos.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance37.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.griDepreciacionActivos.DisplayLayout.GroupByBox.Appearance = Appearance37
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDepreciacionActivos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance38
        Me.griDepreciacionActivos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDepreciacionActivos.DisplayLayout.GroupByBox.Hidden = True
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance39.BackColor2 = System.Drawing.SystemColors.Control
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDepreciacionActivos.DisplayLayout.GroupByBox.PromptAppearance = Appearance39
        Me.griDepreciacionActivos.DisplayLayout.MaxColScrollRegions = 1
        Me.griDepreciacionActivos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDepreciacionActivos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDepreciacionActivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDepreciacionActivos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDepreciacionActivos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDepreciacionActivos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDepreciacionActivos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDepreciacionActivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDepreciacionActivos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDepreciacionActivos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDepreciacionActivos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDepreciacionActivos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDepreciacionActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDepreciacionActivos.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDepreciacionActivos.Location = New System.Drawing.Point(0, 52)
        Me.griDepreciacionActivos.Name = "griDepreciacionActivos"
        Me.griDepreciacionActivos.Size = New System.Drawing.Size(1157, 463)
        Me.griDepreciacionActivos.TabIndex = 315
        '
        'udsDepActivos
        '
        UltraDataColumn79.DataType = GetType(Boolean)
        UltraDataColumn80.DataType = GetType(Date)
        UltraDataColumn81.DataType = GetType(Boolean)
        UltraDataColumn82.DataType = GetType(Double)
        UltraDataColumn83.DataType = GetType(Double)
        UltraDataColumn84.DataType = GetType(Double)
        UltraDataColumn91.DataType = GetType(Date)
        UltraDataColumn92.DataType = GetType(Date)
        UltraDataColumn93.DataType = GetType(Double)
        UltraDataColumn94.DataType = GetType(Double)
        UltraDataColumn101.DataType = GetType(Boolean)
        Me.udsDepActivos.Band.Columns.AddRange(New Object() {UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103})
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.Label2)
        Me.UltraGroupBox7.Controls.Add(Me.ColorFilaEdit)
        Me.UltraGroupBox7.Controls.Add(Me.btnValidarDepreciacion)
        Me.UltraGroupBox7.Controls.Add(Me.AñoDepActivos)
        Me.UltraGroupBox7.Controls.Add(Me.cboMesDepActivos)
        Me.UltraGroupBox7.Controls.Add(Me.Label1)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1157, 52)
        Me.UltraGroupBox7.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Celda Editada:"
        Me.Label2.Visible = False
        '
        'ColorFilaEdit
        '
        Me.ColorFilaEdit.Color = System.Drawing.Color.LightGreen
        Me.ColorFilaEdit.Location = New System.Drawing.Point(440, 16)
        Me.ColorFilaEdit.Name = "ColorFilaEdit"
        Me.ColorFilaEdit.Size = New System.Drawing.Size(46, 21)
        Me.ColorFilaEdit.TabIndex = 9
        Me.ColorFilaEdit.Text = "LightGreen"
        Me.ColorFilaEdit.Visible = False
        '
        'btnValidarDepreciacion
        '
        Me.btnValidarDepreciacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarDepreciacion.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnValidarDepreciacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValidarDepreciacion.Location = New System.Drawing.Point(211, 12)
        Me.btnValidarDepreciacion.Name = "btnValidarDepreciacion"
        Me.btnValidarDepreciacion.Size = New System.Drawing.Size(82, 29)
        Me.btnValidarDepreciacion.TabIndex = 4
        Me.btnValidarDepreciacion.Text = "Validar"
        Me.btnValidarDepreciacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidarDepreciacion.UseVisualStyleBackColor = True
        Me.btnValidarDepreciacion.Visible = False
        '
        'AñoDepActivos
        '
        Me.AñoDepActivos.Año = 2020
        Me.AñoDepActivos.AutoSize = True
        Me.AñoDepActivos.Controls.Add(Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd)
        Me.AñoDepActivos.Controls.Add(Me.NumeroEntero12)
        Me.AñoDepActivos.Controls.Add(Me.NumeroEntero13)
        Me.AñoDepActivos.Controls.Add(Me.NumeroEntero14)
        Me.AñoDepActivos.Controls.Add(Me.NumeroEntero15)
        Me.AñoDepActivos.Location = New System.Drawing.Point(62, 15)
        Me.AñoDepActivos.Name = "AñoDepActivos"
        Me.AñoDepActivos.Size = New System.Drawing.Size(56, 24)
        Me.AñoDepActivos.TabIndex = 5
        '
        'object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Appearance = Appearance40
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.ForeColor = System.Drawing.Color.Black
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.FormatString = ""
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Location = New System.Drawing.Point(1, 0)
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.MaskInput = "nnnn"
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.MaxValue = 2020
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.MinValue = 2000
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Name = "object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd"
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.NullText = "0"
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Size = New System.Drawing.Size(52, 21)
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.TabIndex = 0
        Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd.Value = 2016
        '
        'NumeroEntero12
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero12.Appearance = Appearance41
        Me.NumeroEntero12.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero12.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero12.FormatString = ""
        Me.NumeroEntero12.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero12.MaskInput = "nnnn"
        Me.NumeroEntero12.MaxValue = 2020
        Me.NumeroEntero12.MinValue = 2000
        Me.NumeroEntero12.Name = "NumeroEntero12"
        Me.NumeroEntero12.NullText = "0"
        Me.NumeroEntero12.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero12.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero12.TabIndex = 0
        Me.NumeroEntero12.Value = 2014
        '
        'NumeroEntero13
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero13.Appearance = Appearance42
        Me.NumeroEntero13.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero13.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero13.FormatString = ""
        Me.NumeroEntero13.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero13.MaskInput = "nnnn"
        Me.NumeroEntero13.MaxValue = 2020
        Me.NumeroEntero13.MinValue = 2000
        Me.NumeroEntero13.Name = "NumeroEntero13"
        Me.NumeroEntero13.NullText = "0"
        Me.NumeroEntero13.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero13.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero13.TabIndex = 0
        Me.NumeroEntero13.Value = 2013
        '
        'NumeroEntero14
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero14.Appearance = Appearance43
        Me.NumeroEntero14.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero14.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero14.FormatString = ""
        Me.NumeroEntero14.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero14.MaskInput = "nnnn"
        Me.NumeroEntero14.MaxValue = 2020
        Me.NumeroEntero14.MinValue = 2000
        Me.NumeroEntero14.Name = "NumeroEntero14"
        Me.NumeroEntero14.NullText = "0"
        Me.NumeroEntero14.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero14.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero14.TabIndex = 0
        Me.NumeroEntero14.Value = 2013
        '
        'NumeroEntero15
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero15.Appearance = Appearance44
        Me.NumeroEntero15.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero15.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero15.FormatString = ""
        Me.NumeroEntero15.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero15.MaskInput = "nnnn"
        Me.NumeroEntero15.MaxValue = 2020
        Me.NumeroEntero15.MinValue = 2000
        Me.NumeroEntero15.Name = "NumeroEntero15"
        Me.NumeroEntero15.NullText = "0"
        Me.NumeroEntero15.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero15.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero15.TabIndex = 0
        Me.NumeroEntero15.Value = 2012
        '
        'cboMesDepActivos
        '
        Appearance45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesDepActivos.Appearance = Appearance45
        Me.cboMesDepActivos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesDepActivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMesDepActivos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMesDepActivos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesDepActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesDepActivos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesDepActivos.Location = New System.Drawing.Point(125, 16)
        Me.cboMesDepActivos.Name = "cboMesDepActivos"
        Me.cboMesDepActivos.Size = New System.Drawing.Size(72, 21)
        Me.cboMesDepActivos.TabIndex = 3
        Me.cboMesDepActivos.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodo:"
        '
        'utpListaDAF
        '
        Me.utpListaDAF.Controls.Add(Me.griAsiento)
        Me.utpListaDAF.Controls.Add(Me.UltraExpandableGroupBox17)
        Me.utpListaDAF.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpListaDAF.Name = "utpListaDAF"
        Me.utpListaDAF.Size = New System.Drawing.Size(1157, 515)
        '
        'griAsiento
        '
        Me.griAsiento.DataSource = Me.udsAsiento
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Appearance46.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAsiento.DisplayLayout.Appearance = Appearance46
        Appearance47.Image = 6
        Appearance47.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance47.TextHAlignAsString = "Left"
        UltraGridColumn89.CellAppearance = Appearance47
        Appearance48.Image = 8
        Appearance48.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn89.CellButtonAppearance = Appearance48
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn91.Header.VisiblePosition = 5
        UltraGridColumn91.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 95
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 491
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Moneda"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 78
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance49
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Width = 63
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance50
        UltraGridColumn8.Format = "#,##0.00"
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Width = 71
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance51
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Width = 73
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 15
        UltraGridColumn103.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 16
        UltraGridColumn105.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 17
        UltraGridColumn14.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn91, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn103, UltraGridColumn105, UltraGridColumn14})
        Me.griAsiento.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griAsiento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAsiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAsiento.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance52.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.griAsiento.DisplayLayout.GroupByBox.Appearance = Appearance52
        Appearance53.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAsiento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance53
        Me.griAsiento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAsiento.DisplayLayout.GroupByBox.Hidden = True
        Appearance54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance54.BackColor2 = System.Drawing.SystemColors.Control
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance54.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAsiento.DisplayLayout.GroupByBox.PromptAppearance = Appearance54
        Me.griAsiento.DisplayLayout.MaxColScrollRegions = 1
        Me.griAsiento.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAsiento.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAsiento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAsiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAsiento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAsiento.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAsiento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAsiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAsiento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAsiento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAsiento.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAsiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAsiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAsiento.Location = New System.Drawing.Point(0, 63)
        Me.griAsiento.Name = "griAsiento"
        Me.griAsiento.Size = New System.Drawing.Size(1157, 452)
        Me.griAsiento.TabIndex = 340
        Me.griAsiento.Text = "DEPRECIACION DE ACTIVOS FIJOS POR PERIODO"
        '
        'udsAsiento
        '
        UltraDataColumn108.DataType = GetType(Date)
        UltraDataColumn112.DataType = GetType(Double)
        UltraDataColumn113.DataType = GetType(Double)
        UltraDataColumn114.DataType = GetType(Double)
        UltraDataColumn119.DataType = GetType(Date)
        UltraDataColumn120.DataType = GetType(Boolean)
        UltraDataColumn121.DataType = GetType(Integer)
        Me.udsAsiento.Band.Columns.AddRange(New Object() {UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121})
        '
        'UltraExpandableGroupBox17
        '
        Appearance55.BackColor = System.Drawing.Color.White
        Appearance55.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox17.ContentAreaAppearance = Appearance55
        Me.UltraExpandableGroupBox17.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox17.ExpandedSize = New System.Drawing.Size(1157, 63)
        Me.UltraExpandableGroupBox17.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox17.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox17.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox17.Name = "UltraExpandableGroupBox17"
        Me.UltraExpandableGroupBox17.Size = New System.Drawing.Size(1157, 63)
        Me.UltraExpandableGroupBox17.TabIndex = 339
        Me.UltraExpandableGroupBox17.Text = "Filtro Asientos Depreciacion Activos Fijos"
        Me.UltraExpandableGroupBox17.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.btnExtornarAsiento)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.btnEliminarDepreciaciones)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.UltraExpandableGroupBox11)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.AñoListaDAF)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.Etiqueta93)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.cboMesListaDAF)
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.Etiqueta94)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(1151, 40)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'btnExtornarAsiento
        '
        Me.btnExtornarAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtornarAsiento.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.btnExtornarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtornarAsiento.Location = New System.Drawing.Point(244, 5)
        Me.btnExtornarAsiento.Name = "btnExtornarAsiento"
        Me.btnExtornarAsiento.Size = New System.Drawing.Size(124, 30)
        Me.btnExtornarAsiento.TabIndex = 2
        Me.btnExtornarAsiento.Text = "Extornar Asiento"
        Me.btnExtornarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExtornarAsiento.UseVisualStyleBackColor = True
        '
        'btnEliminarDepreciaciones
        '
        Appearance56.Image = 5
        Appearance56.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btnEliminarDepreciaciones.Appearance = Appearance56
        Me.btnEliminarDepreciaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDepreciaciones.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEliminarDepreciaciones.Location = New System.Drawing.Point(602, 3)
        Me.btnEliminarDepreciaciones.Name = "btnEliminarDepreciaciones"
        Me.btnEliminarDepreciaciones.Size = New System.Drawing.Size(129, 25)
        Me.btnEliminarDepreciaciones.TabIndex = 360
        Me.btnEliminarDepreciaciones.Text = "Extornar Asiento"
        UltraToolTipInfo1.ToolTipText = "Guardar Depreciacion de Activo Fijos"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnEliminarDepreciaciones, UltraToolTipInfo1)
        Me.btnEliminarDepreciaciones.Visible = False
        '
        'UltraExpandableGroupBox11
        '
        Appearance185.BackColor = System.Drawing.Color.White
        Appearance185.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox11.ContentAreaAppearance = Appearance185
        Me.UltraExpandableGroupBox11.Controls.Add(Me.UltraExpandableGroupBoxPanel14)
        Me.UltraExpandableGroupBox11.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox11.ExpandedSize = New System.Drawing.Size(271, 40)
        Me.UltraExpandableGroupBox11.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox11.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox11.Location = New System.Drawing.Point(880, 0)
        Me.UltraExpandableGroupBox11.Name = "UltraExpandableGroupBox11"
        Me.UltraExpandableGroupBox11.Size = New System.Drawing.Size(271, 40)
        Me.UltraExpandableGroupBox11.TabIndex = 3
        Me.UltraExpandableGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.UltraExpandableGroupBox11.Visible = False
        '
        'UltraExpandableGroupBoxPanel14
        '
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.btnConsultarAsiento)
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.txtNroAsiento)
        Me.UltraExpandableGroupBoxPanel14.Controls.Add(Me.verNroAsiento)
        Me.UltraExpandableGroupBoxPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel14.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel14.Name = "UltraExpandableGroupBoxPanel14"
        Me.UltraExpandableGroupBoxPanel14.Size = New System.Drawing.Size(250, 34)
        Me.UltraExpandableGroupBoxPanel14.TabIndex = 0
        '
        'btnConsultarAsiento
        '
        Appearance186.Image = "266.png"
        Appearance186.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance186.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnConsultarAsiento.Appearance = Appearance186
        Me.btnConsultarAsiento.Enabled = False
        Me.btnConsultarAsiento.ImageList = Me.imagenes
        Me.btnConsultarAsiento.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultarAsiento.Location = New System.Drawing.Point(193, 1)
        Me.btnConsultarAsiento.Name = "btnConsultarAsiento"
        Me.btnConsultarAsiento.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultarAsiento.TabIndex = 2
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
        '
        'txtNroAsiento
        '
        Appearance187.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroAsiento.Appearance = Appearance187
        Me.txtNroAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNroAsiento.Enabled = False
        Me.txtNroAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroAsiento.Location = New System.Drawing.Point(87, 6)
        Me.txtNroAsiento.MaxLength = 10
        Me.txtNroAsiento.Name = "txtNroAsiento"
        Me.txtNroAsiento.Size = New System.Drawing.Size(100, 21)
        Me.txtNroAsiento.TabIndex = 1
        '
        'verNroAsiento
        '
        Me.verNroAsiento.AutoSize = True
        Me.verNroAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verNroAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verNroAsiento.Location = New System.Drawing.Point(3, 8)
        Me.verNroAsiento.Name = "verNroAsiento"
        Me.verNroAsiento.Size = New System.Drawing.Size(78, 17)
        Me.verNroAsiento.TabIndex = 0
        Me.verNroAsiento.Text = "Nro Asiento"
        '
        'AñoListaDAF
        '
        Me.AñoListaDAF.Año = 2020
        Me.AñoListaDAF.AutoSize = True
        Me.AñoListaDAF.Location = New System.Drawing.Point(57, 10)
        Me.AñoListaDAF.Name = "AñoListaDAF"
        Me.AñoListaDAF.Size = New System.Drawing.Size(65, 24)
        Me.AñoListaDAF.TabIndex = 0
        '
        'Etiqueta93
        '
        Me.Etiqueta93.AutoSize = True
        Me.Etiqueta93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta93.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta93.Location = New System.Drawing.Point(2, 14)
        Me.Etiqueta93.Name = "Etiqueta93"
        Me.Etiqueta93.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta93.TabIndex = 317
        Me.Etiqueta93.Text = "Ejercicio:"
        '
        'cboMesListaDAF
        '
        Appearance188.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesListaDAF.Appearance = Appearance188
        Me.cboMesListaDAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesListaDAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesListaDAF.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesListaDAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesListaDAF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesListaDAF.Location = New System.Drawing.Point(160, 9)
        Me.cboMesListaDAF.Name = "cboMesListaDAF"
        Me.cboMesListaDAF.Size = New System.Drawing.Size(55, 21)
        Me.cboMesListaDAF.TabIndex = 1
        Me.cboMesListaDAF.ValueMember = "Id"
        '
        'Etiqueta94
        '
        Me.Etiqueta94.AutoSize = True
        Me.Etiqueta94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta94.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta94.Location = New System.Drawing.Point(127, 13)
        Me.Etiqueta94.Name = "Etiqueta94"
        Me.Etiqueta94.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta94.TabIndex = 320
        Me.Etiqueta94.Text = "Mes:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl3.Controls.Add(Me.uegbDatosBaja)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1159, 369)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None
        Me.UltraGroupBox2.Controls.Add(Me.rbtSituacionAFecha)
        Me.UltraGroupBox2.Controls.Add(Me.ugbSinDocumento)
        Me.UltraGroupBox2.Controls.Add(Me.rbtInformacionCompra)
        Me.UltraGroupBox2.Controls.Add(Me.ugbConDoc)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(403, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(756, 302)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "  "
        '
        'rbtSituacionAFecha
        '
        Me.rbtSituacionAFecha.AutoSize = True
        Me.rbtSituacionAFecha.Location = New System.Drawing.Point(369, 5)
        Me.rbtSituacionAFecha.Name = "rbtSituacionAFecha"
        Me.rbtSituacionAFecha.Size = New System.Drawing.Size(172, 17)
        Me.rbtSituacionAFecha.TabIndex = 1
        Me.rbtSituacionAFecha.Text = "Situación contable a una fecha"
        Me.rbtSituacionAFecha.UseVisualStyleBackColor = True
        '
        'ugbSinDocumento
        '
        Me.ugbSinDocumento.Controls.Add(Me.uneCosto2012)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta34)
        Me.ugbSinDocumento.Controls.Add(Me.uneDep2015)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta22)
        Me.ugbSinDocumento.Controls.Add(Me.uneDep2014)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta19)
        Me.ugbSinDocumento.Controls.Add(Me.fecSituacionCtble)
        Me.ugbSinDocumento.Controls.Add(Me.decValorLibroSC)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta37)
        Me.ugbSinDocumento.Controls.Add(Me.decDepreciacionAcumuladaSC)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta36)
        Me.ugbSinDocumento.Controls.Add(Me.decVidaUtilRemanenteSC)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta39)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta40)
        Me.ugbSinDocumento.Controls.Add(Me.decRevalorizacionAcumuladaSC)
        Me.ugbSinDocumento.Controls.Add(Me.Etiqueta38)
        Me.ugbSinDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugbSinDocumento.Location = New System.Drawing.Point(356, 17)
        Me.ugbSinDocumento.Name = "ugbSinDocumento"
        Me.ugbSinDocumento.Size = New System.Drawing.Size(400, 285)
        Me.ugbSinDocumento.TabIndex = 1
        Me.ugbSinDocumento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'uneCosto2012
        '
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.uneCosto2012.Appearance = Appearance59
        Me.uneCosto2012.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.uneCosto2012.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCosto2012.ForeColor = System.Drawing.Color.Black
        Me.uneCosto2012.Location = New System.Drawing.Point(152, 62)
        Me.uneCosto2012.MaskInput = "{double:9.2}"
        Me.uneCosto2012.Name = "uneCosto2012"
        Me.uneCosto2012.NullText = "0.00"
        Me.uneCosto2012.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCosto2012.Size = New System.Drawing.Size(90, 22)
        Me.uneCosto2012.TabIndex = 2
        '
        'Etiqueta34
        '
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(69, 66)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta34.TabIndex = 323
        Me.Etiqueta34.Text = "Costo al Inicio:"
        '
        'uneDep2015
        '
        Appearance60.ForeColor = System.Drawing.Color.Black
        Me.uneDep2015.Appearance = Appearance60
        Me.uneDep2015.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.uneDep2015.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDep2015.ForeColor = System.Drawing.Color.Black
        Me.uneDep2015.Location = New System.Drawing.Point(152, 36)
        Me.uneDep2015.MaskInput = "{double:9.2}"
        Me.uneDep2015.Name = "uneDep2015"
        Me.uneDep2015.NullText = "0.00"
        Me.uneDep2015.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneDep2015.Size = New System.Drawing.Size(90, 22)
        Me.uneDep2015.TabIndex = 1
        '
        'Etiqueta22
        '
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(67, 40)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(83, 15)
        Me.Etiqueta22.TabIndex = 321
        Me.Etiqueta22.Text = "Deprec. Añor 2:"
        '
        'uneDep2014
        '
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.uneDep2014.Appearance = Appearance61
        Me.uneDep2014.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.uneDep2014.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDep2014.ForeColor = System.Drawing.Color.Black
        Me.uneDep2014.Location = New System.Drawing.Point(152, 10)
        Me.uneDep2014.MaskInput = "{double:9.2}"
        Me.uneDep2014.Name = "uneDep2014"
        Me.uneDep2014.NullText = "0.00"
        Me.uneDep2014.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneDep2014.Size = New System.Drawing.Size(90, 22)
        Me.uneDep2014.TabIndex = 0
        '
        'Etiqueta19
        '
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(69, 14)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta19.TabIndex = 319
        Me.Etiqueta19.Text = "Deprec. Año 1:"
        '
        'fecSituacionCtble
        '
        Me.fecSituacionCtble.CustomFormat = "dd/MM/yyyy"
        Me.fecSituacionCtble.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecSituacionCtble.Location = New System.Drawing.Point(152, 92)
        Me.fecSituacionCtble.Name = "fecSituacionCtble"
        Me.fecSituacionCtble.Size = New System.Drawing.Size(91, 21)
        Me.fecSituacionCtble.TabIndex = 3
        '
        'decValorLibroSC
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.decValorLibroSC.Appearance = Appearance62
        Me.decValorLibroSC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decValorLibroSC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorLibroSC.ForeColor = System.Drawing.Color.Black
        Me.decValorLibroSC.Location = New System.Drawing.Point(152, 117)
        Me.decValorLibroSC.MaskInput = "{double:9.2}"
        Me.decValorLibroSC.Name = "decValorLibroSC"
        Me.decValorLibroSC.NullText = "0.00"
        Me.decValorLibroSC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorLibroSC.Size = New System.Drawing.Size(90, 22)
        Me.decValorLibroSC.TabIndex = 4
        '
        'Etiqueta37
        '
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta37.Location = New System.Drawing.Point(83, 122)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta37.TabIndex = 311
        Me.Etiqueta37.Text = "Valor Libro:"
        '
        'decDepreciacionAcumuladaSC
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.decDepreciacionAcumuladaSC.Appearance = Appearance63
        Me.decDepreciacionAcumuladaSC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decDepreciacionAcumuladaSC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDepreciacionAcumuladaSC.ForeColor = System.Drawing.Color.Black
        Me.decDepreciacionAcumuladaSC.Location = New System.Drawing.Point(152, 143)
        Me.decDepreciacionAcumuladaSC.MaskInput = "{double:9.2}"
        Me.decDepreciacionAcumuladaSC.Name = "decDepreciacionAcumuladaSC"
        Me.decDepreciacionAcumuladaSC.NullText = "0.00"
        Me.decDepreciacionAcumuladaSC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDepreciacionAcumuladaSC.Size = New System.Drawing.Size(90, 22)
        Me.decDepreciacionAcumuladaSC.TabIndex = 5
        '
        'Etiqueta36
        '
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(127, 95)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(18, 15)
        Me.Etiqueta36.TabIndex = 297
        Me.Etiqueta36.Text = "Al:"
        '
        'decVidaUtilRemanenteSC
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilRemanenteSC.Appearance = Appearance64
        Me.decVidaUtilRemanenteSC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decVidaUtilRemanenteSC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decVidaUtilRemanenteSC.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilRemanenteSC.Location = New System.Drawing.Point(152, 169)
        Me.decVidaUtilRemanenteSC.MaskInput = "{double:9.2}"
        Me.decVidaUtilRemanenteSC.Name = "decVidaUtilRemanenteSC"
        Me.decVidaUtilRemanenteSC.NullText = "0.00"
        Me.decVidaUtilRemanenteSC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decVidaUtilRemanenteSC.Size = New System.Drawing.Size(90, 22)
        Me.decVidaUtilRemanenteSC.TabIndex = 6
        '
        'Etiqueta39
        '
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta39.Location = New System.Drawing.Point(15, 147)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(130, 15)
        Me.Etiqueta39.TabIndex = 315
        Me.Etiqueta39.Text = "Depreciación acumulada:"
        '
        'Etiqueta40
        '
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta40.Location = New System.Drawing.Point(35, 173)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(110, 15)
        Me.Etiqueta40.TabIndex = 317
        Me.Etiqueta40.Text = "Vida Útil Remanente:"
        '
        'decRevalorizacionAcumuladaSC
        '
        Appearance65.ForeColor = System.Drawing.Color.Black
        Me.decRevalorizacionAcumuladaSC.Appearance = Appearance65
        Me.decRevalorizacionAcumuladaSC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decRevalorizacionAcumuladaSC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decRevalorizacionAcumuladaSC.ForeColor = System.Drawing.Color.Black
        Me.decRevalorizacionAcumuladaSC.Location = New System.Drawing.Point(152, 235)
        Me.decRevalorizacionAcumuladaSC.MaskInput = "{double:9.2}"
        Me.decRevalorizacionAcumuladaSC.Name = "decRevalorizacionAcumuladaSC"
        Me.decRevalorizacionAcumuladaSC.NullText = "0.00"
        Me.decRevalorizacionAcumuladaSC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decRevalorizacionAcumuladaSC.Size = New System.Drawing.Size(90, 22)
        Me.decRevalorizacionAcumuladaSC.TabIndex = 7
        Me.decRevalorizacionAcumuladaSC.Visible = False
        '
        'Etiqueta38
        '
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta38.Location = New System.Drawing.Point(11, 240)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(137, 15)
        Me.Etiqueta38.TabIndex = 313
        Me.Etiqueta38.Text = "Revalorización acumulada:"
        Me.Etiqueta38.Visible = False
        '
        'rbtInformacionCompra
        '
        Me.rbtInformacionCompra.AutoSize = True
        Me.rbtInformacionCompra.Checked = True
        Me.rbtInformacionCompra.Location = New System.Drawing.Point(12, 5)
        Me.rbtInformacionCompra.Name = "rbtInformacionCompra"
        Me.rbtInformacionCompra.Size = New System.Drawing.Size(137, 17)
        Me.rbtInformacionCompra.TabIndex = 0
        Me.rbtInformacionCompra.TabStop = True
        Me.rbtInformacionCompra.Text = "Información de Compra"
        Me.rbtInformacionCompra.UseVisualStyleBackColor = True
        '
        'ugbConDoc
        '
        Me.ugbConDoc.Controls.Add(Me.uneValorCompra)
        Me.ugbConDoc.Controls.Add(Me.txtTipoDocumento)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta18)
        Me.ugbConDoc.Controls.Add(Me.txtSerie)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta8)
        Me.ugbConDoc.Controls.Add(Me.txtProveedor)
        Me.ugbConDoc.Controls.Add(Me.fecCompraIC)
        Me.ugbConDoc.Controls.Add(Me.btnBuscarDoc)
        Me.ugbConDoc.Controls.Add(Me.opcTipoDocumento)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta29)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta30)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta31)
        Me.ugbConDoc.Controls.Add(Me.Etiqueta32)
        Me.ugbConDoc.Controls.Add(Me.etiProveedor)
        Me.ugbConDoc.Controls.Add(Me.txtNroDocumentoIC)
        Me.ugbConDoc.Controls.Add(Me.decVidaUtilIC)
        Me.ugbConDoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.ugbConDoc.Location = New System.Drawing.Point(0, 17)
        Me.ugbConDoc.Name = "ugbConDoc"
        Me.ugbConDoc.Size = New System.Drawing.Size(356, 285)
        Me.ugbConDoc.TabIndex = 0
        Me.ugbConDoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'uneValorCompra
        '
        Me.uneValorCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.uneValorCompra.Location = New System.Drawing.Point(97, 141)
        Me.uneValorCompra.MaskInput = "{double:9.2}"
        Me.uneValorCompra.Name = "uneValorCompra"
        Me.uneValorCompra.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneValorCompra.ReadOnly = True
        Me.uneValorCompra.Size = New System.Drawing.Size(90, 22)
        Me.uneValorCompra.TabIndex = 7
        '
        'txtTipoDocumento
        '
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDocumento.Appearance = Appearance66
        Me.txtTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDocumento.Location = New System.Drawing.Point(97, 64)
        Me.txtTipoDocumento.MaxLength = 50
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(251, 22)
        Me.txtTipoDocumento.TabIndex = 3
        '
        'Etiqueta18
        '
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(62, 119)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta18.TabIndex = 315
        Me.Etiqueta18.Text = "Serie:"
        '
        'txtSerie
        '
        Appearance67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerie.Appearance = Appearance67
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerie.Location = New System.Drawing.Point(97, 115)
        Me.txtSerie.MaxLength = 15
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(63, 22)
        Me.txtSerie.TabIndex = 5
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(39, 68)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta8.TabIndex = 313
        Me.Etiqueta8.Text = "Tipo Doc.:"
        '
        'txtProveedor
        '
        Appearance68.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Appearance = Appearance68
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtProveedor.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProveedor.Location = New System.Drawing.Point(97, 89)
        Me.txtProveedor.MaxLength = 50
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(251, 22)
        Me.txtProveedor.TabIndex = 4
        '
        'fecCompraIC
        '
        Me.fecCompraIC.CustomFormat = "dd/MM/yyyy"
        Me.fecCompraIC.Enabled = False
        Me.fecCompraIC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecCompraIC.Location = New System.Drawing.Point(97, 39)
        Me.fecCompraIC.Name = "fecCompraIC"
        Me.fecCompraIC.Size = New System.Drawing.Size(87, 21)
        Me.fecCompraIC.TabIndex = 2
        '
        'btnBuscarDoc
        '
        Me.btnBuscarDoc.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarDoc.BackgroundImage = Global.ISL.Win.My.Resources.Resources.kdvi
        Me.btnBuscarDoc.Location = New System.Drawing.Point(310, 5)
        Me.btnBuscarDoc.Name = "btnBuscarDoc"
        Me.btnBuscarDoc.Size = New System.Drawing.Size(36, 35)
        Me.btnBuscarDoc.TabIndex = 1
        Me.btnBuscarDoc.UseVisualStyleBackColor = False
        '
        'opcTipoDocumento
        '
        Me.opcTipoDocumento.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcTipoDocumento.CheckedIndex = 0
        ValueListItem16.DataValue = "Default Item"
        ValueListItem16.DisplayText = "Documento"
        ValueListItem17.DataValue = "ValueListItem1"
        ValueListItem17.DisplayText = "Obligación"
        ValueListItem1.DataValue = "ValueListItem2"
        ValueListItem1.DisplayText = "Sin Documento"
        Me.opcTipoDocumento.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem16, ValueListItem17, ValueListItem1})
        Me.opcTipoDocumento.ItemSpacingHorizontal = 15
        Me.opcTipoDocumento.Location = New System.Drawing.Point(22, 14)
        Me.opcTipoDocumento.Name = "opcTipoDocumento"
        Me.opcTipoDocumento.Size = New System.Drawing.Size(281, 20)
        Me.opcTipoDocumento.TabIndex = 0
        Me.opcTipoDocumento.Text = "Documento"
        '
        'Etiqueta29
        '
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(3, 42)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(92, 15)
        Me.Etiqueta29.TabIndex = 295
        Me.Etiqueta29.Text = "F. Emisión/Venc.:"
        '
        'Etiqueta30
        '
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(7, 174)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta30.TabIndex = 299
        Me.Etiqueta30.Text = "Vida Útil (Años):"
        '
        'Etiqueta31
        '
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(5, 146)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta31.TabIndex = 301
        Me.Etiqueta31.Text = "Valor Activo (S/):"
        '
        'Etiqueta32
        '
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta32.Location = New System.Drawing.Point(190, 119)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta32.TabIndex = 303
        Me.Etiqueta32.Text = "Número:"
        '
        'etiProveedor
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.etiProveedor.Appearance = Appearance69
        Me.etiProveedor.AutoSize = True
        Me.etiProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiProveedor.ForeColor = System.Drawing.Color.Black
        Me.etiProveedor.Location = New System.Drawing.Point(36, 93)
        Me.etiProveedor.Name = "etiProveedor"
        Me.etiProveedor.Size = New System.Drawing.Size(59, 15)
        Me.etiProveedor.TabIndex = 312
        Me.etiProveedor.Text = "Proveedor:"
        '
        'txtNroDocumentoIC
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumentoIC.Appearance = Appearance70
        Me.txtNroDocumentoIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumentoIC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNroDocumentoIC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoIC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDocumentoIC.Location = New System.Drawing.Point(238, 116)
        Me.txtNroDocumentoIC.MaxLength = 15
        Me.txtNroDocumentoIC.Name = "txtNroDocumentoIC"
        Me.txtNroDocumentoIC.ReadOnly = True
        Me.txtNroDocumentoIC.Size = New System.Drawing.Size(110, 22)
        Me.txtNroDocumentoIC.TabIndex = 6
        '
        'decVidaUtilIC
        '
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilIC.Appearance = Appearance71
        Me.decVidaUtilIC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decVidaUtilIC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decVidaUtilIC.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilIC.Location = New System.Drawing.Point(97, 170)
        Me.decVidaUtilIC.MaskInput = "{double:6.2}"
        Me.decVidaUtilIC.Name = "decVidaUtilIC"
        Me.decVidaUtilIC.NullText = "0.00"
        Me.decVidaUtilIC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decVidaUtilIC.Size = New System.Drawing.Size(90, 22)
        Me.decVidaUtilIC.TabIndex = 10
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta72)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta71)
        Me.UltraGroupBox1.Controls.Add(Me.txtNroAutorizacion)
        Me.UltraGroupBox1.Controls.Add(Me.cboMetodo)
        Me.UltraGroupBox1.Controls.Add(Me.numPorcentaje)
        Me.UltraGroupBox1.Controls.Add(Me.cboDepreciacion)
        Me.UltraGroupBox1.Controls.Add(Me.cboCCUbicaciones)
        Me.UltraGroupBox1.Controls.Add(Me.cbgCentroCostoAF)
        Me.UltraGroupBox1.Controls.Add(Me.cboSubGrupoAF)
        Me.UltraGroupBox1.Controls.Add(Me.uneValorResidual)
        Me.UltraGroupBox1.Controls.Add(Me.cboGrupoAF)
        Me.UltraGroupBox1.Controls.Add(Me.cboConceptoIngresoAF)
        Me.UltraGroupBox1.Controls.Add(Me.chkDepreciable)
        Me.UltraGroupBox1.Controls.Add(Me.fecActivacion)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta41)
        Me.UltraGroupBox1.Controls.Add(Me.fecIngreso)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta15)
        Me.UltraGroupBox1.Controls.Add(Me.verIndFecActivacion)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta14)
        Me.UltraGroupBox1.Controls.Add(Me.chkMaterial)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta25)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta13)
        Me.UltraGroupBox1.Controls.Add(Me.cbgMaterial)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta10)
        Me.UltraGroupBox1.Controls.Add(Me.numCantidadAF)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta16)
        Me.UltraGroupBox1.Controls.Add(Me.chkConjuntoAF)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(403, 302)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'Etiqueta72
        '
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta72.Appearance = Appearance72
        Me.Etiqueta72.AutoSize = True
        Me.Etiqueta72.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta72.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta72.Location = New System.Drawing.Point(29, 283)
        Me.Etiqueta72.Name = "Etiqueta72"
        Me.Etiqueta72.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta72.TabIndex = 309
        Me.Etiqueta72.Text = "Nro. Autoriza:"
        '
        'Etiqueta71
        '
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta71.Appearance = Appearance73
        Me.Etiqueta71.AutoSize = True
        Me.Etiqueta71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta71.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta71.Location = New System.Drawing.Point(56, 255)
        Me.Etiqueta71.Name = "Etiqueta71"
        Me.Etiqueta71.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta71.TabIndex = 308
        Me.Etiqueta71.Text = "Método:"
        '
        'txtNroAutorizacion
        '
        Me.txtNroAutorizacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNroAutorizacion.Location = New System.Drawing.Point(106, 280)
        Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
        Me.txtNroAutorizacion.Size = New System.Drawing.Size(226, 22)
        Me.txtNroAutorizacion.TabIndex = 307
        '
        'cboMetodo
        '
        Me.cboMetodo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboMetodo.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboMetodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMetodo.DisplayMember = "Nombre"
        Me.cboMetodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMetodo.DropDownListWidth = -1
        Me.cboMetodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMetodo.Location = New System.Drawing.Point(106, 252)
        Me.cboMetodo.Name = "cboMetodo"
        Me.cboMetodo.Size = New System.Drawing.Size(282, 22)
        Me.cboMetodo.TabIndex = 306
        Me.cboMetodo.ValueMember = "Id"
        '
        'numPorcentaje
        '
        Me.numPorcentaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.numPorcentaje.FormatString = "#,##0.00"
        Me.numPorcentaje.Location = New System.Drawing.Point(338, 224)
        Me.numPorcentaje.MaskInput = "{double:9.2}"
        Me.numPorcentaje.Name = "numPorcentaje"
        Me.numPorcentaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPorcentaje.ReadOnly = True
        Me.numPorcentaje.Size = New System.Drawing.Size(50, 22)
        Me.numPorcentaje.TabIndex = 305
        '
        'cboDepreciacion
        '
        Me.cboDepreciacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboDepreciacion.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboDepreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepreciacion.DisplayMember = "Nombre"
        Me.cboDepreciacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboDepreciacion.DropDownListWidth = -1
        Me.cboDepreciacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepreciacion.Location = New System.Drawing.Point(105, 224)
        Me.cboDepreciacion.Name = "cboDepreciacion"
        Me.cboDepreciacion.Size = New System.Drawing.Size(227, 22)
        Me.cboDepreciacion.TabIndex = 304
        Me.cboDepreciacion.ValueMember = "Id"
        '
        'cboCCUbicaciones
        '
        Me.cboCCUbicaciones.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCCUbicaciones.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboCCUbicaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCCUbicaciones.DisplayMember = "Nombre"
        Me.cboCCUbicaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCCUbicaciones.DropDownListWidth = -1
        Me.cboCCUbicaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCCUbicaciones.Location = New System.Drawing.Point(105, 141)
        Me.cboCCUbicaciones.Name = "cboCCUbicaciones"
        Me.cboCCUbicaciones.Size = New System.Drawing.Size(283, 22)
        Me.cboCCUbicaciones.TabIndex = 7
        Me.cboCCUbicaciones.ValueMember = "Id"
        '
        'cbgCentroCostoAF
        '
        Me.cbgCentroCostoAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cbgCentroCostoAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cbgCentroCostoAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbgCentroCostoAF.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgCentroCostoAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cbgCentroCostoAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgCentroCostoAF.Location = New System.Drawing.Point(105, 114)
        Me.cbgCentroCostoAF.Name = "cbgCentroCostoAF"
        Me.cbgCentroCostoAF.Size = New System.Drawing.Size(283, 23)
        Me.cbgCentroCostoAF.TabIndex = 6
        '
        'cboSubGrupoAF
        '
        Me.cboSubGrupoAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboSubGrupoAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboSubGrupoAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSubGrupoAF.DisplayMember = "Nombre"
        Me.cboSubGrupoAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboSubGrupoAF.DropDownListWidth = -1
        Me.cboSubGrupoAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubGrupoAF.Location = New System.Drawing.Point(105, 88)
        Me.cboSubGrupoAF.Name = "cboSubGrupoAF"
        Me.cboSubGrupoAF.Size = New System.Drawing.Size(283, 22)
        Me.cboSubGrupoAF.TabIndex = 5
        Me.cboSubGrupoAF.ValueMember = "Id"
        '
        'uneValorResidual
        '
        Me.uneValorResidual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.uneValorResidual.FormatString = "#,##0.00"
        Me.uneValorResidual.Location = New System.Drawing.Point(105, 196)
        Me.uneValorResidual.MaskInput = "{double:9.2}"
        Me.uneValorResidual.Name = "uneValorResidual"
        Me.uneValorResidual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneValorResidual.Size = New System.Drawing.Size(88, 22)
        Me.uneValorResidual.TabIndex = 11
        '
        'cboGrupoAF
        '
        Me.cboGrupoAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboGrupoAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboGrupoAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoAF.DisplayMember = "Nombre"
        Me.cboGrupoAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboGrupoAF.DropDownListWidth = -1
        Me.cboGrupoAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupoAF.Location = New System.Drawing.Point(105, 62)
        Me.cboGrupoAF.Name = "cboGrupoAF"
        Me.cboGrupoAF.Size = New System.Drawing.Size(283, 22)
        Me.cboGrupoAF.TabIndex = 4
        Me.cboGrupoAF.ValueMember = "Id"
        '
        'cboConceptoIngresoAF
        '
        Me.cboConceptoIngresoAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboConceptoIngresoAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboConceptoIngresoAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConceptoIngresoAF.DisplayMember = "Nombre"
        Me.cboConceptoIngresoAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboConceptoIngresoAF.DropDownListWidth = -1
        Me.cboConceptoIngresoAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptoIngresoAF.Location = New System.Drawing.Point(105, 36)
        Me.cboConceptoIngresoAF.Name = "cboConceptoIngresoAF"
        Me.cboConceptoIngresoAF.Size = New System.Drawing.Size(283, 22)
        Me.cboConceptoIngresoAF.TabIndex = 3
        Me.cboConceptoIngresoAF.ValueMember = "Id"
        '
        'chkDepreciable
        '
        Me.chkDepreciable.AutoSize = True
        Me.chkDepreciable.BackColor = System.Drawing.Color.Transparent
        Me.chkDepreciable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDepreciable.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkDepreciable.Location = New System.Drawing.Point(28, 227)
        Me.chkDepreciable.Name = "chkDepreciable"
        Me.chkDepreciable.Size = New System.Drawing.Size(82, 17)
        Me.chkDepreciable.TabIndex = 12
        Me.chkDepreciable.Text = "Depreciable"
        Me.chkDepreciable.UseVisualStyleBackColor = False
        '
        'fecActivacion
        '
        Me.fecActivacion.CustomFormat = "dd/MM/yyyy"
        Me.fecActivacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecActivacion.Location = New System.Drawing.Point(305, 11)
        Me.fecActivacion.Name = "fecActivacion"
        Me.fecActivacion.Size = New System.Drawing.Size(83, 21)
        Me.fecActivacion.TabIndex = 2
        '
        'Etiqueta41
        '
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta41.Location = New System.Drawing.Point(28, 146)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta41.TabIndex = 303
        Me.Etiqueta41.Text = "CC Ubicación:"
        '
        'fecIngreso
        '
        Me.fecIngreso.CustomFormat = "dd/MM/yyyy"
        Me.fecIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecIngreso.Location = New System.Drawing.Point(106, 12)
        Me.fecIngreso.Name = "fecIngreso"
        Me.fecIngreso.Size = New System.Drawing.Size(87, 21)
        Me.fecIngreso.TabIndex = 0
        '
        'Etiqueta15
        '
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(24, 15)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(77, 15)
        Me.Etiqueta15.TabIndex = 237
        Me.Etiqueta15.Text = "F. Adquisición:"
        '
        'verIndFecActivacion
        '
        Me.verIndFecActivacion.AutoSize = True
        Me.verIndFecActivacion.Checked = True
        Me.verIndFecActivacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verIndFecActivacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndFecActivacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndFecActivacion.Location = New System.Drawing.Point(229, 13)
        Me.verIndFecActivacion.Name = "verIndFecActivacion"
        Me.verIndFecActivacion.Size = New System.Drawing.Size(73, 17)
        Me.verIndFecActivacion.TabIndex = 1
        Me.verIndFecActivacion.Text = "F. Ingreso:"
        '
        'Etiqueta14
        '
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(37, 68)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(64, 15)
        Me.Etiqueta14.TabIndex = 238
        Me.Etiqueta14.Text = "Tipo Activo:"
        '
        'chkMaterial
        '
        Appearance74.FontData.BoldAsString = "False"
        Appearance74.FontData.Name = "Tahoma"
        Appearance74.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkMaterial.Appearance = Appearance74
        Me.chkMaterial.AutoSize = True
        Me.chkMaterial.Location = New System.Drawing.Point(36, 170)
        Me.chkMaterial.Name = "chkMaterial"
        Me.chkMaterial.Size = New System.Drawing.Size(65, 18)
        Me.chkMaterial.TabIndex = 9
        Me.chkMaterial.Text = "Material:"
        '
        'Etiqueta25
        '
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance75
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(22, 200)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta25.TabIndex = 302
        Me.Etiqueta25.Text = "Valor Residual:"
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(35, 41)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta13.TabIndex = 240
        Me.Etiqueta13.Text = "Ingreso por:"
        '
        'cbgMaterial
        '
        Me.cbgMaterial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cbgMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance76.BackColor = System.Drawing.SystemColors.Window
        Appearance76.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgMaterial.DisplayLayout.Appearance = Appearance76
        Me.cbgMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance77.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance77.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance77.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgMaterial.DisplayLayout.GroupByBox.Appearance = Appearance77
        Appearance78.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance78
        Me.cbgMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance79.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance79.BackColor2 = System.Drawing.SystemColors.Control
        Appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance79.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance79
        Me.cbgMaterial.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgMaterial.DisplayLayout.MaxRowScrollRegions = 1
        Appearance80.BackColor = System.Drawing.SystemColors.Window
        Appearance80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance80
        Appearance81.BackColor = System.Drawing.SystemColors.Window
        Me.cbgMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance81
        Me.cbgMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgMaterial.DisplayLayout.Override.CellPadding = 0
        Appearance82.BackColor = System.Drawing.SystemColors.Control
        Appearance82.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance82.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance82.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance82
        Me.cbgMaterial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Appearance83.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance83
        Me.cbgMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgMaterial.DisplayMember = "Nombre"
        Me.cbgMaterial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cbgMaterial.Enabled = False
        Me.cbgMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgMaterial.Location = New System.Drawing.Point(105, 167)
        Me.cbgMaterial.Name = "cbgMaterial"
        Me.cbgMaterial.Size = New System.Drawing.Size(283, 23)
        Me.cbgMaterial.TabIndex = 10
        Me.cbgMaterial.ValueMember = "Id"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(49, 93)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta10.TabIndex = 242
        Me.Etiqueta10.Text = "Sub Tipo:"
        '
        'numCantidadAF
        '
        Me.numCantidadAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.numCantidadAF.Enabled = False
        Me.numCantidadAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCantidadAF.Location = New System.Drawing.Point(290, 197)
        Me.numCantidadAF.MaxValue = 50
        Me.numCantidadAF.MinValue = 0
        Me.numCantidadAF.Name = "numCantidadAF"
        Me.numCantidadAF.NullText = "1"
        Me.numCantidadAF.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numCantidadAF.Size = New System.Drawing.Size(42, 22)
        Me.numCantidadAF.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numCantidadAF.SpinIncrement = 1
        Me.numCantidadAF.TabIndex = 14
        Me.numCantidadAF.Value = 1
        '
        'Etiqueta16
        '
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(28, 120)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta16.TabIndex = 286
        Me.Etiqueta16.Text = "Centro Costo:"
        '
        'chkConjuntoAF
        '
        Appearance84.FontData.Name = "Tahoma"
        Me.chkConjuntoAF.Appearance = Appearance84
        Me.chkConjuntoAF.AutoSize = True
        Me.chkConjuntoAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConjuntoAF.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkConjuntoAF.Location = New System.Drawing.Point(199, 200)
        Me.chkConjuntoAF.Name = "chkConjuntoAF"
        Me.chkConjuntoAF.Size = New System.Drawing.Size(87, 18)
        Me.chkConjuntoAF.TabIndex = 13
        Me.chkConjuntoAF.Text = "Conjunto A.F."
        '
        'uegbDatosBaja
        '
        Appearance85.BackColor = System.Drawing.Color.White
        Appearance85.BackColor2 = System.Drawing.Color.White
        Me.uegbDatosBaja.ContentAreaAppearance = Appearance85
        Me.uegbDatosBaja.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.uegbDatosBaja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uegbDatosBaja.ExpandedSize = New System.Drawing.Size(1159, 67)
        Me.uegbDatosBaja.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.uegbDatosBaja.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.uegbDatosBaja.Location = New System.Drawing.Point(0, 302)
        Me.uegbDatosBaja.Name = "uegbDatosBaja"
        Me.uegbDatosBaja.Size = New System.Drawing.Size(1159, 67)
        Me.uegbDatosBaja.TabIndex = 2
        Me.uegbDatosBaja.Text = "Datos de la Baja"
        Me.uegbDatosBaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.ugbDocumentoBaja)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.fecBaja)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.cboConceptoBajaAF)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.verIndBaja)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta24)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Etiqueta23)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.txtDescripcionBaja)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1153, 44)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'ugbDocumentoBaja
        '
        Me.ugbDocumentoBaja.Controls.Add(Me.txtTipoDocBaja)
        Me.ugbDocumentoBaja.Controls.Add(Me.ToolStrip2)
        Me.ugbDocumentoBaja.Controls.Add(Me.Etiqueta21)
        Me.ugbDocumentoBaja.Controls.Add(Me.Etiqueta33)
        Me.ugbDocumentoBaja.Controls.Add(Me.Etiqueta26)
        Me.ugbDocumentoBaja.Controls.Add(Me.txtSerieBaja)
        Me.ugbDocumentoBaja.Controls.Add(Me.txtNumeroBaja)
        Me.ugbDocumentoBaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugbDocumentoBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ugbDocumentoBaja.Location = New System.Drawing.Point(495, -1)
        Me.ugbDocumentoBaja.Name = "ugbDocumentoBaja"
        Me.ugbDocumentoBaja.Size = New System.Drawing.Size(430, 70)
        Me.ugbDocumentoBaja.TabIndex = 4
        Me.ugbDocumentoBaja.Text = "Documento"
        Me.ugbDocumentoBaja.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txtTipoDocBaja
        '
        Appearance86.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDocBaja.Appearance = Appearance86
        Me.txtTipoDocBaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDocBaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtTipoDocBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoDocBaja.Location = New System.Drawing.Point(71, 14)
        Me.txtTipoDocBaja.MaxLength = 10
        Me.txtTipoDocBaja.Name = "txtTipoDocBaja"
        Me.txtTipoDocBaja.ReadOnly = True
        Me.txtTipoDocBaja.Size = New System.Drawing.Size(250, 21)
        Me.txtTipoDocBaja.TabIndex = 331
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscarDocBaja})
        Me.ToolStrip2.Location = New System.Drawing.Point(324, 13)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(98, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.TabStop = True
        '
        'tsbBuscarDocBaja
        '
        Me.tsbBuscarDocBaja.ForeColor = System.Drawing.Color.Black
        Me.tsbBuscarDocBaja.Image = Global.ISL.Win.My.Resources.Resources.consult
        Me.tsbBuscarDocBaja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscarDocBaja.Name = "tsbBuscarDocBaja"
        Me.tsbBuscarDocBaja.Size = New System.Drawing.Size(86, 22)
        Me.tsbBuscarDocBaja.Text = "Buscar Doc"
        '
        'Etiqueta21
        '
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(11, 18)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta21.TabIndex = 329
        Me.Etiqueta21.Text = "Tipo Doc.:"
        '
        'Etiqueta33
        '
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta33.Location = New System.Drawing.Point(145, 43)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta33.TabIndex = 328
        Me.Etiqueta33.Text = "Número:"
        '
        'Etiqueta26
        '
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(34, 43)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta26.TabIndex = 330
        Me.Etiqueta26.Text = "Serie:"
        '
        'txtSerieBaja
        '
        Appearance87.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieBaja.Appearance = Appearance87
        Me.txtSerieBaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieBaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtSerieBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieBaja.Location = New System.Drawing.Point(71, 39)
        Me.txtSerieBaja.MaxLength = 15
        Me.txtSerieBaja.Name = "txtSerieBaja"
        Me.txtSerieBaja.ReadOnly = True
        Me.txtSerieBaja.Size = New System.Drawing.Size(63, 21)
        Me.txtSerieBaja.TabIndex = 2
        '
        'txtNumeroBaja
        '
        Appearance88.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroBaja.Appearance = Appearance88
        Me.txtNumeroBaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNumeroBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroBaja.Location = New System.Drawing.Point(194, 40)
        Me.txtNumeroBaja.MaxLength = 15
        Me.txtNumeroBaja.Name = "txtNumeroBaja"
        Me.txtNumeroBaja.ReadOnly = True
        Me.txtNumeroBaja.Size = New System.Drawing.Size(127, 21)
        Me.txtNumeroBaja.TabIndex = 3
        '
        'fecBaja
        '
        Me.fecBaja.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecBaja.CustomFormat = "dd/MM/yyyy"
        Me.fecBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecBaja.Location = New System.Drawing.Point(70, 7)
        Me.fecBaja.Name = "fecBaja"
        Me.fecBaja.Size = New System.Drawing.Size(85, 20)
        Me.fecBaja.TabIndex = 307
        '
        'cboConceptoBajaAF
        '
        Me.cboConceptoBajaAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboConceptoBajaAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboConceptoBajaAF.DisplayMember = "Nombre"
        Me.cboConceptoBajaAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboConceptoBajaAF.DropDownListWidth = -1
        Me.cboConceptoBajaAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptoBajaAF.Location = New System.Drawing.Point(246, 5)
        Me.cboConceptoBajaAF.Name = "cboConceptoBajaAF"
        Me.cboConceptoBajaAF.Size = New System.Drawing.Size(237, 22)
        Me.cboConceptoBajaAF.TabIndex = 2
        Me.cboConceptoBajaAF.ValueMember = "Id"
        '
        'verIndBaja
        '
        Me.verIndBaja.AutoSize = True
        Me.verIndBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIndBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verIndBaja.Location = New System.Drawing.Point(8, 8)
        Me.verIndBaja.Name = "verIndBaja"
        Me.verIndBaja.Size = New System.Drawing.Size(59, 17)
        Me.verIndBaja.TabIndex = 0
        Me.verIndBaja.Text = "F. Baja:"
        '
        'Etiqueta24
        '
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.Location = New System.Drawing.Point(2, 34)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(65, 15)
        Me.Etiqueta24.TabIndex = 301
        Me.Etiqueta24.Text = "Descripción:"
        '
        'Etiqueta23
        '
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(160, 10)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta23.TabIndex = 298
        Me.Etiqueta23.Text = "Concepto Baja:"
        '
        'txtDescripcionBaja
        '
        Appearance89.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionBaja.Appearance = Appearance89
        Me.txtDescripcionBaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionBaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescripcionBaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionBaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionBaja.Location = New System.Drawing.Point(70, 31)
        Me.txtDescripcionBaja.MaxLength = 500
        Me.txtDescripcionBaja.Multiline = True
        Me.txtDescripcionBaja.Name = "txtDescripcionBaja"
        Me.txtDescripcionBaja.Size = New System.Drawing.Size(413, 36)
        Me.txtDescripcionBaja.TabIndex = 3
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griAFCuentaContable)
        Me.UltraTabPageControl6.Controls.Add(Me.tspInformacionContable)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1159, 369)
        '
        'griAFCuentaContable
        '
        Me.griAFCuentaContable.DataSource = Me.udsAFCuentaContable
        Appearance90.BackColor = System.Drawing.SystemColors.Window
        Appearance90.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAFCuentaContable.DisplayLayout.Appearance = Appearance90
        Appearance91.Image = 6
        Appearance91.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance91.TextHAlignAsString = "Left"
        UltraGridColumn107.CellAppearance = Appearance91
        Appearance92.Image = 8
        Appearance92.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn107.CellButtonAppearance = Appearance92
        UltraGridColumn107.Header.VisiblePosition = 0
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn108.Header.VisiblePosition = 1
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 2
        UltraGridColumn109.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 3
        UltraGridColumn132.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 4
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 5
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 6
        UltraGridColumn166.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 7
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 8
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 10
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 12
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 14
        UltraGridColumn173.Hidden = True
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn174.CellAppearance = Appearance93
        UltraGridColumn174.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn174.Format = "#,##0.00"
        UltraGridColumn174.Header.VisiblePosition = 26
        UltraGridColumn174.Hidden = True
        UltraGridColumn174.MaskInput = "{double:9.2}"
        UltraGridColumn175.Header.VisiblePosition = 27
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 28
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 29
        UltraGridColumn177.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn177.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn177.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 42)
        UltraGridColumn177.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn177.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn178.Header.VisiblePosition = 30
        UltraGridColumn178.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 9
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.Width = 378
        UltraGridColumn116.Header.VisiblePosition = 11
        UltraGridColumn116.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 15
        UltraGridColumn118.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 13
        UltraGridColumn117.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 31
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 32
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 33
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 34
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 35
        UltraGridColumn183.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 36
        UltraGridColumn28.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn33.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.VisiblePosition = 20
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn34.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.VisiblePosition = 22
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn35.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.VisiblePosition = 24
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn36.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.VisiblePosition = 16
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn38.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 42)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn38.Width = 63
        UltraGridColumn44.Header.VisiblePosition = 37
        UltraGridColumn44.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 17
        UltraGridColumn78.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn78.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn78.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 42)
        UltraGridColumn78.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn78.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn78.Width = 175
        UltraGridColumn80.Header.VisiblePosition = 19
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn80.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.Header.VisiblePosition = 21
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn81.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.Header.VisiblePosition = 23
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn82.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.Header.VisiblePosition = 25
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn83.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Cta Desactivación"
        UltraGridColumn40.Header.VisiblePosition = 38
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(100, 0)
        UltraGridColumn40.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 42)
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn41.Header.Caption = "Gasto Función"
        UltraGridColumn41.Header.VisiblePosition = 39
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(256, 0)
        UltraGridColumn41.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 42)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 4
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn132, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn115, UltraGridColumn116, UltraGridColumn118, UltraGridColumn117, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn28, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn38, UltraGridColumn44, UltraGridColumn78, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn40, UltraGridColumn41})
        UltraGridGroup1.Header.Caption = "Cta Compra"
        UltraGridGroup1.Key = "NewGroup0"
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 4
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 4
        UltraGridGroup2.Header.Caption = "Cta Reclasificación"
        UltraGridGroup2.Key = "NewGroup1"
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 8
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 4
        UltraGridGroup3.Header.Caption = "Cta Depreciación"
        UltraGridGroup3.Key = "NewGroup2"
        UltraGridGroup3.RowLayoutGroupInfo.OriginX = 12
        UltraGridGroup3.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup3.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup3.RowLayoutGroupInfo.SpanY = 4
        UltraGridGroup4.Header.Caption = "Cta Readecuación"
        UltraGridGroup4.Hidden = True
        UltraGridGroup4.Key = "NewGroup3"
        UltraGridGroup4.RowLayoutGroupInfo.OriginX = 16
        UltraGridGroup4.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup4.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup4.RowLayoutGroupInfo.SpanY = 4
        UltraGridBand6.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4})
        UltraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.griAFCuentaContable.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griAFCuentaContable.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAFCuentaContable.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance94.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance94.BorderColor = System.Drawing.SystemColors.Window
        Me.griAFCuentaContable.DisplayLayout.GroupByBox.Appearance = Appearance94
        Appearance95.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAFCuentaContable.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance95
        Me.griAFCuentaContable.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAFCuentaContable.DisplayLayout.GroupByBox.Hidden = True
        Appearance96.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance96.BackColor2 = System.Drawing.SystemColors.Control
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance96.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAFCuentaContable.DisplayLayout.GroupByBox.PromptAppearance = Appearance96
        Me.griAFCuentaContable.DisplayLayout.MaxColScrollRegions = 1
        Me.griAFCuentaContable.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAFCuentaContable.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAFCuentaContable.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAFCuentaContable.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAFCuentaContable.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAFCuentaContable.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAFCuentaContable.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAFCuentaContable.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAFCuentaContable.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAFCuentaContable.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAFCuentaContable.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAFCuentaContable.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAFCuentaContable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAFCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAFCuentaContable.Location = New System.Drawing.Point(0, 188)
        Me.griAFCuentaContable.Name = "griAFCuentaContable"
        Me.griAFCuentaContable.Size = New System.Drawing.Size(1159, 181)
        Me.griAFCuentaContable.TabIndex = 5
        '
        'udsAFCuentaContable
        '
        UltraDataColumn126.DataType = GetType(Integer)
        UltraDataColumn127.DataType = GetType(Date)
        UltraDataColumn128.DataType = GetType(Integer)
        UltraDataColumn129.DataType = GetType(Date)
        UltraDataColumn134.DataType = GetType(Double)
        UltraDataColumn135.DataType = GetType(Double)
        UltraDataColumn136.DataType = GetType(Integer)
        UltraDataColumn137.DataType = GetType(Boolean)
        UltraDataColumn140.DataType = GetType(Boolean)
        UltraDataColumn142.DataType = GetType(Date)
        UltraDataColumn144.DataType = GetType(Date)
        UltraDataColumn146.DataType = GetType(Double)
        UltraDataColumn147.DataType = GetType(Date)
        UltraDataColumn153.DataType = GetType(Long)
        Me.udsAFCuentaContable.Band.Columns.AddRange(New Object() {UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161})
        '
        'tspInformacionContable
        '
        Me.tspInformacionContable.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspInformacionContable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregar, Me.tsbQuitar})
        Me.tspInformacionContable.Location = New System.Drawing.Point(0, 163)
        Me.tspInformacionContable.Name = "tspInformacionContable"
        Me.tspInformacionContable.Size = New System.Drawing.Size(1159, 25)
        Me.tspInformacionContable.TabIndex = 339
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregar.Text = "Agregar"
        '
        'tsbQuitar
        '
        Me.tsbQuitar.Image = Global.ISL.Win.My.Resources.Resources.Quitar
        Me.tsbQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitar.Name = "tsbQuitar"
        Me.tsbQuitar.Size = New System.Drawing.Size(60, 22)
        Me.tsbQuitar.Text = "Quitar"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.txtGastoFuncion)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta12)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDesactivacionDD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDesactivacionD)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta11)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaReadecuacionHH)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDepreciacionHH)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaRevalorizacionHH)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaCompraHH)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaReadecuacionDD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDepreciacionDD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaRevalorizacionDD)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta17)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaReadecuacionH)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta27)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDepreciacionH)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta63)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta64)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaRevalorizacionH)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta65)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaCompraH)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta68)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta70)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta85)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta86)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaCompraD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaReadecuacionD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaDepreciacionD)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaRevalorizacionD)
        Me.UltraGroupBox5.Controls.Add(Me.UltraTextEditor1)
        Me.UltraGroupBox5.Controls.Add(Me.Button1)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta42)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta87)
        Me.UltraGroupBox5.Controls.Add(Me.txtNroLeasingIC)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta20)
        Me.UltraGroupBox5.Controls.Add(Me.opcTipoAdquisicion)
        Me.UltraGroupBox5.Controls.Add(Me.txtCtaCompraDD)
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta66)
        Me.UltraGroupBox5.Controls.Add(Me.AñoIC)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1159, 163)
        Me.UltraGroupBox5.TabIndex = 4
        '
        'txtGastoFuncion
        '
        Me.txtGastoFuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGastoFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtGastoFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastoFuncion.Location = New System.Drawing.Point(89, 134)
        Me.txtGastoFuncion.Name = "txtGastoFuncion"
        Me.txtGastoFuncion.ReadOnly = True
        Me.txtGastoFuncion.Size = New System.Drawing.Size(406, 22)
        Me.txtGastoFuncion.TabIndex = 370
        '
        'Etiqueta12
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance97
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta12.Location = New System.Drawing.Point(6, 138)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta12.TabIndex = 369
        Me.Etiqueta12.Text = "Gasto Función:"
        '
        'txtCtaDesactivacionDD
        '
        Me.txtCtaDesactivacionDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDesactivacionDD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDesactivacionDD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDesactivacionDD.Location = New System.Drawing.Point(89, 84)
        Me.txtCtaDesactivacionDD.Name = "txtCtaDesactivacionDD"
        Me.txtCtaDesactivacionDD.ReadOnly = True
        Me.txtCtaDesactivacionDD.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaDesactivacionDD.TabIndex = 368
        '
        'txtCtaDesactivacionD
        '
        Me.txtCtaDesactivacionD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDesactivacionD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDesactivacionD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDesactivacionD.Location = New System.Drawing.Point(161, 84)
        Me.txtCtaDesactivacionD.Name = "txtCtaDesactivacionD"
        Me.txtCtaDesactivacionD.ReadOnly = True
        Me.txtCtaDesactivacionD.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaDesactivacionD.TabIndex = 366
        Me.txtCtaDesactivacionD.TabStop = False
        '
        'Etiqueta11
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance98
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta11.Location = New System.Drawing.Point(9, 87)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(76, 15)
        Me.Etiqueta11.TabIndex = 365
        Me.Etiqueta11.Text = "Desactivación:"
        '
        'txtCtaReadecuacionHH
        '
        Me.txtCtaReadecuacionHH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaReadecuacionHH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaReadecuacionHH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaReadecuacionHH.Location = New System.Drawing.Point(591, 209)
        Me.txtCtaReadecuacionHH.Name = "txtCtaReadecuacionHH"
        Me.txtCtaReadecuacionHH.ReadOnly = True
        Me.txtCtaReadecuacionHH.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaReadecuacionHH.TabIndex = 15
        Me.txtCtaReadecuacionHH.Visible = False
        '
        'txtCtaDepreciacionHH
        '
        Me.txtCtaDepreciacionHH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDepreciacionHH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDepreciacionHH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDepreciacionHH.Location = New System.Drawing.Point(591, 109)
        Me.txtCtaDepreciacionHH.Name = "txtCtaDepreciacionHH"
        Me.txtCtaDepreciacionHH.ReadOnly = True
        Me.txtCtaDepreciacionHH.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaDepreciacionHH.TabIndex = 11
        '
        'txtCtaRevalorizacionHH
        '
        Me.txtCtaRevalorizacionHH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaRevalorizacionHH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaRevalorizacionHH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaRevalorizacionHH.Location = New System.Drawing.Point(591, 59)
        Me.txtCtaRevalorizacionHH.Name = "txtCtaRevalorizacionHH"
        Me.txtCtaRevalorizacionHH.ReadOnly = True
        Me.txtCtaRevalorizacionHH.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaRevalorizacionHH.TabIndex = 7
        '
        'txtCtaCompraHH
        '
        Me.txtCtaCompraHH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCompraHH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaCompraHH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCompraHH.Location = New System.Drawing.Point(591, 34)
        Me.txtCtaCompraHH.Name = "txtCtaCompraHH"
        Me.txtCtaCompraHH.ReadOnly = True
        Me.txtCtaCompraHH.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaCompraHH.TabIndex = 3
        '
        'txtCtaReadecuacionDD
        '
        Me.txtCtaReadecuacionDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaReadecuacionDD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaReadecuacionDD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaReadecuacionDD.Location = New System.Drawing.Point(89, 209)
        Me.txtCtaReadecuacionDD.Name = "txtCtaReadecuacionDD"
        Me.txtCtaReadecuacionDD.ReadOnly = True
        Me.txtCtaReadecuacionDD.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaReadecuacionDD.TabIndex = 13
        Me.txtCtaReadecuacionDD.Visible = False
        '
        'txtCtaDepreciacionDD
        '
        Me.txtCtaDepreciacionDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDepreciacionDD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDepreciacionDD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDepreciacionDD.Location = New System.Drawing.Point(89, 109)
        Me.txtCtaDepreciacionDD.Name = "txtCtaDepreciacionDD"
        Me.txtCtaDepreciacionDD.ReadOnly = True
        Me.txtCtaDepreciacionDD.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaDepreciacionDD.TabIndex = 9
        '
        'txtCtaRevalorizacionDD
        '
        Me.txtCtaRevalorizacionDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaRevalorizacionDD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaRevalorizacionDD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaRevalorizacionDD.Location = New System.Drawing.Point(89, 59)
        Me.txtCtaRevalorizacionDD.Name = "txtCtaRevalorizacionDD"
        Me.txtCtaRevalorizacionDD.ReadOnly = True
        Me.txtCtaRevalorizacionDD.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaRevalorizacionDD.TabIndex = 5
        '
        'Etiqueta17
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta17.Appearance = Appearance99
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta17.Location = New System.Drawing.Point(512, 214)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(77, 15)
        Me.Etiqueta17.TabIndex = 364
        Me.Etiqueta17.Text = "Readecuación:"
        Me.Etiqueta17.Visible = False
        '
        'txtCtaReadecuacionH
        '
        Me.txtCtaReadecuacionH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaReadecuacionH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaReadecuacionH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaReadecuacionH.Location = New System.Drawing.Point(668, 209)
        Me.txtCtaReadecuacionH.Name = "txtCtaReadecuacionH"
        Me.txtCtaReadecuacionH.ReadOnly = True
        Me.txtCtaReadecuacionH.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaReadecuacionH.TabIndex = 16
        Me.txtCtaReadecuacionH.Visible = False
        '
        'Etiqueta27
        '
        Appearance100.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta27.Appearance = Appearance100
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta27.Location = New System.Drawing.Point(517, 113)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta27.TabIndex = 363
        Me.Etiqueta27.Text = "Depreciación:"
        '
        'txtCtaDepreciacionH
        '
        Me.txtCtaDepreciacionH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDepreciacionH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDepreciacionH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDepreciacionH.Location = New System.Drawing.Point(668, 109)
        Me.txtCtaDepreciacionH.Name = "txtCtaDepreciacionH"
        Me.txtCtaDepreciacionH.ReadOnly = True
        Me.txtCtaDepreciacionH.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaDepreciacionH.TabIndex = 12
        '
        'Etiqueta28
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta28.Appearance = Appearance101
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta28.Location = New System.Drawing.Point(710, 18)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta28.TabIndex = 362
        Me.Etiqueta28.Text = "Haber:"
        '
        'Etiqueta63
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta63.Appearance = Appearance102
        Me.Etiqueta63.AutoSize = True
        Me.Etiqueta63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta63.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta63.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta63.Location = New System.Drawing.Point(181, 18)
        Me.Etiqueta63.Name = "Etiqueta63"
        Me.Etiqueta63.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta63.TabIndex = 361
        Me.Etiqueta63.Text = "Debe:"
        '
        'Etiqueta64
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta64.Appearance = Appearance103
        Me.Etiqueta64.AutoSize = True
        Me.Etiqueta64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta64.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta64.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta64.Location = New System.Drawing.Point(509, 62)
        Me.Etiqueta64.Name = "Etiqueta64"
        Me.Etiqueta64.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta64.TabIndex = 360
        Me.Etiqueta64.Text = "Reclasificación:"
        '
        'txtCtaRevalorizacionH
        '
        Me.txtCtaRevalorizacionH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaRevalorizacionH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaRevalorizacionH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaRevalorizacionH.Location = New System.Drawing.Point(668, 59)
        Me.txtCtaRevalorizacionH.Name = "txtCtaRevalorizacionH"
        Me.txtCtaRevalorizacionH.ReadOnly = True
        Me.txtCtaRevalorizacionH.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaRevalorizacionH.TabIndex = 8
        '
        'Etiqueta65
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta65.Appearance = Appearance104
        Me.Etiqueta65.AutoSize = True
        Me.Etiqueta65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta65.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta65.Location = New System.Drawing.Point(542, 39)
        Me.Etiqueta65.Name = "Etiqueta65"
        Me.Etiqueta65.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta65.TabIndex = 359
        Me.Etiqueta65.Text = "Compra:"
        '
        'txtCtaCompraH
        '
        Me.txtCtaCompraH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCompraH.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaCompraH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCompraH.Location = New System.Drawing.Point(668, 34)
        Me.txtCtaCompraH.Name = "txtCtaCompraH"
        Me.txtCtaCompraH.ReadOnly = True
        Me.txtCtaCompraH.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaCompraH.TabIndex = 4
        '
        'Etiqueta68
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta68.Appearance = Appearance105
        Me.Etiqueta68.AutoSize = True
        Me.Etiqueta68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta68.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta68.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta68.Location = New System.Drawing.Point(8, 213)
        Me.Etiqueta68.Name = "Etiqueta68"
        Me.Etiqueta68.Size = New System.Drawing.Size(77, 15)
        Me.Etiqueta68.TabIndex = 356
        Me.Etiqueta68.Text = "Readecuación:"
        Me.Etiqueta68.Visible = False
        '
        'Etiqueta70
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta70.Appearance = Appearance106
        Me.Etiqueta70.AutoSize = True
        Me.Etiqueta70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta70.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta70.Location = New System.Drawing.Point(5, 62)
        Me.Etiqueta70.Name = "Etiqueta70"
        Me.Etiqueta70.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta70.TabIndex = 355
        Me.Etiqueta70.Text = "Reclasificación:"
        '
        'Etiqueta85
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta85.Appearance = Appearance107
        Me.Etiqueta85.AutoSize = True
        Me.Etiqueta85.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta85.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta85.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta85.Location = New System.Drawing.Point(38, 39)
        Me.Etiqueta85.Name = "Etiqueta85"
        Me.Etiqueta85.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta85.TabIndex = 357
        Me.Etiqueta85.Text = "Compra:"
        '
        'Etiqueta86
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta86.Appearance = Appearance108
        Me.Etiqueta86.AutoSize = True
        Me.Etiqueta86.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta86.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta86.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta86.Location = New System.Drawing.Point(13, 113)
        Me.Etiqueta86.Name = "Etiqueta86"
        Me.Etiqueta86.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta86.TabIndex = 358
        Me.Etiqueta86.Text = "Depreciación:"
        '
        'txtCtaCompraD
        '
        Me.txtCtaCompraD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCompraD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaCompraD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCompraD.Location = New System.Drawing.Point(161, 34)
        Me.txtCtaCompraD.Name = "txtCtaCompraD"
        Me.txtCtaCompraD.ReadOnly = True
        Me.txtCtaCompraD.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaCompraD.TabIndex = 2
        '
        'txtCtaReadecuacionD
        '
        Me.txtCtaReadecuacionD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaReadecuacionD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaReadecuacionD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaReadecuacionD.Location = New System.Drawing.Point(161, 209)
        Me.txtCtaReadecuacionD.Name = "txtCtaReadecuacionD"
        Me.txtCtaReadecuacionD.ReadOnly = True
        Me.txtCtaReadecuacionD.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaReadecuacionD.TabIndex = 14
        Me.txtCtaReadecuacionD.Visible = False
        '
        'txtCtaDepreciacionD
        '
        Me.txtCtaDepreciacionD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDepreciacionD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDepreciacionD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaDepreciacionD.Location = New System.Drawing.Point(161, 109)
        Me.txtCtaDepreciacionD.Name = "txtCtaDepreciacionD"
        Me.txtCtaDepreciacionD.ReadOnly = True
        Me.txtCtaDepreciacionD.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaDepreciacionD.TabIndex = 10
        '
        'txtCtaRevalorizacionD
        '
        Me.txtCtaRevalorizacionD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaRevalorizacionD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaRevalorizacionD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaRevalorizacionD.Location = New System.Drawing.Point(161, 59)
        Me.txtCtaRevalorizacionD.Name = "txtCtaRevalorizacionD"
        Me.txtCtaRevalorizacionD.ReadOnly = True
        Me.txtCtaRevalorizacionD.Size = New System.Drawing.Size(334, 22)
        Me.txtCtaRevalorizacionD.TabIndex = 6
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.UltraTextEditor1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTextEditor1.Location = New System.Drawing.Point(95, 302)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(387, 22)
        Me.UltraTextEditor1.TabIndex = 338
        Me.UltraTextEditor1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.ISL.Win.My.Resources.Resources.kexi
        Me.Button1.Location = New System.Drawing.Point(258, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 35)
        Me.Button1.TabIndex = 337
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Etiqueta42
        '
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance109
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta42.Location = New System.Drawing.Point(35, 9)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta42.TabIndex = 299
        Me.Etiqueta42.Text = "Ejercicio:"
        '
        'Etiqueta87
        '
        Me.Etiqueta87.AutoSize = True
        Me.Etiqueta87.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta87.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta87.Location = New System.Drawing.Point(27, 332)
        Me.Etiqueta87.Name = "Etiqueta87"
        Me.Etiqueta87.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta87.TabIndex = 334
        Me.Etiqueta87.Text = "N° Leasing:"
        Me.Etiqueta87.Visible = False
        '
        'txtNroLeasingIC
        '
        Me.txtNroLeasingIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroLeasingIC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNroLeasingIC.Location = New System.Drawing.Point(96, 328)
        Me.txtNroLeasingIC.Name = "txtNroLeasingIC"
        Me.txtNroLeasingIC.Size = New System.Drawing.Size(148, 22)
        Me.txtNroLeasingIC.TabIndex = 16
        Me.txtNroLeasingIC.Visible = False
        '
        'Etiqueta20
        '
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(0, 276)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(89, 15)
        Me.Etiqueta20.TabIndex = 294
        Me.Etiqueta20.Text = "Tipo Adquisición:"
        Me.Etiqueta20.Visible = False
        '
        'opcTipoAdquisicion
        '
        Me.opcTipoAdquisicion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem13.DataValue = "Default Item"
        ValueListItem13.DisplayText = "Propio (0)"
        ValueListItem14.DataValue = "ValueListItem1"
        ValueListItem14.DisplayText = "Leasing (1)"
        Me.opcTipoAdquisicion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14})
        Me.opcTipoAdquisicion.ItemSpacingHorizontal = 5
        Me.opcTipoAdquisicion.Location = New System.Drawing.Point(96, 276)
        Me.opcTipoAdquisicion.Name = "opcTipoAdquisicion"
        Me.opcTipoAdquisicion.Size = New System.Drawing.Size(156, 21)
        Me.opcTipoAdquisicion.TabIndex = 14
        Me.opcTipoAdquisicion.Visible = False
        '
        'txtCtaCompraDD
        '
        Me.txtCtaCompraDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaCompraDD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaCompraDD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCompraDD.Location = New System.Drawing.Point(89, 34)
        Me.txtCtaCompraDD.Name = "txtCtaCompraDD"
        Me.txtCtaCompraDD.ReadOnly = True
        Me.txtCtaCompraDD.Size = New System.Drawing.Size(66, 22)
        Me.txtCtaCompraDD.TabIndex = 1
        '
        'Etiqueta66
        '
        Me.Etiqueta66.AutoSize = True
        Me.Etiqueta66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta66.Location = New System.Drawing.Point(13, 306)
        Me.Etiqueta66.Name = "Etiqueta66"
        Me.Etiqueta66.Size = New System.Drawing.Size(78, 15)
        Me.Etiqueta66.TabIndex = 310
        Me.Etiqueta66.Text = "Emp. Financia:"
        Me.Etiqueta66.Visible = False
        '
        'AñoIC
        '
        Me.AñoIC.Año = 2020
        Me.AñoIC.AutoSize = True
        Me.AñoIC.Controls.Add(Me.numAño)
        Me.AñoIC.Controls.Add(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9)
        Me.AñoIC.Controls.Add(Me.NumeroEntero2)
        Me.AñoIC.Controls.Add(Me.NumeroEntero3)
        Me.AñoIC.Location = New System.Drawing.Point(89, 6)
        Me.AñoIC.Name = "AñoIC"
        Me.AñoIC.Size = New System.Drawing.Size(56, 24)
        Me.AñoIC.TabIndex = 0
        '
        'numAño
        '
        Appearance110.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance110
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2014
        '
        'object_affad419_86ca_48bd_b401_1f51c77e4ae9
        '
        Appearance111.ForeColor = System.Drawing.Color.Black
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Appearance = Appearance111
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.ForeColor = System.Drawing.Color.Black
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.FormatString = ""
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Location = New System.Drawing.Point(1, 0)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MaskInput = "nnnn"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MaxValue = 2020
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MinValue = 2000
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Name = "object_affad419_86ca_48bd_b401_1f51c77e4ae9"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.NullText = "0"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Size = New System.Drawing.Size(52, 21)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.TabIndex = 0
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Value = 2013
        '
        'NumeroEntero2
        '
        Appearance112.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance112
        Me.NumeroEntero2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero2.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.FormatString = ""
        Me.NumeroEntero2.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero2.MaskInput = "nnnn"
        Me.NumeroEntero2.MaxValue = 2020
        Me.NumeroEntero2.MinValue = 2000
        Me.NumeroEntero2.Name = "NumeroEntero2"
        Me.NumeroEntero2.NullText = "0"
        Me.NumeroEntero2.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero2.TabIndex = 0
        Me.NumeroEntero2.Value = 2013
        '
        'NumeroEntero3
        '
        Appearance113.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance113
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2012
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1159, 369)
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.utcReadecuaciones)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1159, 369)
        Me.UltraGroupBox6.TabIndex = 0
        '
        'utcReadecuaciones
        '
        Me.utcReadecuaciones.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.utcReadecuaciones.Controls.Add(Me.tapListaReadecuaciones)
        Me.utcReadecuaciones.Controls.Add(Me.tapMantReadecuaciones)
        Me.utcReadecuaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcReadecuaciones.Location = New System.Drawing.Point(3, 3)
        Me.utcReadecuaciones.Name = "utcReadecuaciones"
        Me.utcReadecuaciones.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.utcReadecuaciones.Size = New System.Drawing.Size(1153, 363)
        Me.utcReadecuaciones.TabIndex = 342
        UltraTab2.TabPage = Me.tapListaReadecuaciones
        UltraTab2.Text = "Listado"
        UltraTab7.TabPage = Me.tapMantReadecuaciones
        UltraTab7.Text = "Mantenimiento"
        Me.utcReadecuaciones.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab7})
        Me.utcReadecuaciones.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1149, 337)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griDepreciacion)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraExpandableGroupBox16)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1159, 369)
        '
        'griDepreciacion
        '
        Me.griDepreciacion.DataSource = Me.ogdDepreciacion
        Appearance123.BackColor = System.Drawing.SystemColors.Window
        Appearance123.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDepreciacion.DisplayLayout.Appearance = Appearance123
        Appearance124.Image = 6
        Appearance124.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance124.TextHAlignAsString = "Left"
        UltraGridColumn145.CellAppearance = Appearance124
        Appearance125.Image = 8
        Appearance125.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn145.CellButtonAppearance = Appearance125
        UltraGridColumn145.Header.VisiblePosition = 0
        UltraGridColumn145.Hidden = True
        UltraGridColumn145.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn146.Header.VisiblePosition = 1
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 4
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 5
        UltraGridColumn148.Width = 50
        UltraGridColumn149.Header.Caption = "AF. IC."
        UltraGridColumn149.Header.VisiblePosition = 6
        UltraGridColumn149.Width = 200
        UltraGridColumn150.Header.VisiblePosition = 16
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.Header.VisiblePosition = 2
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 3
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.Caption = "Cta.Origen"
        UltraGridColumn153.Header.VisiblePosition = 7
        UltraGridColumn153.Width = 50
        UltraGridColumn154.Header.Caption = "Cta.Destino"
        UltraGridColumn154.Header.VisiblePosition = 8
        UltraGridColumn154.Width = 50
        Appearance126.TextHAlignAsString = "Right"
        UltraGridColumn155.CellAppearance = Appearance126
        UltraGridColumn155.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn155.Header.VisiblePosition = 9
        UltraGridColumn155.MaskInput = "{LOC}-nnnnnnnnnn.nnn"
        UltraGridColumn155.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn155.Width = 75
        Appearance127.TextHAlignAsString = "Right"
        UltraGridColumn156.CellAppearance = Appearance127
        UltraGridColumn156.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn156.Header.VisiblePosition = 10
        UltraGridColumn156.MaskInput = "{LOC}-nnnnnnnnnn.nnn"
        UltraGridColumn156.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn156.Width = 75
        UltraGridColumn157.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn157.Header.VisiblePosition = 11
        UltraGridColumn157.Width = 200
        UltraGridColumn158.Header.VisiblePosition = 15
        UltraGridColumn158.Hidden = True
        UltraGridColumn158.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn158.Width = 40
        UltraGridColumn159.Header.VisiblePosition = 12
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 13
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 14
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 17
        UltraGridColumn162.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162})
        Me.griDepreciacion.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griDepreciacion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDepreciacion.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance128.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance128.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance128.BorderColor = System.Drawing.SystemColors.Window
        Me.griDepreciacion.DisplayLayout.GroupByBox.Appearance = Appearance128
        Appearance129.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDepreciacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance129
        Me.griDepreciacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDepreciacion.DisplayLayout.GroupByBox.Hidden = True
        Appearance130.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance130.BackColor2 = System.Drawing.SystemColors.Control
        Appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance130.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDepreciacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance130
        Me.griDepreciacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griDepreciacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDepreciacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDepreciacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDepreciacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDepreciacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDepreciacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDepreciacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDepreciacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDepreciacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDepreciacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDepreciacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDepreciacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDepreciacion.Location = New System.Drawing.Point(425, 0)
        Me.griDepreciacion.Name = "griDepreciacion"
        Me.griDepreciacion.Size = New System.Drawing.Size(734, 369)
        Me.griDepreciacion.TabIndex = 302
        '
        'ogdDepreciacion
        '
        Me.ogdDepreciacion.Band.Columns.AddRange(New Object() {UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179})
        '
        'UltraExpandableGroupBox16
        '
        Me.UltraExpandableGroupBox16.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Appearance131.BackColor = System.Drawing.Color.White
        Appearance131.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox16.ContentAreaAppearance = Appearance131
        Me.UltraExpandableGroupBox16.Controls.Add(Me.UltraExpandableGroupBoxPanel19)
        Me.UltraExpandableGroupBox16.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox16.ExpandedSize = New System.Drawing.Size(425, 369)
        Me.UltraExpandableGroupBox16.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox16.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox16.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox16.Name = "UltraExpandableGroupBox16"
        Me.UltraExpandableGroupBox16.Size = New System.Drawing.Size(425, 369)
        Me.UltraExpandableGroupBox16.TabIndex = 301
        Me.UltraExpandableGroupBox16.Text = "Depreciacion de Activo Datos Historicos"
        Me.UltraExpandableGroupBox16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel19
        '
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.cboAFCuentaContableD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta69)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.verActualD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.cboCtaDestinoD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.cboCtaOrigenD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.txtObservacionD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.btnAgregarD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta61)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.decImporteD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.decValorD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta62)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.txtCtaDestinoD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.txtCtaOrigenD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta55)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta56)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta53)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.cboMesD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.AñoD)
        Me.UltraExpandableGroupBoxPanel19.Controls.Add(Me.Etiqueta54)
        Me.UltraExpandableGroupBoxPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel19.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel19.Name = "UltraExpandableGroupBoxPanel19"
        Me.UltraExpandableGroupBoxPanel19.Size = New System.Drawing.Size(402, 363)
        Me.UltraExpandableGroupBoxPanel19.TabIndex = 0
        '
        'cboAFCuentaContableD
        '
        Me.cboAFCuentaContableD.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAFCuentaContableD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance132.BackColor = System.Drawing.SystemColors.Window
        Appearance132.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboAFCuentaContableD.DisplayLayout.Appearance = Appearance132
        Me.cboAFCuentaContableD.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboAFCuentaContableD.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance133.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance133.BorderColor = System.Drawing.SystemColors.Window
        Me.cboAFCuentaContableD.DisplayLayout.GroupByBox.Appearance = Appearance133
        Appearance134.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboAFCuentaContableD.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance134
        Me.cboAFCuentaContableD.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance135.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance135.BackColor2 = System.Drawing.SystemColors.Control
        Appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance135.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboAFCuentaContableD.DisplayLayout.GroupByBox.PromptAppearance = Appearance135
        Me.cboAFCuentaContableD.DisplayLayout.MaxColScrollRegions = 1
        Me.cboAFCuentaContableD.DisplayLayout.MaxRowScrollRegions = 1
        Appearance136.BackColor = System.Drawing.SystemColors.Window
        Appearance136.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboAFCuentaContableD.DisplayLayout.Override.ActiveCellAppearance = Appearance136
        Appearance137.BackColor = System.Drawing.SystemColors.Window
        Me.cboAFCuentaContableD.DisplayLayout.Override.CardAreaAppearance = Appearance137
        Me.cboAFCuentaContableD.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboAFCuentaContableD.DisplayLayout.Override.CellPadding = 0
        Me.cboAFCuentaContableD.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance138.BackColor = System.Drawing.SystemColors.Control
        Appearance138.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance138.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance138.BorderColor = System.Drawing.SystemColors.Window
        Me.cboAFCuentaContableD.DisplayLayout.Override.GroupByRowAppearance = Appearance138
        Appearance139.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboAFCuentaContableD.DisplayLayout.Override.TemplateAddRowAppearance = Appearance139
        Me.cboAFCuentaContableD.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboAFCuentaContableD.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboAFCuentaContableD.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboAFCuentaContableD.DisplayMember = "Nombre"
        Me.cboAFCuentaContableD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboAFCuentaContableD.Location = New System.Drawing.Point(67, 55)
        Me.cboAFCuentaContableD.Name = "cboAFCuentaContableD"
        Me.cboAFCuentaContableD.Size = New System.Drawing.Size(331, 22)
        Me.cboAFCuentaContableD.TabIndex = 337
        Me.cboAFCuentaContableD.ValueMember = "Id"
        '
        'Etiqueta69
        '
        Me.Etiqueta69.AutoSize = True
        Me.Etiqueta69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta69.Location = New System.Drawing.Point(7, 60)
        Me.Etiqueta69.Name = "Etiqueta69"
        Me.Etiqueta69.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta69.TabIndex = 336
        Me.Etiqueta69.Text = "I.C. Items:"
        '
        'verActualD
        '
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Me.verActualD.Appearance = Appearance140
        Me.verActualD.Checked = True
        Me.verActualD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verActualD.Location = New System.Drawing.Point(262, 149)
        Me.verActualD.Name = "verActualD"
        Me.verActualD.Size = New System.Drawing.Size(55, 25)
        Me.verActualD.TabIndex = 335
        Me.verActualD.Text = "Actual"
        '
        'cboCtaDestinoD
        '
        Me.cboCtaDestinoD.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaDestinoD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance141.BackColor = System.Drawing.SystemColors.Window
        Appearance141.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboCtaDestinoD.DisplayLayout.Appearance = Appearance141
        Me.cboCtaDestinoD.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboCtaDestinoD.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance142.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance142.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance142.BorderColor = System.Drawing.SystemColors.Window
        Me.cboCtaDestinoD.DisplayLayout.GroupByBox.Appearance = Appearance142
        Appearance143.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCtaDestinoD.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance143
        Me.cboCtaDestinoD.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance144.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance144.BackColor2 = System.Drawing.SystemColors.Control
        Appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance144.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCtaDestinoD.DisplayLayout.GroupByBox.PromptAppearance = Appearance144
        Me.cboCtaDestinoD.DisplayLayout.MaxColScrollRegions = 1
        Me.cboCtaDestinoD.DisplayLayout.MaxRowScrollRegions = 1
        Appearance145.BackColor = System.Drawing.SystemColors.Window
        Appearance145.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboCtaDestinoD.DisplayLayout.Override.ActiveCellAppearance = Appearance145
        Appearance146.BackColor = System.Drawing.SystemColors.Window
        Me.cboCtaDestinoD.DisplayLayout.Override.CardAreaAppearance = Appearance146
        Me.cboCtaDestinoD.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboCtaDestinoD.DisplayLayout.Override.CellPadding = 0
        Me.cboCtaDestinoD.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance147.BackColor = System.Drawing.SystemColors.Control
        Appearance147.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance147.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance147.BorderColor = System.Drawing.SystemColors.Window
        Me.cboCtaDestinoD.DisplayLayout.Override.GroupByRowAppearance = Appearance147
        Appearance148.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboCtaDestinoD.DisplayLayout.Override.TemplateAddRowAppearance = Appearance148
        Me.cboCtaDestinoD.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboCtaDestinoD.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboCtaDestinoD.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboCtaDestinoD.DisplayMember = "Nombre"
        Me.cboCtaDestinoD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCtaDestinoD.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboCtaDestinoD.Location = New System.Drawing.Point(67, 105)
        Me.cboCtaDestinoD.Name = "cboCtaDestinoD"
        Me.cboCtaDestinoD.Size = New System.Drawing.Size(75, 22)
        Me.cboCtaDestinoD.TabIndex = 334
        Me.cboCtaDestinoD.ValueMember = "Id"
        '
        'cboCtaOrigenD
        '
        Me.cboCtaOrigenD.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaOrigenD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance149.BackColor = System.Drawing.SystemColors.Window
        Appearance149.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboCtaOrigenD.DisplayLayout.Appearance = Appearance149
        Me.cboCtaOrigenD.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboCtaOrigenD.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance150.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance150.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance150.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance150.BorderColor = System.Drawing.SystemColors.Window
        Me.cboCtaOrigenD.DisplayLayout.GroupByBox.Appearance = Appearance150
        Appearance151.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCtaOrigenD.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance151
        Me.cboCtaOrigenD.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance152.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance152.BackColor2 = System.Drawing.SystemColors.Control
        Appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance152.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboCtaOrigenD.DisplayLayout.GroupByBox.PromptAppearance = Appearance152
        Me.cboCtaOrigenD.DisplayLayout.MaxColScrollRegions = 1
        Me.cboCtaOrigenD.DisplayLayout.MaxRowScrollRegions = 1
        Appearance153.BackColor = System.Drawing.SystemColors.Window
        Appearance153.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboCtaOrigenD.DisplayLayout.Override.ActiveCellAppearance = Appearance153
        Appearance154.BackColor = System.Drawing.SystemColors.Window
        Me.cboCtaOrigenD.DisplayLayout.Override.CardAreaAppearance = Appearance154
        Me.cboCtaOrigenD.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboCtaOrigenD.DisplayLayout.Override.CellPadding = 0
        Me.cboCtaOrigenD.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance155.BackColor = System.Drawing.SystemColors.Control
        Appearance155.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance155.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance155.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance155.BorderColor = System.Drawing.SystemColors.Window
        Me.cboCtaOrigenD.DisplayLayout.Override.GroupByRowAppearance = Appearance155
        Appearance156.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboCtaOrigenD.DisplayLayout.Override.TemplateAddRowAppearance = Appearance156
        Me.cboCtaOrigenD.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboCtaOrigenD.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboCtaOrigenD.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboCtaOrigenD.DisplayMember = "Nombre"
        Me.cboCtaOrigenD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCtaOrigenD.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboCtaOrigenD.Location = New System.Drawing.Point(67, 80)
        Me.cboCtaOrigenD.Name = "cboCtaOrigenD"
        Me.cboCtaOrigenD.Size = New System.Drawing.Size(75, 22)
        Me.cboCtaOrigenD.TabIndex = 333
        Me.cboCtaOrigenD.ValueMember = "Id"
        '
        'txtObservacionD
        '
        Appearance157.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionD.Appearance = Appearance157
        Me.txtObservacionD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservacionD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionD.Location = New System.Drawing.Point(6, 131)
        Me.txtObservacionD.MaxLength = 10
        Me.txtObservacionD.Multiline = True
        Me.txtObservacionD.Name = "txtObservacionD"
        Me.txtObservacionD.Size = New System.Drawing.Size(250, 40)
        Me.txtObservacionD.TabIndex = 332
        '
        'btnAgregarD
        '
        Appearance158.Image = "add.ico"
        Me.btnAgregarD.Appearance = Appearance158
        Me.btnAgregarD.ImageList = Me.imagenes
        Me.btnAgregarD.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarD.Location = New System.Drawing.Point(368, 141)
        Me.btnAgregarD.Name = "btnAgregarD"
        Me.btnAgregarD.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarD.TabIndex = 331
        '
        'Etiqueta61
        '
        Me.Etiqueta61.AutoSize = True
        Me.Etiqueta61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta61.Location = New System.Drawing.Point(262, 35)
        Me.Etiqueta61.Name = "Etiqueta61"
        Me.Etiqueta61.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta61.TabIndex = 330
        Me.Etiqueta61.Text = "Importe:"
        '
        'decImporteD
        '
        Appearance159.ForeColor = System.Drawing.Color.Black
        Me.decImporteD.Appearance = Appearance159
        Me.decImporteD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decImporteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteD.ForeColor = System.Drawing.Color.Black
        Me.decImporteD.Location = New System.Drawing.Point(308, 31)
        Me.decImporteD.MaskInput = "{LOC}-nnnnnnnnnn.nn"
        Me.decImporteD.Name = "decImporteD"
        Me.decImporteD.NullText = "0.00"
        Me.decImporteD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteD.Size = New System.Drawing.Size(90, 21)
        Me.decImporteD.TabIndex = 329
        '
        'decValorD
        '
        Appearance160.ForeColor = System.Drawing.Color.Black
        Me.decValorD.Appearance = Appearance160
        Me.decValorD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decValorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorD.ForeColor = System.Drawing.Color.Black
        Me.decValorD.Location = New System.Drawing.Point(166, 31)
        Me.decValorD.MaskInput = "{LOC}-nnnnnnnnnn.nn"
        Me.decValorD.Name = "decValorD"
        Me.decValorD.NullText = "0.00"
        Me.decValorD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorD.Size = New System.Drawing.Size(90, 21)
        Me.decValorD.TabIndex = 327
        '
        'Etiqueta62
        '
        Me.Etiqueta62.AutoSize = True
        Me.Etiqueta62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta62.Location = New System.Drawing.Point(131, 35)
        Me.Etiqueta62.Name = "Etiqueta62"
        Me.Etiqueta62.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta62.TabIndex = 328
        Me.Etiqueta62.Text = "Valor:"
        '
        'txtCtaDestinoD
        '
        Me.txtCtaDestinoD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaDestinoD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaDestinoD.Location = New System.Drawing.Point(148, 105)
        Me.txtCtaDestinoD.Name = "txtCtaDestinoD"
        Me.txtCtaDestinoD.Size = New System.Drawing.Size(250, 21)
        Me.txtCtaDestinoD.TabIndex = 326
        '
        'txtCtaOrigenD
        '
        Me.txtCtaOrigenD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtaOrigenD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCtaOrigenD.Location = New System.Drawing.Point(148, 81)
        Me.txtCtaOrigenD.Name = "txtCtaOrigenD"
        Me.txtCtaOrigenD.Size = New System.Drawing.Size(250, 21)
        Me.txtCtaOrigenD.TabIndex = 325
        '
        'Etiqueta55
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta55.Appearance = Appearance161
        Me.Etiqueta55.AutoSize = True
        Me.Etiqueta55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta55.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta55.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta55.Location = New System.Drawing.Point(4, 85)
        Me.Etiqueta55.Name = "Etiqueta55"
        Me.Etiqueta55.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta55.TabIndex = 324
        Me.Etiqueta55.Text = "Cta.Origen:"
        '
        'Etiqueta56
        '
        Appearance162.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta56.Appearance = Appearance162
        Me.Etiqueta56.AutoSize = True
        Me.Etiqueta56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta56.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta56.ImageTransparentColor = System.Drawing.Color.Empty
        Me.Etiqueta56.Location = New System.Drawing.Point(-1, 110)
        Me.Etiqueta56.Name = "Etiqueta56"
        Me.Etiqueta56.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta56.TabIndex = 322
        Me.Etiqueta56.Text = "Cta.Destino:"
        '
        'Etiqueta53
        '
        Appearance163.FontData.Name = "Tahoma"
        Appearance163.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta53.Appearance = Appearance163
        Me.Etiqueta53.AutoSize = True
        Me.Etiqueta53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta53.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta53.Location = New System.Drawing.Point(37, 35)
        Me.Etiqueta53.Name = "Etiqueta53"
        Me.Etiqueta53.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta53.TabIndex = 320
        Me.Etiqueta53.Text = "Mes:"
        '
        'cboMesD
        '
        Appearance164.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesD.Appearance = Appearance164
        Me.cboMesD.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMesD.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMesD.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesD.Location = New System.Drawing.Point(67, 31)
        Me.cboMesD.Name = "cboMesD"
        Me.cboMesD.Size = New System.Drawing.Size(55, 21)
        Me.cboMesD.TabIndex = 319
        Me.cboMesD.ValueMember = "Id"
        '
        'AñoD
        '
        Me.AñoD.Año = 2020
        Me.AñoD.AutoSize = True
        Me.AñoD.Controls.Add(Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5)
        Me.AñoD.Controls.Add(Me.NumeroEntero7)
        Me.AñoD.Controls.Add(Me.NumeroEntero8)
        Me.AñoD.Controls.Add(Me.NumeroEntero9)
        Me.AñoD.Controls.Add(Me.NumeroEntero10)
        Me.AñoD.Controls.Add(Me.NumeroEntero11)
        Me.AñoD.Location = New System.Drawing.Point(67, 7)
        Me.AñoD.Name = "AñoD"
        Me.AñoD.Size = New System.Drawing.Size(56, 24)
        Me.AñoD.TabIndex = 318
        '
        'object_b3276692_4c30_4c88_ab83_8b127fe270b5
        '
        Appearance165.ForeColor = System.Drawing.Color.Black
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Appearance = Appearance165
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.ForeColor = System.Drawing.Color.Black
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.FormatString = ""
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Location = New System.Drawing.Point(1, 0)
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.MaskInput = "nnnn"
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.MaxValue = 2020
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.MinValue = 2000
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Name = "object_b3276692_4c30_4c88_ab83_8b127fe270b5"
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.NullText = "0"
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Size = New System.Drawing.Size(52, 21)
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.TabIndex = 0
        Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5.Value = 2014
        '
        'NumeroEntero7
        '
        Appearance166.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero7.Appearance = Appearance166
        Me.NumeroEntero7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero7.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero7.FormatString = ""
        Me.NumeroEntero7.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero7.MaskInput = "nnnn"
        Me.NumeroEntero7.MaxValue = 2020
        Me.NumeroEntero7.MinValue = 2000
        Me.NumeroEntero7.Name = "NumeroEntero7"
        Me.NumeroEntero7.NullText = "0"
        Me.NumeroEntero7.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero7.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero7.TabIndex = 0
        Me.NumeroEntero7.Value = 2014
        '
        'NumeroEntero8
        '
        Appearance167.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero8.Appearance = Appearance167
        Me.NumeroEntero8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero8.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero8.FormatString = ""
        Me.NumeroEntero8.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero8.MaskInput = "nnnn"
        Me.NumeroEntero8.MaxValue = 2020
        Me.NumeroEntero8.MinValue = 2000
        Me.NumeroEntero8.Name = "NumeroEntero8"
        Me.NumeroEntero8.NullText = "0"
        Me.NumeroEntero8.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero8.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero8.TabIndex = 0
        Me.NumeroEntero8.Value = 2014
        '
        'NumeroEntero9
        '
        Appearance168.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero9.Appearance = Appearance168
        Me.NumeroEntero9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero9.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero9.FormatString = ""
        Me.NumeroEntero9.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero9.MaskInput = "nnnn"
        Me.NumeroEntero9.MaxValue = 2020
        Me.NumeroEntero9.MinValue = 2000
        Me.NumeroEntero9.Name = "NumeroEntero9"
        Me.NumeroEntero9.NullText = "0"
        Me.NumeroEntero9.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero9.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero9.TabIndex = 0
        Me.NumeroEntero9.Value = 2013
        '
        'NumeroEntero10
        '
        Appearance169.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero10.Appearance = Appearance169
        Me.NumeroEntero10.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero10.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero10.FormatString = ""
        Me.NumeroEntero10.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero10.MaskInput = "nnnn"
        Me.NumeroEntero10.MaxValue = 2020
        Me.NumeroEntero10.MinValue = 2000
        Me.NumeroEntero10.Name = "NumeroEntero10"
        Me.NumeroEntero10.NullText = "0"
        Me.NumeroEntero10.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero10.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero10.TabIndex = 0
        Me.NumeroEntero10.Value = 2013
        '
        'NumeroEntero11
        '
        Appearance170.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero11.Appearance = Appearance170
        Me.NumeroEntero11.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero11.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero11.FormatString = ""
        Me.NumeroEntero11.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero11.MaskInput = "nnnn"
        Me.NumeroEntero11.MaxValue = 2020
        Me.NumeroEntero11.MinValue = 2000
        Me.NumeroEntero11.Name = "NumeroEntero11"
        Me.NumeroEntero11.NullText = "0"
        Me.NumeroEntero11.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero11.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero11.TabIndex = 0
        Me.NumeroEntero11.Value = 2012
        '
        'Etiqueta54
        '
        Appearance171.FontData.Name = "Tahoma"
        Appearance171.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta54.Appearance = Appearance171
        Me.Etiqueta54.AutoSize = True
        Me.Etiqueta54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta54.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta54.Location = New System.Drawing.Point(15, 11)
        Me.Etiqueta54.Name = "Etiqueta54"
        Me.Etiqueta54.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta54.TabIndex = 317
        Me.Etiqueta54.Text = "Ejercicio:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraExpandableGroupBox8)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1159, 369)
        '
        'UltraExpandableGroupBox9
        '
        Appearance114.BackColor = System.Drawing.Color.White
        Appearance114.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance114
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(1159, 244)
        Me.UltraExpandableGroupBox9.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox9.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(0, 125)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(1159, 244)
        Me.UltraExpandableGroupBox9.TabIndex = 308
        Me.UltraExpandableGroupBox9.Text = "Valores a la Fecha de la Consulta:"
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Etiqueta51)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.decReadecuacionesV)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Etiqueta49)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Etiqueta47)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.decValorLibroAlFecV)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.decVidaUtilRemanV)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.decDepreAcumuladaV)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Etiqueta48)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.Etiqueta50)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.decRevalAcumuladaV)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(1153, 221)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'Etiqueta51
        '
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta51.Location = New System.Drawing.Point(31, 88)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(139, 14)
        Me.Etiqueta51.TabIndex = 308
        Me.Etiqueta51.Text = "Valor Libro al XX/XX/XXXX:"
        '
        'decReadecuacionesV
        '
        Appearance115.ForeColor = System.Drawing.Color.Black
        Me.decReadecuacionesV.Appearance = Appearance115
        Me.decReadecuacionesV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decReadecuacionesV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decReadecuacionesV.ForeColor = System.Drawing.Color.Black
        Me.decReadecuacionesV.Location = New System.Drawing.Point(173, 8)
        Me.decReadecuacionesV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decReadecuacionesV.Name = "decReadecuacionesV"
        Me.decReadecuacionesV.NullText = "0.00"
        Me.decReadecuacionesV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decReadecuacionesV.ReadOnly = True
        Me.decReadecuacionesV.Size = New System.Drawing.Size(90, 21)
        Me.decReadecuacionesV.TabIndex = 306
        '
        'Etiqueta49
        '
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta49.Location = New System.Drawing.Point(40, 58)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(128, 14)
        Me.Etiqueta49.TabIndex = 319
        Me.Etiqueta49.Text = "Depreciacion acumulada:"
        '
        'Etiqueta47
        '
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta47.Location = New System.Drawing.Point(80, 12)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(89, 14)
        Me.Etiqueta47.TabIndex = 307
        Me.Etiqueta47.Text = "Readecuaciones:"
        '
        'decValorLibroAlFecV
        '
        Appearance116.ForeColor = System.Drawing.Color.Black
        Me.decValorLibroAlFecV.Appearance = Appearance116
        Me.decValorLibroAlFecV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decValorLibroAlFecV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorLibroAlFecV.ForeColor = System.Drawing.Color.Black
        Me.decValorLibroAlFecV.Location = New System.Drawing.Point(173, 84)
        Me.decValorLibroAlFecV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decValorLibroAlFecV.Name = "decValorLibroAlFecV"
        Me.decValorLibroAlFecV.NullText = "0.00"
        Me.decValorLibroAlFecV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorLibroAlFecV.ReadOnly = True
        Me.decValorLibroAlFecV.Size = New System.Drawing.Size(90, 21)
        Me.decValorLibroAlFecV.TabIndex = 307
        '
        'decVidaUtilRemanV
        '
        Appearance117.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilRemanV.Appearance = Appearance117
        Me.decVidaUtilRemanV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decVidaUtilRemanV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decVidaUtilRemanV.ForeColor = System.Drawing.Color.Black
        Me.decVidaUtilRemanV.Location = New System.Drawing.Point(430, 8)
        Me.decVidaUtilRemanV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decVidaUtilRemanV.Name = "decVidaUtilRemanV"
        Me.decVidaUtilRemanV.NullText = "0.00"
        Me.decVidaUtilRemanV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decVidaUtilRemanV.ReadOnly = True
        Me.decVidaUtilRemanV.Size = New System.Drawing.Size(90, 21)
        Me.decVidaUtilRemanV.TabIndex = 308
        '
        'decDepreAcumuladaV
        '
        Appearance118.ForeColor = System.Drawing.Color.Black
        Me.decDepreAcumuladaV.Appearance = Appearance118
        Me.decDepreAcumuladaV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decDepreAcumuladaV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDepreAcumuladaV.ForeColor = System.Drawing.Color.Black
        Me.decDepreAcumuladaV.Location = New System.Drawing.Point(173, 54)
        Me.decDepreAcumuladaV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decDepreAcumuladaV.Name = "decDepreAcumuladaV"
        Me.decDepreAcumuladaV.NullText = "0.00"
        Me.decDepreAcumuladaV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDepreAcumuladaV.ReadOnly = True
        Me.decDepreAcumuladaV.Size = New System.Drawing.Size(90, 21)
        Me.decDepreAcumuladaV.TabIndex = 318
        '
        'Etiqueta48
        '
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta48.Location = New System.Drawing.Point(318, 12)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(108, 14)
        Me.Etiqueta48.TabIndex = 309
        Me.Etiqueta48.Text = "Vida Util Remanente:"
        '
        'Etiqueta50
        '
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta50.Location = New System.Drawing.Point(32, 35)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(136, 14)
        Me.Etiqueta50.TabIndex = 317
        Me.Etiqueta50.Text = "Revalorizacion acumulada:"
        '
        'decRevalAcumuladaV
        '
        Appearance119.ForeColor = System.Drawing.Color.Black
        Me.decRevalAcumuladaV.Appearance = Appearance119
        Me.decRevalAcumuladaV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decRevalAcumuladaV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decRevalAcumuladaV.ForeColor = System.Drawing.Color.Black
        Me.decRevalAcumuladaV.Location = New System.Drawing.Point(173, 31)
        Me.decRevalAcumuladaV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decRevalAcumuladaV.Name = "decRevalAcumuladaV"
        Me.decRevalAcumuladaV.NullText = "0.00"
        Me.decRevalAcumuladaV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decRevalAcumuladaV.ReadOnly = True
        Me.decRevalAcumuladaV.Size = New System.Drawing.Size(90, 21)
        Me.decRevalAcumuladaV.TabIndex = 316
        '
        'UltraExpandableGroupBox8
        '
        Appearance120.BackColor = System.Drawing.Color.White
        Appearance120.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox8.ContentAreaAppearance = Appearance120
        Me.UltraExpandableGroupBox8.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.UltraExpandableGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox8.ExpandedSize = New System.Drawing.Size(1159, 125)
        Me.UltraExpandableGroupBox8.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox8.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox8.Name = "UltraExpandableGroupBox8"
        Me.UltraExpandableGroupBox8.Size = New System.Drawing.Size(1159, 125)
        Me.UltraExpandableGroupBox8.TabIndex = 307
        Me.UltraExpandableGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.fecConsultaV)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta43)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta46)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.btn_Valorizar)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.decValorBrutoInicialV)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.decValorCompraLibroV)
        Me.UltraExpandableGroupBoxPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(3, 18)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(1153, 104)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        '
        'fecConsultaV
        '
        Me.fecConsultaV.CustomFormat = "dd/MM/yyyy"
        Me.fecConsultaV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecConsultaV.Location = New System.Drawing.Point(173, 10)
        Me.fecConsultaV.Name = "fecConsultaV"
        Me.fecConsultaV.Size = New System.Drawing.Size(90, 20)
        Me.fecConsultaV.TabIndex = 306
        '
        'Etiqueta43
        '
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta43.Location = New System.Drawing.Point(85, 13)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(84, 14)
        Me.Etiqueta43.TabIndex = 297
        Me.Etiqueta43.Text = "Fecha Consulta:"
        '
        'Etiqueta46
        '
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta46.Location = New System.Drawing.Point(77, 66)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(92, 14)
        Me.Etiqueta46.TabIndex = 305
        Me.Etiqueta46.Text = "Valor bruto Inicial:"
        '
        'btn_Valorizar
        '
        Me.btn_Valorizar.Location = New System.Drawing.Point(269, 3)
        Me.btn_Valorizar.Name = "btn_Valorizar"
        Me.btn_Valorizar.Size = New System.Drawing.Size(80, 33)
        Me.btn_Valorizar.TabIndex = 299
        Me.btn_Valorizar.Text = "&Valorizar"
        '
        'decValorBrutoInicialV
        '
        Appearance121.ForeColor = System.Drawing.Color.Black
        Me.decValorBrutoInicialV.Appearance = Appearance121
        Me.decValorBrutoInicialV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decValorBrutoInicialV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorBrutoInicialV.ForeColor = System.Drawing.Color.Black
        Me.decValorBrutoInicialV.Location = New System.Drawing.Point(173, 62)
        Me.decValorBrutoInicialV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decValorBrutoInicialV.Name = "decValorBrutoInicialV"
        Me.decValorBrutoInicialV.NullText = "0.00"
        Me.decValorBrutoInicialV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorBrutoInicialV.ReadOnly = True
        Me.decValorBrutoInicialV.Size = New System.Drawing.Size(90, 21)
        Me.decValorBrutoInicialV.TabIndex = 304
        '
        'Etiqueta45
        '
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta45.Location = New System.Drawing.Point(1, 43)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(168, 14)
        Me.Etiqueta45.TabIndex = 303
        Me.Etiqueta45.Text = "Valor Compra / Valor Libro Inicial:"
        '
        'decValorCompraLibroV
        '
        Appearance122.ForeColor = System.Drawing.Color.Black
        Me.decValorCompraLibroV.Appearance = Appearance122
        Me.decValorCompraLibroV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.decValorCompraLibroV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorCompraLibroV.ForeColor = System.Drawing.Color.Black
        Me.decValorCompraLibroV.Location = New System.Drawing.Point(173, 39)
        Me.decValorCompraLibroV.MaskInput = "{LOC}nnnnnnn.nnnn"
        Me.decValorCompraLibroV.Name = "decValorCompraLibroV"
        Me.decValorCompraLibroV.NullText = "0.00"
        Me.decValorCompraLibroV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorCompraLibroV.ReadOnly = True
        Me.decValorCompraLibroV.Size = New System.Drawing.Size(90, 21)
        Me.decValorCompraLibroV.TabIndex = 302
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.tabAdicionalAF)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1161, 538)
        '
        'tabAdicionalAF
        '
        Appearance57.BackColor = System.Drawing.Color.White
        Appearance57.BackColor2 = System.Drawing.Color.White
        Me.tabAdicionalAF.ClientAreaAppearance = Appearance57
        Me.tabAdicionalAF.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabAdicionalAF.Controls.Add(Me.utpActivosFijos)
        Me.tabAdicionalAF.Controls.Add(Me.utpListaDAF)
        Me.tabAdicionalAF.Controls.Add(Me.utpDepreciarActivos)
        Me.tabAdicionalAF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionalAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicionalAF.Location = New System.Drawing.Point(0, 0)
        Me.tabAdicionalAF.Name = "tabAdicionalAF"
        Me.tabAdicionalAF.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabAdicionalAF.Size = New System.Drawing.Size(1161, 538)
        Me.tabAdicionalAF.TabIndex = 314
        UltraTab1.TabPage = Me.utpActivosFijos
        UltraTab1.Text = "Activos Fijos"
        UltraTab5.TabPage = Me.utpDepreciarActivos
        UltraTab5.Text = "Depreciación Activos"
        UltraTab3.TabPage = Me.utpListaDAF
        UltraTab3.Text = "Extornar Asientos"
        Me.tabAdicionalAF.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab5, UltraTab3})
        Me.tabAdicionalAF.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1157, 515)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficDatosAF)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox12)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1161, 538)
        '
        'ficDatosAF
        '
        Appearance58.BackColor = System.Drawing.Color.White
        Appearance58.BackColor2 = System.Drawing.Color.White
        Me.ficDatosAF.ClientAreaAppearance = Appearance58
        Me.ficDatosAF.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDatosAF.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDatosAF.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDatosAF.Controls.Add(Me.UltraTabPageControl10)
        Me.ficDatosAF.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDatosAF.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDatosAF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDatosAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDatosAF.Location = New System.Drawing.Point(0, 146)
        Me.ficDatosAF.Name = "ficDatosAF"
        Me.ficDatosAF.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDatosAF.Size = New System.Drawing.Size(1161, 392)
        Me.ficDatosAF.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficDatosAF.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Datos Ingreso"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Informacion Contable"
        UltraTab11.TabPage = Me.UltraTabPageControl10
        UltraTab11.Text = "Adiciones/Retiros"
        UltraTab19.TabPage = Me.UltraTabPageControl7
        UltraTab19.Text = "Depreciacion"
        UltraTab19.Visible = False
        UltraTab20.TabPage = Me.UltraTabPageControl4
        UltraTab20.Text = "Valorizacion"
        UltraTab20.Visible = False
        Me.ficDatosAF.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab6, UltraTab11, UltraTab19, UltraTab20})
        Me.ficDatosAF.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1159, 369)
        '
        'UltraExpandableGroupBox12
        '
        Appearance172.BackColor = System.Drawing.Color.White
        Appearance172.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox12.ContentAreaAppearance = Appearance172
        Me.UltraExpandableGroupBox12.Controls.Add(Me.expandablecabecera)
        Me.UltraExpandableGroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox12.ExpandedSize = New System.Drawing.Size(1161, 146)
        Me.UltraExpandableGroupBox12.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox12.Name = "UltraExpandableGroupBox12"
        Me.UltraExpandableGroupBox12.Size = New System.Drawing.Size(1161, 146)
        Me.UltraExpandableGroupBox12.TabIndex = 0
        Me.UltraExpandableGroupBox12.Text = "Datos Generales"
        Me.UltraExpandableGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'expandablecabecera
        '
        Me.expandablecabecera.Controls.Add(Me.agrDepende)
        Me.expandablecabecera.Controls.Add(Me.txtIdentificador)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta35)
        Me.expandablecabecera.Controls.Add(Me.cboEstadoAF)
        Me.expandablecabecera.Controls.Add(Me.cboCentro)
        Me.expandablecabecera.Controls.Add(Me.cboResponsable)
        Me.expandablecabecera.Controls.Add(Me.txtDescripcionDetallada)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta3)
        Me.expandablecabecera.Controls.Add(Me.chkPropio)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta6)
        Me.expandablecabecera.Controls.Add(Me.UltraLabel6)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta67)
        Me.expandablecabecera.Controls.Add(Me.txtCodigo)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta1)
        Me.expandablecabecera.Controls.Add(Me.txtDescripcionResumida)
        Me.expandablecabecera.Controls.Add(Me.Etiqueta2)
        Me.expandablecabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expandablecabecera.Location = New System.Drawing.Point(3, 20)
        Me.expandablecabecera.Name = "expandablecabecera"
        Me.expandablecabecera.Size = New System.Drawing.Size(1155, 123)
        Me.expandablecabecera.TabIndex = 0
        '
        'agrDepende
        '
        Me.agrDepende.Controls.Add(Me.txtActivoFijo)
        Me.agrDepende.Controls.Add(Me.cboActivoFijo)
        Me.agrDepende.Controls.Add(Me.chkDepende)
        Me.agrDepende.Location = New System.Drawing.Point(702, 3)
        Me.agrDepende.Name = "agrDepende"
        Me.agrDepende.Size = New System.Drawing.Size(298, 117)
        Me.agrDepende.TabIndex = 334
        Me.agrDepende.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtActivoFijo
        '
        Appearance173.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtActivoFijo.Appearance = Appearance173
        Me.txtActivoFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActivoFijo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtActivoFijo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivoFijo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtActivoFijo.Location = New System.Drawing.Point(9, 58)
        Me.txtActivoFijo.MaxLength = 200
        Me.txtActivoFijo.Multiline = True
        Me.txtActivoFijo.Name = "txtActivoFijo"
        Me.txtActivoFijo.Size = New System.Drawing.Size(282, 51)
        Me.txtActivoFijo.TabIndex = 336
        '
        'cboActivoFijo
        '
        Me.cboActivoFijo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboActivoFijo.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboActivoFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboActivoFijo.DisplayMember = "Nombre"
        Me.cboActivoFijo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboActivoFijo.DropDownListWidth = -1
        Me.cboActivoFijo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActivoFijo.Location = New System.Drawing.Point(9, 31)
        Me.cboActivoFijo.Name = "cboActivoFijo"
        Me.cboActivoFijo.Size = New System.Drawing.Size(282, 22)
        Me.cboActivoFijo.TabIndex = 335
        Me.cboActivoFijo.ValueMember = "Id"
        '
        'chkDepende
        '
        Me.chkDepende.AutoSize = True
        Me.chkDepende.BackColor = System.Drawing.Color.Transparent
        Me.chkDepende.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkDepende.Location = New System.Drawing.Point(9, 8)
        Me.chkDepende.Name = "chkDepende"
        Me.chkDepende.Size = New System.Drawing.Size(75, 18)
        Me.chkDepende.TabIndex = 335
        Me.chkDepende.Text = "Mejora de:"
        '
        'txtIdentificador
        '
        Appearance174.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIdentificador.Appearance = Appearance174
        Me.txtIdentificador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdentificador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtIdentificador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIdentificador.Location = New System.Drawing.Point(526, 9)
        Me.txtIdentificador.MaxLength = 20
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.Size = New System.Drawing.Size(163, 22)
        Me.txtIdentificador.TabIndex = 2
        '
        'Etiqueta35
        '
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta35.Appearance = Appearance175
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(486, 13)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta35.TabIndex = 333
        Me.Etiqueta35.Text = "Serial:"
        '
        'cboEstadoAF
        '
        Me.cboEstadoAF.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoAF.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboEstadoAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEstadoAF.DisplayMember = "Nombre"
        Me.cboEstadoAF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboEstadoAF.DropDownListWidth = -1
        Me.cboEstadoAF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoAF.Location = New System.Drawing.Point(526, 34)
        Me.cboEstadoAF.Name = "cboEstadoAF"
        Me.cboEstadoAF.Size = New System.Drawing.Size(163, 22)
        Me.cboEstadoAF.TabIndex = 4
        Me.cboEstadoAF.ValueMember = "Id"
        '
        'cboCentro
        '
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboCentro.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.StartsWith
        Me.cboCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCentro.DropDownListWidth = -1
        Me.cboCentro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.Location = New System.Drawing.Point(86, 9)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(147, 22)
        Me.cboCentro.TabIndex = 1
        Me.cboCentro.ValueMember = "Descripcion"
        '
        'cboResponsable
        '
        Me.cboResponsable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboResponsable.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsable.DisplayMember = "Nombre"
        Me.cboResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboResponsable.DropDownListWidth = -1
        Me.cboResponsable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.Location = New System.Drawing.Point(86, 59)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(331, 22)
        Me.cboResponsable.TabIndex = 5
        Me.cboResponsable.ValueMember = "Id"
        '
        'txtDescripcionDetallada
        '
        Appearance176.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionDetallada.Appearance = Appearance176
        Me.txtDescripcionDetallada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDetallada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescripcionDetallada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionDetallada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionDetallada.Location = New System.Drawing.Point(86, 85)
        Me.txtDescripcionDetallada.MaxLength = 200
        Me.txtDescripcionDetallada.Multiline = True
        Me.txtDescripcionDetallada.Name = "txtDescripcionDetallada"
        Me.txtDescripcionDetallada.Size = New System.Drawing.Size(603, 27)
        Me.txtDescripcionDetallada.TabIndex = 7
        '
        'Etiqueta3
        '
        Appearance177.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance177
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(17, 85)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(65, 15)
        Me.Etiqueta3.TabIndex = 331
        Me.Etiqueta3.Text = "Descripción:"
        '
        'chkPropio
        '
        Me.chkPropio.AutoSize = True
        Me.chkPropio.BackColor = System.Drawing.Color.Transparent
        Me.chkPropio.ForeColor = System.Drawing.Color.Navy
        Me.chkPropio.Location = New System.Drawing.Point(430, 62)
        Me.chkPropio.Name = "chkPropio"
        Me.chkPropio.Size = New System.Drawing.Size(56, 17)
        Me.chkPropio.TabIndex = 6
        Me.chkPropio.Text = "Propio"
        Me.chkPropio.UseVisualStyleBackColor = False
        '
        'Etiqueta6
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance178
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(427, 38)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(94, 15)
        Me.Etiqueta6.TabIndex = 232
        Me.Etiqueta6.Text = "Estado del Activo:"
        '
        'UltraLabel6
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Appearance179.ForeColor = System.Drawing.Color.Navy
        Appearance179.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance179
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(17, 12)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(66, 15)
        Me.UltraLabel6.TabIndex = 319
        Me.UltraLabel6.Text = "Sede Activo:"
        '
        'Etiqueta67
        '
        Appearance180.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta67.Appearance = Appearance180
        Me.Etiqueta67.AutoSize = True
        Me.Etiqueta67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta67.Location = New System.Drawing.Point(11, 63)
        Me.Etiqueta67.Name = "Etiqueta67"
        Me.Etiqueta67.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta67.TabIndex = 317
        Me.Etiqueta67.Text = "Responsable:"
        '
        'txtCodigo
        '
        Appearance181.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance181
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(290, 9)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(127, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Etiqueta1
        '
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance182
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(244, 12)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Codigo:"
        '
        'txtDescripcionResumida
        '
        Appearance183.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionResumida.Appearance = Appearance183
        Me.txtDescripcionResumida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionResumida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescripcionResumida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionResumida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionResumida.Location = New System.Drawing.Point(86, 34)
        Me.txtDescripcionResumida.MaxLength = 200
        Me.txtDescripcionResumida.Name = "txtDescripcionResumida"
        Me.txtDescripcionResumida.Size = New System.Drawing.Size(331, 22)
        Me.txtDescripcionResumida.TabIndex = 3
        '
        'Etiqueta2
        '
        Appearance184.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance184
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(1, 37)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(81, 15)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Nombre Activo:"
        '
        'ficActivoFijo
        '
        Me.ficActivoFijo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficActivoFijo.Controls.Add(Me.UltraTabPageControl1)
        Me.ficActivoFijo.Controls.Add(Me.UltraTabPageControl2)
        Me.ficActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficActivoFijo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficActivoFijo.Location = New System.Drawing.Point(0, 0)
        Me.ficActivoFijo.Name = "ficActivoFijo"
        Me.ficActivoFijo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficActivoFijo.Size = New System.Drawing.Size(1163, 561)
        Me.ficActivoFijo.TabIndex = 1
        UltraTab21.TabPage = Me.UltraTabPageControl1
        UltraTab21.Text = "Lista"
        UltraTab22.TabPage = Me.UltraTabPageControl2
        UltraTab22.Text = "Mantenimiento"
        Me.ficActivoFijo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab21, UltraTab22})
        Me.ficActivoFijo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1161, 538)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_ActivoFijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1163, 561)
        Me.Controls.Add(Me.ficActivoFijo)
        Me.KeyPreview = True
        Me.Name = "frm_ActivoFijo"
        Me.Text = "Activo Fijo"
        Me.tapListaReadecuaciones.ResumeLayout(False)
        Me.tapListaReadecuaciones.PerformLayout()
        CType(Me.griReadecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdReadecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListaReadecuaciones.ResumeLayout(False)
        Me.tspListaReadecuaciones.PerformLayout()
        Me.tapMantReadecuaciones.ResumeLayout(False)
        Me.tapMantReadecuaciones.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.griReadecuacionAFDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsReadecuacionAFDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspDocAsocReadecuacion.ResumeLayout(False)
        Me.tspDocAsocReadecuacion.PerformLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.cboTipoDocReadecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtNumeroReadecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieReadecuacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        Me.UltraGroupBox8.PerformLayout()
        CType(Me.decMontoAgregarActR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoAgregarVR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decVidaUtilAgregarR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoR.ResumeLayout(False)
        Me.AñoR.PerformLayout()
        CType(Me.object_a3320913_f3cf_4a9f_9d48_683a67c44781, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspMantReadecuaciones.ResumeLayout(False)
        Me.tspMantReadecuaciones.PerformLayout()
        Me.utpActivosFijos.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsListado.ResumeLayout(False)
        CType(Me.udsActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDepreciarActivos.ResumeLayout(False)
        CType(Me.griDepreciacionActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsDepActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        Me.UltraGroupBox7.PerformLayout()
        CType(Me.ColorFilaEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoDepActivos.ResumeLayout(False)
        Me.AñoDepActivos.PerformLayout()
        CType(Me.object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesDepActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpListaDAF.ResumeLayout(False)
        CType(Me.griAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox17.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.PerformLayout()
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox11.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel14.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel14.PerformLayout()
        CType(Me.txtNroAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verNroAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesListaDAF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.ugbSinDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbSinDocumento.ResumeLayout(False)
        Me.ugbSinDocumento.PerformLayout()
        CType(Me.uneCosto2012, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneDep2015, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneDep2014, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorLibroSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decDepreciacionAcumuladaSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decVidaUtilRemanenteSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decRevalorizacionAcumuladaSC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugbConDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbConDoc.ResumeLayout(False)
        Me.ugbConDoc.PerformLayout()
        CType(Me.uneValorCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumentoIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decVidaUtilIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMetodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCCUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgCentroCostoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSubGrupoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneValorResidual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptoIngresoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndFecActivacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantidadAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConjuntoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uegbDatosBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uegbDatosBaja.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.PerformLayout()
        CType(Me.ugbDocumentoBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbDocumentoBaja.ResumeLayout(False)
        Me.ugbDocumentoBaja.PerformLayout()
        CType(Me.txtTipoDocBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.txtSerieBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptoBajaAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl6.PerformLayout()
        CType(Me.griAFCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsAFCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspInformacionContable.ResumeLayout(False)
        Me.tspInformacionContable.PerformLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.txtGastoFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDesactivacionDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDesactivacionD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaReadecuacionHH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDepreciacionHH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaRevalorizacionHH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCompraHH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaReadecuacionDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDepreciacionDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaRevalorizacionDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaReadecuacionH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDepreciacionH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaRevalorizacionH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCompraH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCompraD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaReadecuacionD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDepreciacionD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaRevalorizacionD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroLeasingIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcTipoAdquisicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaCompraDD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoIC.ResumeLayout(False)
        Me.AñoIC.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.utcReadecuaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcReadecuaciones.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox16.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel19.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel19.PerformLayout()
        CType(Me.cboAFCuentaContableD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActualD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaDestinoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaOrigenD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImporteD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaDestinoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCtaOrigenD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoD.ResumeLayout(False)
        Me.AñoD.PerformLayout()
        CType(Me.object_b3276692_4c30_4c88_ab83_8b127fe270b5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.PerformLayout()
        CType(Me.decReadecuacionesV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorLibroAlFecV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decVidaUtilRemanV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decDepreAcumuladaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decRevalAcumuladaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox8.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.PerformLayout()
        CType(Me.decValorBrutoInicialV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorCompraLibroV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.tabAdicionalAF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdicionalAF.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDatosAF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDatosAF.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox12.ResumeLayout(False)
        Me.expandablecabecera.ResumeLayout(False)
        Me.expandablecabecera.PerformLayout()
        CType(Me.agrDepende, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDepende.ResumeLayout(False)
        Me.agrDepende.PerformLayout()
        CType(Me.txtActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDepende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentificador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionDetallada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionResumida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficActivoFijo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficActivoFijo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ficDatosAF As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uegbDatosBaja As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents txtDescripcionBaja As ISL.Controles.Texto
    Friend WithEvents numCantidadAF As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents chkConjuntoAF As ISL.Controles.Chequear
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents opcTipoAdquisicion As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Etiqueta60 As ISL.Controles.Etiqueta
    Friend WithEvents decMontoAgregarActR As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta59 As ISL.Controles.Etiqueta
    Friend WithEvents txtObservacionR As ISL.Controles.Texto
    Friend WithEvents decMontoAgregarVR As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta58 As ISL.Controles.Etiqueta
    Friend WithEvents decVidaUtilAgregarR As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta57 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents decReadecuacionesV As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents decValorLibroAlFecV As ISL.Controles.NumeroDecimal
    Friend WithEvents decVidaUtilRemanV As ISL.Controles.NumeroDecimal
    Friend WithEvents decDepreAcumuladaV As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents decRevalAcumuladaV As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraExpandableGroupBox8 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents btn_Valorizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents decValorBrutoInicialV As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents decValorCompraLibroV As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents decValorLibroSC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents decVidaUtilRemanenteSC As ISL.Controles.NumeroDecimal
    Friend WithEvents decRevalorizacionAcumuladaSC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents decDepreciacionAcumuladaSC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents decVidaUtilIC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumentoIC As ISL.Controles.Texto
    Friend WithEvents UltraExpandableGroupBox12 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents expandablecabecera As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents txtDescripcionResumida As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox16 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel19 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griDepreciacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdDepreciacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udsActivoFijo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents etiProveedor As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaCompraDD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents AñoIC As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents object_affad419_86ca_48bd_b401_1f51c77e4ae9 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents udsAFCuentaContable As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griReadecuacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesR As ISL.Controles.Combo
    Friend WithEvents AñoR As ISL.Win.Año
    Friend WithEvents object_a3320913_f3cf_4a9f_9d48_683a67c44781 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero6 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents ogdReadecuacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtObservacionD As ISL.Controles.Texto
    Friend WithEvents btnAgregarD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Etiqueta61 As ISL.Controles.Etiqueta
    Friend WithEvents decImporteD As ISL.Controles.NumeroDecimal
    Friend WithEvents decValorD As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta62 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaDestinoD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaOrigenD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta55 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta56 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta53 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesD As ISL.Controles.Combo
    Friend WithEvents AñoD As ISL.Win.Año
    Friend WithEvents object_b3276692_4c30_4c88_ab83_8b127fe270b5 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero7 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero8 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero9 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero10 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero11 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta54 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta66 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta67 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaDestinoD As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboCtaOrigenD As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbgMaterial As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkMaterial As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verActualD As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents opcTipoDocumento As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents verIndBaja As ISL.Controles.Chequear
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboAFCuentaContableD As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Etiqueta69 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents verIndFecActivacion As ISL.Controles.Chequear
    Friend WithEvents tabAdicionalAF As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpListaDAF As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents griAsiento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBox17 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents Etiqueta93 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesListaDAF As ISL.Controles.Combo
    Friend WithEvents Etiqueta94 As ISL.Controles.Etiqueta
    Friend WithEvents AñoListaDAF As ISL.Win.Año
    Friend WithEvents UltraExpandableGroupBox11 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel14 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents verNroAsiento As ISL.Controles.Chequear
    Friend WithEvents btnEliminarDepreciaciones As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnConsultarAsiento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtNroAsiento As ISL.Controles.Texto
    Friend WithEvents Etiqueta87 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroLeasingIC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utpActivosFijos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents fecIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecActivacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugbSinDocumento As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents rbtSituacionAFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInformacionCompra As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscarDoc As System.Windows.Forms.Button
    Friend WithEvents fecCompraIC As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecSituacionCtble As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDepreciable As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropio As System.Windows.Forms.CheckBox
    Friend WithEvents txtDescripcionDetallada As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uneValorResidual As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboResponsable As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboCentro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboEstadoAF As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboConceptoIngresoAF As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboSubGrupoAF As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboGrupoAF As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cbgCentroCostoAF As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboCCUbicaciones As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtProveedor As ISL.Controles.Texto
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tspInformacionContable As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboConceptoBajaAF As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tspMantReadecuaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAceptarReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelarReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents griAFCuentaContable As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtTipoDocumento As ISL.Controles.Texto
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents uneValorCompra As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents fecConsultaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents ugbConDoc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utpDepreciarActivos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents AñoDepActivos As ISL.Win.Año
    Friend WithEvents object_e0e25adf_3744_46ec_8a08_c3c6505cf0cd As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero12 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero13 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero14 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero15 As ISL.Controles.NumeroEntero
    Friend WithEvents btnValidarDepreciacion As System.Windows.Forms.Button
    Friend WithEvents cboMesDepActivos As ISL.Controles.Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents griDepreciacionActivos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udsDepActivos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaReadecuacionH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaDepreciacionH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta63 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta64 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaRevalorizacionH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta65 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaCompraH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta68 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta70 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta85 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta86 As ISL.Controles.Etiqueta
    Friend WithEvents txtCtaCompraD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaReadecuacionD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaDepreciacionD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaRevalorizacionD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaReadecuacionHH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaDepreciacionHH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaRevalorizacionHH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaCompraHH As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaReadecuacionDD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaDepreciacionDD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaRevalorizacionDD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents udsAsiento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnExtornarAsiento As System.Windows.Forms.Button
    Friend WithEvents cmsListado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itemReclasificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerieReadecuacion As ISL.Controles.Texto
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents txtNumeroReadecuacion As ISL.Controles.Texto
    Friend WithEvents griReadecuacionAFDocumento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents itemBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspListaReadecuaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents utcReadecuaciones As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tapListaReadecuaciones As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tapMantReadecuaciones As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tspDocAsocReadecuacion As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarReadecuacionDoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarReadecuacionDoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugbDocumentoBaja As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerieBaja As ISL.Controles.Texto
    Friend WithEvents txtNumeroBaja As ISL.Controles.Texto
    Friend WithEvents udsReadecuacionAFDocumento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscarDocReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscarDocBaja As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboTipoDocReadecuacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtTipoDocBaja As ISL.Controles.Texto
    Friend WithEvents txtCtaDesactivacionDD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCtaDesactivacionD As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtGastoFuncion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents tsbEditarReadecuacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents fecReadecuacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents uneCosto2012 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents uneDep2015 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents uneDep2014 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents txtIdentificador As ISL.Controles.Texto
    Friend WithEvents cboDepreciacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents numPorcentaje As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Etiqueta72 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta71 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroAutorizacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboMetodo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents agrDepende As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtActivoFijo As ISL.Controles.Texto
    Friend WithEvents cboActivoFijo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkDepende As Infragistics.Win.UltraWinEditors.UltraCheckEditor

End Class
