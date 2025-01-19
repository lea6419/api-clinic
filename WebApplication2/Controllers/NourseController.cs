using BL.InterfaceServe;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NourseControllre : ControllerBase
    {
        private INurseService _nurseService;
        public NourseControllre(INurseService nurseService)=>_nurseService = nurseService;
        // GET: api/<BabyController>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return _nurseService.GetList();
        }
        [HttpGet("id")]
        public Nurse Get(int id)
        {
            return _nurseService.GetById(id);
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
        public void Post( Nurse nurse)
        {
            _nurseService.Post(nurse);
        }

        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Nurse nurse)
        {
            _nurseService.Update(nurse);
        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nurseService.Delete(id);
        }
    }
}
