' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_TurnoCierre" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_TurnoCierre.svc o e_TurnoCierre.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_TurnoCierre
    Implements Ie_TurnoCierre
    Implements IEquatable(Of e_TurnoCierre)

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
    Property IdTurno As String = ""
    <DataMember()>
    Property Turno As Integer = -1
    <DataMember()>
    Property FechaOperacion As Date = #01/01/1901#
    <DataMember()>
    Property NroCorrelativo As String = ""
    <DataMember()>
    Property NroOperaciones As Integer = -1
    <DataMember()>
    Property SubTotal As Double = 0
    <DataMember()>
    Property Igv As Double = 0
    <DataMember()>
    Property Total As Double = 0
    <DataMember()>
    Property Nro_Doc_Inicial As String = ""
    <DataMember()>
    Property Nro_Doc_Final As String = ""
    <DataMember()>
    Property Cantidad_Anulados As Integer = -1
    <DataMember()>
    Property Monto_Anulados As Double = 0
    <DataMember()>
    Property TipoCambio As Double = 0
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(turnocierre As e_TurnoCierre) As e_TurnoCierre Implements Ie_TurnoCierre.Obtener
        Return turnocierre
    End Function

    Public Overloads Function Equals(other As e_TurnoCierre) As Boolean Implements IEquatable(Of e_TurnoCierre).Equals
        Return False
    End Function

#End Region


End Class
