Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_InformeDetrac", también debe actualizar la referencia a "Il_InformeDetrac" en Web.config.
<ServiceContract()> _
Public Interface Il_InformeDetrac

    <OperationContract()> _
    Function Obtener(ByVal oeInformeDetrac As e_InformeDetrac) As e_InformeDetrac

    <OperationContract()> _
    Function Listar(ByVal oeInformeDetrac As e_InformeDetrac) As List(Of e_InformeDetrac)

    <OperationContract()> _
    Function Validar(ByVal oeInformeDetrac As e_InformeDetrac) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeInformeDetrac As e_InformeDetrac) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeInformeDetrac As e_InformeDetrac) As Boolean

End Interface
