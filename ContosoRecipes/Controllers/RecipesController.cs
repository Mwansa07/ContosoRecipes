using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ContosoRecipes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ActionResult GetRecipes([FromQuery]int count)
        {
            Recipe[] recipes = {
                new() { Title = "Oxtail" },
                new() { Title = "Curry Chicken" },
                new() { Title = "Dumplings" }
            };

            return Ok(recipes.Take(count));
        }

        // POST api/values
        [HttpPost]
        public ActionResult CreateNewRecipes([FromBody] Recipe newRecipe)
        {
            //validate and return to database
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();

            return Created("", newRecipe);
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] string value)
        //{
        //    if (!recipes.Any())
        //        return NotFound();

        //    recipes[id] = value;

        //    return NoContent();
        //}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult DeleteRecipes(string id)
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }
    }
}
