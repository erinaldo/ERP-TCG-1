Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AsistenciaPersonal" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AsistenciaPersonal

    <OperationContract()> _
    Function Obtener(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As e_AsistenciaPersonal

    <OperationContract()> _
    Function Listar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As List(Of e_AsistenciaPersonal)

    <OperationContract()> _
    Function Validar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsistenciaPersonal As e_AsistenciaPersonal) As Boolean

End Interface
