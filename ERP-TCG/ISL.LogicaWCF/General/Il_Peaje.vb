Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Peaje" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Peaje

    <OperationContract()> _
    Function Guardar(oePeaje As e_Peaje) As Boolean

    <OperationContract()> _
    Function Obtener(oePeaje As e_Peaje, IndPeajeTarifa As Boolean) As e_Peaje

    <OperationContract()> _
    Function Listar(oePeaje As e_Peaje) As List(Of e_Peaje)

    <OperationContract()> _
    Function Eliminar(oePeaje As e_Peaje, IndTarifa As Boolean) As Boolean

End Interface
