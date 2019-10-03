<DataContract()> _
Public Class e_TrabajadorSeguridad
    Implements Ie_TrabajadorSeguridad

#Region "Propiedad"

    Private _id As String
    Private _cantidadlimite As Double
    Private _cantidadminima As Double
    Private _indmontofuncional As Integer

    Private _activo As Boolean
    Private _usuariocreacion As String

    '<DataMember()> _
    'Public oeProceso As New e_ProcesoNegocio

    '<DataMember()> _
    'Public oeArea As New e_Area
    Private _idArea As String
    Private _area As String

    ''<DataMember()> _
    ''Public oeTrabajador As New e_Trabajador
    Private _idTrabajador As String
    Private _codigoTrabajador As String
    Private _nombreTrabajador As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    '<DataMember()> _
    'Public NombreProceso As String
    <DataMember()>
    Public PrefijoID As String = ""
    Private _idProcesoNegocio As String
    Private _nombreProceso As String

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property IdProceso() As String
    '    Get
    '        Return _idProcesoNegocio
    '    End Get
    '    Set(ByVal value As String)
    '        _idProcesoNegocio = value
    '    End Set
    'End Property

    'Private _idProcesoNegocio As e_ProcesoNegocio
    '<DataMember()> _
    'Public Property oeProceso() As e_ProcesoNegocio
    '    Get
    '        Return _idProcesoNegocio
    '    End Get
    '    Set(ByVal value As e_ProcesoNegocio)
    '        _idProcesoNegocio = value
    '    End Set
    'End Property


    'Private _Trabajador As e_Trabajador

    '<DataMember()> _
    'Public Property oeTrabajador() As e_Trabajador
    '    Get
    '        Return _Trabajador
    '    End Get
    '    Set(ByVal value As e_Trabajador)
    '        _Trabajador = value
    '    End Set
    'End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idTrabajador
        End Get
        Set(ByVal value As String)
            _idTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoTrabajador() As String
        Get
            Return _codigoTrabajador
        End Get
        Set(ByVal value As String)
            _codigoTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreTrabajador() As String
        Get
            Return _nombreTrabajador
        End Get
        Set(ByVal value As String)
            _nombreTrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadLimite() As Double
        Get
            Return _cantidadlimite
        End Get
        Set(ByVal value As Double)
            _cantidadlimite = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadMinima() As Double
        Get
            Return _cantidadminima
        End Get
        Set(ByVal value As Double)
            _cantidadminima = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndMontoFuncional() As Integer
        Get
            Return _indmontofuncional
        End Get
        Set(ByVal value As Integer)
            _indmontofuncional = value
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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idProcesoNegocio
        End Get
        Set(ByVal value As String)
            _idProcesoNegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreProceso() As String
        Get
            Return _nombreProceso
        End Get
        Set(ByVal value As String)
            _nombreProceso = value
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

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idArea
        End Get
        Set(ByVal value As String)
            _idArea = value
        End Set
    End Property

    'Private _oeArea As e_Area
    '<DataMember()> _
    'Public Property oeArea() As e_Area
    '    Get
    '        Return _oeArea
    '    End Get
    '    Set(ByVal value As e_Area)
    '        _oeArea = value
    '    End Set
    'End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdProceso As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_CodigoTrab As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ld_CantidadLimite As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ln_CantidadMinima As Double _
              , ByVal ln_IndMontoFuncional As Integer _
              , ByVal ls_NombreProceso As String _
           )

        _id = ls_Id
        _idProcesoNegocio = ls_IdProceso
        _idTrabajador = ls_IdTrabajador
        _codigoTrabajador = ls_CodigoTrab
        _nombreTrabajador = ls_Trabajador
        _idArea = ls_IdArea
        _area = ls_Area
        _cantidadlimite = ld_CantidadLimite
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _cantidadminima = ln_CantidadMinima
        _indmontofuncional = ln_IndMontoFuncional
        _nombreProceso = ls_NombreProceso
    End Sub

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_TrabajadorSeguridad
    ''' </summary>
    ''' <param name="trabajadorSeguridad"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal trabajadorSeguridad As e_TrabajadorSeguridad) As e_TrabajadorSeguridad Implements Ie_TrabajadorSeguridad.Obtener
        Return trabajadorSeguridad
    End Function

#End Region

End Class


