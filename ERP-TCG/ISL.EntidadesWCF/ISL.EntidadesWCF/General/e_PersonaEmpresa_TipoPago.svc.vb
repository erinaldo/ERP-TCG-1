

<DataContract()> _
Public Class e_PersonaEmpresa_TipoPago
    Implements Ie_PersonaEmpresa_TipoPago
    Implements IEquatable(Of e_PersonaEmpresa_TipoPago)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idclienteproveedor As String
    Private _indclienteproveedor As Integer
    Private _idtipopago As String
    Private _tipopago As String
    Private _dias As Integer
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String

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
    Public Property IdClienteProveedor() As String
        Get
            Return _idclienteproveedor
        End Get
        Set(ByVal value As String)
            _idclienteproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndClienteProveedor() As String
        Get
            Return _indclienteproveedor
        End Get
        Set(ByVal value As String)
            _indclienteproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Dim _tipo As String = ""
            Select Case _indclienteproveedor
                Case 1 : _tipo = "CLIENTE"
                Case 2 : _tipo = "PROVEEDOR"
            End Select
            Return _tipo
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoPago() As String
        Get
            Return _idtipopago
        End Get
        Set(ByVal value As String)
            _idtipopago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoPago() As String
        Get
            Return _tipopago
        End Get
        Set(ByVal value As String)
            _tipopago = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dias() As Integer
        Get
            Return _dias
        End Get
        Set(ByVal value As Integer)
            _dias = value
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
        _id = ""
        _idclienteproveedor = ""
        _indclienteproveedor = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = ""
        _activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal ln_IndClienteProveedor As Integer _
              , ByVal ls_IdTipoPago As String _
              , ByVal ls_TipoPago As String _
              , ByVal ln_Dias As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
           )
        _id = ls_Id
        _idclienteproveedor = ls_IdClienteProveedor
        _indclienteproveedor = ln_IndClienteProveedor
        _idtipopago = ls_IdTipoPago
        _tipopago = ls_TipoPago
        _dias = ln_Dias
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oePETipoPago As e_PersonaEmpresa_TipoPago) _
    As Boolean Implements IEquatable(Of e_PersonaEmpresa_TipoPago).Equals
        If Me.IdTipoPago = oePETipoPago.IdTipoPago _
        And Me.IndClienteProveedor = oePETipoPago.IndClienteProveedor Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal personaEmpresa_TipoPago As e_PersonaEmpresa_TipoPago) As e_PersonaEmpresa_TipoPago Implements Ie_PersonaEmpresa_TipoPago.Obtener
        Return personaEmpresa_TipoPago
    End Function

#End Region

End Class


