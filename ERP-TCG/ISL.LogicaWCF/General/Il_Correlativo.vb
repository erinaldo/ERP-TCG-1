Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Correlativo", también debe actualizar la referencia a "Il_Correlativo" en Web.config.
<ServiceContract()> _
Public Interface Il_Correlativo

    <OperationContract()>
    Function Obtener(ByVal oeCorrelativo As e_Correlativo) As e_Correlativo

    <OperationContract()> _
    Function Listar(ByVal oeCorrelativo As e_Correlativo) As List(Of e_Correlativo)

    <OperationContract()> _
    Function Validar(ByVal oeCorrelativo As e_Correlativo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCorrelativo As e_Correlativo) As Boolean

End Interface
