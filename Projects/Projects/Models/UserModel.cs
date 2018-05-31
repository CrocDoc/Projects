using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int WorkerNumber { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime LeavingDate { get; set; }

    }
}
