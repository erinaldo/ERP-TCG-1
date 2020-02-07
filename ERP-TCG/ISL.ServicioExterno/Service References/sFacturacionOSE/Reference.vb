﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace sFacturacionOSE
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://service.sunat.gob.pe", ConfigurationName:="sFacturacionOSE.billService")>  _
    Public Interface billService
        
        'CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/getStatus", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getStatus(ByVal request As sFacturacionOSE.getStatusRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="status")> sFacturacionOSE.getStatusResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/getStatus", ReplyAction:="*")>  _
        Function getStatusAsync(ByVal request As sFacturacionOSE.getStatusRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusResponse)
        
        'CODEGEN: El parámetro 'applicationResponse' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendBill", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function sendBill(ByVal request As sFacturacionOSE.sendBillRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="applicationResponse")> sFacturacionOSE.sendBillResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendBill", ReplyAction:="*")>  _
        Function sendBillAsync(ByVal request As sFacturacionOSE.sendBillRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendBillResponse)
        
        'CODEGEN: El parámetro 'ticket' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendPack", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function sendPack(ByVal request As sFacturacionOSE.sendPackRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="ticket")> sFacturacionOSE.sendPackResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendPack", ReplyAction:="*")>  _
        Function sendPackAsync(ByVal request As sFacturacionOSE.sendPackRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendPackResponse)
        
        'CODEGEN: El parámetro 'ticket' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendSummary", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function sendSummary(ByVal request As sFacturacionOSE.sendSummaryRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="ticket")> sFacturacionOSE.sendSummaryResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/sendSummary", ReplyAction:="*")>  _
        Function sendSummaryAsync(ByVal request As sFacturacionOSE.sendSummaryRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendSummaryResponse)
        
        'CODEGEN: El parámetro 'statusCdr' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/getStatusCdr", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getStatusCdr(ByVal request As sFacturacionOSE.getStatusCdrRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="statusCdr")> sFacturacionOSE.getStatusCdrResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://service.sunat.gob.pe/getStatusCdr", ReplyAction:="*")>  _
        Function getStatusCdrAsync(ByVal request As sFacturacionOSE.getStatusCdrRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusCdrResponse)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://service.sunat.gob.pe")>  _
    Partial Public Class statusResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private contentField() As Byte
        
        Private statusCodeField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary", Order:=0)>  _
        Public Property content() As Byte()
            Get
                Return Me.contentField
            End Get
            Set
                Me.contentField = value
                Me.RaisePropertyChanged("content")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property statusCode() As String
            Get
                Return Me.statusCodeField
            End Get
            Set
                Me.statusCodeField = value
                Me.RaisePropertyChanged("statusCode")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://service.sunat.gob.pe")>  _
    Partial Public Class statusCdr
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private contentField() As Byte
        
        Private statusCodeField As String
        
        Private statusMessageField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary", Order:=0)>  _
        Public Property content() As Byte()
            Get
                Return Me.contentField
            End Get
            Set
                Me.contentField = value
                Me.RaisePropertyChanged("content")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property statusCode() As String
            Get
                Return Me.statusCodeField
            End Get
            Set
                Me.statusCodeField = value
                Me.RaisePropertyChanged("statusCode")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property statusMessage() As String
            Get
                Return Me.statusMessageField
            End Get
            Set
                Me.statusMessageField = value
                Me.RaisePropertyChanged("statusMessage")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatus", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public ticket As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ticket As String)
            MyBase.New
            Me.ticket = ticket
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public status As sFacturacionOSE.statusResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal status As sFacturacionOSE.statusResponse)
            MyBase.New
            Me.status = status
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendBill", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendBillRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public fileName As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary")>  _
        Public contentFile() As Byte
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public partyType As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String)
            MyBase.New
            Me.fileName = fileName
            Me.contentFile = contentFile
            Me.partyType = partyType
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendBillResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendBillResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary")>  _
        Public applicationResponse() As Byte
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal applicationResponse() As Byte)
            MyBase.New
            Me.applicationResponse = applicationResponse
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendPack", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendPackRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public fileName As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary")>  _
        Public contentFile() As Byte
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public partyType As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String)
            MyBase.New
            Me.fileName = fileName
            Me.contentFile = contentFile
            Me.partyType = partyType
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendPackResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendPackResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public ticket As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ticket As String)
            MyBase.New
            Me.ticket = ticket
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendSummary", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendSummaryRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public fileName As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary")>  _
        Public contentFile() As Byte
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public partyType As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String)
            MyBase.New
            Me.fileName = fileName
            Me.contentFile = contentFile
            Me.partyType = partyType
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendSummaryResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class sendSummaryResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public ticket As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ticket As String)
            MyBase.New
            Me.ticket = ticket
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusCdr", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusCdrRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public rucComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public tipoComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public serieComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=3),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public numeroComprobante As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As String)
            MyBase.New
            Me.rucComprobante = rucComprobante
            Me.tipoComprobante = tipoComprobante
            Me.serieComprobante = serieComprobante
            Me.numeroComprobante = numeroComprobante
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusCdrResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusCdrResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public statusCdr As sFacturacionOSE.statusCdr
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal statusCdr As sFacturacionOSE.statusCdr)
            MyBase.New
            Me.statusCdr = statusCdr
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface billServiceChannel
        Inherits sFacturacionOSE.billService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class billServiceClient
        Inherits System.ServiceModel.ClientBase(Of sFacturacionOSE.billService)
        Implements sFacturacionOSE.billService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_getStatus(ByVal request As sFacturacionOSE.getStatusRequest) As sFacturacionOSE.getStatusResponse Implements sFacturacionOSE.billService.getStatus
            Return MyBase.Channel.getStatus(request)
        End Function
        
        Public Function getStatus(ByVal ticket As String) As sFacturacionOSE.statusResponse
            Dim inValue As sFacturacionOSE.getStatusRequest = New sFacturacionOSE.getStatusRequest()
            inValue.ticket = ticket
            Dim retVal As sFacturacionOSE.getStatusResponse = CType(Me,sFacturacionOSE.billService).getStatus(inValue)
            Return retVal.status
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_getStatusAsync(ByVal request As sFacturacionOSE.getStatusRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusResponse) Implements sFacturacionOSE.billService.getStatusAsync
            Return MyBase.Channel.getStatusAsync(request)
        End Function
        
        Public Function getStatusAsync(ByVal ticket As String) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusResponse)
            Dim inValue As sFacturacionOSE.getStatusRequest = New sFacturacionOSE.getStatusRequest()
            inValue.ticket = ticket
            Return CType(Me,sFacturacionOSE.billService).getStatusAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendBill(ByVal request As sFacturacionOSE.sendBillRequest) As sFacturacionOSE.sendBillResponse Implements sFacturacionOSE.billService.sendBill
            Return MyBase.Channel.sendBill(request)
        End Function
        
        Public Function sendBill(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As Byte()
            Dim inValue As sFacturacionOSE.sendBillRequest = New sFacturacionOSE.sendBillRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Dim retVal As sFacturacionOSE.sendBillResponse = CType(Me,sFacturacionOSE.billService).sendBill(inValue)
            Return retVal.applicationResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendBillAsync(ByVal request As sFacturacionOSE.sendBillRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendBillResponse) Implements sFacturacionOSE.billService.sendBillAsync
            Return MyBase.Channel.sendBillAsync(request)
        End Function
        
        Public Function sendBillAsync(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendBillResponse)
            Dim inValue As sFacturacionOSE.sendBillRequest = New sFacturacionOSE.sendBillRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Return CType(Me,sFacturacionOSE.billService).sendBillAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendPack(ByVal request As sFacturacionOSE.sendPackRequest) As sFacturacionOSE.sendPackResponse Implements sFacturacionOSE.billService.sendPack
            Return MyBase.Channel.sendPack(request)
        End Function
        
        Public Function sendPack(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As String
            Dim inValue As sFacturacionOSE.sendPackRequest = New sFacturacionOSE.sendPackRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Dim retVal As sFacturacionOSE.sendPackResponse = CType(Me,sFacturacionOSE.billService).sendPack(inValue)
            Return retVal.ticket
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendPackAsync(ByVal request As sFacturacionOSE.sendPackRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendPackResponse) Implements sFacturacionOSE.billService.sendPackAsync
            Return MyBase.Channel.sendPackAsync(request)
        End Function
        
        Public Function sendPackAsync(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendPackResponse)
            Dim inValue As sFacturacionOSE.sendPackRequest = New sFacturacionOSE.sendPackRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Return CType(Me,sFacturacionOSE.billService).sendPackAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendSummary(ByVal request As sFacturacionOSE.sendSummaryRequest) As sFacturacionOSE.sendSummaryResponse Implements sFacturacionOSE.billService.sendSummary
            Return MyBase.Channel.sendSummary(request)
        End Function
        
        Public Function sendSummary(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As String
            Dim inValue As sFacturacionOSE.sendSummaryRequest = New sFacturacionOSE.sendSummaryRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Dim retVal As sFacturacionOSE.sendSummaryResponse = CType(Me,sFacturacionOSE.billService).sendSummary(inValue)
            Return retVal.ticket
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_sendSummaryAsync(ByVal request As sFacturacionOSE.sendSummaryRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendSummaryResponse) Implements sFacturacionOSE.billService.sendSummaryAsync
            Return MyBase.Channel.sendSummaryAsync(request)
        End Function
        
        Public Function sendSummaryAsync(ByVal fileName As String, ByVal contentFile() As Byte, ByVal partyType As String) As System.Threading.Tasks.Task(Of sFacturacionOSE.sendSummaryResponse)
            Dim inValue As sFacturacionOSE.sendSummaryRequest = New sFacturacionOSE.sendSummaryRequest()
            inValue.fileName = fileName
            inValue.contentFile = contentFile
            inValue.partyType = partyType
            Return CType(Me,sFacturacionOSE.billService).sendSummaryAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_getStatusCdr(ByVal request As sFacturacionOSE.getStatusCdrRequest) As sFacturacionOSE.getStatusCdrResponse Implements sFacturacionOSE.billService.getStatusCdr
            Return MyBase.Channel.getStatusCdr(request)
        End Function
        
        Public Function getStatusCdr(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As String) As sFacturacionOSE.statusCdr
            Dim inValue As sFacturacionOSE.getStatusCdrRequest = New sFacturacionOSE.getStatusCdrRequest()
            inValue.rucComprobante = rucComprobante
            inValue.tipoComprobante = tipoComprobante
            inValue.serieComprobante = serieComprobante
            inValue.numeroComprobante = numeroComprobante
            Dim retVal As sFacturacionOSE.getStatusCdrResponse = CType(Me,sFacturacionOSE.billService).getStatusCdr(inValue)
            Return retVal.statusCdr
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function sFacturacionOSE_billService_getStatusCdrAsync(ByVal request As sFacturacionOSE.getStatusCdrRequest) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusCdrResponse) Implements sFacturacionOSE.billService.getStatusCdrAsync
            Return MyBase.Channel.getStatusCdrAsync(request)
        End Function
        
        Public Function getStatusCdrAsync(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As String) As System.Threading.Tasks.Task(Of sFacturacionOSE.getStatusCdrResponse)
            Dim inValue As sFacturacionOSE.getStatusCdrRequest = New sFacturacionOSE.getStatusCdrRequest()
            inValue.rucComprobante = rucComprobante
            inValue.tipoComprobante = tipoComprobante
            inValue.serieComprobante = serieComprobante
            inValue.numeroComprobante = numeroComprobante
            Return CType(Me,sFacturacionOSE.billService).getStatusCdrAsync(inValue)
        End Function
    End Class
End Namespace
