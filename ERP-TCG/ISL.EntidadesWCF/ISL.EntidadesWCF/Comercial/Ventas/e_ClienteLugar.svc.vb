

' NOTA: si cambia aquí el nombre de clase "e_ClienteLugar", también debe actualizar la referencia a "e_ClienteLugar" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_ClienteLugar
    Implements Ie_ClienteLugar

    'Public Sub DoWork() Implements Ie_ClienteLugar.DoWork
    'End Sub

#Region "Propiedad"
    Private _id As String
    Private _idlugar As String
    Private _idcliente As String
    Private _nombre As String
    Private _codigo As String
    Private _centrocosto As String
    Private _observacion As String
    Private _activo As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

    <DataMember()> _
    Public TipoOperacion As String
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
    Public Property IdLugar() As String
        Get
            Return _idlugar
        End Get
        Set(ByVal value As String)
            _idlugar = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    <DataMember()> _
    Public Property CentroCosto() As String
        Get
            Return _centrocosto
        End Get
        Set(ByVal value As String)
            _centrocosto = value
        End Set
    End Property
    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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
        TipoOperacion = ""
        Id = ""
        IdCliente = ""
        IdLugar = ""
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdLugar As String _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_CentroCosto As String _
              , ByVal ls_Observacion As String _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idlugar = ls_IdLugar
        _idcliente = ls_IdCliente
        _nombre = ls_Nombre
        _codigo = ls_Codigo
        _centrocosto = ls_CentroCosto
        _observacion = ls_Observacion
        _activo = lb_Activo
    End Sub

#End Region

End Class


