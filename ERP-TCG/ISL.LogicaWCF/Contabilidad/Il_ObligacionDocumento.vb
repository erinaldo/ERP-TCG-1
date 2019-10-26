Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IIl_ObligacionDocumento" en el código y en el archivo de configuración a la vez.
<ServiceContract()> _
Public Interface Il_ObligacionDocumento

    <OperationContract()> _
    Function CrearDT() As Data.DataTable
    <OperationContract()> _
    Function Listar(oe_ObligFin_MovDoc As e_ObligacionDocumento) As List(Of e_ObligacionDocumento)
End Interface
