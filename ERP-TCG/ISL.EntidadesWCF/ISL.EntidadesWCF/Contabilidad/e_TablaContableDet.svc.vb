<DataContract()> _
Public Class e_TablaContableDet
    Implements Ie_TablaContableDet
    Implements ICloneable

#Region "Propiedad"

    Private _id As String
    Private _idtabla As String
    Private _nombre As String
    Private _texto1 As String
    Private _texto2 As String
    Private _texto3 As String
    Private _valor1 As Double
    Private _valor2 As Double
    Private _valor3 As Double
    Private _logico1 As Boolean
    Private _logico2 As Boolean
    Private _logico3 As Boolean
    Private _activo As Boolean
    Private _IndTablaContable As Integer
    Private _IdTablaContableDet As String


    <DataMember()> _
    Public ListaTipoCompra As New List(Of e_TipoCompra)
    <DataMember()> _
    Public ListaTipoVenta As New List(Of e_TipoVenta)
    <DataMember()> _
    Public ListaCuentasGenerales As New List(Of e_CuentasGenerales)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

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
    Public Property IdTabla() As String
        Get
            Return _idtabla
        End Get
        Set(ByVal value As String)
            _idtabla = value
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
    Public Property Texto1() As String
        Get
            Return _texto1
        End Get
        Set(ByVal value As String)
            _texto1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto2() As String
        Get
            Return _texto2
        End Get
        Set(ByVal value As String)
            _texto2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Texto3() As String
        Get
            Return _texto3
        End Get
        Set(ByVal value As String)
            _texto3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor1() As Double
        Get
            Return _valor1
        End Get
        Set(ByVal value As Double)
            _valor1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor2() As Double
        Get
            Return _valor2
        End Get
        Set(ByVal value As Double)
            _valor2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Valor3() As Double
        Get
            Return _valor3
        End Get
        Set(ByVal value As Double)
            _valor3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico1() As Boolean
        Get
            Return _logico1
        End Get
        Set(ByVal value As Boolean)
            _logico1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico2() As Boolean
        Get
            Return _logico2
        End Get
        Set(ByVal value As Boolean)
            _logico2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Logico3() As Boolean
        Get
            Return _logico3
        End Get
        Set(ByVal value As Boolean)
            _logico3 = value
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
    Public Property IndTablaContable() As Integer
        Get
            Return _IndTablaContable
        End Get
        Set(ByVal value As Integer)
            _IndTablaContable = value
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

#End Region

#Region "Constructor"
    Public Sub New()
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTabla As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Texto1 As String _
              , ByVal ls_Texto2 As String _
              , ByVal ls_Texto3 As String _
              , ByVal ln_Valor1 As Double _
              , ByVal ln_Valor2 As Double _
              , ByVal ln_Valor3 As Double _
              , ByVal lb_Logico1 As Boolean _
              , ByVal lb_Logico2 As Boolean _
              , ByVal lb_Logico3 As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal li_IndTablaContable As Integer _
              , ByVal ls_IdTablaContableDet As String)
        _id = ls_Id
        _idtabla = ls_IdTabla
        _nombre = ls_Nombre
        _texto1 = ls_Texto1
        _texto2 = ls_Texto2
        _texto3 = ls_Texto3
        _valor1 = ln_Valor1
        _valor2 = ln_Valor2
        _valor3 = ln_Valor3
        _logico1 = lb_Logico1
        _logico2 = lb_Logico2
        _logico3 = lb_Logico3
        _activo = lb_Activo
        _IndTablaContable = li_IndTablaContable
        _IdTablaContableDet = ls_IdTablaContableDet
    End Sub

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Function Obtener(ByVal tablaContableDet As e_TablaContableDet) As e_TablaContableDet Implements Ie_TablaContableDet.Obtener
        Return tablaContableDet
    End Function

#End Region

End Class
