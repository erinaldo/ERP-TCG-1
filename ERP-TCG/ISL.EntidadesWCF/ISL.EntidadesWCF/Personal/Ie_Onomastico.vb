Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Onomastico", también debe actualizar la referencia a "Ie_Onomastico" en Web.config.
<ServiceContract()> _
Public Interface Ie_Onomastico

    ''' <summary>
    ''' Obtener una entidad de tipo e_Onomastico
    ''' </summary>
    ''' <param name="onomastico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <OperationContract()> _
        Function Obtener(ByVal onomastico As e_Onomastico) As e_Onomastico

End Interface
