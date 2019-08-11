


<DataContract()> _
Public Class e_Grupo_Asiento
    Implements Ie_Grupo_Asiento
    Implements IEquatable(Of e_Grupo_Asiento)

#Region "Declaracion de varibales"

    Private _id As String
    Private _idgrupo As String
    Private _centro As String
    Private _codgrupo As String
    Private _fecgrupo As Date
    Private _fecenviogrupo As Date
    Private _glosaenvio As String
    Private _importegrupo As Double
    Private _saldogrupo As Double
    Private _tipogrupo As String
    Private _idasientoMovimiento As String
    Private _importe As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public IdCheque As String = ""
    <DataMember()> _
    Public IdTipoMedio As String = ""
    <DataMember()> _
    Public IdFlujoCaja As String = ""
    <DataMember()> _
    Public IdCtaBancaria As String = ""
    <DataMember()> _
    Public _IdEstado As String = ""
    <DataMember()> _
    Public TipoOperacion As String = ""
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public NroCheque As String = ""
    <DataMember()> _
    Public loGrupoAsiento As New List(Of e_Grupo_Asiento)
    <DataMember()> _
    Public loAsientoModelo As New List(Of e_AsientoModelo)

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
    Public Property Codigo() As String
        Get
            Return _codgrupo
        End Get
        Set(ByVal value As String)
            _codgrupo = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipogrupo
        End Get
        Set(ByVal value As String)
            _tipogrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecgrupo
        End Get
        Set(ByVal value As Date)
            _fecgrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property GlosaEnvio() As String
        Get
            Return _glosaenvio
        End Get
        Set(ByVal value As String)
            _glosaenvio = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEnvio() As Date
        Get
            Return _fecenviogrupo
        End Get
        Set(ByVal value As Date)
            _fecenviogrupo = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ImporteTotal() As Double
        Get
            Return _importegrupo
        End Get
        Set(ByVal value As Double)
            _importegrupo = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo()
        Get
            Return _saldogrupo
        End Get
        Set(ByVal value)
            _saldogrupo = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImportePagar() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
            'RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientoMovimiento
        End Get
        Set(ByVal value As String)
            _idasientoMovimiento = value
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
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
        _id = ""
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_IdASientoMovimiento As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idgrupo = ls_IdGrupo
        _idasientoMovimiento = ls_IdASientoMovimiento
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeGrupoAsiento As e_Grupo_Asiento) _
    As Boolean Implements System.IEquatable(Of e_Grupo_Asiento).Equals
        If Me.IdGrupo = oeGrupoAsiento.IdGrupo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal grupo_Asiento As e_Grupo_Asiento) As e_Grupo_Asiento Implements Ie_Grupo_Asiento.Obtener
        Return grupo_Asiento
    End Function

#End Region

End Class

