Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Lugar", también debe actualizar la referencia a "Il_Lugar" en Web.config.
<ServiceContract()> _
Public Interface Il_Lugar

    <OperationContract()> _
    Function Obtener(ByVal oeLugar As e_Lugar) As e_Lugar

    <OperationContract()> _
    Function Listar(ByVal oeLugar As e_Lugar) As List(Of e_Lugar)

    <OperationContract()> _
    Function ListarClienteLugar(ByVal oeClienteLugar As e_ClienteLugar) As List(Of e_ClienteLugar)

    <OperationContract()> _
    Function ListarVentanaHoraria(ByVal oeVentanaHoraria As e_VentanaHoraria) As List(Of e_VentanaHoraria)

    <OperationContract()> _
    Function Validar(ByVal oeLugar As e_Lugar) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeLugar As e_Lugar) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeLugar As e_Lugar) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaLugar As List(Of e_Lugar))

End Interface
