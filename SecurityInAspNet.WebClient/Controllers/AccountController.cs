using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;



namespace SecurityInAspNet.WebClient.Controllers
{
    public class AccountController : Controller
    {

        public AccountController()
        {

        }

        //[HttpPost]
        //public async Task Logout()
        //{
        //    await HttpContext.SignOutAsync("oidc");
        //    await HttpContext.SignOutAsync("Cookie");
        //}

        public IActionResult Logout()
        {
            return new SignOutResult(new string[] { "oidc", "Cookies" });
        }
    }
}
