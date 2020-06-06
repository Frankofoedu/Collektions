using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Collektions.Web.Controllers.Apis
{
    public class FlatMateController : Controller
    {
        readonly IAsyncRepository<FlatMate> _flatMatesRepository;
        public FlatMateController(IAsyncRepository<FlatMate> flatMatesRepository)
        {
            _flatMatesRepository = flatMatesRepository;
        }

        public Task<FlatMateViewModel> GetFlatMateById(int id, int houseId)
        {
            _flatMatesRepository.FirstAsync()
        }

    }
}