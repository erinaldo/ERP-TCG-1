<DataContract()> _
Public Class e_AsientoModelo_Referencia
    Implements Ie_AsientoModelo_Referencia
    Implements IEquatable(Of e_AsientoModelo_Referencia)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idasimod_actneg As String
    Private _tiporeferencia As Integer
    Private _referencia As String
    Private _idreferencia As String
    Private _nombre As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdActividad As String
    <DataMember()> _
    Public Cant As Integer
    <DataMember()> _
    Public Equivale As Integer
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
    Public Property IdAsiMod_ActNeg() As String
        Get
            Return _idasimod_actneg
        End Get
        Set(ByVal value As String)
            _idasimod_actneg = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As Integer
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As Integer)
            _tiporeferencia = value
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
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
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

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idasimod_actneg = String.Empty
        _tiporeferencia = -1
        _referencia = String.Empty
        _idreferencia = String.Empty
        _nombre = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariomodifica = String.Empty
        _fechamodifica = #1/1/1901#
        _activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String, ByVal ls_Referencia As String, ByVal ln_TipoReferencia As Integer)
        _id = ls_Id
        _referencia = ls_Referencia
        _tiporeferencia = ln_TipoReferencia
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsiMod_ActNeg As String _
              , ByVal ln_TipoReferencia As Integer _
              , ByVal ls_Referencia As String _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdActividad As String _
           )
        _id = ls_Id
        _idasimod_actneg = ls_IdAsiMod_ActNeg
        _tiporeferencia = ln_TipoReferencia
        _referencia = ls_Referencia
        _idreferencia = ls_IdReferencia
        _nombre = ls_Nombre
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _activo = lb_Activo
        IdActividad = ls_IdActividad
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(asientomodeloreferencia As e_AsientoModelo_Referencia) As e_AsientoModelo_Referencia Implements Ie_AsientoModelo_Referencia.Obtener
        Return asientomodeloreferencia
    End Function

    Public Overloads Function Equals(ByVal oeRef As e_AsientoModelo_Referencia) As Boolean Implements System.IEquatable(Of e_AsientoModelo_Referencia).Equals
        Select Case oeRef.Equivale
            Case 0 : If Me.Id = oeRef.Id Then Return True
            Case 1 : If Me.TipoReferencia = oeRef.TipoReferencia And Me.IdReferencia = oeRef.IdReferencia Then Return True
            Case 2 : If Me.TipoReferencia = oeRef.TipoReferencia And Me.Referencia.Trim = oeRef.Referencia.Trim Then Return True
            Case 3 : If Me.TipoReferencia = oeRef.TipoReferencia And Me.Nombre.Trim = oeRef.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
