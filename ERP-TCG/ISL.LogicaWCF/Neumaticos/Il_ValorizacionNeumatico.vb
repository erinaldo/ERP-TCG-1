Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ValorizacionNeumatico", también debe actualizar la referencia a "Il_ValorizacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_ValorizacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As e_ValorizacionNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As List(Of e_ValorizacionNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeValorizacionNeumatico As e_ValorizacionNeumatico) As Boolean

End Interface
