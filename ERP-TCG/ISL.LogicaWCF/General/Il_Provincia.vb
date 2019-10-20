Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Provincia", también debe actualizar la referencia a "Il_Provincia" en Web.config.
<ServiceContract()> _
Public Interface Il_Provincia

    <OperationContract()> _
    Function Obtener(ByVal oeProvincia As e_Provincia) As e_Provincia

    <OperationContract()> _
    Function Listar(ByVal oeProvincia As e_Provincia) As List(Of e_Provincia)

    <OperationContract()> _
    Function Guardar(ByVal oeProvincia As e_Provincia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProvincia As e_Provincia) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeProvincia As e_Provincia) As Boolean

End Interface
