

<DataContract()> _
Public Class e_Leasing
    Implements Ie_Leasing

#Region "Propiedad"
    Private _id As String
    Private _idproveedor As String
    Private _fechainicio As Date
    Private _idmoneda As String
    Private _capital As Double
    Private _cuotainicia As Double
    Private _numerocuotas As Integer
    Private _fechavencimiento As Date
    Private _tasainteres As Double
    Private _activo As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdProveedor() As String
        Get
            Return _idproveedor
        End Get
        Set(ByVal value As String)
            _idproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Capital() As Double
        Get
            Return _capital
        End Get
        Set(ByVal value As Double)
            _capital = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CuotaInicia() As Double
        Get
            Return _cuotainicia
        End Get
        Set(ByVal value As Double)
            _cuotainicia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCuotas() As Integer
        Get
            Return _numerocuotas
        End Get
        Set(ByVal value As Integer)
            _numerocuotas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TasaInteres() As Double
        Get
            Return _tasainteres
        End Get
        Set(ByVal value As Double)
            _tasainteres = value
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
              , ByVal ls_IdProveedor As String _
              , ByVal ld_FechaInicio As Date _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_Capital As Double _
              , ByVal ln_CuotaInicia As Double _
              , ByVal ln_NumeroCuotas As Integer _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ln_TasaInteres As Double _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idproveedor = ls_IdProveedor
        _fechainicio = ld_FechaInicio
        _idmoneda = ls_IdMoneda
        '_capital = --Capital
        '_cuotainicia = --CuotaInicia
        _numerocuotas = ln_NumeroCuotas
        _fechavencimiento = ld_FechaVencimiento
        _tasainteres = --TasaInteres
        _activo = lb_Activo
    End Sub
#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_Leasing
    ''' </summary>
    ''' <param name="leasing"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal leasing As e_Leasing) As e_Leasing Implements Ie_Leasing.Obtener
        Return leasing
    End Function

#End Region

End Class

