''' <summary>
''' Clase para definir la entidad: MedioPago
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_MedioPago
    Implements Ie_MedioPago
    Implements IPropiedadesBasicas

#Region "Propiedades"

    Private _id As String
    Private _codigo As String
    Private _nombre As String
    Private _abreviatura As String
    Private _idtipoasiento As String
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
    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoAsiento() As String
        Get
            Return _idtipoasiento
        End Get
        Set(ByVal value As String)
            _idtipoasiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
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
              , ByVal ls_Nombre As String _
              , ByVal ls_Abreviatura As String _
              , ByVal ls_IdTipoAsiento As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Codigo As String _
           )
        _id = ls_Id
        _nombre = ls_Nombre
        _abreviatura = ls_Abreviatura
        _idtipoasiento = ls_IdTipoAsiento
        _activo = lb_Activo
        _codigo = ls_Codigo
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal medioPago As e_MedioPago) As e_MedioPago Implements Ie_MedioPago.Obtener
        Return medioPago
    End Function

#End Region

End Class


