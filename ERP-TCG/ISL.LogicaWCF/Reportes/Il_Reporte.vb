'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2020-02-23  |  CESS     |   Generar Interfaces para Reportes
'=================================================================================================================

Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Reporte" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Reporte

    <OperationContract()>
    Function Consultar(Reporte As e_reporteFiltro) As DataTable

End Interface
