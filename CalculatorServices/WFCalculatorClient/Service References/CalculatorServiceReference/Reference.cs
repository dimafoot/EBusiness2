﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFCalculatorClient.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="http://localhsot.CalculatorService.Sample", ConfigurationName="CalculatorServiceReference.httplocalhsotCalculatorServiceSample")]
    public interface httplocalhsotCalculatorServiceSample {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Ad" +
            "d", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Ad" +
            "dResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Ad" +
            "d", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Ad" +
            "dResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Su" +
            "bstract", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Su" +
            "bstractResponse")]
        double Substract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Su" +
            "bstract", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Su" +
            "bstractResponse")]
        System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Mu" +
            "ltiply", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Mu" +
            "ltiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Mu" +
            "ltiply", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Mu" +
            "ltiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Di" +
            "vide", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Di" +
            "videResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Di" +
            "vide", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_localhsot.CalculatorService.Sample/Di" +
            "videResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface httplocalhsotCalculatorServiceSampleChannel : WFCalculatorClient.CalculatorServiceReference.httplocalhsotCalculatorServiceSample, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class httplocalhsotCalculatorServiceSampleClient : System.ServiceModel.ClientBase<WFCalculatorClient.CalculatorServiceReference.httplocalhsotCalculatorServiceSample>, WFCalculatorClient.CalculatorServiceReference.httplocalhsotCalculatorServiceSample {
        
        public httplocalhsotCalculatorServiceSampleClient() {
        }
        
        public httplocalhsotCalculatorServiceSampleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public httplocalhsotCalculatorServiceSampleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public httplocalhsotCalculatorServiceSampleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public httplocalhsotCalculatorServiceSampleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Substract(double n1, double n2) {
            return base.Channel.Substract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2) {
            return base.Channel.SubstractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
    }
}
