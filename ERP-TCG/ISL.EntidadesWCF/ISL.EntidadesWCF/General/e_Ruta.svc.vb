''' <summary>
''' Clase para definir la entidad: Ruta
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Ruta
    Implements Ie_Ruta
    Implements ICloneable
    Implements IEquatable(Of e_Ruta)
    Implements IPropiedadesBasicas

#Region "Propiedades"

    Private _id As String
    Private _codigo As String
    Private _idorigen As String
    Private _origen As String
    Private _iddestino As String
    Private _destino As String
    Private _idcentro As String
    Private _idflota As String
    Private _kilometros As Decimal
    Private _horassolo As Decimal
    Private _horasacompañado As Decimal
    Private _indicadorlocal As Boolean
    Private _factorreferencial As Decimal
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _nombre As String

    Private _Seleccion As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public oeTiempoCiclo As New List(Of e_TiempoCiclo)
    <DataMember()> _
    Public oeFlete As New List(Of e_Flete)
    <DataMember()> _
    Public oeBolsaViaje As New List(Of e_BolsaViaje)
    <DataMember()> _
    Public oeDistanciaZona As New List(Of e_DistanciaZona)
    <DataMember()> _
    Public loMontoRuta As New List(Of e_MontoRuta)
    <DataMember()> _
    Public loZonaD2 As New List(Of e_ZonaCombustible)
    <DataMember()> _
    Public ListaRutaPeaje As List(Of e_RutaPeaje)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen() As String
        Get
            Return _idorigen
        End Get
        Set(ByVal value As String)
            _idorigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDestino() As String
        Get
            Return _iddestino
        End Get
        Set(ByVal value As String)
            _iddestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property Destino() As String
        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasAcompañado() As Decimal
        Get
            Return _horasacompañado
        End Get
        Set(ByVal value As Decimal)
            _horasacompañado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlota() As String
        Get
            Return _idflota
        End Get
        Set(ByVal value As String)
            _idflota = value
        End Set
    End Property

    <DataMember()> _
    Public Property Kilometros() As Decimal
        Get
            Return _kilometros
        End Get
        Set(ByVal value As Decimal)
            _kilometros = value
        End Set
    End Property

    <DataMember()> _
    Public Property HorasSolo() As Decimal
        Get
            Return _horassolo
        End Get
        Set(ByVal value As Decimal)
            _horassolo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndicadorLocal() As Boolean
        Get
            Return _indicadorlocal
        End Get
        Set(ByVal value As Boolean)
            _indicadorlocal = value
        End Set
    End Property

    <DataMember()> _
    Public Property FactorReferencial() As Decimal
        Get
            Return _factorreferencial
        End Get
        Set(ByVal value As Decimal)
            _factorreferencial = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property CantidadTarifas() As Integer

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = ""
        Modificado = False
        'Propiedades
        Id = ""
        Codigo = ""
        Seleccion = False
        IdOrigen = ""
        Origen = ""
        IdDestino = ""
        Destino = ""
        IdCentro = ""
        HorasAcompañado = 0
        IdFlota = ""
        Kilometros = 0
        HorasSolo = 0
        IndicadorLocal = False
        FactorReferencial = 0
        UsuarioCreacion = ""
        Activo = True
        Nombre = ""
        CantidadTarifas = 0
        ListaRutaPeaje = New List(Of e_RutaPeaje)
    End Sub

    Public Sub New( _
                ByVal ls_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdOrigen As String _
              , ByVal ls_Origen As String _
              , ByVal ls_IdDestino As String _
              , ByVal ls_Destino As String _
              , ByVal ls_IdCentro As String _
              , ByVal ls_IdFlota As String _
              , ByVal ln_Kilometros As Decimal _
              , ByVal ln_HorasSolo As Decimal _
              , ByVal ln_HorasAcompañado As Decimal _
              , ByVal lb_IndicadorLocal As Boolean _
              , ByVal ln_FactorReferencial As Decimal _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Nombre As String _
              , ByVal ln_CantidadTarifas As String _
           )
        _Seleccion = ls_Seleccion
        _id = ls_Id
        _codigo = ls_Codigo
        _idorigen = ls_IdOrigen
        _origen = ls_Origen
        _iddestino = ls_IdDestino
        _destino = ls_Destino
        _idcentro = ls_IdCentro
        _idflota = ls_IdFlota
        _kilometros = ln_Kilometros
        _horassolo = ln_HorasSolo
        _horasacompañado = ln_HorasAcompañado
        _indicadorlocal = lb_IndicadorLocal
        _factorreferencial = ln_FactorReferencial
        _activo = lb_Activo
        _nombre = ls_Nombre
        ListaRutaPeaje = New List(Of e_RutaPeaje)
        CantidadTarifas = ln_CantidadTarifas
    End Sub

#End Region

#Region "Métodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    Public Overloads Function Equals(ByVal Ruta As e_Ruta) As Boolean Implements IEquatable(Of e_Ruta).Equals
        If Ruta.TipoOperacion = "" Then
            If Me.Id = Ruta.Id Then Return True
        Else
            If Ruta.TipoOperacion = "R" Then
                If Me.IdOrigen = Ruta.IdOrigen And Me.IdDestino = Ruta.IdDestino Then Return True
            End If
        End If
        Return False
    End Function

    Public Function Obtener(ByVal ruta As e_Ruta) As e_Ruta Implements Ie_Ruta.Obtener
        Return ruta
    End Function

#End Region

End Class


