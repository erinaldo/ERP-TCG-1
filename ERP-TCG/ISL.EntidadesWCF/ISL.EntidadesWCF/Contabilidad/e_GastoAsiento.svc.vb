<DataContract()> _
Public Class e_GastoAsiento
    Implements Ie_GastoAsiento

#Region "Propiedad"

    Private _id As String
    Private _idgastooperacion As String
    Private _idasiento As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public NroMes As Integer
    <DataMember()> _
    Public IdItemGasto As String
    <DataMember()> _
    Public IdCuentaContable As String
   
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdGastoOperacion() As String
        Get
            Return _idgastooperacion
        End Get
        Set(ByVal value As String)
            _idgastooperacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsiento() As String
        Get
            Return _idasiento
        End Get
        Set(ByVal value As String)
            _idasiento = value
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

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        IdAsiento = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGastoOperacion As String _
              , ByVal ls_IdAsiento As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idgastooperacion = ls_IdGastoOperacion
        _idasiento = ls_IdAsiento
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal gastoAsiento As e_GastoAsiento) As e_GastoAsiento Implements Ie_GastoAsiento.Obtener
        Return gastoAsiento
    End Function

End Class
