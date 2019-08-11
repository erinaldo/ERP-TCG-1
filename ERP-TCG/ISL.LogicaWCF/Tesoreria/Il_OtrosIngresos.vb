Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_OtrosIngresos", también debe actualizar la referencia a "Il_OtrosIngresos" en Web.config.
<ServiceContract()> _
Public Interface Il_OtrosIngresos

    <OperationContract()> _
    Function Obtener(ByVal oeOtrosIngresos As e_OtrosIngresos) As e_OtrosIngresos

    <OperationContract()> _
    Function Listar(ByVal oeOtrosIngresos As e_OtrosIngresos) As List(Of e_OtrosIngresos)

    <OperationContract()> _
    Function Validar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOtrosIngresos As e_OtrosIngresos) As Boolean

End Interface
