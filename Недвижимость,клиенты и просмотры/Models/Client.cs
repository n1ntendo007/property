using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Недвижимость_клиенты_и_просмотры.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ClientType { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
