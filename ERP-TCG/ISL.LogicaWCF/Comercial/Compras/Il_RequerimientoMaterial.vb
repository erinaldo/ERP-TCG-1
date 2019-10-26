Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_RequerimientoMaterial

    <OperationContract()> _
    Function Guardar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As e_RequerimientoMaterial

    <OperationContract()> _
    Function Validar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean

    <OperationContract()> _
    Function Listar(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As List(Of e_RequerimientoMaterial)

End Interface
