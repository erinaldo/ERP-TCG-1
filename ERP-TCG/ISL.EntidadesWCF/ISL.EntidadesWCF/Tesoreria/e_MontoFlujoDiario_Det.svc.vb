

<DataContract()> _
Public Class e_MontoFlujoDiario_Det
    Implements Ie_MontoFlujoDiario_Det
    Implements IEquatable(Of e_MontoFlujoDiario_Det)

#Region "Declaración de variables"

    Private _id As String
    Private _idmontoflujodiario As String
    Private _tipo As Integer
    Private _montopromedio As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    Private _concepto As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

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
    Public Property IdMontoFlujoDiario() As String
        Get
            Return _idmontoflujodiario
        End Get
        Set(ByVal value As String)
            _idmontoflujodiario = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoPromedio() As Double
        Get
            Return _montopromedio
        End Get
        Set(ByVal value As Double)
            _montopromedio = value
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

#Region "Constructores"

    Public Sub New()
        _id = ""
        _concepto = ""
        _tipo = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMontoFlujoDiario As String _
              , ByVal ln_Tipo As Integer _
              , ByVal ln_MontoPromedio As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idmontoflujodiario = ls_IdMontoFlujoDiario
        _tipo = ln_Tipo
        _montopromedio = ln_MontoPromedio
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeMFDDetalle As e_MontoFlujoDiario_Det) _
    As Boolean Implements IEquatable(Of e_MontoFlujoDiario_Det).Equals
        If Me.Tipo = oeMFDDetalle.Tipo Then Return True
        Return False
    End Function

    Public Function Obtener(ByVal montoFlujoDiario_Det As e_MontoFlujoDiario_Det) As e_MontoFlujoDiario_Det Implements Ie_MontoFlujoDiario_Det.Obtener
        Return montoFlujoDiario_Det
    End Function

#End Region

End Class

