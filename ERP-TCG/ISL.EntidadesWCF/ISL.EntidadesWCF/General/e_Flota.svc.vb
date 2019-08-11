''' <summary>
''' Clase para definir datos de Flota vehicular ISL
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Flota
    Implements Ie_Flota
    Implements IPropiedadesBasicas

#Region "Variables"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _activo As Boolean
    Private _IndFlota As Integer
    Private _IndZona As Integer
    Private _IndZonaD2 As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public ListJefes As List(Of e_Flota_Trabajador)
    <DataMember()> _
    Public ListCuotas As List(Of e_Flota_Cuota)
#End Region

#Region "Propiedades"

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
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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
    Public Property IndFlota() As Integer
        Get
            Return _IndFlota
        End Get
        Set(ByVal value As Integer)
            _IndFlota = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndZona() As Integer
        Get
            Return _IndZona
        End Get
        Set(ByVal value As Integer)
            _IndZona = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndZonaD2() As Integer
        Get
            Return _IndZonaD2
        End Get
        Set(ByVal value As Integer)
            _IndZonaD2 = value
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

    Public Property IdJefeActual() As String

    Public Property CuotaTracto() As Double

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Modificado = False
        Id = ""
        Codigo = ""
        Nombre = ""
        Activo = True
        IndZona = 2
        IndFlota = 2
        IndZonaD2 = 2
        Descripcion = ""
        IdJefeActual = ""
        CuotaTracto = 0
        ListJefes = New List(Of e_Flota_Trabajador)
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Nombre As String _
              , ByVal lb_Activo As Boolean _
              , ByVal li_IndZona As Integer _
              , ByVal li_IndFlota As Integer _
              , ByVal li_IndZonaD2 As Integer _
              , ByVal ls_Descripcion As String _
              , ByVal ls_IdJefeActual As String _
              , ByVal ln_CuotaTracto As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _activo = lb_Activo
        _IndZona = li_IndZona
        _IndFlota = li_IndFlota
        _IndZonaD2 = li_IndZonaD2
        _descripcion = ls_Descripcion
        IdJefeActual = ls_IdJefeActual
        CuotaTracto = ln_CuotaTracto
        ListJefes = New List(Of e_Flota_Trabajador)
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal flota As e_Flota) As e_Flota Implements Ie_Flota.Obtener
        Return flota
    End Function

#End Region

End Class


