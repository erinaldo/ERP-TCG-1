Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_BonificacionProduccion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_BonificacionProduccion

    <OperationContract()> _
    Function Obtener(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As e_BonificacionProduccion

    <OperationContract()> _
    Function Listar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As List(Of e_BonificacionProduccion)

    <OperationContract()> _
    Function Validar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ByVal leBonificacionProduccion As List(Of e_BonificacionProduccion), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As Boolean

    <OperationContract()> _
    Function CrearDT() As Data.DataTable

    <OperationContract()> _
    Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String

End Interface
