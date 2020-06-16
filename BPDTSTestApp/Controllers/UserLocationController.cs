using BPDTSTestApp.Models;
using BPDTSTestApp.Services;
using BPDTSTestApp.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BPDTSTestApp.Controllers
{
    public class UserLocationController : Controller
    {
        HttpClient client;
        IAPISerrvice apiService;
        IDistanceService distanceService;
        IUserService userService;

        public UserLocationController()
        {
            client = new HttpClient();
            apiService = new APIService(client);
            distanceService = new DistanceService();
            userService = new UserService(distanceService);
        }

        public ActionResult Index()
        {
            List<User> allUsers = Task.Run(() => apiService.GetUsers(null)).Result;

            List<User> usersLondon = Task.Run(() => apiService.GetUsers("London")).Result;

            List<User> users = userService.Users(allUsers, usersLondon);

            return View(users);
        }
    }
}
