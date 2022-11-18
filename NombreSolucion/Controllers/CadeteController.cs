using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NombreSolucion.Models.entities;
using NombreSolucion.Models;
using AutoMapper;

namespace NombreSolucion.Controllers;

public class CadeteController : Controller
{

    private readonly ILogger<HomeController> _logger;
    private readonly IMapper _mapper;
    public CadeteController(ILogger<HomeController> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }


    public IActionResult altaCadete()
    {
        return View(new CadeteVM());
    }

    static List<Cadete> Cadetes = new List<Cadete>();

    [HttpPost]
    public IActionResult agregarCad(Cadete Cad)
    {
        Cadetes.Add(Cad);
        return RedirectToAction("mostrarCadete");
    }
    

    public IActionResult mostrarCadete()
    {
        try
        {
           

            var ListaCVM = _mapper.Map<List<CadeteVM>>(Cadetes);
            return View(ListaCVM);
        }
        catch (System.Exception )
        {
            return RedirectToAction("Index", "Home");

            throw;
        }


    }

    [HttpGet]
    public IActionResult eliminarCadete(int id)
    {
        var index = Cadetes.FindIndex(T => T.id == id);
        //  c1.nombre=Cadetes[index].Nombre;
        //  c1.Telefono=Cadetes[index].telefono;
        var cadeteVM=_mapper.Map<CadeteVM>(Cadetes[index]);
        return View(cadeteVM);
      }

    
    [HttpGet]
    public IActionResult eliminarCadeteConfirm(int id)
    {
        var index = Cadetes.FindIndex(T => T.id == id);
        Cadetes.RemoveAt(index);
         return RedirectToAction("mostrarCadete");
    }


    /*MODIFICARRRRR*/
    [HttpGet]
    public IActionResult modificarCadete(int id){
    var index = Cadetes.FindIndex(T => T.id == id);

    var cadeteCVM = _mapper.Map<CadeteVM>(Cadetes[index]);

        return View(cadeteCVM);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}