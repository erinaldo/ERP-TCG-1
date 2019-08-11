Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConfiguracionSis", también debe actualizar la referencia a "Il_ConfiguracionSis" en Web.config.
<ServiceContract()> _
Public Interface Il_ConfiguracionSis

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionSis As e_ConfiguracionSis) As e_ConfiguracionSis

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As List(Of e_ConfiguracionSis)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As Boolean

End Interface
