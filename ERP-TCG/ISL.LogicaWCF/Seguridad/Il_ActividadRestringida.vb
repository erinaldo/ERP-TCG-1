Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_ActividadRestringida", también debe actualizar la referencia a "Il_ActividadRestringida" en Web.config.
<ServiceContract()> _
Public Interface Il_ActividadRestringida

    <OperationContract()> _
   Function Obtener(ByVal oeActividadRestringida As e_ActividadRestringida) As e_ActividadRestringida

    <OperationContract()> _
    Function Listar(ByVal oeActividadRestringida As e_ActividadRestringida) As List(Of e_ActividadRestringida)

    <OperationContract()> _
    Function Validar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean

End Interface
