// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PastaClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PastaClient.Controllers
{
  public class PastasController : Controller
  {
    public IActionResult Index()
    {
      var allPastas = Pasta.GetPastas();
      return View(allPastas);
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
    public IActionResult Edit(int id, Pasta pasta)
    {
      Console.Out.WriteLine(id);
      Console.Out.WriteLine(pasta);
      pasta.PastaId = id;
      Pasta.Put(pasta);
      return RedirectToAction("Details", id);
    }
  }
}