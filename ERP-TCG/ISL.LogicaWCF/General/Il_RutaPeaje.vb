Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RutaPeaje" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RutaPeaje

    <OperationContract()> _
    Function Guardar(oeRutaPeaje As e_RutaPeaje) As Boolean

    <OperationContract()> _
    Function Obtener(oeRutaPeaje As e_RutaPeaje) As e_RutaPeaje

    <OperationContract()> _
    Function Listar(oeRutaPeaje As e_RutaPeaje) As List(Of e_RutaPeaje)

    <OperationContract()> _
    Function Eliminar(oeRutaPeaje As e_RutaPeaje) As Boolean

End Interface
