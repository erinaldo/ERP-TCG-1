Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RequerimientoServicio", también debe actualizar la referencia a "Il_RequerimientoServicio" en Web.config.
<ServiceContract()> _
Public Interface Il_RequerimientoServicio

    <OperationContract()> _
    Function Guardar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As e_RequerimientoServicio

    <OperationContract()> _
    Function Validar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As List(Of e_RequerimientoServicio)

End Interface
