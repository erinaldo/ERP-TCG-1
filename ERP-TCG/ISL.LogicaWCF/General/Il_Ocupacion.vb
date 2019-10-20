Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Ocupacion", también debe actualizar la referencia a "Il_Ocupacion" en Web.config.
<ServiceContract()> _
Public Interface Il_Ocupacion

    <OperationContract()> _
    Function Obtener(ByVal oeOcupacion As e_Ocupacion) As e_Ocupacion

    <OperationContract()> _
    Function Listar(ByVal oeOcupacion As e_Ocupacion) As List(Of e_Ocupacion)

    <OperationContract()> _
    Function Listar2(ByVal oeOcupacion As e_Ocupacion) As List(Of e_Ocupacion)

    <OperationContract()> _
    Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeOcupacion As e_Ocupacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeOcupacion As e_Ocupacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeOcupacion As e_Ocupacion) As Boolean

End Interface
