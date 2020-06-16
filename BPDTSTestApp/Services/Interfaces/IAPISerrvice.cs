using BPDTSTestApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPDTSTestApp.Services
{
    public interface IAPISerrvice
    {
        Task<List<User>> GetUsers(string city);
    }
}
