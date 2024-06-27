using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class DisplayRecipeWindow : Window
    {
        private List<Recipe> recipes;

        public DisplayRecipeWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeComboBox.ItemsSource = recipes;
        }

        private void RecipeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem is Recipe selectedRecipe)
            {
                RecipeDetailsTextBlock.Text = $"Ingredients:\n{string.Join("\n", selectedRecipe.Ingredients.Select(i => $"{i.Quantity} {i.Unit} of {i.Name} ({i.FoodGroup}) - {i.Calories} cal"))}\n\nSteps:\n{string.Join("\n", selectedRecipe.Steps)}";
            }
        }
    }
}
