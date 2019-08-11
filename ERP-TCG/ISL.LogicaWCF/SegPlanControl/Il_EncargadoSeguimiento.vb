Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_EncargadoSeguimiento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_EncargadoSeguimiento

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As e_EncargadoSeguimiento

    <OperationContract()>
    Function Listar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As List(Of e_EncargadoSeguimiento)

    <OperationContract()>
    Function Validar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean
End Interface
