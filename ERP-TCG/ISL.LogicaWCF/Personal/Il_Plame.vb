Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Plame" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Plame

    Function Listar(oePlame As EntidadesWCF.e_PlameRem) As List(Of EntidadesWCF.e_PlameRem)

    <OperationContract()>
    Sub DoWork()

End Interface
