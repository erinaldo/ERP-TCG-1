Imports ISL.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleCapacitacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleCapacitacion

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As e_DetalleCapacitacion

    <OperationContract()> _
    Function Listar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As List(Of e_DetalleCapacitacion)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleCapacitacion As e_DetalleCapacitacion) As Boolean

End Interface
