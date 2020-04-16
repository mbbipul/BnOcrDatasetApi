using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restApiDataset.Models;

namespace restApiDataset.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphemerootController : ControllerBase
    {
        private IGraphemerootRepository repository;
        public GraphemerootController(IGraphemerootRepository repo){
            repository = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemeroot(){
            return await repository.GetGraphemeroots().ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemerootById(string id){
            return await repository.GetGraphemeByrootId(id).ToListAsync();
        }
        [HttpGet("{id}/orderbyfont")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemerootByIdOrderByfont(string id){
            return await repository.GetGraphemeByrootIdOrderByFont(repository.GetGraphemeByrootId(id)).ToListAsync();
        }
        [HttpGet("{id}/{font}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemerootByIdByFont(string id,string font){
            return await repository.GetGraphemeByrootIdByName(id,font).ToListAsync();
        }
    }
}