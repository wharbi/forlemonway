﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Leamonway.WinFormApp.FibonacciServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FibonacciServiceReference.FibonacciWebServiceSoap")]
    public interface FibonacciWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN: Generating message contract since element name xml from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse XmlToJson(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse> XmlToJsonAsync(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FibonacciWebServiceSoapChannel : Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FibonacciWebServiceSoapClient : System.ServiceModel.ClientBase<Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap>, Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap {
        
        public FibonacciWebServiceSoapClient() {
        }
        
        public FibonacciWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FibonacciWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FibonacciWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FibonacciWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap.XmlToJson(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest inValue = new Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest();
            inValue.Body = new Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse retVal = ((Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse> Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap.XmlToJsonAsync(Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest inValue = new Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequest();
            inValue.Body = new Leamonway.WinFormApp.FibonacciServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((Leamonway.WinFormApp.FibonacciServiceReference.FibonacciWebServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
