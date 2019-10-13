

' NOTA: si cambia aquí el nombre de clase "e_HistorialRechazoOC", también debe actualizar la referencia a "e_HistorialRechazoOC" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_HistorialRechazoOC
    Implements Ie_HistorialRechazoOC

#Region "Propiedad"

    Private _id As String
    Private _idordencompra As String
    Private _glosa As String
    Private _fecha As Date
    Private _nroorden As String
    Private _usuariocreacion As String

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
   Public Property NroOrden() As String
        Get
            Return _nroorden
        End Get
        Set(ByVal value As String)
            _nroorden = value
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
    Public Property IdOrdenCompra() As String
        Get
            Return _idordencompra
        End Get
        Set(ByVal value As String)
            _idordencompra = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        _fecha = #1/1/1901#
        _glosa = String.Empty
        _id = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdOrdenCompra As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_NroOrden As String _
              , ByVal ls_UsuarioCreacion As String)
        _id = ls_Id
        _idordencompra = ls_IdOrdenCompra
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _nroorden = ls_NroOrden
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

    Public Function Obtener(ByVal historialRechazooc As e_HistorialRechazoOC) As e_HistorialRechazoOC Implements Ie_HistorialRechazoOC.Obtener
        Return historialRechazooc
    End Function

End Class


