using Microsoft.AspNetCore.Mvc;

namespace Server
{
    public class RecipeService : IRecipeService
    {
        private readonly HttpClient _httpClient;

        public RecipeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ActionResult<string>> GetRecipes(string? type, string? appId, string? appKey, string? query)
        {
            return await _httpClient.GetStringAsync($"?type={type}&q={query}&app_id={appId}&app_key={appKey}");
        }
    }
}
