﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMS.Client.Main.SaleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SaleOrder", Namespace="http://schemas.datacontract.org/2004/07/MEMSservice.DAL")]
    [System.SerializableAttribute()]
    public partial class SaleOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string customernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string qtnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MEMS.Client.Main.SaleService.T_saleorder soField;
        
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
        public string customername {
            get {
                return this.customernameField;
            }
            set {
                if ((object.ReferenceEquals(this.customernameField, value) != true)) {
                    this.customernameField = value;
                    this.RaisePropertyChanged("customername");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string qtno {
            get {
                return this.qtnoField;
            }
            set {
                if ((object.ReferenceEquals(this.qtnoField, value) != true)) {
                    this.qtnoField = value;
                    this.RaisePropertyChanged("qtno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MEMS.Client.Main.SaleService.T_saleorder so {
            get {
                return this.soField;
            }
            set {
                if ((object.ReferenceEquals(this.soField, value) != true)) {
                    this.soField = value;
                    this.RaisePropertyChanged("so");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="T_saleorder", Namespace="http://schemas.datacontract.org/2004/07/MEMSservice.DAL")]
    [System.SerializableAttribute()]
    public partial class T_saleorder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int customeridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int orderstateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quotationidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> receiveamountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> receiveperiodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int receiveperiodtypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> receiveratioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int receivestateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int receivetypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string remarksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime saledateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string salenoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> saletotalamountField;
        
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
        public int customerid {
            get {
                return this.customeridField;
            }
            set {
                if ((this.customeridField.Equals(value) != true)) {
                    this.customeridField = value;
                    this.RaisePropertyChanged("customerid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int orderstate {
            get {
                return this.orderstateField;
            }
            set {
                if ((this.orderstateField.Equals(value) != true)) {
                    this.orderstateField = value;
                    this.RaisePropertyChanged("orderstate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quotationid {
            get {
                return this.quotationidField;
            }
            set {
                if ((this.quotationidField.Equals(value) != true)) {
                    this.quotationidField = value;
                    this.RaisePropertyChanged("quotationid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> receiveamount {
            get {
                return this.receiveamountField;
            }
            set {
                if ((this.receiveamountField.Equals(value) != true)) {
                    this.receiveamountField = value;
                    this.RaisePropertyChanged("receiveamount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> receiveperiod {
            get {
                return this.receiveperiodField;
            }
            set {
                if ((this.receiveperiodField.Equals(value) != true)) {
                    this.receiveperiodField = value;
                    this.RaisePropertyChanged("receiveperiod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int receiveperiodtype {
            get {
                return this.receiveperiodtypeField;
            }
            set {
                if ((this.receiveperiodtypeField.Equals(value) != true)) {
                    this.receiveperiodtypeField = value;
                    this.RaisePropertyChanged("receiveperiodtype");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> receiveratio {
            get {
                return this.receiveratioField;
            }
            set {
                if ((this.receiveratioField.Equals(value) != true)) {
                    this.receiveratioField = value;
                    this.RaisePropertyChanged("receiveratio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int receivestate {
            get {
                return this.receivestateField;
            }
            set {
                if ((this.receivestateField.Equals(value) != true)) {
                    this.receivestateField = value;
                    this.RaisePropertyChanged("receivestate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int receivetype {
            get {
                return this.receivetypeField;
            }
            set {
                if ((this.receivetypeField.Equals(value) != true)) {
                    this.receivetypeField = value;
                    this.RaisePropertyChanged("receivetype");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string remarks {
            get {
                return this.remarksField;
            }
            set {
                if ((object.ReferenceEquals(this.remarksField, value) != true)) {
                    this.remarksField = value;
                    this.RaisePropertyChanged("remarks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime saledate {
            get {
                return this.saledateField;
            }
            set {
                if ((this.saledateField.Equals(value) != true)) {
                    this.saledateField = value;
                    this.RaisePropertyChanged("saledate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string saleno {
            get {
                return this.salenoField;
            }
            set {
                if ((object.ReferenceEquals(this.salenoField, value) != true)) {
                    this.salenoField = value;
                    this.RaisePropertyChanged("saleno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> saletotalamount {
            get {
                return this.saletotalamountField;
            }
            set {
                if ((this.saletotalamountField.Equals(value) != true)) {
                    this.saletotalamountField = value;
                    this.RaisePropertyChanged("saletotalamount");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SaleService.ISaleService")]
    public interface ISaleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/getAllSaleOrderList", ReplyAction="http://tempuri.org/ISaleService/getAllSaleOrderListResponse")]
        MEMS.Client.Main.SaleService.SaleOrder[] getAllSaleOrderList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/getSaleOrderbyId", ReplyAction="http://tempuri.org/ISaleService/getSaleOrderbyIdResponse")]
        MEMS.Client.Main.SaleService.T_saleorder getSaleOrderbyId(int saleorderid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/getSaleOrderList", ReplyAction="http://tempuri.org/ISaleService/getSaleOrderListResponse")]
        MEMS.Client.Main.SaleService.SaleOrder[] getSaleOrderList(string soNo, System.DateTime dtstart, System.DateTime dtend);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/AddNewSaleOrder", ReplyAction="http://tempuri.org/ISaleService/AddNewSaleOrderResponse")]
        bool AddNewSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/UpdateSaleOrder", ReplyAction="http://tempuri.org/ISaleService/UpdateSaleOrderResponse")]
        bool UpdateSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaleService/DeleteSaleOrder", ReplyAction="http://tempuri.org/ISaleService/DeleteSaleOrderResponse")]
        bool DeleteSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISaleServiceChannel : MEMS.Client.Main.SaleService.ISaleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaleServiceClient : System.ServiceModel.ClientBase<MEMS.Client.Main.SaleService.ISaleService>, MEMS.Client.Main.SaleService.ISaleService {
        
        public SaleServiceClient() {
        }
        
        public SaleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MEMS.Client.Main.SaleService.SaleOrder[] getAllSaleOrderList() {
            return base.Channel.getAllSaleOrderList();
        }
        
        public MEMS.Client.Main.SaleService.T_saleorder getSaleOrderbyId(int saleorderid) {
            return base.Channel.getSaleOrderbyId(saleorderid);
        }
        
        public MEMS.Client.Main.SaleService.SaleOrder[] getSaleOrderList(string soNo, System.DateTime dtstart, System.DateTime dtend) {
            return base.Channel.getSaleOrderList(soNo, dtstart, dtend);
        }
        
        public bool AddNewSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so) {
            return base.Channel.AddNewSaleOrder(so);
        }
        
        public bool UpdateSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so) {
            return base.Channel.UpdateSaleOrder(so);
        }
        
        public bool DeleteSaleOrder(MEMS.Client.Main.SaleService.T_saleorder so) {
            return base.Channel.DeleteSaleOrder(so);
        }
    }
}
