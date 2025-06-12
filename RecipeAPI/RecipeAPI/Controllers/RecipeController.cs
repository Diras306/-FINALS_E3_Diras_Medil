using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecipe()
        {
            var recipe = new
            {
                DishName = "Spaghetti Carbonara",
                Ingredients = new string[]
                {
                    "200g Spaghetti",
                    "100g Bacon",
                    "2 Eggs",
                    "50g Parmesan Cheese",
                    "Salt & Pepper"
                },
                Steps = new string[]
                {
                    "1. Boil the spaghetti until al dente.",
                    "2. Fry the bacon until crispy.",
                    "3. Beat the eggs and mix with parmesan cheese.",
                    "3. Beat the eggs and mix with parmesan cheese.",
                    "4. Combine spaghetti, bacon, and egg mixture.",
                    "5. Season with salt and pepper. Serve hot."
                }
            };
            return Ok(recipe);
        }
    }
}
