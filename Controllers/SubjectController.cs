using EFMVC.Context;
using EFMVC.Models;
using EFMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;

        public SubjectController(ISubjectServices _iss)
        {
            this.iss = _iss;
        }

        public IActionResult Index()
        {
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id)
        {
            iss.DeleteSubject(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(string subjectName, string subjectTerm, int subjectCredits)
        {
            if (subjectName == null)
            {
                return View("Error");
            }

            iss.CreateSubject(subjectName, subjectTerm, subjectCredits);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            return View("Edit", iss.GetEditSubject(id));
        }

        public IActionResult Details(int id)
        {
            return View("Details", iss.GetDetailSubject(id));
        }

        [HttpPost]
        public IActionResult Edit(Subject subject)
        {

            if (subject == null)
            {
                return View("Error");
            }

            iss.EditSubject(subject);
            return RedirectToAction("Index");
        }

    }
}
