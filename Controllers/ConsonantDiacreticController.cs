using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restApiDataset.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace restApiDataset.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsonantDiacreticController : ControllerBase
    {
        private IConsonantDiacretic repository;
        public ConsonantDiacreticController(IConsonantDiacretic rep){
            this.repository = rep;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetConsonantDiacretics(){
            return await repository.GetConsonantDiacretics().ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetConsonantDiacreticsById(string id){
            return await repository.GetConsonantDiacreticsById(id).ToArrayAsync();
        }

    }
}