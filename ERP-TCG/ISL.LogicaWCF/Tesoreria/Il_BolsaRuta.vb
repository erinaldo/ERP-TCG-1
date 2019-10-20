Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_BolsaRuta", también debe actualizar la referencia a "Il_BolsaRuta" en Web.config.
<ServiceContract()> _
Public Interface Il_BolsaRuta

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ID As String, ByVal IDRUTA As String, ByVal IDTIPOVEHICULO As String) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeBolsaRuta As e_BolsaRuta) As e_BolsaRuta

    <OperationContract()> _
    Function Listar(ByVal oeBolsaRuta As e_BolsaRuta) As List(Of e_BolsaRuta)

    <OperationContract()> _
    Function Validar(ByVal oeBolsaRuta As e_BolsaRuta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeBolsaRuta As e_BolsaRuta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeBolsaRuta As e_BolsaRuta) As Boolean

End Interface
