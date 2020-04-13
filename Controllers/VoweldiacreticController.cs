using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restApiDataset.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace restApiDataset.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoweldiacreticController : ControllerBase
    {
        private IVowelDiacretic repository;
        public VoweldiacreticController(IVowelDiacretic repo){
            this.repository = repo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetVowelDiacretics(){
            return await repository.GetVowelDiacretics().ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetVowelDiacreticsById(string id){
            return await repository.GetVowelDiacreticsById(id).ToListAsync();
        }

    }
}