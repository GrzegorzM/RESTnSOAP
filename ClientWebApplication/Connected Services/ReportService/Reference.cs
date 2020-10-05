﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWebApplication.ReportService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReportService.IReportService", CallbackContract=typeof(ClientWebApplication.ReportService.IReportServiceCallback))]
    public interface IReportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportService/ProcessReport", ReplyAction="http://tempuri.org/IReportService/ProcessReportResponse")]
        void ProcessReport();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportService/ProcessReport", ReplyAction="http://tempuri.org/IReportService/ProcessReportResponse")]
        System.Threading.Tasks.Task ProcessReportAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportService/Progress", ReplyAction="http://tempuri.org/IReportService/ProgressResponse")]
        void Progress(int percentageCompleted);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServiceChannel : ClientWebApplication.ReportService.IReportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportServiceClient : System.ServiceModel.DuplexClientBase<ClientWebApplication.ReportService.IReportService>, ClientWebApplication.ReportService.IReportService {
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ProcessReport() {
            base.Channel.ProcessReport();
        }
        
        public System.Threading.Tasks.Task ProcessReportAsync() {
            return base.Channel.ProcessReportAsync();
        }
    }
}
