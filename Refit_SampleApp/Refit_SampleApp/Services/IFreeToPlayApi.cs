using Refit;
using Refit_SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refit_SampleApp.Services
{
    public interface IFreeToPlayApi
    {
        [Get("/games?sort-by=alphabetical")]
        Task<List<FreeToPlayGameModel>> GetF2PAsync();
        
    }
}
