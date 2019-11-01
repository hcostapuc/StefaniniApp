using AppStefanini.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStefanini.Services
{
    public interface ICitiesService<T>
    {
        Task<T> GetCitiesAsync();
    }
}
