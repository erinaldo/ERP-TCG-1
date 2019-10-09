<DataContract()> _
Public Class e_DocumentoAsociado
    Implements Ie_DocumentoAsociado
    Implements IEquatable(Of e_MovimientoDocumento)

#Region "Propiedad"

    Private _id As String
    Private _idmovimientodocumento As String
    Private _idmovimientodocumentoasoc As String
    Private _indafectadocumento As Boolean
    Private _activo As Boolean

    Private _monto_operar As Double
    Private _monto_desc As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumentoAsoc() As String
        Get
            Return _idmovimientodocumentoasoc
        End Get
        Set(ByVal value As String)
            _idmovimientodocumentoasoc = value
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
    Public Property IndAfectaDocumento() As Boolean
        Get
            Return _indafectadocumento
        End Get
        Set(ByVal value As Boolean)
            _indafectadocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto_Operar() As Double
        Get
            Return _monto_operar
        End Get
        Set(ByVal value As Double)
            _monto_operar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto_Desc() As Double
        Get
            Return _monto_desc
        End Get
        Set(ByVal value As Double)
            _monto_desc = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        TipoOperacion = ""
        Monto_Operar = 0.0
        Monto_Desc = 0.0
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IdMovimientoDocumentoAsoc As String _
              , ByVal lb_AfectaDocumento As Boolean _
              , ByVal lb_Activo As Boolean)
        _id = ls_Id
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idmovimientodocumentoasoc = ls_IdMovimientoDocumentoAsoc
        _indafectadocumento = lb_AfectaDocumento
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals1(ByVal other As e_MovimientoDocumento) As Boolean Implements System.IEquatable(Of e_MovimientoDocumento).Equals
        If Me.IdMovimientoDocumentoAsoc = other.Id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal documentoAsociado As e_DocumentoAsociado) As e_DocumentoAsociado Implements Ie_DocumentoAsociado.Obtener
        Return documentoAsociado
    End Function

#End Region

End Class
