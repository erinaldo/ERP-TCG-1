Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_SubAlmacen", también debe actualizar la referencia a "Il_SubAlmacen" en Web.config.
<ServiceContract()> _
Public Interface Il_SubAlmacen

    <OperationContract()> _
    Function Obtener(ByVal oeSubAlmacen As e_SubAlmacen) As e_SubAlmacen

    <OperationContract()> _
    Function Listar_SubAlmacen(ByVal oeSubAlmacen As e_SubAlmacen) As List(Of e_SubAlmacen)

    <OperationContract()> _
    Function Listar(ByVal oeSubAlmacen As e_SubAlmacen) As List(Of e_SubAlmacen)

    <OperationContract()> _
    Function Validar(ByVal oeSubAlmacen As e_SubAlmacen) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeSubAlmacen As e_SubAlmacen) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal oeSubAlmacen As e_SubAlmacen)

End Interface
