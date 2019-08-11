Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_BolsaViaje", también debe actualizar la referencia a "Ie_BolsaViaje" en Web.config.
<ServiceContract()> _
Public Interface Ie_BolsaViaje

    <OperationContract()> _
    Function Obtener(ByVal bolsaViaje As e_BolsaViaje) As e_BolsaViaje

End Interface
