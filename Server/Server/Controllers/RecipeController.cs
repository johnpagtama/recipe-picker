using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [EnableCors("AllowedOrigins")]
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IRecipeService _recipeService;

        public RecipeController(IConfiguration configuration, IRecipeService recipeService)
        {
            _configuration = configuration;
            _recipeService = recipeService;
        }

        // GET: RecipeController
        [HttpGet(Name = "GetRecipes")]
        public async Task<ActionResult<string>> GetRecipes()
        {
            return await _recipeService.GetRecipes("public", _configuration["Recipe:AppID"], _configuration["Recipe:AppKey"], "beef");
        }
    }
}
