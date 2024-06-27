using System.Collections.Generic;
using System.Windows;

namespace RecipeApplicationWPF
{
    public partial class AddStepWindow : Window
    {
        private List<Recipe> recipes;

        public AddStepWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeComboBox.ItemsSource = recipes;
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem is Recipe selectedRecipe)
            {
                selectedRecipe.AddStep(StepTextBox.Text);
                MessageBox.Show("Step added successfully!");
                Close();
            }
        }
    }
}
