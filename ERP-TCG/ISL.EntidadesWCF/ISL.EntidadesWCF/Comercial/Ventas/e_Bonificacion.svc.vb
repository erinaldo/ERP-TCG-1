<DataContract()> _
Public Class e_Bonificacion
    Implements Ie_Bonificacion

#Region "Variables"

    <DataMember()> _
    Public TipoOperacion As String
    Private _Id As String
    Private _IdVehiculo As String
    Private _Numero As Integer
    Private _Porcentaje As Integer
    Private _IndBonificacion As Integer
    Private _Observacion As String
    Private _Activo As Boolean

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Propiedades"

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
    Public Property IdVehiculo() As String
        Get
            Return _IdVehiculo
        End Get
        Set(ByVal value As String)
            _IdVehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property Porcentaje() As Integer
        Get
            Return _Porcentaje
        End Get
        Set(ByVal value As Integer)
            _Porcentaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndBonificacion() As Integer
        Get
            Return _IndBonificacion
        End Get
        Set(ByVal value As Integer)
            _IndBonificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
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

#End Region

#Region "Contructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        IdVehiculo = ""
        Numero = 0
        Porcentaje = 0
        IndBonificacion = 0
        Observacion = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_id As String, _
                   ByVal ls_idVehiculo As String, _
                   ByVal li_numero As Integer, _
                   ByVal li_porcentaje As Integer, _
                   ByVal li_indBonificacion As Integer, _
                   ByVal ls_observacion As String, _
                   ByVal lb_activo As Boolean)
        _Id = ls_id
        _IdVehiculo = ls_idVehiculo
        _Numero = li_numero
        _Porcentaje = li_porcentaje
        _IndBonificacion = li_indBonificacion
        _Observacion = ls_observacion
        _Activo = lb_activo
    End Sub


#End Region

#Region "Métodos"

    Public Function Obtener(ByVal Bonificacion As e_Bonificacion) As e_Bonificacion Implements Ie_Bonificacion.Obtener
        Return Bonificacion
    End Function

#End Region

End Class


