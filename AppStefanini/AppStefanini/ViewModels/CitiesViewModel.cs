using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using AppStefanini.Models;
using AppStefanini.Views;
using AppStefanini.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AppStefanini.ViewModels
{
    class CitiesViewModel : BaseViewModel
    {
        ICitiesService<CityColection> CitiesService => DependencyService.Get<ICitiesService<CityColection>>() ?? new CitiesService();
        public ObservableCollection<City> Cities { get; set; }
        public Command LoadCitiesCommand { get; set; }

        public CitiesViewModel()
        {
            Title = "Browse";
            Cities = new ObservableCollection<City>();
            LoadCitiesCommand = new Command(async () => await ExecuteLoadCitiesCommand());
        }

        async Task ExecuteLoadCitiesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Cities.Clear();

                var cities = await CitiesService.GetCitiesAsync();

                Parallel.ForEach(cities.Data, city =>
                {
                    Cities.Add(city);
                });
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        
    }
}