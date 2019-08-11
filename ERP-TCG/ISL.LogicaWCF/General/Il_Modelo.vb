Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Modelo", también debe actualizar la referencia a "Il_Modelo" en Web.config.
<ServiceContract()> _
Public Interface Il_Modelo

    <OperationContract()> _
    Function ValidarDuplicado(ByVal ls_Modelo As e_Modelo) As Boolean

    <OperationContract()> _
    Function Obtener(ByVal oeModeloVehiculo As e_Modelo) As e_Modelo

    <OperationContract()> _
    Function Listar(ByVal oeModeloVehiculo As e_Modelo) As List(Of e_Modelo)

    <OperationContract()> _
    Function Validar(ByVal oeModeloVehiculo As e_Modelo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeModeloVehiculo As e_Modelo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeModeloVehiculo As e_Modelo) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal loModelo As List(Of e_Modelo))

End Interface
