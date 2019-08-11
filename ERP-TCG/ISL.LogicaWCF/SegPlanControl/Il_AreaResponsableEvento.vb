Imports System.ServiceModel
Imports ISL.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Il_AreaResponsableEvento" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Il_AreaResponsableEvento

    Function GuardarEstado(oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean

    Function GuardarGlosa(oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean

    <OperationContract()>
    Sub DoWork()

    <OperationContract()>
    Function Obtener(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As e_AreaResponsableEvento

    <OperationContract()>
    Function Listar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As List(Of e_AreaResponsableEvento)

    <OperationContract()>
    Function Validar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean

    <OperationContract()>
    Function Guardar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean

    <OperationContract()>
    Function Eliminar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean

End Interface
