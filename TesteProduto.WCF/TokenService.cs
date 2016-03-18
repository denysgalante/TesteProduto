using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TesteProduto.WCF
{
    [ServiceContract]
    public interface TokenService
    {
        [OperationContract]
        string GenerateToken();

        [OperationContract]
        bool ValidateToken(string token);
    }
}
