using BL.InterfaceServe;
using DL;
using WebApplication2.DL;

namespace WebApplication2.BL
{
    public class NurseService:INurseService
    {
        IDataContext _dataContext;
        public NurseService(IDataContext daContext) => _dataContext = daContext;
 
        public Nurse GetNurseId(int id)
        {
            return _dataContext.Nurses.Where(x => x.NurseId == id).FirstOrDefault();
        }
        public List<Nurse> GetNurse()
        {
            return _dataContext.Nurses.ToList();
            _dataContext.save();

        }
        public void UpdateNurse( Nurse nurse)
        {
                Nurse a = _dataContext.Nurses.ToList().Find(x => x.NurseId == nurse.NurseId);
            a.NurseId = nurse.NurseId;
            //   a.Appointments = nurse.Appointments;
            _dataContext.save();

        }
        public void PostNurse(Nurse nurse)
        {
            _dataContext.Nurses.Add( nurse);
            _dataContext.save();

        }
        public void DeleteNurse(int id)
        {
            _dataContext.Nurses.Remove(_dataContext.Nurses.ToList().Find(x => x.NurseId == id));
            _dataContext.save();
        }
    }
}
