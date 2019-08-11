


<DataContract()> _
Public Class e_MovimientoDocumentoCuenta
    Implements Ie_MovimientoDocumentoCuenta

#Region "Propiedad"

    Private _id As String
    Private _idMovimientoDocumento As String
    Private _idCuentaxCyP As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property idMovimientoDocumento() As String
        Get
            Return _idMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _idMovimientoDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property idCuentaxCyP() As String
        Get
            Return _idCuentaxCyP
        End Get
        Set(ByVal value As String)
            _idCuentaxCyP = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Public Sub New( _
                ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
             , ByVal ls_IdCuentaxCyP As String _
           )

        _id = ls_Id
        _idMovimientoDocumento = ls_IdMovimientoDocumento
        _idCuentaxCyP = ls_IdCuentaxCyP

    End Sub

#End Region

    Public Function Obtener(ByVal movimientoDocumentoCuenta As e_MovimientoDocumentoCuenta) As e_MovimientoDocumentoCuenta Implements Ie_MovimientoDocumentoCuenta.Obtener
        Return movimientoDocumentoCuenta
    End Function

End Class

