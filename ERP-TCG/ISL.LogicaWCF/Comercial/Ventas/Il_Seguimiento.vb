Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Seguimiento", también debe actualizar la referencia a "Il_Seguimiento" en Web.config.
<ServiceContract()> _
Public Interface Il_Seguimiento

    Function GuardarImportar(listaViaje As List(Of e_Viaje)) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeSeguimiento As e_Seguimiento) As e_Seguimiento

    <OperationContract()> _
    Function Listar(ByVal oeSeguimiento As e_Seguimiento) As List(Of e_Seguimiento)

    <OperationContract()> _
    Function Listar2(ByVal oeSeguimiento As e_Seguimiento) As List(Of e_Seguimiento)

    <OperationContract()> _
    Function ObtenerRango(ByVal oeSeguimiento As e_Seguimiento) As e_Seguimiento

    <OperationContract()> _
    Function Validar(ByVal oeSeguimiento As e_Seguimiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSeguimiento As e_Seguimiento) As Boolean

    <OperationContract()> _
    Function Guardar1(ByVal oeSeguimiento As e_Seguimiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSeguimiento As e_Seguimiento) As Boolean

End Interface
