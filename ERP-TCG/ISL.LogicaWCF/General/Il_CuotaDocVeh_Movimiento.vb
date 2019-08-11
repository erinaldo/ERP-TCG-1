Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CuotaDocVeh_Movimiento

    <OperationContract()> _
    Function GuardarCancelacion(ByVal oeCuotaDocVeh_Movimiento As e_CuotaDocVeh_Movimiento) As Boolean

End Interface
