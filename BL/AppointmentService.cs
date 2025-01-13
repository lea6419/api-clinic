using BL.InterfaceServe;
using DL;
using WebApplication2.DL;

namespace WebApplication2.BL
{
    public class AppointmentService : IAppointmentService
    {

        IDataContext _dataContext;
        public AppointmentService(IDataContext daContext)
        {
            _dataContext = daContext;
        }
        public Appointment GetById(int id)
        {
            return _dataContext.Appointments.Where(x => x.AppointmentId == id).FirstOrDefault();
        }




        public List<Appointment> GetList()
        {
            return _dataContext.Appointments.ToList();
        }

        public void Post(Appointment appointment)
        {
            _dataContext.Appointments.Add(appointment);

            Nurse n = _dataContext.Nurses.ToList().Find(a => a.NurseId == appointment.NurseId);
           // n.Appointments.Add(appointment);
            Baby b = _dataContext.Babies.ToList().Find(a => a.Id == appointment.BabyId);
            //b.Appointments.Add(appointment);
            _dataContext.save();
        }

        public void Update(Appointment appointment)
        {
            Appointment LastAppoitment = _dataContext.Appointments.ToList().Find(x => x.AppointmentId == appointment.AppointmentId);
            Nurse LastNurse = _dataContext.Nurses.ToList().Find(x => x.NurseId == LastAppoitment.NurseId);
        //    LastNurse.Appointments.Remove(LastAppoitment);
           // _dataContext.Nurses.ToList().Find(x => x.NurseId == appointment.NurseId).Appointments.Add(appointment);

            Baby lastBaby = _dataContext.Babies.ToList().Find(x => x.Id == LastAppoitment.BabyId);
          //  LastNurse.Appointments.Remove(LastAppoitment);
          //  _dataContext.Babies.ToList().Find(x => x.BabyId == appointment.BabyId).Appointments.Add(appointment);
            _dataContext.Appointments.Remove(LastAppoitment);
            _dataContext.Appointments.Add(appointment);
            _dataContext.save();
        }

        public void Delete(int id)
        {
            Appointment ap = _dataContext.Appointments.ToList().Find(x => x.AppointmentId == id);
            _dataContext.Appointments.Remove(ap);
            Nurse n = _dataContext.Nurses.ToList().Find(a => a.NurseId == ap.NurseId);
          //  n.Appointments.Remove(ap);
            Baby b = _dataContext.Babies.ToList().Find(a => a.Id == ap.BabyId);
            //b.Appointments.Remove(ap);
            _dataContext.save();
        }

    }


}