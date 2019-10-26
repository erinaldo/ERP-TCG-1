Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_AsientoMov_ObligacionFin

    <OperationContract()> _
    Function Obtener(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As e_AsientoMov_ObligacionFin

    <OperationContract()> _
    Function Listar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As List(Of e_AsientoMov_ObligacionFin)

    <OperationContract()> _
    Function Validar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean

    <OperationContract()> _
    Function Extornar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin, lst_DocRetDet As List(Of e_DocumentoRetencionDetalle)) As Boolean

    <OperationContract()> _
   Function CrearDT() As DataTable

End Interface
