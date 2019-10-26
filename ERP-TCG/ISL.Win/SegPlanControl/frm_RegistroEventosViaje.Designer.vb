<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegistroEventosViaje
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHora")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHora")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViaje")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEvento")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RegistroEventosViaje))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIncidencia")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoEvento")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GuardarEstado", 0)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEvento")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArea")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIncidencia")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViaje")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoEvento")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHora")
        Dim UltraGridColumn545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHora")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
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
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccionar")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEvento")
        Dim UltraGridColumn564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIncidencia")
        Dim UltraGridColumn577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoEvento")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHora")
        Dim UltraGridColumn591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denuncia")
        Dim UltraGridColumn598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHoraDenuncia")
        Dim UltraGridColumn599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dosaje")
        Dim UltraGridColumn600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHoraDosaje")
        Dim UltraGridColumn601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHora")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Denuncia")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHoraDenuncia")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dosaje")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHoraDosaje")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEvento")
        Dim UltraGridColumn612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIncidencia")
        Dim UltraGridColumn625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoEvento")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
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
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHora", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHora")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEvento")
        Dim UltraGridColumn660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraGridColumn664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIncidencia")
        Dim UltraGridColumn673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoEvento")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
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
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHora")
        Dim UltraGridColumn739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denuncia")
        Dim UltraGridColumn818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaHoraDenuncia")
        Dim UltraGridColumn819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoEvento")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoEvento")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipo")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHora")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Denuncia")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaHoraDenuncia")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEvento")
        Dim UltraGridColumn830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEvento")
        Dim UltraGridColumn831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEvento")
        Dim UltraGridColumn832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArea")
        Dim UltraGridColumn833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn885 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn886 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn887 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipo")
        Dim UltraGridColumn888 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIncidencia")
        Dim UltraGridColumn889 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn890 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn891 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn892 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn893 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn894 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoEvento")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn895 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn896 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn897 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn898 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
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
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.cboLugarIncidente = New ISL.Controles.Combo(Me.components)
        Me.cboLugarRobo = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaIncidencia = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdEventos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaCerrarIncidencia = New ISL.Controles.Grilla(Me.components)
        Me.ogdAreaResponsable = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboAreaBuscar = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griListaAlarmas = New ISL.Controles.Grilla(Me.components)
        Me.ogdAlarma = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservacionAlarma = New ISL.Controles.Texto(Me.components)
        Me.griAreas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdArea = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.griAreasAlarma = New ISL.Controles.Grilla(Me.components)
        Me.cboEstadoAlarma = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnLimpiarAlarma = New Infragistics.Win.Misc.UltraButton()
        Me.cboLugarAlarma = New ISL.Controles.Combo(Me.components)
        Me.fecAlarma = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboOperador = New ISL.Controles.Combo(Me.components)
        Me.txtReferenciaLugarAlarma = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAgregarAlarma = New Infragistics.Win.Misc.UltraButton()
        Me.txtDetalleAlarma = New ISL.Controles.Texto(Me.components)
        Me.cboTipoAlarma = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.hAlarma = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griListaAccidentes = New ISL.Controles.Grilla(Me.components)
        Me.ogdAccidente = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLimpiarAccidente = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarAccidente = New Infragistics.Win.Misc.UltraButton()
        Me.txtObservacionAccidente = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.griAreasAccidenteAsignado = New ISL.Controles.Grilla(Me.components)
        Me.cboOperadorAccidente = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoAccidente = New ISL.Controles.Combo(Me.components)
        Me.griAreasAccidente = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.fecDosajeAccidente = New System.Windows.Forms.DateTimePicker()
        Me.fecDenunciaAccidente = New System.Windows.Forms.DateTimePicker()
        Me.cboLugarAccidente = New ISL.Controles.Combo(Me.components)
        Me.hDenunciaAccidente = New System.Windows.Forms.DateTimePicker()
        Me.hDosajeAccidente = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkDosajeAccidente = New System.Windows.Forms.CheckBox()
        Me.fecAccidente = New System.Windows.Forms.DateTimePicker()
        Me.txtReferenciaLugarAccidente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkDenunciaAccidente = New System.Windows.Forms.CheckBox()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDetalleAccidente = New ISL.Controles.Texto(Me.components)
        Me.cboTipoAccidente = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.hAccidente = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griListaIncidentes = New ISL.Controles.Grilla(Me.components)
        Me.ogdIncidente = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLimpiarIncidente = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarIncidente = New Infragistics.Win.Misc.UltraButton()
        Me.txtObservacionIncidente = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.griAreasIncidentesAsignados = New ISL.Controles.Grilla(Me.components)
        Me.cboEstadoIncidente = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboOperadorIncidente = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoIncidente = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.griAreasIncidentes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecIncidente = New System.Windows.Forms.DateTimePicker()
        Me.txtReferenciaLugarIncidente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDetalleIncidente = New ISL.Controles.Texto(Me.components)
        Me.hIncidente = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griListaRobos = New ISL.Controles.Grilla(Me.components)
        Me.ogdRobo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLimpiarRobo = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregarRobo = New Infragistics.Win.Misc.UltraButton()
        Me.txtObservacionRobo = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.griAreaRoboAsignada = New ISL.Controles.Grilla(Me.components)
        Me.griAreasRobo = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cboOperadorRobo = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoRobo = New ISL.Controles.Combo(Me.components)
        Me.cboTipoRobo = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDenunciaRobo = New System.Windows.Forms.DateTimePicker()
        Me.hDenunciaRobo = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecRobo = New System.Windows.Forms.DateTimePicker()
        Me.txtReferenciaLugarRobo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chkDenunciaRobo = New System.Windows.Forms.CheckBox()
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDetalleRobo = New ISL.Controles.Texto(Me.components)
        Me.hRobo = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalAccidentes = New ISL.Controles.Agrupacion(Me.components)
        Me.tabListado = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ColorGenerado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFinalizadoArea = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPendiente = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorFinalizado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboEventoBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.fichaDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.lblPilotoGRT = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPilotoTercero = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboActividadNegocio = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecViaje = New ISL.Controles.Fecha(Me.components)
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeEscala = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCopiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeDestino = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoViaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeCarreta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel44 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCodigoOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajeTracto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtViajePiloto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel45 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtViajeOrigen = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdSeguimiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtIdOperacionDetalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tcIncidencia = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.cboLugarIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griListaIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griListaCerrarIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAreaResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.cboAreaBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.griListaAlarmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtObservacionAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaLugarAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalleAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAlarma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.griListaAccidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtObservacionAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasAccidenteAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperadorAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugarAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaLugarAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalleAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.griListaIncidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txtObservacionIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasIncidentesAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperadorIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasIncidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaLugarIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalleIncidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.griListaRobos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.txtObservacionRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreaRoboAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griAreasRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperadorRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenciaLugarRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalleRobo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrTotalAccidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTotalAccidentes.SuspendLayout()
        CType(Me.tabListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListado.SuspendLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.ColorGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFinalizadoArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFinalizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.cboEventoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.fichaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fichaDetalle.SuspendLayout()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.cboPilotoTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtViajeOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcIncidencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLugarIncidente
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.cboLugarIncidente.Appearance = Appearance1
        Me.cboLugarIncidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarIncidente.ForeColor = System.Drawing.Color.Black
        Me.cboLugarIncidente.Location = New System.Drawing.Point(75, 69)
        Me.cboLugarIncidente.Name = "cboLugarIncidente"
        Me.cboLugarIncidente.Size = New System.Drawing.Size(298, 21)
        Me.cboLugarIncidente.TabIndex = 5
        Me.cboLugarIncidente.ValueMember = "Id"
        '
        'cboLugarRobo
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.cboLugarRobo.Appearance = Appearance2
        Me.cboLugarRobo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarRobo.ForeColor = System.Drawing.Color.Black
        Me.cboLugarRobo.Location = New System.Drawing.Point(74, 69)
        Me.cboLugarRobo.Name = "cboLugarRobo"
        Me.cboLugarRobo.Size = New System.Drawing.Size(290, 21)
        Me.cboLugarRobo.TabIndex = 5
        Me.cboLugarRobo.ValueMember = "Id"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griListaIncidencia)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1236, 415)
        '
        'griListaIncidencia
        '
        Me.griListaIncidencia.ContextMenuStrip = Me.Menu
        Me.griListaIncidencia.DataSource = Me.ogdEventos
        UltraGridColumn485.Header.Fixed = True
        UltraGridColumn485.Header.VisiblePosition = 0
        UltraGridColumn485.Hidden = True
        UltraGridColumn485.Width = 90
        UltraGridColumn486.Header.Caption = "Evento"
        UltraGridColumn486.Header.Fixed = True
        UltraGridColumn486.Header.VisiblePosition = 2
        UltraGridColumn486.Width = 90
        UltraGridColumn487.Header.Fixed = True
        UltraGridColumn487.Header.VisiblePosition = 3
        UltraGridColumn487.Hidden = True
        UltraGridColumn487.Width = 90
        UltraGridColumn488.Header.Fixed = True
        UltraGridColumn488.Header.VisiblePosition = 4
        UltraGridColumn488.Width = 120
        UltraGridColumn489.Header.Fixed = True
        UltraGridColumn489.Header.VisiblePosition = 5
        UltraGridColumn489.Hidden = True
        UltraGridColumn489.Width = 90
        UltraGridColumn490.Header.Fixed = True
        UltraGridColumn490.Header.VisiblePosition = 6
        UltraGridColumn490.Width = 200
        UltraGridColumn491.Header.Caption = "Fecha"
        UltraGridColumn491.Header.Fixed = True
        UltraGridColumn491.Header.VisiblePosition = 7
        UltraGridColumn491.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn491.Width = 120
        UltraGridColumn492.Header.VisiblePosition = 9
        UltraGridColumn492.Hidden = True
        UltraGridColumn492.Width = 110
        UltraGridColumn493.Header.Caption = "Ubicación"
        UltraGridColumn493.Header.VisiblePosition = 10
        UltraGridColumn493.Width = 200
        UltraGridColumn494.Header.VisiblePosition = 11
        UltraGridColumn494.Width = 200
        UltraGridColumn495.Header.Caption = "Descripción"
        UltraGridColumn495.Header.VisiblePosition = 12
        UltraGridColumn495.Width = 200
        UltraGridColumn496.Header.VisiblePosition = 14
        UltraGridColumn496.Hidden = True
        UltraGridColumn496.Width = 110
        UltraGridColumn497.Header.Caption = "Estado"
        UltraGridColumn497.Header.VisiblePosition = 17
        UltraGridColumn497.Width = 110
        UltraGridColumn498.Header.VisiblePosition = 8
        UltraGridColumn498.Hidden = True
        UltraGridColumn498.Width = 110
        UltraGridColumn499.Header.Caption = "Viaje"
        UltraGridColumn499.Header.Fixed = True
        UltraGridColumn499.Header.VisiblePosition = 1
        UltraGridColumn499.Width = 110
        UltraGridColumn500.Header.VisiblePosition = 18
        UltraGridColumn500.Width = 200
        UltraGridColumn501.Header.VisiblePosition = 19
        UltraGridColumn501.Width = 200
        UltraGridColumn502.Header.VisiblePosition = 20
        UltraGridColumn502.Hidden = True
        UltraGridColumn502.Width = 200
        UltraGridColumn503.Header.VisiblePosition = 21
        UltraGridColumn503.Width = 200
        UltraGridColumn504.Header.VisiblePosition = 22
        UltraGridColumn504.Width = 200
        UltraGridColumn505.Header.VisiblePosition = 23
        UltraGridColumn505.Width = 110
        UltraGridColumn506.Header.VisiblePosition = 24
        UltraGridColumn506.Width = 110
        UltraGridColumn507.Header.VisiblePosition = 25
        UltraGridColumn507.Width = 110
        UltraGridColumn508.Header.Caption = "FechaViaje"
        UltraGridColumn508.Header.VisiblePosition = 26
        UltraGridColumn508.Width = 110
        UltraGridColumn509.Header.VisiblePosition = 27
        UltraGridColumn509.Width = 200
        UltraGridColumn510.Header.VisiblePosition = 28
        UltraGridColumn510.Width = 110
        UltraGridColumn535.Header.VisiblePosition = 29
        UltraGridColumn535.Width = 110
        UltraGridColumn536.Header.Caption = "Observación"
        UltraGridColumn536.Header.VisiblePosition = 13
        UltraGridColumn536.Width = 200
        UltraGridColumn537.Header.VisiblePosition = 30
        UltraGridColumn537.Hidden = True
        UltraGridColumn537.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn537.Width = 110
        UltraGridColumn538.Header.VisiblePosition = 31
        UltraGridColumn538.Hidden = True
        UltraGridColumn538.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn538.Width = 110
        UltraGridColumn539.Header.VisiblePosition = 15
        UltraGridColumn539.Hidden = True
        UltraGridColumn540.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499, UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539, UltraGridColumn540})
        Me.griListaIncidencia.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaIncidencia.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaIncidencia.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaIncidencia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaIncidencia.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaIncidencia.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaIncidencia.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaIncidencia.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaIncidencia.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaIncidencia.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaIncidencia.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaIncidencia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaIncidencia.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaIncidencia.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaIncidencia.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaIncidencia.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaIncidencia.DisplayLayout.UseFixedHeaders = True
        Me.griListaIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaIncidencia.Location = New System.Drawing.Point(0, 0)
        Me.griListaIncidencia.Name = "griListaIncidencia"
        Me.griListaIncidencia.Size = New System.Drawing.Size(1236, 415)
        Me.griListaIncidencia.TabIndex = 3
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarCorreoToolStripMenuItem})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(139, 26)
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.send_email
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar Correo"
        '
        'ogdEventos
        '
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn26.DataType = GetType(Decimal)
        UltraDataColumn29.DataType = GetType(Date)
        UltraDataColumn30.DataType = GetType(Date)
        Me.ogdEventos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32})
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griListaCerrarIncidencia)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1236, 415)
        '
        'griListaCerrarIncidencia
        '
        Me.griListaCerrarIncidencia.ContextMenuStrip = Me.Menu
        Me.griListaCerrarIncidencia.DataSource = Me.ogdAreaResponsable
        UltraGridColumn301.Header.Fixed = True
        UltraGridColumn301.Header.VisiblePosition = 0
        UltraGridColumn301.Hidden = True
        UltraGridColumn301.Width = 90
        UltraGridColumn302.Header.Caption = "AreaIncidencia"
        UltraGridColumn302.Header.Fixed = True
        UltraGridColumn302.Header.VisiblePosition = 2
        UltraGridColumn302.Width = 90
        UltraGridColumn303.Header.Fixed = True
        UltraGridColumn303.Header.VisiblePosition = 3
        UltraGridColumn303.Hidden = True
        UltraGridColumn303.Width = 90
        UltraGridColumn304.Header.Fixed = True
        UltraGridColumn304.Header.VisiblePosition = 4
        UltraGridColumn304.Hidden = True
        UltraGridColumn304.Width = 30
        UltraGridColumn305.Header.Fixed = True
        UltraGridColumn305.Header.VisiblePosition = 5
        UltraGridColumn305.Width = 100
        UltraGridColumn306.Header.VisiblePosition = 9
        UltraGridColumn306.Hidden = True
        UltraGridColumn306.Width = 90
        UltraGridColumn307.Header.VisiblePosition = 10
        UltraGridColumn307.Width = 120
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn308.CellAppearance = Appearance3
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn308.CellButtonAppearance = Appearance4
        UltraGridColumn308.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn308.Header.VisiblePosition = 12
        UltraGridColumn308.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn308.Width = 250
        UltraGridColumn309.Header.Fixed = True
        UltraGridColumn309.Header.VisiblePosition = 7
        UltraGridColumn309.Width = 120
        UltraGridColumn310.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn310.Header.VisiblePosition = 14
        UltraGridColumn310.Hidden = True
        UltraGridColumn310.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn310.Width = 110
        UltraGridColumn311.Header.VisiblePosition = 15
        UltraGridColumn311.Hidden = True
        UltraGridColumn311.Width = 90
        UltraGridColumn312.Header.VisiblePosition = 13
        UltraGridColumn312.Hidden = True
        UltraGridColumn312.Width = 30
        UltraGridColumn313.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn313.Header.VisiblePosition = 22
        UltraGridColumn313.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn313.Width = 110
        UltraGridColumn314.Header.VisiblePosition = 18
        UltraGridColumn314.Hidden = True
        UltraGridColumn314.Width = 90
        UltraGridColumn315.Header.Fixed = True
        UltraGridColumn315.Header.VisiblePosition = 6
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.Width = 30
        UltraGridColumn316.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn316.Header.VisiblePosition = 8
        UltraGridColumn316.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn316.Width = 110
        UltraGridColumn317.Header.VisiblePosition = 19
        UltraGridColumn317.Hidden = True
        UltraGridColumn317.Width = 90
        UltraGridColumn318.Header.VisiblePosition = 20
        UltraGridColumn318.Width = 90
        UltraGridColumn319.Header.VisiblePosition = 11
        UltraGridColumn319.Width = 250
        UltraGridColumn320.Header.VisiblePosition = 21
        UltraGridColumn320.Width = 60
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn321.CellButtonAppearance = Appearance5
        UltraGridColumn321.Header.Caption = "Estado"
        UltraGridColumn321.Header.VisiblePosition = 16
        UltraGridColumn321.Width = 100
        UltraGridColumn322.Header.Caption = "NombreEstado"
        UltraGridColumn322.Header.VisiblePosition = 23
        UltraGridColumn322.Hidden = True
        UltraGridColumn322.Width = 100
        UltraGridColumn323.Header.Caption = "Incidencia"
        UltraGridColumn323.Header.Fixed = True
        UltraGridColumn323.Header.VisiblePosition = 1
        UltraGridColumn323.Width = 90
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn324.CellAppearance = Appearance6
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn324.CellButtonAppearance = Appearance7
        UltraGridColumn324.Header.VisiblePosition = 17
        UltraGridColumn324.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn324.Width = 40
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324})
        Me.griListaCerrarIncidencia.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaCerrarIncidencia.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaCerrarIncidencia.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaCerrarIncidencia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaCerrarIncidencia.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCerrarIncidencia.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaCerrarIncidencia.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaCerrarIncidencia.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaCerrarIncidencia.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaCerrarIncidencia.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaCerrarIncidencia.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaCerrarIncidencia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaCerrarIncidencia.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaCerrarIncidencia.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaCerrarIncidencia.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaCerrarIncidencia.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaCerrarIncidencia.DisplayLayout.UseFixedHeaders = True
        Me.griListaCerrarIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCerrarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaCerrarIncidencia.Location = New System.Drawing.Point(0, 48)
        Me.griListaCerrarIncidencia.Name = "griListaCerrarIncidencia"
        Me.griListaCerrarIncidencia.Size = New System.Drawing.Size(1236, 367)
        Me.griListaCerrarIncidencia.TabIndex = 8
        '
        'ogdAreaResponsable
        '
        UltraDataColumn42.DataType = GetType(Date)
        UltraDataColumn45.DataType = GetType(Date)
        UltraDataColumn48.DataType = GetType(Date)
        Me.ogdAreaResponsable.Band.Columns.AddRange(New Object() {UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55})
        '
        'UltraGroupBox8
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox8.ContentAreaAppearance = Appearance8
        Me.UltraGroupBox8.Controls.Add(Me.cboAreaBuscar)
        Me.UltraGroupBox8.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1236, 48)
        Me.UltraGroupBox8.TabIndex = 6
        Me.UltraGroupBox8.Text = "Filtro"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboAreaBuscar
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.cboAreaBuscar.Appearance = Appearance9
        Me.cboAreaBuscar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboAreaBuscar.DisplayMember = "Login"
        Me.cboAreaBuscar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAreaBuscar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAreaBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAreaBuscar.ForeColor = System.Drawing.Color.Black
        Me.cboAreaBuscar.Location = New System.Drawing.Point(51, 19)
        Me.cboAreaBuscar.Name = "cboAreaBuscar"
        Me.cboAreaBuscar.Size = New System.Drawing.Size(276, 21)
        Me.cboAreaBuscar.TabIndex = 6
        Me.cboAreaBuscar.ValueMember = "Id"
        '
        'UltraLabel15
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance10
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(16, 23)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel15.TabIndex = 5
        Me.UltraLabel15.Text = "Area:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(892, 505)
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance11
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox1.TabIndex = 6
        Me.UltraExpandableGroupBox1.Text = "Datos Generales de la Alarma"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(869, 499)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ugb_Espera)
        Me.UltraGroupBox1.Controls.Add(Me.griListaAlarmas)
        Me.UltraGroupBox1.Controls.Add(Me.Panel2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(869, 499)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(16, 286)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 16
        Me.ugb_Espera.Visible = False
        '
        'griListaAlarmas
        '
        Me.griListaAlarmas.DataSource = Me.ogdAlarma
        UltraGridColumn479.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn479.Header.VisiblePosition = 0
        UltraGridColumn479.Hidden = True
        UltraGridColumn479.Width = 90
        UltraGridColumn480.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn480.Header.VisiblePosition = 1
        UltraGridColumn480.Width = 110
        UltraGridColumn481.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn481.Header.VisiblePosition = 2
        UltraGridColumn481.Hidden = True
        UltraGridColumn481.Width = 90
        UltraGridColumn482.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn482.Header.VisiblePosition = 3
        UltraGridColumn482.Hidden = True
        UltraGridColumn482.Width = 90
        UltraGridColumn483.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn483.Header.VisiblePosition = 4
        UltraGridColumn483.Hidden = True
        UltraGridColumn483.Width = 120
        UltraGridColumn484.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn484.Header.VisiblePosition = 5
        UltraGridColumn484.Hidden = True
        UltraGridColumn484.Width = 90
        UltraGridColumn541.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn541.Header.VisiblePosition = 7
        UltraGridColumn541.Width = 150
        UltraGridColumn542.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn542.Header.VisiblePosition = 8
        UltraGridColumn542.Hidden = True
        UltraGridColumn542.Width = 90
        UltraGridColumn543.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn543.Header.VisiblePosition = 12
        UltraGridColumn543.Width = 120
        UltraGridColumn544.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn544.Header.Caption = "Fecha"
        UltraGridColumn544.Header.VisiblePosition = 6
        UltraGridColumn544.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn544.Width = 110
        UltraGridColumn545.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn545.Header.Caption = "Descripción"
        UltraGridColumn545.Header.VisiblePosition = 11
        UltraGridColumn545.Width = 250
        UltraGridColumn546.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn546.Header.Caption = "IdUbicación"
        UltraGridColumn546.Header.VisiblePosition = 13
        UltraGridColumn546.Hidden = True
        UltraGridColumn546.Width = 90
        UltraGridColumn547.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn547.Header.Caption = "Ubicación"
        UltraGridColumn547.Header.VisiblePosition = 9
        UltraGridColumn547.Width = 220
        UltraGridColumn548.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn548.Header.Caption = "Referencia del lugar"
        UltraGridColumn548.Header.VisiblePosition = 10
        UltraGridColumn548.Width = 250
        UltraGridColumn549.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn549.Header.VisiblePosition = 14
        UltraGridColumn549.Hidden = True
        UltraGridColumn549.Width = 90
        UltraGridColumn550.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn550.Header.Caption = "Estado"
        UltraGridColumn550.Header.VisiblePosition = 15
        UltraGridColumn550.Width = 100
        UltraGridColumn551.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn551.Header.VisiblePosition = 20
        UltraGridColumn551.Hidden = True
        UltraGridColumn551.Width = 100
        UltraGridColumn552.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn552.Header.VisiblePosition = 21
        UltraGridColumn552.Hidden = True
        UltraGridColumn552.Width = 90
        UltraGridColumn553.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn553.Header.VisiblePosition = 17
        UltraGridColumn553.Hidden = True
        UltraGridColumn553.Width = 30
        UltraGridColumn554.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn554.Header.VisiblePosition = 18
        UltraGridColumn554.Hidden = True
        UltraGridColumn554.Width = 110
        UltraGridColumn555.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn555.Header.VisiblePosition = 19
        UltraGridColumn555.Hidden = True
        UltraGridColumn555.Width = 90
        UltraGridColumn556.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn556.Header.Caption = "Observación"
        UltraGridColumn556.Header.VisiblePosition = 16
        UltraGridColumn556.Width = 250
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543, UltraGridColumn544, UltraGridColumn545, UltraGridColumn546, UltraGridColumn547, UltraGridColumn548, UltraGridColumn549, UltraGridColumn550, UltraGridColumn551, UltraGridColumn552, UltraGridColumn553, UltraGridColumn554, UltraGridColumn555, UltraGridColumn556})
        Me.griListaAlarmas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaAlarmas.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaAlarmas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaAlarmas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaAlarmas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaAlarmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaAlarmas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaAlarmas.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaAlarmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaAlarmas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaAlarmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaAlarmas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaAlarmas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaAlarmas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaAlarmas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaAlarmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaAlarmas.Location = New System.Drawing.Point(3, 236)
        Me.griListaAlarmas.Name = "griListaAlarmas"
        Me.griListaAlarmas.Size = New System.Drawing.Size(863, 260)
        Me.griListaAlarmas.TabIndex = 14
        '
        'ogdAlarma
        '
        UltraDataColumn65.DataType = GetType(Date)
        UltraDataColumn72.DataType = GetType(Date)
        UltraDataColumn75.DataType = GetType(Date)
        Me.ogdAlarma.Band.Columns.AddRange(New Object() {UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77})
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.UltraLabel8)
        Me.Panel2.Controls.Add(Me.txtObservacionAlarma)
        Me.Panel2.Controls.Add(Me.griAreas)
        Me.Panel2.Controls.Add(Me.griAreasAlarma)
        Me.Panel2.Controls.Add(Me.cboEstadoAlarma)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.btnLimpiarAlarma)
        Me.Panel2.Controls.Add(Me.cboLugarAlarma)
        Me.Panel2.Controls.Add(Me.fecAlarma)
        Me.Panel2.Controls.Add(Me.Etiqueta2)
        Me.Panel2.Controls.Add(Me.cboOperador)
        Me.Panel2.Controls.Add(Me.txtReferenciaLugarAlarma)
        Me.Panel2.Controls.Add(Me.UltraLabel5)
        Me.Panel2.Controls.Add(Me.UltraLabel14)
        Me.Panel2.Controls.Add(Me.btnAgregarAlarma)
        Me.Panel2.Controls.Add(Me.txtDetalleAlarma)
        Me.Panel2.Controls.Add(Me.cboTipoAlarma)
        Me.Panel2.Controls.Add(Me.UltraLabel6)
        Me.Panel2.Controls.Add(Me.hAlarma)
        Me.Panel2.Controls.Add(Me.UltraLabel7)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 233)
        Me.Panel2.TabIndex = 0
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(3, 164)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel8.TabIndex = 58
        Me.UltraLabel8.Text = "Observación:"
        '
        'txtObservacionAlarma
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAlarma.Appearance = Appearance13
        Me.txtObservacionAlarma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionAlarma.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAlarma.Location = New System.Drawing.Point(80, 159)
        Me.txtObservacionAlarma.MaxLength = 100
        Me.txtObservacionAlarma.Multiline = True
        Me.txtObservacionAlarma.Name = "txtObservacionAlarma"
        Me.txtObservacionAlarma.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionAlarma.Size = New System.Drawing.Size(281, 43)
        Me.txtObservacionAlarma.TabIndex = 8
        '
        'griAreas
        '
        Me.griAreas.DataSource = Me.ogdArea
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAreas.DisplayLayout.Appearance = Appearance14
        UltraGridColumn557.Header.VisiblePosition = 0
        UltraGridColumn557.Hidden = True
        UltraGridColumn557.Width = 50
        UltraGridColumn558.Header.VisiblePosition = 1
        UltraGridColumn558.Hidden = True
        UltraGridColumn559.Header.Caption = "Sel"
        UltraGridColumn559.Header.VisiblePosition = 2
        UltraGridColumn559.Width = 30
        UltraGridColumn560.Header.Caption = "Area"
        UltraGridColumn560.Header.VisiblePosition = 3
        UltraGridColumn560.Width = 150
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn557, UltraGridColumn558, UltraGridColumn559, UltraGridColumn560})
        Me.griAreas.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griAreas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAreas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreas.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.griAreas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreas.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.griAreas.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griAreas.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griAreas.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.griAreas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAreas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.griAreas.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griAreas.DisplayLayout.Override.CellAppearance = Appearance21
        Me.griAreas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAreas.DisplayLayout.Override.CellPadding = 0
        Me.griAreas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreas.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreas.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Me.griAreas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.griAreas.DisplayLayout.Override.RowAppearance = Appearance23
        Me.griAreas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAreas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griAreas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.griAreas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAreas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreas.Location = New System.Drawing.Point(365, 6)
        Me.griAreas.Name = "griAreas"
        Me.griAreas.Size = New System.Drawing.Size(213, 221)
        Me.griAreas.TabIndex = 10
        '
        'ogdArea
        '
        UltraDataColumn80.DataType = GetType(Boolean)
        Me.ogdArea.Band.Columns.AddRange(New Object() {UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81})
        '
        'griAreasAlarma
        '
        Me.griAreasAlarma.DataSource = Me.ogdAreaResponsable
        UltraGridColumn561.Header.VisiblePosition = 0
        UltraGridColumn561.Hidden = True
        UltraGridColumn562.Header.VisiblePosition = 1
        UltraGridColumn562.Hidden = True
        UltraGridColumn563.Header.VisiblePosition = 2
        UltraGridColumn563.Hidden = True
        UltraGridColumn564.Header.VisiblePosition = 5
        UltraGridColumn564.Hidden = True
        UltraGridColumn565.Header.VisiblePosition = 6
        UltraGridColumn565.Hidden = True
        UltraGridColumn566.Header.VisiblePosition = 3
        UltraGridColumn566.Hidden = True
        UltraGridColumn567.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn567.Header.Caption = "Areas Selecionadas"
        UltraGridColumn567.Header.VisiblePosition = 4
        UltraGridColumn567.Width = 95
        UltraGridColumn568.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn568.Header.VisiblePosition = 7
        UltraGridColumn568.MaxLength = 500
        UltraGridColumn568.Width = 135
        UltraGridColumn569.Header.VisiblePosition = 8
        UltraGridColumn569.Hidden = True
        UltraGridColumn570.Header.VisiblePosition = 9
        UltraGridColumn570.Hidden = True
        UltraGridColumn571.Header.VisiblePosition = 10
        UltraGridColumn571.Hidden = True
        UltraGridColumn572.Header.VisiblePosition = 11
        UltraGridColumn572.Hidden = True
        UltraGridColumn573.Header.VisiblePosition = 12
        UltraGridColumn573.Hidden = True
        UltraGridColumn574.Header.VisiblePosition = 13
        UltraGridColumn574.Hidden = True
        UltraGridColumn575.Header.VisiblePosition = 14
        UltraGridColumn575.Hidden = True
        UltraGridColumn576.Header.VisiblePosition = 15
        UltraGridColumn576.Hidden = True
        UltraGridColumn577.Header.VisiblePosition = 16
        UltraGridColumn577.Hidden = True
        UltraGridColumn578.Header.VisiblePosition = 17
        UltraGridColumn578.Hidden = True
        UltraGridColumn579.Header.VisiblePosition = 18
        UltraGridColumn579.Hidden = True
        UltraGridColumn580.Header.VisiblePosition = 19
        UltraGridColumn580.Hidden = True
        UltraGridColumn581.Header.VisiblePosition = 20
        UltraGridColumn581.Hidden = True
        UltraGridColumn582.Header.VisiblePosition = 21
        UltraGridColumn582.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 22
        UltraGridColumn177.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn561, UltraGridColumn562, UltraGridColumn563, UltraGridColumn564, UltraGridColumn565, UltraGridColumn566, UltraGridColumn567, UltraGridColumn568, UltraGridColumn569, UltraGridColumn570, UltraGridColumn571, UltraGridColumn572, UltraGridColumn573, UltraGridColumn574, UltraGridColumn575, UltraGridColumn576, UltraGridColumn577, UltraGridColumn578, UltraGridColumn579, UltraGridColumn580, UltraGridColumn581, UltraGridColumn582, UltraGridColumn177})
        Me.griAreasAlarma.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griAreasAlarma.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreasAlarma.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasAlarma.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAlarma.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAlarma.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreasAlarma.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreasAlarma.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreasAlarma.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreasAlarma.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasAlarma.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreasAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasAlarma.Location = New System.Drawing.Point(584, 6)
        Me.griAreasAlarma.Name = "griAreasAlarma"
        Me.griAreasAlarma.Size = New System.Drawing.Size(292, 218)
        Me.griAreasAlarma.TabIndex = 11
        '
        'cboEstadoAlarma
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoAlarma.Appearance = Appearance25
        Me.cboEstadoAlarma.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstadoAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoAlarma.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoAlarma.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoAlarma.Location = New System.Drawing.Point(80, 203)
        Me.cboEstadoAlarma.Name = "cboEstadoAlarma"
        Me.cboEstadoAlarma.Size = New System.Drawing.Size(115, 21)
        Me.cboEstadoAlarma.TabIndex = 9
        Me.cboEstadoAlarma.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance26
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(30, 202)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel2.TabIndex = 51
        Me.UltraLabel2.Text = "Estado:"
        '
        'btnLimpiarAlarma
        '
        Appearance27.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.btnLimpiarAlarma.Appearance = Appearance27
        Me.btnLimpiarAlarma.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnLimpiarAlarma.Location = New System.Drawing.Point(276, 202)
        Me.btnLimpiarAlarma.Name = "btnLimpiarAlarma"
        Me.btnLimpiarAlarma.Size = New System.Drawing.Size(85, 25)
        Me.btnLimpiarAlarma.TabIndex = 13
        Me.btnLimpiarAlarma.Text = "Cancelar"
        '
        'cboLugarAlarma
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.cboLugarAlarma.Appearance = Appearance28
        Me.cboLugarAlarma.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarAlarma.ForeColor = System.Drawing.Color.Black
        Me.cboLugarAlarma.Location = New System.Drawing.Point(80, 71)
        Me.cboLugarAlarma.Name = "cboLugarAlarma"
        Me.cboLugarAlarma.Size = New System.Drawing.Size(281, 21)
        Me.cboLugarAlarma.TabIndex = 5
        Me.cboLugarAlarma.ValueMember = "Id"
        '
        'fecAlarma
        '
        Me.fecAlarma.CustomFormat = ""
        Me.fecAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecAlarma.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecAlarma.Location = New System.Drawing.Point(79, 4)
        Me.fecAlarma.Name = "fecAlarma"
        Me.fecAlarma.Size = New System.Drawing.Size(85, 20)
        Me.fecAlarma.TabIndex = 1
        Me.fecAlarma.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'Etiqueta2
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance29
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(38, 73)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta2.TabIndex = 46
        Me.Etiqueta2.Text = "Lugar:"
        '
        'cboOperador
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.cboOperador.Appearance = Appearance30
        Me.cboOperador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOperador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOperador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperador.ForeColor = System.Drawing.Color.Black
        Me.cboOperador.Location = New System.Drawing.Point(80, 49)
        Me.cboOperador.Name = "cboOperador"
        Me.cboOperador.Size = New System.Drawing.Size(281, 21)
        Me.cboOperador.TabIndex = 4
        Me.cboOperador.ValueMember = "Id"
        '
        'txtReferenciaLugarAlarma
        '
        Me.txtReferenciaLugarAlarma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaLugarAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaLugarAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaLugarAlarma.Location = New System.Drawing.Point(80, 93)
        Me.txtReferenciaLugarAlarma.Name = "txtReferenciaLugarAlarma"
        Me.txtReferenciaLugarAlarma.Size = New System.Drawing.Size(281, 21)
        Me.txtReferenciaLugarAlarma.TabIndex = 6
        '
        'UltraLabel5
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance31
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 96)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel5.TabIndex = 44
        Me.UltraLabel5.Text = "Referencia:"
        '
        'UltraLabel14
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance32
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(18, 50)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel14.TabIndex = 29
        Me.UltraLabel14.Text = "Operador:"
        '
        'btnAgregarAlarma
        '
        Appearance33.Image = CType(resources.GetObject("Appearance33.Image"), Object)
        Me.btnAgregarAlarma.Appearance = Appearance33
        Me.btnAgregarAlarma.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarAlarma.Location = New System.Drawing.Point(198, 202)
        Me.btnAgregarAlarma.Name = "btnAgregarAlarma"
        Me.btnAgregarAlarma.Size = New System.Drawing.Size(79, 25)
        Me.btnAgregarAlarma.TabIndex = 12
        Me.btnAgregarAlarma.Text = "Editar"
        '
        'txtDetalleAlarma
        '
        Appearance34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleAlarma.Appearance = Appearance34
        Me.txtDetalleAlarma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDetalleAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleAlarma.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleAlarma.Location = New System.Drawing.Point(80, 115)
        Me.txtDetalleAlarma.MaxLength = 100
        Me.txtDetalleAlarma.Multiline = True
        Me.txtDetalleAlarma.Name = "txtDetalleAlarma"
        Me.txtDetalleAlarma.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleAlarma.Size = New System.Drawing.Size(281, 43)
        Me.txtDetalleAlarma.TabIndex = 7
        '
        'cboTipoAlarma
        '
        Appearance35.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAlarma.Appearance = Appearance35
        Me.cboTipoAlarma.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance36
        Me.cboTipoAlarma.ButtonsRight.Add(EditorButton1)
        Me.cboTipoAlarma.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAlarma.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAlarma.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAlarma.Location = New System.Drawing.Point(80, 26)
        Me.cboTipoAlarma.Name = "cboTipoAlarma"
        Me.cboTipoAlarma.Size = New System.Drawing.Size(281, 21)
        Me.cboTipoAlarma.TabIndex = 3
        Me.cboTipoAlarma.ValueMember = "Id"
        '
        'UltraLabel6
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance37
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(44, 28)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(29, 14)
        Me.UltraLabel6.TabIndex = 24
        Me.UltraLabel6.Text = "Tipo:"
        '
        'hAlarma
        '
        Me.hAlarma.CustomFormat = "HH:mm"
        Me.hAlarma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hAlarma.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hAlarma.Location = New System.Drawing.Point(166, 4)
        Me.hAlarma.Name = "hAlarma"
        Me.hAlarma.ShowUpDown = True
        Me.hAlarma.Size = New System.Drawing.Size(53, 20)
        Me.hAlarma.TabIndex = 2
        Me.hAlarma.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'UltraLabel7
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance38
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(34, 6)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel7.TabIndex = 20
        Me.UltraLabel7.Text = "Fecha:"
        '
        'UltraLabel1
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance39
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(30, 120)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Detalle:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(892, 505)
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance40
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox2.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox2.TabIndex = 7
        Me.UltraExpandableGroupBox2.Text = "Datos Generales del Accidente"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(869, 499)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.griListaAccidentes)
        Me.UltraGroupBox2.Controls.Add(Me.Panel3)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(869, 499)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaAccidentes
        '
        Me.griListaAccidentes.DataSource = Me.ogdAccidente
        UltraGridColumn583.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn583.Header.VisiblePosition = 0
        UltraGridColumn583.Hidden = True
        UltraGridColumn583.Width = 90
        UltraGridColumn584.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn584.Header.VisiblePosition = 1
        UltraGridColumn584.Width = 110
        UltraGridColumn585.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn585.Header.VisiblePosition = 2
        UltraGridColumn585.Hidden = True
        UltraGridColumn585.Width = 90
        UltraGridColumn586.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn586.Header.VisiblePosition = 3
        UltraGridColumn586.Hidden = True
        UltraGridColumn586.Width = 90
        UltraGridColumn587.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn587.Header.VisiblePosition = 4
        UltraGridColumn587.Hidden = True
        UltraGridColumn587.Width = 120
        UltraGridColumn588.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn588.Header.VisiblePosition = 5
        UltraGridColumn588.Hidden = True
        UltraGridColumn588.Width = 90
        UltraGridColumn589.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn589.Header.VisiblePosition = 7
        UltraGridColumn589.Width = 150
        UltraGridColumn590.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn590.Header.Caption = "Fecha"
        UltraGridColumn590.Header.VisiblePosition = 6
        UltraGridColumn590.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn590.Width = 110
        UltraGridColumn591.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn591.Header.VisiblePosition = 8
        UltraGridColumn591.Hidden = True
        UltraGridColumn591.Width = 90
        UltraGridColumn592.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn592.Header.VisiblePosition = 12
        UltraGridColumn592.Width = 150
        UltraGridColumn593.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn593.Header.Caption = "IdUbicación"
        UltraGridColumn593.Header.VisiblePosition = 13
        UltraGridColumn593.Hidden = True
        UltraGridColumn593.Width = 90
        UltraGridColumn594.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn594.Header.VisiblePosition = 9
        UltraGridColumn594.Width = 220
        UltraGridColumn595.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn595.Header.Caption = "Referencia del lugar"
        UltraGridColumn595.Header.VisiblePosition = 10
        UltraGridColumn595.Width = 250
        UltraGridColumn596.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn596.Header.VisiblePosition = 11
        UltraGridColumn596.Width = 250
        UltraGridColumn597.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn597.Header.VisiblePosition = 14
        UltraGridColumn597.Width = 30
        UltraGridColumn598.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn598.Header.Caption = "Fecha Denuncia"
        UltraGridColumn598.Header.VisiblePosition = 15
        UltraGridColumn598.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn598.Width = 110
        UltraGridColumn599.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn599.Header.VisiblePosition = 16
        UltraGridColumn599.Width = 30
        UltraGridColumn600.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn600.Header.Caption = "Fecha Dosaje"
        UltraGridColumn600.Header.VisiblePosition = 17
        UltraGridColumn600.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn600.Width = 110
        UltraGridColumn601.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn601.Header.VisiblePosition = 18
        UltraGridColumn601.Hidden = True
        UltraGridColumn601.Width = 90
        UltraGridColumn602.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn602.Header.Caption = "Estado"
        UltraGridColumn602.Header.VisiblePosition = 19
        UltraGridColumn602.Width = 120
        UltraGridColumn603.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn603.Header.VisiblePosition = 21
        UltraGridColumn603.Hidden = True
        UltraGridColumn603.Width = 100
        UltraGridColumn604.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn604.Header.VisiblePosition = 22
        UltraGridColumn604.Hidden = True
        UltraGridColumn604.Width = 90
        UltraGridColumn605.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn605.Header.VisiblePosition = 20
        UltraGridColumn605.Hidden = True
        UltraGridColumn605.Width = 30
        UltraGridColumn606.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn606.Header.VisiblePosition = 23
        UltraGridColumn606.Hidden = True
        UltraGridColumn606.Width = 110
        UltraGridColumn607.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn607.Header.VisiblePosition = 24
        UltraGridColumn607.Hidden = True
        UltraGridColumn607.Width = 90
        UltraGridColumn608.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn608.Header.Caption = "Observación"
        UltraGridColumn608.Header.VisiblePosition = 25
        UltraGridColumn608.Width = 250
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn583, UltraGridColumn584, UltraGridColumn585, UltraGridColumn586, UltraGridColumn587, UltraGridColumn588, UltraGridColumn589, UltraGridColumn590, UltraGridColumn591, UltraGridColumn592, UltraGridColumn593, UltraGridColumn594, UltraGridColumn595, UltraGridColumn596, UltraGridColumn597, UltraGridColumn598, UltraGridColumn599, UltraGridColumn600, UltraGridColumn601, UltraGridColumn602, UltraGridColumn603, UltraGridColumn604, UltraGridColumn605, UltraGridColumn606, UltraGridColumn607, UltraGridColumn608})
        Me.griListaAccidentes.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griListaAccidentes.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaAccidentes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaAccidentes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaAccidentes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaAccidentes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaAccidentes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaAccidentes.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaAccidentes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaAccidentes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaAccidentes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaAccidentes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaAccidentes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaAccidentes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaAccidentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaAccidentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaAccidentes.Location = New System.Drawing.Point(3, 272)
        Me.griListaAccidentes.Name = "griListaAccidentes"
        Me.griListaAccidentes.Size = New System.Drawing.Size(863, 224)
        Me.griListaAccidentes.TabIndex = 20
        '
        'ogdAccidente
        '
        UltraDataColumn89.DataType = GetType(Date)
        UltraDataColumn97.DataType = GetType(Date)
        UltraDataColumn99.DataType = GetType(Date)
        UltraDataColumn102.DataType = GetType(Date)
        UltraDataColumn105.DataType = GetType(Date)
        Me.ogdAccidente.Band.Columns.AddRange(New Object() {UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107})
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnLimpiarAccidente)
        Me.Panel3.Controls.Add(Me.btnAgregarAccidente)
        Me.Panel3.Controls.Add(Me.txtObservacionAccidente)
        Me.Panel3.Controls.Add(Me.UltraLabel11)
        Me.Panel3.Controls.Add(Me.griAreasAccidenteAsignado)
        Me.Panel3.Controls.Add(Me.cboOperadorAccidente)
        Me.Panel3.Controls.Add(Me.UltraLabel4)
        Me.Panel3.Controls.Add(Me.UltraLabel3)
        Me.Panel3.Controls.Add(Me.cboEstadoAccidente)
        Me.Panel3.Controls.Add(Me.griAreasAccidente)
        Me.Panel3.Controls.Add(Me.fecDosajeAccidente)
        Me.Panel3.Controls.Add(Me.fecDenunciaAccidente)
        Me.Panel3.Controls.Add(Me.cboLugarAccidente)
        Me.Panel3.Controls.Add(Me.hDenunciaAccidente)
        Me.Panel3.Controls.Add(Me.hDosajeAccidente)
        Me.Panel3.Controls.Add(Me.Etiqueta3)
        Me.Panel3.Controls.Add(Me.chkDosajeAccidente)
        Me.Panel3.Controls.Add(Me.fecAccidente)
        Me.Panel3.Controls.Add(Me.txtReferenciaLugarAccidente)
        Me.Panel3.Controls.Add(Me.chkDenunciaAccidente)
        Me.Panel3.Controls.Add(Me.UltraLabel12)
        Me.Panel3.Controls.Add(Me.txtDetalleAccidente)
        Me.Panel3.Controls.Add(Me.cboTipoAccidente)
        Me.Panel3.Controls.Add(Me.UltraLabel9)
        Me.Panel3.Controls.Add(Me.hAccidente)
        Me.Panel3.Controls.Add(Me.UltraLabel10)
        Me.Panel3.Controls.Add(Me.UltraLabel13)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(863, 269)
        Me.Panel3.TabIndex = 0
        '
        'btnLimpiarAccidente
        '
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.btnLimpiarAccidente.Appearance = Appearance41
        Me.btnLimpiarAccidente.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnLimpiarAccidente.Location = New System.Drawing.Point(229, 226)
        Me.btnLimpiarAccidente.Name = "btnLimpiarAccidente"
        Me.btnLimpiarAccidente.Size = New System.Drawing.Size(85, 25)
        Me.btnLimpiarAccidente.TabIndex = 19
        Me.btnLimpiarAccidente.Text = "Cancelar"
        '
        'btnAgregarAccidente
        '
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        Me.btnAgregarAccidente.Appearance = Appearance42
        Me.btnAgregarAccidente.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarAccidente.Location = New System.Drawing.Point(229, 202)
        Me.btnAgregarAccidente.Name = "btnAgregarAccidente"
        Me.btnAgregarAccidente.Size = New System.Drawing.Size(85, 25)
        Me.btnAgregarAccidente.TabIndex = 18
        Me.btnAgregarAccidente.Text = "Editar"
        '
        'txtObservacionAccidente
        '
        Appearance43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAccidente.Appearance = Appearance43
        Me.txtObservacionAccidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionAccidente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAccidente.Location = New System.Drawing.Point(73, 158)
        Me.txtObservacionAccidente.MaxLength = 100
        Me.txtObservacionAccidente.Multiline = True
        Me.txtObservacionAccidente.Name = "txtObservacionAccidente"
        Me.txtObservacionAccidente.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionAccidente.Size = New System.Drawing.Size(241, 43)
        Me.txtObservacionAccidente.TabIndex = 8
        '
        'UltraLabel11
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance44
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel11.Location = New System.Drawing.Point(2, 160)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel11.TabIndex = 60
        Me.UltraLabel11.Text = "Observación:"
        '
        'griAreasAccidenteAsignado
        '
        Me.griAreasAccidenteAsignado.DataSource = Me.ogdAreaResponsable
        UltraGridColumn609.Header.VisiblePosition = 0
        UltraGridColumn609.Hidden = True
        UltraGridColumn610.Header.VisiblePosition = 1
        UltraGridColumn610.Hidden = True
        UltraGridColumn611.Header.VisiblePosition = 2
        UltraGridColumn611.Hidden = True
        UltraGridColumn612.Header.VisiblePosition = 5
        UltraGridColumn612.Hidden = True
        UltraGridColumn613.Header.VisiblePosition = 6
        UltraGridColumn613.Hidden = True
        UltraGridColumn614.Header.VisiblePosition = 3
        UltraGridColumn614.Hidden = True
        UltraGridColumn615.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn615.Header.Caption = "Area Seleccionadas"
        UltraGridColumn615.Header.VisiblePosition = 4
        UltraGridColumn615.Width = 95
        UltraGridColumn616.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn616.Header.VisiblePosition = 7
        UltraGridColumn616.MaxLength = 500
        UltraGridColumn616.Width = 135
        UltraGridColumn617.Header.VisiblePosition = 8
        UltraGridColumn617.Hidden = True
        UltraGridColumn618.Header.VisiblePosition = 9
        UltraGridColumn618.Hidden = True
        UltraGridColumn619.Header.VisiblePosition = 10
        UltraGridColumn619.Hidden = True
        UltraGridColumn620.Header.VisiblePosition = 11
        UltraGridColumn620.Hidden = True
        UltraGridColumn621.Header.VisiblePosition = 12
        UltraGridColumn621.Hidden = True
        UltraGridColumn622.Header.VisiblePosition = 13
        UltraGridColumn622.Hidden = True
        UltraGridColumn623.Header.VisiblePosition = 14
        UltraGridColumn623.Hidden = True
        UltraGridColumn624.Header.VisiblePosition = 15
        UltraGridColumn624.Hidden = True
        UltraGridColumn625.Header.VisiblePosition = 16
        UltraGridColumn625.Hidden = True
        UltraGridColumn626.Header.VisiblePosition = 17
        UltraGridColumn626.Hidden = True
        UltraGridColumn627.Header.VisiblePosition = 18
        UltraGridColumn627.Hidden = True
        UltraGridColumn628.Header.VisiblePosition = 19
        UltraGridColumn628.Hidden = True
        UltraGridColumn629.Header.VisiblePosition = 20
        UltraGridColumn629.Hidden = True
        UltraGridColumn630.Header.VisiblePosition = 21
        UltraGridColumn630.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 22
        UltraGridColumn178.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn609, UltraGridColumn610, UltraGridColumn611, UltraGridColumn612, UltraGridColumn613, UltraGridColumn614, UltraGridColumn615, UltraGridColumn616, UltraGridColumn617, UltraGridColumn618, UltraGridColumn619, UltraGridColumn620, UltraGridColumn621, UltraGridColumn622, UltraGridColumn623, UltraGridColumn624, UltraGridColumn625, UltraGridColumn626, UltraGridColumn627, UltraGridColumn628, UltraGridColumn629, UltraGridColumn630, UltraGridColumn178})
        Me.griAreasAccidenteAsignado.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griAreasAccidenteAsignado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreasAccidenteAsignado.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasAccidenteAsignado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreasAccidenteAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasAccidenteAsignado.Location = New System.Drawing.Point(534, 5)
        Me.griAreasAccidenteAsignado.Name = "griAreasAccidenteAsignado"
        Me.griAreasAccidenteAsignado.Size = New System.Drawing.Size(292, 260)
        Me.griAreasAccidenteAsignado.TabIndex = 17
        '
        'cboOperadorAccidente
        '
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorAccidente.Appearance = Appearance45
        Me.cboOperadorAccidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOperadorAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOperadorAccidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOperadorAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperadorAccidente.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorAccidente.Location = New System.Drawing.Point(73, 48)
        Me.cboOperadorAccidente.Name = "cboOperadorAccidente"
        Me.cboOperadorAccidente.Size = New System.Drawing.Size(241, 21)
        Me.cboOperadorAccidente.TabIndex = 4
        Me.cboOperadorAccidente.ValueMember = "Id"
        '
        'UltraLabel4
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance46
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(17, 50)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel4.TabIndex = 59
        Me.UltraLabel4.Text = "Operador:"
        '
        'UltraLabel3
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Appearance47.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance47
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(29, 206)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel3.TabIndex = 58
        Me.UltraLabel3.Text = "Estado:"
        '
        'cboEstadoAccidente
        '
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoAccidente.Appearance = Appearance48
        Me.cboEstadoAccidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstadoAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoAccidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoAccidente.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoAccidente.Location = New System.Drawing.Point(73, 202)
        Me.cboEstadoAccidente.Name = "cboEstadoAccidente"
        Me.cboEstadoAccidente.Size = New System.Drawing.Size(153, 21)
        Me.cboEstadoAccidente.TabIndex = 9
        Me.cboEstadoAccidente.ValueMember = "Id"
        '
        'griAreasAccidente
        '
        Me.griAreasAccidente.DataSource = Me.ogdArea
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAreasAccidente.DisplayLayout.Appearance = Appearance49
        UltraGridColumn631.Header.VisiblePosition = 0
        UltraGridColumn631.Hidden = True
        UltraGridColumn631.Width = 50
        UltraGridColumn632.Header.VisiblePosition = 1
        UltraGridColumn632.Hidden = True
        UltraGridColumn633.Header.VisiblePosition = 2
        UltraGridColumn634.Header.Caption = "Area"
        UltraGridColumn634.Header.VisiblePosition = 3
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn631, UltraGridColumn632, UltraGridColumn633, UltraGridColumn634})
        Me.griAreasAccidente.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griAreasAccidente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAreasAccidente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasAccidente.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasAccidente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.griAreasAccidente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasAccidente.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.griAreasAccidente.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasAccidente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griAreasAccidente.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griAreasAccidente.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.griAreasAccidente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAreasAccidente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.griAreasAccidente.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griAreasAccidente.DisplayLayout.Override.CellAppearance = Appearance56
        Me.griAreasAccidente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreasAccidente.DisplayLayout.Override.CellPadding = 0
        Me.griAreasAccidente.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasAccidente.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Left"
        Me.griAreasAccidente.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.griAreasAccidente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasAccidente.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.griAreasAccidente.DisplayLayout.Override.RowAppearance = Appearance59
        Me.griAreasAccidente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griAreasAccidente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.griAreasAccidente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAreasAccidente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAreasAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasAccidente.Location = New System.Drawing.Point(317, 4)
        Me.griAreasAccidente.Name = "griAreasAccidente"
        Me.griAreasAccidente.Size = New System.Drawing.Size(213, 261)
        Me.griAreasAccidente.TabIndex = 16
        '
        'fecDosajeAccidente
        '
        Me.fecDosajeAccidente.CustomFormat = ""
        Me.fecDosajeAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecDosajeAccidente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDosajeAccidente.Location = New System.Drawing.Point(86, 247)
        Me.fecDosajeAccidente.Name = "fecDosajeAccidente"
        Me.fecDosajeAccidente.Size = New System.Drawing.Size(85, 20)
        Me.fecDosajeAccidente.TabIndex = 14
        Me.fecDosajeAccidente.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'fecDenunciaAccidente
        '
        Me.fecDenunciaAccidente.CustomFormat = ""
        Me.fecDenunciaAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecDenunciaAccidente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDenunciaAccidente.Location = New System.Drawing.Point(86, 224)
        Me.fecDenunciaAccidente.Name = "fecDenunciaAccidente"
        Me.fecDenunciaAccidente.Size = New System.Drawing.Size(86, 20)
        Me.fecDenunciaAccidente.TabIndex = 11
        Me.fecDenunciaAccidente.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'cboLugarAccidente
        '
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.cboLugarAccidente.Appearance = Appearance61
        Me.cboLugarAccidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugarAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugarAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarAccidente.ForeColor = System.Drawing.Color.Black
        Me.cboLugarAccidente.Location = New System.Drawing.Point(73, 70)
        Me.cboLugarAccidente.Name = "cboLugarAccidente"
        Me.cboLugarAccidente.Size = New System.Drawing.Size(241, 21)
        Me.cboLugarAccidente.TabIndex = 5
        Me.cboLugarAccidente.ValueMember = "Id"
        '
        'hDenunciaAccidente
        '
        Me.hDenunciaAccidente.CustomFormat = "HH:mm"
        Me.hDenunciaAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hDenunciaAccidente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hDenunciaAccidente.Location = New System.Drawing.Point(173, 225)
        Me.hDenunciaAccidente.Name = "hDenunciaAccidente"
        Me.hDenunciaAccidente.ShowUpDown = True
        Me.hDenunciaAccidente.Size = New System.Drawing.Size(53, 20)
        Me.hDenunciaAccidente.TabIndex = 12
        Me.hDenunciaAccidente.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'hDosajeAccidente
        '
        Me.hDosajeAccidente.CustomFormat = "HH:mm"
        Me.hDosajeAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hDosajeAccidente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hDosajeAccidente.Location = New System.Drawing.Point(173, 247)
        Me.hDosajeAccidente.Name = "hDosajeAccidente"
        Me.hDosajeAccidente.ShowUpDown = True
        Me.hDosajeAccidente.Size = New System.Drawing.Size(53, 20)
        Me.hDosajeAccidente.TabIndex = 15
        Me.hDosajeAccidente.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'Etiqueta3
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance62
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(37, 73)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta3.TabIndex = 48
        Me.Etiqueta3.Text = "Lugar:"
        '
        'chkDosajeAccidente
        '
        Me.chkDosajeAccidente.AutoSize = True
        Me.chkDosajeAccidente.BackColor = System.Drawing.Color.Transparent
        Me.chkDosajeAccidente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDosajeAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkDosajeAccidente.ForeColor = System.Drawing.Color.Navy
        Me.chkDosajeAccidente.Location = New System.Drawing.Point(27, 248)
        Me.chkDosajeAccidente.Name = "chkDosajeAccidente"
        Me.chkDosajeAccidente.Size = New System.Drawing.Size(59, 17)
        Me.chkDosajeAccidente.TabIndex = 13
        Me.chkDosajeAccidente.Text = "Dosaje"
        Me.chkDosajeAccidente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDosajeAccidente.UseVisualStyleBackColor = False
        '
        'fecAccidente
        '
        Me.fecAccidente.CustomFormat = ""
        Me.fecAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecAccidente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecAccidente.Location = New System.Drawing.Point(73, 5)
        Me.fecAccidente.Name = "fecAccidente"
        Me.fecAccidente.Size = New System.Drawing.Size(80, 20)
        Me.fecAccidente.TabIndex = 1
        Me.fecAccidente.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'txtReferenciaLugarAccidente
        '
        Me.txtReferenciaLugarAccidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaLugarAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaLugarAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaLugarAccidente.Location = New System.Drawing.Point(73, 92)
        Me.txtReferenciaLugarAccidente.Name = "txtReferenciaLugarAccidente"
        Me.txtReferenciaLugarAccidente.Size = New System.Drawing.Size(241, 21)
        Me.txtReferenciaLugarAccidente.TabIndex = 6
        '
        'chkDenunciaAccidente
        '
        Me.chkDenunciaAccidente.AutoSize = True
        Me.chkDenunciaAccidente.BackColor = System.Drawing.Color.Transparent
        Me.chkDenunciaAccidente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDenunciaAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkDenunciaAccidente.ForeColor = System.Drawing.Color.Navy
        Me.chkDenunciaAccidente.Location = New System.Drawing.Point(15, 225)
        Me.chkDenunciaAccidente.Name = "chkDenunciaAccidente"
        Me.chkDenunciaAccidente.Size = New System.Drawing.Size(72, 17)
        Me.chkDenunciaAccidente.TabIndex = 10
        Me.chkDenunciaAccidente.Text = "Denuncia"
        Me.chkDenunciaAccidente.UseVisualStyleBackColor = False
        '
        'UltraLabel12
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance63
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(10, 94)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel12.TabIndex = 44
        Me.UltraLabel12.Text = "Referencia:"
        '
        'txtDetalleAccidente
        '
        Appearance64.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleAccidente.Appearance = Appearance64
        Me.txtDetalleAccidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDetalleAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleAccidente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleAccidente.Location = New System.Drawing.Point(73, 114)
        Me.txtDetalleAccidente.MaxLength = 100
        Me.txtDetalleAccidente.Multiline = True
        Me.txtDetalleAccidente.Name = "txtDetalleAccidente"
        Me.txtDetalleAccidente.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleAccidente.Size = New System.Drawing.Size(241, 43)
        Me.txtDetalleAccidente.TabIndex = 7
        '
        'cboTipoAccidente
        '
        Appearance65.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAccidente.Appearance = Appearance65
        Me.cboTipoAccidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance66.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton2.Appearance = Appearance66
        Me.cboTipoAccidente.ButtonsRight.Add(EditorButton2)
        Me.cboTipoAccidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAccidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAccidente.ForeColor = System.Drawing.Color.Black
        Me.cboTipoAccidente.Location = New System.Drawing.Point(73, 26)
        Me.cboTipoAccidente.Name = "cboTipoAccidente"
        Me.cboTipoAccidente.Size = New System.Drawing.Size(241, 21)
        Me.cboTipoAccidente.TabIndex = 3
        Me.cboTipoAccidente.ValueMember = "Id"
        '
        'UltraLabel9
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance67
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(43, 30)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(29, 14)
        Me.UltraLabel9.TabIndex = 24
        Me.UltraLabel9.Text = "Tipo:"
        '
        'hAccidente
        '
        Me.hAccidente.CustomFormat = "HH:mm"
        Me.hAccidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hAccidente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hAccidente.Location = New System.Drawing.Point(156, 5)
        Me.hAccidente.Name = "hAccidente"
        Me.hAccidente.ShowUpDown = True
        Me.hAccidente.Size = New System.Drawing.Size(53, 20)
        Me.hAccidente.TabIndex = 2
        Me.hAccidente.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance68
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(34, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel10.TabIndex = 20
        Me.UltraLabel10.Text = "Fecha:"
        '
        'UltraLabel13
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Appearance69.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance69
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(28, 116)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel13.TabIndex = 5
        Me.UltraLabel13.Text = "Detalle:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(892, 505)
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance70.BackColor = System.Drawing.Color.White
        Appearance70.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance70
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox3.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox3.TabIndex = 7
        Me.UltraExpandableGroupBox3.Text = "Datos Generales del Incidente"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox5)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(869, 499)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.griListaIncidentes)
        Me.UltraGroupBox5.Controls.Add(Me.Panel4)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(869, 499)
        Me.UltraGroupBox5.TabIndex = 2
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaIncidentes
        '
        Me.griListaIncidentes.DataSource = Me.ogdIncidente
        UltraGridColumn635.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn635.Header.VisiblePosition = 0
        UltraGridColumn635.Hidden = True
        UltraGridColumn635.Width = 90
        UltraGridColumn636.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn636.Header.VisiblePosition = 1
        UltraGridColumn636.Width = 110
        UltraGridColumn637.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn637.Header.VisiblePosition = 2
        UltraGridColumn637.Hidden = True
        UltraGridColumn637.Width = 90
        UltraGridColumn638.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn638.Header.VisiblePosition = 4
        UltraGridColumn638.Hidden = True
        UltraGridColumn638.Width = 90
        UltraGridColumn639.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn639.Header.VisiblePosition = 5
        UltraGridColumn639.Hidden = True
        UltraGridColumn639.Width = 150
        UltraGridColumn640.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn640.Header.VisiblePosition = 6
        UltraGridColumn640.Hidden = True
        UltraGridColumn640.Width = 90
        UltraGridColumn641.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn641.Header.VisiblePosition = 7
        UltraGridColumn641.Width = 180
        UltraGridColumn642.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn642.Header.Caption = "Fecha"
        UltraGridColumn642.Header.VisiblePosition = 3
        UltraGridColumn642.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn642.Width = 110
        UltraGridColumn643.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn643.Header.VisiblePosition = 12
        UltraGridColumn643.Hidden = True
        UltraGridColumn643.Width = 90
        UltraGridColumn644.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn644.Header.VisiblePosition = 13
        UltraGridColumn644.Width = 150
        UltraGridColumn645.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn645.EditorComponent = Me.cboLugarIncidente
        UltraGridColumn645.Header.Caption = "IdUbicación"
        UltraGridColumn645.Header.VisiblePosition = 8
        UltraGridColumn645.Hidden = True
        UltraGridColumn645.Width = 90
        UltraGridColumn646.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn646.Header.VisiblePosition = 9
        UltraGridColumn646.Width = 220
        UltraGridColumn647.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn647.Header.VisiblePosition = 10
        UltraGridColumn647.Width = 250
        UltraGridColumn648.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn648.Header.Caption = "Descripción"
        UltraGridColumn648.Header.VisiblePosition = 11
        UltraGridColumn648.Width = 250
        UltraGridColumn649.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn649.Header.VisiblePosition = 19
        UltraGridColumn649.Hidden = True
        UltraGridColumn649.Width = 90
        UltraGridColumn650.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn650.Header.Caption = "Estado"
        UltraGridColumn650.Header.VisiblePosition = 20
        UltraGridColumn650.Width = 120
        UltraGridColumn651.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn651.Header.VisiblePosition = 15
        UltraGridColumn651.Hidden = True
        UltraGridColumn651.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn651.Width = 100
        UltraGridColumn652.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn652.Header.VisiblePosition = 16
        UltraGridColumn652.Hidden = True
        UltraGridColumn652.Width = 90
        UltraGridColumn653.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn653.Header.VisiblePosition = 14
        UltraGridColumn653.Hidden = True
        UltraGridColumn653.Width = 30
        UltraGridColumn654.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn654.Header.VisiblePosition = 17
        UltraGridColumn654.Hidden = True
        UltraGridColumn654.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn654.Width = 110
        UltraGridColumn655.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn655.Header.VisiblePosition = 18
        UltraGridColumn655.Hidden = True
        UltraGridColumn655.Width = 90
        UltraGridColumn656.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn656.Header.Caption = "Observación"
        UltraGridColumn656.Header.VisiblePosition = 21
        UltraGridColumn656.Width = 250
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn635, UltraGridColumn636, UltraGridColumn637, UltraGridColumn638, UltraGridColumn639, UltraGridColumn640, UltraGridColumn641, UltraGridColumn642, UltraGridColumn643, UltraGridColumn644, UltraGridColumn645, UltraGridColumn646, UltraGridColumn647, UltraGridColumn648, UltraGridColumn649, UltraGridColumn650, UltraGridColumn651, UltraGridColumn652, UltraGridColumn653, UltraGridColumn654, UltraGridColumn655, UltraGridColumn656})
        Me.griListaIncidentes.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griListaIncidentes.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaIncidentes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaIncidentes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaIncidentes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaIncidentes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaIncidentes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaIncidentes.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaIncidentes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaIncidentes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaIncidentes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaIncidentes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaIncidentes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaIncidentes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaIncidentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaIncidentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaIncidentes.Location = New System.Drawing.Point(3, 249)
        Me.griListaIncidentes.Name = "griListaIncidentes"
        Me.griListaIncidentes.Size = New System.Drawing.Size(863, 247)
        Me.griListaIncidentes.TabIndex = 14
        '
        'ogdIncidente
        '
        UltraDataColumn115.DataType = GetType(Date)
        UltraDataColumn124.DataType = GetType(Date)
        UltraDataColumn127.DataType = GetType(Date)
        Me.ogdIncidente.Band.Columns.AddRange(New Object() {UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.btnLimpiarIncidente)
        Me.Panel4.Controls.Add(Me.btnAgregarIncidente)
        Me.Panel4.Controls.Add(Me.txtObservacionIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel24)
        Me.Panel4.Controls.Add(Me.griAreasIncidentesAsignados)
        Me.Panel4.Controls.Add(Me.cboEstadoIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel19)
        Me.Panel4.Controls.Add(Me.cboOperadorIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel20)
        Me.Panel4.Controls.Add(Me.cboTipoIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel22)
        Me.Panel4.Controls.Add(Me.griAreasIncidentes)
        Me.Panel4.Controls.Add(Me.cboLugarIncidente)
        Me.Panel4.Controls.Add(Me.Etiqueta4)
        Me.Panel4.Controls.Add(Me.fecIncidente)
        Me.Panel4.Controls.Add(Me.txtReferenciaLugarIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel27)
        Me.Panel4.Controls.Add(Me.txtDetalleIncidente)
        Me.Panel4.Controls.Add(Me.hIncidente)
        Me.Panel4.Controls.Add(Me.UltraLabel23)
        Me.Panel4.Controls.Add(Me.UltraLabel28)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(863, 246)
        Me.Panel4.TabIndex = 0
        '
        'btnLimpiarIncidente
        '
        Appearance71.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.btnLimpiarIncidente.Appearance = Appearance71
        Me.btnLimpiarIncidente.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnLimpiarIncidente.Location = New System.Drawing.Point(288, 200)
        Me.btnLimpiarIncidente.Name = "btnLimpiarIncidente"
        Me.btnLimpiarIncidente.Size = New System.Drawing.Size(85, 25)
        Me.btnLimpiarIncidente.TabIndex = 13
        Me.btnLimpiarIncidente.Text = "Cancelar"
        '
        'btnAgregarIncidente
        '
        Appearance72.Image = CType(resources.GetObject("Appearance72.Image"), Object)
        Me.btnAgregarIncidente.Appearance = Appearance72
        Me.btnAgregarIncidente.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarIncidente.Location = New System.Drawing.Point(210, 200)
        Me.btnAgregarIncidente.Name = "btnAgregarIncidente"
        Me.btnAgregarIncidente.Size = New System.Drawing.Size(79, 25)
        Me.btnAgregarIncidente.TabIndex = 12
        Me.btnAgregarIncidente.Text = "Editar"
        '
        'txtObservacionIncidente
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionIncidente.Appearance = Appearance73
        Me.txtObservacionIncidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionIncidente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionIncidente.Location = New System.Drawing.Point(75, 157)
        Me.txtObservacionIncidente.MaxLength = 100
        Me.txtObservacionIncidente.Multiline = True
        Me.txtObservacionIncidente.Name = "txtObservacionIncidente"
        Me.txtObservacionIncidente.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionIncidente.Size = New System.Drawing.Size(298, 43)
        Me.txtObservacionIncidente.TabIndex = 8
        '
        'UltraLabel24
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance74
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(3, 157)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel24.TabIndex = 66
        Me.UltraLabel24.Text = "Observación:"
        '
        'griAreasIncidentesAsignados
        '
        Me.griAreasIncidentesAsignados.DataSource = Me.ogdAreaResponsable
        UltraGridColumn657.Header.VisiblePosition = 0
        UltraGridColumn657.Hidden = True
        UltraGridColumn658.Header.VisiblePosition = 1
        UltraGridColumn658.Hidden = True
        UltraGridColumn659.Header.VisiblePosition = 2
        UltraGridColumn659.Hidden = True
        UltraGridColumn660.Header.VisiblePosition = 5
        UltraGridColumn660.Hidden = True
        UltraGridColumn661.Header.VisiblePosition = 6
        UltraGridColumn661.Hidden = True
        UltraGridColumn662.Header.VisiblePosition = 3
        UltraGridColumn662.Hidden = True
        UltraGridColumn663.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn663.Header.Caption = "Area Seleccionadas"
        UltraGridColumn663.Header.VisiblePosition = 4
        UltraGridColumn663.Width = 95
        UltraGridColumn664.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn664.Header.VisiblePosition = 7
        UltraGridColumn664.MaxLength = 500
        UltraGridColumn664.Width = 135
        UltraGridColumn665.Header.VisiblePosition = 8
        UltraGridColumn665.Hidden = True
        UltraGridColumn666.Header.VisiblePosition = 9
        UltraGridColumn666.Hidden = True
        UltraGridColumn667.Header.VisiblePosition = 10
        UltraGridColumn667.Hidden = True
        UltraGridColumn668.Header.VisiblePosition = 11
        UltraGridColumn668.Hidden = True
        UltraGridColumn669.Header.VisiblePosition = 12
        UltraGridColumn669.Hidden = True
        UltraGridColumn670.Header.VisiblePosition = 13
        UltraGridColumn670.Hidden = True
        UltraGridColumn671.Header.VisiblePosition = 14
        UltraGridColumn671.Hidden = True
        UltraGridColumn672.Header.VisiblePosition = 15
        UltraGridColumn672.Hidden = True
        UltraGridColumn673.Header.VisiblePosition = 16
        UltraGridColumn673.Hidden = True
        UltraGridColumn674.Header.VisiblePosition = 17
        UltraGridColumn674.Hidden = True
        UltraGridColumn675.Header.VisiblePosition = 18
        UltraGridColumn675.Hidden = True
        UltraGridColumn676.Header.VisiblePosition = 19
        UltraGridColumn676.Hidden = True
        UltraGridColumn677.Header.VisiblePosition = 20
        UltraGridColumn677.Hidden = True
        UltraGridColumn678.Header.VisiblePosition = 21
        UltraGridColumn678.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 22
        UltraGridColumn179.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn657, UltraGridColumn658, UltraGridColumn659, UltraGridColumn660, UltraGridColumn661, UltraGridColumn662, UltraGridColumn663, UltraGridColumn664, UltraGridColumn665, UltraGridColumn666, UltraGridColumn667, UltraGridColumn668, UltraGridColumn669, UltraGridColumn670, UltraGridColumn671, UltraGridColumn672, UltraGridColumn673, UltraGridColumn674, UltraGridColumn675, UltraGridColumn676, UltraGridColumn677, UltraGridColumn678, UltraGridColumn179})
        Me.griAreasIncidentesAsignados.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griAreasIncidentesAsignados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreasIncidentesAsignados.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasIncidentesAsignados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreasIncidentesAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasIncidentesAsignados.Location = New System.Drawing.Point(596, 3)
        Me.griAreasIncidentesAsignados.Name = "griAreasIncidentesAsignados"
        Me.griAreasIncidentesAsignados.Size = New System.Drawing.Size(292, 219)
        Me.griAreasIncidentesAsignados.TabIndex = 11
        '
        'cboEstadoIncidente
        '
        Appearance75.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoIncidente.Appearance = Appearance75
        Me.cboEstadoIncidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstadoIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoIncidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoIncidente.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoIncidente.Location = New System.Drawing.Point(75, 201)
        Me.cboEstadoIncidente.Name = "cboEstadoIncidente"
        Me.cboEstadoIncidente.Size = New System.Drawing.Size(129, 21)
        Me.cboEstadoIncidente.TabIndex = 9
        Me.cboEstadoIncidente.ValueMember = "Id"
        '
        'UltraLabel19
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance76
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(26, 203)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel19.TabIndex = 65
        Me.UltraLabel19.Text = "Estado:"
        '
        'cboOperadorIncidente
        '
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorIncidente.Appearance = Appearance77
        Me.cboOperadorIncidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOperadorIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOperadorIncidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOperadorIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperadorIncidente.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorIncidente.Location = New System.Drawing.Point(75, 46)
        Me.cboOperadorIncidente.Name = "cboOperadorIncidente"
        Me.cboOperadorIncidente.Size = New System.Drawing.Size(298, 21)
        Me.cboOperadorIncidente.TabIndex = 4
        Me.cboOperadorIncidente.ValueMember = "Id"
        '
        'UltraLabel20
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Appearance78.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance78
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(14, 49)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel20.TabIndex = 62
        Me.UltraLabel20.Text = "Operador:"
        '
        'cboTipoIncidente
        '
        Appearance79.ForeColor = System.Drawing.Color.Black
        Me.cboTipoIncidente.Appearance = Appearance79
        Me.cboTipoIncidente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance80.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton3.Appearance = Appearance80
        Me.cboTipoIncidente.ButtonsRight.Add(EditorButton3)
        Me.cboTipoIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoIncidente.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoIncidente.ForeColor = System.Drawing.Color.Black
        Me.cboTipoIncidente.Location = New System.Drawing.Point(75, 24)
        Me.cboTipoIncidente.Name = "cboTipoIncidente"
        Me.cboTipoIncidente.Size = New System.Drawing.Size(298, 21)
        Me.cboTipoIncidente.TabIndex = 3
        Me.cboTipoIncidente.ValueMember = "Id"
        '
        'UltraLabel22
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance81
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(40, 27)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(29, 14)
        Me.UltraLabel22.TabIndex = 60
        Me.UltraLabel22.Text = "Tipo:"
        '
        'griAreasIncidentes
        '
        Me.griAreasIncidentes.DataSource = Me.ogdArea
        Appearance82.BackColor = System.Drawing.SystemColors.Window
        Appearance82.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAreasIncidentes.DisplayLayout.Appearance = Appearance82
        UltraGridColumn679.Header.VisiblePosition = 0
        UltraGridColumn679.Hidden = True
        UltraGridColumn679.Width = 50
        UltraGridColumn680.Header.VisiblePosition = 1
        UltraGridColumn680.Hidden = True
        UltraGridColumn703.Header.VisiblePosition = 2
        UltraGridColumn704.Header.Caption = "Area"
        UltraGridColumn704.Header.VisiblePosition = 3
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn679, UltraGridColumn680, UltraGridColumn703, UltraGridColumn704})
        Me.griAreasIncidentes.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griAreasIncidentes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAreasIncidentes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance83.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance83.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance83.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasIncidentes.DisplayLayout.GroupByBox.Appearance = Appearance83
        Appearance84.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasIncidentes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance84
        Me.griAreasIncidentes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance85.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance85.BackColor2 = System.Drawing.SystemColors.Control
        Appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance85.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasIncidentes.DisplayLayout.GroupByBox.PromptAppearance = Appearance85
        Me.griAreasIncidentes.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasIncidentes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance86.BackColor = System.Drawing.SystemColors.Window
        Appearance86.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griAreasIncidentes.DisplayLayout.Override.ActiveCellAppearance = Appearance86
        Appearance87.BackColor = System.Drawing.SystemColors.Highlight
        Appearance87.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griAreasIncidentes.DisplayLayout.Override.ActiveRowAppearance = Appearance87
        Me.griAreasIncidentes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAreasIncidentes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance88.BackColor = System.Drawing.SystemColors.Window
        Me.griAreasIncidentes.DisplayLayout.Override.CardAreaAppearance = Appearance88
        Appearance89.BorderColor = System.Drawing.Color.Silver
        Appearance89.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griAreasIncidentes.DisplayLayout.Override.CellAppearance = Appearance89
        Me.griAreasIncidentes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreasIncidentes.DisplayLayout.Override.CellPadding = 0
        Me.griAreasIncidentes.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Appearance90.BackColor = System.Drawing.SystemColors.Control
        Appearance90.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance90.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance90.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasIncidentes.DisplayLayout.Override.GroupByRowAppearance = Appearance90
        Appearance91.TextHAlignAsString = "Left"
        Me.griAreasIncidentes.DisplayLayout.Override.HeaderAppearance = Appearance91
        Me.griAreasIncidentes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasIncidentes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance92.BackColor = System.Drawing.SystemColors.Window
        Appearance92.BorderColor = System.Drawing.Color.Silver
        Me.griAreasIncidentes.DisplayLayout.Override.RowAppearance = Appearance92
        Me.griAreasIncidentes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance93.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griAreasIncidentes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance93
        Me.griAreasIncidentes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAreasIncidentes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAreasIncidentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasIncidentes.Location = New System.Drawing.Point(379, 4)
        Me.griAreasIncidentes.Name = "griAreasIncidentes"
        Me.griAreasIncidentes.Size = New System.Drawing.Size(213, 218)
        Me.griAreasIncidentes.TabIndex = 10
        '
        'Etiqueta4
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance94
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(34, 69)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta4.TabIndex = 46
        Me.Etiqueta4.Text = "Lugar:"
        '
        'fecIncidente
        '
        Me.fecIncidente.CustomFormat = ""
        Me.fecIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecIncidente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecIncidente.Location = New System.Drawing.Point(75, 3)
        Me.fecIncidente.Name = "fecIncidente"
        Me.fecIncidente.Size = New System.Drawing.Size(86, 20)
        Me.fecIncidente.TabIndex = 1
        Me.fecIncidente.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'txtReferenciaLugarIncidente
        '
        Me.txtReferenciaLugarIncidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaLugarIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaLugarIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaLugarIncidente.Location = New System.Drawing.Point(75, 91)
        Me.txtReferenciaLugarIncidente.Name = "txtReferenciaLugarIncidente"
        Me.txtReferenciaLugarIncidente.Size = New System.Drawing.Size(298, 21)
        Me.txtReferenciaLugarIncidente.TabIndex = 6
        '
        'UltraLabel27
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Appearance95.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance95
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(7, 92)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel27.TabIndex = 44
        Me.UltraLabel27.Text = "Referencia:"
        '
        'txtDetalleIncidente
        '
        Appearance96.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleIncidente.Appearance = Appearance96
        Me.txtDetalleIncidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleIncidente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDetalleIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleIncidente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleIncidente.Location = New System.Drawing.Point(75, 113)
        Me.txtDetalleIncidente.MaxLength = 100
        Me.txtDetalleIncidente.Multiline = True
        Me.txtDetalleIncidente.Name = "txtDetalleIncidente"
        Me.txtDetalleIncidente.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleIncidente.Size = New System.Drawing.Size(298, 43)
        Me.txtDetalleIncidente.TabIndex = 7
        '
        'hIncidente
        '
        Me.hIncidente.CustomFormat = "HH:mm"
        Me.hIncidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hIncidente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hIncidente.Location = New System.Drawing.Point(165, 3)
        Me.hIncidente.Name = "hIncidente"
        Me.hIncidente.ShowUpDown = True
        Me.hIncidente.Size = New System.Drawing.Size(53, 20)
        Me.hIncidente.TabIndex = 2
        Me.hIncidente.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'UltraLabel23
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance97
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(30, 4)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel23.TabIndex = 20
        Me.UltraLabel23.Text = "Fecha:"
        '
        'UltraLabel28
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Appearance98.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance98
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel28.Location = New System.Drawing.Point(26, 115)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel28.TabIndex = 5
        Me.UltraLabel28.Text = "Detalle:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(892, 505)
        '
        'UltraExpandableGroupBox4
        '
        Me.UltraExpandableGroupBox4.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance99.BackColor = System.Drawing.Color.White
        Appearance99.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance99
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox4.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(892, 505)
        Me.UltraExpandableGroupBox4.TabIndex = 8
        Me.UltraExpandableGroupBox4.Text = "Datos Generales del Robo"
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(869, 499)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.griListaRobos)
        Me.UltraGroupBox6.Controls.Add(Me.Panel5)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(869, 499)
        Me.UltraGroupBox6.TabIndex = 2
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griListaRobos
        '
        Me.griListaRobos.DataSource = Me.ogdRobo
        UltraGridColumn705.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn705.Header.VisiblePosition = 0
        UltraGridColumn705.Hidden = True
        UltraGridColumn705.Width = 90
        UltraGridColumn706.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn706.Header.VisiblePosition = 1
        UltraGridColumn706.Width = 110
        UltraGridColumn707.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn707.Header.VisiblePosition = 2
        UltraGridColumn707.Hidden = True
        UltraGridColumn707.Width = 90
        UltraGridColumn732.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn732.Header.VisiblePosition = 4
        UltraGridColumn732.Hidden = True
        UltraGridColumn732.Width = 90
        UltraGridColumn733.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn733.Header.VisiblePosition = 5
        UltraGridColumn733.Hidden = True
        UltraGridColumn733.Width = 150
        UltraGridColumn734.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn734.Header.VisiblePosition = 6
        UltraGridColumn734.Hidden = True
        UltraGridColumn734.Width = 90
        UltraGridColumn737.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn737.Header.VisiblePosition = 7
        UltraGridColumn737.Width = 180
        UltraGridColumn738.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn738.Header.Caption = "Fecha"
        UltraGridColumn738.Header.VisiblePosition = 3
        UltraGridColumn738.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn738.Width = 110
        UltraGridColumn739.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn739.Header.VisiblePosition = 12
        UltraGridColumn739.Hidden = True
        UltraGridColumn739.Width = 90
        UltraGridColumn740.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn740.Header.VisiblePosition = 13
        UltraGridColumn740.Width = 150
        UltraGridColumn813.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn813.EditorComponent = Me.cboLugarRobo
        UltraGridColumn813.Header.Caption = "Ubicación"
        UltraGridColumn813.Header.VisiblePosition = 8
        UltraGridColumn813.Hidden = True
        UltraGridColumn813.Width = 100
        UltraGridColumn814.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn814.Header.VisiblePosition = 9
        UltraGridColumn814.Width = 220
        UltraGridColumn815.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn815.Header.Caption = "Referencia de lugar"
        UltraGridColumn815.Header.VisiblePosition = 10
        UltraGridColumn815.Width = 250
        UltraGridColumn816.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn816.Header.Caption = "Descripción"
        UltraGridColumn816.Header.VisiblePosition = 11
        UltraGridColumn816.Width = 250
        UltraGridColumn817.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn817.Header.VisiblePosition = 14
        UltraGridColumn817.Width = 30
        UltraGridColumn818.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn818.Header.Caption = "Fecha Denuncia"
        UltraGridColumn818.Header.VisiblePosition = 15
        UltraGridColumn818.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn818.Width = 110
        UltraGridColumn819.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn819.Header.VisiblePosition = 21
        UltraGridColumn819.Hidden = True
        UltraGridColumn819.Width = 90
        UltraGridColumn820.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn820.Header.Caption = "Estado"
        UltraGridColumn820.Header.VisiblePosition = 22
        UltraGridColumn820.Width = 120
        UltraGridColumn821.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn821.Header.VisiblePosition = 17
        UltraGridColumn821.Hidden = True
        UltraGridColumn821.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn821.Width = 100
        UltraGridColumn822.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn822.Header.VisiblePosition = 18
        UltraGridColumn822.Hidden = True
        UltraGridColumn822.Width = 90
        UltraGridColumn823.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn823.Header.VisiblePosition = 16
        UltraGridColumn823.Hidden = True
        UltraGridColumn823.Width = 30
        UltraGridColumn824.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn824.Header.VisiblePosition = 19
        UltraGridColumn824.Hidden = True
        UltraGridColumn824.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn824.Width = 110
        UltraGridColumn825.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn825.Header.VisiblePosition = 20
        UltraGridColumn825.Hidden = True
        UltraGridColumn825.Width = 90
        UltraGridColumn826.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn826.Header.Caption = "Observación"
        UltraGridColumn826.Header.VisiblePosition = 23
        UltraGridColumn826.Width = 250
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn705, UltraGridColumn706, UltraGridColumn707, UltraGridColumn732, UltraGridColumn733, UltraGridColumn734, UltraGridColumn737, UltraGridColumn738, UltraGridColumn739, UltraGridColumn740, UltraGridColumn813, UltraGridColumn814, UltraGridColumn815, UltraGridColumn816, UltraGridColumn817, UltraGridColumn818, UltraGridColumn819, UltraGridColumn820, UltraGridColumn821, UltraGridColumn822, UltraGridColumn823, UltraGridColumn824, UltraGridColumn825, UltraGridColumn826})
        Me.griListaRobos.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griListaRobos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaRobos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaRobos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRobos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaRobos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaRobos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaRobos.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaRobos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaRobos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaRobos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaRobos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaRobos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaRobos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaRobos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaRobos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaRobos.Location = New System.Drawing.Point(3, 259)
        Me.griListaRobos.Name = "griListaRobos"
        Me.griListaRobos.Size = New System.Drawing.Size(863, 237)
        Me.griListaRobos.TabIndex = 17
        '
        'ogdRobo
        '
        UltraDataColumn137.DataType = GetType(Date)
        UltraDataColumn145.DataType = GetType(Date)
        UltraDataColumn148.DataType = GetType(Date)
        UltraDataColumn151.DataType = GetType(Date)
        Me.ogdRobo.Band.Columns.AddRange(New Object() {UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153})
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.btnLimpiarRobo)
        Me.Panel5.Controls.Add(Me.btnAgregarRobo)
        Me.Panel5.Controls.Add(Me.txtObservacionRobo)
        Me.Panel5.Controls.Add(Me.UltraLabel30)
        Me.Panel5.Controls.Add(Me.griAreaRoboAsignada)
        Me.Panel5.Controls.Add(Me.griAreasRobo)
        Me.Panel5.Controls.Add(Me.cboOperadorRobo)
        Me.Panel5.Controls.Add(Me.UltraLabel26)
        Me.Panel5.Controls.Add(Me.UltraLabel33)
        Me.Panel5.Controls.Add(Me.cboEstadoRobo)
        Me.Panel5.Controls.Add(Me.cboTipoRobo)
        Me.Panel5.Controls.Add(Me.UltraLabel34)
        Me.Panel5.Controls.Add(Me.fecDenunciaRobo)
        Me.Panel5.Controls.Add(Me.cboLugarRobo)
        Me.Panel5.Controls.Add(Me.hDenunciaRobo)
        Me.Panel5.Controls.Add(Me.Etiqueta5)
        Me.Panel5.Controls.Add(Me.fecRobo)
        Me.Panel5.Controls.Add(Me.txtReferenciaLugarRobo)
        Me.Panel5.Controls.Add(Me.chkDenunciaRobo)
        Me.Panel5.Controls.Add(Me.UltraLabel31)
        Me.Panel5.Controls.Add(Me.txtDetalleRobo)
        Me.Panel5.Controls.Add(Me.hRobo)
        Me.Panel5.Controls.Add(Me.UltraLabel29)
        Me.Panel5.Controls.Add(Me.UltraLabel32)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(863, 256)
        Me.Panel5.TabIndex = 0
        '
        'btnLimpiarRobo
        '
        Appearance100.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.btnLimpiarRobo.Appearance = Appearance100
        Me.btnLimpiarRobo.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnLimpiarRobo.Location = New System.Drawing.Point(282, 224)
        Me.btnLimpiarRobo.Name = "btnLimpiarRobo"
        Me.btnLimpiarRobo.Size = New System.Drawing.Size(82, 25)
        Me.btnLimpiarRobo.TabIndex = 16
        Me.btnLimpiarRobo.Text = "Cancelar"
        '
        'btnAgregarRobo
        '
        Appearance101.Image = CType(resources.GetObject("Appearance101.Image"), Object)
        Me.btnAgregarRobo.Appearance = Appearance101
        Me.btnAgregarRobo.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarRobo.Location = New System.Drawing.Point(282, 199)
        Me.btnAgregarRobo.Name = "btnAgregarRobo"
        Me.btnAgregarRobo.Size = New System.Drawing.Size(82, 25)
        Me.btnAgregarRobo.TabIndex = 15
        Me.btnAgregarRobo.Text = "Editar"
        '
        'txtObservacionRobo
        '
        Appearance102.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionRobo.Appearance = Appearance102
        Me.txtObservacionRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionRobo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionRobo.Location = New System.Drawing.Point(74, 156)
        Me.txtObservacionRobo.MaxLength = 100
        Me.txtObservacionRobo.Multiline = True
        Me.txtObservacionRobo.Name = "txtObservacionRobo"
        Me.txtObservacionRobo.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionRobo.Size = New System.Drawing.Size(290, 43)
        Me.txtObservacionRobo.TabIndex = 8
        '
        'UltraLabel30
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Appearance103.TextVAlignAsString = "Middle"
        Me.UltraLabel30.Appearance = Appearance103
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel30.Location = New System.Drawing.Point(3, 159)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel30.TabIndex = 66
        Me.UltraLabel30.Text = "Observación:"
        '
        'griAreaRoboAsignada
        '
        Me.griAreaRoboAsignada.DataSource = Me.ogdAreaResponsable
        UltraGridColumn827.Header.VisiblePosition = 0
        UltraGridColumn827.Hidden = True
        UltraGridColumn828.Header.VisiblePosition = 1
        UltraGridColumn828.Hidden = True
        UltraGridColumn829.Header.VisiblePosition = 2
        UltraGridColumn829.Hidden = True
        UltraGridColumn830.Header.VisiblePosition = 5
        UltraGridColumn830.Hidden = True
        UltraGridColumn831.Header.VisiblePosition = 6
        UltraGridColumn831.Hidden = True
        UltraGridColumn832.Header.VisiblePosition = 3
        UltraGridColumn832.Hidden = True
        UltraGridColumn833.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn833.Header.Caption = "Area Seleccionadas"
        UltraGridColumn833.Header.VisiblePosition = 4
        UltraGridColumn833.Width = 95
        UltraGridColumn834.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn834.Header.VisiblePosition = 7
        UltraGridColumn834.MaxLength = 500
        UltraGridColumn834.Width = 135
        UltraGridColumn835.Header.VisiblePosition = 8
        UltraGridColumn835.Hidden = True
        UltraGridColumn836.Header.VisiblePosition = 9
        UltraGridColumn836.Hidden = True
        UltraGridColumn837.Header.VisiblePosition = 10
        UltraGridColumn837.Hidden = True
        UltraGridColumn838.Header.VisiblePosition = 11
        UltraGridColumn838.Hidden = True
        UltraGridColumn885.Header.VisiblePosition = 12
        UltraGridColumn885.Hidden = True
        UltraGridColumn886.Header.VisiblePosition = 13
        UltraGridColumn886.Hidden = True
        UltraGridColumn887.Header.VisiblePosition = 14
        UltraGridColumn887.Hidden = True
        UltraGridColumn888.Header.VisiblePosition = 15
        UltraGridColumn888.Hidden = True
        UltraGridColumn889.Header.VisiblePosition = 16
        UltraGridColumn889.Hidden = True
        UltraGridColumn890.Header.VisiblePosition = 17
        UltraGridColumn890.Hidden = True
        UltraGridColumn891.Header.VisiblePosition = 18
        UltraGridColumn891.Hidden = True
        UltraGridColumn892.Header.VisiblePosition = 19
        UltraGridColumn892.Hidden = True
        UltraGridColumn893.Header.VisiblePosition = 20
        UltraGridColumn893.Hidden = True
        UltraGridColumn894.Header.VisiblePosition = 21
        UltraGridColumn894.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 22
        UltraGridColumn184.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn827, UltraGridColumn828, UltraGridColumn829, UltraGridColumn830, UltraGridColumn831, UltraGridColumn832, UltraGridColumn833, UltraGridColumn834, UltraGridColumn835, UltraGridColumn836, UltraGridColumn837, UltraGridColumn838, UltraGridColumn885, UltraGridColumn886, UltraGridColumn887, UltraGridColumn888, UltraGridColumn889, UltraGridColumn890, UltraGridColumn891, UltraGridColumn892, UltraGridColumn893, UltraGridColumn894, UltraGridColumn184})
        Me.griAreaRoboAsignada.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griAreaRoboAsignada.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griAreaRoboAsignada.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreaRoboAsignada.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreaRoboAsignada.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAreaRoboAsignada.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAreaRoboAsignada.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAreaRoboAsignada.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAreaRoboAsignada.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreaRoboAsignada.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAreaRoboAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreaRoboAsignada.Location = New System.Drawing.Point(585, 3)
        Me.griAreaRoboAsignada.Name = "griAreaRoboAsignada"
        Me.griAreaRoboAsignada.Size = New System.Drawing.Size(292, 246)
        Me.griAreaRoboAsignada.TabIndex = 14
        '
        'griAreasRobo
        '
        Me.griAreasRobo.DataSource = Me.ogdArea
        Appearance104.BackColor = System.Drawing.SystemColors.Window
        Appearance104.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAreasRobo.DisplayLayout.Appearance = Appearance104
        UltraGridColumn895.Header.VisiblePosition = 0
        UltraGridColumn895.Hidden = True
        UltraGridColumn895.Width = 50
        UltraGridColumn896.Header.VisiblePosition = 1
        UltraGridColumn896.Hidden = True
        UltraGridColumn897.Header.VisiblePosition = 2
        UltraGridColumn898.Header.Caption = "Area"
        UltraGridColumn898.Header.VisiblePosition = 3
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn895, UltraGridColumn896, UltraGridColumn897, UltraGridColumn898})
        Me.griAreasRobo.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griAreasRobo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAreasRobo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance105.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance105.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance105.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance105.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasRobo.DisplayLayout.GroupByBox.Appearance = Appearance105
        Appearance106.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasRobo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance106
        Me.griAreasRobo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance107.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance107.BackColor2 = System.Drawing.SystemColors.Control
        Appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance107.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAreasRobo.DisplayLayout.GroupByBox.PromptAppearance = Appearance107
        Me.griAreasRobo.DisplayLayout.MaxColScrollRegions = 1
        Me.griAreasRobo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance108.BackColor = System.Drawing.SystemColors.Window
        Appearance108.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griAreasRobo.DisplayLayout.Override.ActiveCellAppearance = Appearance108
        Appearance109.BackColor = System.Drawing.SystemColors.Highlight
        Appearance109.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griAreasRobo.DisplayLayout.Override.ActiveRowAppearance = Appearance109
        Me.griAreasRobo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAreasRobo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance110.BackColor = System.Drawing.SystemColors.Window
        Me.griAreasRobo.DisplayLayout.Override.CardAreaAppearance = Appearance110
        Appearance111.BorderColor = System.Drawing.Color.Silver
        Appearance111.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griAreasRobo.DisplayLayout.Override.CellAppearance = Appearance111
        Me.griAreasRobo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAreasRobo.DisplayLayout.Override.CellPadding = 0
        Me.griAreasRobo.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Appearance112.BackColor = System.Drawing.SystemColors.Control
        Appearance112.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance112.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance112.BorderColor = System.Drawing.SystemColors.Window
        Me.griAreasRobo.DisplayLayout.Override.GroupByRowAppearance = Appearance112
        Appearance113.TextHAlignAsString = "Left"
        Me.griAreasRobo.DisplayLayout.Override.HeaderAppearance = Appearance113
        Me.griAreasRobo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAreasRobo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance114.BackColor = System.Drawing.SystemColors.Window
        Appearance114.BorderColor = System.Drawing.Color.Silver
        Me.griAreasRobo.DisplayLayout.Override.RowAppearance = Appearance114
        Me.griAreasRobo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance115.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griAreasRobo.DisplayLayout.Override.TemplateAddRowAppearance = Appearance115
        Me.griAreasRobo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAreasRobo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAreasRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.griAreasRobo.Location = New System.Drawing.Point(368, 3)
        Me.griAreasRobo.Name = "griAreasRobo"
        Me.griAreasRobo.Size = New System.Drawing.Size(213, 246)
        Me.griAreasRobo.TabIndex = 13
        '
        'cboOperadorRobo
        '
        Appearance116.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorRobo.Appearance = Appearance116
        Me.cboOperadorRobo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOperadorRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOperadorRobo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOperadorRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperadorRobo.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorRobo.Location = New System.Drawing.Point(74, 47)
        Me.cboOperadorRobo.Name = "cboOperadorRobo"
        Me.cboOperadorRobo.Size = New System.Drawing.Size(290, 21)
        Me.cboOperadorRobo.TabIndex = 4
        Me.cboOperadorRobo.ValueMember = "Id"
        '
        'UltraLabel26
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Appearance117.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance117
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(20, 50)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel26.TabIndex = 65
        Me.UltraLabel26.Text = "Operador:"
        '
        'UltraLabel33
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Appearance118.TextVAlignAsString = "Middle"
        Me.UltraLabel33.Appearance = Appearance118
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel33.Location = New System.Drawing.Point(28, 200)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel33.TabIndex = 64
        Me.UltraLabel33.Text = "Estado:"
        '
        'cboEstadoRobo
        '
        Appearance119.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoRobo.Appearance = Appearance119
        Me.cboEstadoRobo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstadoRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoRobo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoRobo.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoRobo.Location = New System.Drawing.Point(74, 200)
        Me.cboEstadoRobo.Name = "cboEstadoRobo"
        Me.cboEstadoRobo.Size = New System.Drawing.Size(158, 21)
        Me.cboEstadoRobo.TabIndex = 9
        Me.cboEstadoRobo.ValueMember = "Id"
        '
        'cboTipoRobo
        '
        Appearance120.ForeColor = System.Drawing.Color.Black
        Me.cboTipoRobo.Appearance = Appearance120
        Me.cboTipoRobo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance121.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton4.Appearance = Appearance121
        Me.cboTipoRobo.ButtonsRight.Add(EditorButton4)
        Me.cboTipoRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoRobo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRobo.ForeColor = System.Drawing.Color.Black
        Me.cboTipoRobo.Location = New System.Drawing.Point(74, 25)
        Me.cboTipoRobo.Name = "cboTipoRobo"
        Me.cboTipoRobo.Size = New System.Drawing.Size(290, 21)
        Me.cboTipoRobo.TabIndex = 3
        Me.cboTipoRobo.ValueMember = "Id"
        '
        'UltraLabel34
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance122
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel34.Location = New System.Drawing.Point(46, 27)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(29, 14)
        Me.UltraLabel34.TabIndex = 61
        Me.UltraLabel34.Text = "Tipo:"
        '
        'fecDenunciaRobo
        '
        Me.fecDenunciaRobo.CustomFormat = ""
        Me.fecDenunciaRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecDenunciaRobo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDenunciaRobo.Location = New System.Drawing.Point(91, 223)
        Me.fecDenunciaRobo.Name = "fecDenunciaRobo"
        Me.fecDenunciaRobo.Size = New System.Drawing.Size(86, 20)
        Me.fecDenunciaRobo.TabIndex = 11
        Me.fecDenunciaRobo.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'hDenunciaRobo
        '
        Me.hDenunciaRobo.CustomFormat = "HH:mm"
        Me.hDenunciaRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hDenunciaRobo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hDenunciaRobo.Location = New System.Drawing.Point(179, 224)
        Me.hDenunciaRobo.Name = "hDenunciaRobo"
        Me.hDenunciaRobo.ShowUpDown = True
        Me.hDenunciaRobo.Size = New System.Drawing.Size(53, 20)
        Me.hDenunciaRobo.TabIndex = 12
        Me.hDenunciaRobo.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'Etiqueta5
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance123
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(36, 73)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta5.TabIndex = 48
        Me.Etiqueta5.Text = "Lugar:"
        '
        'fecRobo
        '
        Me.fecRobo.CustomFormat = ""
        Me.fecRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecRobo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecRobo.Location = New System.Drawing.Point(74, 4)
        Me.fecRobo.Name = "fecRobo"
        Me.fecRobo.Size = New System.Drawing.Size(86, 20)
        Me.fecRobo.TabIndex = 1
        Me.fecRobo.Value = New Date(2015, 10, 22, 0, 0, 0, 0)
        '
        'txtReferenciaLugarRobo
        '
        Me.txtReferenciaLugarRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaLugarRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferenciaLugarRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaLugarRobo.Location = New System.Drawing.Point(74, 91)
        Me.txtReferenciaLugarRobo.Name = "txtReferenciaLugarRobo"
        Me.txtReferenciaLugarRobo.Size = New System.Drawing.Size(290, 21)
        Me.txtReferenciaLugarRobo.TabIndex = 6
        '
        'chkDenunciaRobo
        '
        Me.chkDenunciaRobo.AutoSize = True
        Me.chkDenunciaRobo.BackColor = System.Drawing.Color.Transparent
        Me.chkDenunciaRobo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDenunciaRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkDenunciaRobo.ForeColor = System.Drawing.Color.Navy
        Me.chkDenunciaRobo.Location = New System.Drawing.Point(17, 226)
        Me.chkDenunciaRobo.Name = "chkDenunciaRobo"
        Me.chkDenunciaRobo.Size = New System.Drawing.Size(72, 17)
        Me.chkDenunciaRobo.TabIndex = 10
        Me.chkDenunciaRobo.Text = "Denuncia"
        Me.chkDenunciaRobo.UseVisualStyleBackColor = False
        '
        'UltraLabel31
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.UltraLabel31.Appearance = Appearance124
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel31.Location = New System.Drawing.Point(11, 93)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel31.TabIndex = 44
        Me.UltraLabel31.Text = "Referencia:"
        '
        'txtDetalleRobo
        '
        Appearance125.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleRobo.Appearance = Appearance125
        Me.txtDetalleRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleRobo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDetalleRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleRobo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDetalleRobo.Location = New System.Drawing.Point(74, 113)
        Me.txtDetalleRobo.MaxLength = 100
        Me.txtDetalleRobo.Multiline = True
        Me.txtDetalleRobo.Name = "txtDetalleRobo"
        Me.txtDetalleRobo.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleRobo.Size = New System.Drawing.Size(290, 42)
        Me.txtDetalleRobo.TabIndex = 7
        '
        'hRobo
        '
        Me.hRobo.CustomFormat = "HH:mm"
        Me.hRobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hRobo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hRobo.Location = New System.Drawing.Point(163, 4)
        Me.hRobo.Name = "hRobo"
        Me.hRobo.ShowUpDown = True
        Me.hRobo.Size = New System.Drawing.Size(53, 20)
        Me.hRobo.TabIndex = 2
        Me.hRobo.Value = New Date(2013, 8, 14, 0, 0, 0, 0)
        '
        'UltraLabel29
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance126
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(36, 7)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel29.TabIndex = 20
        Me.UltraLabel29.Text = "Fecha:"
        '
        'UltraLabel32
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Appearance127.TextVAlignAsString = "Middle"
        Me.UltraLabel32.Appearance = Appearance127
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(28, 115)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel32.TabIndex = 5
        Me.UltraLabel32.Text = "Detalle:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalAccidentes)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1244, 528)
        '
        'agrTotalAccidentes
        '
        Me.agrTotalAccidentes.Controls.Add(Me.tabListado)
        Me.agrTotalAccidentes.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.agrTotalAccidentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTotalAccidentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTotalAccidentes.ForeColor = System.Drawing.Color.Black
        Me.agrTotalAccidentes.Location = New System.Drawing.Point(0, 0)
        Me.agrTotalAccidentes.Name = "agrTotalAccidentes"
        Me.agrTotalAccidentes.Size = New System.Drawing.Size(1244, 528)
        Me.agrTotalAccidentes.TabIndex = 1
        Me.agrTotalAccidentes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tabListado
        '
        Me.tabListado.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabListado.Controls.Add(Me.UltraTabPageControl5)
        Me.tabListado.Controls.Add(Me.UltraTabPageControl6)
        Me.tabListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabListado.Location = New System.Drawing.Point(3, 87)
        Me.tabListado.Name = "tabListado"
        Me.tabListado.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabListado.Size = New System.Drawing.Size(1238, 438)
        Me.tabListado.TabIndex = 22
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "General"
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "Areas Responsables"
        Me.tabListado.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabListado.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1236, 415)
        '
        'UltraExpandableGroupBox6
        '
        Appearance128.BackColor = System.Drawing.Color.White
        Appearance128.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance128
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1238, 84)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1238, 84)
        Me.UltraExpandableGroupBox6.TabIndex = 21
        Me.UltraExpandableGroupBox6.Text = "Busqueda"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox3)
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraGroupBox13)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(1232, 61)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Appearance129.BackColor = System.Drawing.Color.White
        Appearance129.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance129
        Me.UltraGroupBox3.Controls.Add(Me.ColorGenerado)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox3.Controls.Add(Me.ColorFinalizadoArea)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox3.Controls.Add(Me.ColorPendiente)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox3.Controls.Add(Me.ColorFinalizado)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta24)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(340, 1)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(895, 60)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorGenerado
        '
        Me.ColorGenerado.Color = System.Drawing.Color.GreenYellow
        Me.ColorGenerado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorGenerado.Location = New System.Drawing.Point(204, 10)
        Me.ColorGenerado.Name = "ColorGenerado"
        Me.ColorGenerado.Size = New System.Drawing.Size(44, 19)
        Me.ColorGenerado.TabIndex = 15
        Me.ColorGenerado.Text = "GreenYellow"
        '
        'Etiqueta1
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance130
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(141, 37)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta1.TabIndex = 16
        Me.Etiqueta1.Text = "Finalizado:"
        '
        'ColorFinalizadoArea
        '
        Me.ColorFinalizadoArea.Color = System.Drawing.Color.LightBlue
        Me.ColorFinalizadoArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFinalizadoArea.Location = New System.Drawing.Point(204, 34)
        Me.ColorFinalizadoArea.Name = "ColorFinalizadoArea"
        Me.ColorFinalizadoArea.Size = New System.Drawing.Size(44, 19)
        Me.ColorFinalizadoArea.TabIndex = 17
        Me.ColorFinalizadoArea.Text = "LightBlue"
        '
        'Etiqueta6
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance131
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(142, 13)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta6.TabIndex = 14
        Me.Etiqueta6.Text = "Generado:"
        '
        'ColorPendiente
        '
        Me.ColorPendiente.Color = System.Drawing.Color.GreenYellow
        Me.ColorPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPendiente.Location = New System.Drawing.Point(72, 11)
        Me.ColorPendiente.Name = "ColorPendiente"
        Me.ColorPendiente.Size = New System.Drawing.Size(44, 19)
        Me.ColorPendiente.TabIndex = 11
        Me.ColorPendiente.Text = "GreenYellow"
        '
        'Etiqueta28
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance132
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(9, 38)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta28.TabIndex = 12
        Me.Etiqueta28.Text = "Finalizado:"
        '
        'ColorFinalizado
        '
        Me.ColorFinalizado.Color = System.Drawing.Color.LightBlue
        Me.ColorFinalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFinalizado.Location = New System.Drawing.Point(72, 35)
        Me.ColorFinalizado.Name = "ColorFinalizado"
        Me.ColorFinalizado.Size = New System.Drawing.Size(44, 19)
        Me.ColorFinalizado.TabIndex = 13
        Me.ColorFinalizado.Text = "LightBlue"
        '
        'Etiqueta24
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance133
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(10, 14)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta24.TabIndex = 10
        Me.Etiqueta24.Text = "Pendiente:"
        '
        'UltraGroupBox13
        '
        Appearance134.BackColor = System.Drawing.Color.White
        Appearance134.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance134
        Me.UltraGroupBox13.Controls.Add(Me.cboEventoBusqueda)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(-1, 1)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(335, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboEventoBusqueda
        '
        Appearance135.ForeColor = System.Drawing.Color.Black
        Me.cboEventoBusqueda.Appearance = Appearance135
        Me.cboEventoBusqueda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEventoBusqueda.DisplayMember = "Login"
        Me.cboEventoBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEventoBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEventoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventoBusqueda.ForeColor = System.Drawing.Color.Black
        Me.cboEventoBusqueda.Location = New System.Drawing.Point(192, 9)
        Me.cboEventoBusqueda.Name = "cboEventoBusqueda"
        Me.cboEventoBusqueda.Size = New System.Drawing.Size(134, 21)
        Me.cboEventoBusqueda.TabIndex = 4
        Me.cboEventoBusqueda.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance136
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel62.Location = New System.Drawing.Point(144, 13)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel62.TabIndex = 3
        Me.UltraLabel62.Text = "Evento:"
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2014, 8, 15, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 32)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 21)
        Me.fecHasta.TabIndex = 2
        Me.fecHasta.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel39
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Appearance137.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance137
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(9, 36)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel39.TabIndex = 2
        Me.UltraLabel39.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2014, 8, 15, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 9)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 21)
        Me.fecDesde.TabIndex = 1
        Me.fecDesde.Value = New Date(2014, 8, 15, 0, 0, 0, 0)
        '
        'UltraLabel41
        '
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Appearance138.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance138
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.fichaDetalle)
        Me.utpDetalle.Controls.Add(Me.exgruViaje)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1244, 528)
        '
        'fichaDetalle
        '
        Me.fichaDetalle.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.fichaDetalle.Controls.Add(Me.UltraTabPageControl2)
        Me.fichaDetalle.Controls.Add(Me.UltraTabPageControl1)
        Me.fichaDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.fichaDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.fichaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fichaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fichaDetalle.Location = New System.Drawing.Point(350, 0)
        Me.fichaDetalle.Name = "fichaDetalle"
        Me.fichaDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.fichaDetalle.Size = New System.Drawing.Size(894, 528)
        Me.fichaDetalle.TabIndex = 8
        UltraTab7.TabPage = Me.UltraTabPageControl2
        UltraTab7.Text = "Alarmas"
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Accidentes"
        UltraTab9.TabPage = Me.UltraTabPageControl3
        UltraTab9.Text = "Incidentes"
        UltraTab10.TabPage = Me.UltraTabPageControl4
        UltraTab10.Text = "Robos"
        Me.fichaDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8, UltraTab9, UltraTab10})
        Me.fichaDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(892, 505)
        '
        'exgruViaje
        '
        Me.exgruViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance139.BackColor = System.Drawing.Color.White
        Appearance139.BackColor2 = System.Drawing.Color.White
        Me.exgruViaje.ContentAreaAppearance = Appearance139
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Left
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(350, 528)
        Me.exgruViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(350, 528)
        Me.exgruViaje.TabIndex = 7
        Me.exgruViaje.Text = "Datos de Viaje"
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.btnBuscar)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.lblPilotoGRT)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboPilotoTercero)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboActividadNegocio)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel35)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.fecViaje)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel36)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeEscala)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtIdViaje)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeCopiloto)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel37)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel38)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeDestino)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel40)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel42)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtCodigoViaje)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeCarreta)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel43)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel44)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtCodigoOperacion)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeTracto)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajePiloto)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel45)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel46)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtViajeOrigen)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtIdSeguimiento)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtIdOperacion)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtIdOperacionDetalle)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(327, 522)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'btnBuscar
        '
        Appearance140.Image = Global.ISL.Win.My.Resources.Resources.consult
        Me.btnBuscar.Appearance = Appearance140
        Me.btnBuscar.Location = New System.Drawing.Point(245, 214)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 25)
        Me.btnBuscar.TabIndex = 53
        Me.btnBuscar.Text = "Buscar"
        '
        'lblPilotoGRT
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Appearance141.TextVAlignAsString = "Middle"
        Me.lblPilotoGRT.Appearance = Appearance141
        Me.lblPilotoGRT.AutoSize = True
        Me.lblPilotoGRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPilotoGRT.Location = New System.Drawing.Point(2, 192)
        Me.lblPilotoGRT.Name = "lblPilotoGRT"
        Me.lblPilotoGRT.Size = New System.Drawing.Size(63, 14)
        Me.lblPilotoGRT.TabIndex = 52
        Me.lblPilotoGRT.Text = "Piloto GRT:"
        Me.lblPilotoGRT.Visible = False
        '
        'cboPilotoTercero
        '
        Appearance142.Image = Global.ISL.Win.My.Resources.Resources.consult
        EditorButton5.Appearance = Appearance142
        Me.cboPilotoTercero.ButtonsRight.Add(EditorButton5)
        Me.cboPilotoTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPilotoTercero.DisplayMember = "Nombre"
        Me.cboPilotoTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPilotoTercero.Location = New System.Drawing.Point(66, 186)
        Me.cboPilotoTercero.Name = "cboPilotoTercero"
        Me.cboPilotoTercero.Size = New System.Drawing.Size(260, 22)
        Me.cboPilotoTercero.TabIndex = 51
        Me.cboPilotoTercero.ValueMember = "Id"
        Me.cboPilotoTercero.Visible = False
        '
        'cboActividadNegocio
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance143
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocio.DisplayMember = "Nombre"
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Location = New System.Drawing.Point(175, 48)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.ReadOnly = True
        Me.cboActividadNegocio.Size = New System.Drawing.Size(150, 21)
        Me.cboActividadNegocio.TabIndex = 32
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'UltraLabel35
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Appearance144.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance144
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel35.Location = New System.Drawing.Point(-1, 52)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel35.TabIndex = 5
        Me.UltraLabel35.Text = "F. Atencion:"
        '
        'fecViaje
        '
        Appearance145.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Appearance = Appearance145
        Me.fecViaje.DateTime = New Date(2014, 11, 14, 0, 0, 0, 0)
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Location = New System.Drawing.Point(66, 48)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.ReadOnly = True
        Me.fecViaje.Size = New System.Drawing.Size(80, 21)
        Me.fecViaje.TabIndex = 6
        Me.fecViaje.Value = New Date(2014, 11, 14, 0, 0, 0, 0)
        '
        'UltraLabel36
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Appearance146.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance146
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel36.Location = New System.Drawing.Point(8, 121)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel36.TabIndex = 20
        Me.UltraLabel36.Text = "R. Escala:"
        '
        'txtViajeEscala
        '
        Me.txtViajeEscala.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeEscala.Location = New System.Drawing.Point(66, 117)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(260, 21)
        Me.txtViajeEscala.TabIndex = 21
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViaje.Location = New System.Drawing.Point(8, 25)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(21, 21)
        Me.txtIdViaje.TabIndex = 2
        Me.txtIdViaje.Visible = False
        '
        'txtViajeCopiloto
        '
        Me.txtViajeCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCopiloto.Location = New System.Drawing.Point(66, 163)
        Me.txtViajeCopiloto.Name = "txtViajeCopiloto"
        Me.txtViajeCopiloto.ReadOnly = True
        Me.txtViajeCopiloto.Size = New System.Drawing.Size(260, 21)
        Me.txtViajeCopiloto.TabIndex = 1
        '
        'UltraLabel37
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Appearance147.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance147
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel37.Location = New System.Drawing.Point(14, 167)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel37.TabIndex = 0
        Me.UltraLabel37.Text = "CoPiloto:"
        '
        'UltraLabel38
        '
        Appearance148.BackColor = System.Drawing.Color.Transparent
        Appearance148.ForeColor = System.Drawing.Color.Navy
        Appearance148.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance148
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel38.Location = New System.Drawing.Point(4, 98)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel38.TabIndex = 18
        Me.UltraLabel38.Text = "R. Destino:"
        '
        'txtViajeDestino
        '
        Me.txtViajeDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeDestino.Location = New System.Drawing.Point(66, 94)
        Me.txtViajeDestino.Name = "txtViajeDestino"
        Me.txtViajeDestino.ReadOnly = True
        Me.txtViajeDestino.Size = New System.Drawing.Size(260, 21)
        Me.txtViajeDestino.TabIndex = 19
        '
        'UltraLabel40
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Appearance149.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance149
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel40.Location = New System.Drawing.Point(30, 29)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel40.TabIndex = 3
        Me.UltraLabel40.Text = "Viaje:"
        '
        'UltraLabel42
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel42.Appearance = Appearance150
        Me.UltraLabel42.AutoSize = True
        Me.UltraLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel42.Location = New System.Drawing.Point(197, 29)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel42.TabIndex = 11
        Me.UltraLabel42.Text = "Carreta:"
        '
        'txtCodigoViaje
        '
        Appearance151.BorderColor = System.Drawing.Color.Cyan
        Me.txtCodigoViaje.Appearance = Appearance151
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoViaje.Location = New System.Drawing.Point(66, 25)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoViaje.TabIndex = 7
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeCarreta.Location = New System.Drawing.Point(245, 25)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(80, 21)
        Me.txtViajeCarreta.TabIndex = 12
        '
        'UltraLabel43
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Appearance152.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance152
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel43.Location = New System.Drawing.Point(3, 6)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel43.TabIndex = 0
        Me.UltraLabel43.Text = "Operacion:"
        '
        'UltraLabel44
        '
        Appearance153.BackColor = System.Drawing.Color.Transparent
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Appearance153.TextVAlignAsString = "Middle"
        Me.UltraLabel44.Appearance = Appearance153
        Me.UltraLabel44.AutoSize = True
        Me.UltraLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel44.Location = New System.Drawing.Point(203, 6)
        Me.UltraLabel44.Name = "UltraLabel44"
        Me.UltraLabel44.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel44.TabIndex = 9
        Me.UltraLabel44.Text = "Tracto:"
        '
        'txtCodigoOperacion
        '
        Me.txtCodigoOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(66, 2)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 21)
        Me.txtCodigoOperacion.TabIndex = 8
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeTracto.Location = New System.Drawing.Point(245, 2)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(80, 21)
        Me.txtViajeTracto.TabIndex = 10
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajePiloto.Location = New System.Drawing.Point(66, 140)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(260, 21)
        Me.txtViajePiloto.TabIndex = 23
        '
        'UltraLabel45
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Appearance154.TextVAlignAsString = "Middle"
        Me.UltraLabel45.Appearance = Appearance154
        Me.UltraLabel45.AutoSize = True
        Me.UltraLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel45.Location = New System.Drawing.Point(8, 75)
        Me.UltraLabel45.Name = "UltraLabel45"
        Me.UltraLabel45.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel45.TabIndex = 16
        Me.UltraLabel45.Text = "R. Origen:"
        '
        'UltraLabel46
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Appearance155.TextVAlignAsString = "Middle"
        Me.UltraLabel46.Appearance = Appearance155
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel46.Location = New System.Drawing.Point(27, 144)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel46.TabIndex = 22
        Me.UltraLabel46.Text = "Piloto:"
        '
        'txtViajeOrigen
        '
        Me.txtViajeOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViajeOrigen.Location = New System.Drawing.Point(66, 71)
        Me.txtViajeOrigen.Name = "txtViajeOrigen"
        Me.txtViajeOrigen.ReadOnly = True
        Me.txtViajeOrigen.Size = New System.Drawing.Size(260, 21)
        Me.txtViajeOrigen.TabIndex = 17
        '
        'txtIdSeguimiento
        '
        Me.txtIdSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSeguimiento.Location = New System.Drawing.Point(179, 25)
        Me.txtIdSeguimiento.Name = "txtIdSeguimiento"
        Me.txtIdSeguimiento.ReadOnly = True
        Me.txtIdSeguimiento.Size = New System.Drawing.Size(21, 21)
        Me.txtIdSeguimiento.TabIndex = 14
        Me.txtIdSeguimiento.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacion.Location = New System.Drawing.Point(179, 2)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacion.TabIndex = 13
        Me.txtIdOperacion.Visible = False
        '
        'txtIdOperacionDetalle
        '
        Me.txtIdOperacionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionDetalle.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacionDetalle.Location = New System.Drawing.Point(150, 48)
        Me.txtIdOperacionDetalle.Name = "txtIdOperacionDetalle"
        Me.txtIdOperacionDetalle.ReadOnly = True
        Me.txtIdOperacionDetalle.Size = New System.Drawing.Size(21, 21)
        Me.txtIdOperacionDetalle.TabIndex = 15
        Me.txtIdOperacionDetalle.Visible = False
        '
        'tcIncidencia
        '
        Me.tcIncidencia.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcIncidencia.Controls.Add(Me.UltraTabPageControl7)
        Me.tcIncidencia.Controls.Add(Me.utpDetalle)
        Me.tcIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcIncidencia.Location = New System.Drawing.Point(0, 0)
        Me.tcIncidencia.Name = "tcIncidencia"
        Me.tcIncidencia.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcIncidencia.Size = New System.Drawing.Size(1246, 551)
        Me.tcIncidencia.TabIndex = 3
        UltraTab11.Key = "Lista"
        UltraTab11.TabPage = Me.UltraTabPageControl7
        UltraTab11.Text = "Lista"
        UltraTab12.Key = "Mantenimiento"
        UltraTab12.TabPage = Me.utpDetalle
        UltraTab12.Text = "Mantenimiento"
        Me.tcIncidencia.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab11, UltraTab12})
        Me.tcIncidencia.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1244, 528)
        '
        'frm_RegistroEventosViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 551)
        Me.Controls.Add(Me.tcIncidencia)
        Me.Name = "frm_RegistroEventosViaje"
        Me.Text = "Registro Eventos Viajes"
        CType(Me.cboLugarIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarRobo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griListaIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griListaCerrarIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAreaResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        Me.UltraGroupBox8.PerformLayout()
        CType(Me.cboAreaBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.griListaAlarmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtObservacionAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaLugarAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalleAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAlarma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.griListaAccidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtObservacionAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasAccidenteAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperadorAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugarAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaLugarAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalleAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.griListaIncidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.txtObservacionIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasIncidentesAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperadorIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasIncidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaLugarIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalleIncidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.griListaRobos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdRobo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtObservacionRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreaRoboAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griAreasRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperadorRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenciaLugarRobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalleRobo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrTotalAccidentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTotalAccidentes.ResumeLayout(False)
        CType(Me.tabListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListado.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.ColorGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFinalizadoArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFinalizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.cboEventoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.fichaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fichaDetalle.ResumeLayout(False)
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.PerformLayout()
        CType(Me.cboPilotoTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCopiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajePiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtViajeOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcIncidencia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcIncidencia As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalAccidentes As ISL.Controles.Agrupacion
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents exgruViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblPilotoGRT As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboPilotoTercero As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboActividadNegocio As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecViaje As ISL.Controles.Fecha
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeEscala As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCopiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeDestino As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoViaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeCarreta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel44 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajeTracto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtViajePiloto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel45 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtViajeOrigen As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdSeguimiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtIdOperacionDetalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents fichaDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griListaAlarmas As ISL.Controles.Grilla
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboLugarAlarma As ISL.Controles.Combo
    Friend WithEvents fecAlarma As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboOperador As ISL.Controles.Combo
    Friend WithEvents txtReferenciaLugarAlarma As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAgregarAlarma As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtDetalleAlarma As ISL.Controles.Texto
    Friend WithEvents cboTipoAlarma As ISL.Controles.Combo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents hAlarma As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboTipoAccidente As ISL.Controles.Combo
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents fecDosajeAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDenunciaAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboLugarAccidente As ISL.Controles.Combo
    Friend WithEvents hDenunciaAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents hDosajeAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents chkDosajeAccidente As System.Windows.Forms.CheckBox
    Friend WithEvents fecAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReferenciaLugarAccidente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkDenunciaAccidente As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDetalleAccidente As ISL.Controles.Texto
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents hAccidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboLugarIncidente As ISL.Controles.Combo
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents fecIncidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReferenciaLugarIncidente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDetalleIncidente As ISL.Controles.Texto
    Friend WithEvents hIncidente As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboLugarRobo As ISL.Controles.Combo
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents fecDenunciaRobo As System.Windows.Forms.DateTimePicker
    Friend WithEvents hDenunciaRobo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecRobo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReferenciaLugarRobo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkDenunciaRobo As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDetalleRobo As ISL.Controles.Texto
    Friend WithEvents hRobo As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents griListaIncidencia As ISL.Controles.Grilla
    Friend WithEvents ogdEventos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdAlarma As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdAccidente As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdArea As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdAreaResponsable As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnLimpiarAlarma As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboEstadoAlarma As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoAccidente As ISL.Controles.Combo
    Friend WithEvents griAreasAccidente As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboOperadorAccidente As ISL.Controles.Combo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoIncidente As ISL.Controles.Combo
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboOperadorIncidente As ISL.Controles.Combo
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTipoIncidente As ISL.Controles.Combo
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griAreasIncidentes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents griAreasRobo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboOperadorRobo As ISL.Controles.Combo
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoRobo As ISL.Controles.Combo
    Friend WithEvents cboTipoRobo As ISL.Controles.Combo
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdIncidente As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdRobo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griAreasAlarma As ISL.Controles.Grilla
    Friend WithEvents griAreasAccidenteAsignado As ISL.Controles.Grilla
    Friend WithEvents griAreasIncidentesAsignados As ISL.Controles.Grilla
    Friend WithEvents griAreaRoboAsignada As ISL.Controles.Grilla
    Friend WithEvents griAreas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griListaAccidentes As ISL.Controles.Grilla
    Friend WithEvents griListaIncidentes As ISL.Controles.Grilla
    Friend WithEvents griListaRobos As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboEventoBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ColorPendiente As ISL.Controles.Colores
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFinalizado As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacionAlarma As ISL.Controles.Texto
    Friend WithEvents btnLimpiarAccidente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarAccidente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtObservacionAccidente As ISL.Controles.Texto
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnLimpiarIncidente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarIncidente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtObservacionIncidente As ISL.Controles.Texto
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnLimpiarRobo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregarRobo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtObservacionRobo As ISL.Controles.Texto
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Private WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabListado As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaCerrarIncidencia As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboAreaBuscar As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ColorGenerado As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ColorFinalizadoArea As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
End Class
