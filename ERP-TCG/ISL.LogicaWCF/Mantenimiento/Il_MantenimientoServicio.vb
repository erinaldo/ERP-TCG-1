Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MantenimientoServicio", también debe actualizar la referencia a "Il_MantenimientoServicio" en Web.config.
<ServiceContract()> _
Public Interface Il_MantenimientoServicio

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As e_MantenimientoServicio

    <OperationContract()> _
    Function Listar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As List(Of e_MantenimientoServicio)

    <OperationContract()> _
    Function Validar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimientoServicio As e_MantenimientoServicio) As Boolean

End Interface
