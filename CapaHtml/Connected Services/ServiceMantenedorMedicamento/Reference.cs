﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaHtml.ServiceMantenedorMedicamento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorMedicamento.WebServiceMedicamentoSoap")]
    public interface WebServiceMedicamentoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaMedicamentoService(CapaHtml.ServiceMantenedorMedicamento.Medicamento auxMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorMedicamento.Medicamento auxMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarMedicamentoService(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarMedicamentoServiceAsync(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorMedicamento.Medicamento retornaPosicionMedicamentoService(int pos, string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> retornaPosicionMedicamentoServiceAsync(int pos, string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorMedicamento.Medicamento buscarMedicamentoService(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> buscarMedicamentoServiceAsync(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorMedicamento.Medicamento buscarIdMedicamentoService(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> buscarIdMedicamentoServiceAsync(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarMedicamentoService(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarMedicamentoServiceAsync(string id_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarMedicamentoService(CapaHtml.ServiceMantenedorMedicamento.Medicamento medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarMedicamentoServiceAsync(CapaHtml.ServiceMantenedorMedicamento.Medicamento medicamento);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Medicamento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private string nombre_medicamentoField;
        
        private string tipo_medicamentoField;
        
        private System.DateTime fecha_fabricacionField;
        
        private System.DateTime fecha_vencimientoField;
        
        private string descripcionField;
        
        private int cantidadField;
        
        private string farmacia_id_farmaciaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("Codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre_medicamento {
            get {
                return this.nombre_medicamentoField;
            }
            set {
                this.nombre_medicamentoField = value;
                this.RaisePropertyChanged("Nombre_medicamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Tipo_medicamento {
            get {
                return this.tipo_medicamentoField;
            }
            set {
                this.tipo_medicamentoField = value;
                this.RaisePropertyChanged("Tipo_medicamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime Fecha_fabricacion {
            get {
                return this.fecha_fabricacionField;
            }
            set {
                this.fecha_fabricacionField = value;
                this.RaisePropertyChanged("Fecha_fabricacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Fecha_vencimiento {
            get {
                return this.fecha_vencimientoField;
            }
            set {
                this.fecha_vencimientoField = value;
                this.RaisePropertyChanged("Fecha_vencimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("Cantidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Farmacia_id_farmacia {
            get {
                return this.farmacia_id_farmaciaField;
            }
            set {
                this.farmacia_id_farmaciaField = value;
                this.RaisePropertyChanged("Farmacia_id_farmacia");
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
    public interface WebServiceMedicamentoSoapChannel : CapaHtml.ServiceMantenedorMedicamento.WebServiceMedicamentoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceMedicamentoSoapClient : System.ServiceModel.ClientBase<CapaHtml.ServiceMantenedorMedicamento.WebServiceMedicamentoSoap>, CapaHtml.ServiceMantenedorMedicamento.WebServiceMedicamentoSoap {
        
        public WebServiceMedicamentoSoapClient() {
        }
        
        public WebServiceMedicamentoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceMedicamentoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMedicamentoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMedicamentoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaMedicamentoService(CapaHtml.ServiceMantenedorMedicamento.Medicamento auxMedicamento) {
            base.Channel.insertaMedicamentoService(auxMedicamento);
        }
        
        public System.Threading.Tasks.Task insertaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorMedicamento.Medicamento auxMedicamento) {
            return base.Channel.insertaMedicamentoServiceAsync(auxMedicamento);
        }
        
        public System.Data.DataSet retornarMedicamentoService(string id_medicamento) {
            return base.Channel.retornarMedicamentoService(id_medicamento);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarMedicamentoServiceAsync(string id_medicamento) {
            return base.Channel.retornarMedicamentoServiceAsync(id_medicamento);
        }
        
        public CapaHtml.ServiceMantenedorMedicamento.Medicamento retornaPosicionMedicamentoService(int pos, string id_medicamento) {
            return base.Channel.retornaPosicionMedicamentoService(pos, id_medicamento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> retornaPosicionMedicamentoServiceAsync(int pos, string id_medicamento) {
            return base.Channel.retornaPosicionMedicamentoServiceAsync(pos, id_medicamento);
        }
        
        public CapaHtml.ServiceMantenedorMedicamento.Medicamento buscarMedicamentoService(string id_medicamento) {
            return base.Channel.buscarMedicamentoService(id_medicamento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> buscarMedicamentoServiceAsync(string id_medicamento) {
            return base.Channel.buscarMedicamentoServiceAsync(id_medicamento);
        }
        
        public CapaHtml.ServiceMantenedorMedicamento.Medicamento buscarIdMedicamentoService(string id_medicamento) {
            return base.Channel.buscarIdMedicamentoService(id_medicamento);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorMedicamento.Medicamento> buscarIdMedicamentoServiceAsync(string id_medicamento) {
            return base.Channel.buscarIdMedicamentoServiceAsync(id_medicamento);
        }
        
        public void eliminarMedicamentoService(string id_medicamento) {
            base.Channel.eliminarMedicamentoService(id_medicamento);
        }
        
        public System.Threading.Tasks.Task eliminarMedicamentoServiceAsync(string id_medicamento) {
            return base.Channel.eliminarMedicamentoServiceAsync(id_medicamento);
        }
        
        public void actualizarMedicamentoService(CapaHtml.ServiceMantenedorMedicamento.Medicamento medicamento) {
            base.Channel.actualizarMedicamentoService(medicamento);
        }
        
        public System.Threading.Tasks.Task actualizarMedicamentoServiceAsync(CapaHtml.ServiceMantenedorMedicamento.Medicamento medicamento) {
            return base.Channel.actualizarMedicamentoServiceAsync(medicamento);
        }
    }
}
