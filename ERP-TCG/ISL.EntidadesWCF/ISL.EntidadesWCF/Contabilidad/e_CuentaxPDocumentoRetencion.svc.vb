<DataContract()> _
Public Class e_CuentaxPDocumentoRetencion
    Implements Ie_CuentaxPDocumentoRetencion

#Region "Declaracion de Variables"

    Private _id As String
    Private _iddocumentoretencion As String
    Private _activo As Boolean
    Private _idcuentaxcyp As String
    Private _IdMovimientoDocumento As String
    Private _UsuarioCrea As String
    Private _FechaCrea As String
    Private _UsuarioModifica As String
    Private _FechaModifica As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
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
    Public Property IdDocumentoRetencion() As String
        Get
            Return _iddocumentoretencion
        End Get
        Set(ByVal value As String)
            _iddocumentoretencion = value
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
    Public Property IdCuentaxCyP() As String
        Get
            Return _idcuentaxcyp
        End Get
        Set(ByVal value As String)
            _idcuentaxcyp = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        _UsuarioCrea = String.Empty
        _FechaCrea = #1/1/1901#
        _UsuarioModifica = String.Empty
        _FechaModifica = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumentoRetencion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaxCyP As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
           )
        _id = ls_Id
        _iddocumentoretencion = ls_IdDocumentoRetencion
        _activo = lb_Activo
        _idcuentaxcyp = ls_IdCuentaxCyP
        _IdMovimientoDocumento = ls_IdMovimientoDocumento
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal cuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As e_CuentaxPDocumentoRetencion Implements Ie_CuentaxPDocumentoRetencion.Obtener
        Return cuentaxPDocumentoRetencion
    End Function

#End Region

End Class
