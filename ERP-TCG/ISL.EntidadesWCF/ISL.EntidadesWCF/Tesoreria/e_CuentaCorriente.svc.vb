<DataContract()> _
Public Class e_CuentaCorriente
    Implements Ie_CuentaCorriente
    Implements IEquatable(Of e_CuentaCorriente)

#Region "Declaración de variables"

    Private _id As String
    Private _idtrabajador As String
    Private _Trabajador As String
    Private _Codigo As String
    Private _idmoneda As String
    Private _NombreMoneda As String
    Private _glosa As String
    Private _saldo As Double
    Private _usuariocreacion As String
    Private _idestado As String
    Private _estado As String
    Private _Activo As Boolean

    Private _Tipo As Integer
    Private _TipoCuenta As String
    <DataMember()> _
    Public Tipooperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Private _TotalCargo As Double
    Private _TotalAbono As Double
    Private _Ejercicio As Integer

    Public Equivale As String = ""

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
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
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
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreMoneda() As String
        Get
            Return _NombreMoneda
        End Get
        Set(ByVal value As String)
            _NombreMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCuenta() As String
        Get
            Return _TipoCuenta
        End Get
        Set(ByVal value As String)
            _TipoCuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalCargo() As Double
        Get
            Return _TotalCargo
        End Get
        Set(ByVal value As Double)
            _TotalCargo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalAbono() As Double
        Get
            Return _TotalAbono
        End Get
        Set(ByVal value As Double)
            _TotalAbono = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Double
        Get
            Return _Ejercicio
        End Get
        Set(ByVal value As Double)
            _Ejercicio = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Public Sub New()
        _id = ""
        _idtrabajador = ""
        _Codigo = ""
        _idmoneda = ""
        _idestado = ""
        _estado = ""
        _saldo = 0
        _glosa = ""
        _idestado = ""
        _Activo = True
        _Tipo = -1
        _TipoCuenta = ""
        Tipooperacion = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_IdTrabajador As String _
                  , ByVal ls_Codigo As String _
                  , ByVal ls_Trabajador As String _
                  , ByVal ls_IdMoneda As String _
                  , ByVal ls_NombreMoneda As String _
                  , ByVal ld_Saldo As Double _
                  , ByVal ls_Glosa As String _
                  , ByVal ls_UsuarioCreacion As String _
                  , ByVal ls_IdEstado As String _
                  , ByVal ls_Estado As String _
                  , ByVal lb_Activo As Boolean _
                  , ByVal ls_Tipo As Integer _
                  , ByVal ls_TipoCuenta As String _
                  , ByVal ld_TotalCargo As Double _
                  , ByVal ld_TotalAbono As Double _
                  , ByVal li_Ejercicio As Integer)
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _Codigo = ls_Codigo
        _Trabajador = ls_Trabajador
        _idmoneda = ls_IdMoneda
        _NombreMoneda = ls_NombreMoneda
        _saldo = ld_Saldo
        _glosa = ls_Glosa
        _usuariocreacion = ls_UsuarioCreacion
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _Activo = lb_Activo
        _Tipo = ls_Tipo
        _TipoCuenta = ls_TipoCuenta
        _TotalCargo = ld_TotalCargo
        _TotalAbono = ld_TotalAbono
        _Ejercicio = li_Ejercicio
    End Sub
#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeCuentaCorriente As e_CuentaCorriente) _
    As Boolean Implements System.IEquatable(Of e_CuentaCorriente).Equals
        If Me.IdTrabajador = oeCuentaCorriente.IdTrabajador And Me.Tipo = oeCuentaCorriente.Tipo Then Return True
        Return False
    End Function

    Public Function Obtener(ByVal cuentaCorriente As e_CuentaCorriente) As e_CuentaCorriente Implements Ie_CuentaCorriente.Obtener
        Return cuentaCorriente
    End Function

#End Region

End Class
