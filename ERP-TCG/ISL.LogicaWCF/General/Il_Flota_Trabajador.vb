Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()>
Public Interface Il_Flota_Trabajador

    <OperationContract()>
    Function Obtener(oeFlota_Trabajador As e_Flota_Trabajador) As e_Flota_Trabajador

    <OperationContract()>
    Function Listar(oeFlota_Trabajador As e_Flota_Trabajador) As List(Of e_Flota_Trabajador)

    <OperationContract()>
    Function Guardar(oeFlota_Trabajador As e_Flota_Trabajador) As Boolean

    <OperationContract()>
    Function Eliminar(oeFlota_Trabajador As e_Flota_Trabajador) As Boolean

End Interface