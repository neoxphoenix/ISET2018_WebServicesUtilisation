﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISET2018_WebServicesUtilisation.UtiliserServiceHEL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ISET2018_WebServices")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WS_Personne", Namespace="http://schemas.datacontract.org/2004/07/ISET2018_WebServices")]
    [System.SerializableAttribute()]
    public partial class WS_Personne : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WS_CheckISBN", Namespace="http://schemas.datacontract.org/2004/07/ISET2018_WebServices")]
    [System.SerializableAttribute()]
    public partial class WS_CheckISBN : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNnumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int checkDigitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool codeValideField;
        
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
        public string ISBNnum {
            get {
                return this.ISBNnumField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNnumField, value) != true)) {
                    this.ISBNnumField = value;
                    this.RaisePropertyChanged("ISBNnum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int checkDigit {
            get {
                return this.checkDigitField;
            }
            set {
                if ((this.checkDigitField.Equals(value) != true)) {
                    this.checkDigitField = value;
                    this.RaisePropertyChanged("checkDigit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool codeValide {
            get {
                return this.codeValideField;
            }
            set {
                if ((this.codeValideField.Equals(value) != true)) {
                    this.codeValideField = value;
                    this.RaisePropertyChanged("codeValide");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UtiliserServiceHEL.IServiceHEL")]
    public interface IServiceHEL {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetData", ReplyAction="http://tempuri.org/IServiceHEL/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetData", ReplyAction="http://tempuri.org/IServiceHEL/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/HelloWorld", ReplyAction="http://tempuri.org/IServiceHEL/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/HelloWorld", ReplyAction="http://tempuri.org/IServiceHEL/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceHEL/GetDataUsingDataContractResponse")]
        ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType GetDataUsingDataContract(ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceHEL/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType> GetDataUsingDataContractAsync(ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetPersonneByID", ReplyAction="http://tempuri.org/IServiceHEL/GetPersonneByIDResponse")]
        ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne GetPersonneByID(int NID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/GetPersonneByID", ReplyAction="http://tempuri.org/IServiceHEL/GetPersonneByIDResponse")]
        System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne> GetPersonneByIDAsync(int NID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/CheckPersonneMDP", ReplyAction="http://tempuri.org/IServiceHEL/CheckPersonneMDPResponse")]
        ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne CheckPersonneMDP(string Nom, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/CheckPersonneMDP", ReplyAction="http://tempuri.org/IServiceHEL/CheckPersonneMDPResponse")]
        System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne> CheckPersonneMDPAsync(string Nom, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/CheckISBNNumber", ReplyAction="http://tempuri.org/IServiceHEL/CheckISBNNumberResponse")]
        ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_CheckISBN CheckISBNNumber(string numberToCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHEL/CheckISBNNumber", ReplyAction="http://tempuri.org/IServiceHEL/CheckISBNNumberResponse")]
        System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_CheckISBN> CheckISBNNumberAsync(string numberToCheck);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHELChannel : ISET2018_WebServicesUtilisation.UtiliserServiceHEL.IServiceHEL, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHELClient : System.ServiceModel.ClientBase<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.IServiceHEL>, ISET2018_WebServicesUtilisation.UtiliserServiceHEL.IServiceHEL {
        
        public ServiceHELClient() {
        }
        
        public ServiceHELClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceHELClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHELClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHELClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType GetDataUsingDataContract(ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType> GetDataUsingDataContractAsync(ISET2018_WebServicesUtilisation.UtiliserServiceHEL.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne GetPersonneByID(int NID) {
            return base.Channel.GetPersonneByID(NID);
        }
        
        public System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne> GetPersonneByIDAsync(int NID) {
            return base.Channel.GetPersonneByIDAsync(NID);
        }
        
        public ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne CheckPersonneMDP(string Nom, string Password) {
            return base.Channel.CheckPersonneMDP(Nom, Password);
        }
        
        public System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_Personne> CheckPersonneMDPAsync(string Nom, string Password) {
            return base.Channel.CheckPersonneMDPAsync(Nom, Password);
        }
        
        public ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_CheckISBN CheckISBNNumber(string numberToCheck) {
            return base.Channel.CheckISBNNumber(numberToCheck);
        }
        
        public System.Threading.Tasks.Task<ISET2018_WebServicesUtilisation.UtiliserServiceHEL.WS_CheckISBN> CheckISBNNumberAsync(string numberToCheck) {
            return base.Channel.CheckISBNNumberAsync(numberToCheck);
        }
    }
}
