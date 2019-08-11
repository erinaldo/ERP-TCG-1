Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_ContratoFinanciero" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_ContratoFinanciero

    <OperationContract()> _
    Function Obtener(Contrato As e_ContratoFinanciero) As e_ContratoFinanciero


End Interface


