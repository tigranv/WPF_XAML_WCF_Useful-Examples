﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISender")]
    public interface ISender {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISender/GetData", ReplyAction="http://tempuri.org/ISender/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISender/GetData", ReplyAction="http://tempuri.org/ISender/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISender/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISender/GetDataUsingDataContractResponse")]
        WCFService.CompositeType GetDataUsingDataContract(WCFService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISender/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISender/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCFService.CompositeType> GetDataUsingDataContractAsync(WCFService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISenderChannel : Client2.ServiceReference1.ISender, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SenderClient : System.ServiceModel.ClientBase<Client2.ServiceReference1.ISender>, Client2.ServiceReference1.ISender {
        
        public SenderClient() {
        }
        
        public SenderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SenderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SenderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SenderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WCFService.CompositeType GetDataUsingDataContract(WCFService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCFService.CompositeType> GetDataUsingDataContractAsync(WCFService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
