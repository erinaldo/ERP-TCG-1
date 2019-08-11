Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Formula" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Formula

    <OperationContract()> _
    Function Obtener(ByVal oeformula As e_Formula) As e_Formula

    <OperationContract()> _
    Function Listar(ByVal oeformula As e_Formula) As List(Of e_Formula)

    <OperationContract()> _
    Function Validar(ByVal oeformula As e_Formula) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeformula As e_Formula) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeformula As e_Formula) As Boolean

End Interface
