Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleModelo_Referencia" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleModelo_Referencia

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As e_DetalleModelo_Referencia

    <OperationContract()> _
    Function Listar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As List(Of e_DetalleModelo_Referencia)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As Boolean

End Interface
