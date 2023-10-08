using Microsoft.AspNetCore.Mvc;
using MyPet.Models;

namespace MyPet.Controllers;

public class ConsultaController : Controller
{
    private static List<Consulta> _lista = new();
    private static int _count = 0;

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Consulta consulta)
    {
        consulta.Id = ++_count;
        _lista.Add(consulta);
        TempData["msg"] = "Personagem cadastrado!";
        return RedirectToAction("Cadastrar");
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_lista);
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var lista = _lista.First(con => con.Id == id);
        return View(lista);
    }

    [HttpPost]
    public IActionResult Editar(Consulta consulta)
    {
        var index = _lista.FindIndex(con => con.Id == consulta.Id);
        _lista[index] = consulta;
        TempData["msg"] = "Consulta atualizada";
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Excluir(int id)
    {
        var con = _lista.First(c => c.Id == id);
        _lista.Remove(con);
        TempData["msg"] = "Consulta Removida com sucesso!";
        return RedirectToAction("Index");
    }

}
