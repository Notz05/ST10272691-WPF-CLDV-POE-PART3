using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class DisplayRecipesWindow : Window
    {
        private readonly List<Recipe> recipes;

        public DisplayRecipesWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeComboBox.ItemsSource = recipes;
        }

        private void RecipeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem is Recipe selectedRecipe)
            {
                RecipeDetailsTextBlock.Text = $"Ingredients:\n{string.Join("\n", selectedRecipe.Ingredients.Select(i => $"{i.Quantity} {i.Unit} of {i.Name} ({i.FoodGroup}) - {i.Calories} cal"))}";

                StepsListBox.ItemsSource = selectedRecipe.Steps.Select((step, index) => new StepItem { Index = index + 1, Description = step, Completed = false }).ToList();
            }
        }
    }

    public class StepItem
    {
        public int Index { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
