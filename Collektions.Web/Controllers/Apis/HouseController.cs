using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Collektions.Web.Controllers.Apis
{
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
    }
}