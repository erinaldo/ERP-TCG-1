Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Bonificacion", también debe actualizar la referencia a "Il_Bonificacion" en Web.config.
<ServiceContract()> _
Public Interface Il_Bonificacion

    '<OperationContract()> _
    'Sub DoWork()

    <OperationContract()> _
    Function Obtener(ByVal oeBonificacion As e_Bonificacion) As e_Bonificacion

    <OperationContract()> _
    Function Listar(ByVal oeBonificacion As e_Bonificacion) As List(Of e_Bonificacion)

    <OperationContract()> _
    Function Guardar(ByVal oeBonificacion As e_Bonificacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeBonificacion As e_Bonificacion) As Boolean

End Interface
