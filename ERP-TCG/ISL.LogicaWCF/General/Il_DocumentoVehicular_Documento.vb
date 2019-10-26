Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoVehicular_Documento", también debe actualizar la referencia a "Il_DocumentoVehicular_Documento" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoVehicular_Documento

    <OperationContract()> _
     Function Listar(ByVal oeDocVeh_Doc As e_DocumentoVehicular_Documento) As List(Of e_DocumentoVehicular_Documento)

    <OperationContract()> _
     Function Guardar(ByVal oeDocVeh_Doc As e_DocumentoVehicular_Documento) As Boolean

    <OperationContract()> _
   Function ComboGrilla(ByVal Lista As List(Of e_DocumentoVehicular_Documento))

End Interface
