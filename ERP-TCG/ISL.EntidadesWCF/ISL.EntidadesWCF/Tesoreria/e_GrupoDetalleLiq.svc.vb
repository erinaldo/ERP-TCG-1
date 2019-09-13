


<DataContract()> _
Public Class e_GrupoDetalleLiq
    Implements Ie_GrupoDetalleLiq

#Region "Declaracion de Variables"

    Private _id As String
    Private _idgrupo As String
    Private _idviaje As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public Monto As Decimal
    <DataMember()>
    Public PrefijoID As String = ""

    Public Event DatoCambiado()

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
    Public Property IdGrupo() As String
        Get
            Return _idgrupo
        End Get
        Set(ByVal value As String)
            _idgrupo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
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
        _activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_IdViaje As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idgrupo = ls_IdGrupo
        _idviaje = ls_IdViaje
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal grupoDetalleLiq As e_GrupoDetalleLiq) As e_GrupoDetalleLiq Implements Ie_GrupoDetalleLiq.Obtener
        Return grupoDetalleLiq
    End Function

End Class

