using First_aid_kit.Cabal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace First_aid_kit.Cabal.Views
{
    public class DrugOverview : ContentPage
    {
        public DrugOverview(AppViewModel ViewModel)
        {
            BindingContext = ViewModel;

            Label Name = new Label();
            Name.SetBinding(Label.TextProperty, nameof(AppViewModel.SelectedDrugName));

            Label BestBefour = new Label();
            BestBefour.SetBinding(Label.TextProperty, nameof(AppViewModel.SelectedDrugBestBefour));

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
