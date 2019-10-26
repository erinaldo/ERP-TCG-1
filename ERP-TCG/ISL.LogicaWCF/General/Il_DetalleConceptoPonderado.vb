Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleConceptoPonderado" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleConceptoPonderado

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As e_DetalleConceptoPonderado

    <OperationContract()> _
    Function Listar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As List(Of e_DetalleConceptoPonderado)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean

End Interface
