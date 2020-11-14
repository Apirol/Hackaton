using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data.Models;
using Service.CampingService;
using Web.RequestModels;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampingController : ControllerBase
    {
        private readonly ICampingService campingService;
        private readonly ILogger<CampingController> _logger;

        public CampingController(ILogger<CampingController> logger, ICampingService service)
        {
            this._logger = logger;
            this.campingService = service;
        }

        [HttpGet("/api/Owner/Campings/getAllCampings")]
        public ActionResult GetAllCampings()
        {
            var campings = campingService.GetAllCampings();
            return Ok(campings);
        }

        [HttpGet("/api/Owner/Campings/getCampingById")]
        public ActionResult GetCampingById(Guid id)
        {
            var camping = campingService.GetOneCamping(id);
            if (camping != null)
                return Ok(camping);

            return Ok("Camping doesn't exist");
        }

        [HttpGet("/api/Campings/DeleteCamping")]
        public ActionResult DeleteCamping(Guid id)
        {
            var camping = campingService.GetOneCamping(id);
            if (camping != null)
            {
                campingService.DeleteCamping(camping);
                return Ok("Camping was deleted");
            }

            return Ok("Camping doesn't exist");
        }

        [HttpPost("/api/Campings/AddNewCamping")]
        public ActionResult AddNewCamping([FromBody] CampingRequestModel newRequest)
        {
            var time = DateTime.Now;
            var camping = new Camping
            {
                Owner = newRequest.Owner,
                Name = newRequest.Name,
                Description = newRequest.Description,
                ParkingType = newRequest.ParkingType,
                ParkingSize = newRequest.ParkingSize,
                Rating = newRequest.Rating,
                PricePerDay = newRequest.PricePerDay,
                URL = newRequest.URL,
                Id = newRequest.Id,
                CreateOn = time,
                facilities = newRequest.facilities,
                location = newRequest.location
            };

            campingService.AddCamping(camping);
            return Ok("Camping was created");
        }
    }
}
