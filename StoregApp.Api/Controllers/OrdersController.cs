using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Domain.Entities;
using StoregApp.Infrastructure.Persistence;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrdersController : ControllerBase
    {
        private StoreGContext _context;

        public OrdersController(StoreGContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            var list = _context.Products;
            return Ok(list);
        }
    }

}
