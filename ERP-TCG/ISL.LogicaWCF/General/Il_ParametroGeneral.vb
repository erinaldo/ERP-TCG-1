Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ParametroGeneral", también debe actualizar la referencia a "Il_ParametroGeneral" en Web.config.
<ServiceContract()> _
Public Interface Il_ParametroGeneral

    <OperationContract()> _
    Function Obtener(ByVal oeParametroGeneral As e_ParametroGeneral) As e_ParametroGeneral

    <OperationContract()> _
    Function Listar(ByVal oeParametroGeneral As e_ParametroGeneral) As List(Of e_ParametroGeneral)

    <OperationContract()> _
    Function Validar(ByVal oeParametroGeneral As e_ParametroGeneral) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeParametroGeneral As e_ParametroGeneral) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeParametroGeneral As e_ParametroGeneral) As Boolean

End Interface
