Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovCuentaCte", también debe actualizar la referencia a "Il_MovCuentaCte" en Web.config.
<ServiceContract()> _
Public Interface Il_MovCuentaCte

    <OperationContract()> _
     Function Obtener(ByVal oeMovCuentaCte As e_MovCuentaCte) As e_MovCuentaCte

    <OperationContract()> _
    Function Listar(ByVal oeMovCuentaCte As e_MovCuentaCte) As List(Of e_MovCuentaCte)

    <OperationContract()> _
    Function Validar(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean

    <OperationContract()>
    Function GuardarLista(ByVal leMovCuentaCte As List(Of e_MovCuentaCte), ByVal PrefijoID As String) As Boolean

    <OperationContract()>
    Function GuardarLista2(ByVal leMovCuentaCte As List(Of e_MovCuentaCte), ByVal leAsientoModel As List(Of e_AsientoModelo), ByVal PrefijoID As String) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leMovCuentaCte As List(Of e_MovCuentaCte), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovCuentaCte As e_MovCuentaCte) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function ListarDocumentos(ByVal oeMovCuentaCte As e_MovCuentaCte) As List(Of e_MovimientoDocumento)


End Interface
