using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.web.Models;

namespace Uninove.web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Iuri Eduardo Mendes dos Santos";
        ViewBag.Curso = "Analise de Sistemas";
        ViewBag.Semestre = 1;

        return View("Detalhes/index");
    }
}