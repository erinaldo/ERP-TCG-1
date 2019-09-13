
<DataContract()> _
Public Class e_ConfiguracionSisDet
    Implements Ie_ConfiguracionSisDet

#Region "Propiedad"

    Private _id As String
    Private _ejercicio As Integer
    Private _idconfiguracionsis As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Ejercicio() As Integer
        Get
            Return _ejercicio
        End Get
        Set(ByVal value As Integer)
            _ejercicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdConfiguracionSis() As String
        Get
            Return _idconfiguracionsis
        End Get
        Set(ByVal value As String)
            _idconfiguracionsis = value
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
              , ByVal ln_Ejercicio As Integer _
              , ByVal ls_IdConfiguracionSis As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _ejercicio = ln_Ejercicio
        _idconfiguracionsis = ls_IdConfiguracionSis
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ConfiguracionSisDet
    ''' </summary>
    ''' <param name="configuracionSisDet"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal configuracionSisDet As e_ConfiguracionSisDet) As e_ConfiguracionSisDet Implements Ie_ConfiguracionSisDet.Obtener
        Return configuracionSisDet
    End Function

#End Region

End Class


