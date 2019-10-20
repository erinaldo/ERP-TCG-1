Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "Il_AccionSistema", también debe actualizar la referencia a "Il_AccionSistema" en Web.config.
<ServiceContract()> _
Public Interface Il_AccionSistema

    <OperationContract()> _
  Function Obtener(ByVal oeAccionSistema As e_AccionSistema) As e_AccionSistema

    <OperationContract()> _
    Function Listar(ByVal oeAccionSistema As e_AccionSistema) As List(Of e_AccionSistema)

    <OperationContract()> _
    Function Validar(ByVal oeAccionSistema As e_AccionSistema) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAccionSistema As e_AccionSistema) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAccionSistema As e_AccionSistema) As Boolean

End Interface
