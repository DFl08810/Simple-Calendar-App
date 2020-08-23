using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarWebApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string SysID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public DateTime UserCreationDateTime { get; set; }
        public DateTime UserLastLoginDateTime { get; set; }
        public int NumCoursesCreated { get; set; }
    }
}
