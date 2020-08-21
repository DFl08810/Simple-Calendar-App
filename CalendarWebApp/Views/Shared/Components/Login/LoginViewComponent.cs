using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarWebApp.Views.Shared.Components
{
    //This view component is responsible for controlling login window at home page of application
    //It is embedded in Home views
    public class LoginViewComponent : ViewComponent
    {
        public LoginViewComponent()
        {
        }
        
        public IViewComponentResult Invoke()
        {
            return View("Login");
        }
    }
}
