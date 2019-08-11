Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AccidenteIncidencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AccidenteIncidencia

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As e_AccidenteIncidencia

    <OperationContract()>
    Function Listar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As List(Of e_AccidenteIncidencia)

    <OperationContract()>
    Function Validar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean
End Interface
