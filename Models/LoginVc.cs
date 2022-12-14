using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace v6.Models
{
    public class LoginVc: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
