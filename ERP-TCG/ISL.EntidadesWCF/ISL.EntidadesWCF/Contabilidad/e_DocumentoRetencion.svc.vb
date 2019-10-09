<DataContract()> _
Public Class e_DocumentoRetencion
    Implements Ie_DocumentoRetencion

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtipodocumento As String
    Private _serie As String
    Private _numero As String
    Private _fechaemision As Date
    Private _activo As Boolean
    Private _idasientomovimiento As String
    Private _IndElectronico As Integer
    Private _IndEnviado As Boolean
    Private _IndAnulado As Boolean
    Private _Regimen As String
    Private _Tasa As Double
    Private _Comentario As String
    Private _IdMonedaRetencion As String
    Private _TipoCambioRetencion As Double
    Private _ImporteRetencion As Double
    Private _IdMonedaPagado As String
    Private _ImportePagado As Double
    Private _NroDocElectronico As String
    Private _EstadoElectronico As String
    Private _IndEmail As Boolean
    Private _IndExterno As Boolean
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdMoneda As String
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public ImporteDol As Double
    <DataMember()> _
    Public ImporteSol As Double
    <DataMember()> _
    Public Voucher As String
    <DataMember()> _
    Public FechaFin As Date
    <DataMember()> _
    Public IdEstado As String
    <DataMember()> _
    Public IdUsuario As String
    <DataMember()> _
    Public MacPCLocal As String

    Private _Estado As String
    Private _NombreTipoDoc As String

    <DataMember()> _
    Public IdProveedor As String
    <DataMember()> _
    Public ls_Ruta As String

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property NombreTipoDoc() As String
        Get
            Return _NombreTipoDoc
        End Get
        Set(ByVal value As String)
            _NombreTipoDoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

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
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
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

    <DataMember()> _
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndElectronico() As Integer
        Get
            Return _IndElectronico
        End Get
        Set(ByVal value As Integer)
            _IndElectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEnviado() As Boolean
        Get
            Return _IndEnviado
        End Get
        Set(ByVal value As Boolean)
            _IndEnviado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAnulado() As Boolean
        Get
            Return _IndAnulado
        End Get
        Set(ByVal value As Boolean)
            _IndAnulado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Regimen() As String
        Get
            Return _Regimen
        End Get
        Set(ByVal value As String)
            _Regimen = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tasa() As Double
        Get
            Return _Tasa
        End Get
        Set(ByVal value As Double)
            _Tasa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comentario() As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMonedaRetencion() As String
        Get
            Return _IdMonedaRetencion
        End Get
        Set(ByVal value As String)
            _IdMonedaRetencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambioRetencion() As Double
        Get
            Return _TipoCambioRetencion
        End Get
        Set(ByVal value As Double)
            _TipoCambioRetencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImporteRetencion() As Double
        Get
            Return _ImporteRetencion
        End Get
        Set(ByVal value As Double)
            _ImporteRetencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMonedaPagado() As String
        Get
            Return _IdMonedaPagado
        End Get
        Set(ByVal value As String)
            _IdMonedaPagado = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImportePagado() As Double
        Get
            Return _ImportePagado
        End Get
        Set(ByVal value As Double)
            _ImportePagado = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDocElectronico() As String
        Get
            Return _NroDocElectronico
        End Get
        Set(ByVal value As String)
            _NroDocElectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoElectronico() As String
        Get
            Return _EstadoElectronico
        End Get
        Set(ByVal value As String)
            _EstadoElectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEmail() As Boolean
        Get
            Return _IndEmail
        End Get
        Set(ByVal value As Boolean)
            _IndEmail = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndExterno() As Boolean
        Get
            Return _IndExterno
        End Get
        Set(ByVal value As Boolean)
            _IndExterno = value
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
        TipoOperacion = ""
        IdEstado = "EMITIDA"
        IdUsuario = ""

        _IndElectronico = 0
        _IndEnviado = False
        _IndAnulado = False
        _Regimen = ""
        _Tasa = 0
        _Comentario = ""
        _IdMonedaRetencion = ""
        _TipoCambioRetencion = 0
        _ImporteRetencion = 0
        _IdMonedaPagado = ""
        _ImportePagado = 0
        _NroDocElectronico = ""
        _EstadoElectronico = ""
        _IndEmail = False
        _IndExterno = False
        _UsuarioCrea = ""
        _FechaCrea = #1/1/1901#
        _UsuarioModifica = String.Empty
        _FechaModifica = #1/1/1901#

        _serie = ""
        _numero = ""
        _fechaemision = #1/1/1901#
        _idasientomovimiento = ""

        IdProveedor = String.Empty

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdAsientoMovimiento As String _
              , ByVal lsTipoDoc As String _
              , ByVal lsEstado As String _
              , ByVal ln_IndElectronico As Integer _
              , ByVal lb_IndEnviado As Boolean _
              , ByVal lb_IndAnulado As Boolean _
              , ByVal ls_Regimen As String _
            , ByVal ln_Tasa As Double _
            , ByVal ls_Comentario As String _
            , ByVal ls_IdMonedaRetencion As String _
            , ByVal ln_TipoCambioRetencion As Double _
            , ByVal ln_ImporteRetencion As Double _
            , ByVal ls_IdMonedaPagado As String _
            , ByVal ln_ImportePagado As Double _
            , ByVal ls_NroDocElectronico As String _
            , ByVal ls_EstadoElectronico As String _
            , ByVal lb_IndEmail As Boolean _
            , ByVal lb_IndExterno As Boolean _
            , ByVal ls_UsuarioCrea As String _
            , ByVal ld_FechaCrea As Date _
            , ByVal ls_UsuarioModifica As String _
            , ByVal ld_FechaModifica As Date _
            , ByVal ls_IdProveedor As String _
           )
        NombreTipoDoc = lsTipoDoc
        Estado = lsEstado
        _id = ls_Id
        _idtipodocumento = ls_IdTipoDocumento
        _serie = ls_Serie
        _numero = ls_Numero
        _fechaemision = ld_FechaEmision
        _activo = lb_Activo
        _idasientomovimiento = ls_IdAsientoMovimiento
        _IndElectronico = ln_IndElectronico
        _IndEnviado = lb_IndEnviado
        _IndAnulado = lb_IndAnulado
        _Regimen = ls_Regimen
        _Tasa = ln_Tasa
        _Comentario = ls_Comentario
        _IdMonedaRetencion = ls_IdMonedaRetencion
        _TipoCambioRetencion = ln_TipoCambioRetencion
        _ImporteRetencion = ln_ImporteRetencion
        _IdMonedaPagado = ls_IdMonedaPagado
        _ImportePagado = ln_ImportePagado
        _NroDocElectronico = ls_NroDocElectronico
        _EstadoElectronico = ls_EstadoElectronico
        _IndEmail = lb_IndEmail
        _IndExterno = lb_IndExterno
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica

        IdProveedor = ls_IdProveedor
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal documentoRetencion As e_DocumentoRetencion) As e_DocumentoRetencion Implements Ie_DocumentoRetencion.Obtener
        Return documentoRetencion
    End Function

#End Region

End Class
