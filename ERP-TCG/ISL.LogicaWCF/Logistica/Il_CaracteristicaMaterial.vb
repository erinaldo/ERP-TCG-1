Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CaracteristicaMaterial", también debe actualizar la referencia a "Il_CaracteristicaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_CaracteristicaMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeCaracteristicaMaterial As e_CaracteristicaMaterial) As e_CaracteristicaMaterial

    <OperationContract()> _
    Function Listar(ByVal oeCaracteristicaEspecial As e_CaracteristicaMaterial) As List(Of e_CaracteristicaMaterial)

    <OperationContract()> _
    Function Guardar(ByVal oeCaracteristicaEspecial As e_CaracteristicaMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCaracteristicaEspecial As e_CaracteristicaMaterial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCaracteristicaEspecial As e_CaracteristicaMaterial) As Boolean

End Interface
