Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Prestamo_Sancion", también debe actualizar la referencia a "Il_Prestamo_Sancion" en Web.config.
<ServiceContract()> _
Public Interface Il_Prestamo_Sancion

    <OperationContract()> _
     Function Obtener(ByVal oePrestamoSancion As e_Prestamo_Sancion) As e_Prestamo_Sancion

    <OperationContract()> _
    Function Listar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As List(Of e_Prestamo_Sancion)

    <OperationContract()> _
    Function Validar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean

    <OperationContract()> _
     Function Guardar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oePrestamoSancion As e_Prestamo_Sancion) As Boolean


End Interface
