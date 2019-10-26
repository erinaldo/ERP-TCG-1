Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ModeloFuncionalVehiculo", también debe actualizar la referencia a "Il_ModeloFuncionalVehiculo" en Web.config.
<ServiceContract()> _
Public Interface Il_ModeloFuncionalVehiculo

    <OperationContract()> _
    Function Obtener(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As e_ModeloFuncionalVehiculo

    <OperationContract()> _
    Function Listar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As List(Of e_ModeloFuncionalVehiculo)

    <OperationContract()> _
    Function Validar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeModeloFuncionalVehiculo As e_ModeloFuncionalVehiculo) As Boolean

End Interface
