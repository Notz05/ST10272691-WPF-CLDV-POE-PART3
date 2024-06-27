using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;

namespace RecipeApplicationWPF
{
    public partial class CreateMenuWindow : Window
    {
        private List<Recipe> recipes;

        public CreateMenuWindow(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeListBox.ItemsSource = recipes;
        }

        private void CreateMenu_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipes = RecipeListBox.SelectedItems.Cast<Recipe>().ToList();
            if (selectedRecipes.Count == 0)
            {
                MessageBox.Show("Please select at least one recipe to create a menu.");
                return;
            }

            var foodGroupCounts = selectedRecipes
                .SelectMany(r => r.Ingredients)
                .GroupBy(i => i.FoodGroup)
                .Select(g => new { FoodGroup = g.Key, Count = g.Count() })
                .ToDictionary(g => g.FoodGroup, g => g.Count);

            MenuPieChart.Series.Clear();
            foreach (var foodGroup in foodGroupCounts)
            {
                MenuPieChart.Series.Add(new PieSeries
                {
                    Title = foodGroup.Key,
                    Values = new ChartValues<int> { foodGroup.Value },
                    DataLabels = true
                });
            }
        }
    }
}
