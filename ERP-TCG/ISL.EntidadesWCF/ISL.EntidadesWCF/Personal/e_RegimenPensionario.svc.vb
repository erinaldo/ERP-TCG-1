<DataContract()> _
Public Class e_RegimenPensionario
    Implements Ie_RegimenPensionario
    Implements IEquatable(Of e_RegimenPensionario)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idempresa As String
    Private _empresa As String
    Private _porcentajeobligatorio As Double
    Private _porcentajecomision As Double
    Private _porcentajeseguros As Double
    Private _porcentajecomisionmixta As Double
    Private _porcentajesaldomixta As Double
    Private _porcentajeobligatorio2 As Double
    Private _porcentajetotal As Double
    Private _porcentajetotalmixta As Double
    Private _renumeracionmaxima As Double
    Private _vigente As Integer
    Private _fechaactividad As Date
    Private _fechainactividad As Date
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leHistorialPorcentaje As New List(Of e_RegimenPensionario)

#End Region

#Region "Propiedades"

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
    Public Property IdEmpresa() As String
        Get
            Return _idempresa
        End Get
        Set(ByVal value As String)
            _idempresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeObligatorio() As Double
        Get
            Return _porcentajeobligatorio
        End Get
        Set(ByVal value As Double)
            _porcentajeobligatorio = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeComision() As Double
        Get
            Return _porcentajecomision
        End Get
        Set(ByVal value As Double)
            _porcentajecomision = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeSeguros() As Double
        Get
            Return _porcentajeseguros
        End Get
        Set(ByVal value As Double)
            _porcentajeseguros = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeComisionMixta() As Double
        Get
            Return _porcentajecomisionmixta
        End Get
        Set(ByVal value As Double)
            _porcentajecomisionmixta = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeSaldoMixta() As Double
        Get
            Return _porcentajesaldomixta
        End Get
        Set(ByVal value As Double)
            _porcentajesaldomixta = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeObligatorio2() As Double
        Get
            Return _porcentajeobligatorio2
        End Get
        Set(ByVal value As Double)
            _porcentajeobligatorio2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeTotal() As Double
        Get
            Return _porcentajetotal
        End Get
        Set(ByVal value As Double)
            _porcentajetotal = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeTotalMixta() As Double
        Get
            Return _porcentajetotalmixta
        End Get
        Set(ByVal value As Double)
            _porcentajetotalmixta = value
        End Set
    End Property

    <DataMember()> _
    Public Property RenumeracionMaxima() As Double
        Get
            Return _renumeracionmaxima
        End Get
        Set(ByVal value As Double)
            _renumeracionmaxima = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaActividad() As Date
        Get
            Return _fechaactividad
        End Get
        Set(ByVal value As Date)
            _fechaactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInactividad() As Date
        Get
            Return _fechainactividad
        End Get
        Set(ByVal value As Date)
            _fechainactividad = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
        _id = String.Empty
        _idempresa = String.Empty
        _porcentajeobligatorio = 0
        _porcentajecomision = 0
        _porcentajeseguros = 0
        _porcentajecomisionmixta = 0
        _porcentajesaldomixta = 0
        _porcentajetotal = 0
        _porcentajetotalmixta = 0
        _renumeracionmaxima = 0
        _vigente = -1
        _fechaactividad = #1/1/1901#
        _fechainactividad = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdEmpresa As String _
              , ByVal ls_Empresa As String _
              , ByVal ln_PorcentajeObligatorio As Double _
              , ByVal ln_PorcentajeComision As Double _
              , ByVal ln_PorcentajeSeguros As Double _
              , ByVal ln_PorcentajeComisionMixta As Double _
              , ByVal ln_PorcentajeSaldoMixta As Double _
              , ByVal ln_PorcentajeObligatorio2 As Double _
              , ByVal ln_RenumeracionMaxima As Double _
              , ByVal ln_Vigente As String _
              , ByVal ld_FechaActividad As Date _
              , ByVal ld_FechaInactividad As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idempresa = ls_IdEmpresa
        _empresa = ls_Empresa
        _porcentajeobligatorio = ln_PorcentajeObligatorio
        _porcentajecomision = ln_PorcentajeComision
        _porcentajeseguros = ln_PorcentajeSeguros
        _porcentajecomisionmixta = ln_PorcentajeComisionMixta
        _porcentajesaldomixta = ln_PorcentajeSaldoMixta
        _porcentajeobligatorio2 = ln_PorcentajeObligatorio2
        _renumeracionmaxima = ln_RenumeracionMaxima
        _porcentajetotal = _porcentajeobligatorio + _porcentajecomision + _porcentajeseguros
        _porcentajetotalmixta = _porcentajeobligatorio + _porcentajecomisionmixta + _porcentajeseguros
        _vigente = ln_Vigente
        _fechaactividad = ld_FechaActividad
        _fechainactividad = ld_FechaInactividad
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(ByVal oeRegimenPensionario As e_RegimenPensionario) As e_RegimenPensionario Implements Ie_RegimenPensionario.obtener
        Return oeRegimenPensionario
    End Function

    Public Overloads Function Equals(ByVal oeRegPen As e_RegimenPensionario) As Boolean Implements System.IEquatable(Of e_RegimenPensionario).Equals
        If Me.IdEmpresa = oeRegPen.IdEmpresa Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

End Class
