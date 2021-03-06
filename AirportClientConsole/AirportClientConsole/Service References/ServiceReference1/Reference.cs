﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirportClientConsole.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="http://schemas.datacontract.org/2004/07/AirportServerConsole.Database")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string citySourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityTargetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string timeArriveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string timeDepartureField;
        
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
        public string citySource {
            get {
                return this.citySourceField;
            }
            set {
                if ((object.ReferenceEquals(this.citySourceField, value) != true)) {
                    this.citySourceField = value;
                    this.RaisePropertyChanged("citySource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cityTarget {
            get {
                return this.cityTargetField;
            }
            set {
                if ((object.ReferenceEquals(this.cityTargetField, value) != true)) {
                    this.cityTargetField = value;
                    this.RaisePropertyChanged("cityTarget");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeArrive {
            get {
                return this.timeArriveField;
            }
            set {
                if ((object.ReferenceEquals(this.timeArriveField, value) != true)) {
                    this.timeArriveField = value;
                    this.RaisePropertyChanged("timeArrive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeDeparture {
            get {
                return this.timeDepartureField;
            }
            set {
                if ((object.ReferenceEquals(this.timeDepartureField, value) != true)) {
                    this.timeDepartureField = value;
                    this.RaisePropertyChanged("timeDeparture");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestWelcomeMessage", ReplyAction="http://tempuri.org/IService1/GetTestWelcomeMessageResponse")]
        string GetTestWelcomeMessage(bool wannaBeWelcomed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTestWelcomeMessage", ReplyAction="http://tempuri.org/IService1/GetTestWelcomeMessageResponse")]
        System.Threading.Tasks.Task<string> GetTestWelcomeMessageAsync(bool wannaBeWelcomed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllFlights", ReplyAction="http://tempuri.org/IService1/GetAllFlightsResponse")]
        AirportClientConsole.ServiceReference1.Flight[] GetAllFlights();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllFlights", ReplyAction="http://tempuri.org/IService1/GetAllFlightsResponse")]
        System.Threading.Tasks.Task<AirportClientConsole.ServiceReference1.Flight[]> GetAllFlightsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AirportClientConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AirportClientConsole.ServiceReference1.IService1>, AirportClientConsole.ServiceReference1.IService1 {
        
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
        
        public string GetTestWelcomeMessage(bool wannaBeWelcomed) {
            return base.Channel.GetTestWelcomeMessage(wannaBeWelcomed);
        }
        
        public System.Threading.Tasks.Task<string> GetTestWelcomeMessageAsync(bool wannaBeWelcomed) {
            return base.Channel.GetTestWelcomeMessageAsync(wannaBeWelcomed);
        }
        
        public AirportClientConsole.ServiceReference1.Flight[] GetAllFlights() {
            return base.Channel.GetAllFlights();
        }
        
        public System.Threading.Tasks.Task<AirportClientConsole.ServiceReference1.Flight[]> GetAllFlightsAsync() {
            return base.Channel.GetAllFlightsAsync();
        }
    }
}
