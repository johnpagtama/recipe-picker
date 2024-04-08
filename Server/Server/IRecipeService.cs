using Server.Models;

namespace Server
{
    public interface IRecipeService
    {
        Task<ResponseModel?> GetRecipes(string? query, string? appId, string? appKey, IEnumerable<string>? dietLabel);
    }
}