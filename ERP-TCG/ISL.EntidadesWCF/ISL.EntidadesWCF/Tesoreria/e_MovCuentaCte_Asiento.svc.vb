


<DataContract()> _
Public Class e_MovCuentaCte_Asiento
    Implements Ie_MovCuentaCte_Asiento

#Region "Declaracion de Variables"

    Private _id As String
    Private _idmovcuentacte As String
    Private _idasiento As String
    Private _activo As Boolean

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

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
    Public Property IdMovCuentaCte() As String
        Get
            Return _idmovcuentacte
        End Get
        Set(ByVal value As String)
            _idmovcuentacte = value
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
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovCuentaCte As String _
              , ByVal ls_IdAsiento As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idmovcuentacte = ls_IdMovCuentaCte
        _idasiento = ls_IdAsiento
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal movcuentacte_asiento As e_MovCuentaCte_Asiento) As e_MovCuentaCte_Asiento Implements Ie_MovCuentaCte_Asiento.Obtener
        Return movcuentacte_asiento
    End Function

End Class

