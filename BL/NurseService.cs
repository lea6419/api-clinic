using BL.InterfaceServe;
using DL;
using WebApplication2.DL;

namespace WebApplication2.BL
{
    public class NurseService:INurseService
    {
        IDataContext _dataContext;
        public NurseService(IDataContext daContext) => _dataContext = daContext;
        public void Delete(int id)
        {
            _dataContext.Nurses.Remove(_dataContext.Nurses.ToList().Find(x => x.Id == id));
            _dataContext.save();
        }

        public Nurse GetById(int id)
        {
            return _dataContext.Nurses.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Nurse> GetList()
        {
            return _dataContext.Nurses.ToList();
            _dataContext.save();
           
        }
            public void Post(Nurse nurse)
        {
            _dataContext.Nurses.Add(nurse);
            _dataContext.save();
        }

        public void Update(Nurse nurse)
        {
            Nurse a = _dataContext.Nurses.ToList().Find(x => x.Id == nurse.Id);
            a.Id = nurse.Id;
            //   a.Appointments = nurse.Appointments;
            _dataContext.save();
        }
    }
}
