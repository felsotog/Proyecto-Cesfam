﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaHtml.ServiceMantenedorAgendamiento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorAgendamiento.WebServiceAgendamientoSoap")]
    public interface WebServiceAgendamientoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaAgendamientoService(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaAgendamientoServiceAsync(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarAgendamientoService(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarAgendamientoServiceAsync(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorAgendamiento.Agendamiento retornaPosicionAgendamientoService(int pos, string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> retornaPosicionAgendamientoServiceAsync(int pos, string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorAgendamiento.Agendamiento buscarAgendamientoService(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> buscarAgendamientoServiceAsync(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorAgendamiento.Agendamiento buscarIdAgendamientoService(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> buscarIdAgendamientoServiceAsync(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarAgendamientoService(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarAgendamientoServiceAsync(string id_agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarAgendamientoService(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarAgendamientoServiceAsync(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarTotalAgendamientoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarTotalAgendamientoService();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarTotalAgendamientoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarTotalAgendamientoServiceAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Agendamiento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_agendamientoField;
        
        private System.DateTime horarioField;
        
        private string paciente_rutField;
        
        private string medico_rut_medicoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_agendamiento {
            get {
                return this.id_agendamientoField;
            }
            set {
                this.id_agendamientoField = value;
                this.RaisePropertyChanged("Id_agendamiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Horario {
            get {
                return this.horarioField;
            }
            set {
                this.horarioField = value;
                this.RaisePropertyChanged("Horario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Paciente_rut {
            get {
                return this.paciente_rutField;
            }
            set {
                this.paciente_rutField = value;
                this.RaisePropertyChanged("Paciente_rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Medico_rut_medico {
            get {
                return this.medico_rut_medicoField;
            }
            set {
                this.medico_rut_medicoField = value;
                this.RaisePropertyChanged("Medico_rut_medico");
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
    public interface WebServiceAgendamientoSoapChannel : CapaHtml.ServiceMantenedorAgendamiento.WebServiceAgendamientoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAgendamientoSoapClient : System.ServiceModel.ClientBase<CapaHtml.ServiceMantenedorAgendamiento.WebServiceAgendamientoSoap>, CapaHtml.ServiceMantenedorAgendamiento.WebServiceAgendamientoSoap {
        
        public WebServiceAgendamientoSoapClient() {
        }
        
        public WebServiceAgendamientoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAgendamientoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAgendamientoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAgendamientoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaAgendamientoService(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento) {
            base.Channel.insertaAgendamientoService(agendamiento);
        }
        
        public System.Threading.Tasks.Task insertaAgendamientoServiceAsync(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento) {
            return base.Channel.insertaAgendamientoServiceAsync(agendamiento);
        }
        
        public System.Data.DataSet retornarAgendamientoService(string id_agendamiento) {
            return base.Channel.retornarAgendamientoService(id_agendamiento);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarAgendamientoServiceAsync(string id_agendamiento) {
            return base.Channel.retornarAgendamientoServiceAsync(id_agendamiento);
        }
        
        public CapaHtml.ServiceMantenedorAgendamiento.Agendamiento retornaPosicionAgendamientoService(int pos, string id_agendamiento) {
            return base.Channel.retornaPosicionAgendamientoService(pos, id_agendamiento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> retornaPosicionAgendamientoServiceAsync(int pos, string id_agendamiento) {
            return base.Channel.retornaPosicionAgendamientoServiceAsync(pos, id_agendamiento);
        }
        
        public CapaHtml.ServiceMantenedorAgendamiento.Agendamiento buscarAgendamientoService(string id_agendamiento) {
            return base.Channel.buscarAgendamientoService(id_agendamiento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> buscarAgendamientoServiceAsync(string id_agendamiento) {
            return base.Channel.buscarAgendamientoServiceAsync(id_agendamiento);
        }
        
        public CapaHtml.ServiceMantenedorAgendamiento.Agendamiento buscarIdAgendamientoService(string id_agendamiento) {
            return base.Channel.buscarIdAgendamientoService(id_agendamiento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorAgendamiento.Agendamiento> buscarIdAgendamientoServiceAsync(string id_agendamiento) {
            return base.Channel.buscarIdAgendamientoServiceAsync(id_agendamiento);
        }
        
        public void eliminarAgendamientoService(string id_agendamiento) {
            base.Channel.eliminarAgendamientoService(id_agendamiento);
        }
        
        public System.Threading.Tasks.Task eliminarAgendamientoServiceAsync(string id_agendamiento) {
            return base.Channel.eliminarAgendamientoServiceAsync(id_agendamiento);
        }
        
        public void actualizarAgendamientoService(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento) {
            base.Channel.actualizarAgendamientoService(agendamiento);
        }
        
        public System.Threading.Tasks.Task actualizarAgendamientoServiceAsync(CapaHtml.ServiceMantenedorAgendamiento.Agendamiento agendamiento) {
            return base.Channel.actualizarAgendamientoServiceAsync(agendamiento);
        }
        
        public System.Data.DataSet retornarTotalAgendamientoService() {
            return base.Channel.retornarTotalAgendamientoService();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarTotalAgendamientoServiceAsync() {
            return base.Channel.retornarTotalAgendamientoServiceAsync();
        }
    }
}
