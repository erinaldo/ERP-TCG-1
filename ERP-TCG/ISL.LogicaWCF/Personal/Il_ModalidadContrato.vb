Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ModalidadContrato" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ModalidadContrato

    <OperationContract()> _
    Function Listar(ByVal oeModalidadContrato As e_ModalidadContrato) As List(Of e_ModalidadContrato)

End Interface
