
using WebApplication2.BL;
using WebApplication2.Controllers;
using WebApplication2.DL;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var id = "va";
            var dataContext = new DataContext();
            dataContext.appointments1 = new List<Appointment> {
            new Appointment()
            {
             AppointmentId=1, BabyId=1,NurseId=1,
            } };
            var serv = new AppointmentService(dataContext);
            var cont = new AppointmentController(serv);

            var result = cont.Get(id);

            Assert.NotNull(result);

        }

        [Fact]
        public void GetId_NullId_EXCEPTEException()
        {
            var id = "va";
            var dataContext = new DataContext();
            dataContext.Values = new List<string> { "value1", "value2" };
            var serv = new Service(dataContext);
            var cont = new ValuesController(serv);

            Assert.Throws<ArgumentNullException>(() => cont.Get(null));
        }
    }

}
}