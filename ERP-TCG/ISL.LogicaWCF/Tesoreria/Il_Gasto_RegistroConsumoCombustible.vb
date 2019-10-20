Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Gasto_RegistroConsumoCombustible", también debe actualizar la referencia a "Il_Gasto_RegistroConsumoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Il_Gasto_RegistroConsumoCombustible

    <OperationContract()> _
    Function Obtener(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As e_Gasto_RegistroConsumoCombustible

    <OperationContract()> _
    Function Listar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As List(Of e_Gasto_RegistroConsumoCombustible)

    <OperationContract()> _
    Function Validar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As Boolean

End Interface
