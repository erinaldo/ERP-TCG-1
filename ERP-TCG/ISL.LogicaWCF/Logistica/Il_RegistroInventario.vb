Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegistroInventario", también debe actualizar la referencia a "Il_RegistroInventario" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistroInventario

    <OperationContract()> _
    Function Obtener(ByVal oeRegistroInventario As e_RegistroInventario) As e_RegistroInventario

    <OperationContract()> _
    Function ObtenerRegInv(oeRegistroInventario As e_RegistroInventario) As e_RegistroInventario

    <OperationContract()> _
    Function Rectificar(ByVal oeRegistroInventario As e_RegistroInventario) As Boolean

    <OperationContract()> _
    Function ListarSOrden(ByVal oeRegistroInventario As e_RegistroInventario) As List(Of e_RegistroInventario)

    <OperationContract()> _
    Function Listar(ByVal oeRegistroInventario As e_RegistroInventario) As List(Of e_RegistroInventario)

    <OperationContract()> _
    Function ListarStock(ByVal oeRegistroInventario As e_RegistroInventario) As DataSet

    <OperationContract()> _
    Function ListarIngresosSalidas(ByVal oeRegistroInventario As e_RegistroInventario) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeRegistroInventario As e_RegistroInventario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal lstRegistroInventario As List(Of e_RegistroInventario)) As Boolean

    '<OperationContract()> _
    'Function GuardarD2(ByVal lstRegistroInventario As List(Of e_RegistroInventario)) As e_RegistroInventario

    <OperationContract()> _
    Function Eliminar(ByVal oeRegistroInventario As e_RegistroInventario) As Boolean

End Interface
