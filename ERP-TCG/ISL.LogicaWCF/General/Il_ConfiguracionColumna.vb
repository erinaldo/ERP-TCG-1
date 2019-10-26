Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_ConfiguracionColumna

    <OperationContract()> _
    Function Obtener(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As e_ConfiguracionColumna

    <OperationContract()> _
    Function Listar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As List(Of e_ConfiguracionColumna)

    <OperationContract()> _
    Function Validar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeConfiguracionColumna As e_ConfiguracionColumna) As Boolean

End Interface
