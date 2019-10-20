Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Inventario", también debe actualizar la referencia a "Il_Inventario" en Web.config.
<ServiceContract()> _
Public Interface Il_Inventario

    <OperationContract()> _
    Function Listar(ByVal oeInventario As e_Inventario) As List(Of e_Inventario)

    <OperationContract()> _
    Function Listar1(ByVal oeInventario As e_Inventario) As List(Of e_Inventario)

    <OperationContract()> _
    Function Listar_Valorizado(ByVal oeInventarioValorizado As e_InventarioValorizado) As List(Of e_InventarioValorizado)

    <OperationContract()> _
    Function Obtener(ByVal oeInventario As e_Inventario) As e_Inventario

End Interface
