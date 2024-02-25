using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet8_KeyedServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private IShoppingCartRepository shoppingCartRepository { get; set; }
        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Cart", this.shoppingCartRepository.GetCart(CartSource.Cache).ToString() };
        }

        [HttpGet("{source}")]
        public string Get(CartSource source)
        {
            return this.shoppingCartRepository.GetCart(source).ToString();
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
