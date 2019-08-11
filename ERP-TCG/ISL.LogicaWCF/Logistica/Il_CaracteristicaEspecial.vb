Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CaracteristicaEspecial", también debe actualizar la referencia a "Il_CaracteristicaEspecial" en Web.config.
<ServiceContract()> _
Public Interface Il_CaracteristicaEspecial

    <OperationContract()> _
    Function Obtener(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As e_CaracteristicaEspecial

    <OperationContract()> _
    Function Listar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As List(Of e_CaracteristicaEspecial)

    <OperationContract()> _
    Function Guardar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCaracteristicaEspecial As e_CaracteristicaEspecial) As Boolean

End Interface
