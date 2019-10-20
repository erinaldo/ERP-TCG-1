Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_RubroEEFFDetalle_CuentaContable

    <OperationContract()>
    Function Obtener(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As e_RubroEEFFDetalle_CuentaContable

    <OperationContract()>
    Function Listar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As List(Of e_RubroEEFFDetalle_CuentaContable)

    <OperationContract()>
    Function Guardar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeRubroEEFFDetalle_CuentaContable As e_RubroEEFFDetalle_CuentaContable) As Boolean

End Interface
