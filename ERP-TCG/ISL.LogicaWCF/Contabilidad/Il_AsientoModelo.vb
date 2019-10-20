Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AsientoModelo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AsientoModelo

    <OperationContract()> _
    Function Obtener(ByVal oeAsientoModelo As e_AsientoModelo) As e_AsientoModelo

    <OperationContract()> _
    Function Listar(ByVal oeAsientoModelo As e_AsientoModelo) As List(Of e_AsientoModelo)

    <OperationContract()> _
    Function Validar(ByVal oeAsientoModelo As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeAsientoModelo As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeAsientoModelo As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function ProvisionaBeneficios(ByVal oeAsientoModelo As e_AsientoModelo, ByVal oePeriodo As e_Periodo, ByVal leBeneficios As List(Of e_ProvisionBonificacion)) As Boolean

End Interface
