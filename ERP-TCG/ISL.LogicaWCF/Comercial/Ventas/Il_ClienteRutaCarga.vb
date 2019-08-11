Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ClienteRutaCarga" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ClienteRutaCarga

    <OperationContract()> _
    Function Obtener(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As e_ClienteRutaCarga

    <OperationContract()> _
    Function Listar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As List(Of e_ClienteRutaCarga)

    <OperationContract()> _
    Function Guardar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean

End Interface
