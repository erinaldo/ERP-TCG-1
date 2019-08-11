<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegistroSeguimiento
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
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViaje")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAproxLlegada")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Select", 0, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoViaje")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaAproxLlegada")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEntrega")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUbicacion")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReferenciaLugar")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperador")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operador")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreEstado")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoViaje")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaAproxLlegada")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEntrega")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUbicacion")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ubicacion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReferenciaLugar")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperador")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operador")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreEstado")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oeViaje.Codigo")
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdSeguimientoMonitoreo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cbInd = New System.Windows.Forms.CheckBox()
        Me.griListaEnviarEmail = New ISL.Controles.Grilla(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnEnviarCorreo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaSeguimientoViaje = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaSeguimientoConductor = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaSeguimientoVehiculo = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrTotalAccidentes = New ISL.Controles.Agrupacion(Me.components)
        Me.tabListado = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.tabListar = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ColorATiempo = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorRetrasado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboClientes = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoBusqueda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.tcDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGuardarRapido = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.horEntregaVenta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecEntregaVenta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horEntrega = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecEntrega = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horAproxLlegada = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecAproxLlegada = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horSeguimiento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecSeguimiento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.horInicioDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horSalidaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecSalidaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecLlegadaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.horLlegadaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecTerminoDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horTerminoDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecInicioDescargaDestino = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.horCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horSalidaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecSalidaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecLlegadaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.horLlegadaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl = New Infragistics.Win.Misc.UltraLabel()
        Me.fecTerminoCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.horTerminoCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.fecCargaOrigen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstado = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboLugar = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboOperador = New ISL.Controles.Combo(Me.components)
        Me.txtReferencia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.exgruViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtMovil = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnValidar = New ISL.Controles.Boton(Me.components)
        Me.btnImportar = New ISL.Controles.Boton(Me.components)
        Me.gridImportar = New ISL.Controles.Grilla(Me.components)
        Me.ogdSeguimientoMonitoreoAux = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdSeguimientoMonitoreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griListaEnviarEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griListaSeguimientoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griListaSeguimientoConductor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaSeguimientoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ColorATiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRetrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.cboClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.horEntregaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEntregaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horAproxLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecAproxLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.horInicioDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horSalidaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecLlegadaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horLlegadaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecInicioDescargaDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.horCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horSalidaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSalidaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecLlegadaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horLlegadaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecCargaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.gridImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdSeguimientoMonitoreoAux, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griLista)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1233, 240)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn40.Header.VisiblePosition = 38
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.Fixed = True
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 100
        UltraGridColumn42.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn42.Header.Fixed = True
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn42.Width = 100
        UltraGridColumn43.Header.VisiblePosition = 3
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 100
        UltraGridColumn44.Header.Caption = "Viaje"
        UltraGridColumn44.Header.Fixed = True
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Width = 100
        UltraGridColumn45.Header.Caption = "F. Seguimiento"
        UltraGridColumn45.Header.VisiblePosition = 5
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn45.Width = 110
        UltraGridColumn46.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn46.Header.VisiblePosition = 6
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn46.Width = 110
        UltraGridColumn47.Header.Caption = "F. Entrega"
        UltraGridColumn47.Header.VisiblePosition = 7
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn47.Width = 110
        UltraGridColumn48.Header.VisiblePosition = 10
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.Width = 100
        UltraGridColumn49.Header.Caption = "Ubicación"
        UltraGridColumn49.Header.VisiblePosition = 11
        UltraGridColumn49.Width = 180
        UltraGridColumn50.Header.VisiblePosition = 20
        UltraGridColumn50.Width = 180
        UltraGridColumn51.Header.VisiblePosition = 17
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.Width = 100
        UltraGridColumn52.Header.VisiblePosition = 19
        UltraGridColumn52.Width = 110
        UltraGridColumn53.Header.VisiblePosition = 23
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn53.Width = 110
        UltraGridColumn54.Header.VisiblePosition = 22
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.Width = 100
        UltraGridColumn55.Header.VisiblePosition = 37
        UltraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn55.Width = 110
        UltraGridColumn56.Header.VisiblePosition = 24
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.Width = 100
        UltraGridColumn57.Header.VisiblePosition = 21
        UltraGridColumn57.Width = 180
        UltraGridColumn58.Header.VisiblePosition = 16
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.Width = 100
        UltraGridColumn59.Header.VisiblePosition = 36
        UltraGridColumn59.Width = 180
        UltraGridColumn60.Header.VisiblePosition = 9
        UltraGridColumn60.Width = 180
        UltraGridColumn61.Header.VisiblePosition = 13
        UltraGridColumn61.Width = 180
        UltraGridColumn62.Header.VisiblePosition = 15
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.Width = 180
        UltraGridColumn63.Header.VisiblePosition = 27
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.Width = 100
        UltraGridColumn64.Header.VisiblePosition = 28
        UltraGridColumn64.Width = 180
        UltraGridColumn65.Header.VisiblePosition = 32
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.Width = 100
        UltraGridColumn66.Header.VisiblePosition = 33
        UltraGridColumn66.Width = 80
        UltraGridColumn67.Header.VisiblePosition = 29
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.Width = 100
        UltraGridColumn68.Header.VisiblePosition = 30
        UltraGridColumn68.Width = 180
        UltraGridColumn69.Header.VisiblePosition = 31
        UltraGridColumn69.Width = 80
        UltraGridColumn70.Header.VisiblePosition = 34
        UltraGridColumn70.Width = 80
        UltraGridColumn71.Header.VisiblePosition = 25
        UltraGridColumn71.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn71.Width = 110
        UltraGridColumn72.Header.VisiblePosition = 35
        UltraGridColumn72.Width = 80
        UltraGridColumn73.Header.VisiblePosition = 26
        UltraGridColumn73.Width = 180
        UltraGridColumn74.Header.VisiblePosition = 8
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.Width = 100
        UltraGridColumn75.Header.VisiblePosition = 12
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Width = 100
        UltraGridColumn76.Header.VisiblePosition = 14
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.Width = 100
        UltraGridColumn77.Header.Caption = "Estado"
        UltraGridColumn77.Header.VisiblePosition = 18
        UltraGridColumn77.Width = 110
        UltraGridColumn78.Header.Caption = "F. Salida Origen"
        UltraGridColumn78.Header.VisiblePosition = 4
        UltraGridColumn78.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn78.Width = 110
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1233, 240)
        Me.griLista.TabIndex = 3
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarCorreoToolStripMenuItem, Me.ImportarDatosToolStripMenuItem})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(141, 48)
        '
        'EnviarCorreoToolStripMenuItem
        '
        Me.EnviarCorreoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.send_email
        Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
        Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EnviarCorreoToolStripMenuItem.Text = "Enviar Correo"
        '
        'ImportarDatosToolStripMenuItem
        '
        Me.ImportarDatosToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ImportarDatosToolStripMenuItem.Name = "ImportarDatosToolStripMenuItem"
        Me.ImportarDatosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ImportarDatosToolStripMenuItem.Text = "‎ImportarDatos"
        '
        'ogdSeguimientoMonitoreo
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn14.DataType = GetType(Date)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Date)
        UltraDataColumn39.DataType = GetType(Date)
        Me.ogdSeguimientoMonitoreo.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.cbInd)
        Me.UltraTabPageControl5.Controls.Add(Me.griListaEnviarEmail)
        Me.UltraTabPageControl5.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1233, 240)
        '
        'cbInd
        '
        Me.cbInd.AutoSize = True
        Me.cbInd.BackColor = System.Drawing.Color.Transparent
        Me.cbInd.Location = New System.Drawing.Point(41, 74)
        Me.cbInd.Name = "cbInd"
        Me.cbInd.Size = New System.Drawing.Size(15, 14)
        Me.cbInd.TabIndex = 39
        Me.cbInd.UseVisualStyleBackColor = False
        '
        'griListaEnviarEmail
        '
        Me.griListaEnviarEmail.ContextMenuStrip = Me.Menu
        Me.griListaEnviarEmail.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn79.Header.Caption = ""
        UltraGridColumn79.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn79.Header.Fixed = True
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.Width = 40
        UltraGridColumn80.Header.Fixed = True
        UltraGridColumn80.Header.VisiblePosition = 2
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.Width = 100
        UltraGridColumn81.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn81.Header.Fixed = True
        UltraGridColumn81.Header.VisiblePosition = 3
        UltraGridColumn81.Width = 100
        UltraGridColumn82.Header.VisiblePosition = 5
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 100
        UltraGridColumn83.Header.Caption = "Viaje"
        UltraGridColumn83.Header.Fixed = True
        UltraGridColumn83.Header.VisiblePosition = 4
        UltraGridColumn83.Width = 100
        UltraGridColumn84.Header.Caption = "F. Seguimiento"
        UltraGridColumn84.Header.VisiblePosition = 7
        UltraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn84.Width = 110
        UltraGridColumn85.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn85.Header.VisiblePosition = 8
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn85.Width = 110
        UltraGridColumn86.Header.Caption = "F. Entrega"
        UltraGridColumn86.Header.VisiblePosition = 9
        UltraGridColumn86.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn86.Width = 110
        UltraGridColumn87.Header.VisiblePosition = 12
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.Width = 100
        UltraGridColumn88.Header.Caption = "Ubicación"
        UltraGridColumn88.Header.VisiblePosition = 13
        UltraGridColumn88.Width = 180
        UltraGridColumn89.Header.VisiblePosition = 22
        UltraGridColumn89.Width = 180
        UltraGridColumn90.Header.VisiblePosition = 19
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Width = 100
        UltraGridColumn91.Header.VisiblePosition = 21
        UltraGridColumn91.Width = 110
        UltraGridColumn92.Header.VisiblePosition = 25
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn92.Width = 110
        UltraGridColumn93.Header.VisiblePosition = 24
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.Width = 100
        UltraGridColumn94.Header.VisiblePosition = 27
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn94.Width = 110
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.Width = 100
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.Width = 180
        UltraGridColumn97.Header.VisiblePosition = 18
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.Width = 100
        UltraGridColumn98.Header.VisiblePosition = 39
        UltraGridColumn98.Width = 180
        UltraGridColumn99.Header.VisiblePosition = 11
        UltraGridColumn99.Width = 180
        UltraGridColumn100.Header.VisiblePosition = 15
        UltraGridColumn100.Width = 180
        UltraGridColumn101.Header.VisiblePosition = 17
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Width = 180
        UltraGridColumn102.Header.VisiblePosition = 30
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Width = 100
        UltraGridColumn103.Header.VisiblePosition = 31
        UltraGridColumn103.Width = 180
        UltraGridColumn104.Header.VisiblePosition = 35
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.Width = 100
        UltraGridColumn105.Header.VisiblePosition = 36
        UltraGridColumn105.Width = 80
        UltraGridColumn106.Header.VisiblePosition = 32
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.Width = 100
        UltraGridColumn107.Header.VisiblePosition = 33
        UltraGridColumn107.Width = 180
        UltraGridColumn108.Header.VisiblePosition = 34
        UltraGridColumn108.Width = 80
        UltraGridColumn109.Header.VisiblePosition = 37
        UltraGridColumn109.Width = 80
        UltraGridColumn110.Header.VisiblePosition = 28
        UltraGridColumn110.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn110.Width = 110
        UltraGridColumn111.Header.VisiblePosition = 38
        UltraGridColumn111.Width = 80
        UltraGridColumn112.Header.VisiblePosition = 29
        UltraGridColumn112.Width = 180
        UltraGridColumn113.Header.VisiblePosition = 10
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.Width = 100
        UltraGridColumn114.Header.VisiblePosition = 14
        UltraGridColumn114.Hidden = True
        UltraGridColumn114.Width = 100
        UltraGridColumn115.Header.VisiblePosition = 16
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.Width = 100
        UltraGridColumn116.Header.Caption = "Estado"
        UltraGridColumn116.Header.VisiblePosition = 20
        UltraGridColumn116.Width = 110
        UltraGridColumn117.Header.Caption = "F. Salida Origen"
        UltraGridColumn117.Header.VisiblePosition = 6
        UltraGridColumn117.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn117.Width = 110
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn118.DataType = GetType(Boolean)
        UltraGridColumn118.Header.Caption = ""
        UltraGridColumn118.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn118.Header.Fixed = True
        UltraGridColumn118.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118})
        Me.griListaEnviarEmail.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaEnviarEmail.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaEnviarEmail.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaEnviarEmail.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaEnviarEmail.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaEnviarEmail.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaEnviarEmail.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaEnviarEmail.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaEnviarEmail.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaEnviarEmail.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaEnviarEmail.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaEnviarEmail.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListaEnviarEmail.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaEnviarEmail.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaEnviarEmail.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaEnviarEmail.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaEnviarEmail.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaEnviarEmail.DisplayLayout.UseFixedHeaders = True
        Me.griListaEnviarEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaEnviarEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaEnviarEmail.Location = New System.Drawing.Point(0, 54)
        Me.griListaEnviarEmail.Name = "griListaEnviarEmail"
        Me.griListaEnviarEmail.Size = New System.Drawing.Size(1233, 186)
        Me.griListaEnviarEmail.TabIndex = 23
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(703, 129)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 22
        Me.ugb_Espera.Visible = False
        '
        'UltraGroupBox8
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox8.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox8.Controls.Add(Me.btnEnviarCorreo)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1233, 54)
        Me.UltraGroupBox8.TabIndex = 5
        Me.UltraGroupBox8.Text = "Filtro"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEnviarCorreo
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.btnEnviarCorreo.Appearance = Appearance2
        Me.btnEnviarCorreo.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.btnEnviarCorreo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCorreo.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnEnviarCorreo.Location = New System.Drawing.Point(10, 19)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        Me.btnEnviarCorreo.Size = New System.Drawing.Size(78, 32)
        Me.btnEnviarCorreo.TabIndex = 2
        Me.btnEnviarCorreo.Text = "Enviar Correo"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griListaSeguimientoViaje)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(860, 114)
        '
        'griListaSeguimientoViaje
        '
        Me.griListaSeguimientoViaje.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn236.Header.VisiblePosition = 38
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.Fixed = True
        UltraGridColumn237.Header.VisiblePosition = 0
        UltraGridColumn237.Hidden = True
        UltraGridColumn237.Width = 100
        UltraGridColumn238.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn238.Header.Fixed = True
        UltraGridColumn238.Header.VisiblePosition = 1
        UltraGridColumn238.Width = 100
        UltraGridColumn239.Header.VisiblePosition = 3
        UltraGridColumn239.Hidden = True
        UltraGridColumn239.Width = 100
        UltraGridColumn240.Header.Caption = "Viaje"
        UltraGridColumn240.Header.Fixed = True
        UltraGridColumn240.Header.VisiblePosition = 2
        UltraGridColumn240.Width = 100
        UltraGridColumn241.Header.Caption = "F. Seguimiento"
        UltraGridColumn241.Header.VisiblePosition = 5
        UltraGridColumn241.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn241.Width = 110
        UltraGridColumn242.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn242.Header.VisiblePosition = 6
        UltraGridColumn242.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn242.Width = 110
        UltraGridColumn243.Header.Caption = "F. Entrega"
        UltraGridColumn243.Header.VisiblePosition = 7
        UltraGridColumn243.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn243.Width = 110
        UltraGridColumn244.Header.VisiblePosition = 10
        UltraGridColumn244.Hidden = True
        UltraGridColumn244.Width = 100
        UltraGridColumn245.Header.Caption = "Ubicación"
        UltraGridColumn245.Header.VisiblePosition = 11
        UltraGridColumn245.Width = 180
        UltraGridColumn246.Header.VisiblePosition = 20
        UltraGridColumn246.Width = 180
        UltraGridColumn247.Header.VisiblePosition = 17
        UltraGridColumn247.Hidden = True
        UltraGridColumn247.Width = 100
        UltraGridColumn248.Header.VisiblePosition = 19
        UltraGridColumn248.Width = 110
        UltraGridColumn249.Header.VisiblePosition = 36
        UltraGridColumn249.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn249.Width = 110
        UltraGridColumn250.Header.VisiblePosition = 22
        UltraGridColumn250.Hidden = True
        UltraGridColumn250.Width = 100
        UltraGridColumn251.Header.VisiblePosition = 37
        UltraGridColumn251.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn251.Width = 110
        UltraGridColumn252.Header.VisiblePosition = 23
        UltraGridColumn252.Hidden = True
        UltraGridColumn252.Width = 100
        UltraGridColumn253.Header.VisiblePosition = 21
        UltraGridColumn253.Width = 180
        UltraGridColumn254.Header.VisiblePosition = 16
        UltraGridColumn254.Hidden = True
        UltraGridColumn254.Width = 100
        UltraGridColumn255.Header.VisiblePosition = 35
        UltraGridColumn255.Width = 180
        UltraGridColumn256.Header.VisiblePosition = 9
        UltraGridColumn256.Width = 180
        UltraGridColumn257.Header.VisiblePosition = 13
        UltraGridColumn257.Width = 180
        UltraGridColumn258.Header.VisiblePosition = 15
        UltraGridColumn258.Hidden = True
        UltraGridColumn258.Width = 180
        UltraGridColumn259.Header.VisiblePosition = 26
        UltraGridColumn259.Hidden = True
        UltraGridColumn259.Width = 100
        UltraGridColumn260.Header.VisiblePosition = 27
        UltraGridColumn260.Width = 180
        UltraGridColumn261.Header.VisiblePosition = 31
        UltraGridColumn261.Hidden = True
        UltraGridColumn261.Width = 100
        UltraGridColumn262.Header.VisiblePosition = 32
        UltraGridColumn262.Width = 80
        UltraGridColumn263.Header.VisiblePosition = 28
        UltraGridColumn263.Hidden = True
        UltraGridColumn263.Width = 100
        UltraGridColumn264.Header.VisiblePosition = 29
        UltraGridColumn264.Width = 180
        UltraGridColumn265.Header.VisiblePosition = 30
        UltraGridColumn265.Width = 80
        UltraGridColumn266.Header.VisiblePosition = 33
        UltraGridColumn266.Width = 80
        UltraGridColumn267.Header.VisiblePosition = 24
        UltraGridColumn267.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn267.Width = 110
        UltraGridColumn268.Header.VisiblePosition = 34
        UltraGridColumn268.Width = 80
        UltraGridColumn269.Header.VisiblePosition = 25
        UltraGridColumn269.Width = 180
        UltraGridColumn270.Header.VisiblePosition = 8
        UltraGridColumn270.Hidden = True
        UltraGridColumn270.Width = 100
        UltraGridColumn271.Header.VisiblePosition = 12
        UltraGridColumn271.Hidden = True
        UltraGridColumn271.Width = 100
        UltraGridColumn272.Header.VisiblePosition = 14
        UltraGridColumn272.Hidden = True
        UltraGridColumn272.Width = 100
        UltraGridColumn273.Header.Caption = "Estado"
        UltraGridColumn273.Header.VisiblePosition = 18
        UltraGridColumn273.Width = 110
        UltraGridColumn274.Header.Caption = "F. Salida Origen"
        UltraGridColumn274.Header.VisiblePosition = 4
        UltraGridColumn274.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn274.Width = 110
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274})
        Me.griListaSeguimientoViaje.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListaSeguimientoViaje.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaSeguimientoViaje.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaSeguimientoViaje.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaSeguimientoViaje.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSeguimientoViaje.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaSeguimientoViaje.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSeguimientoViaje.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSeguimientoViaje.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaSeguimientoViaje.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSeguimientoViaje.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaSeguimientoViaje.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSeguimientoViaje.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSeguimientoViaje.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaSeguimientoViaje.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaSeguimientoViaje.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaSeguimientoViaje.DisplayLayout.UseFixedHeaders = True
        Me.griListaSeguimientoViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSeguimientoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaSeguimientoViaje.Location = New System.Drawing.Point(0, 0)
        Me.griListaSeguimientoViaje.Name = "griListaSeguimientoViaje"
        Me.griListaSeguimientoViaje.Size = New System.Drawing.Size(860, 114)
        Me.griListaSeguimientoViaje.TabIndex = 30
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griListaSeguimientoConductor)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(860, 114)
        '
        'griListaSeguimientoConductor
        '
        Me.griListaSeguimientoConductor.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn275.Header.VisiblePosition = 38
        UltraGridColumn275.Hidden = True
        UltraGridColumn276.Header.Fixed = True
        UltraGridColumn276.Header.VisiblePosition = 0
        UltraGridColumn276.Hidden = True
        UltraGridColumn276.Width = 100
        UltraGridColumn277.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn277.Header.Fixed = True
        UltraGridColumn277.Header.VisiblePosition = 1
        UltraGridColumn277.Width = 100
        UltraGridColumn278.Header.VisiblePosition = 3
        UltraGridColumn278.Hidden = True
        UltraGridColumn278.Width = 100
        UltraGridColumn279.Header.Caption = "Viaje"
        UltraGridColumn279.Header.Fixed = True
        UltraGridColumn279.Header.VisiblePosition = 2
        UltraGridColumn279.Width = 100
        UltraGridColumn280.Header.Caption = "F. Seguimiento"
        UltraGridColumn280.Header.VisiblePosition = 5
        UltraGridColumn280.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn280.Width = 110
        UltraGridColumn281.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn281.Header.VisiblePosition = 6
        UltraGridColumn281.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn281.Width = 110
        UltraGridColumn282.Header.Caption = "F. Entrega"
        UltraGridColumn282.Header.VisiblePosition = 7
        UltraGridColumn282.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn282.Width = 110
        UltraGridColumn283.Header.VisiblePosition = 10
        UltraGridColumn283.Hidden = True
        UltraGridColumn283.Width = 100
        UltraGridColumn284.Header.Caption = "Ubicación"
        UltraGridColumn284.Header.VisiblePosition = 11
        UltraGridColumn284.Width = 180
        UltraGridColumn285.Header.VisiblePosition = 20
        UltraGridColumn285.Width = 180
        UltraGridColumn286.Header.VisiblePosition = 17
        UltraGridColumn286.Hidden = True
        UltraGridColumn286.Width = 100
        UltraGridColumn287.Header.VisiblePosition = 19
        UltraGridColumn287.Width = 110
        UltraGridColumn288.Header.VisiblePosition = 36
        UltraGridColumn288.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn288.Width = 110
        UltraGridColumn289.Header.VisiblePosition = 22
        UltraGridColumn289.Hidden = True
        UltraGridColumn289.Width = 100
        UltraGridColumn290.Header.VisiblePosition = 37
        UltraGridColumn290.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn290.Width = 110
        UltraGridColumn291.Header.VisiblePosition = 23
        UltraGridColumn291.Hidden = True
        UltraGridColumn291.Width = 100
        UltraGridColumn292.Header.VisiblePosition = 21
        UltraGridColumn292.Width = 180
        UltraGridColumn293.Header.VisiblePosition = 16
        UltraGridColumn293.Hidden = True
        UltraGridColumn293.Width = 100
        UltraGridColumn294.Header.VisiblePosition = 35
        UltraGridColumn294.Width = 180
        UltraGridColumn295.Header.VisiblePosition = 9
        UltraGridColumn295.Width = 180
        UltraGridColumn296.Header.VisiblePosition = 13
        UltraGridColumn296.Width = 180
        UltraGridColumn297.Header.VisiblePosition = 15
        UltraGridColumn297.Hidden = True
        UltraGridColumn297.Width = 180
        UltraGridColumn298.Header.VisiblePosition = 26
        UltraGridColumn298.Hidden = True
        UltraGridColumn298.Width = 100
        UltraGridColumn299.Header.VisiblePosition = 27
        UltraGridColumn299.Width = 180
        UltraGridColumn300.Header.VisiblePosition = 31
        UltraGridColumn300.Hidden = True
        UltraGridColumn300.Width = 100
        UltraGridColumn301.Header.VisiblePosition = 32
        UltraGridColumn301.Width = 80
        UltraGridColumn302.Header.VisiblePosition = 28
        UltraGridColumn302.Hidden = True
        UltraGridColumn302.Width = 100
        UltraGridColumn303.Header.VisiblePosition = 29
        UltraGridColumn303.Width = 180
        UltraGridColumn304.Header.VisiblePosition = 30
        UltraGridColumn304.Width = 80
        UltraGridColumn305.Header.VisiblePosition = 33
        UltraGridColumn305.Width = 80
        UltraGridColumn306.Header.VisiblePosition = 24
        UltraGridColumn306.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn306.Width = 110
        UltraGridColumn307.Header.VisiblePosition = 34
        UltraGridColumn307.Width = 80
        UltraGridColumn308.Header.VisiblePosition = 25
        UltraGridColumn308.Width = 180
        UltraGridColumn309.Header.VisiblePosition = 8
        UltraGridColumn309.Hidden = True
        UltraGridColumn309.Width = 100
        UltraGridColumn310.Header.VisiblePosition = 12
        UltraGridColumn310.Hidden = True
        UltraGridColumn310.Width = 100
        UltraGridColumn311.Header.VisiblePosition = 14
        UltraGridColumn311.Hidden = True
        UltraGridColumn311.Width = 100
        UltraGridColumn312.Header.Caption = "Estado"
        UltraGridColumn312.Header.VisiblePosition = 18
        UltraGridColumn312.Width = 110
        UltraGridColumn313.Header.Caption = "F. Salida Origen"
        UltraGridColumn313.Header.VisiblePosition = 4
        UltraGridColumn313.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn313.Width = 110
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313})
        Me.griListaSeguimientoConductor.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griListaSeguimientoConductor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaSeguimientoConductor.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaSeguimientoConductor.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaSeguimientoConductor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSeguimientoConductor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaSeguimientoConductor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSeguimientoConductor.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSeguimientoConductor.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaSeguimientoConductor.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSeguimientoConductor.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaSeguimientoConductor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSeguimientoConductor.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSeguimientoConductor.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaSeguimientoConductor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaSeguimientoConductor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaSeguimientoConductor.DisplayLayout.UseFixedHeaders = True
        Me.griListaSeguimientoConductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSeguimientoConductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaSeguimientoConductor.Location = New System.Drawing.Point(0, 0)
        Me.griListaSeguimientoConductor.Name = "griListaSeguimientoConductor"
        Me.griListaSeguimientoConductor.Size = New System.Drawing.Size(860, 114)
        Me.griListaSeguimientoConductor.TabIndex = 31
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaSeguimientoVehiculo)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(860, 114)
        '
        'griListaSeguimientoVehiculo
        '
        Me.griListaSeguimientoVehiculo.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn314.Header.VisiblePosition = 38
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.Fixed = True
        UltraGridColumn315.Header.VisiblePosition = 0
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.Width = 100
        UltraGridColumn316.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn316.Header.Fixed = True
        UltraGridColumn316.Header.VisiblePosition = 1
        UltraGridColumn316.Width = 100
        UltraGridColumn317.Header.VisiblePosition = 3
        UltraGridColumn317.Hidden = True
        UltraGridColumn317.Width = 100
        UltraGridColumn318.Header.Caption = "Viaje"
        UltraGridColumn318.Header.Fixed = True
        UltraGridColumn318.Header.VisiblePosition = 2
        UltraGridColumn318.Width = 100
        UltraGridColumn319.Header.Caption = "F. Seguimiento"
        UltraGridColumn319.Header.VisiblePosition = 5
        UltraGridColumn319.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn319.Width = 110
        UltraGridColumn320.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn320.Header.VisiblePosition = 6
        UltraGridColumn320.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn320.Width = 110
        UltraGridColumn321.Header.Caption = "F. Entrega"
        UltraGridColumn321.Header.VisiblePosition = 7
        UltraGridColumn321.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn321.Width = 110
        UltraGridColumn322.Header.VisiblePosition = 10
        UltraGridColumn322.Hidden = True
        UltraGridColumn322.Width = 100
        UltraGridColumn323.Header.Caption = "Ubicación"
        UltraGridColumn323.Header.VisiblePosition = 11
        UltraGridColumn323.Width = 180
        UltraGridColumn324.Header.VisiblePosition = 20
        UltraGridColumn324.Width = 180
        UltraGridColumn325.Header.VisiblePosition = 17
        UltraGridColumn325.Hidden = True
        UltraGridColumn325.Width = 100
        UltraGridColumn326.Header.VisiblePosition = 19
        UltraGridColumn326.Width = 110
        UltraGridColumn327.Header.VisiblePosition = 36
        UltraGridColumn327.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn327.Width = 110
        UltraGridColumn328.Header.VisiblePosition = 22
        UltraGridColumn328.Hidden = True
        UltraGridColumn328.Width = 100
        UltraGridColumn329.Header.VisiblePosition = 37
        UltraGridColumn329.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn329.Width = 110
        UltraGridColumn330.Header.VisiblePosition = 23
        UltraGridColumn330.Hidden = True
        UltraGridColumn330.Width = 100
        UltraGridColumn331.Header.VisiblePosition = 21
        UltraGridColumn331.Width = 180
        UltraGridColumn332.Header.VisiblePosition = 16
        UltraGridColumn332.Hidden = True
        UltraGridColumn332.Width = 100
        UltraGridColumn333.Header.VisiblePosition = 35
        UltraGridColumn333.Width = 180
        UltraGridColumn334.Header.VisiblePosition = 9
        UltraGridColumn334.Width = 180
        UltraGridColumn335.Header.VisiblePosition = 13
        UltraGridColumn335.Width = 180
        UltraGridColumn336.Header.VisiblePosition = 15
        UltraGridColumn336.Hidden = True
        UltraGridColumn336.Width = 180
        UltraGridColumn337.Header.VisiblePosition = 26
        UltraGridColumn337.Hidden = True
        UltraGridColumn337.Width = 100
        UltraGridColumn338.Header.VisiblePosition = 27
        UltraGridColumn338.Width = 180
        UltraGridColumn339.Header.VisiblePosition = 31
        UltraGridColumn339.Hidden = True
        UltraGridColumn339.Width = 100
        UltraGridColumn340.Header.VisiblePosition = 32
        UltraGridColumn340.Width = 80
        UltraGridColumn341.Header.VisiblePosition = 28
        UltraGridColumn341.Hidden = True
        UltraGridColumn341.Width = 100
        UltraGridColumn342.Header.VisiblePosition = 29
        UltraGridColumn342.Width = 180
        UltraGridColumn343.Header.VisiblePosition = 30
        UltraGridColumn343.Width = 80
        UltraGridColumn344.Header.VisiblePosition = 33
        UltraGridColumn344.Width = 80
        UltraGridColumn345.Header.VisiblePosition = 24
        UltraGridColumn345.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn345.Width = 110
        UltraGridColumn346.Header.VisiblePosition = 34
        UltraGridColumn346.Width = 80
        UltraGridColumn347.Header.VisiblePosition = 25
        UltraGridColumn347.Width = 180
        UltraGridColumn348.Header.VisiblePosition = 8
        UltraGridColumn348.Hidden = True
        UltraGridColumn348.Width = 100
        UltraGridColumn349.Header.VisiblePosition = 12
        UltraGridColumn349.Hidden = True
        UltraGridColumn349.Width = 100
        UltraGridColumn350.Header.VisiblePosition = 14
        UltraGridColumn350.Hidden = True
        UltraGridColumn350.Width = 100
        UltraGridColumn351.Header.Caption = "Estado"
        UltraGridColumn351.Header.VisiblePosition = 18
        UltraGridColumn351.Width = 110
        UltraGridColumn352.Header.Caption = "F. Salida Origen"
        UltraGridColumn352.Header.VisiblePosition = 4
        UltraGridColumn352.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn352.Width = 110
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352})
        Me.griListaSeguimientoVehiculo.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griListaSeguimientoVehiculo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.griListaSeguimientoVehiculo.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaSeguimientoVehiculo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListaSeguimientoVehiculo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaSeguimientoVehiculo.DisplayLayout.UseFixedHeaders = True
        Me.griListaSeguimientoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSeguimientoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.griListaSeguimientoVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.griListaSeguimientoVehiculo.Name = "griListaSeguimientoVehiculo"
        Me.griListaSeguimientoVehiculo.Size = New System.Drawing.Size(860, 114)
        Me.griListaSeguimientoVehiculo.TabIndex = 31
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrTotalAccidentes)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1241, 353)
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
        Me.agrTotalAccidentes.Size = New System.Drawing.Size(1241, 353)
        Me.agrTotalAccidentes.TabIndex = 1
        Me.agrTotalAccidentes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tabListado
        '
        Me.tabListado.Controls.Add(Me.tabListar)
        Me.tabListado.Controls.Add(Me.UltraTabPageControl4)
        Me.tabListado.Controls.Add(Me.UltraTabPageControl5)
        Me.tabListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabListado.Location = New System.Drawing.Point(3, 87)
        Me.tabListado.Name = "tabListado"
        Me.tabListado.SharedControlsPage = Me.tabListar
        Me.tabListado.Size = New System.Drawing.Size(1235, 263)
        Me.tabListado.TabIndex = 23
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "General"
        UltraTab7.TabPage = Me.UltraTabPageControl5
        UltraTab7.Text = "EnviarEmail"
        Me.tabListado.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab7})
        Me.tabListado.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'tabListar
        '
        Me.tabListar.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabListar.Name = "tabListar"
        Me.tabListar.Size = New System.Drawing.Size(1233, 240)
        '
        'UltraExpandableGroupBox6
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance3
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1235, 84)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1235, 84)
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
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(1229, 61)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance4
        Me.UltraGroupBox3.Controls.Add(Me.ColorATiempo)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta28)
        Me.UltraGroupBox3.Controls.Add(Me.ColorRetrasado)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta24)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(611, 1)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(624, 60)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorATiempo
        '
        Me.ColorATiempo.Color = System.Drawing.Color.GreenYellow
        Me.ColorATiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorATiempo.Location = New System.Drawing.Point(72, 11)
        Me.ColorATiempo.Name = "ColorATiempo"
        Me.ColorATiempo.Size = New System.Drawing.Size(44, 19)
        Me.ColorATiempo.TabIndex = 11
        Me.ColorATiempo.Text = "GreenYellow"
        '
        'Etiqueta28
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance5
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(9, 38)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta28.TabIndex = 12
        Me.Etiqueta28.Text = "Retrasado:"
        '
        'ColorRetrasado
        '
        Me.ColorRetrasado.Color = System.Drawing.Color.LightBlue
        Me.ColorRetrasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorRetrasado.Location = New System.Drawing.Point(72, 35)
        Me.ColorRetrasado.Name = "ColorRetrasado"
        Me.ColorRetrasado.Size = New System.Drawing.Size(44, 19)
        Me.ColorRetrasado.TabIndex = 13
        Me.ColorRetrasado.Text = "LightBlue"
        '
        'Etiqueta24
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance6
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(13, 14)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(56, 14)
        Me.Etiqueta24.TabIndex = 10
        Me.Etiqueta24.Text = "A Tiempo:"
        '
        'UltraGroupBox13
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance7
        Me.UltraGroupBox13.Controls.Add(Me.cboClientes)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox13.Controls.Add(Me.cboEstadoBusqueda)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(-1, 1)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(606, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboClientes
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.cboClientes.Appearance = Appearance8
        Me.cboClientes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClientes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientes.ForeColor = System.Drawing.Color.Black
        Me.cboClientes.Location = New System.Drawing.Point(192, 32)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(409, 21)
        Me.cboClientes.TabIndex = 18
        Me.cboClientes.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance9
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(148, 34)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel16.TabIndex = 17
        Me.UltraLabel16.Text = "Cliente:"
        '
        'cboEstadoBusqueda
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBusqueda.Appearance = Appearance10
        Me.cboEstadoBusqueda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoBusqueda.DisplayMember = "Login"
        Me.cboEstadoBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoBusqueda.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoBusqueda.Location = New System.Drawing.Point(192, 9)
        Me.cboEstadoBusqueda.Name = "cboEstadoBusqueda"
        Me.cboEstadoBusqueda.Size = New System.Drawing.Size(139, 21)
        Me.cboEstadoBusqueda.TabIndex = 4
        Me.cboEstadoBusqueda.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance11
        Me.UltraLabel62.AutoSize = True
        Me.UltraLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel62.Location = New System.Drawing.Point(144, 13)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel62.TabIndex = 3
        Me.UltraLabel62.Text = "Estado:"
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
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance12
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
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance13
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
        Me.utpDetalle.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.utpDetalle.Controls.Add(Me.exgruViaje)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1241, 353)
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance14
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(891, 353)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(350, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(891, 353)
        Me.UltraExpandableGroupBox1.TabIndex = 8
        Me.UltraExpandableGroupBox1.Text = "Datos Generales de la Alarma"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(868, 347)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraTabControl1)
        Me.UltraGroupBox1.Controls.Add(Me.Panel2)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(868, 347)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.tcDetalle)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(3, 207)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.tcDetalle
        Me.UltraTabControl1.Size = New System.Drawing.Size(862, 137)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab9.TabPage = Me.UltraTabPageControl1
        UltraTab9.Text = "Seg. Viaje"
        UltraTab10.TabPage = Me.UltraTabPageControl2
        UltraTab10.Text = "Seg. Conductor"
        UltraTab11.TabPage = Me.UltraTabPageControl3
        UltraTab11.Text = "Seg. Vehículo"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10, UltraTab11})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'tcDetalle
        '
        Me.tcDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.tcDetalle.Name = "tcDetalle"
        Me.tcDetalle.Size = New System.Drawing.Size(860, 114)
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnGuardarRapido)
        Me.Panel2.Controls.Add(Me.UltraLabel15)
        Me.Panel2.Controls.Add(Me.horEntregaVenta)
        Me.Panel2.Controls.Add(Me.fecEntregaVenta)
        Me.Panel2.Controls.Add(Me.horEntrega)
        Me.Panel2.Controls.Add(Me.fecEntrega)
        Me.Panel2.Controls.Add(Me.horAproxLlegada)
        Me.Panel2.Controls.Add(Me.fecAproxLlegada)
        Me.Panel2.Controls.Add(Me.horSeguimiento)
        Me.Panel2.Controls.Add(Me.fecSeguimiento)
        Me.Panel2.Controls.Add(Me.UltraGroupBox4)
        Me.Panel2.Controls.Add(Me.UltraGroupBox2)
        Me.Panel2.Controls.Add(Me.UltraLabel4)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.cboEstado)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.cboLugar)
        Me.Panel2.Controls.Add(Me.Etiqueta2)
        Me.Panel2.Controls.Add(Me.cboOperador)
        Me.Panel2.Controls.Add(Me.txtReferencia)
        Me.Panel2.Controls.Add(Me.UltraLabel5)
        Me.Panel2.Controls.Add(Me.UltraLabel14)
        Me.Panel2.Controls.Add(Me.txtGlosa)
        Me.Panel2.Controls.Add(Me.UltraLabel7)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 204)
        Me.Panel2.TabIndex = 0
        '
        'btnGuardarRapido
        '
        Appearance15.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.btnGuardarRapido.Appearance = Appearance15
        Me.btnGuardarRapido.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnGuardarRapido.Location = New System.Drawing.Point(255, 177)
        Me.btnGuardarRapido.Name = "btnGuardarRapido"
        Me.btnGuardarRapido.Size = New System.Drawing.Size(85, 25)
        Me.btnGuardarRapido.TabIndex = 85
        Me.btnGuardarRapido.Text = "Guardar"
        Me.btnGuardarRapido.Visible = False
        '
        'UltraLabel15
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance16
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(255, 93)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(100, 14)
        Me.UltraLabel15.TabIndex = 84
        Me.UltraLabel15.Text = "F. Pactada Cliente:"
        '
        'horEntregaVenta
        '
        Me.horEntregaVenta.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horEntregaVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horEntregaVenta.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horEntregaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horEntregaVenta.Location = New System.Drawing.Point(331, 110)
        Me.horEntregaVenta.MaskInput = "{LOC}hh:mm"
        Me.horEntregaVenta.Name = "horEntregaVenta"
        Me.horEntregaVenta.Nullable = False
        Me.horEntregaVenta.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horEntregaVenta.ReadOnly = True
        Me.horEntregaVenta.Size = New System.Drawing.Size(51, 20)
        Me.horEntregaVenta.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horEntregaVenta.TabIndex = 11
        Me.horEntregaVenta.Tag = ""
        Me.horEntregaVenta.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecEntregaVenta
        '
        Me.fecEntregaVenta.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecEntregaVenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEntregaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecEntregaVenta.Location = New System.Drawing.Point(255, 110)
        Me.fecEntregaVenta.MaskInput = ""
        Me.fecEntregaVenta.Name = "fecEntregaVenta"
        Me.fecEntregaVenta.ReadOnly = True
        Me.fecEntregaVenta.Size = New System.Drawing.Size(76, 20)
        Me.fecEntregaVenta.TabIndex = 10
        Me.fecEntregaVenta.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horEntrega
        '
        Me.horEntrega.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horEntrega.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horEntrega.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horEntrega.Location = New System.Drawing.Point(194, 112)
        Me.horEntrega.MaskInput = "{LOC}hh:mm"
        Me.horEntrega.Name = "horEntrega"
        Me.horEntrega.Nullable = False
        Me.horEntrega.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horEntrega.Size = New System.Drawing.Size(55, 20)
        Me.horEntrega.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horEntrega.TabIndex = 9
        Me.horEntrega.Tag = ""
        Me.horEntrega.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecEntrega
        '
        Me.fecEntrega.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecEntrega.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecEntrega.Location = New System.Drawing.Point(100, 112)
        Me.fecEntrega.MaskInput = ""
        Me.fecEntrega.Name = "fecEntrega"
        Me.fecEntrega.Size = New System.Drawing.Size(90, 20)
        Me.fecEntrega.TabIndex = 8
        Me.fecEntrega.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horAproxLlegada
        '
        Me.horAproxLlegada.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horAproxLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horAproxLlegada.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horAproxLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horAproxLlegada.Location = New System.Drawing.Point(194, 90)
        Me.horAproxLlegada.MaskInput = "{LOC}hh:mm"
        Me.horAproxLlegada.Name = "horAproxLlegada"
        Me.horAproxLlegada.Nullable = False
        Me.horAproxLlegada.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horAproxLlegada.Size = New System.Drawing.Size(55, 20)
        Me.horAproxLlegada.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horAproxLlegada.TabIndex = 7
        Me.horAproxLlegada.Tag = ""
        Me.horAproxLlegada.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecAproxLlegada
        '
        Me.fecAproxLlegada.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecAproxLlegada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecAproxLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecAproxLlegada.Location = New System.Drawing.Point(100, 90)
        Me.fecAproxLlegada.MaskInput = ""
        Me.fecAproxLlegada.Name = "fecAproxLlegada"
        Me.fecAproxLlegada.Size = New System.Drawing.Size(90, 20)
        Me.fecAproxLlegada.TabIndex = 6
        Me.fecAproxLlegada.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horSeguimiento
        '
        Me.horSeguimiento.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horSeguimiento.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horSeguimiento.Location = New System.Drawing.Point(194, 68)
        Me.horSeguimiento.MaskInput = "{LOC}hh:mm"
        Me.horSeguimiento.Name = "horSeguimiento"
        Me.horSeguimiento.Nullable = False
        Me.horSeguimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horSeguimiento.Size = New System.Drawing.Size(55, 20)
        Me.horSeguimiento.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horSeguimiento.TabIndex = 5
        Me.horSeguimiento.Tag = ""
        Me.horSeguimiento.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecSeguimiento
        '
        Me.fecSeguimiento.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecSeguimiento.Location = New System.Drawing.Point(100, 68)
        Me.fecSeguimiento.MaskInput = ""
        Me.fecSeguimiento.Name = "fecSeguimiento"
        Me.fecSeguimiento.Size = New System.Drawing.Size(90, 20)
        Me.fecSeguimiento.TabIndex = 4
        Me.fecSeguimiento.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraGroupBox4
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox4.ContentAreaAppearance = Appearance17
        Me.UltraGroupBox4.Controls.Add(Me.horInicioDescargaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.horSalidaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox4.Controls.Add(Me.fecSalidaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.fecLlegadaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.horLlegadaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox4.Controls.Add(Me.fecTerminoDescargaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.horTerminoDescargaDestino)
        Me.UltraGroupBox4.Controls.Add(Me.fecInicioDescargaDestino)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(550, 5)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(158, 196)
        Me.UltraGroupBox4.TabIndex = 75
        Me.UltraGroupBox4.Text = "Destino"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'horInicioDescargaDestino
        '
        Me.horInicioDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horInicioDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horInicioDescargaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horInicioDescargaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horInicioDescargaDestino.Location = New System.Drawing.Point(95, 80)
        Me.horInicioDescargaDestino.MaskInput = "{LOC}hh:mm"
        Me.horInicioDescargaDestino.Name = "horInicioDescargaDestino"
        Me.horInicioDescargaDestino.Nullable = False
        Me.horInicioDescargaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horInicioDescargaDestino.ReadOnly = True
        Me.horInicioDescargaDestino.Size = New System.Drawing.Size(55, 20)
        Me.horInicioDescargaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horInicioDescargaDestino.TabIndex = 25
        Me.horInicioDescargaDestino.Tag = ""
        Me.horInicioDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horSalidaDestino
        '
        Me.horSalidaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horSalidaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horSalidaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horSalidaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horSalidaDestino.Location = New System.Drawing.Point(96, 169)
        Me.horSalidaDestino.MaskInput = "{LOC}hh:mm"
        Me.horSalidaDestino.Name = "horSalidaDestino"
        Me.horSalidaDestino.Nullable = False
        Me.horSalidaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horSalidaDestino.ReadOnly = True
        Me.horSalidaDestino.Size = New System.Drawing.Size(55, 20)
        Me.horSalidaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horSalidaDestino.TabIndex = 29
        Me.horSalidaDestino.Tag = ""
        Me.horSalidaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel9
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance18
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(4, 20)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel9.TabIndex = 62
        Me.UltraLabel9.Text = "Llegada:"
        '
        'fecSalidaDestino
        '
        Me.fecSalidaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecSalidaDestino.Location = New System.Drawing.Point(4, 169)
        Me.fecSalidaDestino.MaskInput = ""
        Me.fecSalidaDestino.Name = "fecSalidaDestino"
        Me.fecSalidaDestino.ReadOnly = True
        Me.fecSalidaDestino.Size = New System.Drawing.Size(90, 20)
        Me.fecSalidaDestino.TabIndex = 28
        Me.fecSalidaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecLlegadaDestino
        '
        Me.fecLlegadaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecLlegadaDestino.Location = New System.Drawing.Point(4, 35)
        Me.fecLlegadaDestino.MaskInput = ""
        Me.fecLlegadaDestino.Name = "fecLlegadaDestino"
        Me.fecLlegadaDestino.ReadOnly = True
        Me.fecLlegadaDestino.Size = New System.Drawing.Size(90, 20)
        Me.fecLlegadaDestino.TabIndex = 22
        Me.fecLlegadaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance19
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(4, 154)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel11.TabIndex = 71
        Me.UltraLabel11.Text = "Salida:"
        '
        'horLlegadaDestino
        '
        Me.horLlegadaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horLlegadaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horLlegadaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horLlegadaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horLlegadaDestino.Location = New System.Drawing.Point(95, 35)
        Me.horLlegadaDestino.MaskInput = "{LOC}hh:mm"
        Me.horLlegadaDestino.Name = "horLlegadaDestino"
        Me.horLlegadaDestino.Nullable = False
        Me.horLlegadaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horLlegadaDestino.ReadOnly = True
        Me.horLlegadaDestino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.horLlegadaDestino.Size = New System.Drawing.Size(55, 20)
        Me.horLlegadaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horLlegadaDestino.TabIndex = 23
        Me.horLlegadaDestino.Tag = ""
        Me.horLlegadaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel12
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance20
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(5, 109)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(100, 14)
        Me.UltraLabel12.TabIndex = 68
        Me.UltraLabel12.Text = "Termino Descarga:"
        '
        'UltraLabel13
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance21
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(4, 64)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel13.TabIndex = 65
        Me.UltraLabel13.Text = "Inicio Descarga:"
        '
        'fecTerminoDescargaDestino
        '
        Me.fecTerminoDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoDescargaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecTerminoDescargaDestino.Location = New System.Drawing.Point(4, 125)
        Me.fecTerminoDescargaDestino.MaskInput = ""
        Me.fecTerminoDescargaDestino.Name = "fecTerminoDescargaDestino"
        Me.fecTerminoDescargaDestino.ReadOnly = True
        Me.fecTerminoDescargaDestino.Size = New System.Drawing.Size(90, 20)
        Me.fecTerminoDescargaDestino.TabIndex = 26
        Me.fecTerminoDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horTerminoDescargaDestino
        '
        Me.horTerminoDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horTerminoDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horTerminoDescargaDestino.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horTerminoDescargaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horTerminoDescargaDestino.Location = New System.Drawing.Point(95, 125)
        Me.horTerminoDescargaDestino.MaskInput = "{LOC}hh:mm"
        Me.horTerminoDescargaDestino.Name = "horTerminoDescargaDestino"
        Me.horTerminoDescargaDestino.Nullable = False
        Me.horTerminoDescargaDestino.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horTerminoDescargaDestino.ReadOnly = True
        Me.horTerminoDescargaDestino.Size = New System.Drawing.Size(55, 20)
        Me.horTerminoDescargaDestino.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horTerminoDescargaDestino.TabIndex = 27
        Me.horTerminoDescargaDestino.Tag = ""
        Me.horTerminoDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecInicioDescargaDestino
        '
        Me.fecInicioDescargaDestino.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecInicioDescargaDestino.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecInicioDescargaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecInicioDescargaDestino.Location = New System.Drawing.Point(4, 80)
        Me.fecInicioDescargaDestino.MaskInput = ""
        Me.fecInicioDescargaDestino.Name = "fecInicioDescargaDestino"
        Me.fecInicioDescargaDestino.ReadOnly = True
        Me.fecInicioDescargaDestino.Size = New System.Drawing.Size(90, 20)
        Me.fecInicioDescargaDestino.TabIndex = 24
        Me.fecInicioDescargaDestino.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraGroupBox2
        '
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance22
        Me.UltraGroupBox2.Controls.Add(Me.horCargaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.horSalidaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox2.Controls.Add(Me.fecSalidaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.fecLlegadaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox2.Controls.Add(Me.horLlegadaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox2.Controls.Add(Me.lbl)
        Me.UltraGroupBox2.Controls.Add(Me.fecTerminoCargaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.horTerminoCargaOrigen)
        Me.UltraGroupBox2.Controls.Add(Me.fecCargaOrigen)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(387, 5)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(158, 196)
        Me.UltraGroupBox2.TabIndex = 74
        Me.UltraGroupBox2.Text = "Origen"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'horCargaOrigen
        '
        Me.horCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horCargaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horCargaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horCargaOrigen.Location = New System.Drawing.Point(95, 80)
        Me.horCargaOrigen.MaskInput = "{LOC}hh:mm"
        Me.horCargaOrigen.Name = "horCargaOrigen"
        Me.horCargaOrigen.Nullable = False
        Me.horCargaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horCargaOrigen.ReadOnly = True
        Me.horCargaOrigen.Size = New System.Drawing.Size(55, 20)
        Me.horCargaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horCargaOrigen.TabIndex = 17
        Me.horCargaOrigen.Tag = ""
        Me.horCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horSalidaOrigen
        '
        Me.horSalidaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horSalidaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horSalidaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horSalidaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horSalidaOrigen.Location = New System.Drawing.Point(96, 169)
        Me.horSalidaOrigen.MaskInput = "{LOC}hh:mm"
        Me.horSalidaOrigen.Name = "horSalidaOrigen"
        Me.horSalidaOrigen.Nullable = False
        Me.horSalidaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horSalidaOrigen.ReadOnly = True
        Me.horSalidaOrigen.Size = New System.Drawing.Size(55, 20)
        Me.horSalidaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horSalidaOrigen.TabIndex = 21
        Me.horSalidaOrigen.Tag = ""
        Me.horSalidaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance23
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(4, 20)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel10.TabIndex = 62
        Me.UltraLabel10.Text = "Llegada:"
        '
        'fecSalidaOrigen
        '
        Me.fecSalidaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecSalidaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSalidaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecSalidaOrigen.Location = New System.Drawing.Point(4, 169)
        Me.fecSalidaOrigen.MaskInput = ""
        Me.fecSalidaOrigen.Name = "fecSalidaOrigen"
        Me.fecSalidaOrigen.ReadOnly = True
        Me.fecSalidaOrigen.Size = New System.Drawing.Size(90, 20)
        Me.fecSalidaOrigen.TabIndex = 20
        Me.fecSalidaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecLlegadaOrigen
        '
        Me.fecLlegadaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecLlegadaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecLlegadaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecLlegadaOrigen.Location = New System.Drawing.Point(4, 35)
        Me.fecLlegadaOrigen.MaskInput = ""
        Me.fecLlegadaOrigen.Name = "fecLlegadaOrigen"
        Me.fecLlegadaOrigen.ReadOnly = True
        Me.fecLlegadaOrigen.Size = New System.Drawing.Size(90, 20)
        Me.fecLlegadaOrigen.TabIndex = 14
        Me.fecLlegadaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel20
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance24
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(4, 154)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel20.TabIndex = 71
        Me.UltraLabel20.Text = "Salida:"
        '
        'horLlegadaOrigen
        '
        Me.horLlegadaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horLlegadaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horLlegadaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horLlegadaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horLlegadaOrigen.Location = New System.Drawing.Point(95, 35)
        Me.horLlegadaOrigen.MaskInput = "{LOC}hh:mm"
        Me.horLlegadaOrigen.Name = "horLlegadaOrigen"
        Me.horLlegadaOrigen.Nullable = False
        Me.horLlegadaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horLlegadaOrigen.ReadOnly = True
        Me.horLlegadaOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.horLlegadaOrigen.Size = New System.Drawing.Size(55, 20)
        Me.horLlegadaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horLlegadaOrigen.TabIndex = 15
        Me.horLlegadaOrigen.Tag = ""
        Me.horLlegadaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel6
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance25
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(5, 109)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel6.TabIndex = 68
        Me.UltraLabel6.Text = "Termino Carga:"
        '
        'lbl
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextVAlignAsString = "Middle"
        Me.lbl.Appearance = Appearance26
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(4, 64)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(68, 14)
        Me.lbl.TabIndex = 65
        Me.lbl.Text = "Inicio Carga:"
        '
        'fecTerminoCargaOrigen
        '
        Me.fecTerminoCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecTerminoCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecTerminoCargaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecTerminoCargaOrigen.Location = New System.Drawing.Point(4, 125)
        Me.fecTerminoCargaOrigen.MaskInput = ""
        Me.fecTerminoCargaOrigen.Name = "fecTerminoCargaOrigen"
        Me.fecTerminoCargaOrigen.ReadOnly = True
        Me.fecTerminoCargaOrigen.Size = New System.Drawing.Size(90, 20)
        Me.fecTerminoCargaOrigen.TabIndex = 18
        Me.fecTerminoCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'horTerminoCargaOrigen
        '
        Me.horTerminoCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.horTerminoCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.horTerminoCargaOrigen.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.horTerminoCargaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.horTerminoCargaOrigen.Location = New System.Drawing.Point(95, 125)
        Me.horTerminoCargaOrigen.MaskInput = "{LOC}hh:mm"
        Me.horTerminoCargaOrigen.Name = "horTerminoCargaOrigen"
        Me.horTerminoCargaOrigen.Nullable = False
        Me.horTerminoCargaOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.horTerminoCargaOrigen.ReadOnly = True
        Me.horTerminoCargaOrigen.Size = New System.Drawing.Size(55, 20)
        Me.horTerminoCargaOrigen.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.horTerminoCargaOrigen.TabIndex = 19
        Me.horTerminoCargaOrigen.Tag = ""
        Me.horTerminoCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'fecCargaOrigen
        '
        Me.fecCargaOrigen.DateTime = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.fecCargaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecCargaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecCargaOrigen.Location = New System.Drawing.Point(4, 80)
        Me.fecCargaOrigen.MaskInput = ""
        Me.fecCargaOrigen.Name = "fecCargaOrigen"
        Me.fecCargaOrigen.ReadOnly = True
        Me.fecCargaOrigen.Size = New System.Drawing.Size(90, 20)
        Me.fecCargaOrigen.TabIndex = 16
        Me.fecCargaOrigen.Value = New Date(2014, 12, 1, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance27
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(18, 116)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(81, 14)
        Me.UltraLabel4.TabIndex = 57
        Me.UltraLabel4.Text = "Fecha Entrega:"
        '
        'UltraLabel3
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance28
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(3, 95)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 14)
        Me.UltraLabel3.TabIndex = 54
        Me.UltraLabel3.Text = "Fecha Aprox Lleg:"
        '
        'cboEstado
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Appearance = Appearance29
        Me.cboEstado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstado.Enabled = False
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboEstado.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Location = New System.Drawing.Point(102, 177)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(147, 20)
        Me.cboEstado.TabIndex = 13
        Me.cboEstado.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance30
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(56, 181)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel2.TabIndex = 51
        Me.UltraLabel2.Text = "Estado:"
        '
        'cboLugar
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Appearance = Appearance31
        Me.cboLugar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLugar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.Location = New System.Drawing.Point(100, 3)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(281, 20)
        Me.cboLugar.TabIndex = 1
        Me.cboLugar.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance32
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(38, 6)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta2.TabIndex = 46
        Me.Etiqueta2.Text = "Ubicación:"
        '
        'cboOperador
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboOperador.Appearance = Appearance33
        Me.cboOperador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboOperador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOperador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboOperador.ForeColor = System.Drawing.Color.Black
        Me.cboOperador.Location = New System.Drawing.Point(100, 47)
        Me.cboOperador.Name = "cboOperador"
        Me.cboOperador.Size = New System.Drawing.Size(281, 20)
        Me.cboOperador.TabIndex = 3
        Me.cboOperador.ValueMember = "Id"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtReferencia.Location = New System.Drawing.Point(100, 25)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(281, 20)
        Me.txtReferencia.TabIndex = 2
        '
        'UltraLabel5
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance34
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(37, 28)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel5.TabIndex = 44
        Me.UltraLabel5.Text = "Referencia:"
        '
        'UltraLabel14
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance35
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(44, 49)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel14.TabIndex = 29
        Me.UltraLabel14.Text = "Operador:"
        '
        'txtGlosa
        '
        Appearance36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance36
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(101, 133)
        Me.txtGlosa.MaxLength = 100
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(281, 43)
        Me.txtGlosa.TabIndex = 12
        '
        'UltraLabel7
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Appearance37.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance37
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(37, 70)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel7.TabIndex = 20
        Me.UltraLabel7.Text = "Fecha Seg:"
        '
        'UltraLabel1
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance38
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(62, 139)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Glosa:"
        '
        'exgruViaje
        '
        Me.exgruViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.White
        Me.exgruViaje.ContentAreaAppearance = Appearance39
        Me.exgruViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.exgruViaje.Dock = System.Windows.Forms.DockStyle.Left
        Me.exgruViaje.ExpandedSize = New System.Drawing.Size(350, 353)
        Me.exgruViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.exgruViaje.Location = New System.Drawing.Point(0, 0)
        Me.exgruViaje.Name = "exgruViaje"
        Me.exgruViaje.Size = New System.Drawing.Size(350, 353)
        Me.exgruViaje.TabIndex = 7
        Me.exgruViaje.Text = "Datos de Viaje"
        Me.exgruViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtMovil)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraLabel8)
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
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(327, 347)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'txtMovil
        '
        Me.txtMovil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtMovil.Location = New System.Drawing.Point(66, 208)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.ReadOnly = True
        Me.txtMovil.Size = New System.Drawing.Size(260, 20)
        Me.txtMovil.TabIndex = 58
        '
        'UltraLabel8
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Appearance40.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance40
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(28, 213)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel8.TabIndex = 57
        Me.UltraLabel8.Text = "Movil:"
        '
        'btnBuscar
        '
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.consult
        Me.btnBuscar.Appearance = Appearance41
        Me.btnBuscar.Location = New System.Drawing.Point(246, 230)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 25)
        Me.btnBuscar.TabIndex = 53
        Me.btnBuscar.Text = "Buscar"
        '
        'lblPilotoGRT
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.TextVAlignAsString = "Middle"
        Me.lblPilotoGRT.Appearance = Appearance42
        Me.lblPilotoGRT.AutoSize = True
        Me.lblPilotoGRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPilotoGRT.Location = New System.Drawing.Point(2, 191)
        Me.lblPilotoGRT.Name = "lblPilotoGRT"
        Me.lblPilotoGRT.Size = New System.Drawing.Size(63, 14)
        Me.lblPilotoGRT.TabIndex = 52
        Me.lblPilotoGRT.Text = "Piloto GRT:"
        Me.lblPilotoGRT.Visible = False
        '
        'cboPilotoTercero
        '
        Appearance43.Image = Global.ISL.Win.My.Resources.Resources.consult
        EditorButton1.Appearance = Appearance43
        Me.cboPilotoTercero.ButtonsRight.Add(EditorButton1)
        Me.cboPilotoTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPilotoTercero.DisplayMember = "Nombre"
        Me.cboPilotoTercero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoTercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboPilotoTercero.Location = New System.Drawing.Point(66, 185)
        Me.cboPilotoTercero.Name = "cboPilotoTercero"
        Me.cboPilotoTercero.Size = New System.Drawing.Size(260, 21)
        Me.cboPilotoTercero.TabIndex = 51
        Me.cboPilotoTercero.ValueMember = "Id"
        Me.cboPilotoTercero.Visible = False
        '
        'cboActividadNegocio
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance44
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocio.DisplayMember = "Nombre"
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Location = New System.Drawing.Point(175, 48)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.ReadOnly = True
        Me.cboActividadNegocio.Size = New System.Drawing.Size(150, 20)
        Me.cboActividadNegocio.TabIndex = 32
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'UltraLabel35
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.UltraLabel35.Appearance = Appearance45
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
        Appearance46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Appearance = Appearance46
        Me.fecViaje.DateTime = New Date(2014, 11, 14, 0, 0, 0, 0)
        Me.fecViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.fecViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecViaje.Location = New System.Drawing.Point(66, 48)
        Me.fecViaje.Name = "fecViaje"
        Me.fecViaje.ReadOnly = True
        Me.fecViaje.Size = New System.Drawing.Size(80, 20)
        Me.fecViaje.TabIndex = 6
        Me.fecViaje.Value = New Date(2014, 11, 14, 0, 0, 0, 0)
        '
        'UltraLabel36
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Appearance47.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance47
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
        Me.txtViajeEscala.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeEscala.Location = New System.Drawing.Point(66, 117)
        Me.txtViajeEscala.Name = "txtViajeEscala"
        Me.txtViajeEscala.ReadOnly = True
        Me.txtViajeEscala.Size = New System.Drawing.Size(260, 20)
        Me.txtViajeEscala.TabIndex = 21
        '
        'txtIdViaje
        '
        Me.txtIdViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtIdViaje.Location = New System.Drawing.Point(8, 25)
        Me.txtIdViaje.Name = "txtIdViaje"
        Me.txtIdViaje.ReadOnly = True
        Me.txtIdViaje.Size = New System.Drawing.Size(21, 20)
        Me.txtIdViaje.TabIndex = 2
        Me.txtIdViaje.Visible = False
        '
        'txtViajeCopiloto
        '
        Me.txtViajeCopiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCopiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeCopiloto.Location = New System.Drawing.Point(66, 162)
        Me.txtViajeCopiloto.Name = "txtViajeCopiloto"
        Me.txtViajeCopiloto.ReadOnly = True
        Me.txtViajeCopiloto.Size = New System.Drawing.Size(260, 20)
        Me.txtViajeCopiloto.TabIndex = 1
        '
        'UltraLabel37
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Appearance48.TextVAlignAsString = "Middle"
        Me.UltraLabel37.Appearance = Appearance48
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel37.Location = New System.Drawing.Point(14, 166)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel37.TabIndex = 0
        Me.UltraLabel37.Text = "CoPiloto:"
        '
        'UltraLabel38
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Appearance49.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance49
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
        Me.txtViajeDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeDestino.Location = New System.Drawing.Point(66, 94)
        Me.txtViajeDestino.Name = "txtViajeDestino"
        Me.txtViajeDestino.ReadOnly = True
        Me.txtViajeDestino.Size = New System.Drawing.Size(260, 20)
        Me.txtViajeDestino.TabIndex = 19
        '
        'UltraLabel40
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Appearance50.TextVAlignAsString = "Middle"
        Me.UltraLabel40.Appearance = Appearance50
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
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Appearance51.TextVAlignAsString = "Middle"
        Me.UltraLabel42.Appearance = Appearance51
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
        Appearance52.BorderColor = System.Drawing.Color.Cyan
        Me.txtCodigoViaje.Appearance = Appearance52
        Me.txtCodigoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtCodigoViaje.Location = New System.Drawing.Point(66, 25)
        Me.txtCodigoViaje.Name = "txtCodigoViaje"
        Me.txtCodigoViaje.ReadOnly = True
        Me.txtCodigoViaje.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoViaje.TabIndex = 7
        '
        'txtViajeCarreta
        '
        Me.txtViajeCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeCarreta.Location = New System.Drawing.Point(245, 25)
        Me.txtViajeCarreta.Name = "txtViajeCarreta"
        Me.txtViajeCarreta.ReadOnly = True
        Me.txtViajeCarreta.Size = New System.Drawing.Size(80, 20)
        Me.txtViajeCarreta.TabIndex = 12
        '
        'UltraLabel43
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Appearance53.TextVAlignAsString = "Middle"
        Me.UltraLabel43.Appearance = Appearance53
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
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Appearance54.TextVAlignAsString = "Middle"
        Me.UltraLabel44.Appearance = Appearance54
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
        Me.txtCodigoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtCodigoOperacion.Location = New System.Drawing.Point(66, 2)
        Me.txtCodigoOperacion.Name = "txtCodigoOperacion"
        Me.txtCodigoOperacion.ReadOnly = True
        Me.txtCodigoOperacion.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoOperacion.TabIndex = 8
        '
        'txtViajeTracto
        '
        Me.txtViajeTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeTracto.Location = New System.Drawing.Point(245, 2)
        Me.txtViajeTracto.Name = "txtViajeTracto"
        Me.txtViajeTracto.ReadOnly = True
        Me.txtViajeTracto.Size = New System.Drawing.Size(80, 20)
        Me.txtViajeTracto.TabIndex = 10
        '
        'txtViajePiloto
        '
        Me.txtViajePiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajePiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajePiloto.Location = New System.Drawing.Point(66, 139)
        Me.txtViajePiloto.Name = "txtViajePiloto"
        Me.txtViajePiloto.ReadOnly = True
        Me.txtViajePiloto.Size = New System.Drawing.Size(260, 20)
        Me.txtViajePiloto.TabIndex = 23
        '
        'UltraLabel45
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel45.Appearance = Appearance55
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
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel46.Appearance = Appearance56
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel46.Location = New System.Drawing.Point(27, 143)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel46.TabIndex = 22
        Me.UltraLabel46.Text = "Piloto:"
        '
        'txtViajeOrigen
        '
        Me.txtViajeOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtViajeOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtViajeOrigen.Location = New System.Drawing.Point(66, 71)
        Me.txtViajeOrigen.Name = "txtViajeOrigen"
        Me.txtViajeOrigen.ReadOnly = True
        Me.txtViajeOrigen.Size = New System.Drawing.Size(260, 20)
        Me.txtViajeOrigen.TabIndex = 17
        '
        'txtIdSeguimiento
        '
        Me.txtIdSeguimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtIdSeguimiento.Location = New System.Drawing.Point(179, 25)
        Me.txtIdSeguimiento.Name = "txtIdSeguimiento"
        Me.txtIdSeguimiento.ReadOnly = True
        Me.txtIdSeguimiento.Size = New System.Drawing.Size(21, 20)
        Me.txtIdSeguimiento.TabIndex = 14
        Me.txtIdSeguimiento.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtIdOperacion.Location = New System.Drawing.Point(179, 2)
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.ReadOnly = True
        Me.txtIdOperacion.Size = New System.Drawing.Size(21, 20)
        Me.txtIdOperacion.TabIndex = 13
        Me.txtIdOperacion.Visible = False
        '
        'txtIdOperacionDetalle
        '
        Me.txtIdOperacionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txtIdOperacionDetalle.Location = New System.Drawing.Point(150, 48)
        Me.txtIdOperacionDetalle.Name = "txtIdOperacionDetalle"
        Me.txtIdOperacionDetalle.ReadOnly = True
        Me.txtIdOperacionDetalle.Size = New System.Drawing.Size(21, 20)
        Me.txtIdOperacionDetalle.TabIndex = 15
        Me.txtIdOperacionDetalle.Visible = False
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.btnValidar)
        Me.UltraTabPageControl6.Controls.Add(Me.btnImportar)
        Me.UltraTabPageControl6.Controls.Add(Me.gridImportar)
        Me.UltraTabPageControl6.Enabled = False
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1241, 353)
        '
        'btnValidar
        '
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.btnValidar.Appearance = Appearance57
        Me.btnValidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.ForeColor = System.Drawing.Color.Black
        Me.btnValidar.Location = New System.Drawing.Point(136, 3)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(81, 22)
        Me.btnValidar.TabIndex = 34
        Me.btnValidar.Text = "Validar"
        '
        'btnImportar
        '
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.btnImportar.Appearance = Appearance58
        Me.btnImportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.Black
        Me.btnImportar.Location = New System.Drawing.Point(3, 3)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(81, 22)
        Me.btnImportar.TabIndex = 33
        Me.btnImportar.Text = "Importar"
        '
        'gridImportar
        '
        Me.gridImportar.DataSource = Me.ogdSeguimientoMonitoreo
        UltraGridColumn197.Header.VisiblePosition = 38
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.Fixed = True
        UltraGridColumn198.Header.VisiblePosition = 0
        UltraGridColumn198.Hidden = True
        UltraGridColumn198.Width = 100
        UltraGridColumn199.Header.Caption = "Seg. Monitoreo"
        UltraGridColumn199.Header.Fixed = True
        UltraGridColumn199.Header.VisiblePosition = 1
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.Width = 100
        UltraGridColumn200.Header.VisiblePosition = 3
        UltraGridColumn200.Hidden = True
        UltraGridColumn200.Width = 100
        UltraGridColumn201.Header.Caption = "Viaje"
        UltraGridColumn201.Header.Fixed = True
        UltraGridColumn201.Header.VisiblePosition = 2
        UltraGridColumn201.Width = 100
        UltraGridColumn202.Header.Caption = "F. Seguimiento"
        UltraGridColumn202.Header.VisiblePosition = 5
        UltraGridColumn202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn202.Width = 110
        UltraGridColumn203.Header.Caption = "F. Aprox. Llegada"
        UltraGridColumn203.Header.VisiblePosition = 6
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn203.Width = 110
        UltraGridColumn204.Header.Caption = "F. Entrega"
        UltraGridColumn204.Header.VisiblePosition = 7
        UltraGridColumn204.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn204.Width = 110
        UltraGridColumn205.Header.VisiblePosition = 10
        UltraGridColumn205.Hidden = True
        UltraGridColumn205.Width = 100
        UltraGridColumn206.Header.Caption = "Ubicación"
        UltraGridColumn206.Header.VisiblePosition = 11
        UltraGridColumn206.Width = 180
        UltraGridColumn207.Header.VisiblePosition = 20
        UltraGridColumn207.Width = 180
        UltraGridColumn208.Header.VisiblePosition = 17
        UltraGridColumn208.Hidden = True
        UltraGridColumn208.Width = 100
        UltraGridColumn209.Header.VisiblePosition = 19
        UltraGridColumn209.Hidden = True
        UltraGridColumn209.Width = 110
        UltraGridColumn210.Header.VisiblePosition = 36
        UltraGridColumn210.Hidden = True
        UltraGridColumn210.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn210.Width = 110
        UltraGridColumn211.Header.VisiblePosition = 22
        UltraGridColumn211.Hidden = True
        UltraGridColumn211.Width = 100
        UltraGridColumn212.Header.VisiblePosition = 37
        UltraGridColumn212.Hidden = True
        UltraGridColumn212.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn212.Width = 110
        UltraGridColumn213.Header.VisiblePosition = 23
        UltraGridColumn213.Hidden = True
        UltraGridColumn213.Width = 100
        UltraGridColumn214.Header.VisiblePosition = 21
        UltraGridColumn214.Width = 180
        UltraGridColumn215.Header.VisiblePosition = 16
        UltraGridColumn215.Hidden = True
        UltraGridColumn215.Width = 100
        UltraGridColumn216.Header.VisiblePosition = 35
        UltraGridColumn216.Hidden = True
        UltraGridColumn216.Width = 180
        UltraGridColumn217.Header.VisiblePosition = 9
        UltraGridColumn217.Width = 180
        UltraGridColumn218.Header.VisiblePosition = 13
        UltraGridColumn218.Width = 180
        UltraGridColumn219.Header.VisiblePosition = 15
        UltraGridColumn219.Hidden = True
        UltraGridColumn219.Width = 180
        UltraGridColumn220.Header.VisiblePosition = 26
        UltraGridColumn220.Hidden = True
        UltraGridColumn220.Width = 100
        UltraGridColumn221.Header.VisiblePosition = 27
        UltraGridColumn221.Width = 180
        UltraGridColumn222.Header.VisiblePosition = 31
        UltraGridColumn222.Hidden = True
        UltraGridColumn222.Width = 100
        UltraGridColumn223.Header.VisiblePosition = 32
        UltraGridColumn223.Width = 80
        UltraGridColumn224.Header.VisiblePosition = 28
        UltraGridColumn224.Hidden = True
        UltraGridColumn224.Width = 100
        UltraGridColumn225.Header.VisiblePosition = 29
        UltraGridColumn225.Width = 180
        UltraGridColumn226.Header.VisiblePosition = 30
        UltraGridColumn226.Width = 80
        UltraGridColumn227.Header.VisiblePosition = 33
        UltraGridColumn227.Hidden = True
        UltraGridColumn227.Width = 80
        UltraGridColumn228.Header.VisiblePosition = 24
        UltraGridColumn228.Hidden = True
        UltraGridColumn228.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn228.Width = 110
        UltraGridColumn229.Header.VisiblePosition = 34
        UltraGridColumn229.Hidden = True
        UltraGridColumn229.Width = 80
        UltraGridColumn230.Header.VisiblePosition = 25
        UltraGridColumn230.Width = 180
        UltraGridColumn231.Header.VisiblePosition = 8
        UltraGridColumn231.Hidden = True
        UltraGridColumn231.Width = 100
        UltraGridColumn232.Header.VisiblePosition = 12
        UltraGridColumn232.Hidden = True
        UltraGridColumn232.Width = 100
        UltraGridColumn233.Header.VisiblePosition = 14
        UltraGridColumn233.Hidden = True
        UltraGridColumn233.Width = 100
        UltraGridColumn234.Header.Caption = "Estado"
        UltraGridColumn234.Header.VisiblePosition = 18
        UltraGridColumn234.Width = 110
        UltraGridColumn235.Header.Caption = "F. Salida Origen"
        UltraGridColumn235.Header.VisiblePosition = 4
        UltraGridColumn235.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn235.Width = 110
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235})
        Me.gridImportar.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.gridImportar.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.gridImportar.DisplayLayout.MaxColScrollRegions = 1
        Me.gridImportar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridImportar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridImportar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridImportar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridImportar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridImportar.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridImportar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridImportar.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.gridImportar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridImportar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridImportar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridImportar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridImportar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridImportar.DisplayLayout.UseFixedHeaders = True
        Me.gridImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.gridImportar.Location = New System.Drawing.Point(3, 31)
        Me.gridImportar.Name = "gridImportar"
        Me.gridImportar.Size = New System.Drawing.Size(1235, 319)
        Me.gridImportar.TabIndex = 32
        '
        'ogdSeguimientoMonitoreoAux
        '
        UltraDataColumn40.DataType = GetType(Boolean)
        UltraDataColumn40.DefaultValue = False
        UltraDataColumn45.DataType = GetType(Date)
        UltraDataColumn46.DataType = GetType(Date)
        UltraDataColumn47.DataType = GetType(Date)
        UltraDataColumn53.DataType = GetType(Date)
        UltraDataColumn55.DataType = GetType(Date)
        UltraDataColumn71.DataType = GetType(Date)
        UltraDataColumn78.DataType = GetType(Date)
        Me.ogdSeguimientoMonitoreoAux.Band.Columns.AddRange(New Object() {UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79})
        '
        'tcPrincipal
        '
        Me.tcPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcPrincipal.Controls.Add(Me.UltraTabPageControl7)
        Me.tcPrincipal.Controls.Add(Me.utpDetalle)
        Me.tcPrincipal.Controls.Add(Me.UltraTabPageControl6)
        Me.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tcPrincipal.Name = "tcPrincipal"
        Me.tcPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcPrincipal.Size = New System.Drawing.Size(1243, 376)
        Me.tcPrincipal.TabIndex = 4
        UltraTab5.Key = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "Lista"
        UltraTab6.Key = "Mantenimiento"
        UltraTab6.TabPage = Me.utpDetalle
        UltraTab6.Text = "Mantenimiento"
        UltraTab8.Key = "ImportarDatos"
        UltraTab8.TabPage = Me.UltraTabPageControl6
        UltraTab8.Text = "Importar Datos"
        Me.tcPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab8})
        Me.tcPrincipal.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1241, 353)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_RegistroSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 376)
        Me.Controls.Add(Me.tcPrincipal)
        Me.Name = "frm_RegistroSeguimiento"
        Me.Text = "Seguimiento Monitoreo Viaje"
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdSeguimientoMonitoreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
        CType(Me.griListaEnviarEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griListaSeguimientoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griListaSeguimientoConductor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaSeguimientoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ColorATiempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRetrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.cboClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.horEntregaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEntregaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horAproxLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecAproxLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.horInicioDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horSalidaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecLlegadaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horLlegadaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horTerminoDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecInicioDescargaDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.horCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horSalidaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSalidaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecLlegadaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horLlegadaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horTerminoCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecCargaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exgruViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.PerformLayout()
        CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.gridImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdSeguimientoMonitoreoAux, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTotalAccidentes As ISL.Controles.Agrupacion
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorATiempo As ISL.Controles.Colores
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents ColorRetrasado As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboEstadoBusqueda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboEstado As ISL.Controles.Combo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboLugar As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboOperador As ISL.Controles.Combo
    Friend WithEvents txtReferencia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents tcDetalle As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents horLlegadaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecLlegadaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lbl As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecTerminoCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horTerminoCargaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horSalidaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecSalidaOrigen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents horEntrega As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecEntrega As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horAproxLlegada As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecAproxLlegada As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horSeguimiento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecSeguimiento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents horInicioDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horSalidaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecSalidaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecLlegadaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents horLlegadaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecTerminoDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents horTerminoDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecInicioDescargaDestino As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents ogdSeguimientoMonitoreo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtMovil As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents horEntregaVenta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents fecEntregaVenta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents EnviarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griListaSeguimientoViaje As ISL.Controles.Grilla
    Friend WithEvents griListaSeguimientoConductor As ISL.Controles.Grilla
    Friend WithEvents griListaSeguimientoVehiculo As ISL.Controles.Grilla
    Friend WithEvents btnGuardarRapido As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabListado As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents tabListar As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnEnviarCorreo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griListaEnviarEmail As ISL.Controles.Grilla
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbInd As System.Windows.Forms.CheckBox
    Friend WithEvents ogdSeguimientoMonitoreoAux As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cboClientes As ISL.Controles.Combo
    Friend WithEvents ImportarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnImportar As ISL.Controles.Boton
    Friend WithEvents gridImportar As ISL.Controles.Grilla
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnValidar As ISL.Controles.Boton
End Class
