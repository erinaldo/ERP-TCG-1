Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Impuesto", también debe actualizar la referencia a "Il_Impuesto" en Web.config.
<ServiceContract()> _
Public Interface Il_Impuesto

    <OperationContract()> _
    Function IGV(ByVal fecha As Date) As e_Impuesto

    <OperationContract()> _
    Function Obtener(ByVal oeImpuesto As e_Impuesto) As e_Impuesto

    <OperationContract()> _
    Function Guardar(ByVal oeImpuesto As e_Impuesto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeImpuesto As e_Impuesto) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeImpuesto As e_Impuesto) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeImpuesto As e_Impuesto) As List(Of e_Impuesto)

End Interface
