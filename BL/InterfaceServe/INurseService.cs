using WebApplication2.BL;

namespace BL.InterfaceServe
{
    public interface INurseService
    {
        void Delete(int id);
        Nurse GetById(int id);
        List<Nurse> GetList();
        void Post(Nurse nurse);
        void Update(Nurse nurse);
    }
}