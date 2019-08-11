

<DataContract()> _
Public Class e_ActividadNegocio
    Implements Ie_ActividadNegocio

#Region "Declaracion de Variables"

    Private _id As String
    Private _idprocesonegocio As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _activo As Boolean
    Private _fechacreacion As DateTime
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
            _idprocesonegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As DateTime
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As DateTime)
            '_fechacreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _nombre = ""
        _abreviatura = ""
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idprocesonegocio = ls_IdProcesoNegocio
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ActividadNegocio
    ''' </summary>
    ''' <param name="actividadNegocio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal actividadNegocio As e_ActividadNegocio) As e_ActividadNegocio Implements Ie_ActividadNegocio.Obtener
        Return actividadNegocio
    End Function

#End Region

End Class


