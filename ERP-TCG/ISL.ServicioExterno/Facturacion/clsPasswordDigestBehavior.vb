Imports System.ServiceModel
Imports System.ServiceModel.Description

Public Class clsPasswordDigestBehavior
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

    Public Sub ApplyClientBehavior(endpoint As ServiceEndpoint, clientRuntime As Dispatcher.ClientRuntime) Implements IEndpointBehavior.ApplyClientBehavior
        clientRuntime.ClientMessageInspectors.Add(New clsPasswordDigestMessageInspector(_Username, _Password))
    End Sub

    Public Sub ApplyDispatchBehavior(endpoint As ServiceEndpoint, endpointDispatcher As Dispatcher.EndpointDispatcher) Implements IEndpointBehavior.ApplyDispatchBehavior
        Return
    End Sub

    Public Sub Validate(endpoint As ServiceEndpoint) Implements IEndpointBehavior.Validate
        Return
    End Sub

End Class
