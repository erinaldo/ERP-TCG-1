Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Movimiento_Administrativo", también debe actualizar la referencia a "Il_Movimiento_Administrativo" en Web.config.
<ServiceContract()> _
Public Interface Il_Movimiento_Administrativo

    <OperationContract()> _
    Function Obtener(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As e_Movimiento_Administrativo

    <OperationContract()> _
    Function Listar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As List(Of e_Movimiento_Administrativo)

    <OperationContract()> _
    Function Validar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As Boolean

End Interface
