Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MenuWeb", también debe actualizar la referencia a "Il_MenuWeb" en Web.config.
<ServiceContract()> _
Public Interface Il_MenuWeb

    <OperationContract()> _
    Function Obtener(ByVal oeMenuWeb As e_MenuWeb) As e_MenuWeb

    <OperationContract()> _
    Function Listar(ByVal oeMenuWeb As e_MenuWeb) As List(Of e_MenuWeb)

    <OperationContract()> _
    Function Validar(ByVal oeMenuWeb As e_MenuWeb) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMenuWeb As e_MenuWeb) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMenuWeb As e_MenuWeb) As Boolean

End Interface
