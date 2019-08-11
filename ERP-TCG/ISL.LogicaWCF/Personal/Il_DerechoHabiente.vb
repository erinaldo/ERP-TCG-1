Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DerechoHabiente" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DerechoHabiente

    <OperationContract()> _
    Function Obtener(ByVal oeDerechoHabiente As e_DerechoHabiente) As e_DerechoHabiente

    <OperationContract()> _
    Function Listar(ByVal oeDerechoHabiente As e_DerechoHabiente) As List(Of e_DerechoHabiente)

    <OperationContract()> _
    Function Validar(ByVal oeDerechoHabiente As e_DerechoHabiente) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDerechoHabiente As e_DerechoHabiente) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDerechoHabiente As e_DerechoHabiente) As Boolean

End Interface
