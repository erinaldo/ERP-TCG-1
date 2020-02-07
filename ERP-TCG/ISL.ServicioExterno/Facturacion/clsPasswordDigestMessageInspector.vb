Imports System.ServiceModel
Imports System.ServiceModel.Dispatcher
Imports System.Xml
Imports Microsoft.Web.Services3.Security.Tokens

Public Class clsPasswordDigestMessageInspector
    Implements IClientMessageInspector

    Public _Username As String
    Public _Password As String

    Public Sub New(username As String, password As String)
        _Username = username
        _Password = password
    End Sub

    Public Sub AfterReceiveReply(ByRef reply As Channels.Message, correlationState As Object) Implements IClientMessageInspector.AfterReceiveReply
        Return
    End Sub

    Public Function BeforeSendRequest(ByRef request As Channels.Message, channel As IClientChannel) As Object Implements IClientMessageInspector.BeforeSendRequest
        Dim _token As UsernameToken = New UsernameToken(_Username, _Password, PasswordOption.SendPlainText)
        Dim _securityToken As XmlElement = _token.GetXml(New XmlDocument)
        Dim _node = _securityToken.GetElementsByTagName("wsse:Nonce").Item(0)
        _node.RemoveAll()
        Dim _securityHeader As Channels.MessageHeader = Channels.MessageHeader.CreateHeader("Security", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", _securityToken, False)
        request.Headers.Add(_securityHeader)
        Return Convert.DBNull
    End Function

End Class
