Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegistroConsumoCombustible", también debe actualizar la referencia a "Il_RegistroConsumoCombustible" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistroConsumoCombustible

    <OperationContract()> _
    Function Obtener(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible

    <OperationContract()> _
    Function Listar(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As List(Of e_RegistroConsumoCombustible)

    <OperationContract()> _
    Sub ValidarGrifo(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Sub ValidarDireccion(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Sub ValidarSubAlmacen(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Function ValidarFechaTanqueActual(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Function Validar48Horas(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Sub ValidarNroValeDireccion(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Function Validar(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean

    <OperationContract()> _
    Sub ValidarPeriodo(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible)

    <OperationContract()> _
    Function ListarDts(oeRegCon As e_RegistroConsumoCombustible) As DataSet

    <OperationContract()> _
    Function Guardar(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible, oeOrden As e_Orden) As e_RegistroConsumoCombustible

    <OperationContract()> _
    Function Eliminar(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean

    <OperationContract()> _
    Function ValidarFechaTanqueo(oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean

    <OperationContract()> _
    Function CalcularRendimiento(oeRegistrarConsumo As e_RegistroConsumoCombustible) As DataSet

    <OperationContract()> _
    Sub AsientoConsumoDiesel(oeOrdenSalida As e_Orden, idReg As String)

    <OperationContract()> _
    Function AsientoConsumoDieselMasivo(loReg As List(Of e_RegistroConsumoCombustible), loAsientoModelo As List(Of e_AsientoModelo), oeOrden As e_Orden) As Boolean

End Interface
