using Collektions.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collektions.Web.Interfaces
{
    public interface IFlatMateViewModelService
    {
        Task<FlatMateViewModel> CreateFlatMate(FlatMateViewModel fVm);
        Task<FlatMateViewModel> GetFlatMateById(int id, int houseId);
    }
}
