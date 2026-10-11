using Microsoft.AspNetCore.Mvc;
using Practical_7_Feedback_Management.Models;
namespace Practical_7_Feedback_Management.Controllers;
public class FeedbackController : Controller
{
    // Demonstration-only storage: entries are cleared when the application restarts.
    private static readonly List<Feedback> FeedbackEntries = new();

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FeedbackEntries = FeedbackEntries;
        return View(new Feedback());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Feedback feedback)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.FeedbackEntries = FeedbackEntries;
            return View(feedback);
        }
        FeedbackEntries.Insert(0, feedback);
        TempData["SuccessMessage"] = "Thank you! Your feedback has been submitted successfully.";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Error() => View();
}