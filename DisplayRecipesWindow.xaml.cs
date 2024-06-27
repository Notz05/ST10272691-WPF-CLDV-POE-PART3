using System.Collections.Generic;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class DisplayRecipesWindow : Window
    {
        private List<Recipe> recipes;

        public DisplayRecipesWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeListBox.ItemsSource = recipes;
        }
    }
}
