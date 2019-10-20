Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_PrestamoDetalle", también debe actualizar la referencia a "Il_PrestamoDetalle" en Web.config.
<ServiceContract()> _
Public Interface Il_PrestamoDetalle

    <OperationContract()> _
      Function Obtener(ByVal oePrestamoDetalle As e_PrestamoDetalle) As e_PrestamoDetalle

    <OperationContract()> _
    Function Listar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As List(Of e_PrestamoDetalle)

    <OperationContract()> _
    Function Validar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean

    <OperationContract()> _
     Function GuardarLista(ByVal lePrestamoDet As List(Of e_PrestamoDetalle)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean

    <OperationContract()> _
     Function Ejecutar(ByVal oePrestamoDetalle As e_PrestamoDetalle, _
                       ByVal lePrestamo As List(Of e_Prestamo), ByVal FechaEjecucion As Date, _
                       ByVal IndAdelantoPrestamo As Boolean, ByVal ls_PeriodoEjec As String) As Boolean

    '<OperationContract()> _
    'Function Liquidar(ByVal oePrestamoDetalle As e_PrestamoDetalle) As Boolean

End Interface
