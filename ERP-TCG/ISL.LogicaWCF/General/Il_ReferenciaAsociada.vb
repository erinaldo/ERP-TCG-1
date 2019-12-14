Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ReferenciaAsociada" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ReferenciaAsociada

    <OperationContract()>
    Function Eliminar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As Boolean

    <OperationContract()>
    Function Listar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As List(Of e_ReferenciaAsociada)

    <OperationContract()>
    Function Obtener(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As e_ReferenciaAsociada

End Interface
