' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Isla" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Isla.svc o e_Isla.svc.vb en el Explorador de soluciones e inicie la depuración.

' Hola Belleza

Imports ERP.EntidadesWCF

Public Class e_Isla
    Implements Ie_Isla
    Implements IEquatable(Of e_Isla)

#Region "Declaracion de Variables"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String

#End Region

#Region "Propiedades"

    <DataMember()>
    Property Id As Integer = -1
    <DataMember()>
    Property IdEmpresaSis As String = ""
    <DataMember()>
    Property IdSucursal As String = ""
    <DataMember()>
    Property IdEstacionServicio As Integer = -1
    <DataMember()>
    Property Nombre As String = ""
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(isla As e_Isla) As e_Isla Implements Ie_Isla.Obtener
        Return isla
    End Function

    Public Overloads Function Equals(other As e_Isla) As Boolean Implements IEquatable(Of e_Isla).Equals
        If Me.Id = other.Id Then Return True
        Return False
    End Function

#End Region



End Class
