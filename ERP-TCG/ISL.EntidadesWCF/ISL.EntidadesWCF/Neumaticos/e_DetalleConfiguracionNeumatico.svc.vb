<DataContract()> _
Public Class e_DetalleConfiguracionNeumatico
    Implements Ie_DetalleConfiguracionNeumatico

#Region "Propiedad"

    Private _id As String
    Private _configuracionneumatico As String
    Private _nrolineaeje As Integer
    Private _cantidadllantas As Integer
    Private _indtraccion As Boolean
    Private _activo As Boolean
    Private _usuariocreacion As String

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
    Public Property IdConfiguracionNeumatico() As String
        Get
            Return _configuracionneumatico
        End Get
        Set(ByVal value As String)
            _configuracionneumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroLineaEje() As Integer
        Get
            Return _nrolineaeje
        End Get
        Set(ByVal value As Integer)
            _nrolineaeje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadLlantas() As Integer
        Get
            Return _cantidadllantas
        End Get
        Set(ByVal value As Integer)
            _cantidadllantas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndTraccion() As Boolean
        Get
            Return _indtraccion
        End Get
        Set(ByVal value As Boolean)
            _indtraccion = value
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

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
              , ByVal ln_IdConfiguracionNeumatico As String _
              , ByVal ln_NroLineaEje As Integer _
              , ByVal ln_CantidadLlantas As Integer _
              , ByVal lb_IndTraccion As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _configuracionneumatico = ln_IdConfiguracionNeumatico
        _nrolineaeje = ln_NroLineaEje
        _cantidadllantas = ln_CantidadLlantas
        _indtraccion = lb_IndTraccion
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_DetalleConfiguracionNeumatico
    ''' </summary>
    ''' <param name="detalleConfiguracionNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal detalleConfiguracionNeumatico As e_DetalleConfiguracionNeumatico) As e_DetalleConfiguracionNeumatico Implements Ie_DetalleConfiguracionNeumatico.Obtener
        Return detalleConfiguracionNeumatico
    End Function

#End Region

End Class
