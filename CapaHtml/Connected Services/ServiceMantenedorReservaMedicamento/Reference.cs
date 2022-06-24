﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaHtml.ServiceMantenedorReservaMedicamento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoap")]
    public interface WebServiceReservaMedicamentoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaReservaMedicamentoService(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento auxReservaMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaReservaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento auxReservaMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarReservaMedicamentoService(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarReservaMedicamentoServiceAsync(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento retornaPosicionReservaMedicamentoService(int pos, string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> retornaPosicionReservaMedicamentoServiceAsync(int pos, string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento buscarReservaMedicamentoService(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> buscarReservaMedicamentoServiceAsync(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento buscarIdReservaMedicamentoService(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> buscarIdReservaMedicamentoServiceAsync(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarReservaMedicamentoService(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarReservaMedicamentoServiceAsync(string id_reserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarReservaMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarReservaMedicamentoService(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento reserva_medicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarReservaMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarReservaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento reserva_medicamento);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ReservaMedicamento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_reservaField;
        
        private System.DateTime fecha_reservaField;
        
        private int cantidad_reservaField;
        
        private string farmaceutico_id_farmaceutaField;
        
        private string medicamento_codigoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_reserva {
            get {
                return this.id_reservaField;
            }
            set {
                this.id_reservaField = value;
                this.RaisePropertyChanged("Id_reserva");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha_reserva {
            get {
                return this.fecha_reservaField;
            }
            set {
                this.fecha_reservaField = value;
                this.RaisePropertyChanged("Fecha_reserva");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Cantidad_reserva {
            get {
                return this.cantidad_reservaField;
            }
            set {
                this.cantidad_reservaField = value;
                this.RaisePropertyChanged("Cantidad_reserva");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Farmaceutico_id_farmaceuta {
            get {
                return this.farmaceutico_id_farmaceutaField;
            }
            set {
                this.farmaceutico_id_farmaceutaField = value;
                this.RaisePropertyChanged("Farmaceutico_id_farmaceuta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Medicamento_codigo {
            get {
                return this.medicamento_codigoField;
            }
            set {
                this.medicamento_codigoField = value;
                this.RaisePropertyChanged("Medicamento_codigo");
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
    public interface WebServiceReservaMedicamentoSoapChannel : CapaHtml.ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceReservaMedicamentoSoapClient : System.ServiceModel.ClientBase<CapaHtml.ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoap>, CapaHtml.ServiceMantenedorReservaMedicamento.WebServiceReservaMedicamentoSoap {
        
        public WebServiceReservaMedicamentoSoapClient() {
        }
        
        public WebServiceReservaMedicamentoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceReservaMedicamentoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceReservaMedicamentoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceReservaMedicamentoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaReservaMedicamentoService(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento auxReservaMedicamento) {
            base.Channel.insertaReservaMedicamentoService(auxReservaMedicamento);
        }
        
        public System.Threading.Tasks.Task insertaReservaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento auxReservaMedicamento) {
            return base.Channel.insertaReservaMedicamentoServiceAsync(auxReservaMedicamento);
        }
        
        public System.Data.DataSet retornarReservaMedicamentoService(string id_reserva) {
            return base.Channel.retornarReservaMedicamentoService(id_reserva);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarReservaMedicamentoServiceAsync(string id_reserva) {
            return base.Channel.retornarReservaMedicamentoServiceAsync(id_reserva);
        }
        
        public CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento retornaPosicionReservaMedicamentoService(int pos, string id_reserva) {
            return base.Channel.retornaPosicionReservaMedicamentoService(pos, id_reserva);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> retornaPosicionReservaMedicamentoServiceAsync(int pos, string id_reserva) {
            return base.Channel.retornaPosicionReservaMedicamentoServiceAsync(pos, id_reserva);
        }
        
        public CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento buscarReservaMedicamentoService(string id_reserva) {
            return base.Channel.buscarReservaMedicamentoService(id_reserva);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> buscarReservaMedicamentoServiceAsync(string id_reserva) {
            return base.Channel.buscarReservaMedicamentoServiceAsync(id_reserva);
        }
        
        public CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento buscarIdReservaMedicamentoService(string id_reserva) {
            return base.Channel.buscarIdReservaMedicamentoService(id_reserva);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento> buscarIdReservaMedicamentoServiceAsync(string id_reserva) {
            return base.Channel.buscarIdReservaMedicamentoServiceAsync(id_reserva);
        }
        
        public void eliminarReservaMedicamentoService(string id_reserva) {
            base.Channel.eliminarReservaMedicamentoService(id_reserva);
        }
        
        public System.Threading.Tasks.Task eliminarReservaMedicamentoServiceAsync(string id_reserva) {
            return base.Channel.eliminarReservaMedicamentoServiceAsync(id_reserva);
        }
        
        public void actualizarReservaMedicamentoService(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento reserva_medicamento) {
            base.Channel.actualizarReservaMedicamentoService(reserva_medicamento);
        }
        
        public System.Threading.Tasks.Task actualizarReservaMedicamentoServiceAsync(CapaHtml.ServiceMantenedorReservaMedicamento.ReservaMedicamento reserva_medicamento) {
            return base.Channel.actualizarReservaMedicamentoServiceAsync(reserva_medicamento);
        }
    }
}