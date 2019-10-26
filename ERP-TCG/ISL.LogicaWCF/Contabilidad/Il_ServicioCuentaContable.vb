Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ServicioCuentaContable", también debe actualizar la referencia a "Il_ServicioCuentaContable" en Web.config.
<ServiceContract()> _
Public Interface Il_ServicioCuentaContable

    <OperationContract()> _
    Function Obtener(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As e_ServicioCuentaContable

    Function Listar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As List(Of e_ServicioCuentaContable)

    Function Validar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As Boolean

    Function Guardar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As Boolean

    Function Eliminar(ByVal oeServicioCuentaContable As e_ServicioCuentaContable) As Boolean



End Interface
