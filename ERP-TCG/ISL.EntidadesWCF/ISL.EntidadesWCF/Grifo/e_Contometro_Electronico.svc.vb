' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Contometro_Electronico" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Contometro_Electronico.svc o e_Contometro_Electronico.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_Contometro_Electronico
    Implements Ie_Contometro_Electronico
    Implements IEquatable(Of e_Contometro_Electronico)

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
    Property IdDistribuidor As Integer = -1
    <DataMember()>
    Property Conteo_inicial As Double = 0
    <DataMember()>
    Property Conteo_final As Double = 0
    <DataMember()>
    Property Movimiento_galones As Double = 0
    <DataMember()>
    Property Conteo_inicial_venta As Double = 0
    <DataMember()>
    Property Diferencia_galones As Double = 0
    <DataMember()>
    Property Precio_referencial As Double = 0
    <DataMember()>
    Property Monto_Factor As Double = 0
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(contometro_electronico As e_Contometro_Electronico) As e_Contometro_Electronico Implements Ie_Contometro_Electronico.Obtener
        Return contometro_electronico
    End Function

    Public Overloads Function Equals(other As e_Contometro_Electronico) As Boolean Implements IEquatable(Of e_Contometro_Electronico).Equals
        If Me.Id = other.Id Then Return True
        Return False
    End Function

#End Region


End Class
