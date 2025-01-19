using System.Collections.Generic;

namespace WebApplication2.BL
{
    public class Baby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Appointment> Appointment { get; set; }

        public Baby()
        {
        }

        public Baby(int v1, string v2, Appointment appointment)
        {
            this.Id = v1;
            this.Name = v2;
           // this.Appointment = appointment;
        }

        
        //public List <Appointment> Appointments { get; set; }
        // public List<Appointment> Appointments { get; set; }
    }
}
