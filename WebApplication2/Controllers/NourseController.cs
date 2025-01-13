using Microsoft.AspNetCore.Mvc;
using WebApplication2.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NourseControllre : ControllerBase
    {
        private NurseService _nurseService;
        public NourseControllre(NurseService nurseService)=>_nurseService = nurseService;
        // GET: api/<BabyController>
        [HttpGet]
        public List<Nurse> Get()
        {
            return _nurseService.GetNurse();
        }
        [HttpGet("id")]
        public Nurse Get(int id)
        {
            return _nurseService.GetNurseId(id);
        }

        /// <summary>
        /// Get baby by Id
        /// </summary>
        /// <param name="id">The id of the baby</param>
        /// <returns>The baby with the given id</returns>
        //[HttpGet("{id}")]
        //public Baby GetBabyById(int id)
        //{
        //    return "value";
        //}

        // POST api/<BabyController>
        [HttpPost]
        public void Post([FromBody] Nurse nurse)
        {
            _nurseService.PostNurse(nurse);
        }

        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Nurse nurse)
        {
            _nurseService.UpdateNurse(nurse);
        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nurseService.DeleteNurse(id);
        }
    }
}
