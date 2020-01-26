Public Class e_MovimientoDocumento_Impresion


#Region "Declaración de variables"

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public IndPrincipal As Integer
    <DataMember()>
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()

    Private _Id As String
    Private _IdMovimientoDocumento As String
    Private _IdTipoDocumento As String
    Private _TipoDocumento As String
    Private _IdTurno As String
    Private _Turno As String
    Private _Lado As String
    Private _NombreClienteProveedor As String
    Private _NroDocumentoClienteProveedor As String
    Private _IdDireccion As String
    Private _Direccion As String
    Private _IdPiloto As String
    Private _Piloto As String
    Private _IdVechiculo As String
    Private _Placa As String
    Private _Kilometraje As Double
    Private _IdMedioPago As String
    Private _MedioPago As String
    Private _IdTrabajador As String
    Private _Trabajador As String
    Private _MontoLetras As String
    Private _HashResumen As String
    Private _HashSunat As String
    Private _QRCode As String
    Private _CodigoExterno As String
    Private _Ruta As String
    Private _RutaImpresionPDF As String
    Private _RutaImpresionXML As String
    Private _IdComprobantePagoElectronico_Resumen As String
    Private _ValorAux1 As Double
    Private _ValorAux2 As Double
    Private _ValorAux3 As Double
    Private _ValorAux4 As Double
    Private _ValorAux5 As Double
    Private _TextoAux1 As String
    Private _TextoAux2 As String
    Private _TextoAux3 As String
    Private _TextoAux4 As String
    Private _TextoAux5 As String
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModifica As String
    Private _FechaModificacion As Date
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdMovimientoDocumento = ""
        _IdTipoDocumento = ""
        _TipoDocumento = ""
        _IdTurno = ""
        _Turno = ""
        _Lado = ""
        _NombreClienteProveedor = ""
        _NroDocumentoClienteProveedor = ""
        _IdDireccion = ""
        _Direccion = ""
        _IdPiloto = ""
        _Piloto = ""
        _IdVechiculo = ""
        _Placa = ""
        _Kilometraje = 0
        _IdMedioPago = ""
        _MedioPago = ""
        _IdTrabajador = ""
        _Trabajador = ""
        _MontoLetras = ""
        _HashResumen = ""
        _HashSunat = ""
        _QRCode = ""
        _Ruta = ""
        _ValorAux1 = 0
        _ValorAux2 = 0
        _ValorAux3 = 0
        _TextoAux1 = ""
        _TextoAux2 = ""
        _TextoAux3 = ""
        _Activo = True
        _UsuarioCreacion = ""
        _FechaCreacion = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModificacion = #01/01/1901#
    End Sub

    Public Sub New(
          ByVal ls_Id As String _
          , ByVal ls_IdMovimientoDocumento As String _
          , ByVal ls_IdTipoDocumento As String _
          , ByVal ls_TipoDocumento As String _
          , ByVal ls_IdTurno As String _
          , ByVal ls_Turno As String _
          , ByVal ls_Lado As String _
          , ByVal ls_NombreClienteProveedor As String _
          , ByVal ls_NroDocumentoClienteProveedor As String _
          , ByVal ls_IdDireccion As String _
          , ByVal ls_Direccion As String _
          , ByVal ls_IdPiloto As String _
          , ByVal ls_Piloto As String _
          , ByVal ls_IdVechiculo As String _
          , ByVal ls_Placa As String _
          , ByVal ln_Kilometraje As Double _
          , ByVal ls_IdMedioPago As String _
          , ByVal ls_MedioPago As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Trabajador As String _
          , ByVal ls_MontoLetras As String _
          , ByVal ls_HashResumen As String _
          , ByVal ls_HashSunat As String _
          , ByVal ls_QRCode As String _
          , ByVal ls_CodigoExterno As String _
          , ByVal ls_Ruta As String _
          , ByVal ls_RutaImpresionPDF As String _
          , ByVal ls_RutaImpresionXML As String _
          , ByVal ls_IdComprobantePagoElectronico_Resumen As String _
          , ByVal ln_ValorAux1 As Double _
          , ByVal ln_ValorAux2 As Double _
          , ByVal ln_ValorAux3 As Double _
          , ByVal ln_ValorAux4 As Double _
          , ByVal ln_ValorAux5 As Double _
          , ByVal ls_TextoAux1 As String _
          , ByVal ls_TextoAux2 As String _
          , ByVal ls_TextoAux3 As String _
          , ByVal ls_TextoAux4 As String _
          , ByVal ls_TextoAux5 As String _
          , ByVal lb_Activo As Boolean _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModificacion As Date
       )
        _Id = ls_Id
        _IdMovimientoDocumento = ls_IdMovimientoDocumento
        _IdTipoDocumento = ls_IdTipoDocumento
        _TipoDocumento = ls_TipoDocumento
        _IdTurno = ls_IdTurno
        _Turno = ls_Turno
        _Lado = ls_Lado
        _NombreClienteProveedor = ls_NombreClienteProveedor
        _NroDocumentoClienteProveedor = ls_NroDocumentoClienteProveedor
        _IdDireccion = ls_IdDireccion
        _Direccion = ls_Direccion
        _IdPiloto = ls_IdPiloto
        _Piloto = ls_Piloto
        _IdVechiculo = ls_IdVechiculo
        _Placa = ls_Placa
        _Kilometraje = ln_Kilometraje
        _IdMedioPago = ls_IdMedioPago
        _MedioPago = ls_MedioPago
        _IdTrabajador = ls_IdTrabajador
        _Trabajador = ls_Trabajador
        _MontoLetras = ls_MontoLetras
        _HashResumen = ls_HashResumen
        _HashSunat = ls_HashSunat
        _QRCode = ls_QRCode
        _CodigoExterno = ls_CodigoExterno
        _Ruta = ls_Ruta
        _RutaImpresionPDF = ls_RutaImpresionPDF
        _RutaImpresionXML = ls_RutaImpresionXML
        _IdComprobantePagoElectronico_Resumen = ls_IdComprobantePagoElectronico_Resumen
        _ValorAux1 = ln_ValorAux1
        _ValorAux2 = ln_ValorAux2
        _ValorAux3 = ln_ValorAux3
        _ValorAux4 = ln_ValorAux4
        _ValorAux5 = ln_ValorAux5
        _TextoAux1 = ls_TextoAux1
        _TextoAux2 = ls_TextoAux2
        _TextoAux3 = ls_TextoAux3
        _TextoAux4 = ls_TextoAux4
        _TextoAux5 = ls_TextoAux5
        _Activo = lb_Activo
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModificacion = ld_FechaModificacion
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
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
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
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property
    Public Property IdTurno() As String
        Get
            Return _IdTurno
        End Get
        Set(ByVal value As String)
            _IdTurno = value
        End Set
    End Property
    Public Property Turno() As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property
    Public Property Lado() As String
        Get
            Return _Lado
        End Get
        Set(ByVal value As String)
            _Lado = value
        End Set
    End Property
    Public Property NombreClienteProveedor() As String
        Get
            Return _NombreClienteProveedor
        End Get
        Set(ByVal value As String)
            _NombreClienteProveedor = value
        End Set
    End Property
    Public Property NroDocumentoClienteProveedor() As String
        Get
            Return _NroDocumentoClienteProveedor
        End Get
        Set(ByVal value As String)
            _NroDocumentoClienteProveedor = value
        End Set
    End Property
    Public Property IdDireccion() As String
        Get
            Return _IdDireccion
        End Get
        Set(ByVal value As String)
            _IdDireccion = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Public Property IdPiloto() As String
        Get
            Return _IdPiloto
        End Get
        Set(ByVal value As String)
            _IdPiloto = value
        End Set
    End Property
    Public Property Piloto() As String
        Get
            Return _Piloto
        End Get
        Set(ByVal value As String)
            _Piloto = value
        End Set
    End Property
    Public Property IdVechiculo() As String
        Get
            Return _IdVechiculo
        End Get
        Set(ByVal value As String)
            _IdVechiculo = value
        End Set
    End Property
    Public Property Placa() As String
        Get
            Return _Placa
        End Get
        Set(ByVal value As String)
            _Placa = value
        End Set
    End Property
    Public Property Kilometraje() As Double
        Get
            Return _Kilometraje
        End Get
        Set(ByVal value As Double)
            _Kilometraje = value
        End Set
    End Property
    Public Property IdMedioPago() As String
        Get
            Return _IdMedioPago
        End Get
        Set(ByVal value As String)
            _IdMedioPago = value
        End Set
    End Property
    Public Property MedioPago() As String
        Get
            Return _MedioPago
        End Get
        Set(ByVal value As String)
            _MedioPago = value
        End Set
    End Property
    Public Property IdTrabajador() As String
        Get
            Return _IdTrabajador
        End Get
        Set(ByVal value As String)
            _IdTrabajador = value
        End Set
    End Property
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
        End Set
    End Property
    Public Property MontoLetras() As String
        Get
            Return _MontoLetras
        End Get
        Set(ByVal value As String)
            _MontoLetras = value
        End Set
    End Property
    Public Property HashResumen() As String
        Get
            Return _HashResumen
        End Get
        Set(ByVal value As String)
            _HashResumen = value
        End Set
    End Property
    Public Property HashSunat() As String
        Get
            Return _HashSunat
        End Get
        Set(ByVal value As String)
            _HashSunat = value
        End Set
    End Property
    Public Property QRCode() As String
        Get
            Return _QRCode
        End Get
        Set(ByVal value As String)
            _QRCode = value
        End Set
    End Property
    Public Property CodigoExterno() As String
        Get
            Return _CodigoExterno
        End Get
        Set(ByVal value As String)
            _CodigoExterno = value
        End Set
    End Property
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
    Public Property RutaImpresionPDF() As String
        Get
            Return _RutaImpresionPDF
        End Get
        Set(ByVal value As String)
            _RutaImpresionPDF = value
        End Set
    End Property
    Public Property RutaImpresionXML() As String
        Get
            Return _RutaImpresionXML
        End Get
        Set(ByVal value As String)
            _RutaImpresionXML = value
        End Set
    End Property

    Public Property IdComprobantePagoElectronico_Resumen() As String
        Get
            Return _IdComprobantePagoElectronico_Resumen
        End Get
        Set(ByVal value As String)
            _IdComprobantePagoElectronico_Resumen = value
        End Set
    End Property


    Public Property ValorAux1() As Double
        Get
            Return _ValorAux1
        End Get
        Set(ByVal value As Double)
            _ValorAux1 = value
        End Set
    End Property
    Public Property ValorAux2() As Double
        Get
            Return _ValorAux2
        End Get
        Set(ByVal value As Double)
            _ValorAux2 = value
        End Set
    End Property
    Public Property ValorAux3() As Double
        Get
            Return _ValorAux3
        End Get
        Set(ByVal value As Double)
            _ValorAux3 = value
        End Set
    End Property
    Public Property ValorAux4() As Double
        Get
            Return _ValorAux4
        End Get
        Set(ByVal value As Double)
            _ValorAux4 = value
        End Set
    End Property
    Public Property ValorAux5() As Double
        Get
            Return _ValorAux5
        End Get
        Set(ByVal value As Double)
            _ValorAux5 = value
        End Set
    End Property
    Public Property TextoAux1() As String
        Get
            Return _TextoAux1
        End Get
        Set(ByVal value As String)
            _TextoAux1 = value
        End Set
    End Property
    Public Property TextoAux2() As String
        Get
            Return _TextoAux2
        End Get
        Set(ByVal value As String)
            _TextoAux2 = value
        End Set
    End Property
    Public Property TextoAux3() As String
        Get
            Return _TextoAux3
        End Get
        Set(ByVal value As String)
            _TextoAux3 = value
        End Set
    End Property
    Public Property TextoAux4() As String
        Get
            Return _TextoAux4
        End Get
        Set(ByVal value As String)
            _TextoAux4 = value
        End Set
    End Property
    Public Property TextoAux5() As String
        Get
            Return _TextoAux5
        End Get
        Set(ByVal value As String)
            _TextoAux5 = value
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
#End Region
End Class