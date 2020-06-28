using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Collektions.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collektions.Web.Controllers.Apis
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HouseController : BaseApiController
    {
        readonly IAsyncRepository<House> _houseRepository;
        public HouseController(IAsyncRepository<House> houseRepository)
        {
            _houseRepository = houseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            //TODO: Get house for current logged in user
            await Task.Delay(5000);
            //return Ok(new HouseVM() { Name="Somolu House", Address="Ladi-Lak, Bariga." });
            return Ok(null);
        }

        [HttpPost]
        public IActionResult Post(HouseVM house)
        {
            //TODO: implement post house to database.
            return Ok(house);
        }

        [HttpPost("RequestJoin")]
        public async Task<IActionResult> PostRequestJoinAsync(string adminEmail)
        {
            //TODO: implement create notification for receiver = housemate(adminEmail) and sender=housemate(current User)
            await Task.Delay(5000);
            return Ok("Notification sent to admin of Somolu House.");
        }

        [HttpGet("ReplyJoin/{notificationId}/{reply}")]
        public async Task<IActionResult> PostReplyJoinAsync(int notificationId, int reply)
        {
            //TODO: implement reply join house request. reply is either 1=yes or 0=no
            await Task.Delay(5000);
            return Ok("User was added to house successfully.");
        }
    }
}