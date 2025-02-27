using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using A2DocWebApplication.Models;

namespace A2DocWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestServiceClient _restServiceClient = new RestServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult>SecretNumberAsync(int x, int y)
        {
            int secNum = await _restServiceClient.SecretNumberAsync(x, y);
            return Json(new { result = secNum });
        }
        [HttpPost]
        public async Task<JsonResult>CheckNumberAsync(int x, int y)
        {
            string checkNum = await _restServiceClient.CheckNumberAsync(x, y);
            return Json(new { result = checkNum });
        }
       
    }
}