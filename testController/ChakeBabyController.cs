//using WebApplication2.BL;
//using WebApplication2.Controllers;
//using WebApplication2.DL;
//namespace testController




//{
//    internal class ChakeBabyController
//    {
//        private readonly DataContext _dataContext;
//        private readonly BabyService _babyService;
//        private readonly BabyController _babyController;
//        public ChakeBabyController()
//        {
//            // יצירת אובייקט DataContext ו-BabyService
//            _dataContext = new DataContext();
//            _babyService = new BabyService(_dataContext);
//            _babyController = new BabyController(_babyService);
//        }
//        [Fact]
//        public void GetId_Negative_ExcceptException()
//        {
//            _dataContext.Babies = new List<Baby> { new Baby(-15, "shalom", new List<Appointment>()) };
//            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _babyController.GetById(-1));
//            Assert.Equal("BabyId cannot be less than zero. (Parameter 'id')", exception.Message);
//        }
//    }
//}
