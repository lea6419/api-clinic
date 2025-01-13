﻿using BL.InterfaceServe;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.BL;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
  

    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private BabyService _babiesService;
        public BabyController(BabyService babyService)=>  _babiesService = babyService;
       
        // GET: api/<BabyController>
        [HttpGet]
        public List<Baby> Get()
        {
            return _babiesService.GetBabies();
        }
        [HttpGet("id")]
        public Baby GetById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "BabyId cannot be less than zero.");
            }
            return _babiesService.GetById(id);
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
        public void Post([FromBody]  Baby baby)
        {
            _babiesService.PostBaby(baby);
        }
       
        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Baby baby)
        {
          
            _babiesService.UpdateBaby(baby);
        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _babiesService.DeleteBaby(id);
        }
    }
}
