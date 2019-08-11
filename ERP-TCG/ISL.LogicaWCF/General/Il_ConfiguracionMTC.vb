Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConfiguracionMTC", también debe actualizar la referencia a "Il_ConfiguracionMTC" en Web.config.
<ServiceContract()> _
Public Interface Il_ConfiguracionMTC

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As e_ConfiguracionMTC

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As List(Of e_ConfiguracionMTC)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean

End Interface
