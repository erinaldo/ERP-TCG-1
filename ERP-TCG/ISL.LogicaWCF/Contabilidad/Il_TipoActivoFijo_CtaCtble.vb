Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_TipoActivoFijo_CtaCtble" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_TipoActivoFijo_CtaCtble


    <OperationContract()>
    Function Obtener(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As e_TipoActivoFijo_CtaCtble

    <OperationContract()>
    Function Listar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As List(Of e_TipoActivoFijo_CtaCtble)

    <OperationContract()>
    Function Guardar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean

    <OperationContract()>
    Function Eliminar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean

End Interface
