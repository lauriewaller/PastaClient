// using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PastaClient.Models;

namespace PastaClient.Controllers
{
  public class PastasController : Controller
  {
    public IActionResult Index()
    {
      var allPastas = Pasta.GetPastas();
      return View(allPastas);
    }
    [HttpPost]
    public IActionResult Index(Pasta pasta)
    {
      Pasta.Post(pasta);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var pastaDetail = Pasta.GetDetails(id);
      return View(pastaDetail);
    }

    public IActionResult Edit(int id)
    {
      var pasta = Pasta.GetDetails(id);
      return View(pasta);
    }

    [HttpPost]
    public IActionResult Details(int id, Pasta pasta)
    {
      pasta.PastaId = id;
      Pasta.Put(pasta);
      return RedirectToAction("Details", id);
    }
    public IActionResult Delete(int id)
    {
      Pasta.Delete(id);
      return RedirectToAction("Index");
    }
  }
}