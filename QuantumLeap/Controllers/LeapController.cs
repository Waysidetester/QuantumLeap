using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantumLeap.Data;

namespace QuantumLeap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeapController : ControllerBase
    {
        readonly LeaperRepo _leaperRepo;

        public LeapController()
        {
            _leaperRepo = new LeaperRepo();
        }

        [HttpGet("{id}")]
        public ActionResult GetLeapInfo(int id)
        {
            var selectedLeaper = _leaperRepo.GatherCurrentIntel(id);

            return Accepted($"api/Leap/{id}", selectedLeaper);
        }

        [HttpGet("{id}/jump")]
        public ActionResult QuantumJump(int id)
        {

        }
    }
}