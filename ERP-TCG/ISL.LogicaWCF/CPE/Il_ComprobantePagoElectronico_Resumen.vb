Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_ComprobantePagoElectronico_Resumen

    <OperationContract()>
    Function Obtener(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen

    <OperationContract()>
    Function Listar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As List(Of e_ComprobantePagoElectronico_Resumen)

    <OperationContract()>
    Function Guardar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen

    <OperationContract()>
    Function Eliminar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean

End Interface