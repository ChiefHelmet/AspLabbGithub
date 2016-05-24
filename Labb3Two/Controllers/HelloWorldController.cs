//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//namespace Labb3Two.Controllers
//{
//    public class HelloWorldController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Labb3Two.Controllers
{
    public class HelloWorldController : Controller
    {
        

        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //ViewData["Welcome"] = "Hello, " + name;
            ViewData["Message"] = "Hello, " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }



        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    //return "This is the Welcome action method...";

        //    return HtmlEncoder.Default.Encode("Hello, " + name + ", NumTimes is: " + numTimes);
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode(
        //        "Hello " + name + ", ID: " + ID);
        //}


    }
}