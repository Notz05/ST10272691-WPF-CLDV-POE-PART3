using System.Collections.Generic;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class AddIngredientWindow : Window
    {
        private List<Recipe> recipes;

        public AddIngredientWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeComboBox.ItemsSource = recipes;
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem is Recipe selectedRecipe)
            {
                selectedRecipe.AddIngredient(IngredientNameTextBox.Text, double.Parse(QuantityTextBox.Text), UnitTextBox.Text, int.Parse(CaloriesTextBox.Text), FoodGroupTextBox.Text);
                MessageBox.Show("Ingredient added successfully!");
                Close();
            }
        }
    }
}
