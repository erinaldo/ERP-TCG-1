Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MantenimientoOcupacion", también debe actualizar la referencia a "Il_MantenimientoOcupacion" en Web.config.
<ServiceContract()> _
Public Interface Il_MantenimientoOcupacion

    <OperationContract()> _
    Function Obtener(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As e_MantenimientoOcupacion

    <OperationContract()> _
    Function Listar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As List(Of e_MantenimientoOcupacion)

    <OperationContract()> _
    Function Validar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMantenimientoOcupacion As e_MantenimientoOcupacion) As Boolean

End Interface
