Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MantenimientoMaterial", también debe actualizar la referencia a "Il_MantenimientoMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_MantenimientoMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As e_MantenimientoMaterial

    <OperationContract()> _
    Function Listar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As List(Of e_MantenimientoMaterial)

    <OperationContract()> _
    Function Validar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean

End Interface
