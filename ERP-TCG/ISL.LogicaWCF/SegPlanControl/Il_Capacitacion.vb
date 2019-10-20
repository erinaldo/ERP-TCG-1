Imports ERP.EntidadesWCF
Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_Capacitacion" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_Capacitacion

    <OperationContract()> _
    Function Obtener(ByVal oeCapacitacion As e_Capacitacion) As e_Capacitacion

    <OperationContract()> _
    Function Listar(ByVal oeCapacitacion As e_Capacitacion) As List(Of e_Capacitacion)

    <OperationContract()> _
    Function Validar(ByVal oeCapacitacion As e_Capacitacion) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeCapacitacion As e_Capacitacion) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeCapacitacion As e_Capacitacion) As Boolean

End Interface
