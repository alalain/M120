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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string NameField;
        
        private string PhoneNumberField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatBase", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ZenChat.ZenChatService.ChatRoom))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ZenChat.ZenChatService.PrivateConversation))]
    public partial class ChatBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> MembersField;
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.ChatMessage> MessagesField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatRoom", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class ChatRoom : ZenChat.ZenChatService.ChatBase {
        
        private ZenChat.ZenChatService.User AdminField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ZenChat.ZenChatService.User Admin {
            get {
                return this.AdminField;
            }
            set {
                if ((object.ReferenceEquals(this.AdminField, value) != true)) {
                    this.AdminField = value;
                    this.RaisePropertyChanged("Admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PrivateConversation", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class PrivateConversation : ZenChat.ZenChatService.ChatBase {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatMessage", Namespace="http://schemas.datacontract.org/2004/07/ZenChat.ServiceClasses")]
    public partial class ChatMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ArrivedAtField;
        
        private ZenChat.ZenChatService.User AuthorField;
        
        private System.DateTime CreatedField;
        
        private int IdField;
        
        private string MessageField;
        
        private System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User> ReadByField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://zenchatservice.azurewebsites.net/ZenChat.svc", ConfigurationName="ZenChatService.ZenChatService")]
    public interface ZenChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetUser", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetUserRespons" +
            "e")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.User> GetUserAsync(string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/Login", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/LoginResponse")]
        System.Threading.Tasks.Task<System.Tuple<int, ZenChat.ZenChatService.User>> LoginAsync(string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/LoginWithId", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/LoginWithIdRes" +
            "ponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.User> LoginWithIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetFriends", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetFriendsResp" +
            "onse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User>> GetFriendsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetAllChatRoom" +
            "s", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetAllChatRoom" +
            "sResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.ChatBase>> GetAllChatRoomsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetChatRoom", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/GetChatRoomRes" +
            "ponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> GetChatRoomAsync(int chatRoomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/CreateChatRoom" +
            "", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/CreateChatRoom" +
            "Response")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> CreateChatRoomAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/JoinChatroom", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/JoinChatroomRe" +
            "sponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> JoinChatroomAsync(int userId, int chatRoomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/WriteChatMessa" +
            "ge", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/WriteChatMessa" +
            "geResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> WriteChatMessageAsync(int userId, int chatRoomId, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/ReadChatMessag" +
            "e", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/ReadChatMessag" +
            "eResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> ReadChatMessageAsync(int userId, int messageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/RecieveChatMes" +
            "sage", ReplyAction="http://zenchatservice.azurewebsites.net/ZenChat.svc/ZenChatService/RecieveChatMes" +
            "sageResponse")]
        System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> RecieveChatMessageAsync(int userId, int messageId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZenChatServiceChannel : ZenChat.ZenChatService.ZenChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZenChatServiceClient : System.ServiceModel.ClientBase<ZenChat.ZenChatService.ZenChatService>, ZenChat.ZenChatService.ZenChatService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ZenChatServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ZenChatServiceClient.GetBindingForEndpoint(endpointConfiguration), ZenChatServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ZenChatServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ZenChatServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ZenChatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.User> GetUserAsync(string phoneNumber) {
            return base.Channel.GetUserAsync(phoneNumber);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<int, ZenChat.ZenChatService.User>> LoginAsync(string name, string phone) {
            return base.Channel.LoginAsync(name, phone);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.User> LoginWithIdAsync(int id) {
            return base.Channel.LoginWithIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.User>> GetFriendsAsync(int userId) {
            return base.Channel.GetFriendsAsync(userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ZenChat.ZenChatService.ChatBase>> GetAllChatRoomsAsync(int userId) {
            return base.Channel.GetAllChatRoomsAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> GetChatRoomAsync(int chatRoomId) {
            return base.Channel.GetChatRoomAsync(chatRoomId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> CreateChatRoomAsync(int userId) {
            return base.Channel.CreateChatRoomAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> JoinChatroomAsync(int userId, int chatRoomId) {
            return base.Channel.JoinChatroomAsync(userId, chatRoomId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> WriteChatMessageAsync(int userId, int chatRoomId, string message) {
            return base.Channel.WriteChatMessageAsync(userId, chatRoomId, message);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> ReadChatMessageAsync(int userId, int messageId) {
            return base.Channel.ReadChatMessageAsync(userId, messageId);
        }
        
        public System.Threading.Tasks.Task<ZenChat.ZenChatService.ChatBase> RecieveChatMessageAsync(int userId, int messageId) {
            return base.Channel.RecieveChatMessageAsync(userId, messageId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ZenChatService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ZenChatService)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ZenChatService)) {
                return new System.ServiceModel.EndpointAddress("http://zenchatservice.azurewebsites.net/ZenChat.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ZenChatService)) {
                return new System.ServiceModel.EndpointAddress("https://zenchatservice.azurewebsites.net/ZenChat.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ZenChatService,
            
            BasicHttpsBinding_ZenChatService,
        }
    }
}
