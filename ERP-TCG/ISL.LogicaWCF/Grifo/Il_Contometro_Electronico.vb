Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Contometro_Electronico" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Contometro_Electronico

    <OperationContract()>
    Function mt_Obtener(ByVal oeContometro_Electronico As e_Contometro_Electronico) As e_Contometro_Electronico

    <OperationContract()>
    Function mt_Listar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As List(Of e_Contometro_Electronico)

    <OperationContract()>
    Function mt_Guardar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As Boolean

    <OperationContract()>
    Function mt_Eliminar(ByVal oeContometro_Electronico As e_Contometro_Electronico) As Boolean

End Interface
