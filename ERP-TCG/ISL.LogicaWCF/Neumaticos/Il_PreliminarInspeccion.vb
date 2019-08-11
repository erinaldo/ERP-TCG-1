Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_PreliminarInspeccion", también debe actualizar la referencia a "Il_PreliminarInspeccion" en Web.config.
<ServiceContract()> _
Public Interface Il_PreliminarInspeccion

    <OperationContract()> _
Function Obtener(ByVal oepreliminarinspeccion As e_PreliminarInspeccion) As e_PreliminarInspeccion

    <OperationContract()> _
    Function Listar(ByVal oepreliminarinspeccion As e_PreliminarInspeccion) As List(Of e_PreliminarInspeccion)

    <OperationContract()> _
    Function Guardar(ByVal oepreliminarinspeccion As e_PreliminarInspeccion) As Boolean

    <OperationContract()> _
    Function Enviar(ByVal oepreliminarinspeccion As e_PreliminarInspeccion) As Boolean

End Interface
