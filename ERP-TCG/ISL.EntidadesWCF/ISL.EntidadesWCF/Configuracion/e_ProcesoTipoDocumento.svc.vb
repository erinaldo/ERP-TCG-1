

<DataContract()> _
Public Class e_ProcesoTipoDocumento
    Implements Ie_ProcesoTipoDocumento

#Region "Declaración de variables"

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

#Region "Constructor"

    Public Sub New()
        _activo = True
        _id = ""
        _idProceso = ""
        _idTipoDocumento = ""
        _proceso = ""
        _tipoDocumento = ""
        TipoOperacion = ""
        _CodigoTD = ""
    End Sub

    Public Sub New(ByVal id As String, _
                   ByVal idTipoDocumento As String, _
                   ByVal idProceso As String, _
                   ByVal activo As Boolean, _
                   ByVal proceso As String, _
                   ByVal tipoDocumento As String, _
                   ByVal codigo As String)
        _id = id
        _idTipoDocumento = idTipoDocumento
        _idProceso = idProceso
        _activo = activo
        _proceso = proceso
        _tipoDocumento = tipoDocumento
        _CodigoTD = codigo
    End Sub


#End Region

#Region "Propiedades"

    Private _id As String
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _idTipoDocumento As String
    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idTipoDocumento
        End Get
        Set(ByVal value As String)
            _idTipoDocumento = value
        End Set
    End Property


    Private _idProceso As String
    <DataMember()> _
    Public Property IdProceso() As String
        Get
            Return _idProceso
        End Get
        Set(ByVal value As String)
            _idProceso = value
        End Set
    End Property

    Private _activo As Boolean
    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Private _proceso As String
    <DataMember()> _
    Public Property Proceso() As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
        End Set
    End Property

    Private _tipoDocumento As String
    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipoDocumento
        End Get
        Set(ByVal value As String)
            _tipoDocumento = value
        End Set
    End Property

    Private _CodigoTD As String
    <DataMember()> _
    Public Property CodigoTD() As String
        Get
            Return _CodigoTD
        End Get
        Set(ByVal value As String)
            _CodigoTD = value
        End Set
    End Property

#End Region

    Public Function Obtener(ByVal procesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento Implements Ie_ProcesoTipoDocumento.Obtener
        Return procesoTipoDocumento
    End Function

End Class


