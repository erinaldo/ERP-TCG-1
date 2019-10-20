Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Combo", también debe actualizar la referencia a "Il_Combo" en Web.config.
<ServiceContract()> _
Public Interface Il_Combo

    <OperationContract()> _
   Function ComboGrilla(ByVal Lista As List(Of e_Combo))

    <OperationContract()> _
   Function ComboGrillaEspecial(ByVal Lista As List(Of e_Combo))

    <OperationContract()> _
   Function Listar(ByVal oeCombo As e_Combo) As List(Of e_Combo)

    <OperationContract()> _
    Function Obtener(ByVal oeCombo As e_Combo) As e_Combo

    <OperationContract()> _
    Function Guardar(ByVal oeCombo As e_Combo) As Boolean

End Interface
