Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ActividadNegocio", también debe actualizar la referencia a "Il_ActividadNegocio" en Web.config.
<ServiceContract()> _
Public Interface Il_ActividadNegocio

    <OperationContract()> _
    Function Obtener(ByVal oeActividadNegocio As e_ActividadNegocio) As e_ActividadNegocio

    <OperationContract()> _
    Function Listar(ByVal oeActividadNegocio As e_ActividadNegocio) As List(Of e_ActividadNegocio)

    <OperationContract()> _
    Function ListarDataSet() As Data.DataSet

    <OperationContract()> _
    Function Validar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean

    <OperationContract()> _
    Function ValidarLista(ByVal leActividadNegocio As List(Of e_ActividadNegocio)) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean

End Interface
