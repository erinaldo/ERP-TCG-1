<DataContract()> _
Public Class e_DetalleValorizacionNeumatico
    Implements Ie_DetalleValorizacionNeumatico

#Region "Propiedad"

    Private _id As String
    Private _valorizacion As String
    Private _vidaneumatico As String
    Private _codneumatico As String
    Private _disenio As String
    Private _marca As String
    Private _medida As String
    Private _valordolares As Double
    Private _activo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdValorizacion() As String
        Get
            Return _valorizacion
        End Get
        Set(ByVal value As String)
            _valorizacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVidaNeumatico() As String
        Get
            Return _vidaneumatico
        End Get
        Set(ByVal value As String)
            _vidaneumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNeumatico() As String
        Get
            Return _codneumatico
        End Get
        Set(ByVal value As String)
            _codneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diseño() As String
        Get
            Return _disenio
        End Get
        Set(ByVal value As String)
            _disenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorDolares() As Double
        Get
            Return _valordolares
        End Get
        Set(ByVal value As Double)
            _valordolares = value
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
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdValorizacion As String _
              , ByVal ls_IdVidaNeumatico As String _
              , ByVal ls_CodigoNeumatico As String _
              , ByVal ls_Marca As String _
              , ByVal ls_Medida As String _
              , ByVal ls_Diseño As String _
              , ByVal ld_ValorDolares As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _valorizacion = ls_IdValorizacion
        _vidaneumatico = ls_IdVidaNeumatico
        _codneumatico = ls_CodigoNeumatico
        _marca = ls_Marca
        _medida = ls_Medida
        _disenio = ls_Diseño
        _valordolares = ld_ValorDolares
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_DetalleValorizacionNeumatico
    ''' </summary>
    ''' <param name="detalleValorizacionNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal detalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As e_DetalleValorizacionNeumatico Implements Ie_DetalleValorizacionNeumatico.Obtener
        Return detalleValorizacionNeumatico
    End Function

#End Region

End Class
