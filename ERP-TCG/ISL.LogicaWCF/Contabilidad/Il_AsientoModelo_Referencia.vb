Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AsientoModelo_Referencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AsientoModelo_Referencia

    <OperationContract()> _
    Function Obtener(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As e_AsientoModelo_Referencia

    <OperationContract()> _
    Function Listar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As List(Of e_AsientoModelo_Referencia)

    <OperationContract()> _
    Function Listar2(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As List(Of e_AsientoModelo_Referencia)

    <OperationContract()> _
    Function Validar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsientoModelo_Referencia As e_AsientoModelo_Referencia) As Boolean

End Interface
