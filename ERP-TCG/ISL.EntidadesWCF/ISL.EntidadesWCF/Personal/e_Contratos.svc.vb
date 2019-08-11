' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Contratos" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Contratos.svc o e_Contratos.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Contratos
    Implements Ie_Contratos
    Implements ICloneable
    Implements IEquatable(Of e_Contratos)

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _modalidadcontrato As New e_ModalidadContrato
    Private _motivocese As New e_MotivoCese
    Private _ocupacion As New e_Ocupacion
    Private _estado As New e_Estado
    Private _tipocontrato As New e_ConceptosGenerales
    Private _sueldo As Double
    Private _fechainicio As Date
    Private _fechatermino As Date
    Private _vigencia As Boolean
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechacese As Date
    Private _glosa As String
    Private _regimenlaboral As String
    Private _jornadatrabajadormax As Boolean
    Private _jornadaacumulativa As Boolean
    Private _jornadanocturno As Boolean
    Private _situacionespecial As Integer
    Private _discapacitado As Boolean
    Private _sindicalizado As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public Equivale As Integer

    Event DatoCambiado()

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
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
    Public Property IdMotivoCese() As String
        Get
            Return _motivocese.Id
        End Get
        Set(ByVal value As String)
            _motivocese.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MotivoCese() As String
        Get
            Return _motivocese.Nombre
        End Get
        Set(ByVal value As String)
            _motivocese.Nombre = value
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
Public Property IdOcupacion() As String
        Get
            Return _ocupacion.Id
        End Get
        Set(ByVal value As String)
            _ocupacion.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion.Nombre
        End Get
        Set(ByVal value As String)
            _ocupacion.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdModalidadContrato() As String
        Get
            Return _modalidadcontrato.Id
        End Get
        Set(ByVal value As String)
            _modalidadcontrato.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ModalidadContrato() As String
        Get
            Return _modalidadcontrato.Nombre
        End Get
        Set(ByVal value As String)
            _modalidadcontrato.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _estado.Id
        End Get
        Set(ByVal value As String)
            _estado.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado.Nombre
        End Get
        Set(ByVal value As String)
            _estado.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoContrato() As String
        Get
            Return _tipocontrato.Id
        End Get
        Set(ByVal value As String)
            _tipocontrato.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoContrato() As String
        Get
            Return _tipocontrato.Nombre
        End Get
        Set(ByVal value As String)
            _tipocontrato.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
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
    Public Property FechaTermino() As Date
        Get
            Return _fechatermino
        End Get
        Set(ByVal value As Date)
            _fechatermino = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Vigencia() As Boolean
        Get
            Return _vigencia
        End Get
        Set(ByVal value As Boolean)
            _vigencia = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
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
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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
    Public Property RegimenLaboral() As String
        Get
            Return _regimenlaboral
        End Get
        Set(ByVal value As String)
            _regimenlaboral = value
        End Set
    End Property

    <DataMember()> _
    Public Property JornadaTrabajoMax() As Boolean
        Get
            Return _jornadatrabajadormax
        End Get
        Set(ByVal value As Boolean)
            _jornadatrabajadormax = value
        End Set
    End Property

    <DataMember()> _
    Public Property JornadaAcumulativo() As Boolean
        Get
            Return _jornadaacumulativa
        End Get
        Set(ByVal value As Boolean)
            _jornadaacumulativa = value
        End Set
    End Property

    <DataMember()> _
    Public Property JornadaNocturno() As Boolean
        Get
            Return _jornadanocturno
        End Get
        Set(ByVal value As Boolean)
            _jornadanocturno = value
        End Set
    End Property

    <DataMember()> _
    Public Property SituacionEspecial() As Integer
        Get
            Return _situacionespecial
        End Get
        Set(ByVal value As Integer)
            _situacionespecial = value
        End Set
    End Property

    <DataMember()> _
    Public Property Discapacitado() As Boolean
        Get
            Return _discapacitado
        End Get
        Set(ByVal value As Boolean)
            _discapacitado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Sindicalizado() As Boolean
        Get
            Return _sindicalizado
        End Get
        Set(ByVal value As Boolean)
            _sindicalizado = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        FechaTermino = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
        FechaInicio = Date.Parse("01/01/1901")
        FechaDesde = Date.Parse("01/01/1901")
        FechaHasta = Date.Parse("01/01/1901")
        FechaCese = Date.Parse("01/01/1901")
        Vigencia = True
        IdEstado = ""
        Sueldo = 0
        _glosa = String.Empty
        _regimenlaboral = String.Empty
        _jornadatrabajadormax = False
        _jornadaacumulativa = False
        _jornadanocturno = False
        _situacionespecial = -1
        _discapacitado = False
        _sindicalizado = False
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_IdOcupacion As String _
              , ByVal ls_Ocupacion As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ls_IdTipoContrato As String _
              , ByVal ls_TipoContrato As String _
              , ByVal ls_IdModalidadContrato As String _
              , ByVal ls_ModalidadContrato As String _
              , ByVal ln_Sueldo As Double _
              , ByVal ld_FechaInicio As Date _
              , ByVal ld_FechaTermino As Date _
              , ByVal lb_Vigencia As Boolean _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCese As Date _
              , ByVal ls_Glosa As String _
              , ByVal ls_RegimenLaboral As String _
              , ByVal lb_JornadaTrabajoMax As Boolean _
              , ByVal lb_JornadaAcumulativa As Boolean _
              , ByVal lb_JornadaNocturno As Boolean _
              , ByVal ln_SituacionEspecial As Integer _
              , ByVal lb_Discapacitado As Boolean _
              , ByVal lb_Sindicalizado As Boolean _
              , ByVal ls_IdMotivoCese As String _
              , ByVal ls_MotivoCese As String)
        _id = ls_Id
        _codigo = ls_Codigo
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _ocupacion.Id = ls_IdOcupacion
        _ocupacion.Nombre = ls_Ocupacion
        _estado.Id = ls_IdEstado
        _estado.Nombre = ls_Estado
        _tipocontrato.Id = ls_IdTipoContrato
        _tipocontrato.Nombre = ls_TipoContrato
        _modalidadcontrato.Id = ls_IdModalidadContrato
        _modalidadcontrato.Nombre = ls_ModalidadContrato
        _sueldo = ln_Sueldo
        _fechainicio = ld_FechaInicio
        _fechatermino = ld_FechaTermino
        _vigencia = lb_Vigencia
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechacese = ld_FechaCese
        _glosa = ls_Glosa
        _regimenlaboral = ls_RegimenLaboral
        _jornadatrabajadormax = lb_JornadaTrabajoMax
        _jornadaacumulativa = lb_JornadaAcumulativa
        _jornadanocturno = lb_JornadaNocturno
        _situacionespecial = ln_SituacionEspecial
        _discapacitado = lb_Discapacitado
        _sindicalizado = lb_Sindicalizado
        _motivocese.Id = ls_IdMotivoCese
        _motivocese.Nombre = ls_MotivoCese
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal contratos As e_Contratos) As e_Contratos Implements Ie_Contratos.Obtener
        Return contratos
    End Function

    Public Function Clonar() As Object Implements System.ICloneable.Clone
        Dim oeCntr As New e_Contratos
        With oeCntr
            .IdTrabajador = Me.IdTrabajador
            .IdOcupacion = Me.IdOcupacion
            .IdTipoContrato = Me.IdTipoContrato
            .Sueldo = Me.Sueldo
            .FechaInicio = Me.FechaTermino.AddDays(1)
        End With
        Return oeCntr
    End Function

    Public Overloads Function Equals(ByVal oeContra As e_Contratos) As Boolean Implements System.IEquatable(Of e_Contratos).Equals
        Select Case oeContra.Equivale
            Case 1 : If Me.Id = oeContra.Id Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
