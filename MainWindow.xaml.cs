using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeApplicationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            var addRecipeWindow = new AddRecipeWindow(recipes);
            addRecipeWindow.ShowDialog();
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var addIngredientWindow = new AddIngredientWindow(recipes);
            addIngredientWindow.ShowDialog();
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            var addStepWindow = new AddStepWindow(recipes);
            addStepWindow.ShowDialog();
        }

        private void DisplayRecipes_Click(object sender, RoutedEventArgs e)
        {
            var displayRecipesWindow = new DisplayRecipesWindow(recipes);
            displayRecipesWindow.ShowDialog();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            var displayRecipeWindow = new DisplayRecipesWindow(recipes);
            displayRecipeWindow.ShowDialog();
        }

        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            var filterRecipesWindow = new FilterRecipesWindow(recipes);
            filterRecipesWindow.ShowDialog();
        }

        private void CreateMenu_Click(object sender, RoutedEventArgs e)
        {
            var createMenuWindow = new CreateMenuWindow(recipes);
            createMenuWindow.ShowDialog();
        }
    }
}
