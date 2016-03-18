using TesteProduto.WebAPI.Token;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;

namespace TesteProduto.WebAPI.DataLayer
{
    public static class TokenRepository
    {
        public static string GenerateToken()
        {
            using (var client = new TokenServiceClient())
            {
                return client.GenerateToken();
            }
        }

        public static bool ValidateToken(string token)
        {
            using (var client = new TokenServiceClient())
            {
                return client.ValidateToken(token);
            }
        }
    }
}