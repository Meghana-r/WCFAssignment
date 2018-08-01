﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.icard")]
    public interface icard {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/cardvalidate", ReplyAction="http://tempuri.org/icard/cardvalidateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/icard/cardvalidateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool cardvalidate(int cardno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/cardvalidate", ReplyAction="http://tempuri.org/icard/cardvalidateResponse")]
        System.Threading.Tasks.Task<bool> cardvalidateAsync(int cardno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/expValidate", ReplyAction="http://tempuri.org/icard/expValidateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/icard/expValidateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool expValidate(System.DateTime transactdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/expValidate", ReplyAction="http://tempuri.org/icard/expValidateResponse")]
        System.Threading.Tasks.Task<bool> expValidateAsync(System.DateTime transactdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/cvvValidate", ReplyAction="http://tempuri.org/icard/cvvValidateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/icard/cvvValidateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool cvvValidate(int cvv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/cvvValidate", ReplyAction="http://tempuri.org/icard/cvvValidateResponse")]
        System.Threading.Tasks.Task<bool> cvvValidateAsync(int cvv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/transaction", ReplyAction="http://tempuri.org/icard/transactionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/icard/transactionArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        double transaction(int transactamt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/icard/transaction", ReplyAction="http://tempuri.org/icard/transactionResponse")]
        System.Threading.Tasks.Task<double> transactionAsync(int transactamt);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface icardChannel : Client.ServiceReference1.icard, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class icardClient : System.ServiceModel.ClientBase<Client.ServiceReference1.icard>, Client.ServiceReference1.icard {
        
        public icardClient() {
        }
        
        public icardClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public icardClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public icardClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public icardClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool cardvalidate(int cardno) {
            return base.Channel.cardvalidate(cardno);
        }
        
        public System.Threading.Tasks.Task<bool> cardvalidateAsync(int cardno) {
            return base.Channel.cardvalidateAsync(cardno);
        }
        
        public bool expValidate(System.DateTime transactdate) {
            return base.Channel.expValidate(transactdate);
        }
        
        public System.Threading.Tasks.Task<bool> expValidateAsync(System.DateTime transactdate) {
            return base.Channel.expValidateAsync(transactdate);
        }
        
        public bool cvvValidate(int cvv) {
            return base.Channel.cvvValidate(cvv);
        }
        
        public System.Threading.Tasks.Task<bool> cvvValidateAsync(int cvv) {
            return base.Channel.cvvValidateAsync(cvv);
        }
        
        public double transaction(int transactamt) {
            return base.Channel.transaction(transactamt);
        }
        
        public System.Threading.Tasks.Task<double> transactionAsync(int transactamt) {
            return base.Channel.transactionAsync(transactamt);
        }
    }
}
