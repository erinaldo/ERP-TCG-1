Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_PrestamosCuenta", también debe actualizar la referencia a "Il_PrestamosCuenta" en Web.config.
<ServiceContract()> _
Public Interface Il_PrestamosCuenta

    <OperationContract()> _
    Function Obtener(ByVal oePrestamosCuenta As e_PrestamosCuenta) As e_PrestamosCuenta

    <OperationContract()> _
    Function Listar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As List(Of e_PrestamosCuenta)

    <OperationContract()> _
    Function Guardar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean

    <OperationContract()> _
    Function CerrarCuenta(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean

End Interface
