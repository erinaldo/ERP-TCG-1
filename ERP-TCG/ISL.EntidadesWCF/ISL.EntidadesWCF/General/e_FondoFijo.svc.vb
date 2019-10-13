

<DataContract()> _
Public Class e_FondoFijo
    Implements Ie_FondoFijo

#Region "Propiedad"

    Private _id As String
    Private _fondofijo As Double
    Private _glosa As String
    Private _fecha As Date
    Private _activo As Integer
    Private _usuariocreacion As String
    Private _fechacreacion As Date

    <DataMember()> _
    Public Modificado As Boolean = False
    <DataMember()> _
    Public TipoOperacion As String
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
    Public Property FondoFijo() As Double
        Get
            Return _fondofijo
        End Get
        Set(ByVal value As Double)
            _fondofijo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Integer
        Get
            Return _activo
        End Get
        Set(ByVal value As Integer)
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        _fecha = #1/1/1901#
        _activo = 1
        _id = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ln_FondoFijo As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_Activo As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _fondofijo = ln_FondoFijo
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _activo = ln_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal fondoFijo As e_FondoFijo) As e_FondoFijo Implements Ie_FondoFijo.Obtener
        Return fondoFijo
    End Function

End Class


