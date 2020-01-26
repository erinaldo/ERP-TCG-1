Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_ComprobantePagoElectronico" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_ComprobantePagoElectronico

    <OperationContract()>
    Function Obtener(Operacion As String, Documento As e_ComprobantePagoElectronico) As e_ComprobantePagoElectronico

    <OperationContract()>
    Function Consultar(Operacion As String, Documento As e_ComprobantePagoElectronico) As List(Of e_ComprobantePagoElectronico)

    <OperationContract()>
    Function CambiarEstado(Operacion As String, Documento As e_ComprobantePagoElectronico) As Boolean

    <OperationContract()>
    Function GenerarEDocFactura(ByVal oe As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarEDocFactura20(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarEDocBoleta(ByVal oe As e_ComprobantePagoElectronico) As String

    <OperationContract()>
    Function GenerarEDocNotaCredito(ByVal oe As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarEDocNotaCredito20(ByVal oe As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarEDocNotaDebito(ByVal oe As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarEDocNotaDebito20(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarResumenBoletas20(ByVal oe As List(Of e_ComprobantePagoElectronico), ByVal Empresa As e_Empresa, Resumen As e_ComprobantePagoElectronico_Resumen, ByRef Hash As String) As String

    <OperationContract()>
    Function GenerarDocBaja(ByVal oe As List(Of e_ComprobantePagoElectronico), ByVal Empresa As e_Empresa, Resumen As e_ComprobantePagoElectronico_Resumen, ByRef Hash As String, Motivo As String) As String

End Interface
