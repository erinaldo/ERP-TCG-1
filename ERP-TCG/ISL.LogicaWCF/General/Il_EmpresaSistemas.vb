Imports System.ServiceModel
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_EmpresaSistemas" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_EmpresaSistemas

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As e_EmpresaSistemas

    <OperationContract()>
    Function Listar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As List(Of e_EmpresaSistemas)

    <OperationContract()>
    Function Guardar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean
End Interface
