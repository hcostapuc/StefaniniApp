using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppStefanini.Models;
using AppStefanini.ViewModels;

namespace AppStefanini.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CityDetailPage : ContentPage
    {
        CityDetailViewModel viewModel;

        public CityDetailPage(CityDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}