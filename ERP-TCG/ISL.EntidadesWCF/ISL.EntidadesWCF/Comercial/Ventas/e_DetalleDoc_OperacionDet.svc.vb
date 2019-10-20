

<DataContract()> _
Public Class e_DetalleDoc_OperacionDet
    Implements Ie_DetalleDoc_OperacionDet
    Implements IEquatable(Of e_DetalleDoc_OperacionDet)

#Region "Declaracion de Variables"

    Private _Id As String
    Private _IdMaterialServicio As String
    Private _MaterialServicio As String
    Private _Cantidad As Double
    Private _PrecioUnitario As Double
    Private _IndGravado As Boolean
    Private _Igv As Double
    Private _Valor As Double
    Private _IdOperacionDetalle As String
    Private _IdUnidadMedida As String
    Private _FactorRefUni As Double
    Private _IdOperacion As String
    Private _IdComisionista As String
    Private _IdUnidadCarga As String
    Private _UnidadMedida As String
    Private _IdMaterial As String
    Private _CantOpe As Double
    Private _IncluyeIgv As Boolean
    Private _FleteUnitario As Double
    Private _Flete As Double
    Private _IdOrigen As String
    Private _IdDestino As String
    Private _Origen As String
    Private _Destino As String
    Private _PesoToneladas As Double
    Private _Glosa As String
    Private _CantGuia As Double
    Private _Saldo As Double
    Private _Tracto As String
    Private _Carreta As String
    Private _FechaViaje As Date
    Private _NroViaje As String
    Private _ConfVeh As String
    Private _Consolidado As Double
    Private _subtotal As Double
    Private _factortotal As Double
    Private _valorunit2 As Double    
    Private _IndConsolidado As String
    Private _GlosaConsolidado As String



    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public IdMovimientoDocumento As String = ""
    <DataMember()> _
    Public IdOperacionDet As String = ""
    <DataMember()> _
    Public _NroOperacion As String = ""
    <DataMember()> _
    Public _IdVehiculo As String = ""

#End Region

#Region "Propiedades"


    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterialServicio() As String
        Get
            Return _IdMaterialServicio
        End Get
        Set(ByVal value As String)
            _IdMaterialServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property MaterialServicio() As String
        Get
            Return _MaterialServicio
        End Get
        Set(ByVal value As String)
            _MaterialServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Double)
            _Cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _PrecioUnitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndGravado() As Boolean
        Get
            Return _IndGravado
        End Get
        Set(ByVal value As Boolean)
            _IndGravado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Igv() As Double
        Get
            Return _Igv
        End Get
        Set(ByVal value As Double)
            _Igv = value
        End Set
    End Property

    <DataMember()> _
    Public Property Valor() As Double
        Get
            Return _Cantidad * _PrecioUnitario
        End Get
        Set(ByVal value As Double)
            _Valor = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal() As Double
        Get
            Return _Cantidad * _PrecioUnitario + _Igv
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacionDetalle() As String
        Get
            Return _IdOperacionDetalle
        End Get
        Set(ByVal value As String)
            _IdOperacionDetalle = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadMedida() As String
        Get
            Return _IdUnidadMedida
        End Get
        Set(ByVal value As String)
            _IdUnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property UnidadMedida() As String
        Get
            Return _UnidadMedida
        End Get
        Set(ByVal value As String)
            _UnidadMedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property FactorRefUni() As Double
        Get
            Return _FactorRefUni
        End Get
        Set(ByVal value As Double)
            _FactorRefUni = value
        End Set
    End Property

    <DataMember()> _
    Public Property FactorRefTotal() As Double
        Get
            Return _factortotal
        End Get
        Set(ByVal value As Double)
            _factortotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperacion() As String
        Get
            Return _IdOperacion
        End Get
        Set(ByVal value As String)
            _IdOperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdComisionista() As String
        Get
            Return _IdComisionista
        End Get
        Set(ByVal value As String)
            _IdComisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUnidadCarga() As String
        Get
            Return _IdUnidadCarga
        End Get
        Set(ByVal value As String)
            _IdUnidadCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMaterial() As String
        Get
            Return _IdMaterial
        End Get
        Set(ByVal value As String)
            _IdMaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantOpe() As Double
        Get
            Return _CantOpe
        End Get
        Set(ByVal value As Double)
            _CantOpe = value
        End Set
    End Property

    <DataMember()> _
    Public Property IncluyeIgv() As Boolean
        Get
            Return _IncluyeIgv
        End Get
        Set(ByVal value As Boolean)
            _IncluyeIgv = value
        End Set
    End Property

    <DataMember()> _
    Public Property FleteUnitario() As Double
        Get
            Return _FleteUnitario
        End Get
        Set(ByVal value As Double)
            _FleteUnitario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As Double
        Get
            Return _Flete
        End Get
        Set(ByVal value As Double)
            _Flete = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _IdOrigen
        End Get
        Set(ByVal value As String)
            _IdOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _IdDestino
        End Get
        Set(ByVal value As String)
            _IdDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property PesoToneladas() As Double
        Get
            Return _PesoToneladas
        End Get
        Set(ByVal value As Double)
            _PesoToneladas = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantGuia() As Double
        Get
            Return _CantGuia
        End Get
        Set(ByVal value As Double)
            _CantGuia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tracto() As String
        Get
            Return _Tracto
        End Get
        Set(ByVal value As String)
            _Tracto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Carreta() As String
        Get
            Return _Carreta
        End Get
        Set(ByVal value As String)
            _Carreta = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaViaje() As Date
        Get
            Return _FechaViaje
        End Get
        Set(ByVal value As Date)
            _FechaViaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroViaje() As String
        Get
            Return _NroViaje
        End Get
        Set(ByVal value As String)
            _NroViaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property CV() As String
        Get
            Return _ConfVeh
        End Get
        Set(ByVal value As String)
            _ConfVeh = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorUnit2() As Double
        Get
            Return _valorunit2
        End Get
        Set(ByVal value As Double)
            _valorunit2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Consolidado() As Double
        Get
            Return _Consolidado
        End Get
        Set(ByVal value As Double)
            _Consolidado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndConsolidado() As String
        Get
            Return _IndConsolidado
        End Get
        Set(ByVal value As String)
            _IndConsolidado = value
        End Set
    End Property
    <DataMember()> _
    Public Property GlosaConsolidado() As String
        Get
            Return _GlosaConsolidado
        End Get
        Set(ByVal value As String)
            _GlosaConsolidado = value
        End Set
    End Property
#End Region

#Region "Contructor"

    Public Sub New()
        _Id = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
        , ByVal ls_IdMaterialServicio As String _
        , ByVal ls_MaterialServicio As String _
        , ByVal ln_Cantidad As Double _
        , ByVal ln_PrecioUnitario As Double _
        , ByVal lb_IndGravado As Boolean _
        , ByVal ln_Igv As Double _
        , ByVal ls_Valor As Double _
        , ByVal ls_IdOperacionDetalle As String _
        , ByVal ls_IdUnidadMedida As String _
        , ByVal ls_UnidadMedida As String _
        , ByVal ln_FactorRefUni As Double _
        , ByVal ls_IdOperacion As String _
        , ByVal ls_IdComisionista As String _
        , ByVal ls_IdUnidadCarga As String _
        , ByVal ls_IdMaterial As String _
        , ByVal ln_CantOpe As Double _
        , ByVal lb_IncluyeIgv As Boolean _
        , ByVal ln_FleteUnitario As Double _
        , ByVal ln_Flete As Double _
        , ByVal ls_IdOrigen As String _
        , ByVal ls_IdDestino As String _
        , ByVal ls_Origen As String _
        , ByVal ls_Destino As String _
        , ByVal ln_PesoToneladas As Double _
        , ByVal ls_Glosa As String _
        , ByVal ln_CantGuia As Double _
        , ByVal ln_Saldo As Double _
        , ByVal ls_Tracto As String _
        , ByVal ls_Carreta As String _
        , ByVal ld_FechaViaje As Date _
        , ByVal ls_NroViaje As String _
        , ByVal ls_ConfVeh As String _
        , ByVal ls_NroOperacion As String _
        , ByVal ls_IdVehiculo As String _
        , ByVal ln_Consolidado As Double)

        _Id = ls_Id
        _IdMaterialServicio = ls_IdMaterialServicio
        _MaterialServicio = ls_MaterialServicio
        If _Id = "" Then
            _Cantidad = IIf(ln_Cantidad = 0, ln_CantOpe, ln_Cantidad)
        Else
            _Cantidad = ln_Cantidad
        End If
        _PrecioUnitario = ln_PrecioUnitario
        _valorunit2 = ln_PrecioUnitario
        _IndGravado = lb_IndGravado
        _Igv = ln_Igv
        _Valor = ls_Valor
        _IdOperacionDetalle = ls_IdOperacionDetalle
        _IdUnidadMedida = ls_IdUnidadMedida
        _UnidadMedida = ls_UnidadMedida
        _FactorRefUni = ln_FactorRefUni
        _IdOperacion = ls_IdOperacion
        _IdComisionista = ls_IdComisionista
        _IdUnidadCarga = ls_IdUnidadCarga
        _IdMaterial = ls_IdMaterial
        _CantOpe = ln_CantOpe
        _IncluyeIgv = lb_IncluyeIgv
        _FleteUnitario = ln_FleteUnitario
        _Flete = ln_Flete
        _IdOrigen = ls_IdOrigen
        _IdDestino = ls_IdDestino
        _Origen = ls_Origen
        _Destino = ls_Destino
        _PesoToneladas = ln_PesoToneladas
        _Glosa = ls_Glosa
        _CantGuia = ln_CantGuia
        _Saldo = ln_Saldo
        _Tracto = ls_Tracto
        _Carreta = ls_Carreta
        _FechaViaje = ld_FechaViaje
        _NroViaje = ls_NroViaje
        _ConfVeh = ls_ConfVeh
        _NroOperacion = ls_NroOperacion
        _IdVehiculo = ls_IdVehiculo
        _Consolidado = ln_Consolidado
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeDDOD As e_DetalleDoc_OperacionDet) _
    As Boolean Implements IEquatable(Of e_DetalleDoc_OperacionDet).Equals
        If Me.IdOperacionDetalle = oeDDOD.IdOperacionDetalle Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal detalleDoc_OperacionDet As e_DetalleDoc_OperacionDet) As e_DetalleDoc_OperacionDet Implements Ie_DetalleDoc_OperacionDet.Obtener
        Return detalleDoc_OperacionDet
    End Function

#End Region

End Class


