

<DataContract()> _
Public Class e_ControlCargaVehiculoES
    Implements Ie_ControlCargaVehiculoES

#Region "Propiedad"

    Private _id As String
    Private _idvehiculoes As String
    Private _placa As String
    Private _indisl As Integer
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
    Public Property IdVehiculoES() As String
        Get
            Return _idvehiculoes
        End Get
        Set(ByVal value As String)
            _idvehiculoes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndIsl() As Integer
        Get
            Return _indisl
        End Get
        Set(ByVal value As Integer)
            _indisl = value
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
              , ByVal ls_IdVehiculoES As String _
              , ByVal ls_Placa As String _
              , ByVal ln_IndIsl As Integer _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idvehiculoes = ls_IdVehiculoES
        _placa = ls_Placa
        _indisl = ln_IndIsl
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ControlCargaVehiculoES
    ''' </summary>
    ''' <param name="controlCargaVehiculoES"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal controlCargaVehiculoES As e_ControlCargaVehiculoES) As e_ControlCargaVehiculoES Implements Ie_ControlCargaVehiculoES.Obtener
        Return controlCargaVehiculoES
    End Function

#End Region

End Class



