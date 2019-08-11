Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Alerta", también debe actualizar la referencia a "Il_Alerta" en Web.config.
<ServiceContract()> _
Public Interface Il_Alerta

    <OperationContract()> _
    Function Obtener(ByVal oeAlerta As e_Alerta) As e_Alerta

    <OperationContract()> _
    Function Listar(ByVal oeAlerta As e_Alerta) As List(Of e_Alerta)

    <OperationContract()> _
    Function Validar(ByVal oeAlerta As e_Alerta) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAlerta As e_Alerta) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAlerta As e_Alerta) As Boolean

End Interface
