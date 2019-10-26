Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_RegistroDevolucion", también debe actualizar la referencia a "Il_RegistroDevolucion" en Web.config.
<ServiceContract()> _
Public Interface Il_RegistroDevolucion

    <OperationContract()> _
  Function Obtener(ByVal oeregistrodevolucion As e_RegistroDevolucion) As e_RegistroDevolucion

    <OperationContract()> _
    Function Listar(ByVal oeregistrodevolucion As e_RegistroDevolucion) As List(Of e_RegistroDevolucion)

    <OperationContract()> _
    Function Validar(ByVal oeregistrodevolucion As e_RegistroDevolucion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeregistrodevolucion As e_RegistroDevolucion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeregistrodevolucion As e_RegistroDevolucion) As Boolean

End Interface
