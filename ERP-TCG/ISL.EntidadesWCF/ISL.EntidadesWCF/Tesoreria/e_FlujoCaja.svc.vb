
<DataContract()> _
Public Class e_FlujoCaja
    Implements Ie_FlujoCaja
    Implements IEquatable(Of e_FlujoCaja)

#Region "Declaración de variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Abreviatura As String
    Private _Activo As Boolean
    Private _Modificado As Boolean = False
    Private _TipoOperacion As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _iditemgasto As String
    Private _indmovimiento As Integer
    Private _movimiento As String

    <DataMember()> _
    Public NombProceso As String
    <DataMember()> _
    Public IdTipoGastoDEtalle As String
    <DataMember()> _
    Public IdTipoCompra As String

    <DataMember()> _
    Public ListaCuentaFlujoCaja As New List(Of e_CuentaFlujoCaja)

    <DataMember()> _
    Public CtaContable As String
    <DataMember()> _
    Public Ejercicio As Integer
    '<DataMember()> _
    'Public CtaGastoAsociado As String
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdItemGasto() As String
        Get
            Return _iditemgasto
        End Get
        Set(ByVal value As String)
            _iditemgasto = value
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
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndMovimiento() As Integer
        Get
            Return _indmovimiento
        End Get
        Set(ByVal value As Integer)
            _indmovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Movimiento() As String
        Get
            Select Case _indmovimiento
                Case 0 : _movimiento = "INGRESO"
                Case 1 : _movimiento = "EGRESO"
            End Select
            Return _movimiento
        End Get
        Set(ByVal value As String)
            _movimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()
        _Id = String.Empty
        _Activo = True
        TipoOperacion = "N"
        IdTipoCompra = ""
    End Sub

    Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, _
            ByVal Activo As Integer, ByVal FechaCreacion As Date, ByVal UsuarioCreacion As String, _
            ByVal IdItemGasto As String, ByVal ls_CtaContable As String, ByVal ls_Ejercicio As Integer, _
            ByVal ls_IdTipoCompra As String, ln_IndMovmiento As Integer)

        _Id = Id
        _Codigo = Codigo
        _Abreviatura = Abreviatura
        _Activo = Activo
        _fechacreacion = FechaCreacion
        _usuariocreacion = UsuarioCreacion
        _iditemgasto = IdItemGasto
        CtaContable = ls_CtaContable
        Ejercicio = ls_Ejercicio
        IdTipoCompra = ls_IdTipoCompra
        _Nombre = Nombre
        _indmovimiento = ln_IndMovmiento
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal flujoCaja As e_FlujoCaja) As e_FlujoCaja Implements Ie_FlujoCaja.Obtener
        Return flujoCaja
    End Function

    Public Overloads Function Equals(ByVal FlujoCaja As e_FlujoCaja) As Boolean Implements IEquatable(Of e_FlujoCaja).Equals
        If Me.Id.Trim = FlujoCaja.Id.Trim And Me.Ejercicio = FlujoCaja.Ejercicio Then Return True
        Return False
    End Function

#End Region

End Class

