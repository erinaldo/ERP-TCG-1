Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MantenimientoActividad", también debe actualizar la referencia a "Il_MantenimientoActividad" en Web.config.
<ServiceContract()> _
Public Interface Il_MantenimientoActividad

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As e_MantenimientoActividad

    <OperationContract()> _
    Function Listar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As List(Of e_MantenimientoActividad)

    <OperationContract()> _
    Function Validar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimientoActividad As e_MantenimientoActividad) As Boolean

End Interface
