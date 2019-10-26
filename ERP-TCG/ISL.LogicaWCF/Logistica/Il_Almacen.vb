Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Almacen", también debe actualizar la referencia a "Il_Almacen" en Web.config.
<ServiceContract()> _
Public Interface Il_Almacen

    <OperationContract()> _
    Function Obtener(ByVal oeAlmacen As e_Almacen) As e_Almacen

    <OperationContract()> _
    Function Listar(ByVal oeAlmacen As e_Almacen) As List(Of e_Almacen)

    <OperationContract()> _
    Function Guardar(ByVal oeAlmacen As e_Almacen) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAlmacen As e_Almacen) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeAlmacen As e_Almacen) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
