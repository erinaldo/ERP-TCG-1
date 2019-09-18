Imports System.ServiceModel
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_RecargaPeaje" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_RecargaPeaje

    <OperationContract()> _
    Function Guardar(oeRecargaPeaje As e_RecargaPeaje) As Boolean

    <OperationContract()>
    Function GuardarMasivo(ListaRecargaPeaje As List(Of e_RecargaPeaje), ByVal PrefijoID As String) As Boolean

    <OperationContract()> _
    Function EditarMasivo(ListaRecargaPeaje As List(Of e_RecargaPeaje)) As Boolean

    <OperationContract()> _
    Function Listar(oeRecargaPeaje As e_RecargaPeaje) As List(Of e_RecargaPeaje)


End Interface
