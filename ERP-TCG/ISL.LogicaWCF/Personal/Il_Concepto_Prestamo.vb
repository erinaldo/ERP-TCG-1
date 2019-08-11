Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Concepto_Prestamo", también debe actualizar la referencia a "Il_Concepto_Prestamo" en Web.config.
<ServiceContract()> _
Public Interface Il_Concepto_Prestamo

    <OperationContract()> _
     Function Obtener(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As e_Concepto_Prestamo

    <OperationContract()> _
    Function Listar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As List(Of e_Concepto_Prestamo)

    <OperationContract()> _
    Function Validar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean
 
    <OperationContract()> _
    Function Eliminar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean


End Interface
