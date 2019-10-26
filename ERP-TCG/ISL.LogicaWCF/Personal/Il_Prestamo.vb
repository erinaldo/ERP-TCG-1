Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Prestamo", también debe actualizar la referencia a "Il_Prestamo" en Web.config.
<ServiceContract()> _
Public Interface Il_Prestamo

    <OperationContract()> _
     Function Obtener(ByVal oePrestamo As e_Prestamo) As e_Prestamo
 
    <OperationContract()> _
    Function Listar(ByVal oePrestamo As e_Prestamo) As List(Of e_Prestamo)

    <OperationContract()> _
    Function ListarRDT(ByVal oeRDT As e_ReporteDescTrabajador) As List(Of e_ReporteDescTrabajador)

    <OperationContract()> _
   Function ListarDS(ByVal oePrestamo As e_Prestamo) As DataSet

    <OperationContract()> _
     Function Validar(ByVal oePrestamo As e_Prestamo) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oePrestamo As e_Prestamo) As Boolean

    <OperationContract()> _
     Function Eliminar(ByVal oePrestamo As e_Prestamo) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal lePrestamo As List(Of e_Prestamo), ByVal IdGrupo As String, _
                           ByVal GrupoDesc As String, ByVal oePeriodo As e_Periodo, ByVal oeAsientoModel As e_AsientoModelo, _
                           ByVal ls_GrupoSanc As String, ByVal ls_GrupoDesc As String) As Boolean

    <OperationContract()> _
    Function Liquidar(ByVal lePrestamo As List(Of e_Prestamo)) As Boolean

    <OperationContract()> _
    Function CobrarCuota(ByVal leCargoPendiente As List(Of e_Prestamo), _
                         ByVal leCuotaCargoPend As List(Of e_PrestamoDetalle), _
                         ByVal IndLiquidacion As Boolean, _
                         ByVal oeAsientoModel As e_AsientoModelo) As Boolean

    <OperationContract()> _
    Function GuardarLista2(ByVal leDscto As List(Of e_Prestamo)) As Boolean

    <OperationContract()> _
    Function TransferirDeuda(ByVal oePrestamo As e_Prestamo, oePrestamoTrans As e_Prestamo) As Boolean

End Interface
