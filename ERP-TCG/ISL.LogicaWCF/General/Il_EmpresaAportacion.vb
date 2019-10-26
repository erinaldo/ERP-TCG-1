Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_EmpresaAportacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_EmpresaAportacion

    <OperationContract()> _
    Function Obtener(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As e_EmpresaAportacion

    <OperationContract()> _
    Function Validar(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeEmpresaAportacion As e_EmpresaAportacion) As Boolean

End Interface
