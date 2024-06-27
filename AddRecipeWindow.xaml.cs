using System.Collections.Generic;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class AddRecipeWindow : Window
    {
        private List<Recipe> recipes;

        public AddRecipeWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            recipes.Add(new Recipe(RecipeNameTextBox.Text));
            MessageBox.Show("Recipe added successfully!");
            Close();
        }
    }
}
