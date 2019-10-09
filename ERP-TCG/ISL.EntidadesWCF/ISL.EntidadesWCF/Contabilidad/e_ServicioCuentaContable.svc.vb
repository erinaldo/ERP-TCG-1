<DataContract()> _
Public Class e_ServicioCuentaContable
    Implements Ie_ServicioCuentaContable
    Implements IEquatable(Of e_ServicioCuentaContable)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idservicio As String
    Private _idcuentacontablehaber As String
    Private _idcuentacontabledebe As String
    Private _ejercicio As Integer
    Private _activo As Boolean
    Private _cuentadebe As String
    Private _cuentahaber As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdServicio() As String
        Get
            Return _idservicio
        End Get
        Set(ByVal value As String)
            _idservicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContableHaber() As String
        Get
            Return _idcuentacontablehaber
        End Get
        Set(ByVal value As String)
            _idcuentacontablehaber = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaContableDebe() As String
        Get
            Return _idcuentacontabledebe
        End Get
        Set(ByVal value As String)
            _idcuentacontabledebe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaHaber() As String
        Get
            Return _cuentahaber
        End Get
        Set(ByVal value As String)
            _cuentahaber = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaDebe() As String
        Get
            Return _cuentadebe
        End Get
        Set(ByVal value As String)
            _cuentadebe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _ejercicio
        End Get
        Set(ByVal value As Integer)
            _ejercicio = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdServicio As String _
              , ByVal ls_IdCuentaContableHaber As String _
              , ByVal ls_IdCuentaContableDebe As String _
              , ByVal ln_Ejercicio As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_CuentaHaber As String _
              , ByVal ls_CuentaDebe As String _
           )
        _id = ls_Id
        _idservicio = ls_IdServicio
        _idcuentacontablehaber = ls_IdCuentaContableHaber
        _idcuentacontabledebe = ls_IdCuentaContableDebe
        _ejercicio = ln_Ejercicio
        _activo = lb_Activo
        _cuentadebe = ls_CuentaDebe
        _cuentahaber = ls_CuentaHaber
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal servicioCuentaContable As e_ServicioCuentaContable) As e_ServicioCuentaContable Implements Ie_ServicioCuentaContable.Obtener
        Return servicioCuentaContable
    End Function

    Public Overloads Function Equals(ByVal oeSCC As e_ServicioCuentaContable) As Boolean Implements System.IEquatable(Of e_ServicioCuentaContable).Equals
        Select Case oeSCC.Equivale
            Case 0 : If Me.Id = oeSCC.Id Then Return True
            Case 1 : If Me.IdServicio.Trim = oeSCC.IdServicio.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
