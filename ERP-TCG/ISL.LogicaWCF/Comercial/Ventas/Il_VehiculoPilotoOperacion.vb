Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_VehiculoPilotoOperacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_VehiculoPilotoOperacion

    '<OperationContract()>
    'Sub DoWork()
    <OperationContract()> _
    Function Obtener(oeVehiculoPiloto As e_VehiculoPilotoOperacion) As e_VehiculoPilotoOperacion

    <OperationContract()> _
    Function Listar(oeVehiculoPiloto As e_VehiculoPilotoOperacion) As List(Of e_VehiculoPilotoOperacion)

    <OperationContract()> _
    Function Guardar(oeVehiculoPiloto As List(Of e_VehiculoPilotoOperacion)) As Boolean

    <OperationContract()> _
    Function Eliminar(oeVehiculoPiloto As e_VehiculoPilotoOperacion) As Boolean
End Interface
