using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class FilterRecipesWindow : Window
    {
        private List<Recipe> recipes;

        public FilterRecipesWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            FoodGroupComboBox.ItemsSource = recipes.SelectMany(r => r.Ingredients).Select(i => i.FoodGroup).Distinct().ToList();
        }

        private void FoodGroupComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (FoodGroupComboBox.SelectedItem is string selectedFoodGroup)
            {
                var filteredRecipes = recipes.Where(r => r.Ingredients.Any(i => i.FoodGroup == selectedFoodGroup)).ToList();
                FilteredRecipesListBox.ItemsSource = filteredRecipes;
            }
        }
    }
}
