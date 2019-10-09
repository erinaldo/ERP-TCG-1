''' <summary>
''' Clase para gestionar la clase Cliente
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Cliente
    Implements Ie_Cliente
    Implements IEquatable(Of e_Cliente)
    Implements IPropiedadesBasicas

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _tipopersonaempresa As Integer
    Private _idpersona As String
    Private _docpersona As String
    Private _idempresa As String
    Private _fechaactividad As Date
    Private _comisionista As Integer
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _Nombre As String

    <DataMember()> _
    Public TipoClienteProveedor As Integer
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public IndRelacionada As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public WithEvents oePersona As New e_Persona
    <DataMember()> _
    Public WithEvents oeEmpresa As New e_Empresa

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPersonaEmpresa() As Integer
        Get
            Return _tipopersonaempresa
        End Get
        Set(ByVal value As Integer)
            _tipopersonaempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPersona() As String
        Get
            Return _idpersona
        End Get
        Set(ByVal value As String)
            _idpersona = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As Integer
        Get
            Return _comisionista
        End Get
        Set(ByVal value As Integer)
            _comisionista = value
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
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _docpersona
        End Get
        Set(ByVal value As String)
            _docpersona = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        _tipopersonaempresa = -1
        _fechaactividad = #1/1/1901#
        _usuariocreacion = ""
        TipoOperacion = ""
        Activo = True
        TipoClienteProveedor = -1
        _comisionista = -1
        IdPersona = ""
        _Nombre = ""
        IndRelacionada = 0
    End Sub

    Public Sub New( _
              ByVal Id As String _
              , ByVal Codigo As String _
              , ByVal TipoPersonaEmpresa As Integer _
              , ByVal IdPersonaEmpresa As String _
              , ByVal Nombre As String _
              , ByVal FechaActividad As Date _
              , ByVal Comisionista As Integer _
              , ByVal UsuarioCreacion As String _
              , ByVal Activo As Boolean _
              , ByVal Dni As String _
              , ByVal ln_IndRelacionda As Integer _
            )
        _id = Id
        _codigo = Codigo
        _tipopersonaempresa = TipoPersonaEmpresa
        If TipoPersonaEmpresa = 1 Then
            _idpersona = IdPersonaEmpresa
        Else
            _idempresa = IdPersonaEmpresa
        End If
        _Nombre = Nombre
        _fechaactividad = FechaActividad
        _comisionista = Comisionista
        _usuariocreacion = UsuarioCreacion
        _activo = Activo
        _docpersona = Dni
        IndRelacionada = ln_IndRelacionda
    End Sub

    Private Sub oePersona_DatoCambiado() Handles oePersona.DatoCambio
        Modificado = True
    End Sub

    Private Sub oeEmpresa_DatoCambiado() Handles oeEmpresa.DatoCambiado
        Modificado = True
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Cliente
    ''' </summary>
    ''' <param name="cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal cliente As e_Cliente) As e_Cliente Implements Ie_Cliente.Obtener
        Return cliente
    End Function

    Public Overloads Function Equals(ByVal oeClie As e_Cliente) As Boolean Implements System.IEquatable(Of e_Cliente).Equals
        Select Case oeClie.Equivale
            Case 1 : If Me.Id.Trim = oeClie.Id.Trim Then Return True
            Case 2 : If Me.oePersona.Dni = oeClie.oePersona.Dni Then Return True
        End Select
        Return False
    End Function

#End Region

End Class


