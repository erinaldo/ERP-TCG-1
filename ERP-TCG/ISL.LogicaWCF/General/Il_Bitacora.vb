Imports System.ServiceModel
Imports ERP.EntidadesWCF

<ServiceContract()> _
Public Interface Il_Bitacora

    <OperationContract()>
    Function Guardar(ByVal l_Bitacora As List(Of e_Bitacora), ByVal PrefijoID As String) As Boolean

End Interface
