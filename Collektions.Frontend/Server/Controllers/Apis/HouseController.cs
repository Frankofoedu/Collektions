using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Collektions.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Collektions.Web.Controllers.Apis
{
    [ApiController]
    [Route("api/[controller]")]
    public class HouseController : BaseApiController
    {
        readonly IAsyncRepository<House> _houseRepository;
        public HouseController(IAsyncRepository<House> houseRepository)
        {
            _houseRepository = houseRepository;
        }

        [HttpGet("GetHouseById")]
        public async Task<House> GetAsync(int id)
        {
            return await _houseRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public HouseVM Post(HouseVM house)
        {
            return house;
        }
    }
}