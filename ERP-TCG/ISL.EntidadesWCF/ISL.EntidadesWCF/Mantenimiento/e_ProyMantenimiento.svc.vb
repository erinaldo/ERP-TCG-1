<DataContract()> _
Public Class e_ProyMantenimiento
    Implements Ie_ProyMantenimiento

#Region "Declaracion de Variables"

    Public TipoOperacion As String = ""

    Private _codigo As String
    Private _placa As String
    Private _motriz As Integer
    Private _marca As String
    Private _modelo As String
    Private _fecha As Date
    Private _kilometraje As Double
    Private _ultimomantenimiento As String
    Private _kmultimoservicio As Double
    Private _kmmantenimiento As Double
    Private _horometro As Double
    Private _fechaultimomantenimiento As Date
    Private _nroultimoot As String
    Private _proximomantenimiento As String
    Private _unidadmedida As String
    Private _cantidad As Double
    Private _cantidadaprox As Double
    Private _diferencia As Double
    Private _kmproyectado As Double
    
    <DataMember()> _
    Public IdUnidadMedida As String
    <DataMember()> _
    Public IdMarca As String
    <DataMember()> _
    Public IdModelo As String

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
Public Property Unidad() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    <DataMember()> _
Public Property Motriz() As Integer
        Get
            Return _motriz
        End Get
        Set(ByVal value As Integer)
            _motriz = value
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
Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    <DataMember()> _
Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property KmProyectado() As Double
        Get
            Return _kmproyectado
        End Get
        Set(ByVal value As Double)
            _kmproyectado = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmMantenimiento() As Double
        Get
            _kmmantenimiento = KmProyectado + Kilometraje
            Return _kmmantenimiento
        End Get
        Set(ByVal value As Double)
            _kmmantenimiento = value
        End Set
    End Property

    <DataMember()> _
 Public Property UltimoMant() As String
        Get
            Return _ultimomantenimiento
        End Get
        Set(ByVal value As String)
            _ultimomantenimiento = value
        End Set
    End Property

    <DataMember()> _
Public Property KmUltimoServicio() As Double
        Get
            Return _kmultimoservicio
        End Get
        Set(ByVal value As Double)
            _kmultimoservicio = value
        End Set
    End Property

    <DataMember()> _
Public Property Horometro() As Double
        Get
            Return _horometro
        End Get
        Set(ByVal value As Double)
            _horometro = value
        End Set
    End Property

    <DataMember()> _
Public Property FechaUltimoMant() As Date
        Get
            Return _fechaultimomantenimiento
        End Get
        Set(ByVal value As Date)
            _fechaultimomantenimiento = value
        End Set
    End Property

    <DataMember()> _
Public Property NroUltimoOT() As String
        Get
            Return _nroultimoot
        End Get
        Set(ByVal value As String)
            _nroultimoot = value
        End Set
    End Property

    <DataMember()> _
Public Property ProximoMant() As String
        Get
            Return _proximomantenimiento
        End Get
        Set(ByVal value As String)
            _proximomantenimiento = value
        End Set
    End Property

    <DataMember()> _
Public Property UnidadMedida() As String
        Get
            Return _unidadmedida
        End Get
        Set(ByVal value As String)
            _unidadmedida = value
        End Set
    End Property

    <DataMember()> _
Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
Public Property CantidadProx() As Double
        Get
            Select Case UnidadMedida
                Case "KILOMETRO"
                    _cantidadaprox = KmUltimoServicio + Cantidad
                Case "DIA"
                Case "HORA"
            End Select
            Return _cantidadaprox
        End Get
        Set(ByVal value As Double)
            _cantidadaprox = value
        End Set
    End Property

    <DataMember()> _
Public Property Diferencia() As Double
        Get
            Select Case UnidadMedida
                Case "KILOMETRO"
                    _diferencia = _cantidadaprox - Kilometraje
                Case "DIA"
                Case "HORA"
            End Select
            Return _diferencia
        End Get
        Set(ByVal value As Double)
            _diferencia = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = ""
        IdUnidadMedida = String.Empty
        IdMarca = String.Empty
        IdModelo = String.Empty
        'Property's
        Codigo = ""
        Unidad = ""
        Motriz = 0
        Marca = ""
        Modelo = ""
        Fecha = #1/1/1901#
        Kilometraje = 0.0
        KmProyectado = 0.0
        KmMantenimiento = 0.0
        UltimoMant = ""
        KmUltimoServicio = 0.0
        Horometro = 0
        FechaUltimoMant = #1/1/1901#
        NroUltimoOT = ""
        ProximoMant = ""
        UnidadMedida = ""
        Cantidad = 0
        CantidadProx = 0
        Diferencia = 0
    End Sub

    Public Sub New(ByVal ls_Codigo As String, _
                   ByVal ls_Placa As String, _
                   ByVal ln_Motriz As Integer, _
                   ByVal ls_Marca As String, _
                   ByVal ls_Modelo As String, _
                   ByVal ld_Fecha As Date, _
                   ByVal ln_Kilometraje As Double, _
                   ByVal ln_KmProyectado As Double, _
                   ByVal ls_UltimoMantenimiento As String, _
                   ByVal ln_KmUltimoServicio As Double, _
                   ByVal ln_Horometro As Double, _
                   ByVal ld_FechaUltimoMant As Date, _
                   ByVal ls_NroUltimoOT As String, _
                   ByVal ls_ProximoMant As String, _
                   ByVal ls_UnidadMedida As String, _
                   ByVal ln_Cantidad As Double)

        _codigo = ls_Codigo
        _placa = ls_Placa
        _motriz = ln_Motriz
        _marca = ls_Marca
        _modelo = ls_Modelo
        _fecha = ld_Fecha
        _kilometraje = ln_Kilometraje
        _kmproyectado = ln_KmProyectado
        _ultimomantenimiento = ls_UltimoMantenimiento
        _kmultimoservicio = ln_KmUltimoServicio
        _horometro = ln_Horometro
        _fechaultimomantenimiento = ld_FechaUltimoMant
        _nroultimoot = ls_NroUltimoOT
        _proximomantenimiento = ls_ProximoMant
        _unidadmedida = ls_UnidadMedida
        _cantidad = ln_Cantidad

    End Sub

#End Region

    Public Function Obtener(ByVal proymantenimiento As e_ProyMantenimiento) As e_ProyMantenimiento Implements Ie_ProyMantenimiento.Obtener
        Return proymantenimiento
    End Function

End Class
