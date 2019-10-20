Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_TrabajadorSeguridad", también debe actualizar la referencia a "Il_TrabajadorSeguridad" en Web.config.
<ServiceContract()> _
Public Interface Il_TrabajadorSeguridad

    <OperationContract()> _
    Function Obtener(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As e_TrabajadorSeguridad

    <OperationContract()> _
    Function Listar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As List(Of e_TrabajadorSeguridad)

    '<OperationContract()> _
    'Function ListarProcesosDelTrabajador(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As List(Of e_TrabajadorSeguridad)

    <OperationContract()> _
    Function Guardar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean

    <OperationContract()> _
    Sub ValidarDuplicado(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad)

End Interface
