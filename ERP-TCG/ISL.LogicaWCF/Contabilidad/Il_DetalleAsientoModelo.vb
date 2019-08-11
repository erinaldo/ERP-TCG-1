Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_DetalleAsientoModelo" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_DetalleAsientoModelo

    <OperationContract()> _
    Function Obtener(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As e_DetalleAsientoModelo

    <OperationContract()> _
    Function Listar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As List(Of e_DetalleAsientoModelo)

    <OperationContract()> _
    Function Validar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean

    <OperationContract()> _
    Function Guardar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean

    <OperationContract()> _
    Function Eliminar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean

End Interface
