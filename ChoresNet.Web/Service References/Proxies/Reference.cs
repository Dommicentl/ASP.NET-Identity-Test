﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChoresNet.Web.Proxies {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DateTimeOffset", Namespace="http://schemas.datacontract.org/2004/07/System")]
    [System.SerializableAttribute()]
    public partial struct DateTimeOffset : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateTimeField;
        
        private short OffsetMinutesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short OffsetMinutes {
            get {
                return this.OffsetMinutesField;
            }
            set {
                if ((this.OffsetMinutesField.Equals(value) != true)) {
                    this.OffsetMinutesField = value;
                    this.RaisePropertyChanged("OffsetMinutes");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxies.IAuthenticationService")]
    public interface IAuthenticationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/GetUserById", ReplyAction="http://tempuri.org/IAuthenticationService/GetUserByIdResponse")]
        ChoresNet.Common.User GetUserById(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/GetUserById", ReplyAction="http://tempuri.org/IAuthenticationService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<ChoresNet.Common.User> GetUserByIdAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/GetUserByName", ReplyAction="http://tempuri.org/IAuthenticationService/GetUserByNameResponse")]
        ChoresNet.Common.User GetUserByName(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/GetUserByName", ReplyAction="http://tempuri.org/IAuthenticationService/GetUserByNameResponse")]
        System.Threading.Tasks.Task<ChoresNet.Common.User> GetUserByNameAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/UpdateUser", ReplyAction="http://tempuri.org/IAuthenticationService/UpdateUserResponse")]
        void UpdateUser(ChoresNet.Common.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/UpdateUser", ReplyAction="http://tempuri.org/IAuthenticationService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(ChoresNet.Common.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/DeleteUser", ReplyAction="http://tempuri.org/IAuthenticationService/DeleteUserResponse")]
        void DeleteUser(ChoresNet.Common.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/DeleteUser", ReplyAction="http://tempuri.org/IAuthenticationService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(ChoresNet.Common.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationServiceChannel : ChoresNet.Web.Proxies.IAuthenticationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<ChoresNet.Web.Proxies.IAuthenticationService>, ChoresNet.Web.Proxies.IAuthenticationService {
        
        public AuthenticationServiceClient() {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ChoresNet.Common.User GetUserById(System.Guid userId) {
            return base.Channel.GetUserById(userId);
        }
        
        public System.Threading.Tasks.Task<ChoresNet.Common.User> GetUserByIdAsync(System.Guid userId) {
            return base.Channel.GetUserByIdAsync(userId);
        }
        
        public ChoresNet.Common.User GetUserByName(string userId) {
            return base.Channel.GetUserByName(userId);
        }
        
        public System.Threading.Tasks.Task<ChoresNet.Common.User> GetUserByNameAsync(string userId) {
            return base.Channel.GetUserByNameAsync(userId);
        }
        
        public void UpdateUser(ChoresNet.Common.User user) {
            base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(ChoresNet.Common.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public void DeleteUser(ChoresNet.Common.User user) {
            base.Channel.DeleteUser(user);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(ChoresNet.Common.User user) {
            return base.Channel.DeleteUserAsync(user);
        }
    }
}