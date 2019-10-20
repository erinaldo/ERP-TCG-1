Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConfiguracionSisDet", también debe actualizar la referencia a "Il_ConfiguracionSisDet" en Web.config.
<ServiceContract()> _
Public Interface Il_ConfiguracionSisDet

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As e_ConfiguracionSisDet

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As List(Of e_ConfiguracionSisDet)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As Boolean

End Interface
