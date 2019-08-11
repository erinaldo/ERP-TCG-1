Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetallePagoCajaTrabajador" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetallePagoCajaTrabajador

    Function CrearDT() As DataTable

    Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String

    Function Validar(oeDetallePagoCajaTrabajador As EntidadesWCF.e_DetallePagoCajaTrabajador) As Boolean

    Function Obtener(oeDetallePagoCajaTrabajador As EntidadesWCF.e_DetallePagoCajaTrabajador) As EntidadesWCF.e_DetallePagoCajaTrabajador

    Function Listar(oeDetallePagoCajaTrabajador As EntidadesWCF.e_DetallePagoCajaTrabajador) As List(Of EntidadesWCF.e_DetallePagoCajaTrabajador)

    Function Guardar(oeDetallePagoCajaTrabajador As EntidadesWCF.e_DetallePagoCajaTrabajador) As Boolean

    Function Eliminar(oeDetallePagoCajaTrabajador As EntidadesWCF.e_DetallePagoCajaTrabajador) As Boolean

    <OperationContract()>
    Sub DoWork()

End Interface
