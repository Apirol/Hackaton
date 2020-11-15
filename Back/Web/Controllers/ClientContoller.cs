using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data.Models;
using Service.ClientService;
using Web.RequestModels;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;
        private readonly ILogger<CampingController> _logger;

        public ClientController(ILogger<CampingController> logger, IClientService service)
        {
            this._logger = logger;
            this.clientService = service;
        }

        [HttpGet("/api/Owner/GetClient")]
        public ActionResult GetClient(Guid id)
        {
            var client = clientService.GetClient(id);
            return Ok(client);
        }

        [HttpGet("/api/Owner/AddClient")]
        public ActionResult AddClient([FromBody] ClientRequestModelcs requestModel)
        {
            var client = new Client
            {
                ID = requestModel.ID,
                FirstName = requestModel.FirstName,
                LastName = requestModel.LastName,
                Telephone = requestModel.Telephone,
                CompanyName = requestModel.CompanyName
            };
            clientService.AddClient(client);
            return Ok("Client was added");
        }
    }
}