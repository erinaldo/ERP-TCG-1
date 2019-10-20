Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_LibroElectronico", también debe actualizar la referencia a "Il_LibroElectronico" en Web.config.
<ServiceContract()> _
Public Interface Il_LibroElectronico

    <OperationContract()> _
    Function Obtener(ByVal oeLibroElectronico As e_LibroElectronico) As e_LibroElectronico

    <OperationContract()> _
    Function Listar(ByVal oeLibroElectronico As e_LibroElectronico) As List(Of e_LibroElectronico)

    <OperationContract()> _
     Function Validar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean

    <OperationContract()> _
     Function Eliminar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

    <OperationContract()> _
    Function ActualizarCUO(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean


End Interface
