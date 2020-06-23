using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Collektions.Web.Interfaces;
using Collektions.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Collektions.Web.Controllers.Apis
{
    public class FlatMateController : Controller
    {
        IFlatMateViewModelService _flatMateViewModelService;
        public FlatMateController(IFlatMateViewModelService flatMateViewModelService) => _flatMateViewModelService = flatMateViewModelService;
            
        public Task<FlatMateViewModel> GetFlatMateById(int id, int houseId)
        {
            return null;
        }

        [HttpPost("CreateFlatMate")]
        public async Task<IActionResult> PostFlatMate(FlatMateViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var result =  await _flatMateViewModelService.CreateFlatMate(vm);

            return CreatedAtAction(nameof(FlatMate), new {id = vm.Id } ,vm);

        }

    }
}