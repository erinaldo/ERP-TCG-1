Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Flota", también debe actualizar la referencia a "Il_Flota" en Web.config.
<ServiceContract()> _
Public Interface Il_Flota

    <OperationContract()> _
    Function Obtener(ByVal oeFlota As e_Flota) As e_Flota

    <OperationContract()> _
    Function Listar(ByVal oeFlota As e_Flota) As List(Of e_Flota)

    <OperationContract()> _
    Function Validar(ByVal oeFlota As e_Flota) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeFlota As e_Flota) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeFlota As e_Flota) As Boolean

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaFlota As List(Of e_Flota))

End Interface
