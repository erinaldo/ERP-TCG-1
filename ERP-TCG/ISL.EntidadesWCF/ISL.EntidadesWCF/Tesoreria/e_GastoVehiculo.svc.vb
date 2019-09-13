


' NOTA: si cambia aquí el nombre de clase "e_GastoVehiculo", también debe actualizar la referencia a "e_GastoVehiculo" tanto en Web.config como en el archivo .svc asociado.
Public Class e_GastoVehiculo
    Implements Ie_GastoVehiculo

#Region "Propiedad"

    Private _id As String
    Private _idgastocaja As String
    Private _idvehiculo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

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
    Public Property IdGastoCaja() As String
        Get
            Return _idgastocaja
        End Get
        Set(ByVal value As String)
            _idgastocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
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
              , ByVal ls_IdVehiculo As String _
           )
        _id = ls_Id
        _idgastocaja = ls_IdGastoOperacion
        _idvehiculo = ls_IdVehiculo
    End Sub

#End Region

    Public Function Obtener(ByVal gastovehiculo As e_GastoVehiculo) As e_GastoVehiculo Implements Ie_GastoVehiculo.Obtener
        Return gastovehiculo
    End Function

End Class

