using BPDTSTestApp.Models;
using System.Collections.Generic;


namespace BPDTSTestApp.Services.Interfaces
{
    public interface IUserService
    {
        List<User> Users(List<User> allUsers, List<User> loationUsers);
    }
}
