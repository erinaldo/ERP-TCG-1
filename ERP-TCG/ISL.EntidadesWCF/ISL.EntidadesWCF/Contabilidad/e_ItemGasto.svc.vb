<DataContract()> _
Public Class e_ItemGasto
    Implements Ie_ItemGasto
    Implements ICloneable

#Region "Declaracion de Variables"

    Private _id As String
    Private _nombre As String
    Private _idcuentacontable As String
    Private _activo As Boolean
    Private _cuenta As String
    Private _ejercicio As Integer
    Private _IdTablaContableDet As String
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    <DataMember()> _
    Public ListaCuentaItemGasto As New List(Of e_CuentaItemGasto)

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
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
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
    Public Property Cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _ejercicio
        End Get
        Set(ByVal value As Integer)
            _ejercicio = value
        End Set
    End Property
    
    <DataMember()> _
    Public Property IdTablaContableDet() As String
        Get
            Return _IdTablaContableDet
        End Get
        Set(ByVal value As String)
            _IdTablaContableDet = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        TipoOperacion = ""
        Id = ""
        Nombre = ""
        IdCuentaContable = ""
        Ejercicio = 0
        IdTablaContableDet = ""
        UsuarioCrea = ""
        FechaCrea = Now.Date
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Cuenta As String _
              , ByVal ls_Ejercicio As Integer _
              , ByVal ls_IdTablaContableDet As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date)
        _cuenta = ls_Cuenta
        _id = ls_Id
        _nombre = ls_Nombre
        _idcuentacontable = ls_IdCuentaContable
        _activo = lb_Activo
        Ejercicio = ls_Ejercicio
        _IdTablaContableDet = ls_IdTablaContableDet
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
    End Sub

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function Obtener(ByVal itemGasto As e_ItemGasto) As e_ItemGasto Implements Ie_ItemGasto.Obtener
        Return itemGasto
    End Function

#End Region

End Class
