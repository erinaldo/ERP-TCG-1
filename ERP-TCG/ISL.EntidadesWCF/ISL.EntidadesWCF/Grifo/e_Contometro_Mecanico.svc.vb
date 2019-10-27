' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Contometro_Mecanico" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Contometro_Mecanico.svc o e_Contometro_Mecanico.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_Contometro_Mecanico
    Implements Ie_Contometro_Mecanico
    Implements IEquatable(Of e_Contometro_Mecanico)

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
    Property IdContometro_Electronico As Integer = -1
    <DataMember()>
    Property Conteo_inicial As Integer = 0
    <DataMember()>
    Property Conteo_final As Integer = 0
    <DataMember()>
    Property Movimiento_contometro As Integer = 0
    <DataMember()>
    Property Movimiento_galon As Double = 0
    <DataMember()>
    Property Diferencia As Double = 0
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(contometro_electronico As e_Contometro_Mecanico) As e_Contometro_Mecanico Implements Ie_Contometro_Mecanico.Obtener
        Throw New NotImplementedException()
    End Function

    Public Function Equals(other As e_Contometro_Mecanico) As Boolean Implements IEquatable(Of e_Contometro_Mecanico).Equals
        Throw New NotImplementedException()
    End Function

#End Region

End Class
