<DataContract()> _
Public Class e_CuentaItemGasto
    Implements Ie_CuentaItemGasto
    Implements IEquatable(Of e_CuentaItemGasto)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idcuentacontable As String
    Private _iditemgasto As String
    Private _ejercicio As Integer
    Private _cuenta As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
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
    Public Property IdItemGasto() As String
        Get
            Return _iditemgasto
        End Get
        Set(ByVal value As String)
            _iditemgasto = value
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
        Activo = True
        TipoOperacion = String.Empty
        Equivale = 0
        Id = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_IdItemGasto As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal ln_Cuenta As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idcuentacontable = ls_IdCuentaContable
        _iditemgasto = ls_IdItemGasto
        _ejercicio = ln_Ejercicio
        _cuenta = ln_Cuenta
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal cuentaItemGasto As e_CuentaItemGasto) As e_CuentaItemGasto Implements Ie_CuentaItemGasto.Obtener
        Return cuentaItemGasto
    End Function

    Public Overloads Function Equals(ByVal oeCCIG As e_CuentaItemGasto) As Boolean Implements System.IEquatable(Of e_CuentaItemGasto).Equals
        Select Case oeCCIG.Equivale
            Case 0 : If Me.Id = oeCCIG.Id Then Return True
            Case 1 : If Me.IdCuentaContable = oeCCIG.IdCuentaContable Then Return True
            Case 2 : If Me.Ejercicio = oeCCIG.Ejercicio Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
