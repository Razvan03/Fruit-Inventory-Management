﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tema2Form.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShoppingListItem", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ShoppingListItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int QuantityField;
        
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PhotoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public byte[] Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name GetShoppingListItemsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingListItems", ReplyAction="*")]
        Tema2Form.ServiceReference1.GetShoppingListItemsResponse GetShoppingListItems(Tema2Form.ServiceReference1.GetShoppingListItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingListItems", ReplyAction="*")]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsResponse> GetShoppingListItemsAsync(Tema2Form.ServiceReference1.GetShoppingListItemsRequest request);
        
        // CODEGEN: Generating message contract since element name item from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddShoppingListItem", ReplyAction="*")]
        Tema2Form.ServiceReference1.AddShoppingListItemResponse AddShoppingListItem(Tema2Form.ServiceReference1.AddShoppingListItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddShoppingListItem", ReplyAction="*")]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.AddShoppingListItemResponse> AddShoppingListItemAsync(Tema2Form.ServiceReference1.AddShoppingListItemRequest request);
        
        // CODEGEN: Generating message contract since element name item from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateShoppingListItem", ReplyAction="*")]
        Tema2Form.ServiceReference1.UpdateShoppingListItemResponse UpdateShoppingListItem(Tema2Form.ServiceReference1.UpdateShoppingListItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateShoppingListItem", ReplyAction="*")]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.UpdateShoppingListItemResponse> UpdateShoppingListItemAsync(Tema2Form.ServiceReference1.UpdateShoppingListItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteShoppingListItem", ReplyAction="*")]
        void DeleteShoppingListItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteShoppingListItem", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteShoppingListItemAsync(int id);
        
        // CODEGEN: Generating message contract since element name GetShoppingListItemsSortedByPriceResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingListItemsSortedByPrice", ReplyAction="*")]
        Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse GetShoppingListItemsSortedByPrice(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetShoppingListItemsSortedByPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse> GetShoppingListItemsSortedByPriceAsync(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest request);
        
        // CODEGEN: Generating message contract since element name GetTotalValueResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTotalValue", ReplyAction="*")]
        Tema2Form.ServiceReference1.GetTotalValueResponse GetTotalValue(Tema2Form.ServiceReference1.GetTotalValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTotalValue", ReplyAction="*")]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetTotalValueResponse> GetTotalValueAsync(Tema2Form.ServiceReference1.GetTotalValueRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListItemsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingListItems", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetShoppingListItemsRequestBody Body;
        
        public GetShoppingListItemsRequest() {
        }
        
        public GetShoppingListItemsRequest(Tema2Form.ServiceReference1.GetShoppingListItemsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetShoppingListItemsRequestBody {
        
        public GetShoppingListItemsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListItemsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingListItemsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetShoppingListItemsResponseBody Body;
        
        public GetShoppingListItemsResponse() {
        }
        
        public GetShoppingListItemsResponse(Tema2Form.ServiceReference1.GetShoppingListItemsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetShoppingListItemsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItemsResult;
        
        public GetShoppingListItemsResponseBody() {
        }
        
        public GetShoppingListItemsResponseBody(Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItemsResult) {
            this.GetShoppingListItemsResult = GetShoppingListItemsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddShoppingListItemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddShoppingListItem", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.AddShoppingListItemRequestBody Body;
        
        public AddShoppingListItemRequest() {
        }
        
        public AddShoppingListItemRequest(Tema2Form.ServiceReference1.AddShoppingListItemRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddShoppingListItemRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Tema2Form.ServiceReference1.ShoppingListItem item;
        
        public AddShoppingListItemRequestBody() {
        }
        
        public AddShoppingListItemRequestBody(Tema2Form.ServiceReference1.ShoppingListItem item) {
            this.item = item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddShoppingListItemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddShoppingListItemResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.AddShoppingListItemResponseBody Body;
        
        public AddShoppingListItemResponse() {
        }
        
        public AddShoppingListItemResponse(Tema2Form.ServiceReference1.AddShoppingListItemResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddShoppingListItemResponseBody {
        
        public AddShoppingListItemResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateShoppingListItemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateShoppingListItem", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.UpdateShoppingListItemRequestBody Body;
        
        public UpdateShoppingListItemRequest() {
        }
        
        public UpdateShoppingListItemRequest(Tema2Form.ServiceReference1.UpdateShoppingListItemRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateShoppingListItemRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Tema2Form.ServiceReference1.ShoppingListItem item;
        
        public UpdateShoppingListItemRequestBody() {
        }
        
        public UpdateShoppingListItemRequestBody(Tema2Form.ServiceReference1.ShoppingListItem item) {
            this.item = item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateShoppingListItemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateShoppingListItemResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.UpdateShoppingListItemResponseBody Body;
        
        public UpdateShoppingListItemResponse() {
        }
        
        public UpdateShoppingListItemResponse(Tema2Form.ServiceReference1.UpdateShoppingListItemResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateShoppingListItemResponseBody {
        
        public UpdateShoppingListItemResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListItemsSortedByPriceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingListItemsSortedByPrice", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequestBody Body;
        
        public GetShoppingListItemsSortedByPriceRequest() {
        }
        
        public GetShoppingListItemsSortedByPriceRequest(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetShoppingListItemsSortedByPriceRequestBody {
        
        public GetShoppingListItemsSortedByPriceRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShoppingListItemsSortedByPriceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShoppingListItemsSortedByPriceResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponseBody Body;
        
        public GetShoppingListItemsSortedByPriceResponse() {
        }
        
        public GetShoppingListItemsSortedByPriceResponse(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetShoppingListItemsSortedByPriceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItemsSortedByPriceResult;
        
        public GetShoppingListItemsSortedByPriceResponseBody() {
        }
        
        public GetShoppingListItemsSortedByPriceResponseBody(Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItemsSortedByPriceResult) {
            this.GetShoppingListItemsSortedByPriceResult = GetShoppingListItemsSortedByPriceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTotalValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTotalValue", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetTotalValueRequestBody Body;
        
        public GetTotalValueRequest() {
        }
        
        public GetTotalValueRequest(Tema2Form.ServiceReference1.GetTotalValueRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetTotalValueRequestBody {
        
        public GetTotalValueRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTotalValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTotalValueResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tema2Form.ServiceReference1.GetTotalValueResponseBody Body;
        
        public GetTotalValueResponse() {
        }
        
        public GetTotalValueResponse(Tema2Form.ServiceReference1.GetTotalValueResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTotalValueResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTotalValueResult;
        
        public GetTotalValueResponseBody() {
        }
        
        public GetTotalValueResponseBody(string GetTotalValueResult) {
            this.GetTotalValueResult = GetTotalValueResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Tema2Form.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Tema2Form.ServiceReference1.WebService1Soap>, Tema2Form.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema2Form.ServiceReference1.GetShoppingListItemsResponse Tema2Form.ServiceReference1.WebService1Soap.GetShoppingListItems(Tema2Form.ServiceReference1.GetShoppingListItemsRequest request) {
            return base.Channel.GetShoppingListItems(request);
        }
        
        public Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItems() {
            Tema2Form.ServiceReference1.GetShoppingListItemsRequest inValue = new Tema2Form.ServiceReference1.GetShoppingListItemsRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetShoppingListItemsRequestBody();
            Tema2Form.ServiceReference1.GetShoppingListItemsResponse retVal = ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetShoppingListItems(inValue);
            return retVal.Body.GetShoppingListItemsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsResponse> Tema2Form.ServiceReference1.WebService1Soap.GetShoppingListItemsAsync(Tema2Form.ServiceReference1.GetShoppingListItemsRequest request) {
            return base.Channel.GetShoppingListItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsResponse> GetShoppingListItemsAsync() {
            Tema2Form.ServiceReference1.GetShoppingListItemsRequest inValue = new Tema2Form.ServiceReference1.GetShoppingListItemsRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetShoppingListItemsRequestBody();
            return ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetShoppingListItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema2Form.ServiceReference1.AddShoppingListItemResponse Tema2Form.ServiceReference1.WebService1Soap.AddShoppingListItem(Tema2Form.ServiceReference1.AddShoppingListItemRequest request) {
            return base.Channel.AddShoppingListItem(request);
        }
        
        public void AddShoppingListItem(Tema2Form.ServiceReference1.ShoppingListItem item) {
            Tema2Form.ServiceReference1.AddShoppingListItemRequest inValue = new Tema2Form.ServiceReference1.AddShoppingListItemRequest();
            inValue.Body = new Tema2Form.ServiceReference1.AddShoppingListItemRequestBody();
            inValue.Body.item = item;
            Tema2Form.ServiceReference1.AddShoppingListItemResponse retVal = ((Tema2Form.ServiceReference1.WebService1Soap)(this)).AddShoppingListItem(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.AddShoppingListItemResponse> Tema2Form.ServiceReference1.WebService1Soap.AddShoppingListItemAsync(Tema2Form.ServiceReference1.AddShoppingListItemRequest request) {
            return base.Channel.AddShoppingListItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema2Form.ServiceReference1.AddShoppingListItemResponse> AddShoppingListItemAsync(Tema2Form.ServiceReference1.ShoppingListItem item) {
            Tema2Form.ServiceReference1.AddShoppingListItemRequest inValue = new Tema2Form.ServiceReference1.AddShoppingListItemRequest();
            inValue.Body = new Tema2Form.ServiceReference1.AddShoppingListItemRequestBody();
            inValue.Body.item = item;
            return ((Tema2Form.ServiceReference1.WebService1Soap)(this)).AddShoppingListItemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema2Form.ServiceReference1.UpdateShoppingListItemResponse Tema2Form.ServiceReference1.WebService1Soap.UpdateShoppingListItem(Tema2Form.ServiceReference1.UpdateShoppingListItemRequest request) {
            return base.Channel.UpdateShoppingListItem(request);
        }
        
        public void UpdateShoppingListItem(Tema2Form.ServiceReference1.ShoppingListItem item) {
            Tema2Form.ServiceReference1.UpdateShoppingListItemRequest inValue = new Tema2Form.ServiceReference1.UpdateShoppingListItemRequest();
            inValue.Body = new Tema2Form.ServiceReference1.UpdateShoppingListItemRequestBody();
            inValue.Body.item = item;
            Tema2Form.ServiceReference1.UpdateShoppingListItemResponse retVal = ((Tema2Form.ServiceReference1.WebService1Soap)(this)).UpdateShoppingListItem(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.UpdateShoppingListItemResponse> Tema2Form.ServiceReference1.WebService1Soap.UpdateShoppingListItemAsync(Tema2Form.ServiceReference1.UpdateShoppingListItemRequest request) {
            return base.Channel.UpdateShoppingListItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema2Form.ServiceReference1.UpdateShoppingListItemResponse> UpdateShoppingListItemAsync(Tema2Form.ServiceReference1.ShoppingListItem item) {
            Tema2Form.ServiceReference1.UpdateShoppingListItemRequest inValue = new Tema2Form.ServiceReference1.UpdateShoppingListItemRequest();
            inValue.Body = new Tema2Form.ServiceReference1.UpdateShoppingListItemRequestBody();
            inValue.Body.item = item;
            return ((Tema2Form.ServiceReference1.WebService1Soap)(this)).UpdateShoppingListItemAsync(inValue);
        }
        
        public void DeleteShoppingListItem(int id) {
            base.Channel.DeleteShoppingListItem(id);
        }
        
        public System.Threading.Tasks.Task DeleteShoppingListItemAsync(int id) {
            return base.Channel.DeleteShoppingListItemAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse Tema2Form.ServiceReference1.WebService1Soap.GetShoppingListItemsSortedByPrice(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest request) {
            return base.Channel.GetShoppingListItemsSortedByPrice(request);
        }
        
        public Tema2Form.ServiceReference1.ShoppingListItem[] GetShoppingListItemsSortedByPrice() {
            Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest inValue = new Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequestBody();
            Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse retVal = ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetShoppingListItemsSortedByPrice(inValue);
            return retVal.Body.GetShoppingListItemsSortedByPriceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse> Tema2Form.ServiceReference1.WebService1Soap.GetShoppingListItemsSortedByPriceAsync(Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest request) {
            return base.Channel.GetShoppingListItemsSortedByPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceResponse> GetShoppingListItemsSortedByPriceAsync() {
            Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest inValue = new Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetShoppingListItemsSortedByPriceRequestBody();
            return ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetShoppingListItemsSortedByPriceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema2Form.ServiceReference1.GetTotalValueResponse Tema2Form.ServiceReference1.WebService1Soap.GetTotalValue(Tema2Form.ServiceReference1.GetTotalValueRequest request) {
            return base.Channel.GetTotalValue(request);
        }
        
        public string GetTotalValue() {
            Tema2Form.ServiceReference1.GetTotalValueRequest inValue = new Tema2Form.ServiceReference1.GetTotalValueRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetTotalValueRequestBody();
            Tema2Form.ServiceReference1.GetTotalValueResponse retVal = ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetTotalValue(inValue);
            return retVal.Body.GetTotalValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetTotalValueResponse> Tema2Form.ServiceReference1.WebService1Soap.GetTotalValueAsync(Tema2Form.ServiceReference1.GetTotalValueRequest request) {
            return base.Channel.GetTotalValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema2Form.ServiceReference1.GetTotalValueResponse> GetTotalValueAsync() {
            Tema2Form.ServiceReference1.GetTotalValueRequest inValue = new Tema2Form.ServiceReference1.GetTotalValueRequest();
            inValue.Body = new Tema2Form.ServiceReference1.GetTotalValueRequestBody();
            return ((Tema2Form.ServiceReference1.WebService1Soap)(this)).GetTotalValueAsync(inValue);
        }
    }
}
