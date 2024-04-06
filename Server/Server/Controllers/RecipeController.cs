using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Server.Models;

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
        public async Task<ResponseModel?> GetRecipes([FromQuery(Name = "query"), BindRequired] string query)
        {
            return await _recipeService.GetRecipes(query, _configuration["Recipe:AppID"], _configuration["Recipe:AppKey"]);
        }
    }
}
