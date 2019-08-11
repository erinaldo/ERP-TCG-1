
<DataContract()> _
Public Class e_Auditoria
    Implements Ie_Auditoria

#Region "Declaracion de Variables"

    Private _id As String
    Private _idactividadnegocio As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _operacion As String
    Private _idreferencia As String
    Private _codigo As String
    Private _referencia As String
    Private _macpc As String

    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Propiedades"

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
    Public Property IdActividadNegocio() As String
        Get
            Return _idactividadnegocio
        End Get
        Set(ByVal value As String)
            _idactividadnegocio = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Operacion() As String
        Get
            Return _operacion
        End Get
        Set(ByVal value As String)
            _operacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal value As String)
            _referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property MacPc() As String
        Get
            Return _macpc
        End Get
        Set(ByVal value As String)
            _macpc = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idactividadnegocio = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _operacion = String.Empty
        _idreferencia = String.Empty
        _codigo = String.Empty
        _referencia = String.Empty
        _macpc = String.Empty
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdActividadNegocio As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_Operacion As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Referencia As String _
              , ByVal ls_MacPc As String _
           )
        _id = ls_Id
        _idactividadnegocio = ls_IdActividadNegocio
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _operacion = ls_Operacion
        _idreferencia = ls_IdReferencia
        _codigo = ls_Codigo
        _referencia = ls_Referencia
        _macpc = ls_MacPc
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Formulario
    ''' </summary>
    ''' <param name="auditoria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal auditoria As e_Auditoria) As e_Auditoria Implements Ie_Auditoria.Obtener
        Return auditoria
    End Function

#End Region

End Class
