using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class CodeQuizController : Controller
    {
        // GET: CodeQuiz
        public ActionResult Index()
        {

            return View(new DataMethods().GetCodeQuizzes());
        }
    }
}