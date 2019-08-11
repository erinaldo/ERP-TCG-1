Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_VidaNeumatico", también debe actualizar la referencia a "Il_VidaNeumatico" en Web.config.
<ServiceContract()> _
Public Interface Il_VidaNeumatico

    <OperationContract()> _
    Function Obtener(ByVal oeVidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico

    <OperationContract()> _
    Function Listar(ByVal oeVidaNeumatico As e_VidaNeumatico) As List(Of e_VidaNeumatico)

    <OperationContract()> _
    Function Validar(ByVal oeVidaNeumatico As e_VidaNeumatico) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeVidaNeumatico As e_VidaNeumatico) As e_VidaNeumatico

    <OperationContract()> _
    Function Eliminar(ByVal oeVidaNeumatico As e_VidaNeumatico) As Boolean

    <OperationContract()> _
    Function ActualizaKM(ByVal oeVidaNeumatico As e_VidaNeumatico) As Boolean

End Interface
