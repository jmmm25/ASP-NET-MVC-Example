using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult List(int? Id)
        {
            if (Id == null)
                return Content("Error Message #1");

            DocumentActs documentActs = new DocumentActs();
            var documents = documentActs.GetDocuments();

            return View(documents);
        }
    }
}