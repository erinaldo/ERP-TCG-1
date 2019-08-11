Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Despacho" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Despacho

    <OperationContract()>
    Function Obtener(oeDespacho As e_Despacho) As e_Despacho

    <OperationContract()>
    Function Listar(oeDespacho As e_Despacho, bolListarDetalle As Boolean) As List(Of e_Despacho)

    <OperationContract()>
    Function Guardar(oeDespacho As e_Despacho) As Boolean

    <OperationContract()>
    Function Eliminar(oeDespacho As e_Despacho) As Boolean


End Interface
