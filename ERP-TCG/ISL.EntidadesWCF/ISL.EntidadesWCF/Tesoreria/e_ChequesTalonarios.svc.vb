' NOTA: si cambia aquí el nombre de clase "e_ChequesTalonarios", también debe actualizar la referencia a "e_ChequesTalonarios" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_ChequesTalonarios
    Implements Ie_ChequesTalonarios

#Region "Propiedad"

    Private _id As String
    Private _centro As New e_Centro
    Private _inicial As Integer
    Private _final As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _caja As New e_Caja
    Private _talonario As String
    Private _idresponsable As String
    Private _indterminado As Boolean
    Private _indanulado As Boolean
    Private _idChequesControl As String
    Private _fechaingreso As Date
    Private _observacion As String
    Private _correlativo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

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
    Public Property IdCaja() As String
        Get
            Return _caja.Id
        End Get
        Set(ByVal value As String)
            _caja.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTerminado() As Boolean
        Get
            Return _indterminado
        End Get
        Set(ByVal value As Boolean)
            _indterminado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Correlativo() As String
        Get
            Return _correlativo
        End Get
        Set(ByVal value As String)
            _correlativo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAnulado() As Boolean
        Get
            Return _indanulado
        End Get
        Set(ByVal value As Boolean)
            _indanulado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdChequesControl() As String
        Get
            Return _idChequesControl
        End Get
        Set(ByVal value As String)
            _idChequesControl = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdResponsable() As String
        Get
            Return _idresponsable
        End Get
        Set(ByVal value As String)
            _idresponsable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Talonario() As String
        Get
            Return _talonario
        End Get
        Set(ByVal value As String)
            _talonario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Inicial() As Integer
        Get
            Return _inicial
        End Get
        Set(ByVal value As Integer)
            _inicial = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Final() As Integer
        Get
            Return _final
        End Get
        Set(ByVal value As Integer)
            _final = value
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
        Activo = True
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ln_Inicial As Integer _
              , ByVal ln_Final As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdCaja As String _
              , ByVal ls_IdResponsable As String _
              , ByVal lb_IndAnulado As Boolean _
              , ByVal lb_IndTerminado As Boolean _
              , ByVal ls_Observacion As String _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ls_Talonario As String _
              , ByVal ls_Correlativo As String)
        _id = ls_Id
        _inicial = ln_Inicial
        _final = ln_Final
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _caja.Id = ls_IdCaja
        _idresponsable = ls_IdResponsable
        _indanulado = lb_IndAnulado
        _indterminado = lb_IndTerminado
        _observacion = ls_Observacion
        _fechaingreso = ld_FechaIngreso
        _talonario = ls_Talonario
        _correlativo = ls_Correlativo
    End Sub

#End Region

    Public Function Obtener(ByVal chequestalonarios As e_ChequesTalonarios) As e_ChequesTalonarios Implements Ie_ChequesTalonarios.Obtener
        Return chequestalonarios
    End Function

End Class
