using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial1.Controllers
{
    [Route("Say")]
    public class MessagesController : Controller
    {
        [Route("{*message}")]
        public IActionResult ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                ViewData["Message"] = "Message Is Empty!";
            } else {
                ViewData["Message"] = message;
            }

            return View();
        }
    }
}