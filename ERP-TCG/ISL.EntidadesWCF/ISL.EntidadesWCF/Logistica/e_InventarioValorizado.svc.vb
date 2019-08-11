<DataContract()> _
Public Class e_InventarioValorizado
    Implements Ie_InventarioValorizado

#Region "Propiedad"

    <DataMember()> _
    Public IdMaterial As String
    <DataMember()> _
    Public IdSubAlmacen As String
    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    <DataMember()> _
    Public tipoOperacion As String

    Private _idRegistroInv As String
    Private _fecha As Date
    Private _nrodoc As String

    Private _tipomovimiento As String
    Private _descripcion As String
    Private _cantIngreso As String
    Private _costoIngreso As String
    Private _valorIngreso As String

    Private _cantSalida As String
    Private _costoSalida As String
    Private _valorSalida As String

    Private _cantSaldo As String
    Private _costoSaldo As String
    Private _valorSaldo As String

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _idRegistroInv
        End Get
        Set(ByVal value As String)
            _idRegistroInv = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroMovimiento() As String
        Get
            Return _nrodoc
        End Get
        Set(ByVal value As String)
            _nrodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMovimiento() As String
        Get
            Return _tipomovimiento
        End Get
        Set(ByVal value As String)
            _tipomovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantIngreso() As String
        Get
            Return _cantIngreso
        End Get
        Set(ByVal value As String)
            _cantIngreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoIngreso() As String
        Get
            Return _costoIngreso
        End Get
        Set(ByVal value As String)
            _costoIngreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorIngreso() As String
        Get
            Return _valorIngreso
        End Get
        Set(ByVal value As String)
            _valorIngreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantSalida() As String
        Get
            Return _cantSalida
        End Get
        Set(ByVal value As String)
            _cantSalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoSalida() As String
        Get
            Return _costoSalida
        End Get
        Set(ByVal value As String)
            _costoSalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorSalida() As String
        Get
            Return _valorSalida
        End Get
        Set(ByVal value As String)
            _valorSalida = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantSaldo() As String
        Get
            Return _cantSaldo
        End Get
        Set(ByVal value As String)
            _cantSaldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoSaldo() As String
        Get
            Return _costoSaldo
        End Get
        Set(ByVal value As String)
            _costoSaldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorSaldo() As String
        Get
            Return _valorSaldo
        End Get
        Set(ByVal value As String)
            _valorSaldo = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal ls_Id As String _
              , ByVal ls_NroMovimiento As String _
              , ByVal ls_Fecha As Date _
              , ByVal ls_TipoMovimiento As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_CantIngreso As String _
              , ByVal ls_CostoIngreso As String _
              , ByVal ln_ValorIngreso As String _
              , ByVal ls_CantSalida As String _
              , ByVal ls_CostoSalida As String _
              , ByVal ls_ValorSalida As String _
              , ByVal ls_CantSaldo As String _
              , ByVal ls_CostoSaldo As String _
              , ByVal ln_ValorSaldo As String _
           )
        _idRegistroInv = ls_Id
        _nrodoc = ls_NroMovimiento
        _fecha = ls_Fecha
        _tipomovimiento = ls_TipoMovimiento
        _descripcion = ls_Descripcion
        _cantIngreso = ls_CantIngreso
        _costoIngreso = ls_CostoIngreso
        _valorIngreso = ln_ValorIngreso
        _cantSalida = ls_CantSalida
        _costoSalida = ls_CostoSalida
        _valorSalida = ls_ValorSalida
        _cantSaldo = ls_CantSaldo
        _costoSaldo = ls_CostoSaldo
        _valorSaldo = ln_ValorSaldo
    End Sub

#End Region

    Public Function Obtener(ByVal inventarioValorizado As e_InventarioValorizado) As e_InventarioValorizado Implements Ie_InventarioValorizado.Obtener
        Return inventarioValorizado
    End Function

End Class
