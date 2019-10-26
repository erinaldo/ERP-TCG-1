Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_SubFamiliaMaterial", también debe actualizar la referencia a "Il_SubFamiliaMaterial" en Web.config.
<ServiceContract()> _
Public Interface Il_SubFamiliaMaterial

    <OperationContract()> _
    Function Obtener(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As e_SubFamiliaMaterial

    <OperationContract()> _
    Function Listar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As List(Of e_SubFamiliaMaterial)

    <OperationContract()> _
    Function Guardar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean

    <OperationContract()> _
    Function ValidarFamilia(ByVal id As String) As Boolean

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

End Interface
