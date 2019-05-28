using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    [MyLogActionFilter]
    public class DemoController : Controller
    {
       
       /* public ActionResult Index()
        {
            return View();
        }
        // GET: Demo
     /*   public ActionResult Index()
        {
            return RedirectToAction("GetAllCustomers", "Process");
        } 
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
	
         [HttpGet]
      public ActionResult Search(){
         var input = "Another Search action";
         return Content(input);  */
      
        [ActionName("CurrentTime")]
        [OutputCache(Duration = 20)]
        public string Time()
        {
            return TimeString();
        }
        [NonAction]
        public string TimeString() { return "time is " + DateTime.Now.ToString("T"); } 
    } 
}