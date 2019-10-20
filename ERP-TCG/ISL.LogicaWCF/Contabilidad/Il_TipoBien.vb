Imports System.ServiceModel
Imports System.ComponentModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoBien" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoBien

    <OperationContract()>
    Function Obtener(ByVal oeTipoBien As e_TipoBien) As e_TipoBien

    <OperationContract()>
    Function Listar(ByVal oeTipoBien As e_TipoBien) As List(Of e_TipoBien)

End Interface
