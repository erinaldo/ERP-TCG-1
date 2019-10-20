Imports System.ServiceModel
Imports ERP.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "Il_GuiaTransportistaInterrumpida", también debe actualizar la referencia a "Il_GuiaTransportistaInterrumpida" en Web.config.
<ServiceContract()> _
Public Interface Il_GuiaTransportistaInterrumpida

    <OperationContract()> _
    Function Obtener(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As e_GuiaTransportistaInterrumpida

    <OperationContract()> _
    Function Listar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As List(Of e_GuiaTransportistaInterrumpida)

    <OperationContract()> _
    Function Validar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean

End Interface
