using BL.InterfaceServe;
using DL;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DL;

namespace WebApplication2.BL
{
    public class BabyService : IBabyService
    {
        IDataContext _dataContext;
        public BabyService(IDataContext daContext)
        {
            _dataContext = daContext;
        }
        public Baby GetById(int id)
        {
            return _dataContext.Babies.Where(x => x.Id == id).FirstOrDefault();
        }
        public void Delete(int id)
        {
            _dataContext.Babies.Remove(_dataContext.Babies.ToList().Find(x => x.Id == id));
            _dataContext.save();
        }

        public IEnumerable<Baby> GetList()
        {
            return _dataContext.Babies.ToList();
        }

        public void Post(Baby baby)
        {
            _dataContext.Babies.Add(baby);
            _dataContext.save();
        }

        public void Update(Baby baby)
        {
            Baby a = _dataContext.Babies.ToList().Find(x => x.Id == baby.Id);
            a.Id = baby.Id;
            //a.Appointments = baby.Appointments;
            _dataContext.save();
        }
    }
}
