using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers;

public class TeacherController(DB db) : Controller
{
    // GET: Teacher/Index
    public IActionResult Index()
    {
        ViewBag.Teachers = db.Teachers; // TODO
        return View();
    }

    // POST: Teacher/Index
    [HttpPost]
    public IActionResult Index(TeacherVM vm)
    {
        if (ModelState.IsValid)
        {
            // TODO
            
            TempData["Info"] = $"Teacher {vm.Id} inserted.";
            return RedirectToAction("Index");
        }

        ViewBag.Teachers = db.Teachers; // TODO
        return View();
    }

    // Manually generate next id
    private string NextId()
    {
        // TODO
        return "";
    }

    // POST: Teacher/Delete
    [HttpPost]
    public IActionResult Delete(string? id)
    {
        var t = db.Teachers.Find(id);

        if (t != null)
        {
            db.Teachers.Remove(t);
            db.SaveChanges();
            TempData["Info"] = $"Teacher {t.Id} deleted.";
        }

        return RedirectToAction("Index");
    }

    // GET: Teacher/Assign
    public IActionResult Assign(string? id)
    {
        var t = db.Teachers
                  .FirstOrDefault(t => t.Id == id); // TODO

        if (t == null)
        {
            return RedirectToAction("Index");
        }

        // TODO
        
        return View(t);
    }

    // POST: Teacher/Assign
    [HttpPost]
    public IActionResult Assign(string? id, string[] subjects)
    {
        var t = db.Teachers
                  .FirstOrDefault(t => t.Id == id); // TODO

        if (t == null)
        {
            return RedirectToAction("Index");
        }

        // TODO
                
        TempData["Info"] = "Subject(s) assigned.";
        return RedirectToAction("Assign");
    }
}
