using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoClients.Api.Domain.Data.Entities;
using InfoClients.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfoClients.Api.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService ?? throw new ArgumentNullException(nameof(locationService));
        }

        /// <summary>
        /// Returns all countries
        /// </summary>
        /// <returns>List of countries</returns>
        [HttpGet("countries")]
        public async Task<ActionResult<List<Country>>> GetCountries()
        {
            var countries = await _locationService.GetCountries();

            if (countries.Any())
                return Ok(countries);

            return NotFound();
        }

        /// <summary>
        /// Returns all states by country
        /// </summary>
        /// <returns>List of states</returns>
        /// <param name="id">country id</param>
        [HttpGet("countries/{id:int}/states")]
        public async Task<ActionResult<List<State>>> GetStatesByCountry(int id)
        {
            var states = await _locationService.GetStatesByCountry(id);

            if (states.Any())
                return Ok(states);

            return NotFound();
        }

        /// <summary>
        /// Returns all cities by state
        /// </summary>
        /// <returns>List of cities</returns>
        /// <param name="id">state id</param>
        [HttpGet("states/{id:int}/cities")]
        public async Task<ActionResult<List<City>>> GetCitiesByState(int id)
        {
            var cities = await _locationService.GetCitiesByState(id);

            if (cities.Any())
                return Ok(cities);

            return NotFound();
        }
    }
}
