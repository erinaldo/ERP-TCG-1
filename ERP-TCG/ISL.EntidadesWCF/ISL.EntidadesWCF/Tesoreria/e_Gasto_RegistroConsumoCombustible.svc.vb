


<DataContract()> _
Public Class e_Gasto_RegistroConsumoCombustible
    Implements Ie_Gasto_RegistroConsumoCombustible

#Region "Propiedad"

    Private _id As String
    Private _idgastooperacion As String
    Private _idregistroconsumocombustible As String

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
    Public Property IdRegistroConsumoCombustible() As String
        Get
            Return _idregistroconsumocombustible
        End Get
        Set(ByVal value As String)
            _idregistroconsumocombustible = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGastoOperacion As String _
              , ByVal ls_IdRegistroConsumoCombustible As String _
           )
        _id = ls_Id
        _idgastooperacion = ls_IdGastoOperacion
        _idregistroconsumocombustible = ls_IdRegistroConsumoCombustible
    End Sub

#End Region

    Public Function Obtener(ByVal gasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As e_Gasto_RegistroConsumoCombustible Implements Ie_Gasto_RegistroConsumoCombustible.Obtener
        Return gasto_RegistroConsumoCombustible
    End Function

End Class

