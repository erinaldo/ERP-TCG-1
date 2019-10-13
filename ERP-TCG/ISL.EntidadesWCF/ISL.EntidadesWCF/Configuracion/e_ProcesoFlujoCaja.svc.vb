<DataContract()> _
Public Class e_ProcesoFlujoCaja
    Implements Ie_ProcesoFlujoCaja
    Implements IEquatable(Of e_ProcesoFlujoCaja)

#Region "Propiedad"

    Private _id As String
    Private _idprocesonegocio As String
    Private _procesonegocio As String
    Private _idflujocaja As String
    Private _flujocaja As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public ListaProcesoFlujoCaja As New List(Of e_ProcesoFlujoCaja)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property IdProcesoNegocio() As String
        Get
            Return _idprocesonegocio
        End Get
        Set(ByVal value As String)
            _idprocesonegocio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ProcesoNegocio() As String
        Get
            Return _procesonegocio
        End Get
        Set(ByVal value As String)
            _procesonegocio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _idflujocaja
        End Get
        Set(ByVal value As String)
            _idflujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja() As String
        Get
            Return _flujocaja
        End Get
        Set(ByVal value As String)
            _flujocaja = value
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
        _id = String.Empty
        _activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdProcesoNegocio As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_ProcesoNegocio As String _
              , ByVal ls_FlujoCaja As String)
        _id = ls_Id
        _idprocesonegocio = ls_IdProcesoNegocio
        _idflujocaja = ls_IdFlujoCaja
        _activo = lb_Activo
        _flujocaja = ls_FlujoCaja
        _procesonegocio = ls_ProcesoNegocio
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) _
    As Boolean Implements System.IEquatable(Of e_ProcesoFlujoCaja).Equals
        If Me.IdFlujoCaja = oeProcesoFlujoCaja.IdFlujoCaja Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal procesoFlujoCaja As e_ProcesoFlujoCaja) As e_ProcesoFlujoCaja Implements Ie_ProcesoFlujoCaja.Obtener
        Return procesoFlujoCaja
    End Function

#End Region

End Class


