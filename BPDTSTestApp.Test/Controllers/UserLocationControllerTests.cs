using BPDTSTestApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace BPDTSTestApp.Test.Controllers
{
    [TestClass]
    public class UserLocationControllerTests
    {
        [TestMethod]
        public void Index()
        {
            //ARRANGE
            UserLocationController controller = new UserLocationController();

            //ACT
            var result = controller.Index() as ViewResult;

            //ASSERT
            Assert.IsNotNull(result);
        }
    }
}
