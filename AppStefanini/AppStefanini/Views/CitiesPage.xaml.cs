using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppStefanini.Models;
using AppStefanini.ViewModels;

namespace AppStefanini.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CitiesPage : ContentPage
    {
        CitiesViewModel viewModel;

        public CitiesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CitiesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var city = args.SelectedItem as City;
            if (city == null)
                return;

            await Navigation.PushAsync(new CityDetailPage(new CityDetailViewModel(city)));

            // Manually deselect item.
            CitiesListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Cities.Count == 0)
                viewModel.LoadCitiesCommand.Execute(null);
        }
    }
}