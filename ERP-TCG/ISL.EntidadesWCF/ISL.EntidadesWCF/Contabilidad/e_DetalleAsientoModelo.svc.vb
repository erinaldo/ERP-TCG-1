<DataContract()> _
Public Class e_DetalleAsientoModelo
    Implements Ie_DetalleAsientoModelo
    Implements IEquatable(Of e_DetalleAsientoModelo)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idasientomodelo As String
    Private _asientomodelo As String
    Private _codigo As String
    Private _fila As String
    Private _nivelcuenta As Integer
    Private _idcuentacontable As String
    Private _cuentacontable As String
    Private _cuenta As String
    Private _partida As String
    Private _debe As String
    Private _haber As String
    Private _idmoneda As String
    Private _moneda As String
    Private _formula As String
    Private _titulo As String
    Private _activo As Boolean
    Private _repetir As Integer
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _usuariomodificacion As String
    Private _fechamodificacion As Date
    Private _inddocumento As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public leDMReferencia As New List(Of e_DetalleModelo_Referencia)
    <DataMember()> _
    Public IdReferencia As String = ""
    <DataMember()> _
    Public IndAnalisis As Boolean = False
    <DataMember()> _
    Public IndAgregar As Boolean = False
    <DataMember()> _
    Public IndOpcional As Boolean = False
    <DataMember()> _
    Public MontoAux As Double = 0
    <DataMember()>
    Public Ejercicio As Integer = 0
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Public oeCtaCtble As e_CuentaContable

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
    Public Property IdAsientoModelo() As String
        Get
            Return _idasientomodelo
        End Get
        Set(ByVal value As String)
            _idasientomodelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsientoModelo() As String
        Get
            Return _asientomodelo
        End Get
        Set(ByVal value As String)
            _asientomodelo = value
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
    Public Property Fila() As String
        Get
            Return _fila
        End Get
        Set(ByVal value As String)
            _fila = value
        End Set
    End Property

    <DataMember()> _
    Public Property NivelCuenta() As String
        Get
            Return _nivelcuenta
        End Get
        Set(ByVal value As String)
            _nivelcuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaContable() As String
        Get
            Return _cuentacontable
        End Get
        Set(ByVal value As String)
            _cuentacontable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Partida() As String
        Get
            Return _partida
        End Get
        Set(ByVal value As String)
            _partida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Debe() As String
        Get
            _debe = IIf(Partida = "1", Cuenta, String.Empty)
            Return _debe
        End Get
        Set(ByVal value As String)
            _debe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Haber() As String
        Get
            _haber = IIf(Partida = "2", Cuenta, String.Empty)
            Return _haber
        End Get
        Set(ByVal value As String)
            _haber = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Formula() As String
        Get
            Return _formula
        End Get
        Set(ByVal value As String)
            _formula = value
        End Set
    End Property

    <DataMember()> _
    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
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

    <DataMember()> _
    Public Property Repetir() As Integer
        Get
            Return _repetir
        End Get
        Set(ByVal value As Integer)
            _repetir = value
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
    Public Property UsuarioModificacion() As String
        Get
            Return _usuariomodificacion
        End Get
        Set(ByVal value As String)
            _usuariomodificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModificacion() As Date
        Get
            Return _fechamodificacion
        End Get
        Set(ByVal value As Date)
            _fechamodificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndDocumento() As Boolean
        Get
            Return _inddocumento
        End Get
        Set(ByVal value As Boolean)
            _inddocumento = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idasientomodelo = String.Empty
        _asientomodelo = String.Empty
        _codigo = String.Empty
        _fila = String.Empty
        _idcuentacontable = String.Empty
        _cuentacontable = String.Empty
        _cuenta = String.Empty
        _partida = String.Empty
        _idmoneda = String.Empty
        _moneda = String.Empty
        _formula = String.Empty
        _titulo = String.Empty
        _activo = True
        _nivelcuenta = 0
        _repetir = 0
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariomodificacion = String.Empty
        _fechamodificacion = #1/1/1901#
        _inddocumento = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsientoModelo As String _
              , ByVal ls_AsientoModelo As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Fila As String _
              , ByVal ln_NivelCuenta As Integer _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_CuentaContable As String _
              , ByVal ls_Cuenta As String _
              , ByVal ls_Partida As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ls_Formula As String _
              , ByVal ls_Titulo As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_Repetir As Integer _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModificacion As String _
              , ByVal ld_FechaModificacion As Date _
              , ByVal lb_IndDocumento As Boolean)
        _id = ls_Id
        _idasientomodelo = ls_IdAsientoModelo
        _asientomodelo = ls_AsientoModelo
        _codigo = ls_Codigo
        _fila = ls_Fila
        _nivelcuenta = ln_NivelCuenta
        _idcuentacontable = ls_IdCuentaContable
        _cuentacontable = ls_CuentaContable
        _cuenta = ls_Cuenta
        _partida = ls_Partida
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _formula = ls_Formula
        _titulo = ls_Titulo
        _activo = lb_Activo
        _repetir = ln_Repetir
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuariomodificacion = ls_UsuarioModificacion
        _fechamodificacion = ld_FechaModificacion
        _inddocumento = lb_IndDocumento
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(detalleasientomodelo As e_DetalleAsientoModelo) As e_DetalleAsientoModelo Implements Ie_DetalleAsientoModelo.Obtener
        Return detalleasientomodelo
    End Function

    Public Overloads Function Equals(ByVal oeDetAM As e_DetalleAsientoModelo) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_DetalleAsientoModelo).Equals
        Select Case oeDetAM.Equivale
            Case 0 : If Me.Codigo.Trim = oeDetAM.Codigo.Trim Then Return True
            Case 1 : If Me.Id.Trim = oeDetAM.Id.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
