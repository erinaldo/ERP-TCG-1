Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DespachoOperaciones" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DespachoOperaciones

    <OperationContract()>
    Function Obtener(oeDespachoOperaciones As e_DespachoOperaciones) As e_DespachoOperaciones

    <OperationContract()>
    Function Listar(oeDespachoOperaciones As e_DespachoOperaciones) As List(Of e_DespachoOperaciones)

    <OperationContract()>
    Function Guardar(oeDespachoOperaciones As e_DespachoOperaciones) As Boolean

    <OperationContract()>
    Function Eliminar(oeDespachoOperaciones As e_DespachoOperaciones) As Boolean

End Interface
