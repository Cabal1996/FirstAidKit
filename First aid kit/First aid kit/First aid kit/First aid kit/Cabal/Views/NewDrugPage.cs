using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using First_aid_kit.Cabal.ViewModel;

namespace First_aid_kit.Cabal.Views
{
    class NewDrugPage : ContentPage
    {
        public NewDrugPage(AppViewModel ViewModel)
        {
            BindingContext = ViewModel;

            ToolbarItem createButton = new ToolbarItem("Создать", "", () =>
            {
                
            });

            createButton.SetBinding(ToolbarItem.CommandProperty, nameof(AppViewModel.CreateDrugCommand));

            ToolbarItems.Add(createButton);

            Editor name = new Editor
            {
                Placeholder = "Название",
                BackgroundColor = Color.Azure,
                Margin = new Thickness(10)
            };

            name.SetBinding(Editor.TextProperty, nameof(AppViewModel.DrugName));

            Label bestBefourTitle = new Label();
            bestBefourTitle.Text = "Годен до";

            DatePicker bestBefour = new DatePicker
            {
                MinimumDate = DateTime.Today,
                MaximumDate = DateTime.MaxValue,
                Date = DateTime.Now
            };

            bestBefour.SetBinding(DatePicker.DateProperty, nameof(AppViewModel.BestBefour));

            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                },

                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)}
                   
                }
            };

            grid.Children.Add(name, 0, 0);
            Grid.SetColumnSpan(name, 2);

            grid.Children.Add(bestBefourTitle, 0, 1);
            grid.Children.Add(bestBefour, 1, 1);


            Content = grid;
        }
        
    }
}
