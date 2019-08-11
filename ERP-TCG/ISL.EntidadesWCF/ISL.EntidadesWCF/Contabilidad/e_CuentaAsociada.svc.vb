<DataContract()> _
Public Class e_CuentaAsociada
    Implements Ie_CuentaAsociada
    Implements IEquatable(Of e_CuentaAsociada)

#Region "Propiedad"

    Private _id As String
    Private _idcuentacontable As String
    Private _debehaber As String
    Private _activo As Boolean
    Private _idcuentaasociada As String
    Private _IdGastoFuncion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public Property IdCuentaAsociada() As String
        Get
            Return _idcuentaasociada
        End Get
        Set(ByVal value As String)
            _idcuentaasociada = value
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
    Public Property DebeHaber() As String
        Get
            Return _debehaber
        End Get
        Set(ByVal value As String)
            _debehaber = value
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
    Public Property GastoFuncion() As String
        Get
            Return _IdGastoFuncion
        End Get
        Set(ByVal value As String)
            _IdGastoFuncion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        TipoOperacion = ""
        Id = ""
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_DebeHaber As String _
               , ByVal lb_Activo As Boolean _
               , ByVal ls_CuentaAsociada As String _
               , ByVal ls_IdGastoFuncion As String)
        _id = ls_Id
        _idcuentacontable = ls_IdCuentaContable
        _debehaber = ls_DebeHaber
        _activo = lb_Activo
        _idcuentaasociada = ls_CuentaAsociada
        _IdGastoFuncion = ls_IdGastoFuncion
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal Obj As e_CuentaAsociada) _
      As Boolean Implements IEquatable(Of e_CuentaAsociada).Equals
        If Me.IdCuentaContable = Obj.IdCuentaContable And Me.DebeHaber = Obj.DebeHaber _
        And Me.IdCuentaAsociada = Obj.IdCuentaAsociada And Me.GastoFuncion = Obj.GastoFuncion Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal cuentaAsociada As e_CuentaAsociada) As e_CuentaAsociada Implements Ie_CuentaAsociada.Obtener
        Return cuentaAsociada
    End Function

#End Region

End Class
