// Recipe.cs
using System.Collections.Generic;
using System.Linq;

namespace RecipeApplicationWPF
{
    public class Recipe
    {
        // Properties and methods for the Recipe class
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<string> Steps { get; set; } = new List<string>();

        public Recipe(string name)
        {
            Name = name;
        }

        public void AddIngredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Ingredients.Add(new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            });
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public int CalculateTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories);
        }

        public void ScaleRecipe(double scale)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= scale;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = 1;
            }
        }

        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();
        }
    }

    
}
