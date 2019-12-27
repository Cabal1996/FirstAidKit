using First_aid_kit.Cabal.Model;
using First_aid_kit.Cabal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace First_aid_kit.Cabal.Views
{
    public class KitContent : ContentPage
    {
        

        public KitContent(AppViewModel ViewModel)
        {
            BindingContext = ViewModel;

            ToolbarItem newButton = new ToolbarItem("Добавить", "", () =>
            {
                //logic code goes here
            });

            newButton.SetBinding(ToolbarItem.CommandProperty, nameof(AppViewModel.NewDrugCommand));

            ToolbarItems.Add(newButton);

            Editor searchBar = new Editor
            {
                Placeholder = "Поиск по названию...",
                BackgroundColor = Color.Azure,
                Margin = new Thickness(10)
            };

            CollectionView drugCollection = new CollectionView
            {
                ItemTemplate = new NotesTemplate()
            };
            drugCollection.SetBinding(CollectionView.ItemsSourceProperty, nameof(AppViewModel.DrugCollection));
            drugCollection.SetBinding(CollectionView.SelectedItemProperty, nameof(AppViewModel.SelectedDrug));
            drugCollection.SetBinding(CollectionView.SelectionChangedCommandProperty, nameof(AppViewModel.DrugSelectedCommand));   

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
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Auto)}
                }
            };

            grid.Children.Add(searchBar, 0, 0);
            Grid.SetColumnSpan(searchBar, 2);

            grid.Children.Add(drugCollection, 0, 1);
            Grid.SetColumnSpan(drugCollection, 2);

            Content = grid;

        }

        class NotesTemplate : DataTemplate
        {
            public NotesTemplate() : base(LoadTemplate)
            {

            }

            static StackLayout LoadTemplate()
            {
                var textLabel = new Label();
                textLabel.SetBinding(Label.TextProperty, nameof(DrugModel.Name));

                var frame = new Frame
                {
                    VerticalOptions = LayoutOptions.Center,
                    Content = textLabel
                };

                return new StackLayout
                {
                    Children = { frame },
                    Padding = new Thickness(10, 10)
                };
            }
        }
    }
}