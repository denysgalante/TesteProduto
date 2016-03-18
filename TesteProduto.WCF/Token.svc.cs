using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TesteProduto.WCF
{
    public class Token : TokenService
    {
        public string GenerateToken()
        {
            var time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            var key = Guid.NewGuid().ToByteArray();
            var token = Convert.ToBase64String(time.Concat(key).ToArray());
            token = token.Replace("/", "-").Replace("+", "=");
            return token;
        }

        public bool ValidateToken(string token)
        {
            var tokenExpired = true;

            if (!string.IsNullOrEmpty(token) && token != "undefined")
            {
                token = token.Replace("-", "/").Replace("=", "+");
                var data = Convert.FromBase64String(token);
                var when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
                if (when >= DateTime.UtcNow.AddMinutes(-1))
                {
                    tokenExpired = false;
                }
            }

            return !tokenExpired;
        }
    }
}
