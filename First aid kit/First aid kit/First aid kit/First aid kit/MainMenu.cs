using First_aid_kit.Cabal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace First_aid_kit
{
    public class MainMenu : ContentPage
    {
        Button myKit, prescriptions, doctors, features, medicationSchedule, notifications, pharmacies, medicationPuerchase, archive;

        public MainMenu()
        {
            BindingContext = new AppViewModel();

            BackgroundColor = Color.White;

            myKit = new Button
            {
                Text = "Моя аптечка",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            myKit.SetBinding(Button.CommandProperty, nameof(AppViewModel.myKitCommand));

            prescriptions = new Button
            {
                Text = "Рецепты",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            doctors = new Button
            {
                Text = "Врачи",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            features = new Button
            {
                Text = "Особенности",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            medicationSchedule = new Button
            {
                Text = "Прием лекарств",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            notifications = new Button
            {
                Text = "Напоминание",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            pharmacies = new Button
            {
                Text = "Аптеки",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            medicationPuerchase = new Button
            {
                Text = "Покупка лекарств",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            archive = new Button
            {
                Text = "Архив",
                TextColor = Color.Black,
                BackgroundColor = Color.CornflowerBlue,
                CornerRadius = 6,
                Margin = new Thickness(6)
            };

            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },

                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                }
            };

            grid.Children.Add(myKit, 1, 0);
            grid.Children.Add(prescriptions, 1, 1);
            grid.Children.Add(doctors, 1, 2);
            grid.Children.Add(features, 1, 3);
            grid.Children.Add(medicationSchedule, 1, 4);
            grid.Children.Add(notifications, 1, 5);
            grid.Children.Add(pharmacies, 1, 6);
            grid.Children.Add(medicationPuerchase, 1, 7);
            grid.Children.Add(archive, 1, 8);

            Content = grid;
        }
    }
}
