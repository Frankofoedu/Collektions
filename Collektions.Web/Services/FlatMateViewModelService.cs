using Collektions.Core.Entities;
using Collektions.Core.Interfaces;
using Collektions.Web.Interfaces;
using Collektions.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collektions.Web.Services
{
    public class FlatMateViewModelService : IFlatMateViewModelService
    {
       private readonly IAsyncRepository<FlatMate> _flatMatesRepository;
        public FlatMateViewModelService(IAsyncRepository<FlatMate> flatMatesRepository)
        {
            _flatMatesRepository = flatMatesRepository;
        }
        public async Task<FlatMateViewModel> CreateFlatMate(FlatMateViewModel fVm)
        {
            var flatmate = new FlatMate(fVm.HouseId.Value, fVm.Name);

            await _flatMatesRepository.AddAsync(flatmate);

            fVm.Id = flatmate.Id;

            return fVm;
        }

        public Task<FlatMateViewModel> GetFlatMateById(int id, int houseId)
        {

        }
    }
}
