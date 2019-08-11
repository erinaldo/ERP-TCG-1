Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Flota_Cuota" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Flota_Cuota

    <OperationContract()>
    Function Obtener(ByVal oeFlota_Cuota As e_Flota_Cuota) As e_Flota_Cuota

    <OperationContract()>
    Function Listar(ByVal oeFlota_Cuota As e_Flota_Cuota) As List(Of e_Flota_Cuota)

    <OperationContract()> _
    Function Validar(ByVal oeFlota_Cuota As e_Flota_Cuota) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeFlota_Cuota As e_Flota_Cuota) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeFlota_Cuota As e_Flota_Cuota) As Boolean

End Interface
