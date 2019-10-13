
<DataContract()> _
Public Class e_Placa
    Implements Ie_Placa

#Region "Variables"

    Private _id As String
    Private _nombre As String
    Private _Actual As Boolean
    Private _fechainicio As Date
    Private _idvehiculo As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Actual() As Boolean
        Get
            Return _Actual
        End Get
        Set(ByVal value As Boolean)
            _Actual = value
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
        TipoOperacion = ""
        Id = ""
        Nombre = ""
        FechaInicio = #1/1/1901#
        IdVehiculo = ""
        Actual = False
        Activo = True
        'Variables
        Modificado = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaInicio As Date _
              , ByVal ls_IdVehiculo As String _
                , ByVal lb_Actual As Boolean)
        _id = ls_Id
        _nombre = ls_Nombre
        _activo = lb_Activo
        _fechainicio = ld_FechaInicio
        _idvehiculo = ls_IdVehiculo
        _Actual = lb_Actual
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal placa As e_Placa) As e_Placa Implements Ie_Placa.Obtener
        Return placa
    End Function

#End Region
    
End Class


