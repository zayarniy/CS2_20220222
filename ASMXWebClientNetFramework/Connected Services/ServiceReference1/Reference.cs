//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASMXWebClientNetFramework.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse HelloWorld(ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name n1 from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        ASMXWebClientNetFramework.ServiceReference1.SumResponse Sum(ASMXWebClientNetFramework.ServiceReference1.SumRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sum", ReplyAction="*")]
        System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.SumResponse> SumAsync(ASMXWebClientNetFramework.ServiceReference1.SumRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SumRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Sum", Namespace="http://tempuri.org/", Order=0)]
        public ASMXWebClientNetFramework.ServiceReference1.SumRequestBody Body;
        
        public SumRequest() {
        }
        
        public SumRequest(ASMXWebClientNetFramework.ServiceReference1.SumRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SumRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string n1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string n2;
        
        public SumRequestBody() {
        }
        
        public SumRequestBody(string n1, string n2) {
            this.n1 = n1;
            this.n2 = n2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SumResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SumResponse", Namespace="http://tempuri.org/", Order=0)]
        public ASMXWebClientNetFramework.ServiceReference1.SumResponseBody Body;
        
        public SumResponse() {
        }
        
        public SumResponse(ASMXWebClientNetFramework.ServiceReference1.SumResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SumResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SumResult;
        
        public SumResponseBody() {
        }
        
        public SumResponseBody(string SumResult) {
            this.SumResult = SumResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap>, ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap.HelloWorld(ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest inValue = new ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequestBody();
            ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse retVal = ((ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse> ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap.HelloWorldAsync(ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest inValue = new ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ASMXWebClientNetFramework.ServiceReference1.HelloWorldRequestBody();
            return ((ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ASMXWebClientNetFramework.ServiceReference1.SumResponse ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap.Sum(ASMXWebClientNetFramework.ServiceReference1.SumRequest request) {
            return base.Channel.Sum(request);
        }
        
        public string Sum(string n1, string n2) {
            ASMXWebClientNetFramework.ServiceReference1.SumRequest inValue = new ASMXWebClientNetFramework.ServiceReference1.SumRequest();
            inValue.Body = new ASMXWebClientNetFramework.ServiceReference1.SumRequestBody();
            inValue.Body.n1 = n1;
            inValue.Body.n2 = n2;
            ASMXWebClientNetFramework.ServiceReference1.SumResponse retVal = ((ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap)(this)).Sum(inValue);
            return retVal.Body.SumResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.SumResponse> ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap.SumAsync(ASMXWebClientNetFramework.ServiceReference1.SumRequest request) {
            return base.Channel.SumAsync(request);
        }
        
        public System.Threading.Tasks.Task<ASMXWebClientNetFramework.ServiceReference1.SumResponse> SumAsync(string n1, string n2) {
            ASMXWebClientNetFramework.ServiceReference1.SumRequest inValue = new ASMXWebClientNetFramework.ServiceReference1.SumRequest();
            inValue.Body = new ASMXWebClientNetFramework.ServiceReference1.SumRequestBody();
            inValue.Body.n1 = n1;
            inValue.Body.n2 = n2;
            return ((ASMXWebClientNetFramework.ServiceReference1.WebServiceSoap)(this)).SumAsync(inValue);
        }
    }
}
