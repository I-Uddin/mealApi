using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MowAPI.Data;
using MowAPI.Models;

namespace MowAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
    private readonly DataContext _context;

    public MealController(DataContext context)
    {
        _context = context;
    }


        [HttpGet]
        public async Task<ActionResult<List<Meal>>> GetMeals()
        {
            return Ok(await _context.Meals.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Meal>>> CreateMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            await _context.SaveChangesAsync();

            return Ok(await _context.Meals.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Meal>>> UpdateMeal(Meal meal)
        {
            var dbMeal = await _context.Meals.FindAsync(meal.Id);

            if (dbMeal == null)
                return BadRequest("Meal not found");

            dbMeal.Name = meal.Name;
            dbMeal.Ingredients = meal.Ingredients;
            dbMeal.Quantity = meal.Quantity;

            await _context.SaveChangesAsync();

            return Ok(await _context.Meals.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Meal>>> DeleteMeal(int id)
        {
            var dbMeal = await _context.Meals.FindAsync(id);
            if (dbMeal == null)
                return BadRequest("Meal not found.");

            _context.Meals.Remove(dbMeal);
            await _context.SaveChangesAsync();

            return Ok(await _context.Meals.ToListAsync());
        }
    }
}
