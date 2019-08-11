Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ReporteRecorrido", también debe actualizar la referencia a "Il_ReporteRecorrido" en Web.config.
<ServiceContract()> _
Public Interface Il_ReporteRecorrido

    <OperationContract()> _
     Function Obtener(ByVal oeReporteRecorrido As e_ReporteRecorrido) As e_ReporteRecorrido

    <OperationContract()> _
     Function Listar(ByVal oeReporteRecorrido As e_ReporteRecorrido) As List(Of e_ReporteRecorrido)

    <OperationContract()> _
     Function ListarDts(ByVal oeReporteRecorrido As e_ReporteRecorrido) As DataSet

End Interface
