using System.Collections.Generic;
using System.Linq;
using BPDTSTestApp.Models;
using BPDTSTestApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BPDTSTestApp.Test.Services
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void Test_Collect_Correct_Users()
        {
            //ARRANGE
            DistanceService distanceService = new DistanceService();

            UserService userService = new UserService(distanceService);

            var allUsers = new List<User>()
            {
                new User
                {
                    id = 1,
                    First_Name = "Test",
                    Last_Name = "Outside",
                    Email = "Test.Outside@hotmail.com",
                    IP_Address = "192.57.232.111",
                    Latitude = 34.003135,
                    Longitude = -117.7228641,
                },
                new User
                {
                    id = 2,
                    First_Name = "Test",
                    Last_Name = "Within",
                    Email = "Test.Within@hotmail.com",
                    IP_Address = "67.4.69.137",
                    Latitude =  51.6553959,
                    Longitude = 0.0572553,
                },
                new User
                {
                    id = 3,
                    First_Name = "Test",
                    Last_Name = "Inside",
                    Email = "Test.Inside@hotmail.com",
                    IP_Address = "192.57.232.111",
                    Latitude = 34.003135,
                    Longitude = -117.7228641,
                }
            };

            var usersLondon = new List<User>()
            {
                new User
                {
                    id = 3,
                    First_Name = "Test",
                    Last_Name = "Inside",
                    Email = "Test.Inside@hotmail.com",
                    IP_Address = "192.57.232.111",
                    Latitude = 34.003135,
                    Longitude = -117.7228641,
                }
            };

            //ACT
            var result = userService.Users(allUsers, usersLondon);

            //ASSERT
            NUnit.Framework.Assert.AreEqual(2, result.Count());
        }
    }
}
