using InfoClients.Api.Domain.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoClients.Api.Domain.Services
{
    public interface ILocationService
    {
        Task<List<Country>> GetCountries();

        Task<List<State>> GetStatesByCountry(int countryId);

        Task<List<City>> GetCitiesByState(int stateId);
    }
}
