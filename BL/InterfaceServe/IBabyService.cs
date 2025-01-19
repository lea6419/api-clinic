using WebApplication2.BL;

namespace BL.InterfaceServe
{
    public interface IBabyService
    {
        void Delete(int id);
        Baby GetById(int id);
        IEnumerable<Baby> GetList();
        void Post(Baby baby);
        void Update(Baby baby);
    }
}