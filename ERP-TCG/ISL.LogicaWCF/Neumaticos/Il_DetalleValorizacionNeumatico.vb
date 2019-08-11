Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleValorizacionNeumatico", también debe actualizar la referencia a "Il_DetalleValorizacionNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleValorizacionNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As e_DetalleValorizacionNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As List(Of e_DetalleValorizacionNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean

End Interface
