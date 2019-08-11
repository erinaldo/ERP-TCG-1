Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_MenuActividad", también debe actualizar la referencia a "Il_MenuActividad" en Web.config.
<ServiceContract()> _
Public Interface Il_MenuActividad

    <OperationContract()> _
    Function Obtener(ByVal oeMenuActividad As e_MenuActividad) As e_MenuActividad

    <OperationContract()> _
    Function Listar(ByVal oeMenuActividad As e_MenuActividad) As List(Of e_MenuActividad)

    <OperationContract()> _
    Function ValidarCodigo(ByVal Id As String, ByVal Codigo As String) As Boolean

    <OperationContract()> _
    Function Validar(ByVal oeMenuActividad As e_MenuActividad) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMenuActividad As e_MenuActividad) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMenuActividad As e_MenuActividad) As Boolean

End Interface
