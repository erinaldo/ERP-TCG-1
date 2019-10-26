Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ItemGasto", también debe actualizar la referencia a "Il_ItemGasto" en Web.config.
<ServiceContract()> _
Public Interface Il_Kardex
    <OperationContract()> _
    Function Corte(ByVal oeKardex As e_Kardex) As Boolean


End Interface

