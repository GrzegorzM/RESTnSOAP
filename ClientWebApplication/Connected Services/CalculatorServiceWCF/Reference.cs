﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWebApplication.CalculatorServiceWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DivideByZeroFault", Namespace="http://schemas.datacontract.org/2004/07/WCFproject.Models")]
    [System.SerializableAttribute()]
    public partial class DivideByZeroFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceWCF.ICalculatorServiceWCF")]
    public interface ICalculatorServiceWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorServiceWCF/Divide", ReplyAction="http://tempuri.org/ICalculatorServiceWCF/DivideResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientWebApplication.CalculatorServiceWCF.DivideByZeroFault), Action="http://tempuri.org/ICalculatorServiceWCF/DivideDivideByZeroFaultFault", Name="DivideByZeroFault", Namespace="http://schemas.datacontract.org/2004/07/WCFproject.Models")]
        int Divide(int numerator, int denominator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorServiceWCF/Divide", ReplyAction="http://tempuri.org/ICalculatorServiceWCF/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int numerator, int denominator);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceWCFChannel : ClientWebApplication.CalculatorServiceWCF.ICalculatorServiceWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceWCFClient : System.ServiceModel.ClientBase<ClientWebApplication.CalculatorServiceWCF.ICalculatorServiceWCF>, ClientWebApplication.CalculatorServiceWCF.ICalculatorServiceWCF {
        
        public CalculatorServiceWCFClient() {
        }
        
        public CalculatorServiceWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Divide(int numerator, int denominator) {
            return base.Channel.Divide(numerator, denominator);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int numerator, int denominator) {
            return base.Channel.DivideAsync(numerator, denominator);
        }
    }
}
