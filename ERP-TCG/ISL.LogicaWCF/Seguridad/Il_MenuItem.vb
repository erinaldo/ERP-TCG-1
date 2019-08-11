Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MenuItem", también debe actualizar la referencia a "Il_MenuItem" en Web.config.
<ServiceContract()> _
Public Interface Il_MenuItem

    <OperationContract()> _
    Function Obtener(ByVal oeMenuItem As e_MenuItem) As e_MenuItem

    <OperationContract()> _
    Function Listar(ByVal oeMenuItem As e_MenuItem) As List(Of e_MenuItem)

    <OperationContract()> _
    Function Validar(ByVal oeMenuItem As e_MenuItem) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMenuItem As e_MenuItem) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMenuItem As e_MenuItem) As Boolean

End Interface
