Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_ActividadRestringido_Usuario", también debe actualizar la referencia a "Il_ActividadRestringido_Usuario" en Web.config.
<ServiceContract()> _
Public Interface Il_ActividadRestringido_Usuario

    <OperationContract()> _
Function Obtener(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As e_ActividadRestringida_Usuario

    <OperationContract()> _
    Function Listar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As List(Of e_ActividadRestringida_Usuario)

    <OperationContract()> _
    Function Validar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean

    <OperationContract()> _
    Function GuardarLista(ByVal leActividadRestringida_Usuario As List(Of e_ActividadRestringida_Usuario)) As Boolean

    <OperationContract()> _
    Function GuardarLista2(ByVal leActividadRestringida_Usuario As List(Of e_ActividadRestringida_Usuario)) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean

End Interface
