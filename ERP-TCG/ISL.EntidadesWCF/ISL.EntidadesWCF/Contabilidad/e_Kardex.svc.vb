<DataContract()> _
Public Class e_Kardex
    Implements Ie_Kardex
    'Implements ICloneable

#Region "Propiedad"

    Private _id As String
    Private _idperiodo As String
    Private _idcuentacontable As String
    Private _idsubalmacen As String
    Private _total As Double
    Private _idusuariocreacion As String
    Private _fechacreacion As Date
    Private _idperiodosgt As String
    Private _activo As Boolean

    Public TipoOperacion As String
    Public Modificado As Boolean

    <DataMember()> _
    Public Año As Integer
    <DataMember()> _
    Public Mes As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

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
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
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
    Public Property IdSubAlmacen() As String
        Get
            Return _idsubalmacen
        End Get
        Set(ByVal value As String)
            _idsubalmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioCreacion() As String
        Get
            Return _idusuariocreacion
        End Get
        Set(ByVal value As String)
            _idusuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodoSgt() As String
        Get
            Return _idperiodosgt
        End Get
        Set(ByVal value As String)
            _idperiodosgt = value
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
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ln_Total As Double _
              , ByVal ls_IdUsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_IdPeriodoSgt As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idperiodo = ls_IdPeriodo
        _idcuentacontable = ls_IdCuentaContable
        _total = ln_Total
        _idusuariocreacion = ls_IdUsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _idperiodosgt = ls_IdPeriodoSgt
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal Kardex As e_Kardex) As e_Kardex Implements Ie_Kardex.Obtener
        Return Kardex
    End Function

End Class
