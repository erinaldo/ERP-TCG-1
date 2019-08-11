Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_CuotaDocVehPago

    <OperationContract()> _
    Function Listar(ByVal oeCuotaDocVehPago As e_CuotaDocVehPago) As List(Of e_CuotaDocVehPago)

End Interface
