Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_RegistrosEditados", también debe actualizar la referencia a "Il_RegistrosEditados" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistrosEditados

    '<OperationContract()> _
    'Sub DoWork()

    <OperationContract()> _
   Function Obtener(ByVal oeRegistroEditado As e_RegistrosEditados) As e_RegistrosEditados

    <OperationContract()> _
    Function Listar(ByVal oeRegistroEditado As e_RegistrosEditados) As List(Of e_RegistrosEditados)

    <OperationContract()> _
    Function Guardar(ByVal oeRegistroEditado As e_RegistrosEditados) As String

    <OperationContract()> _
    Function Eliminar(ByVal oeRegistroEditado As e_RegistrosEditados) As Boolean


End Interface
