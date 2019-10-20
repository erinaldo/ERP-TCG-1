Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Concepto" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Concepto

    Function ComboGrilla(oeConcepto As e_Concepto) As Object

    Function EliminarTipoEvento(oeConcepto As e_Concepto) As Boolean

    Function Guardar(oeConcepto As e_Concepto, listaAreaTiEoevento As List(Of e_AreaTipoEvento)) As Boolean

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeConcepto As e_Concepto) As e_Concepto

    <OperationContract()>
    Function Listar(ByVal oeConcepto As e_Concepto) As List(Of e_Concepto)

    <OperationContract()>
    Function Validar(ByVal oeConcepto As e_Concepto) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeConcepto As e_Concepto) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeConcepto As e_Concepto) As Boolean

End Interface
