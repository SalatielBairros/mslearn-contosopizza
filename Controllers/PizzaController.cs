using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mslearn_contosopizza.Models;
using mslearn_contosopizza.Services;

namespace mslearn_contosopizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }
    }
}
