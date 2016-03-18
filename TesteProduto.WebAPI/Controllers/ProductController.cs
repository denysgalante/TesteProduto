using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TesteProduto.WebAPI.DataLayer;

namespace TesteProduto.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        ProductInfoEntities db;
        public ProductController()
        {
            db = new ProductInfoEntities();
        }

        //TokenRepository é a instancia para os  
        //métodos que estao sendo chamados via WCF

        /// <summary>
        /// Get Token generate
        /// </summary>
        /// <returns></returns>
        [Route("GetToken")]
        public string GetToken()
        {
            return TokenRepository.GenerateToken();
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [Route("GetProducts/{token}")]
        public List<Product> GetProducts(string token)
        {
            if (TokenRepository.ValidateToken(token))
                return db.Products.ToList();
            else
                throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}
