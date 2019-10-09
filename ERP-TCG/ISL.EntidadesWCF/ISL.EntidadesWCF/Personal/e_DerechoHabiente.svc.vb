<DataContract()> _
Public Class e_DerechoHabiente
    Implements Ie_DerechoHabiente
    Implements IEquatable(Of e_DerechoHabiente)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _idpersona As String
    Private _indvinculo As String
    Private _tipodocacredita As String
    Private _nrodocumentoacredita As String
    Private _mesconcepcion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TipoBuscar As Integer
    <DataMember()> _
    Public NroLinea As Integer = 0
    <DataMember()>
    Public oePersona As New e_Persona
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
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
    Public Property IndVinculo() As String
        Get
            Return _indvinculo
        End Get
        Set(ByVal value As String)
            _indvinculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocAcredita() As String
        Get
            Return _tipodocacredita
        End Get
        Set(ByVal value As String)
            _tipodocacredita = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDocumentoAcredita() As String
        Get
            Return _nrodocumentoacredita
        End Get
        Set(ByVal value As String)
            _nrodocumentoacredita = value
        End Set
    End Property

    <DataMember()> _
    Public Property MesConcepcion() As String
        Get
            Return _mesconcepcion
        End Get
        Set(ByVal value As String)
            _mesconcepcion = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _idpersona = String.Empty
        _indvinculo = String.Empty
        _tipodocacredita = String.Empty
        _nrodocumentoacredita = String.Empty
        _mesconcepcion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String, _
                   ByVal ls_IdTrabajador As String, _
                   ByVal ls_IdPersona As String, _
                   ByVal ls_Dni As String, _
                   ByVal ls_ApellidoPaterno As String, _
                   ByVal ls_ApellidoMaterno As String, _
                   ByVal ls_Nombres As String, _
                   ByVal _Sexo As e_Sexo, _
                   ByVal ld_FechaNacimiento As Date, _
                   ByVal ls_IndVinculo As String, _
                   ByVal ls_TipoDocAcredita As String, _
                   ByVal ls_NroDocumentoAcredita As String, _
                   ByVal ls_MesConcepcion As String, _
                   ByVal ld_FechaCreacion As Date, _
                   ByVal ls_UsuarioCreacion As String, _
                   ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _idpersona = ls_IdPersona
        _indvinculo = ls_IndVinculo
        _tipodocacredita = ls_TipoDocAcredita
        _nrodocumentoacredita = ls_NroDocumentoAcredita
        _mesconcepcion = ls_MesConcepcion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo

        oePersona.Id = ls_IdPersona
        oePersona.Dni = ls_Dni
        oePersona.ApellidoPaterno = ls_ApellidoPaterno
        oePersona.ApellidoMaterno = ls_ApellidoMaterno
        oePersona.Nombre = ls_Nombres
        oePersona.oeSexo.Id = _Sexo.Id
        oePersona.oeSexo.Nombre = _Sexo.Nombre
        oePersona.FechaNacimiento = ld_FechaNacimiento

    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDerechoHabiente As e_DerechoHabiente) As e_DerechoHabiente Implements Ie_DerechoHabiente.obtener
        Return oeDerechoHabiente
    End Function

    Public Overloads Function Equals(ByVal oeDerHab As e_DerechoHabiente) As Boolean Implements System.IEquatable(Of e_DerechoHabiente).Equals
        Select Case oeDerHab.TipoBuscar
            Case 1 : If Me.oePersona.Dni = oeDerHab.oePersona.Dni Then Return True
            Case 2 : If Me.NroLinea = oeDerHab.NroLinea Then Return True
            Case 3 : If Me.NroLinea <> oeDerHab.NroLinea And Me.oePersona.Dni = oePersona.Dni Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
