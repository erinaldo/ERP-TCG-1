Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Proveedor", también debe actualizar la referencia a "Il_Proveedor" en Web.config.
<ServiceContract()> _
Public Interface Il_Proveedor

    <OperationContract()> _
    Function Obtener(ByVal oeProveedor As e_Proveedor) As e_Proveedor

    <OperationContract()> _
    Function ObtenerNomProveedor(ByVal oeProveedor As e_Proveedor) As e_Proveedor

    <OperationContract()> _
    Function Listar(ByVal oeProveedor As e_Proveedor) As List(Of e_Proveedor)

    <OperationContract()> _
    Function ComboGrilla(ByVal oeProveedor As e_Proveedor)

    <OperationContract()> _
    Function Validar(ByVal oeProveedor As e_Proveedor) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeProveedor As e_Proveedor) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeProveedor As e_Proveedor) As Boolean

    '<OperationContract()> _
    'Function Foto(ByVal DNI As String) As System.Drawing.Bitmap

End Interface
