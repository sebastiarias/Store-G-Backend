using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Domain.Entities;
using StoregApp.Infrastructure.Persistence;
using System.Collections.Generic;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderdetailsController : ControllerBase
    {
        private StoreGContext _context;

        public OrderdetailsController(StoreGContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<OrderDetail>> Get()
        {
            var list = _context.OrderDetails;
            return Ok(list);
        }
    }
}
