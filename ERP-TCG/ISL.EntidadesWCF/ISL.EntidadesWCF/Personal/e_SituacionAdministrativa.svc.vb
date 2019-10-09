

<DataContract()> _
Public Class e_SituacionAdministrativa
    Implements Ie_SituacionAdministrativa

#Region "Declaración de variables"
    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _remunerado As Boolean
    Private _acumulaVacaciones As Boolean
    Private _codigoplame As String
    Private _indtipo As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String _
              , ByVal codigo As String _
              , ByVal nombre As String _
              , ByVal abreviatura As String _
              , ByVal remunerado As Boolean _
              , ByVal acumulaVacaciones As Boolean _
              , ByVal codigoplame As String _
              , ByVal indtipo As Integer _
              , ByVal fechaCreacion As Date _
              , ByVal usuarioCreacion As String _
              , ByVal activo As Boolean _
           )
        _id = id
        _codigo = codigo
        _nombre = nombre
        _abreviatura = abreviatura
        _remunerado = remunerado
        _acumulaVacaciones = acumulaVacaciones
        _codigoplame = codigoplame
        _indtipo = indtipo
        _fechacreacion = fechaCreacion
        _usuariocreacion = usuarioCreacion
        _activo = activo
    End Sub

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
        End Set
    End Property

    ''' <summary>
    ''' Variable para establecer si los días en esta situación administrativa son remunerados o no
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Remunerado() As Boolean
        Get
            Return _remunerado
        End Get
        Set(ByVal value As Boolean)
            _remunerado = value
        End Set
    End Property

    ''' <summary>
    ''' Variable para establecer si la situación administrativa específica se acumula para descontar vacaciones
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property AcumulaVacaciones() As Boolean
        Get
            Return _acumulaVacaciones
        End Get
        Set(ByVal value As Boolean)
            _acumulaVacaciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoPlame() As String
        Get
            Return _codigoplame
        End Get
        Set(ByVal value As String)
            _codigoplame = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
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

#Region "Metodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_SituacionAdministrativa
    ''' </summary>
    ''' <param name="situacionAdministrativa"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal situacionAdministrativa As e_SituacionAdministrativa) As e_SituacionAdministrativa Implements Ie_SituacionAdministrativa.Obtener
        Return situacionAdministrativa
    End Function

#End Region

End Class



