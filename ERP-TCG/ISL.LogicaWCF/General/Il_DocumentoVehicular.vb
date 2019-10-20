Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DocumentoVehicular", también debe actualizar la referencia a "Il_DocumentoVehicular" en Web.config.
<ServiceContract()> _
Public Interface Il_DocumentoVehicular

    <OperationContract()> _
    Function GuardarProvisionPoliza(oeDocumentoVehicular As e_DocumentoVehicular, leAsientoModelo As List(Of e_AsientoModelo)) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As e_DocumentoVehicular

    <OperationContract()> _
    Function Listar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As List(Of e_DocumentoVehicular)

    <OperationContract()> _
   Function ListarDts(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As DataSet

    <OperationContract()> _
    Function Validar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean

    <OperationContract()> _
    Function GuardarSeguro(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean

    <OperationContract()> _
    Function ValidarSeguro(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean

End Interface
