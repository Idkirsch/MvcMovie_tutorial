using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class PisController : Controller
    {
        public string Index()
        {
            return "This is my default pee..";
        }
    }
}
