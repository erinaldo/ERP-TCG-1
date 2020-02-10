Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_ComprobantePagoElectronico_Resumen

    <OperationContract()>
    Function Obtener(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen

    <OperationContract()>
    Function Listar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As List(Of e_ComprobantePagoElectronico_Resumen)

    <OperationContract()>
    Function Guardar(ByVal Item As e_ComprobantePagoElectronico_Resumen, lo As List(Of e_ComprobantePagoElectronico)) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean

    <OperationContract()>
    Function ListarDataSet(oe As e_ComprobantePagoElectronico_Resumen) As Data.DataSet

End Interface