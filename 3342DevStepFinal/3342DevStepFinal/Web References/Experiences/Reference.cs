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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace _3342DevStepFinal.Experiences {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ActivitiesServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ActivitiesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetActivityAgenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetActivitiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivitiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivities1OperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivities2OperationCompleted;
        
        private System.Threading.SendOrPostCallback TravelLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ActivitiesService() {
            this.Url = global::_3342DevStepFinal.Properties.Settings.Default._3342DevStepFinal_Experiences_ActivitiesService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetActivityAgenciesCompletedEventHandler GetActivityAgenciesCompleted;
        
        /// <remarks/>
        public event GetActivitiesCompletedEventHandler GetActivitiesCompleted;
        
        /// <remarks/>
        public event FindActivitiesCompletedEventHandler FindActivitiesCompleted;
        
        /// <remarks/>
        public event FindActivities1CompletedEventHandler FindActivities1Completed;
        
        /// <remarks/>
        public event FindActivities2CompletedEventHandler FindActivities2Completed;
        
        /// <remarks/>
        public event TravelLoginCompletedEventHandler TravelLoginCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetActivityAgencies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetActivityAgencies(string state, string city) {
            object[] results = this.Invoke("GetActivityAgencies", new object[] {
                        state,
                        city});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetActivityAgenciesAsync(string state, string city) {
            this.GetActivityAgenciesAsync(state, city, null);
        }
        
        /// <remarks/>
        public void GetActivityAgenciesAsync(string state, string city, object userState) {
            if ((this.GetActivityAgenciesOperationCompleted == null)) {
                this.GetActivityAgenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActivityAgenciesOperationCompleted);
            }
            this.InvokeAsync("GetActivityAgencies", new object[] {
                        state,
                        city}, this.GetActivityAgenciesOperationCompleted, userState);
        }
        
        private void OnGetActivityAgenciesOperationCompleted(object arg) {
            if ((this.GetActivityAgenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActivityAgenciesCompleted(this, new GetActivityAgenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetActivities", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetActivities(Agency a, string state, string city) {
            object[] results = this.Invoke("GetActivities", new object[] {
                        a,
                        state,
                        city});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetActivitiesAsync(Agency a, string state, string city) {
            this.GetActivitiesAsync(a, state, city, null);
        }
        
        /// <remarks/>
        public void GetActivitiesAsync(Agency a, string state, string city, object userState) {
            if ((this.GetActivitiesOperationCompleted == null)) {
                this.GetActivitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActivitiesOperationCompleted);
            }
            this.InvokeAsync("GetActivities", new object[] {
                        a,
                        state,
                        city}, this.GetActivitiesOperationCompleted, userState);
        }
        
        private void OnGetActivitiesOperationCompleted(object arg) {
            if ((this.GetActivitiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActivitiesCompleted(this, new GetActivitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivities", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindActivities(Activities a, string state, string city) {
            object[] results = this.Invoke("FindActivities", new object[] {
                        a,
                        state,
                        city});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivitiesAsync(Activities a, string state, string city) {
            this.FindActivitiesAsync(a, state, city, null);
        }
        
        /// <remarks/>
        public void FindActivitiesAsync(Activities a, string state, string city, object userState) {
            if ((this.FindActivitiesOperationCompleted == null)) {
                this.FindActivitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivitiesOperationCompleted);
            }
            this.InvokeAsync("FindActivities", new object[] {
                        a,
                        state,
                        city}, this.FindActivitiesOperationCompleted, userState);
        }
        
        private void OnFindActivitiesOperationCompleted(object arg) {
            if ((this.FindActivitiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivitiesCompleted(this, new FindActivitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute(MessageName="FindActivities1")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivitiesByVenues", RequestElementName="FindActivitiesByVenues", RequestNamespace="http://tempuri.org/", ResponseElementName="FindActivitiesByVenuesResponse", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("FindActivitiesByVenuesResult")]
        public System.Data.DataSet FindActivities(Venue v, Activities a, string state, string city) {
            object[] results = this.Invoke("FindActivities1", new object[] {
                        v,
                        a,
                        state,
                        city});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivities1Async(Venue v, Activities a, string state, string city) {
            this.FindActivities1Async(v, a, state, city, null);
        }
        
        /// <remarks/>
        public void FindActivities1Async(Venue v, Activities a, string state, string city, object userState) {
            if ((this.FindActivities1OperationCompleted == null)) {
                this.FindActivities1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivities1OperationCompleted);
            }
            this.InvokeAsync("FindActivities1", new object[] {
                        v,
                        a,
                        state,
                        city}, this.FindActivities1OperationCompleted, userState);
        }
        
        private void OnFindActivities1OperationCompleted(object arg) {
            if ((this.FindActivities1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivities1Completed(this, new FindActivities1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute(MessageName="FindActivities2")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivitiesByAgency", RequestElementName="FindActivitiesByAgency", RequestNamespace="http://tempuri.org/", ResponseElementName="FindActivitiesByAgencyResponse", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("FindActivitiesByAgencyResult")]
        public System.Data.DataSet FindActivities(Agency name, Activities a, string state, string city) {
            object[] results = this.Invoke("FindActivities2", new object[] {
                        name,
                        a,
                        state,
                        city});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivities2Async(Agency name, Activities a, string state, string city) {
            this.FindActivities2Async(name, a, state, city, null);
        }
        
        /// <remarks/>
        public void FindActivities2Async(Agency name, Activities a, string state, string city, object userState) {
            if ((this.FindActivities2OperationCompleted == null)) {
                this.FindActivities2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivities2OperationCompleted);
            }
            this.InvokeAsync("FindActivities2", new object[] {
                        name,
                        a,
                        state,
                        city}, this.FindActivities2OperationCompleted, userState);
        }
        
        private void OnFindActivities2OperationCompleted(object arg) {
            if ((this.FindActivities2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivities2Completed(this, new FindActivities2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TravelLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool TravelLogin(string TravelID, string TravelPassword) {
            object[] results = this.Invoke("TravelLogin", new object[] {
                        TravelID,
                        TravelPassword});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void TravelLoginAsync(string TravelID, string TravelPassword) {
            this.TravelLoginAsync(TravelID, TravelPassword, null);
        }
        
        /// <remarks/>
        public void TravelLoginAsync(string TravelID, string TravelPassword, object userState) {
            if ((this.TravelLoginOperationCompleted == null)) {
                this.TravelLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTravelLoginOperationCompleted);
            }
            this.InvokeAsync("TravelLogin", new object[] {
                        TravelID,
                        TravelPassword}, this.TravelLoginOperationCompleted, userState);
        }
        
        private void OnTravelLoginOperationCompleted(object arg) {
            if ((this.TravelLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TravelLoginCompleted(this, new TravelLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Reserve", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(Agency ag, Activities a, Customer c, string TravelID, string TravelPassword) {
            object[] results = this.Invoke("Reserve", new object[] {
                        ag,
                        a,
                        c,
                        TravelID,
                        TravelPassword});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveAsync(Agency ag, Activities a, Customer c, string TravelID, string TravelPassword) {
            this.ReserveAsync(ag, a, c, TravelID, TravelPassword, null);
        }
        
        /// <remarks/>
        public void ReserveAsync(Agency ag, Activities a, Customer c, string TravelID, string TravelPassword, object userState) {
            if ((this.ReserveOperationCompleted == null)) {
                this.ReserveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveOperationCompleted);
            }
            this.InvokeAsync("Reserve", new object[] {
                        ag,
                        a,
                        c,
                        TravelID,
                        TravelPassword}, this.ReserveOperationCompleted, userState);
        }
        
        private void OnReserveOperationCompleted(object arg) {
            if ((this.ReserveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveCompleted(this, new ReserveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Agency {
        
        private string agency_cityField;
        
        private string agency_emailField;
        
        private int agency_idField;
        
        private string agency_nameField;
        
        private string agency_phoneField;
        
        private string agency_stateField;
        
        private int agency_zipField;
        
        /// <remarks/>
        public string Agency_city {
            get {
                return this.agency_cityField;
            }
            set {
                this.agency_cityField = value;
            }
        }
        
        /// <remarks/>
        public string Agency_email {
            get {
                return this.agency_emailField;
            }
            set {
                this.agency_emailField = value;
            }
        }
        
        /// <remarks/>
        public int Agency_id {
            get {
                return this.agency_idField;
            }
            set {
                this.agency_idField = value;
            }
        }
        
        /// <remarks/>
        public string Agency_name {
            get {
                return this.agency_nameField;
            }
            set {
                this.agency_nameField = value;
            }
        }
        
        /// <remarks/>
        public string Agency_phone {
            get {
                return this.agency_phoneField;
            }
            set {
                this.agency_phoneField = value;
            }
        }
        
        /// <remarks/>
        public string Agency_state {
            get {
                return this.agency_stateField;
            }
            set {
                this.agency_stateField = value;
            }
        }
        
        /// <remarks/>
        public int Agency_zip {
            get {
                return this.agency_zipField;
            }
            set {
                this.agency_zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Customer {
        
        private string addressField;
        
        private string emailField;
        
        private string nameField;
        
        private string phoneField;
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Venue {
        
        private string venue_cityField;
        
        private int venue_idField;
        
        private string venue_nameField;
        
        private string venue_stateField;
        
        /// <remarks/>
        public string Venue_city {
            get {
                return this.venue_cityField;
            }
            set {
                this.venue_cityField = value;
            }
        }
        
        /// <remarks/>
        public int Venue_id {
            get {
                return this.venue_idField;
            }
            set {
                this.venue_idField = value;
            }
        }
        
        /// <remarks/>
        public string Venue_name {
            get {
                return this.venue_nameField;
            }
            set {
                this.venue_nameField = value;
            }
        }
        
        /// <remarks/>
        public string Venue_state {
            get {
                return this.venue_stateField;
            }
            set {
                this.venue_stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Activities {
        
        private int activity_idField;
        
        private int activity_avaliabilityField;
        
        private int activity_no_of_bookingField;
        
        private decimal activity_costField;
        
        private string activity_typeField;
        
        private string activity_statusField;
        
        private string activity_startDateField;
        
        private string activity_enddateField;
        
        private string activity_infoField;
        
        private string activity_locationField;
        
        private string activity_cityField;
        
        private string activity_stateField;
        
        /// <remarks/>
        public int Activity_id {
            get {
                return this.activity_idField;
            }
            set {
                this.activity_idField = value;
            }
        }
        
        /// <remarks/>
        public int Activity_avaliability {
            get {
                return this.activity_avaliabilityField;
            }
            set {
                this.activity_avaliabilityField = value;
            }
        }
        
        /// <remarks/>
        public int Activity_no_of_booking {
            get {
                return this.activity_no_of_bookingField;
            }
            set {
                this.activity_no_of_bookingField = value;
            }
        }
        
        /// <remarks/>
        public decimal Activity_cost {
            get {
                return this.activity_costField;
            }
            set {
                this.activity_costField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_type {
            get {
                return this.activity_typeField;
            }
            set {
                this.activity_typeField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_status {
            get {
                return this.activity_statusField;
            }
            set {
                this.activity_statusField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_startDate {
            get {
                return this.activity_startDateField;
            }
            set {
                this.activity_startDateField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_enddate {
            get {
                return this.activity_enddateField;
            }
            set {
                this.activity_enddateField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_info {
            get {
                return this.activity_infoField;
            }
            set {
                this.activity_infoField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_location {
            get {
                return this.activity_locationField;
            }
            set {
                this.activity_locationField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_city {
            get {
                return this.activity_cityField;
            }
            set {
                this.activity_cityField = value;
            }
        }
        
        /// <remarks/>
        public string Activity_state {
            get {
                return this.activity_stateField;
            }
            set {
                this.activity_stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetActivityAgenciesCompletedEventHandler(object sender, GetActivityAgenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActivityAgenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActivityAgenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetActivitiesCompletedEventHandler(object sender, GetActivitiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActivitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActivitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void FindActivitiesCompletedEventHandler(object sender, FindActivitiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void FindActivities1CompletedEventHandler(object sender, FindActivities1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivities1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivities1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void FindActivities2CompletedEventHandler(object sender, FindActivities2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivities2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivities2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void TravelLoginCompletedEventHandler(object sender, TravelLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TravelLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TravelLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void ReserveCompletedEventHandler(object sender, ReserveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591