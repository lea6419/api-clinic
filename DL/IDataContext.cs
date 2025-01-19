using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.BL;

namespace DL
{
    public interface IDataContext
    {

        public int save();
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Baby> Babies { get; set; }
        public DbSet<Appointment>Appointments { get; set; }

    }
}
