Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_DetalleRegistroDevolucion", también debe actualizar la referencia a "Il_DetalleRegistroDevolucion" en Web.config.
<ServiceContract()> _
Public Interface Il_DetalleRegistroDevolucion

    <OperationContract()> _
 Function Obtener(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As e_DetalleRegistroDevolucion

    <OperationContract()> _
    Function Listar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As List(Of e_DetalleRegistroDevolucion)

    <OperationContract()> _
    Function Validar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean

End Interface
