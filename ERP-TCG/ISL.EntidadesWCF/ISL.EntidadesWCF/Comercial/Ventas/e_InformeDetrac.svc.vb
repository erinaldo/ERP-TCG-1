

<DataContract()> _
Public Class e_InformeDetrac
    Implements Ie_InformeDetrac

#Region "Declaracion de Variables"

    Private _id As String
    Private _nroinforme As String
    Private _total As Double
    Private _glosa As String
    Private _fecha As Date
    Private _activo As Boolean
    Private _fechacreacion As Date
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
    <DataMember()> _
    Public leInformeDetrac As New List(Of e_InformeDetrac_Det)

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
    Public Property NroInforme() As String
        Get
            Return _nroinforme
        End Get
        Set(ByVal value As String)
            _nroinforme = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
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

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _activo = True
        _nroinforme = String.Empty
        _total = 0
        _glosa = String.Empty
        _fecha = #1/1/1901#
        _usuariocreacion = String.Empty
        _id = String.Empty
        FechaCreacion = #1/1/1901#
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_NroInforme As String _
              , ByVal ln_Total As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )

        _id = ls_Id
        _nroinforme = ls_NroInforme
        _total = ln_Total
        _glosa = ls_Glosa
        _fecha = ld_Fecha
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion

    End Sub

#End Region

    Public Function Obtener(ByVal informeDetrac As e_InformeDetrac) As e_InformeDetrac Implements Ie_InformeDetrac.Obtener
        Return informeDetrac
    End Function

End Class


