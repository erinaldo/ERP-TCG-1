

<DataContract()> _
Public Class e_OcupacionTrabajador
    Implements Ie_OcupacionTrabajador
    Implements IEquatable(Of e_OcupacionTrabajador)

#Region "Declaracion de Variables"

    Private _seleccion As Boolean
    Private _id As String
    Private _idocupacion As String
    Private _ocupacion As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _idarea As String
    Private _area As String
    Private _idareaog As String
    Private _areaog As String
    Private _idgerencia As String
    Private _gerencia As String
    Private _idcargo As String
    Private _cargo As String
    Private _idcentro As String
    Private _centro As String
    Private _idtiporelacionlaboral As String
    Private _tiporelacionlaboral As String
    Private _fechaingreso As Date
    Private _fechacese As Date
    Private _principal As Integer
    Private _indRuta As Integer
    Private _fechaejecutacese As Date
    Private _usuarioejecutacese As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer = 0
    <DataMember()>
    Public PrefijoID As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _seleccion
        End Get
        Set(ByVal value As Boolean)
            _seleccion = value
        End Set
    End Property

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
    Public Property IdOcupacion() As String
        Get
            Return _idocupacion
        End Get
        Set(ByVal value As String)
            _idocupacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    Public Property IdAreaOG() As String
        Get
            Return _idareaog
        End Get
        Set(ByVal value As String)
            _idareaog = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property AreaOG() As String
        Get
            Return _areaog
        End Get
        Set(ByVal value As String)
            _areaog = value
        End Set
    End Property

    Public Property IdGerencia() As String
        Get
            Return _idgerencia
        End Get
        Set(ByVal value As String)
            _idgerencia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Gerencia() As String
        Get
            Return _gerencia
        End Get
        Set(ByVal value As String)
            _gerencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCargo() As String
        Get
            Return _idcargo
        End Get
        Set(ByVal value As String)
            _idcargo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoRelacionLaboral() As String
        Get
            Return _idtiporelacionlaboral
        End Get
        Set(ByVal value As String)
            _idtiporelacionlaboral = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoRelacionLaboral() As String
        Get
            Return _tiporelacionlaboral
        End Get
        Set(ByVal value As String)
            _tiporelacionlaboral = value
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
    Public Property FechaCese() As Date
        Get
            Return _fechacese
        End Get
        Set(ByVal value As Date)
            _fechacese = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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

    <DataMember()> _
    Public Property Principal() As Integer
        Get
            Return _principal
        End Get
        Set(ByVal value As Integer)
            _principal = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndRuta() As Integer
        Get
            Return _indRuta
        End Get
        Set(ByVal value As Integer)
            _indRuta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEjecutaCese() As Date
        Get
            Return _fechaejecutacese
        End Get
        Set(ByVal value As Date)
            _fechaejecutacese = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioEjecutaCese() As String
        Get
            Return _usuarioejecutacese
        End Get
        Set(ByVal value As String)
            _usuarioejecutacese = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _principal = 0
        _activo = True
        TipoOperacion = ""
        _idarea = ""
        _area = ""
        _idcargo = ""
        _cargo = ""
        _idcentro = ""
        _centro = ""
        _idocupacion = ""
        _idtiporelacionlaboral = ""
        _tiporelacionlaboral = ""
        _fechacese = #1/1/1901#
        _fechaingreso = #1/1/1901#
        _indRuta = 0
        _fechaejecutacese = Date.Parse("01/01/1901")
        _usuarioejecutacese = String.Empty
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean _
              , ByVal ls_Id As String _
              , ByVal ls_IdOcupacion As String _
              , ByVal Ocupacion As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal lb_Principal As Boolean _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ls_IdCargo As String _
              , ByVal ls_Cargo As String _
              , ByVal ls_IdCentro As String _
              , ByVal ls_Centro As String _
              , ByVal ls_IdTipoRelacionLaboral As String _
              , ByVal ls_TipoRelacionLaboral As String _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ld_FechaCese As Date _
              , ByVal ln_IndRuta As Integer _
           )
        _id = ls_Id
        _idocupacion = ls_IdOcupacion
        _ocupacion = Ocupacion
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _principal = IIf(lb_Principal, 1, 0)
        _seleccion = lb_Seleccion
        _idarea = ls_IdArea
        _area = ls_Area
        _idcargo = ls_IdCargo
        _cargo = ls_Cargo
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _idtiporelacionlaboral = ls_IdTipoRelacionLaboral
        _tiporelacionlaboral = ls_TipoRelacionLaboral
        _fechaingreso = ld_FechaIngreso
        _fechacese = ld_FechaCese
        TipoOperacion = ""
        _indRuta = ln_IndRuta

        _fechaejecutacese = #1/1/1901#
        _usuarioejecutacese = String.Empty

    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeOT As e_OcupacionTrabajador) As Boolean Implements System.IEquatable(Of e_OcupacionTrabajador).Equals
        Select Case oeOT.Equivale
            Case 0 : If Me.IdOcupacion = oeOT.IdOcupacion Then Return True
            Case 1 : If Me.Id = oeOT.Id Then Return True
        End Select
        Return False
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_OcupacionTrabajador
    ''' </summary>
    ''' <param name="ocupacionTrabajador"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal ocupacionTrabajador As e_OcupacionTrabajador) As e_OcupacionTrabajador Implements Ie_OcupacionTrabajador.Obtener
        Return ocupacionTrabajador
    End Function

#End Region

End Class



