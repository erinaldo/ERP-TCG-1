Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Dispositivo", también debe actualizar la referencia a "Il_Dispositivo" en Web.config.
<ServiceContract()> _
Public Interface Il_Dispositivo

    <OperationContract()> _
    Function Obtener(ByVal oeDispositivo As e_Dispositivo) As e_Dispositivo

    <OperationContract()> _
    Function Listar(ByVal oeDispositivo As e_Dispositivo) As List(Of e_Dispositivo)

    <OperationContract()> _
    Function Validar(ByVal oeDispositivo As e_Dispositivo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDispositivo As e_Dispositivo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDispositivo As e_Dispositivo) As Boolean

End Interface
