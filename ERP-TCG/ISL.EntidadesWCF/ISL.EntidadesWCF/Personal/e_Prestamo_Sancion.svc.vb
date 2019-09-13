


<DataContract()> _
Public Class e_Prestamo_Sancion
    Implements Ie_Prestamo_Sancion

#Region "Declaracion de Variable"

    Private _id As String
    Private _idsancion As String
    Private _idprestamo As String
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Tipo As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdSancion() As String
        Get
            Return _idsancion
        End Get
        Set(ByVal value As String)
            _idsancion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPrestamo() As String
        Get
            Return _idprestamo
        End Get
        Set(ByVal value As String)
            _idprestamo = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
        _id = String.Empty
        _idsancion = String.Empty
        _idprestamo = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        Tipo = 0
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdSancion As String _
              , ByVal ls_IdPrestamo As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_Tipo As Integer _
           )
        _id = ls_Id
        _idsancion = ls_IdSancion
        _idprestamo = ls_IdPrestamo
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        Tipo = ln_Tipo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal prestamo_sancion As e_Prestamo_Sancion) As e_Prestamo_Sancion Implements Ie_Prestamo_Sancion.Obtener
        Return prestamo_sancion
    End Function

#End Region

End Class

