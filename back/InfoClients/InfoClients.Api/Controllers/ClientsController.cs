using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoClients.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfoClients.Api.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IInfoClientService _infoClientService;

        public ClientsController(IInfoClientService infoClientService)
        {
            _infoClientService = infoClientService ?? throw new ArgumentNullException(nameof(infoClientService));
        }


    }
}
