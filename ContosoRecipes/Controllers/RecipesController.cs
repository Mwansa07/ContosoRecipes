using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings" };

            if (recipes.Any())
                return NotFound();

            return Ok(recipes);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void CreateNewRecipes([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }
    }
}
