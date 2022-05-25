using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoregApp.Infrastructure.Persistence;
using StoregApp.Application.Entities;

namespace StoregApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private StoreGContext _context;

        public CategoriesController(StoreGContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            var list = _context.Categories;
            return Ok(list);
        }

        [HttpGet("{id}")]

        public ActionResult<Category> Get(int id)
        {
            var categoriaExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == id);
            if (categoriaExistente is null) return NotFound();
            return Ok(categoriaExistente);
        }

        [HttpPost]
        public ActionResult Post(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]

        public ActionResult Put(Category category)
        {
            var categoriaExistente = _context.Categories.FirstOrDefault(x => x.IdCategory==category.IdCategory);
            if (categoriaExistente is null) return NotFound();
            categoriaExistente.NameCategory = category.NameCategory;
            _context.SaveChanges();
            return Ok(categoriaExistente);
        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var categoriaExistente = _context.Categories.FirstOrDefault(x => x.IdCategory == id);
            if (categoriaExistente is null) return NotFound();
            _context.Categories.Remove(categoriaExistente);
            _context.SaveChanges();
            return Ok();
        }





    }
}
