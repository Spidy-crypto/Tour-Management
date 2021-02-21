﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tour", Namespace="http://schemas.datacontract.org/2004/07/Tour_CRUD")]
    [System.SerializableAttribute()]
    public partial class tour : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imagepathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int placeidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string priceField;
        
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
        public string desc {
            get {
                return this.descField;
            }
            set {
                if ((object.ReferenceEquals(this.descField, value) != true)) {
                    this.descField = value;
                    this.RaisePropertyChanged("desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imagepath {
            get {
                return this.imagepathField;
            }
            set {
                if ((object.ReferenceEquals(this.imagepathField, value) != true)) {
                    this.imagepathField = value;
                    this.RaisePropertyChanged("imagepath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int placeid {
            get {
                return this.placeidField;
            }
            set {
                if ((this.placeidField.Equals(value) != true)) {
                    this.placeidField = value;
                    this.RaisePropertyChanged("placeid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string price {
            get {
                return this.priceField;
            }
            set {
                if ((object.ReferenceEquals(this.priceField, value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPlace", ReplyAction="http://tempuri.org/IService1/addPlaceResponse")]
        bool addPlace(string name, string desc, string price, string imagepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPlace", ReplyAction="http://tempuri.org/IService1/addPlaceResponse")]
        System.Threading.Tasks.Task<bool> addPlaceAsync(string name, string desc, string price, string imagepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllPlace", ReplyAction="http://tempuri.org/IService1/getAllPlaceResponse")]
        Client.ServiceReference2.tour[] getAllPlace();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllPlace", ReplyAction="http://tempuri.org/IService1/getAllPlaceResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference2.tour[]> getAllPlaceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPlace", ReplyAction="http://tempuri.org/IService1/getPlaceResponse")]
        Client.ServiceReference2.tour getPlace(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPlace", ReplyAction="http://tempuri.org/IService1/getPlaceResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference2.tour> getPlaceAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getFPlace", ReplyAction="http://tempuri.org/IService1/getFPlaceResponse")]
        Client.ServiceReference2.tour[] getFPlace(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getFPlace", ReplyAction="http://tempuri.org/IService1/getFPlaceResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference2.tour[]> getFPlaceAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updatePlace", ReplyAction="http://tempuri.org/IService1/updatePlaceResponse")]
        bool updatePlace(int id, string name, string description, string price, string imagepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updatePlace", ReplyAction="http://tempuri.org/IService1/updatePlaceResponse")]
        System.Threading.Tasks.Task<bool> updatePlaceAsync(int id, string name, string description, string price, string imagepath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        bool delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addToFav", ReplyAction="http://tempuri.org/IService1/addToFavResponse")]
        bool addToFav(string email, int placeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addToFav", ReplyAction="http://tempuri.org/IService1/addToFavResponse")]
        System.Threading.Tasks.Task<bool> addToFavAsync(string email, int placeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addpessenger", ReplyAction="http://tempuri.org/IService1/addpessengerResponse")]
        bool addpessenger(string fname, string lname, string email, string age, string trip_date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addpessenger", ReplyAction="http://tempuri.org/IService1/addpessengerResponse")]
        System.Threading.Tasks.Task<bool> addpessengerAsync(string fname, string lname, string email, string age, string trip_date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference2.IService1>, Client.ServiceReference2.IService1 {
        
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
        
        public bool addPlace(string name, string desc, string price, string imagepath) {
            return base.Channel.addPlace(name, desc, price, imagepath);
        }
        
        public System.Threading.Tasks.Task<bool> addPlaceAsync(string name, string desc, string price, string imagepath) {
            return base.Channel.addPlaceAsync(name, desc, price, imagepath);
        }
        
        public Client.ServiceReference2.tour[] getAllPlace() {
            return base.Channel.getAllPlace();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.tour[]> getAllPlaceAsync() {
            return base.Channel.getAllPlaceAsync();
        }
        
        public Client.ServiceReference2.tour getPlace(int id) {
            return base.Channel.getPlace(id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.tour> getPlaceAsync(int id) {
            return base.Channel.getPlaceAsync(id);
        }
        
        public Client.ServiceReference2.tour[] getFPlace(string email) {
            return base.Channel.getFPlace(email);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.tour[]> getFPlaceAsync(string email) {
            return base.Channel.getFPlaceAsync(email);
        }
        
        public bool updatePlace(int id, string name, string description, string price, string imagepath) {
            return base.Channel.updatePlace(id, name, description, price, imagepath);
        }
        
        public System.Threading.Tasks.Task<bool> updatePlaceAsync(int id, string name, string description, string price, string imagepath) {
            return base.Channel.updatePlaceAsync(id, name, description, price, imagepath);
        }
        
        public bool delete(int id) {
            return base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(int id) {
            return base.Channel.deleteAsync(id);
        }
        
        public bool addToFav(string email, int placeid) {
            return base.Channel.addToFav(email, placeid);
        }
        
        public System.Threading.Tasks.Task<bool> addToFavAsync(string email, int placeid) {
            return base.Channel.addToFavAsync(email, placeid);
        }
        
        public bool addpessenger(string fname, string lname, string email, string age, string trip_date) {
            return base.Channel.addpessenger(fname, lname, email, age, trip_date);
        }
        
        public System.Threading.Tasks.Task<bool> addpessengerAsync(string fname, string lname, string email, string age, string trip_date) {
            return base.Channel.addpessengerAsync(fname, lname, email, age, trip_date);
        }
    }
}
