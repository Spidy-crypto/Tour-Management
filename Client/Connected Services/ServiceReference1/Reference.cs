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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/TourService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lnameField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fname {
            get {
                return this.fnameField;
            }
            set {
                if ((object.ReferenceEquals(this.fnameField, value) != true)) {
                    this.fnameField = value;
                    this.RaisePropertyChanged("fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lname {
            get {
                return this.lnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lnameField, value) != true)) {
                    this.lnameField = value;
                    this.RaisePropertyChanged("lname");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        bool addUser(string email, string fname, string lname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task<bool> addUserAsync(string email, string fname, string lname, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSingleUser", ReplyAction="http://tempuri.org/IService1/getSingleUserResponse")]
        Client.ServiceReference1.User getSingleUser(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSingleUser", ReplyAction="http://tempuri.org/IService1/getSingleUserResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.User> getSingleUserAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUsers", ReplyAction="http://tempuri.org/IService1/getUsersResponse")]
        Client.ServiceReference1.User[] getUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUsers", ReplyAction="http://tempuri.org/IService1/getUsersResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.User[]> getUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkUser", ReplyAction="http://tempuri.org/IService1/checkUserResponse")]
        bool checkUser(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkUser", ReplyAction="http://tempuri.org/IService1/checkUserResponse")]
        System.Threading.Tasks.Task<bool> checkUserAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
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
        
        public bool addUser(string email, string fname, string lname, string password) {
            return base.Channel.addUser(email, fname, lname, password);
        }
        
        public System.Threading.Tasks.Task<bool> addUserAsync(string email, string fname, string lname, string password) {
            return base.Channel.addUserAsync(email, fname, lname, password);
        }
        
        public Client.ServiceReference1.User getSingleUser(string email) {
            return base.Channel.getSingleUser(email);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.User> getSingleUserAsync(string email) {
            return base.Channel.getSingleUserAsync(email);
        }
        
        public Client.ServiceReference1.User[] getUsers() {
            return base.Channel.getUsers();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.User[]> getUsersAsync() {
            return base.Channel.getUsersAsync();
        }
        
        public bool checkUser(string email, string password) {
            return base.Channel.checkUser(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkUserAsync(string email, string password) {
            return base.Channel.checkUserAsync(email, password);
        }
    }
}
