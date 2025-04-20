using System.ComponentModel.DataAnnotations;

namespace MvcRecipe.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public decimal Time { get; set; }
    public int Difficulty { get; set; }
    public int Likes { get; set; }

    public List<string> ingredients {get; set;}
    public string process {get; set;}
    public string tipsAndTrics {get; set;}
}
