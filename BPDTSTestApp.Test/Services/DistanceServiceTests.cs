using BPDTSTestApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BPDTSTestApp.Test.Services
{
    [TestClass]
    public class DistanceServiceTests
    {
        [TestMethod]
        public void LocationWithin()
        {
            //ARRANGE
            DistanceService distanceService = new DistanceService();

            //ACT
            var result = distanceService.LocationDistance(51.5074, 0.1278, 51.6553959, 0.0572553);

            //ASSERT
            NUnit.Framework.Assert.IsTrue(result < 50);
        }

        [TestMethod]
        public void LocationOutside()
        {
            //ARRANGE
            DistanceService distanceService = new DistanceService();

            //ACT
            var result = distanceService.LocationDistance(51.5074, 0.1278, 34.003135, 117.7228641);

            //ASSERT
            NUnit.Framework.Assert.IsTrue(result > 50);
        }
    }
}
