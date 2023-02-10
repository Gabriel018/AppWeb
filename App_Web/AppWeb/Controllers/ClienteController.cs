using AppWeb.Data;
using AppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class ClienteController : Controller
{
    private readonly AppConectionDbContext _db;


    public ClienteController(AppConectionDbContext db)
    {
        _db = db;
    }
  

    public IActionResult Index()
    {   
        IEnumerable<Cliente>Cliente_obj= _db.Clientes;
        return View(Cliente_obj);
    }

}