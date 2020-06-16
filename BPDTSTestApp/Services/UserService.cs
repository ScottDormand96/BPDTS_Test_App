using BPDTSTestApp.Models;
using BPDTSTestApp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BPDTSTestApp.Services
{
    public class UserService : IUserService
    {
        IDistanceService distanceService;

        public UserService(IDistanceService distanceService)
        {
            this.distanceService = distanceService;
        }

        public List<User> Users(List<User> allUsers, List<User> locationUsers)
        {
            List<User> usersWithin = new List<User>();

            foreach (var user in allUsers)
            {
                if (distanceService.LocationDistance(51.5074, 0.1278, user.Latitude, user.Longitude) <= 50)
                {
                    usersWithin.Add(user);
                }
            }

            usersWithin.AddRange(locationUsers);

            return usersWithin.ToList();
        }
    }
}