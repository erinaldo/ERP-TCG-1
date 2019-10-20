Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RendimientoCombustible" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RendimientoCombustible

    <OperationContract()> _
    Function Guardar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As List(Of e_RendimientoCombustible)

    <OperationContract()> _
    Function Obtener(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As e_RendimientoCombustible

    <OperationContract()> _
    Function Validar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean

End Interface
