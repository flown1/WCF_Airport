﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:2.0.50727.8922
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirportServerConsole.Database
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Flight", Namespace = "http://schemas.datacontract.org/2004/07/AirportServerConsole.Database")]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string citySourceField;

        private string cityTargetField;

        private System.DateTime timeArriveField;

        private System.DateTime timeDepartureField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string citySource
        {
            get
            {
                return this.citySourceField;
            }
            set
            {
                this.citySourceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cityTarget
        {
            get
            {
                return this.cityTargetField;
            }
            set
            {
                this.cityTargetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime timeArrive
        {
            get
            {
                return this.timeArriveField;
            }
            set
            {
                this.timeArriveField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime timeDeparture
        {
            get
            {
                return this.timeDepartureField;
            }
            set
            {
                this.timeDepartureField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IService1")]
public interface IService1
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetTestWelcomeMessage", ReplyAction = "http://tempuri.org/IService1/GetTestWelcomeMessageResponse")]
    string GetTestWelcomeMessage(bool wannaBeWelcomed);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllFlights", ReplyAction = "http://tempuri.org/IService1/GetAllFlightsResponse")]
    AirportServerConsole.Database.Flight[] GetAllFlights();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetFlights", ReplyAction = "http://tempuri.org/IService1/GetFlightsResponse")]
    AirportServerConsole.Database.Flight[] GetFlights(string citySource, string cityDestination, System.DateTime startDepartureTime, System.DateTime endDepartureTime);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetFlightsNoTime", ReplyAction = "http://tempuri.org/IService1/GetFlightsNoTimeResponse")]
    AirportServerConsole.Database.Flight[] GetFlightsNoTime(string citySource, string cityDestination);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IService1Channel : IService1, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class Service1Client : System.ServiceModel.ClientBase<IService1>, IService1
{

    public Service1Client()
    {
    }

    public Service1Client(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public Service1Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public string GetTestWelcomeMessage(bool wannaBeWelcomed)
    {
        return base.Channel.GetTestWelcomeMessage(wannaBeWelcomed);
    }

    public AirportServerConsole.Database.Flight[] GetAllFlights()
    {
        return base.Channel.GetAllFlights();
    }

    public AirportServerConsole.Database.Flight[] GetFlights(string citySource, string cityDestination, System.DateTime startDepartureTime, System.DateTime endDepartureTime)
    {
        return base.Channel.GetFlights(citySource, cityDestination, startDepartureTime, endDepartureTime);
    }

    public AirportServerConsole.Database.Flight[] GetFlightsNoTime(string citySource, string cityDestination)
    {
        return base.Channel.GetFlightsNoTime(citySource, cityDestination);
    }
}
