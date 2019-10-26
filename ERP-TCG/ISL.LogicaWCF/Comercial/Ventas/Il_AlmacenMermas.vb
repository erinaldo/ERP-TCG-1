Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_AlmacenMermas", también debe actualizar la referencia a "Il_AlmacenMermas" en Web.config.
<ServiceContract()> _
Public Interface Il_AlmacenMermas

    '<OperationContract()> _
    'Sub DoWork()
    <OperationContract()> _
   Function Obtener(ByVal oeAlmacenMermas As e_AlmacenMermas) As e_AlmacenMermas

    <OperationContract()> _
    Function Listar(ByVal oeAlmacenMermas As e_AlmacenMermas) As List(Of e_AlmacenMermas)

    <OperationContract()> _
    Function Validar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean

End Interface
