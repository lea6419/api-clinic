
using DL;
using Microsoft.EntityFrameworkCore;
using WebApplication2.BL;

namespace WebApplication2.DL
{
    public class DataContext :  DbContext, IDataContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
        public int save()
        {
            return base.SaveChanges();
        }
        DbSet<Nurse> IDataContext.Nurses {get ; set; }
        DbSet<Baby> IDataContext.Babies { get; set; }
        DbSet<Appointment> IDataContext.Appointments { get; set; }

       
/*
        public DbSet<Nurse> nurses1 = new DbSet<Nurse>
        {
            new Nurse()
            {
                NurseId = 1,
                Appointments = new DbSet<Appointment>()
            }
        };

        public  DbSet<Baby> Babies1 = new DbSet<Baby>
        {
            new Baby()
            {
                BabyId = 1,
                Name="yakov",
              
                Appointments=new DbSet<Appointment>()
            }
        };
        public  DbSet<Appointment> appointments1 = new DbSet<Appointment>
        {
            new Appointment()
            {
             AppointmentId=1, BabyId=1,NurseId=1,
            }
        };

        public List<Nurse> Nurses { get => nurses1; set => nurses1=Nurses; }
        public List<Baby> Babies { get => Babies1; set => Babies1=Babies; }
        public List<Appointment> Appointments { get => appointments1; set => Appointments=appointments1; }*/
    }
}
