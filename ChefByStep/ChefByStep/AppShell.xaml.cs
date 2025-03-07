﻿namespace ChefByStep
{
    using System;

    using ChefByStep.Views;

    using Xamarin.Forms;

    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(RecipeStepsPage), typeof(RecipeStepsPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(UserFavouriteRecipesPage), typeof(UserFavouriteRecipesPage));
            Routing.RegisterRoute(nameof(RecipeCategoryPage), typeof(RecipeCategoryPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}