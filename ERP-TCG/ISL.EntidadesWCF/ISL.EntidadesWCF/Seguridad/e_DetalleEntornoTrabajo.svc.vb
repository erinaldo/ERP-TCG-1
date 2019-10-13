<DataContract()> _
Public Class e_DetalleEntornoTrabajo
    Implements Ie_DetalleEntornoTrabajo
    Implements IEquatable(Of e_DetalleEntornoTrabajo)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idusuario As String ' New e_Usuario
    Private _identornotrabajo As String ' New e_EntornoTrabajo
    Private _entornotrabajo As String
    Private _activo As Boolean
    Private _fechacreacion As Date

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

#Region "Propiedad"

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
    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEntornoTrabajo() As String
        Get
            Return _identornotrabajo
        End Get
        Set(ByVal value As String)
            _identornotrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property EntronoTrabajo() As String
        Get
            Return _entornotrabajo
        End Get
        Set(ByVal value As String)
            _entornotrabajo = value
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
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        _id = ""
        _activo = True
        TipoOperacion = ""

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ls_IdEntornoTrabajo As String _
              , ByVal EntornoTrabajo As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idusuario = ls_IdUsuario
        _identornotrabajo = ls_IdEntornoTrabajo
        _entornotrabajo = EntornoTrabajo
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oeDetalleEntornoTrabajo As e_DetalleEntornoTrabajo) _
    As Boolean Implements System.IEquatable(Of e_DetalleEntornoTrabajo).Equals
        If Me.IdEntornoTrabajo = oeDetalleEntornoTrabajo.IdEntornoTrabajo Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_DetalleEntornoTrabajo
    ''' </summary>
    ''' <param name="detalleEntornoTrabajo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal detalleEntornoTrabajo As e_DetalleEntornoTrabajo) As e_DetalleEntornoTrabajo Implements Ie_DetalleEntornoTrabajo.Obtener
        Return detalleEntornoTrabajo
    End Function

#End Region

End Class
