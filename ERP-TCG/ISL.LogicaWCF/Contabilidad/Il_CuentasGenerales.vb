Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentasGenerales", también debe actualizar la referencia a "Il_CuentasGenerales" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentasGenerales

    <OperationContract()> _
    Function Obtener(ByVal oeCuentasGenerales As e_CuentasGenerales) As e_CuentasGenerales

    <OperationContract()> _
    Function Listar(ByVal oeCuentasGenerales As e_CuentasGenerales) As List(Of e_CuentasGenerales)

    <OperationContract()> _
    Function Validar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentasGenerales As e_CuentasGenerales) As Boolean

End Interface
