<DataContract()> _
Public Class e_Asiento_Anticipo
    Implements Ie_Asiento_Anticipo

#Region "Propiedad"

    Private _id As String
    Private _idasientodoc As String
    Private _idasientoantic As String
    Private _activo As Boolean
    Private _idusuariocrea As String
    Private _fechacreacion As Date

    Public Event DatoCambiado()

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
    Public Property IdAsientoDoc() As String
        Get
            Return _idasientodoc
        End Get
        Set(ByVal value As String)
            _idasientodoc = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsientoAntic() As String
        Get
            Return _idasientoantic
        End Get
        Set(ByVal value As String)
            _idasientoantic = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioCrea() As String
        Get
            Return _idusuariocrea
        End Get
        Set(ByVal value As String)
            _idusuariocrea = value
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
        Id = ""
        IdAsientoDoc = ""
        IdAsientoAntic = ""
        Activo = True
        FechaCreacion = Date.Parse("01/01/1901")
        IdUsuarioCrea = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdAsientoDoc As String _
              , ByVal ls_IdAsientoAntic As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdUsuarioCrea As String _
              , ByVal ld_FechaCreacion As Date _
           )
        _id = ls_Id
        _idasientodoc = ls_IdAsientoDoc
        _idasientoantic = ls_IdAsientoAntic
        _idusuariocrea = ls_IdUsuarioCrea
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal asiento As e_Asiento_Anticipo) As e_Asiento_Anticipo Implements Ie_Asiento_Anticipo.Obtener
        Return asiento
    End Function

#End Region

End Class
