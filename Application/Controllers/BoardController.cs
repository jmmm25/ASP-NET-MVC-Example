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
            DocumentActs documentActs = new DocumentActs();
            MemberActs memberActs = new MemberActs();
        
            var documents = documentActs.GetDocuments();
            var member = memberActs.GetMember(1);

            // ViewBag 사용법
            // ViewBag.Member = member;

            // ViewData 사용법
            ViewData["Member"] = member;

            return View(documents);
        }
    }
}