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

namespace ConsoleForTestingServices.ServiceAuthorization {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IAuthorizationService", Namespace="http://tempuri.org/")]
    public partial class AuthorizationService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VerifyPasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterOperationCompleted;
        
        private System.Threading.SendOrPostCallback RemoveUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AuthorizationService() {
            this.Url = global::ConsoleForTestingServices.Properties.Settings.Default.ConsoleForTestingServices_ServiceAuthorization_AuthorizationService;
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
        public event VerifyPasswordCompletedEventHandler VerifyPasswordCompleted;
        
        /// <remarks/>
        public event VerifyEmailCompletedEventHandler VerifyEmailCompleted;
        
        /// <remarks/>
        public event RegisterCompletedEventHandler RegisterCompleted;
        
        /// <remarks/>
        public event RemoveUserCompletedEventHandler RemoveUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizationService/VerifyPassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public TupleOfstringboolean VerifyPassword([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password) {
            object[] results = this.Invoke("VerifyPassword", new object[] {
                        email,
                        password});
            return ((TupleOfstringboolean)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyPasswordAsync(string email, string password) {
            this.VerifyPasswordAsync(email, password, null);
        }
        
        /// <remarks/>
        public void VerifyPasswordAsync(string email, string password, object userState) {
            if ((this.VerifyPasswordOperationCompleted == null)) {
                this.VerifyPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyPasswordOperationCompleted);
            }
            this.InvokeAsync("VerifyPassword", new object[] {
                        email,
                        password}, this.VerifyPasswordOperationCompleted, userState);
        }
        
        private void OnVerifyPasswordOperationCompleted(object arg) {
            if ((this.VerifyPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyPasswordCompleted(this, new VerifyPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizationService/VerifyEmail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public TupleOfstringboolean VerifyEmail([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email) {
            object[] results = this.Invoke("VerifyEmail", new object[] {
                        email});
            return ((TupleOfstringboolean)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyEmailAsync(string email) {
            this.VerifyEmailAsync(email, null);
        }
        
        /// <remarks/>
        public void VerifyEmailAsync(string email, object userState) {
            if ((this.VerifyEmailOperationCompleted == null)) {
                this.VerifyEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyEmailOperationCompleted);
            }
            this.InvokeAsync("VerifyEmail", new object[] {
                        email}, this.VerifyEmailOperationCompleted, userState);
        }
        
        private void OnVerifyEmailOperationCompleted(object arg) {
            if ((this.VerifyEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyEmailCompleted(this, new VerifyEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizationService/Register", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public TupleOfstringboolean Register([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, bool news, [System.Xml.Serialization.XmlIgnoreAttribute()] bool newsSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string appLanguage, bool useLiveTile, [System.Xml.Serialization.XmlIgnoreAttribute()] bool useLiveTileSpecified, [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)] [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")] string[] contentLanguages) {
            object[] results = this.Invoke("Register", new object[] {
                        email,
                        password,
                        news,
                        newsSpecified,
                        appLanguage,
                        useLiveTile,
                        useLiveTileSpecified,
                        contentLanguages});
            return ((TupleOfstringboolean)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterAsync(string email, string password, bool news, bool newsSpecified, string appLanguage, bool useLiveTile, bool useLiveTileSpecified, string[] contentLanguages) {
            this.RegisterAsync(email, password, news, newsSpecified, appLanguage, useLiveTile, useLiveTileSpecified, contentLanguages, null);
        }
        
        /// <remarks/>
        public void RegisterAsync(string email, string password, bool news, bool newsSpecified, string appLanguage, bool useLiveTile, bool useLiveTileSpecified, string[] contentLanguages, object userState) {
            if ((this.RegisterOperationCompleted == null)) {
                this.RegisterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterOperationCompleted);
            }
            this.InvokeAsync("Register", new object[] {
                        email,
                        password,
                        news,
                        newsSpecified,
                        appLanguage,
                        useLiveTile,
                        useLiveTileSpecified,
                        contentLanguages}, this.RegisterOperationCompleted, userState);
        }
        
        private void OnRegisterOperationCompleted(object arg) {
            if ((this.RegisterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterCompleted(this, new RegisterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizationService/RemoveUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public TupleOfstringboolean RemoveUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email) {
            object[] results = this.Invoke("RemoveUser", new object[] {
                        email});
            return ((TupleOfstringboolean)(results[0]));
        }
        
        /// <remarks/>
        public void RemoveUserAsync(string email) {
            this.RemoveUserAsync(email, null);
        }
        
        /// <remarks/>
        public void RemoveUserAsync(string email, object userState) {
            if ((this.RemoveUserOperationCompleted == null)) {
                this.RemoveUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveUserOperationCompleted);
            }
            this.InvokeAsync("RemoveUser", new object[] {
                        email}, this.RemoveUserOperationCompleted, userState);
        }
        
        private void OnRemoveUserOperationCompleted(object arg) {
            if ((this.RemoveUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveUserCompleted(this, new RemoveUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System")]
    public partial class TupleOfstringboolean {
        
        private string m_Item1Field;
        
        private bool m_Item2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string m_Item1 {
            get {
                return this.m_Item1Field;
            }
            set {
                this.m_Item1Field = value;
            }
        }
        
        /// <remarks/>
        public bool m_Item2 {
            get {
                return this.m_Item2Field;
            }
            set {
                this.m_Item2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void VerifyPasswordCompletedEventHandler(object sender, VerifyPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TupleOfstringboolean Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TupleOfstringboolean)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void VerifyEmailCompletedEventHandler(object sender, VerifyEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TupleOfstringboolean Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TupleOfstringboolean)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void RegisterCompletedEventHandler(object sender, RegisterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TupleOfstringboolean Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TupleOfstringboolean)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void RemoveUserCompletedEventHandler(object sender, RemoveUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RemoveUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RemoveUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TupleOfstringboolean Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TupleOfstringboolean)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591