﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.18408
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ser
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://qcm/")>  _
    Partial Public Class Exception
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private messageField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
                Me.RaisePropertyChanged("message")
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
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://qcm/", ConfigurationName:="ser.myws")>  _
    Public Interface myws
        
        'CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://qcm/myws/testRequest", ReplyAction:="http://qcm/myws/testResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(ser.Exception), Action:="http://qcm/myws/test/Fault/Exception", Name:="Exception"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function test(ByVal request As ser.testRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> ser.testResponse
        
        'CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://qcm/myws/helloRequest", ReplyAction:="http://qcm/myws/helloResponse"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function hello(ByVal request As ser.helloRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> ser.helloResponse
        
        'CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://qcm/myws/questionRequest", ReplyAction:="http://qcm/myws/questionResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(ser.Exception), Action:="http://qcm/myws/question/Fault/Exception", Name:="Exception"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function question(ByVal request As ser.questionRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> ser.questionResponse
        
        'CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://qcm/myws/repRequest", ReplyAction:="http://qcm/myws/repResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(ser.Exception), Action:="http://qcm/myws/rep/Fault/Exception", Name:="Exception"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function rep(ByVal request As ser.repRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> ser.repResponse
        
        'CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="http://qcm/myws/matiereRequest", ReplyAction:="http://qcm/myws/matiereResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(ser.Exception), Action:="http://qcm/myws/matiere/Fault/Exception", Name:="Exception"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function matiere(ByVal request As ser.matiereRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="return")> ser.matiereResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="test", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class testRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public id As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal id As Integer)
            MyBase.New
            Me.id = id
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="testResponse", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class testResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public [return]() As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [return]() As String)
            MyBase.New
            Me.[return] = [return]
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="hello", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class helloRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String)
            MyBase.New
            Me.name = name
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="helloResponse", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class helloResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public [return] As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [return] As String)
            MyBase.New
            Me.[return] = [return]
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="question", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class questionRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public nam As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal nam As Integer)
            MyBase.New
            Me.nam = nam
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="questionResponse", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class questionResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public [return]() As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [return]() As String)
            MyBase.New
            Me.[return] = [return]
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="rep", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class repRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public nam As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal nam As Integer)
            MyBase.New
            Me.nam = nam
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="repResponse", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class repResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public [return]() As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [return]() As String)
            MyBase.New
            Me.[return] = [return]
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="matiere", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class matiereRequest
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="matiereResponse", WrapperNamespace:="http://qcm/", IsWrapped:=true)>  _
    Partial Public Class matiereResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://qcm/", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public [return]() As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [return]() As String)
            MyBase.New
            Me.[return] = [return]
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface mywsChannel
        Inherits ser.myws, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class mywsClient
        Inherits System.ServiceModel.ClientBase(Of ser.myws)
        Implements ser.myws
        
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
        Function ser_myws_test(ByVal request As ser.testRequest) As ser.testResponse Implements ser.myws.test
            Return MyBase.Channel.test(request)
        End Function
        
        Public Function test(ByVal id As Integer) As String()
            Dim inValue As ser.testRequest = New ser.testRequest()
            inValue.id = id
            Dim retVal As ser.testResponse = CType(Me,ser.myws).test(inValue)
            Return retVal.[return]
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ser_myws_hello(ByVal request As ser.helloRequest) As ser.helloResponse Implements ser.myws.hello
            Return MyBase.Channel.hello(request)
        End Function
        
        Public Function hello(ByVal name As String) As String
            Dim inValue As ser.helloRequest = New ser.helloRequest()
            inValue.name = name
            Dim retVal As ser.helloResponse = CType(Me,ser.myws).hello(inValue)
            Return retVal.[return]
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ser_myws_question(ByVal request As ser.questionRequest) As ser.questionResponse Implements ser.myws.question
            Return MyBase.Channel.question(request)
        End Function
        
        Public Function question(ByVal nam As Integer) As String()
            Dim inValue As ser.questionRequest = New ser.questionRequest()
            inValue.nam = nam
            Dim retVal As ser.questionResponse = CType(Me,ser.myws).question(inValue)
            Return retVal.[return]
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ser_myws_rep(ByVal request As ser.repRequest) As ser.repResponse Implements ser.myws.rep
            Return MyBase.Channel.rep(request)
        End Function
        
        Public Function rep(ByVal nam As Integer) As String()
            Dim inValue As ser.repRequest = New ser.repRequest()
            inValue.nam = nam
            Dim retVal As ser.repResponse = CType(Me,ser.myws).rep(inValue)
            Return retVal.[return]
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ser_myws_matiere(ByVal request As ser.matiereRequest) As ser.matiereResponse Implements ser.myws.matiere
            Return MyBase.Channel.matiere(request)
        End Function
        
        Public Function matiere() As String()
            Dim inValue As ser.matiereRequest = New ser.matiereRequest()
            Dim retVal As ser.matiereResponse = CType(Me,ser.myws).matiere(inValue)
            Return retVal.[return]
        End Function
    End Class
End Namespace
