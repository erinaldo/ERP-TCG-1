Public Class e_Bitacora
#Region "Propiedad"

    Private _id As String
    Private _idtablacabecera As String
    Private _idtabladetalle As String
    Private _nombretablacabecera As String
    Private _nombretabladetalle As String
    Private _nombreformulario As String
    Private _columnasafectadas As List(Of String)
    Private _fecharegistro As Date
    Private _fechamodificacion As Date
    Private _usuarioregistro As String
    Private _usuariomodificacion As String
    Private _tipooperacion As String
    Private _valoresanteriores As List(Of String)
    Private _valoresactuales As List(Of String)
    Private _indicador As String
    Private _activo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    Public _Tipo As String

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property IdTablaCabecera() As String
        Get
            Return _idtablacabecera
        End Get
        Set(ByVal value As String)
            _idtablacabecera = value

        End Set
    End Property

    Public Property IdTablaDetalle() As String
        Get
            Return _idtabladetalle
        End Get
        Set(ByVal value As String)
            _idtabladetalle = value

        End Set
    End Property

    Public Property NombreTablaCabecera() As String
        Get
            Return _nombretablacabecera
        End Get
        Set(ByVal value As String)
            _nombretablacabecera = value

        End Set
    End Property

    Public Property NombreTablaDetalle() As String
        Get
            Return _nombretabladetalle
        End Get
        Set(ByVal value As String)
            _nombretabladetalle = value

        End Set
    End Property

    Public Property NombreFormulario() As String
        Get
            Return _nombreformulario
        End Get
        Set(ByVal value As String)
            _nombreformulario = value

        End Set
    End Property

    Public Property ColumnasAfectadas() As List(Of String)
        Get
            Return _columnasafectadas
        End Get
        Set(ByVal value As List(Of String))
            _columnasafectadas = value

        End Set
    End Property

    Public Property FechaRegistro() As Date
        Get
            Return _fecharegistro
        End Get
        Set(ByVal value As Date)
            _fecharegistro = value

        End Set
    End Property

    Public Property FechaModificacion() As Date
        Get
            Return _fechamodificacion
        End Get
        Set(ByVal value As Date)
            _fechamodificacion = value

        End Set
    End Property

    Public Property UsuarioRegistro() As String
        Get
            Return _usuarioregistro
        End Get
        Set(ByVal value As String)
            _usuarioregistro = value

        End Set
    End Property

    Public Property UsuarioModificacion() As String
        Get
            Return _usuariomodificacion
        End Get
        Set(ByVal value As String)
            _usuariomodificacion = value
        End Set
    End Property

    Public Property TipoOPeracion() As String
        Get
            Return _tipooperacion
        End Get
        Set(ByVal value As String)
            _tipooperacion = value
        End Set
    End Property

    Public Property ValoresAnteriores() As List(Of String)
        Get
            Return _valoresanteriores
        End Get
        Set(ByVal value As List(Of String))
            _valoresanteriores = value
        End Set
    End Property

    Public Property ValoresActuales() As List(Of String)
        Get
            Return _valoresactuales
        End Get
        Set(ByVal value As List(Of String))
            _valoresactuales = value
        End Set
    End Property

    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value

        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value

        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

#End Region
#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New(
              ByVal ls_IdTablaCabecera As String _
              , ByVal ls_IdTablaDetalle As String _
              , ByVal ls_NombreTablaCabecera As String _
              , ByVal ls_NombreTablaDetalle As String _
              , ByVal ls_NombreFormulario As String _
              , ByVal ls_ColumnasAfectadas As List(Of String) _
              , ByVal ls_Usuario As String _
              , ByVal ls_TipoOPeracion As String _
              , ByVal ls_ValoresAnteriores As List(Of String) _
              , ByVal ls_ValoresActuales As List(Of String) _
              , ByVal ls_Indicador As String _
              , ByVal Tipo As String _
              , ByVal Activo As Boolean
           )
        _idtablacabecera = ls_IdTablaCabecera
        _idtabladetalle = ls_IdTablaDetalle
        _nombretablacabecera = ls_NombreTablaCabecera
        _nombretabladetalle = ls_NombreTablaDetalle
        _nombreformulario = ls_NombreFormulario
        _columnasafectadas = ls_ColumnasAfectadas
        _usuarioregistro = ls_Usuario
        _usuariomodificacion = ls_Usuario
        _tipooperacion = ls_TipoOPeracion
        _valoresanteriores = ls_ValoresAnteriores
        _valoresactuales = ls_ValoresActuales
        _indicador = ls_Indicador
        _Tipo = Tipo
        _activo = Activo
    End Sub

#End Region
End Class

