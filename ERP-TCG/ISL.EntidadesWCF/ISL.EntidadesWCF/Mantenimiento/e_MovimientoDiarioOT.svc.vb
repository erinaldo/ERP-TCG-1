<DataContract()> _
Public Class e_MovimientoDiarioOT
    Implements Ie_MovimientoDiarioOT

#Region "Declaracion de Variables"

    Private _nroot As String
    Private _indicadortipo As String
    Private _tipoorden As String
    Private _equipo As String
    Private _tipovehiculo As String
    Private _modelo As String
    Private _marca As String
    Private _fechaINT As Date
    Private _horaINT As Date
    Private _fechaIT As Date
    Private _horaIT As Date
    Private _kilometraje As Double
    Private _descripcion As String
    Private _fechaFT As Date
    Private _horaFT As Date
    Private _diferencia As String
    Private _flota As String

    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()> _
    Public IdMarca As String
    <DataMember()> _
    Public IdModelo As String
    <DataMember()> _
    Public IdTipoVehiculo As String


#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property NroOT() As String
        Get
            Return _nroot
        End Get
        Set(ByVal value As String)
            _nroot = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorTipo() As String
        Get
            Return _indicadortipo
        End Get
        Set(ByVal value As String)
            _indicadortipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOrden() As String
        Get
            Dim _var As String
            Select Case _tipoorden.Trim
                Case "1" : _var = "PREVENTIVO"
                Case "2" : _var = "PROACTIVO"
                Case "3" : _var = "CORRECTIVO"
                Case Else : _var = "NO ASIGNADO"
            End Select
            Return _var
        End Get
        Set(ByVal value As String)
            _tipoorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property Equipo() As String
        Get
            Return _equipo
        End Get
        Set(ByVal value As String)
            _equipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flota() As String
        Get
            Return _flota
        End Get
        Set(ByVal value As String)
            _flota = value
        End Set
    End Property

    <DataMember()> _
Public Property TipoVehiculo() As String
        Get
            Return _tipovehiculo
        End Get
        Set(ByVal value As String)
            _tipovehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaINT() As Date
        Get
            Return _fechaINT
        End Get
        Set(ByVal value As Date)
            _fechaINT = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraINT() As Date
        Get
            Return _horaINT
        End Get
        Set(ByVal value As Date)
            _horaINT = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIT() As Date
        Get
            Return _fechaIT
        End Get
        Set(ByVal value As Date)
            _fechaIT = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraIT() As Date
        Get
            Return _horaIT
        End Get
        Set(ByVal value As Date)
            _horaIT = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFT() As Date
        Get
            Return _fechaFT
        End Get
        Set(ByVal value As Date)
            _fechaFT = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraFT() As Date
        Get
            Return _horaFT
        End Get
        Set(ByVal value As Date)
            _horaFT = value
        End Set
    End Property

    <DataMember()> _
    Public Property Kilometraje() As Double
        Get
            Return _kilometraje
        End Get
        Set(ByVal value As Double)
            _kilometraje = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diferencia() As String
        Get
            _diferencia = Math.Round(DateDiff(DateInterval.Minute, _fechaINT, FechaFT) / 60, 2)
            '_diferencia = Calcula_fHora(DateDiff(DateInterval.Second, _fechaINT, FechaFT))
            Return _diferencia
        End Get
        Set(ByVal value As String)
            _diferencia = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Anio = String.Empty
        Mes = String.Empty
        IdMarca = String.Empty
        IdModelo = String.Empty
        IdTipoVehiculo = String.Empty
    End Sub

    Public Sub New(ByVal ls_NroOT As String _
                    , ByVal ls_IndicadorTipo As String _
                    , ByVal ls_TipoOrden As String _
                    , ByVal ls_Equipo As String _
                    , ByVal ls_TipoVehiculo As String _
                    , ByVal ls_Marca As String _
                    , ByVal ls_Modelo As String _
                    , ByVal ld_FechaIngresoTaller As Date _
                    , ByVal ld_FechaInicioTaller As Date _
                    , ByVal ld_FechaFinTaller As Date _
                    , ByVal ln_Kilometraje As Double _
                    , ByVal ls_Descripcion As String _
                    , ByVal ls_Flota As String)

        _nroot = ls_NroOT
        _indicadortipo = ls_IndicadorTipo
        _tipoorden = ls_TipoOrden
        _equipo = ls_Equipo
        _tipovehiculo = ls_TipoVehiculo
        _marca = ls_Marca
        _modelo = ls_Modelo
        _kilometraje = ln_Kilometraje
        _descripcion = ls_Descripcion
        _fechaINT = ld_FechaIngresoTaller
        _horaINT = ld_FechaIngresoTaller
        _fechaIT = ld_FechaInicioTaller
        _horaIT = ld_FechaInicioTaller
        _fechaFT = ld_FechaFinTaller
        _horaFT = ld_FechaFinTaller
        _flota = ls_Flota

    End Sub


#End Region

    Public Function Obtener(ByVal movimientoot As e_MovimientoDiarioOT) As e_MovimientoDiarioOT Implements Ie_MovimientoDiarioOT.Obtener
        Return movimientoot
    End Function

    Private Function Calcula_fHora(ByVal cantseg As Integer) As String
        Try
            Dim _varfhora As String = ""
            Dim _canthora As Integer = 0
            Dim _cantminuto As Integer = 0
            Dim _xmin As Double = 0
            Dim _cantsegundo As Integer = 0
            'Calcula Cantidad Hora
            If cantseg > 3599 Then
                _canthora = cantseg / 3600
                _xmin = cantseg Mod 3600
            Else
                _xmin = cantseg
            End If
            If _xmin > 59 Then
                _cantminuto = _xmin / 60
                _cantsegundo = _xmin Mod 60
            Else
                _cantsegundo = _xmin
            End If
            _varfhora = _canthora & " : " & _cantminuto & " : " & _cantsegundo
            '_varfhora = _canthora & " hh " & _cantminuto & " mm " & _cantsegundo & " ss"
            Return _varfhora
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
