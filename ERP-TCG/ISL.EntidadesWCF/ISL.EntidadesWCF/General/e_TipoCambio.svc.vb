

<DataContract()> _
Public Class e_TipoCambio
    Implements Ie_TipoCambio

#Region "Propiedad"
    Private _id As String
    Private _idmonedaorigen As String
    Private _idmonedadestino As String
    Private _fechacambio As Date
    Private _cambioventa As Double
    Private _cambiocompra As Double
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMonedaOrigen() As String
        Get
            Return _idmonedaorigen
        End Get
        Set(ByVal value As String)
            _idmonedaorigen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMonedaDestino() As String
        Get
            Return _idmonedadestino
        End Get
        Set(ByVal value As String)
            _idmonedadestino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCambio() As Date
        Get
            Return _fechacambio
        End Get
        Set(ByVal value As Date)
            _fechacambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CambioVenta() As Double
        Get
            Return _cambioventa
        End Get
        Set(ByVal value As Double)
            _cambioventa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CambioCompra() As Double
        Get
            Return _cambiocompra
        End Get
        Set(ByVal value As Double)
            _cambiocompra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property


#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMonedaOrigen As String _
              , ByVal ls_IdMonedaDestino As String _
              , ByVal ld_FechaCambio As Date _
              , ByVal ln_CambioVenta As Double _
              , ByVal ln_CambioCompra As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idmonedaorigen = ls_IdMonedaOrigen
        _idmonedadestino = ls_IdMonedaDestino
        _fechacambio = ld_FechaCambio
        _cambioventa = ln_CambioVenta
        _cambiocompra = ln_CambioCompra
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal tipoCambio As e_TipoCambio) As e_TipoCambio Implements Ie_TipoCambio.Obtener
        Return tipoCambio
    End Function

End Class


