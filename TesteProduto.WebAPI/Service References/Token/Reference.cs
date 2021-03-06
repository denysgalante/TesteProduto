﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TesteProduto.WebAPI.Token {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Token.TokenService")]
    public interface TokenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TokenService/GenerateToken", ReplyAction="http://tempuri.org/TokenService/GenerateTokenResponse")]
        string GenerateToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TokenService/GenerateToken", ReplyAction="http://tempuri.org/TokenService/GenerateTokenResponse")]
        System.Threading.Tasks.Task<string> GenerateTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TokenService/ValidateToken", ReplyAction="http://tempuri.org/TokenService/ValidateTokenResponse")]
        bool ValidateToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TokenService/ValidateToken", ReplyAction="http://tempuri.org/TokenService/ValidateTokenResponse")]
        System.Threading.Tasks.Task<bool> ValidateTokenAsync(string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TokenServiceChannel : TesteProduto.WebAPI.Token.TokenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TokenServiceClient : System.ServiceModel.ClientBase<TesteProduto.WebAPI.Token.TokenService>, TesteProduto.WebAPI.Token.TokenService {
        
        public TokenServiceClient() {
        }
        
        public TokenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TokenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GenerateToken() {
            return base.Channel.GenerateToken();
        }
        
        public System.Threading.Tasks.Task<string> GenerateTokenAsync() {
            return base.Channel.GenerateTokenAsync();
        }
        
        public bool ValidateToken(string token) {
            return base.Channel.ValidateToken(token);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateTokenAsync(string token) {
            return base.Channel.ValidateTokenAsync(token);
        }
    }
}
