Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MantenimientoEquipo", también debe actualizar la referencia a "Il_MantenimientoEquipo" en Web.config.
<ServiceContract()> _
Public Interface Il_MantenimientoEquipo

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As e_MantenimientoEquipo

    <OperationContract()> _
    Function Listar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As List(Of e_MantenimientoEquipo)

    <OperationContract()> _
    Function Validar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimientoEquipo As e_MantenimientoEquipo) As Boolean

End Interface
