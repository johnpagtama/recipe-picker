using Newtonsoft.Json;
using Server.Models;
//using Microsoft.AspNetCore.WebUtilities;

namespace Server
{
    public class RecipeService : IRecipeService
    {
        private readonly HttpClient _httpClient;

        public RecipeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseModel?> GetRecipes(string? query, string? appId, string? appKey, IEnumerable<string>? dietLabel)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"?type=public&q={query}&app_id={appId}&app_key={appKey}");

            response.EnsureSuccessStatusCode();

            string stringResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseModel>(stringResponse);
        }
    }
}
