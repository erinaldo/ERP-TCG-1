Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_AsientoModelo_ActividadNegocio" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_AsientoModelo_ActividadNegocio

    <OperationContract()>
    Function Obtener(ByVal asientomodeloactividadnegocio As e_AsientoModelo_ActividadNegocio) As e_AsientoModelo_ActividadNegocio

End Interface
