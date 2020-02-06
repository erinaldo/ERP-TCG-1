Imports System.ServiceModel
Imports System.ServiceModel.Description

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClaveSunat" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClaveSunat.svc o l_ClaveSunat.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClaveSunat
    Implements IEndpointBehavior

    Public _Username As String
    Public _Password As String

    Public Sub New(username As String, password As String)
        _Username = username
        _Password = password
    End Sub

    Public Sub AddBindingParameters(endpoint As ServiceEndpoint, bindingParameters As Channels.BindingParameterCollection) Implements IEndpointBehavior.AddBindingParameters
        Return
    End Sub

    Public Sub ApplyDispatchBehavior(endpoint As ServiceEndpoint, endpointDispatcher As Dispatcher.EndpointDispatcher) Implements IEndpointBehavior.ApplyDispatchBehavior
        Return
    End Sub

    Public Sub Validate(endpoint As ServiceEndpoint) Implements IEndpointBehavior.Validate
        Return
    End Sub

    Public Sub ApplyClientBehavior(endpoint As ServiceEndpoint, clientRuntime As Dispatcher.ClientRuntime) Implements IEndpointBehavior.ApplyClientBehavior
        clientRuntime.ClientMessageInspectors.Add(New l_CredencialFacturacion(_Username, _Password))
    End Sub
End Class
