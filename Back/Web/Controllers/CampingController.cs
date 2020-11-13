using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data.Models;
using Service.CampingService;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class  CampingController: ControllerBase
    {
        private readonly CampingService campingService;
        private readonly ILogger<CampingController> _logger;

        public CampingController(ILogger<CampingController> logger, CampingService service)
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
    }
}
