using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace CalendarWebApp.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string SysID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventCreationDateTime { get; set; }
        public DateTime EventPlannedDateTime { get; set; }
        public UserViewModel Creator { get; set; }
        public List<UserViewModel> Attendees { get; set; }
        public int AttendeesCounter { get; set; }

    }
}
