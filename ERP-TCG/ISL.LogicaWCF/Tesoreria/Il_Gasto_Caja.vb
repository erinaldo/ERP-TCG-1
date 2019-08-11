Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Gasto_Caja", también debe actualizar la referencia a "Il_Gasto_Caja" en Web.config.
<ServiceContract()> _
Public Interface Il_Gasto_Caja

    <OperationContract()> _
    Function Obtener(ByVal oeGasto_Caja As e_Gasto_Caja) As e_Gasto_Caja

    <OperationContract()> _
    Function Listar(ByVal oeGasto_Caja As e_Gasto_Caja) As List(Of e_Gasto_Caja)

    <OperationContract()> _
    Function Validar(ByVal oeGasto_Caja As e_Gasto_Caja) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGasto_Caja As e_Gasto_Caja) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGasto_Caja As e_Gasto_Caja) As Boolean

End Interface
