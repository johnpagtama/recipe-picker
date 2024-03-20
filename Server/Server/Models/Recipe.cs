namespace Server.Models
{
    public class Recipe
    {
        public string? Uri { get; set; }
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public ImageSize? ImagesUrl { get; set; }
        public string? Source { get; set; }
        public string? Url { get; set; }
        public string? ShareAs { get; set; }
        public int? Yield { get; set; }
        public string[]? DietLabels { get; set; }
        public string[]? HealthLabels { get; set; }
        public string[]? Cautions { get; set; }
        public string[]? IngredientLines { get; set; }
        public Ingredient[]? Ingredients { get; set; }
        public float Calories { get; set; }
        public float TotalCO2Emissions { get; set; }
        public string? Co2EmissionsClass { get; set; }
        public float TotalWeight { get; set; }
        public int TotalTime { get; set; }
        public string[]? CuisineType { get; set; }
        public string[]? MealType { get; set; }
        public string[]? DishType { get; set; }
        public TotalNutrients? TotalNutrients { get; set; }
        public TotalDaily? TotalDaily { get; set; }
        public Digest[]? Digest { get; set; }
        public string[]? Tags { get; set; }
    }
}
