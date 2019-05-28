using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public string List()
        {
            return "Acesta e procesul";
        }
        public string GetAllCustomers()
        {
            return @"<ul>
      <li>Ali Raza</li>
      <li>Mark Upston</li>
      <li>Allan Bommer</li>
      <li>Greg Jerry</li>
   </ul>";
        }
    }
}