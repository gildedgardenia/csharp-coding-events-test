using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_test.Controllers
{
    public class EventController : Controller
    {
        [HttpGet]
        [Route("/events")]
        public IActionResult Index()
        {
            List<string> events = new List<string>();

            events.Add("Strange Loop");
            events.Add("Apple WWDC");
            events.Add("Code With Pride");

            ViewBag.Events = events;

            return View();
        }

        [Route("/events/form")]
        public IActionResult AddEventForm(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
