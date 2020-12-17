using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrogWebAPI.Controllers
{
    public class IFrameController : Controller
    {
        public ActionResult Index()
        {
            switch (Request.QueryString["option"])
            {
                case "Swagger":
                    ViewBag.PageOption = "Swagger";
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}