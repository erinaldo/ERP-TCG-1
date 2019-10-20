Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_CuentaAsociada", también debe actualizar la referencia a "Il_CuentaAsociada" en Web.config.
<ServiceContract()> _
Public Interface Il_CuentaAsociada

    <OperationContract()> _
    Function Obtener(ByVal oeCuentaAsociada As e_CuentaAsociada) As e_CuentaAsociada

    <OperationContract()> _
    Function Listar(ByVal oeCuentaAsociada As e_CuentaAsociada) As List(Of e_CuentaAsociada)

    <OperationContract()> _
    Function Validar(ByVal oeCuentaAsociada As e_CuentaAsociada) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCuentaAsociada As e_CuentaAsociada) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCuentaAsociada As e_CuentaAsociada) As Boolean

End Interface
