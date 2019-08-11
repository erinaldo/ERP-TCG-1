

<DataContract()> _
Public Class e_GuiasTalonarios
    Implements Ie_GuiasTalonarios

#Region "Propiedad"

    Private _id As String
    Private _idguiascontrol As String
    Private _inicial As String
    Private _final As String
    Private _fechaingreso As Date
    Private _anulado As Integer
    Private _terminado As Integer
    Private _observacion As String
    Private _activo As Boolean

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
    Public Property IdGuiasControl() As String
        Get
            Return _idguiascontrol
        End Get
        Set(ByVal value As String)
            _idguiascontrol = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Inicial() As String
        Get
            Return _inicial
        End Get
        Set(ByVal value As String)
            _inicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Final() As String
        Get
            Return _final
        End Get
        Set(ByVal value As String)
            _final = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Anulado() As Integer
        Get
            Return _anulado
        End Get
        Set(ByVal value As Integer)
            _anulado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Terminado() As Integer
        Get
            Return _terminado
        End Get
        Set(ByVal value As Integer)
            _terminado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
              , ByVal ls_IdGuiasControl As String _
              , ByVal ls_Inicial As String _
              , ByVal ls_Final As String _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ln_Anulado As Integer _
              , ByVal ln_Terminado As Integer _
              , ByVal ls_Observacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idguiascontrol = ls_IdGuiasControl
        _inicial = ls_Inicial
        _final = ls_Final
        _fechaingreso = ld_FechaIngreso
        _anulado = ln_Anulado
        _terminado = ln_Terminado
        _observacion = ls_Observacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal guiasTalonarios As e_GuiasTalonarios) As e_GuiasTalonarios Implements Ie_GuiasTalonarios.Obtener
        Return guiasTalonarios
    End Function

End Class


