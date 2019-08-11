Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Material_DesenoNeu", también debe actualizar la referencia a "Ie_Material_DesenoNeu" en Web.config.
<ServiceContract()> _
Public Interface Ie_Material_DisenoNeu

    <OperationContract()> _
    Function Obtener(ByVal material_disenoneu As e_Material_DisenoNeu) As e_Material_DisenoNeu

End Interface
