using WebApplication2.BL;

namespace BL.InterfaceServe
{
    public interface IAppointmentService
    {
        void Delete(int id);
        Appointment GetById(int id);
        List<Appointment> GetList();
        void Post(Appointment appointment);
        void Update(Appointment appointment);
    }
}