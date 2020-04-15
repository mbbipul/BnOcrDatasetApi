using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restApiDataset.Models;

namespace restApiDataset.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcrdatasetController : ControllerBase
    {
        private IOcrclassRepository repository;

        public OcrdatasetController(IOcrclassRepository rep)
        {
            repository = rep;
        }

        // GET: api/Ocrdataset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetOcrClasses()
        {
            return await repository.OcrClasses.ToListAsync();
        }

        // GET: api/Ocrdataset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OcrClass>> GetOcrClass(long id)
        {
            var ocrClass = repository.GetOcrClass(id);

            if (ocrClass == null)
            {
                return NotFound();
            }

            return await ocrClass;
        }
        [HttpGet("font-{name}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetOcrClassByFontName(string name)
        {
            return await repository.GetClassesByFontName(name).ToListAsync();
        }
        [HttpGet("r{grId}v{vId}c{cId}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemeBygraphemesids(string grId,string vId,string cId){
            return await repository.GetClassesByGraphemeIds(grId,vId,cId).ToListAsync();
        } 
        [HttpGet("r{grId}v{vId}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemeBygraphemervid(string grId,string vId){
            return await repository.GetClassesByGraphemeRVId(grId,vId).ToListAsync();
        } 
        [HttpGet("r{grId}c{cId}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemeBygraphemercid(string grId,string cId){
            return await repository.GetClassesByGraphemeRCId(grId,cId).ToListAsync();
        } 
        [HttpGet("vc{vId}/{cId}")]
        public async Task<ActionResult<IEnumerable<OcrClass>>> GetGraphemeBygraphemevcid(string vId,string cId){
            return await repository.GetClassesByGraphemeVCId(vId,cId).ToListAsync();
        } 
        // PUT: api/Ocrdataset/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcrClass(long id, OcrClass ocrClass)
        {
            if (id != ocrClass.Id)
            {
                return BadRequest();
            }
            var isUpdate =await repository.UpdateOcrClass(ocrClass);
            if(isUpdate){
                return NoContent();
            }
            return NotFound();
        }

        // POST: api/Ocrdataset
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OcrClass>> PostOcrClass(OcrClass ocrClass)
        {
            await repository.AddOcrClass(ocrClass);
            return CreatedAtAction("GetOcrClass", new { id = ocrClass.Id }, ocrClass);
        }
        [HttpPost("all")]
        public async Task<ActionResult<OcrClass>> PostOcrClasses(List<OcrClass> ocrClasses)
        {
            Console.WriteLine(ocrClasses);
            await repository.AddOcrClasses(ocrClasses);
            return CreatedAtAction("GetOcrClasses", new { count = ocrClasses.Count }, ocrClasses);
        }
        [HttpDelete("all")]
        public async Task<ActionResult<OcrClass>> DeleteOcrClasses()
        {
            await repository.DeleteAllOcrClass();
            return CreatedAtAction("GetOcrClasses", new { messgae = "Null" });
        }
        // DELETE: api/Ocrdataset/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OcrClass>> DeleteOcrClass(int id)
        {
            var ocrClass = await repository.DeleteOcrClassR(id);
            if (ocrClass == null)
            {
                return NotFound();
            }
            return ocrClass;
        }
    }
}
