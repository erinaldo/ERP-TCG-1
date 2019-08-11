<DataContract()> _
Public Class e_Descuentos
    Implements Ie_Descuentos

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _idtrabajador As String
    Private _montoadelanto As Double
    Private _montosancion As Double
    Private _indtipo As Integer
    Private _idestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
     Public TipoOperacion As String
    <DataMember()> _
     Public Modificado As Boolean


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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoAdelanto() As Double
        Get
            Return _montoadelanto
        End Get
        Set(ByVal value As Double)
            _montoadelanto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoSancion() As Double
        Get
            Return _montosancion
        End Get
        Set(ByVal value As Double)
            _montosancion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
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
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idplanilla = String.Empty
        _idtrabajador = String.Empty
        _montoadelanto = 0
        _montosancion = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPlanilla As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ln_MontoAdelanto As Double _
              , ByVal ln_MontoSancion As Double _
              , ByVal ln_IndTipo As Integer _
              , ByVal ls_IdEstado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _montoadelanto = ln_MontoAdelanto
        _montosancion = ln_MontoSancion
        _indtipo = ln_IndTipo
        _idestado = ls_IdEstado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDescuentos As e_Descuentos) As e_Descuentos Implements Ie_Descuentos.obtener
        Return oeDescuentos
    End Function

#End Region

End Class
