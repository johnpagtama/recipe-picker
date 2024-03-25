using Microsoft.AspNetCore.Mvc;

namespace Server
{
    public interface IRecipeService
    {
        Task<ActionResult<string>> GetRecipes(string? type, string? appId, string? appKey, string? query);
    }
}