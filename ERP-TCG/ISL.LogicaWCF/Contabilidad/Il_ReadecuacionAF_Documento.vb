Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ReadecuacionAF_Documento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ReadecuacionAF_Documento

    <OperationContract()>
    Function Obtener(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As e_ReadecuacionAF_Documento

    <OperationContract()>
    Function Listar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As List(Of e_ReadecuacionAF_Documento)

    <OperationContract()>
    Function Guardar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean

    <OperationContract()>
    Function Eliminar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean


End Interface
