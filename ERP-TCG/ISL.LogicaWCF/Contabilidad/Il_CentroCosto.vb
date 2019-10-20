Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CentroCosto", también debe actualizar la referencia a "Il_CentroCosto" en Web.config.
<ServiceContract()> _
Public Interface Il_CentroCosto

    <OperationContract()> _
    Function Obtener(ByVal oeCentroCosto As e_CentroCosto) As e_CentroCosto

    <OperationContract()> _
    Function Listar(ByVal oeCentroCosto As e_CentroCosto) As List(Of e_CentroCosto)

    <OperationContract()> _
    Function Guardar(ByVal oeCentroCosto As e_CentroCosto) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeCentroCosto As e_CentroCosto) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCentroCosto As e_CentroCosto) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeCentroCosto As e_CentroCosto)

    <OperationContract()> _
    Function ObtenerUbicaciones(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As e_CentroCostoUbicaciones

    <OperationContract()> _
    Function ListarUbicaciones(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As List(Of e_CentroCostoUbicaciones)

    <OperationContract()> _
    Function GuardarUbicaciones(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As Boolean

    <OperationContract()> _
    Function EliminarUbicaciones(ByVal oeCentroCostoUbicaciones As e_CentroCostoUbicaciones) As Boolean

End Interface
