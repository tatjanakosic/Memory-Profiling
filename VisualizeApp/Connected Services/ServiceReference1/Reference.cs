﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisualizeApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Load", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Load : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ForecastValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MeasuredValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
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
        public double ForecastValue {
            get {
                return this.ForecastValueField;
            }
            set {
                if ((this.ForecastValueField.Equals(value) != true)) {
                    this.ForecastValueField = value;
                    this.RaisePropertyChanged("ForecastValue");
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
        public double MeasuredValue {
            get {
                return this.MeasuredValueField;
            }
            set {
                if ((this.MeasuredValueField.Equals(value) != true)) {
                    this.MeasuredValueField = value;
                    this.RaisePropertyChanged("MeasuredValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InternalCommunicationException", Namespace="http://schemas.datacontract.org/2004/07/Common.Exceptions")]
    [System.SerializableAttribute()]
    public partial class InternalCommunicationException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Audit", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Audit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private VisualizeApp.ServiceReference1.AuditType TypeField;
        
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
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public VisualizeApp.ServiceReference1.AuditType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditType", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    public enum AuditType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MethodProfile", Namespace="http://schemas.datacontract.org/2004/07/Common.MethodProfiler")]
    [System.SerializableAttribute()]
    public partial class MethodProfile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CallCountk__BackingFieldField;
        
        private long MemoryUsagek__BackingFieldField;
        
        private string MethodNamek__BackingFieldField;
        
        private long TotalExecutionTimek__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CallCount>k__BackingField", IsRequired=true)]
        public int CallCountk__BackingField {
            get {
                return this.CallCountk__BackingFieldField;
            }
            set {
                if ((this.CallCountk__BackingFieldField.Equals(value) != true)) {
                    this.CallCountk__BackingFieldField = value;
                    this.RaisePropertyChanged("CallCountk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MemoryUsage>k__BackingField", IsRequired=true)]
        public long MemoryUsagek__BackingField {
            get {
                return this.MemoryUsagek__BackingFieldField;
            }
            set {
                if ((this.MemoryUsagek__BackingFieldField.Equals(value) != true)) {
                    this.MemoryUsagek__BackingFieldField = value;
                    this.RaisePropertyChanged("MemoryUsagek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MethodName>k__BackingField", IsRequired=true)]
        public string MethodNamek__BackingField {
            get {
                return this.MethodNamek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodNamek__BackingFieldField, value) != true)) {
                    this.MethodNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("MethodNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<TotalExecutionTime>k__BackingField", IsRequired=true)]
        public long TotalExecutionTimek__BackingField {
            get {
                return this.TotalExecutionTimek__BackingFieldField;
            }
            set {
                if ((this.TotalExecutionTimek__BackingFieldField.Equals(value) != true)) {
                    this.TotalExecutionTimek__BackingFieldField = value;
                    this.RaisePropertyChanged("TotalExecutionTimek__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceController")]
    public interface IServiceController {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PostRequest", ReplyAction="http://tempuri.org/IServiceController/PostRequestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VisualizeApp.ServiceReference1.InternalCommunicationException), Action="http://tempuri.org/IServiceController/PostRequestInternalCommunicationExceptionFa" +
            "ult", Name="InternalCommunicationException", Namespace="http://schemas.datacontract.org/2004/07/Common.Exceptions")]
        VisualizeApp.ServiceReference1.Load[] PostRequest(System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PostRequest", ReplyAction="http://tempuri.org/IServiceController/PostRequestResponse")]
        System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Load[]> PostRequestAsync(System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PrintLoad", ReplyAction="http://tempuri.org/IServiceController/PrintLoadResponse")]
        VisualizeApp.ServiceReference1.Load[] PrintLoad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PrintLoad", ReplyAction="http://tempuri.org/IServiceController/PrintLoadResponse")]
        System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Load[]> PrintLoadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PrintAudit", ReplyAction="http://tempuri.org/IServiceController/PrintAuditResponse")]
        VisualizeApp.ServiceReference1.Audit[] PrintAudit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/PrintAudit", ReplyAction="http://tempuri.org/IServiceController/PrintAuditResponse")]
        System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Audit[]> PrintAuditAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/AddLoad", ReplyAction="http://tempuri.org/IServiceController/AddLoadResponse")]
        bool AddLoad(int id, System.DateTime time, double forecast, double measured);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/AddLoad", ReplyAction="http://tempuri.org/IServiceController/AddLoadResponse")]
        System.Threading.Tasks.Task<bool> AddLoadAsync(int id, System.DateTime time, double forecast, double measured);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/RemoveAudit", ReplyAction="http://tempuri.org/IServiceController/RemoveAuditResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.MethodProfile[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.MethodProfile))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.InternalCommunicationException))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<int, int>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Load[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Load))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Audit[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Audit))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.AuditType))]
        bool RemoveAudit(System.DateTime time, object temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/RemoveAudit", ReplyAction="http://tempuri.org/IServiceController/RemoveAuditResponse")]
        System.Threading.Tasks.Task<bool> RemoveAuditAsync(System.DateTime time, object temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/RemoveAllDataFromInMemory", ReplyAction="http://tempuri.org/IServiceController/RemoveAllDataFromInMemoryResponse")]
        bool RemoveAllDataFromInMemory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/RemoveAllDataFromInMemory", ReplyAction="http://tempuri.org/IServiceController/RemoveAllDataFromInMemoryResponse")]
        System.Threading.Tasks.Task<bool> RemoveAllDataFromInMemoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/AddLoadMany", ReplyAction="http://tempuri.org/IServiceController/AddLoadManyResponse")]
        VisualizeApp.ServiceReference1.AddLoadManyResponse AddLoadMany(VisualizeApp.ServiceReference1.AddLoadManyRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/AddLoadMany", ReplyAction="http://tempuri.org/IServiceController/AddLoadManyResponse")]
        System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.AddLoadManyResponse> AddLoadManyAsync(VisualizeApp.ServiceReference1.AddLoadManyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/TrackObject", ReplyAction="http://tempuri.org/IServiceController/TrackObjectResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.MethodProfile[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.MethodProfile))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.InternalCommunicationException))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<int, int>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Load[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Load))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Audit[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.Audit))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(VisualizeApp.ServiceReference1.AuditType))]
        void TrackObject(object obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/TrackObject", ReplyAction="http://tempuri.org/IServiceController/TrackObjectResponse")]
        System.Threading.Tasks.Task TrackObjectAsync(object obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetLoadObjectCount", ReplyAction="http://tempuri.org/IServiceController/GetLoadObjectCountResponse")]
        long GetLoadObjectCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetLoadObjectCount", ReplyAction="http://tempuri.org/IServiceController/GetLoadObjectCountResponse")]
        System.Threading.Tasks.Task<long> GetLoadObjectCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetLoadObjectGenerations", ReplyAction="http://tempuri.org/IServiceController/GetLoadObjectGenerationsResponse")]
        System.Collections.Generic.Dictionary<int, int> GetLoadObjectGenerations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetLoadObjectGenerations", ReplyAction="http://tempuri.org/IServiceController/GetLoadObjectGenerationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, int>> GetLoadObjectGenerationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetMemoryUsage", ReplyAction="http://tempuri.org/IServiceController/GetMemoryUsageResponse")]
        long GetMemoryUsage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/GetMemoryUsage", ReplyAction="http://tempuri.org/IServiceController/GetMemoryUsageResponse")]
        System.Threading.Tasks.Task<long> GetMemoryUsageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/ExportDataToCsv", ReplyAction="http://tempuri.org/IServiceController/ExportDataToCsvResponse")]
        void ExportDataToCsv(long totalMemory, long instanceCount, System.Collections.Generic.Dictionary<int, int> generations, bool includeHeader);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceController/ExportDataToCsv", ReplyAction="http://tempuri.org/IServiceController/ExportDataToCsvResponse")]
        System.Threading.Tasks.Task ExportDataToCsvAsync(long totalMemory, long instanceCount, System.Collections.Generic.Dictionary<int, int> generations, bool includeHeader);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddLoadMany", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddLoadManyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.DateTime time;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double forecast;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public double measured;
        
        public AddLoadManyRequest() {
        }
        
        public AddLoadManyRequest(System.DateTime time, double forecast, double measured) {
            this.time = time;
            this.forecast = forecast;
            this.measured = measured;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddLoadManyResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddLoadManyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public VisualizeApp.ServiceReference1.Load AddLoadManyResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public VisualizeApp.ServiceReference1.MethodProfile[] profilerData;
        
        public AddLoadManyResponse() {
        }
        
        public AddLoadManyResponse(VisualizeApp.ServiceReference1.Load AddLoadManyResult, VisualizeApp.ServiceReference1.MethodProfile[] profilerData) {
            this.AddLoadManyResult = AddLoadManyResult;
            this.profilerData = profilerData;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceControllerChannel : VisualizeApp.ServiceReference1.IServiceController, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceControllerClient : System.ServiceModel.ClientBase<VisualizeApp.ServiceReference1.IServiceController>, VisualizeApp.ServiceReference1.IServiceController {
        
        public ServiceControllerClient() {
        }
        
        public ServiceControllerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceControllerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceControllerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceControllerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VisualizeApp.ServiceReference1.Load[] PostRequest(System.DateTime time) {
            return base.Channel.PostRequest(time);
        }
        
        public System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Load[]> PostRequestAsync(System.DateTime time) {
            return base.Channel.PostRequestAsync(time);
        }
        
        public VisualizeApp.ServiceReference1.Load[] PrintLoad() {
            return base.Channel.PrintLoad();
        }
        
        public System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Load[]> PrintLoadAsync() {
            return base.Channel.PrintLoadAsync();
        }
        
        public VisualizeApp.ServiceReference1.Audit[] PrintAudit() {
            return base.Channel.PrintAudit();
        }
        
        public System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.Audit[]> PrintAuditAsync() {
            return base.Channel.PrintAuditAsync();
        }
        
        public bool AddLoad(int id, System.DateTime time, double forecast, double measured) {
            return base.Channel.AddLoad(id, time, forecast, measured);
        }
        
        public System.Threading.Tasks.Task<bool> AddLoadAsync(int id, System.DateTime time, double forecast, double measured) {
            return base.Channel.AddLoadAsync(id, time, forecast, measured);
        }
        
        public bool RemoveAudit(System.DateTime time, object temp) {
            return base.Channel.RemoveAudit(time, temp);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveAuditAsync(System.DateTime time, object temp) {
            return base.Channel.RemoveAuditAsync(time, temp);
        }
        
        public bool RemoveAllDataFromInMemory() {
            return base.Channel.RemoveAllDataFromInMemory();
        }
        
        public System.Threading.Tasks.Task<bool> RemoveAllDataFromInMemoryAsync() {
            return base.Channel.RemoveAllDataFromInMemoryAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VisualizeApp.ServiceReference1.AddLoadManyResponse VisualizeApp.ServiceReference1.IServiceController.AddLoadMany(VisualizeApp.ServiceReference1.AddLoadManyRequest request) {
            return base.Channel.AddLoadMany(request);
        }
        
        public VisualizeApp.ServiceReference1.Load AddLoadMany(System.DateTime time, double forecast, double measured, out VisualizeApp.ServiceReference1.MethodProfile[] profilerData) {
            VisualizeApp.ServiceReference1.AddLoadManyRequest inValue = new VisualizeApp.ServiceReference1.AddLoadManyRequest();
            inValue.time = time;
            inValue.forecast = forecast;
            inValue.measured = measured;
            VisualizeApp.ServiceReference1.AddLoadManyResponse retVal = ((VisualizeApp.ServiceReference1.IServiceController)(this)).AddLoadMany(inValue);
            profilerData = retVal.profilerData;
            return retVal.AddLoadManyResult;
        }
        
        public System.Threading.Tasks.Task<VisualizeApp.ServiceReference1.AddLoadManyResponse> AddLoadManyAsync(VisualizeApp.ServiceReference1.AddLoadManyRequest request) {
            return base.Channel.AddLoadManyAsync(request);
        }
        
        public void TrackObject(object obj) {
            base.Channel.TrackObject(obj);
        }
        
        public System.Threading.Tasks.Task TrackObjectAsync(object obj) {
            return base.Channel.TrackObjectAsync(obj);
        }
        
        public long GetLoadObjectCount() {
            return base.Channel.GetLoadObjectCount();
        }
        
        public System.Threading.Tasks.Task<long> GetLoadObjectCountAsync() {
            return base.Channel.GetLoadObjectCountAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, int> GetLoadObjectGenerations() {
            return base.Channel.GetLoadObjectGenerations();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, int>> GetLoadObjectGenerationsAsync() {
            return base.Channel.GetLoadObjectGenerationsAsync();
        }
        
        public long GetMemoryUsage() {
            return base.Channel.GetMemoryUsage();
        }
        
        public System.Threading.Tasks.Task<long> GetMemoryUsageAsync() {
            return base.Channel.GetMemoryUsageAsync();
        }
        
        public void ExportDataToCsv(long totalMemory, long instanceCount, System.Collections.Generic.Dictionary<int, int> generations, bool includeHeader) {
            base.Channel.ExportDataToCsv(totalMemory, instanceCount, generations, includeHeader);
        }
        
        public System.Threading.Tasks.Task ExportDataToCsvAsync(long totalMemory, long instanceCount, System.Collections.Generic.Dictionary<int, int> generations, bool includeHeader) {
            return base.Channel.ExportDataToCsvAsync(totalMemory, instanceCount, generations, includeHeader);
        }
    }
}
