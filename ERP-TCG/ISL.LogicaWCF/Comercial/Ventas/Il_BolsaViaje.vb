Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_BolsaViaje", también debe actualizar la referencia a "Il_BolsaViaje" en Web.config.
<ServiceContract()> _
Public Interface Il_BolsaViaje

    <OperationContract()> _
    Function Obtener(ByVal oeBolsaViaje As e_BolsaViaje) As e_BolsaViaje

    <OperationContract()> _
    Function Listar(ByVal oeBolsaViaje As e_BolsaViaje) As List(Of e_BolsaViaje)

    <OperationContract()> _
    Function ValidarTipoVehiculo(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function ValidarConceptoGasto(ByVal Id As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean

End Interface
