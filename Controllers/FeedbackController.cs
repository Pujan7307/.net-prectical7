
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        // Display the feedback form
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Feedback());
        }

        // Process submitted feedback
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Success", feedback);
            }

            return View(feedback);
        }
    }
}
