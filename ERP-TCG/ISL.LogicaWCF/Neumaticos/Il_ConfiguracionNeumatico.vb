Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ConfiguracionNeumatico", también debe actualizar la referencia a "Il_ConfiguracionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_ConfiguracionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As e_ConfiguracionNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As List(Of e_ConfiguracionNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As Boolean

End Interface
