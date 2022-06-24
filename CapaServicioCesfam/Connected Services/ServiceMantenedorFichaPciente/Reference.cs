﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceMantenedorFichaPciente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorFichaPciente.WebServiceFichaPacienteSoap")]
    public interface WebServiceFichaPacienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaFichaPacienteService(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaFichaPacienteServiceAsync(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarFichaPacienteService(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarFichaPacienteServiceAsync(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente retornaPosicionFichaPacienteService(int pos, string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> retornaPosicionFichaPacienteServiceAsync(int pos, string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente buscarFichaPacienteService(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> buscarFichaPacienteServiceAsync(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente buscarIdFichaPacienteService(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> buscarIdFichaPacienteServiceAsync(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarFichaPacienteService(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarFichaPacienteServiceAsync(string id_ficha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarFichaPacienteService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarFichaPacienteService(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarFichaPacienteService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarFichaPacienteServiceAsync(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class FichaPaciente : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_fichaField;
        
        private string descripcionField;
        
        private System.DateTime fecha_fichaField;
        
        private string medico_rut_medicoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_ficha {
            get {
                return this.id_fichaField;
            }
            set {
                this.id_fichaField = value;
                this.RaisePropertyChanged("Id_ficha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime Fecha_ficha {
            get {
                return this.fecha_fichaField;
            }
            set {
                this.fecha_fichaField = value;
                this.RaisePropertyChanged("Fecha_ficha");
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
    public interface WebServiceFichaPacienteSoapChannel : CapaServicioCesfam.ServiceMantenedorFichaPciente.WebServiceFichaPacienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFichaPacienteSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceMantenedorFichaPciente.WebServiceFichaPacienteSoap>, CapaServicioCesfam.ServiceMantenedorFichaPciente.WebServiceFichaPacienteSoap {
        
        public WebServiceFichaPacienteSoapClient() {
        }
        
        public WebServiceFichaPacienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFichaPacienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFichaPacienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFichaPacienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaFichaPacienteService(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente) {
            base.Channel.insertaFichaPacienteService(ficha_paciente);
        }
        
        public System.Threading.Tasks.Task insertaFichaPacienteServiceAsync(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente) {
            return base.Channel.insertaFichaPacienteServiceAsync(ficha_paciente);
        }
        
        public System.Data.DataSet retornarFichaPacienteService(string id_ficha) {
            return base.Channel.retornarFichaPacienteService(id_ficha);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarFichaPacienteServiceAsync(string id_ficha) {
            return base.Channel.retornarFichaPacienteServiceAsync(id_ficha);
        }
        
        public CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente retornaPosicionFichaPacienteService(int pos, string id_ficha) {
            return base.Channel.retornaPosicionFichaPacienteService(pos, id_ficha);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> retornaPosicionFichaPacienteServiceAsync(int pos, string id_ficha) {
            return base.Channel.retornaPosicionFichaPacienteServiceAsync(pos, id_ficha);
        }
        
        public CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente buscarFichaPacienteService(string id_ficha) {
            return base.Channel.buscarFichaPacienteService(id_ficha);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> buscarFichaPacienteServiceAsync(string id_ficha) {
            return base.Channel.buscarFichaPacienteServiceAsync(id_ficha);
        }
        
        public CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente buscarIdFichaPacienteService(string id_ficha) {
            return base.Channel.buscarIdFichaPacienteService(id_ficha);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente> buscarIdFichaPacienteServiceAsync(string id_ficha) {
            return base.Channel.buscarIdFichaPacienteServiceAsync(id_ficha);
        }
        
        public void eliminarFichaPacienteService(string id_ficha) {
            base.Channel.eliminarFichaPacienteService(id_ficha);
        }
        
        public System.Threading.Tasks.Task eliminarFichaPacienteServiceAsync(string id_ficha) {
            return base.Channel.eliminarFichaPacienteServiceAsync(id_ficha);
        }
        
        public void actualizarFichaPacienteService(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente) {
            base.Channel.actualizarFichaPacienteService(ficha_paciente);
        }
        
        public System.Threading.Tasks.Task actualizarFichaPacienteServiceAsync(CapaServicioCesfam.ServiceMantenedorFichaPciente.FichaPaciente ficha_paciente) {
            return base.Channel.actualizarFichaPacienteServiceAsync(ficha_paciente);
        }
    }
}
