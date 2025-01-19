using BL.InterfaceServe;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.BL;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        public readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointment)
        {
            _appointmentService = appointment;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id) => _appointmentService.GetById(id);
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _appointmentService.GetList();
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post(Appointment appointment)
        {
            try
            {
                _appointmentService.Post(appointment);
            }
            catch (Exception ex)
            {
                // Log the exception
                // Return a meaningful response
                throw new Exception("An error occurred while creating the appointment.", ex);
            }
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Appointment appointment)
        {
            _appointmentService.Update(appointment);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appointmentService.Delete(id);
        }
    }
}
