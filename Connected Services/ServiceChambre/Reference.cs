﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsService.ServiceChambre {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceChambre.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfService.CompositeType GetDataUsingDataContract(WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfService.CompositeType> GetDataUsingDataContractAsync(WcfService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AjouterChambre", ReplyAction="http://tempuri.org/IService1/AjouterChambreResponse")]
        bool AjouterChambre(WcfService.Model.Chambres ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AjouterChambre", ReplyAction="http://tempuri.org/IService1/AjouterChambreResponse")]
        System.Threading.Tasks.Task<bool> AjouterChambreAsync(WcfService.Model.Chambres ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditerChambre", ReplyAction="http://tempuri.org/IService1/EditerChambreResponse")]
        bool EditerChambre(WcfService.Model.Chambres ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditerChambre", ReplyAction="http://tempuri.org/IService1/EditerChambreResponse")]
        System.Threading.Tasks.Task<bool> EditerChambreAsync(WcfService.Model.Chambres ch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SupprimerChambre", ReplyAction="http://tempuri.org/IService1/SupprimerChambreResponse")]
        bool SupprimerChambre(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SupprimerChambre", ReplyAction="http://tempuri.org/IService1/SupprimerChambreResponse")]
        System.Threading.Tasks.Task<bool> SupprimerChambreAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListerChambres", ReplyAction="http://tempuri.org/IService1/ListerChambresResponse")]
        WcfService.Model.Chambres[] ListerChambres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListerChambres", ReplyAction="http://tempuri.org/IService1/ListerChambresResponse")]
        System.Threading.Tasks.Task<WcfService.Model.Chambres[]> ListerChambresAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsService.ServiceChambre.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsService.ServiceChambre.IService1>, ConsService.ServiceChambre.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfService.CompositeType GetDataUsingDataContract(WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfService.CompositeType> GetDataUsingDataContractAsync(WcfService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool AjouterChambre(WcfService.Model.Chambres ch) {
            return base.Channel.AjouterChambre(ch);
        }
        
        public System.Threading.Tasks.Task<bool> AjouterChambreAsync(WcfService.Model.Chambres ch) {
            return base.Channel.AjouterChambreAsync(ch);
        }
        
        public bool EditerChambre(WcfService.Model.Chambres ch) {
            return base.Channel.EditerChambre(ch);
        }
        
        public System.Threading.Tasks.Task<bool> EditerChambreAsync(WcfService.Model.Chambres ch) {
            return base.Channel.EditerChambreAsync(ch);
        }
        
        public bool SupprimerChambre(int id) {
            return base.Channel.SupprimerChambre(id);
        }
        
        public System.Threading.Tasks.Task<bool> SupprimerChambreAsync(int id) {
            return base.Channel.SupprimerChambreAsync(id);
        }
        
        public WcfService.Model.Chambres[] ListerChambres() {
            return base.Channel.ListerChambres();
        }
        
        public System.Threading.Tasks.Task<WcfService.Model.Chambres[]> ListerChambresAsync() {
            return base.Channel.ListerChambresAsync();
        }
    }
}
