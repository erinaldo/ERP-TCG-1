Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleLibroElectronico", también debe actualizar la referencia a "Il_DetalleLibroElectronico" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleLibroElectronico

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As e_DetalleLibroElectronico

    <OperationContract()> _
    Function Listar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As List(Of e_DetalleLibroElectronico)

    <OperationContract()> _
     Function Validar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean

    <OperationContract()> _
     Function Eliminar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean

    <OperationContract()> _
    Function GuardarMasivo(ByVal NombreTabla As String, ByVal Dt As Data.DataTable) As Boolean

    <OperationContract()> _
    Function CrearDT() As System.Data.DataTable

End Interface
