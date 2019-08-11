Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_BolsaRuta", también debe actualizar la referencia a "Ie_BolsaRuta" en Web.config.
<ServiceContract()> _
Public Interface Ie_BolsaRuta

    <OperationContract()> _
    Function Obtener(ByVal bolsaRuta As e_BolsaRuta) As e_BolsaRuta

End Interface
