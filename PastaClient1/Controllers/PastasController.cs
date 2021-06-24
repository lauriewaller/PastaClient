// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PastaClient.Models;
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
  }
}