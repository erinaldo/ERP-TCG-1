Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_Moneda", también debe actualizar la referencia a "Il_Moneda" en Web.config.
<ServiceContract()> _
Public Interface Il_Moneda

    <OperationContract()> _
    Function Obtener(ByVal oeMoneda As e_Moneda) As e_Moneda

    <OperationContract()> _
    Function Listar(ByVal oeMoneda As e_Moneda) As List(Of e_Moneda)

    <OperationContract()> _
    Function ComboGrilla(ByVal ListaMoneda As List(Of e_Moneda))

    <OperationContract()> _
    Function Validar(ByVal oeMoneda As e_Moneda) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeMoneda As e_Moneda) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeMoneda As e_Moneda) As Boolean

End Interface
