Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Alarma" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Alarma

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeAlarma As e_Alarma) As e_Alarma

    <OperationContract()>
    Function Listar(ByVal oeAlarma As e_Alarma) As List(Of e_Alarma)

    <OperationContract()>
    Function Validar(ByVal oeAlarma As e_Alarma) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeAlarma As e_Alarma) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeAlarma As e_Alarma) As Boolean
End Interface
