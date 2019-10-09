<DataContract()> _
Public Class e_ValorizacionNeumatico
    Implements Ie_ValorizacionNeumatico

#Region "Propiedad"

    Private _id As String
    Private _fecha As Date
    Private _valortotaldolares As Double
    Private _glosa As String
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()>
    Public FechaFin As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()>
    Public lstDetalleValorizacion As New List(Of e_DetalleValorizacionNeumatico)

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
    Public Property ValorTotalDolares() As Double
        Get
            Return _valortotaldolares
        End Get
        Set(ByVal value As Double)
            _valortotaldolares = value
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
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
              , ByVal ld_Fecha As Date _
              , ByVal ln_ValorTotalDolares As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _fecha = ld_Fecha
        _valortotaldolares = ln_ValorTotalDolares
        _glosa = ls_Glosa
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ValorizacionNeumatico
    ''' </summary>
    ''' <param name="valorizacionNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal valorizacionNeumatico As e_ValorizacionNeumatico) As e_ValorizacionNeumatico Implements Ie_ValorizacionNeumatico.Obtener
        Return valorizacionNeumatico
    End Function

#End Region

End Class
