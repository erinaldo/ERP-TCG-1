Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Material_DisenoNeu", también debe actualizar la referencia a "Il_Material_DisenoNeu" en Web.config.
<ServiceContract()> _
Public Interface Il_Material_DisenoNeu

    <OperationContract()> _
   Function Obtener(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As e_Material_DisenoNeu

    <OperationContract()> _
    Function Listar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As List(Of e_Material_DisenoNeu)

    <OperationContract()> _
    Function Guardar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean

End Interface
