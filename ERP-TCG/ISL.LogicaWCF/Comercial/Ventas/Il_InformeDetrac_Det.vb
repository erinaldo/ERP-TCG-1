Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_InformeDetrac_Det", también debe actualizar la referencia a "Il_InformeDetrac_Det" en Web.config.
<ServiceContract()> _
Public Interface Il_InformeDetrac_Det

    <OperationContract()> _
    Function Obtener(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As e_InformeDetrac_Det

    <OperationContract()> _
    Function Listar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As List(Of e_InformeDetrac_Det)

    <OperationContract()> _
    Function Validar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeInformeDetrac_Det As e_InformeDetrac_Det) As Boolean

End Interface
