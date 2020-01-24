'=====================================================================================================
'=== CAPA : ENTIDADES ================================================================================
'=====================================================================================================

Public Class e_MovimientoDocumento_css


#Region "Declaración de variables"


    Private _Id As String
    Private _IdTipoDocumento As String
    Private _Serie As String
    Private _Numero As String
    Private _FechaEmision As Date
    Private _FechaVencimiento As Date
    Private _NoGravadas As Double
    Private _IGV As Double
    Private _SubTotal As Double
    Private _Total As Double
    Private _Saldo As Double
    Private _IdClienteProveedor As String
    Private _Activo As Boolean
    Private _IndCompraVenta As Integer
    Private _IdPeriodo As String
    Private _IdMoneda As String
    Private _TipoCambio As Double
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _IdCuentaContable As String
    Private _IdEstadoDocumento As String
    Private _Operador As Integer
    Private _MacPCLocalCreacion As String
    Private _IndServicioMaterial As String
    Private _GlosaCtaxCyP As String
    Private _CuoMomentaneo As String
    Private _UsuarioModifica As String
    Private _FechaModificacion As Date
    Private _CodigoUnicoOperacion As String
    Private _IndElectronico As Integer
    Private _IndEnviado As Integer
    Private _IndAnulado As Integer
    Private _IdTipoBien As String
    Private _OrdenCompra As String
    Private _IndAnexo As Integer
    Private _CodMotivo As String
    Private _VentaGratuita As Boolean
    Private _Descuento As Double
    Private _EsAnulado As Boolean
    Private _EnviadoEmail As Boolean
    Private _EnviadoExterno As Boolean
    Private _IndAfectoIVA As Boolean
    Private _EstadoElectronico As String
    Private _EstadoPago As String
    Private _FechaRevision As Date
    Private _UsuarioRevision As String
    Private _EnvioPortal As String
    Private _Retencion_Letra As Double
    Private _Retencion_Saldo As Double
    Private _IndAnticipo As Boolean
    Private _IndAfectaAnticipo As Boolean
    Private _Monto_Anticipo As Double
    Public TipoOperacion As String

    <DataMember()>
    Public PrefijoID As String = ""

#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdTipoDocumento = ""
        _Serie = ""
        _Numero = ""
        _FechaEmision = #01/01/1901#
        _FechaVencimiento = #01/01/1901#
        _NoGravadas = 0
        _IGV = 0
        _SubTotal = 0
        _Total = 0
        _Saldo = 0
        _IdClienteProveedor = ""
        _Activo = True
        _IndCompraVenta = 0
        _IdPeriodo = ""
        _IdMoneda = ""
        _TipoCambio = 0
        _UsuarioCreacion = ""
        _FechaCreacion = #01/01/1901#
        _IdCuentaContable = ""
        _IdEstadoDocumento = ""
        _Operador = 0
        _MacPCLocalCreacion = ""
        _IndServicioMaterial = ""
        _GlosaCtaxCyP = ""
        _CuoMomentaneo = ""
        _UsuarioModifica = ""
        _FechaModificacion = #01/01/1901#
        _CodigoUnicoOperacion = ""
        _IndElectronico = 0
        _IndEnviado = 0
        _IndAnulado = 0
        _IdTipoBien = ""
        _OrdenCompra = ""
        _IndAnexo = 0
        _CodMotivo = ""
        _VentaGratuita = True
        _Descuento = 0
        _EsAnulado = True
        _EnviadoEmail = True
        _EnviadoExterno = True
        _IndAfectoIVA = True
        _EstadoElectronico = ""
        _EstadoPago = ""
        _FechaRevision = ""
        _UsuarioRevision = ""
        _EnvioPortal = ""
        _Retencion_Letra = 0
        _Retencion_Saldo = 0
        _IndAnticipo = True
        _IndAfectaAnticipo = True
        _Monto_Anticipo = 0
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_Serie As String _
              , ByVal ls_Numero As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ln_NoGravadas As Double _
              , ByVal ln_IGV As Double _
              , ByVal ln_SubTotal As Double _
              , ByVal ln_Total As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_IndCompraVenta As Integer _
              , ByVal ls_IdPeriodo As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_IdEstadoDocumento As String _
              , ByVal ln_Operador As Integer _
              , ByVal ls_MacPCLocalCreacion As String _
              , ByVal ls_IndServicioMaterial As String _
              , ByVal ls_GlosaCtaxCyP As String _
              , ByVal ls_CuoMomentaneo As String _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModificacion As Date _
              , ByVal ls_CodigoUnicoOperacion As String _
              , ByVal ln_IndElectronico As Integer _
              , ByVal ln_IndEnviado As Integer _
              , ByVal ln_IndAnulado As Integer _
              , ByVal ls_IdTipoBien As String _
              , ByVal ls_OrdenCompra As String _
              , ByVal ln_IndAnexo As Integer _
              , ByVal ls_CodMotivo As String _
              , ByVal lb_VentaGratuita As Boolean _
              , ByVal ln_Descuento As Double _
              , ByVal lb_EsAnulado As Boolean _
              , ByVal lb_EnviadoEmail As Boolean _
              , ByVal lb_EnviadoExterno As Boolean _
              , ByVal lb_IndAfectoIVA As Boolean _
              , ByVal ls_EstadoElectronico As String _
              , ByVal ls_EstadoPago As String _
              , ByVal ld_FechaRevision As Date _
              , ByVal ls_UsuarioRevision As String _
              , ByVal ls_EnvioPortal As String _
              , ByVal ln_Retencion_Letra As Double _
              , ByVal ln_Retencion_Saldo As Double _
              , ByVal lb_IndAnticipo As Boolean _
              , ByVal lb_IndAfectaAnticipo As Boolean _
              , ByVal ln_Monto_Anticipo As Double
           )
        _Id = ls_Id
        _IdTipoDocumento = ls_IdTipoDocumento
        _Serie = --Serie
        _Numero = --Numero
        _FechaEmision = ld_FechaEmision
        _FechaVencimiento = ld_FechaVencimiento
        _NoGravadas = ln_NoGravadas
        _IGV = ln_IGV
        _SubTotal = ln_SubTotal
        _Total = ln_Total
        _Saldo = ln_Saldo
        _IdClienteProveedor = ls_IdClienteProveedor
        _Activo = lb_Activo
        _IndCompraVenta = ln_IndCompraVenta
        _IdPeriodo = ls_IdPeriodo
        _IdMoneda = ls_IdMoneda
        _TipoCambio = ln_TipoCambio
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _IdCuentaContable = ls_IdCuentaContable
        _IdEstadoDocumento = ls_IdEstadoDocumento
        _Operador = ln_Operador
        _MacPCLocalCreacion = ls_MacPCLocalCreacion
        _IndServicioMaterial = ls_IndServicioMaterial
        _GlosaCtaxCyP = ls_GlosaCtaxCyP
        _CuoMomentaneo = ls_CuoMomentaneo
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModificacion = ld_FechaModificacion
        _CodigoUnicoOperacion = --CodigoUnicoOperacion
        _IndElectronico = ln_IndElectronico
        _IndEnviado = ln_IndEnviado
        _IndAnulado = ln_IndAnulado
        _IdTipoBien = ls_IdTipoBien
        _OrdenCompra = ls_OrdenCompra
        _IndAnexo = ln_IndAnexo
        _CodMotivo = ls_CodMotivo
        _VentaGratuita = lb_VentaGratuita
        _Descuento = ln_Descuento
        _EsAnulado = lb_EsAnulado
        _EnviadoEmail = lb_EnviadoEmail
        _EnviadoExterno = lb_EnviadoExterno
        _IndAfectoIVA = lb_IndAfectoIVA
        _EstadoElectronico = ls_EstadoElectronico
        _EstadoPago = ls_EstadoPago
        _FechaRevision = ld_FechaRevision
        _UsuarioRevision = ls_UsuarioRevision
        _EnvioPortal = ls_EnvioPortal
        _Retencion_Letra = ln_Retencion_Letra
        _Retencion_Saldo = ln_Retencion_Saldo
        _IndAnticipo = lb_IndAnticipo
        _IndAfectaAnticipo = lb_IndAfectaAnticipo
        _Monto_Anticipo = ln_Monto_Anticipo
    End Sub

#End Region
#Region "Propiedades"


    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Public Property IdTipoDocumento() As String
        Get
            Return _IdTipoDocumento
        End Get
        Set(ByVal value As String)
            _IdTipoDocumento = value
        End Set
    End Property
    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(ByVal value As String)
            _Serie = value
        End Set
    End Property
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property
    Public Property FechaEmision() As Date
        Get
            Return _FechaEmision
        End Get
        Set(ByVal value As Date)
            _FechaEmision = value
        End Set
    End Property
    Public Property FechaVencimiento() As Date
        Get
            Return _FechaVencimiento
        End Get
        Set(ByVal value As Date)
            _FechaVencimiento = value
        End Set
    End Property
    Public Property NoGravadas() As Double
        Get
            Return _NoGravadas
        End Get
        Set(ByVal value As Double)
            _NoGravadas = value
        End Set
    End Property
    Public Property IGV() As Double
        Get
            Return _IGV
        End Get
        Set(ByVal value As Double)
            _IGV = value
        End Set
    End Property
    Public Property SubTotal() As Double
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Double)
            _SubTotal = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property
    Public Property Saldo() As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property
    Public Property IdClienteProveedor() As String
        Get
            Return _IdClienteProveedor
        End Get
        Set(ByVal value As String)
            _IdClienteProveedor = value
        End Set
    End Property
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property
    Public Property IndCompraVenta() As Integer
        Get
            Return _IndCompraVenta
        End Get
        Set(ByVal value As Integer)
            _IndCompraVenta = value
        End Set
    End Property
    Public Property IdPeriodo() As String
        Get
            Return _IdPeriodo
        End Get
        Set(ByVal value As String)
            _IdPeriodo = value
        End Set
    End Property
    Public Property IdMoneda() As String
        Get
            Return _IdMoneda
        End Get
        Set(ByVal value As String)
            _IdMoneda = value
        End Set
    End Property
    Public Property TipoCambio() As Double
        Get
            Return _TipoCambio
        End Get
        Set(ByVal value As Double)
            _TipoCambio = value
        End Set
    End Property
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property
    Public Property IdCuentaContable() As String
        Get
            Return _IdCuentaContable
        End Get
        Set(ByVal value As String)
            _IdCuentaContable = value
        End Set
    End Property
    Public Property IdEstadoDocumento() As String
        Get
            Return _IdEstadoDocumento
        End Get
        Set(ByVal value As String)
            _IdEstadoDocumento = value
        End Set
    End Property
    Public Property Operador() As Integer
        Get
            Return _Operador
        End Get
        Set(ByVal value As Integer)
            _Operador = value
        End Set
    End Property
    Public Property MacPCLocalCreacion() As String
        Get
            Return _MacPCLocalCreacion
        End Get
        Set(ByVal value As String)
            _MacPCLocalCreacion = value
        End Set
    End Property
    Public Property IndServicioMaterial() As String
        Get
            Return _IndServicioMaterial
        End Get
        Set(ByVal value As String)
            _IndServicioMaterial = value
        End Set
    End Property
    Public Property GlosaCtaxCyP() As String
        Get
            Return _GlosaCtaxCyP
        End Get
        Set(ByVal value As String)
            _GlosaCtaxCyP = value
        End Set
    End Property
    Public Property CuoMomentaneo() As String
        Get
            Return _CuoMomentaneo
        End Get
        Set(ByVal value As String)
            _CuoMomentaneo = value
        End Set
    End Property
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property
    Public Property FechaModificacion() As Date
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property
    Public Property CodigoUnicoOperacion() As String
        Get
            Return _CodigoUnicoOperacion
        End Get
        Set(ByVal value As String)
            _CodigoUnicoOperacion = value
        End Set
    End Property
    Public Property IndElectronico() As Integer
        Get
            Return _IndElectronico
        End Get
        Set(ByVal value As Integer)
            _IndElectronico = value
        End Set
    End Property
    Public Property IndEnviado() As Integer
        Get
            Return _IndEnviado
        End Get
        Set(ByVal value As Integer)
            _IndEnviado = value
        End Set
    End Property
    Public Property IndAnulado() As Integer
        Get
            Return _IndAnulado
        End Get
        Set(ByVal value As Integer)
            _IndAnulado = value
        End Set
    End Property
    Public Property IdTipoBien() As String
        Get
            Return _IdTipoBien
        End Get
        Set(ByVal value As String)
            _IdTipoBien = value
        End Set
    End Property
    Public Property OrdenCompra() As String
        Get
            Return _OrdenCompra
        End Get
        Set(ByVal value As String)
            _OrdenCompra = value
        End Set
    End Property
    Public Property IndAnexo() As Integer
        Get
            Return _IndAnexo
        End Get
        Set(ByVal value As Integer)
            _IndAnexo = value
        End Set
    End Property
    Public Property CodMotivo() As String
        Get
            Return _CodMotivo
        End Get
        Set(ByVal value As String)
            _CodMotivo = value
        End Set
    End Property
    Public Property VentaGratuita() As Boolean
        Get
            Return _VentaGratuita
        End Get
        Set(ByVal value As Boolean)
            _VentaGratuita = value
        End Set
    End Property
    Public Property Descuento() As Double
        Get
            Return _Descuento
        End Get
        Set(ByVal value As Double)
            _Descuento = value
        End Set
    End Property
    Public Property EsAnulado() As Boolean
        Get
            Return _EsAnulado
        End Get
        Set(ByVal value As Boolean)
            _EsAnulado = value
        End Set
    End Property
    Public Property EnviadoEmail() As Boolean
        Get
            Return _EnviadoEmail
        End Get
        Set(ByVal value As Boolean)
            _EnviadoEmail = value
        End Set
    End Property
    Public Property EnviadoExterno() As Boolean
        Get
            Return _EnviadoExterno
        End Get
        Set(ByVal value As Boolean)
            _EnviadoExterno = value
        End Set
    End Property
    Public Property IndAfectoIVA() As Boolean
        Get
            Return _IndAfectoIVA
        End Get
        Set(ByVal value As Boolean)
            _IndAfectoIVA = value
        End Set
    End Property
    Public Property EstadoElectronico() As String
        Get
            Return _EstadoElectronico
        End Get
        Set(ByVal value As String)
            _EstadoElectronico = value
        End Set
    End Property
    Public Property EstadoPago() As String
        Get
            Return _EstadoPago
        End Get
        Set(ByVal value As String)
            _EstadoPago = value
        End Set
    End Property
    Public Property FechaRevision() As Date
        Get
            Return _FechaRevision
        End Get
        Set(ByVal value As Date)
            _FechaRevision = value
        End Set
    End Property
    Public Property UsuarioRevision() As String
        Get
            Return _UsuarioRevision
        End Get
        Set(ByVal value As String)
            _UsuarioRevision = value
        End Set
    End Property
    Public Property EnvioPortal() As String
        Get
            Return _EnvioPortal
        End Get
        Set(ByVal value As String)
            _EnvioPortal = value
        End Set
    End Property
    Public Property Retencion_Letra() As Double
        Get
            Return _Retencion_Letra
        End Get
        Set(ByVal value As Double)
            _Retencion_Letra = value
        End Set
    End Property
    Public Property Retencion_Saldo() As Double
        Get
            Return _Retencion_Saldo
        End Get
        Set(ByVal value As Double)
            _Retencion_Saldo = value
        End Set
    End Property
    Public Property IndAnticipo() As Boolean
        Get
            Return _IndAnticipo
        End Get
        Set(ByVal value As Boolean)
            _IndAnticipo = value
        End Set
    End Property
    Public Property IndAfectaAnticipo() As Boolean
        Get
            Return _IndAfectaAnticipo
        End Get
        Set(ByVal value As Boolean)
            _IndAfectaAnticipo = value
        End Set
    End Property
    Public Property Monto_Anticipo() As Double
        Get
            Return _Monto_Anticipo
        End Get
        Set(ByVal value As Double)
            _Monto_Anticipo = value
        End Set
    End Property
#End Region
End Class