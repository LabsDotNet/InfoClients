using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoClients.Api.Domain.Data;
using InfoClients.Api.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoClients.Api.Domain.Services
{
    public class LocationService : ILocationService
    {
        private readonly InfoClientsContext _context;
        public LocationService(InfoClientsContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetCitiesByState(int stateId)
        {
            var data = await _context.Cities.Where(x => x.IdState == stateId).OrderBy(x=>x.Name).ToListAsync();
            return data;
        }

        public async Task<List<Country>> GetCountries()
        {
            var data = await _context.Countries.OrderBy(x=>x.Name).ToListAsync();
            return data;
        }

        public async Task<List<State>> GetStatesByCountry(int countryId)
        {
            var data = await _context.States.Where(x => x.IdCountry == countryId).OrderBy(x=>x.Name).ToListAsync();
            return data;
        }
    }
}
