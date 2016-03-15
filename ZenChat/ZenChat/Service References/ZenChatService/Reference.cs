﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace ZenChat.ZenChatService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatRoomBase", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class ChatRoomBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime CreatedField;
        
        private string IdField;
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> MembersField;
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.ChatMessage> MessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> Members {
            get {
                return this.MembersField;
            }
            set {
                if ((object.ReferenceEquals(this.MembersField, value) != true)) {
                    this.MembersField = value;
                    this.RaisePropertyChanged("Members");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.ChatMessage> Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> FriendsField;
        
        private string IdField;
        
        private string NameField;
        
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> Friends {
            get {
                return this.FriendsField;
            }
            set {
                if ((object.ReferenceEquals(this.FriendsField, value) != true)) {
                    this.FriendsField = value;
                    this.RaisePropertyChanged("Friends");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatMessage", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class ChatMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ArrivedAtField;
        
        private ZenChat.ZenChatService.User AuthorField;
        
        private string IdField;
        
        private string MessageField;
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ReadByField;
        
        private System.DateTime SendDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ArrivedAt {
            get {
                return this.ArrivedAtField;
            }
            set {
                if ((object.ReferenceEquals(this.ArrivedAtField, value) != true)) {
                    this.ArrivedAtField = value;
                    this.RaisePropertyChanged("ArrivedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ZenChat.ZenChatService.User Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ReadBy {
            get {
                return this.ReadByField;
            }
            set {
                if ((object.ReferenceEquals(this.ReadByField, value) != true)) {
                    this.ReadByField = value;
                    this.RaisePropertyChanged("ReadBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SendDate {
            get {
                return this.SendDateField;
            }
            set {
                if ((this.SendDateField.Equals(value) != true)) {
                    this.SendDateField = value;
                    this.RaisePropertyChanged("SendDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ZenChatService.IZenChat")]
    public interface IZenChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZenChat/GetChatRoom", ReplyAction="http://tempuri.org/IZenChat/GetChatRoomResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> GetChatRoomAsync(string userId, string chatRoomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZenChat/CreateChatRoom", ReplyAction="http://tempuri.org/IZenChat/CreateChatRoomResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> CreateChatRoomAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZenChat/JoinChatroom", ReplyAction="http://tempuri.org/IZenChat/JoinChatroomResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> JoinChatroomAsync(string userId, string chatRoomId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZenChatChannel : ZenChat.ZenChatService.IZenChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZenChatClient : System.ServiceModel.ClientBase<ZenChat.ZenChatService.IZenChat>, ZenChat.ZenChatService.IZenChat {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ZenChatClient(EndpointConfiguration endpointConfiguration) : 
                base(ZenChatClient.GetBindingForEndpoint(endpointConfiguration), ZenChatClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ZenChatClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ZenChatClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> GetChatRoomAsync(string userId, string chatRoomId) {
            return base.Channel.GetChatRoomAsync(userId, chatRoomId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> CreateChatRoomAsync(string userId) {
            return base.Channel.CreateChatRoomAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatRoomBase> JoinChatroomAsync(string userId, string chatRoomId) {
            return base.Channel.JoinChatroomAsync(userId, chatRoomId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IZenChat)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IZenChat)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IZenChat)) {
                return new System.ServiceModel.EndpointAddress("http://zenchatservice.azurewebsites.net/ZenChat.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IZenChat)) {
                return new System.ServiceModel.EndpointAddress("https://zenchatservice.azurewebsites.net/ZenChat.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IZenChat,
            
            BasicHttpsBinding_IZenChat,
        }
    }
}
