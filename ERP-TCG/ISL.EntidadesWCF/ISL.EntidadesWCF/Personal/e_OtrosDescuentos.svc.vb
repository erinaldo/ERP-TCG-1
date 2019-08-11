<DataContract()> _
Public Class e_OtrosDescuentos
    Implements Ie_OtrosDescuentos

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _planilla As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _indtipo As Integer
    Private _tipo As String
    Private _monto As Double
    Private _idempresaconvenio As String
    Private _empresaconvenio As String
    Private _idcuentabeneficiario As String
    Private _nrocuenta As String
    Private _personacuenta As String
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IndReferencia As Integer = 0
    <DataMember()> _
    Public IdReferencia As String = ""

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
    Public Property Planilla() As String
        Get
            Return _planilla
        End Get
        Set(ByVal value As String)
            _planilla = value
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
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
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
    Public Property Tipo() As String
        Get
            Select Case _indtipo
                Case 0 : _tipo = "CONVENIO"
                Case 1 : _tipo = "JUDICIAL"
                Case 2 : _tipo = "OTROS"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaConvenio() As String
        Get
            Return _idempresaconvenio
        End Get
        Set(ByVal value As String)
            _idempresaconvenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Empresa() As String
        Get
            Return _empresaconvenio
        End Get
        Set(ByVal value As String)
            _empresaconvenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaBeneficiario() As String
        Get
            Return _idcuentabeneficiario
        End Get
        Set(ByVal value As String)
            _idcuentabeneficiario = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuenta() As String
        Get
            Return _nrocuenta
        End Get
        Set(ByVal value As String)
            _nrocuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Beneficiario() As String
        Get
            Return _personacuenta
        End Get
        Set(ByVal value As String)
            _personacuenta = value
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
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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
        _planilla = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _indtipo = 0
        _tipo = String.Empty
        _monto = 0
        _idempresaconvenio = String.Empty
        _empresaconvenio = String.Empty
        _idcuentabeneficiario = String.Empty
        _nrocuenta = String.Empty
        _personacuenta = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdPlanilla As String _
          , ByVal ls_Planilla As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Dni As String _
          , ByVal ls_Trabajador As String _
          , ByVal ln_IndTipo As Integer _
          , ByVal ln_Monto As Double _
          , ByVal ls_IdEmpresaConvenio As String _
          , ByVal ls_EmpresaConvenio As String _
          , ByVal ls_IdCuentaBeneficiario As String _
          , ByVal ls_NroCuenta As String _
          , ByVal ls_PersonaCuenta As String _
          , ByVal ls_IdEstado As String _
          , ByVal ls_Estado As String _
          , ByVal ln_IndReferencia As Integer _
          , ByVal ls_IdReferencia As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _planilla = ls_Planilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _indtipo = ln_IndTipo
        _monto = ln_Monto
        _idempresaconvenio = ls_IdEmpresaConvenio
        _empresaconvenio = ls_EmpresaConvenio
        _idcuentabeneficiario = ls_IdCuentaBeneficiario
        _nrocuenta = ls_NroCuenta
        _personacuenta = ls_PersonaCuenta
        _idestado = ls_IdEstado
        _estado = ls_Estado
        IndReferencia = ln_IndReferencia
        IdReferencia = ls_IdReferencia
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeOtrosDescuentos As e_OtrosDescuentos) As e_OtrosDescuentos Implements Ie_OtrosDescuentos.obtener
        Return oeOtrosDescuentos
    End Function

#End Region



End Class
