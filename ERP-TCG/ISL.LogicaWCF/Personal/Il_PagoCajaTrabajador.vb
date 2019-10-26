Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_PagoCajaTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_PagoCajaTrabajador

    Function ImportarDatos(oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean

    Function Validar(oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean

    Function Obtener(oePagoCajaTrabajador As e_PagoCajaTrabajador) As e_PagoCajaTrabajador

    Function Listar(oePagoCajaTrabajador As e_PagoCajaTrabajador) As List(Of e_PagoCajaTrabajador)

    Function Guardar(oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean

    Function Eliminar(oePagoCajaTrabajador As e_PagoCajaTrabajador) As Boolean

    <OperationContract()>
    Sub DoWork()

End Interface
