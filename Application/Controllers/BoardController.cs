using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public string List(int? Id)
        {
            if (Id == null)
                return "Error Message #1";

            return "Board Id : " + Id.Value;
        }
    }
}