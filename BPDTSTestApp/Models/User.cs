using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BPDTSTestApp.Models
{
    [ExcludeFromCodeCoverage]
    public class User
    {
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "First Name")]
        [Column("first_name")]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        [Column("last_name")]
        public string Last_Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "IP Address")]
        [Column("ip_address")]
        public string IP_Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}