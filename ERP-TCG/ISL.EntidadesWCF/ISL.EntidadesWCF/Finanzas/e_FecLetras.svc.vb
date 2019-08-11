<DataContract()> _
Public Class e_FecLetras
    Implements Ie_FecLetras

#Region "Declaracion de Variables"

    Private _id As String
    Private _idobligacionfinanciera As String
    Private _indclienteproveedor As Integer
    Private _idclienteproveedor As String
    Private _activo As Boolean
    Private _nroletra As String
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
    Public Property IdObligacionFinanciera() As String
        Get
            Return _idobligacionfinanciera
        End Get
        Set(ByVal value As String)
            _idobligacionfinanciera = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndClienteProveedor() As Integer
        Get
            Return _indclienteproveedor
        End Get
        Set(ByVal value As Integer)
            _indclienteproveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteProveedor() As String
        Get
            Return _idclienteproveedor
        End Get
        Set(ByVal value As String)
            _idclienteproveedor = value
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
    Public Property NroLetra() As String
        Get
            Return _nroletra
        End Get
        Set(ByVal value As String)
            _nroletra = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idobligacionfinanciera = String.Empty
        _indclienteproveedor = 0
        _idclienteproveedor = String.Empty
        _activo = True
        _nroletra = String.Empty
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(fecletra As e_FecLetras) As e_FecLetras Implements Ie_FecLetras.Obtener
        Return fecletra
    End Function

#End Region

End Class
