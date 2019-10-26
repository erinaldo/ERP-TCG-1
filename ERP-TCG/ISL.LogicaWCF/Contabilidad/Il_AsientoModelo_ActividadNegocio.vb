Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AsientoModelo_ActividadNegocio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AsientoModelo_ActividadNegocio

    <OperationContract()> _
    Function Obtener(ByVal oeAsiModActNeg As e_AsientoModelo_ActividadNegocio) As e_AsientoModelo_ActividadNegocio

    <OperationContract()> _
    Function Listar(ByVal oeAsiModActNeg As e_AsientoModelo_ActividadNegocio) As List(Of e_AsientoModelo_ActividadNegocio)

    <OperationContract()> _
    Function Validar(ByVal oeAsiModActNeg As e_AsientoModelo_ActividadNegocio) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsiModActNeg As e_AsientoModelo_ActividadNegocio) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsiModActNeg As e_AsientoModelo_ActividadNegocio) As Boolean

End Interface
