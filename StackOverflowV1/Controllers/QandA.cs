using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackOverflowV1.Models;

namespace StackOverflowV1.Controllers
{
    public class QandA : Controller
    {
        public IActionResult Index()
        {
            List<Questions> UserQuestions = DAL.GetAllQuestions();
            return View(UserQuestions);
        }
    }
}
