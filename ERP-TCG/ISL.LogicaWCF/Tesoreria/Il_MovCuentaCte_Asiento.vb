Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MovCuentaCte_Asiento", también debe actualizar la referencia a "Il_MovCuentaCte_Asiento" en Web.config.
<ServiceContract()> _
Public Interface Il_MovCuentaCte_Asiento

    <OperationContract()> _
     Function Obtener(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As e_MovCuentaCte_Asiento

    <OperationContract()> _
    Function Listar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As List(Of e_MovCuentaCte_Asiento)

    <OperationContract()> _
    Function Validar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMovCuentaCte_Asiento As e_MovCuentaCte_Asiento) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

End Interface
