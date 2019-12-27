using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace First_aid_kit.Cabal.Views
{
    public class DrugOverview : ContentPage
    {
        public Label Name;
        public Label BestBefour;

        public DrugOverview()
        {
            Name = new Label()
            {
                //Text options goes here
            };

            BestBefour = new Label()
            {
                //Text options goes here
            };

            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                },

                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)}

                }
            };

            grid.Children.Add(Name, 0, 0);
            grid.Children.Add(BestBefour, 0, 1);

            Content = grid;
        }
    }
}
