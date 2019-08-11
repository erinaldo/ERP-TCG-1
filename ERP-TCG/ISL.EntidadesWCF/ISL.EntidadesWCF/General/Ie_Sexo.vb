Imports System.ServiceModel

' NOTA: si cambia aquí el nombre de clase "Ie_Sexo", también debe actualizar la referencia a "Ie_Sexo" en Web.config.
<ServiceContract()> _
Public Interface Ie_Sexo

    <OperationContract()> _
    Function Obtener(ByVal sexo As e_Sexo) As e_Sexo

    <OperationContract()> _
    Sub AsignaValores(ByVal sexo As String)

    ''' <summary>
    ''' Antes esta funcion se llamaba AsignaValores
    ''' se modificó el nombre por restricción en el WCF
    ''' </summary>
    ''' <param name="idSexo"></param>
    ''' <remarks></remarks>
    <OperationContract()> _
    Sub AsignaValor(ByVal idSexo As Integer)

End Interface
