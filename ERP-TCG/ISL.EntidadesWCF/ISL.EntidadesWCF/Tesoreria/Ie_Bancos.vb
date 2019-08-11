Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Bancos", también debe actualizar la referencia a "Ie_Bancos" en Web.config.
<ServiceContract()> _
Public Interface Ie_Bancos

    <OperationContract()> _
    Function Obtener(ByVal listaBancos As List(Of e_Banco)) As List(Of e_Banco)

    <OperationContract()> _
    Function Agregar(ByVal banco As e_Banco) As List(Of e_Banco)

    <OperationContract()> _
    Function Filtrar(ByVal banco As e_Banco) As List(Of e_Banco)

    <OperationContract()> _
    Function Cuantos() As Integer

End Interface
