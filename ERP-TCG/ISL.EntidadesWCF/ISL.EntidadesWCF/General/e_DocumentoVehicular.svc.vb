

<DataContract()> _
Public Class e_DocumentoVehicular
    Implements Ie_DocumentoVehicular
    Implements IEquatable(Of e_DetalleDocumentoVehiculo)

#Region "Propiedad"

    Private _id As String
    Private _idempresaemisora As String
    Private _empresaemisora As String
    Private _idempresapropietaria As String
    Private _empresapropietaria As String
    Private _numero As String
    Private _idtipodocumento As String
    Private _tipodocumento As String
    Private _vehiculo As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _importe As Double
    Private _peso As Double
    Private _descripcion As String
    Private _activo As Boolean
    Private _moneda As String
    Private _nroresolucion As String
    Private _bonificacion As Double
    Private _porcentaje As Double
    Private _tipo As String
    Private _resultado As String
    Private _fechaadquisicion As Date

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public ldDetalleDocVeh As New List(Of e_DetalleDocumentoVehiculo)
    <DataMember()> _
    Public ldCuotaDocVeh As New List(Of e_CuotaDocumentoVehiculo)
    <DataMember()> _
    Public ldBonoVeh As New List(Of e_BonificacionVehiculo)
    <DataMember()> _
    Public ldRevisionTec As New List(Of e_RevisionTecnica)
    <DataMember()> _
    Public ldDocVeh_Doc As New List(Of e_DocumentoVehicular_Documento)
    <DataMember()> _
   Public ldCuotaDocVeh_Movimiento As New List(Of e_CuotaDocVeh_Movimiento)
    <DataMember()> _
    Public IndVigencia As Boolean

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
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
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
    Public Property IdEmpresaEmisora() As String
        Get
            Return _idempresaemisora
        End Get
        Set(ByVal value As String)
            _idempresaemisora = value
        End Set
    End Property

    <DataMember()> _
    Public Property EmpresaEmisora() As String
        Get
            Return _empresaemisora
        End Get
        Set(ByVal value As String)
            _empresaemisora = value
        End Set
    End Property

    <DataMember()> _
  Public Property IdEmpresaPropietaria() As String
        Get
            Return _idempresapropietaria
        End Get
        Set(ByVal value As String)
            _idempresapropietaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property EmpresaPropietaria() As String
        Get
            Return _empresapropietaria
        End Get
        Set(ByVal value As String)
            _empresapropietaria = value
        End Set
    End Property

    <DataMember()> _
   Public Property IdMoneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
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
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property Peso() As Double
        Get
            Return _peso
        End Get
        Set(ByVal value As Double)
            _peso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Public Property IdVehiculo() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroResolucion() As String
        Get
            Return _nroresolucion
        End Get
        Set(ByVal value As String)
            _nroresolucion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bonificacion() As Double
        Get
            Return _bonificacion
        End Get
        Set(ByVal value As Double)
            _bonificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Porcentaje() As Double
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Double)
            _porcentaje = value
        End Set
    End Property

    <DataMember()> _
   Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
   Public Property Resultado() As String
        Get
            Return _resultado
        End Get
        Set(ByVal value As String)
            _resultado = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaAdquisicion() As Date
        Get
            Return _fechaadquisicion
        End Get
        Set(ByVal value As Date)
            _fechaadquisicion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Id = ""
        IdEmpresaEmisora = ""
        IdEmpresaPropietaria = ""
        IdTipoDocumento = ""
        IdMoneda = ""
        IdVehiculo = ""
        Activo = True
        TipoOperacion = ""
        Descripcion = ""
        IndVigencia = False
        NroResolucion = ""
        Bonificacion = 0.0
        Porcentaje = 0.0
        Importe = 0.0
        Resultado = ""
        Tipo = ""
        FechaEmision = "01/01/1991"
        FechaVencimiento = "01/01/1991"
        FechaAdquisicion = "01/01/1991"
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_Numero As String _
              , ByVal ls_IdEmpresaCertifica As String _
              , ByVal ls_EmpresaEmisora As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ln_Importe As Double _
              , ByVal ln_Peso As Double _
              , ByVal ls_Descripcion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdEmpresaPropietaria As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_NroResolucion As String _
              , ByVal ld_Bonificacion As Double _
              , ByVal ld_Porcentaje As Double _
              , ByVal ls_tipo As String _
              , ByVal ls_resultado As String _
              , ByVal ld_FechaAdquision As Date _
           )
        _id = ls_Id
        _idtipodocumento = ls_IdTipoDocumento
        _tipodocumento = ls_TipoDocumento
        _idempresaemisora = ls_IdEmpresaCertifica
        _empresaemisora = ls_EmpresaEmisora
        _numero = ls_Numero
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _importe = ln_Importe
        _peso = ln_Peso
        _descripcion = ls_Descripcion
        _activo = lb_Activo
        _idempresapropietaria = ls_IdEmpresaPropietaria
        _moneda = ls_IdMoneda
        _nroresolucion = ls_NroResolucion
        _bonificacion = ld_Bonificacion
        _porcentaje = ld_Porcentaje
        _tipo = ls_tipo
        _resultado = ls_resultado
        _fechaadquisicion = ld_FechaAdquision

    End Sub

    Public Overloads Function Equals(ByVal oeDetDoc As e_DetalleDocumentoVehiculo) _
    As Boolean Implements IEquatable(Of e_DetalleDocumentoVehiculo).Equals
        If Me.IdVehiculo = oeDetDoc.IdVehiculo Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal documentoVehicular As e_DocumentoVehicular) As e_DocumentoVehicular Implements Ie_DocumentoVehicular.Obtener
        Return documentoVehicular
    End Function

#End Region

End Class


