<DataContract()> _
Public Class e_CodigoBarraMaterial
    Implements Ie_CodigoBarraMaterial

#Region "Propiedad"

    Private _id As String
    Private _idmaterial As New e_Material
    Private _codigobarras As String
    Private _indprincipal As Boolean
    Private _activo As Boolean

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
    Public Property IdMaterial() As String
        Get
            Return _idmaterial.Id
        End Get
        Set(ByVal value As String)
            _idmaterial.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoBarras() As String
        Get
            Return _codigobarras
        End Get
        Set(ByVal value As String)
            _codigobarras = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndPrincipal() As Boolean
        Get
            Return _indprincipal
        End Get
        Set(ByVal value As Boolean)
            _indprincipal = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_CodigoBarras As String _
              , ByVal ln_IndPrincipal As Boolean _
           )
        _id = ls_Id
        _idmaterial.Id = ls_IdMaterial
        _codigobarras = ls_CodigoBarras
        _indprincipal = ln_IndPrincipal
    End Sub

#End Region

    Public Function Obtener(ByVal codigobarramaterial As e_CodigoBarraMaterial) As e_CodigoBarraMaterial Implements Ie_CodigoBarraMaterial.Obtener
        Return codigobarramaterial
    End Function

End Class
