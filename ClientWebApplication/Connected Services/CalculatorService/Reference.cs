﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWebApplication.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.CalculatorWebServiceSoap")]
    public interface CalculatorWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClientWebApplication.CalculatorService.HelloWorldResponse HelloWorld(ClientWebApplication.CalculatorService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.HelloWorldResponse> HelloWorldAsync(ClientWebApplication.CalculatorService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        // CODEGEN: Generating message contract since the wrapper name (AddThreeNumbers) of message AddThreeNumbers does not match the default value (Add1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        ClientWebApplication.CalculatorService.AddThreeNumbers1 Add1(ClientWebApplication.CalculatorService.AddThreeNumbers request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.AddThreeNumbers1> Add1Async(ClientWebApplication.CalculatorService.AddThreeNumbers request);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        ClientWebApplication.CalculatorService.GetCalculationsResponse GetCalculations(ClientWebApplication.CalculatorService.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync(ClientWebApplication.CalculatorService.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClientWebApplication.CalculatorService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClientWebApplication.CalculatorService.HelloWorldRequestBody Body) {
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
        public ClientWebApplication.CalculatorService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClientWebApplication.CalculatorService.HelloWorldResponseBody Body) {
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddThreeNumbers", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddThreeNumbers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int firstNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int secondNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int thirdNumber;
        
        public AddThreeNumbers() {
        }
        
        public AddThreeNumbers(int firstNumber, int secondNumber, int thirdNumber) {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddThreeNumbersResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddThreeNumbers1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int AddThreeNumbersResult;
        
        public AddThreeNumbers1() {
        }
        
        public AddThreeNumbers1(int AddThreeNumbersResult) {
            this.AddThreeNumbersResult = AddThreeNumbersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://tempuri.org/", Order=0)]
        public ClientWebApplication.CalculatorService.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(ClientWebApplication.CalculatorService.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientWebApplication.CalculatorService.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(ClientWebApplication.CalculatorService.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientWebApplication.CalculatorService.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(ClientWebApplication.CalculatorService.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServiceSoapChannel : ClientWebApplication.CalculatorService.CalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<ClientWebApplication.CalculatorService.CalculatorWebServiceSoap>, ClientWebApplication.CalculatorService.CalculatorWebServiceSoap {
        
        public CalculatorWebServiceSoapClient() {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWebApplication.CalculatorService.HelloWorldResponse ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.HelloWorld(ClientWebApplication.CalculatorService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClientWebApplication.CalculatorService.HelloWorldRequest inValue = new ClientWebApplication.CalculatorService.HelloWorldRequest();
            inValue.Body = new ClientWebApplication.CalculatorService.HelloWorldRequestBody();
            ClientWebApplication.CalculatorService.HelloWorldResponse retVal = ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.HelloWorldResponse> ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.HelloWorldAsync(ClientWebApplication.CalculatorService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.HelloWorldResponse> HelloWorldAsync() {
            ClientWebApplication.CalculatorService.HelloWorldRequest inValue = new ClientWebApplication.CalculatorService.HelloWorldRequest();
            inValue.Body = new ClientWebApplication.CalculatorService.HelloWorldRequestBody();
            return ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWebApplication.CalculatorService.AddThreeNumbers1 ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.Add1(ClientWebApplication.CalculatorService.AddThreeNumbers request) {
            return base.Channel.Add1(request);
        }
        
        public int Add1(int firstNumber, int secondNumber, int thirdNumber) {
            ClientWebApplication.CalculatorService.AddThreeNumbers inValue = new ClientWebApplication.CalculatorService.AddThreeNumbers();
            inValue.firstNumber = firstNumber;
            inValue.secondNumber = secondNumber;
            inValue.thirdNumber = thirdNumber;
            ClientWebApplication.CalculatorService.AddThreeNumbers1 retVal = ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).Add1(inValue);
            return retVal.AddThreeNumbersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.AddThreeNumbers1> ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.Add1Async(ClientWebApplication.CalculatorService.AddThreeNumbers request) {
            return base.Channel.Add1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.AddThreeNumbers1> Add1Async(int firstNumber, int secondNumber, int thirdNumber) {
            ClientWebApplication.CalculatorService.AddThreeNumbers inValue = new ClientWebApplication.CalculatorService.AddThreeNumbers();
            inValue.firstNumber = firstNumber;
            inValue.secondNumber = secondNumber;
            inValue.thirdNumber = thirdNumber;
            return ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).Add1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientWebApplication.CalculatorService.GetCalculationsResponse ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.GetCalculations(ClientWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public ClientWebApplication.CalculatorService.ArrayOfString GetCalculations() {
            ClientWebApplication.CalculatorService.GetCalculationsRequest inValue = new ClientWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new ClientWebApplication.CalculatorService.GetCalculationsRequestBody();
            ClientWebApplication.CalculatorService.GetCalculationsResponse retVal = ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.GetCalculationsResponse> ClientWebApplication.CalculatorService.CalculatorWebServiceSoap.GetCalculationsAsync(ClientWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync() {
            ClientWebApplication.CalculatorService.GetCalculationsRequest inValue = new ClientWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new ClientWebApplication.CalculatorService.GetCalculationsRequestBody();
            return ((ClientWebApplication.CalculatorService.CalculatorWebServiceSoap)(this)).GetCalculationsAsync(inValue);
        }
    }
}