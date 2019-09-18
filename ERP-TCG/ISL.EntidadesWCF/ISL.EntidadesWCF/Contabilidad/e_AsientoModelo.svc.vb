<DataContract()>
Public Class e_AsientoModelo
    Implements Ie_AsientoModelo
    Implements IEquatable(Of e_AsientoModelo)

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _idmoneda As String
    Private _moneda As String
    Private _cuentas As Integer
    Private _idtipoasiento As String
    Private _tipoasiento As String
    Private _idvinculado As String
    Private _fila As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _usuariomodificacion As String
    Private _fechamodificacion As Date
    Private _activo As Boolean

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public leDetalle As New List(Of e_DetalleAsientoModelo)
    <DataMember()>
    Public leAMActiviad As New List(Of e_AsientoModelo_ActividadNegocio)
    <DataMember()>
    Public leAMReferencia As New List(Of e_AsientoModelo_Referencia)
    <DataMember()>
    Public leDMReferencia As New List(Of e_DetalleModelo_Referencia)
    <DataMember()>
    Public TipoCambio As Double
    <DataMember()>
    Public IdMedioPago As String
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public Tipo As Integer
    <DataMember()>
    Public IdPeriodo As String
    <DataMember()>
    Public FechaMov As Date
    <DataMember()>
    Public IndVinculado As Boolean = False
    <DataMember()>
    Public Ejercicio As Integer = 0
    <DataMember()>
    Public PrefijoID As String = ""

    Public TipoBusca As Integer
    Public CargaCompleta As Boolean

#End Region

#Region "Propiedades"

    <DataMember()>
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()>
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()>
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()>
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    <DataMember()>
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()>
    Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    <DataMember()>
    Public Property Cuentas() As Integer
        Get
            Return _cuentas
        End Get
        Set(ByVal value As Integer)
            _cuentas = value
        End Set
    End Property

    <DataMember()>
    Public Property IdTipoAsiento() As String
        Get
            Return _idtipoasiento
        End Get
        Set(ByVal value As String)
            _idtipoasiento = value
        End Set
    End Property

    <DataMember()>
    Public Property TipoAsiento() As String
        Get
            Return _tipoasiento
        End Get
        Set(ByVal value As String)
            _tipoasiento = value
        End Set
    End Property

    <DataMember()>
    Public Property IdVinculado() As String
        Get
            Return _idvinculado
        End Get
        Set(ByVal value As String)
            _idvinculado = value
        End Set
    End Property

    <DataMember()>
    Public Property Fila() As String
        Get
            Return _fila
        End Get
        Set(ByVal value As String)
            _fila = value
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()>
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()>
    Public Property UsuarioModificacion() As String
        Get
            Return _usuariomodificacion
        End Get
        Set(ByVal value As String)
            _usuariomodificacion = value
        End Set
    End Property

    <DataMember()>
    Public Property FechaModificacion() As Date
        Get
            Return _fechamodificacion
        End Get
        Set(ByVal value As Date)
            _fechamodificacion = value
        End Set
    End Property

    <DataMember()>
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
        _codigo = String.Empty
        _nombre = String.Empty
        _abreviatura = String.Empty
        _idmoneda = String.Empty
        _moneda = String.Empty
        _cuentas = 0
        _idvinculado = String.Empty
        _fila = String.Empty
        _usuariocreacion = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariomodificacion = String.Empty
        _fechamodificacion = #1/1/1901#
        Activo = True
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ln_Cuentas As Integer _
              , ByVal ls_IdTipoAsiento As String _
              , ByVal ls_TipoAsiento As String _
              , ByVal ls_IdVinculado As String _
              , ByVal ls_Fila As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModificacion As String _
              , ByVal ld_FechaModificacion As Date _
              , ByVal lb_Activo As Boolean
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _cuentas = ln_Cuentas
        _idtipoasiento = ls_IdTipoAsiento
        _tipoasiento = ls_TipoAsiento
        _idvinculado = ls_IdVinculado
        _fila = ls_Fila
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _usuariomodificacion = ls_UsuarioModificacion
        _fechamodificacion = ld_FechaModificacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(asientomodelo As e_AsientoModelo) As e_AsientoModelo Implements Ie_AsientoModelo.Obtener
        Return asientomodelo
    End Function

    Public Overloads Function Equals(ByVal oeAM As e_AsientoModelo) As Boolean Implements System.IEquatable(Of e_AsientoModelo).Equals
        Select Case oeAM.Equivale
            Case 0 : If Me.Id = oeAM.Id Then Return True
            Case 1 : If Me.IdMoneda = oeAM.IdMoneda Then Return True
            Case 2 : If Me.Id = oeAM.Id And Me.IdMoneda = oeAM.IdMoneda Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
