Imports System.ServiceModel
Imports ISL.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Bitacora

    <OperationContract()> _
    Function Guardar(ByVal l_Bitacora As List(Of e_Bitacora)) As Boolean

End Interface
