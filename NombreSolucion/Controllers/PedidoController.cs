using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NombreSolucion.Models.entities;
using NombreSolucion.Models;
using AutoMapper;

namespace NombreSolucion.Controllers;
public class PedidoController : Controller
{    private readonly ILogger<HomeController> _logger;
     private readonly IMapper _mapper;

   static List<Pedido> Pedidos =new List<Pedido>();
       public PedidoController(ILogger<HomeController> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }



   /* PEDIDOS */
    public IActionResult mostrarPedidos(){
        var ListaPVM=_mapper.Map<List<PedidoVM>>(Pedidos);
        return View(ListaPVM);
    }
    [HttpGet]
    public IActionResult altaPedido(){
        return View(new PedidoVM());
    }


    [HttpPost]
    public IActionResult agregarPedido(PedidoVM pedido){
        var Ped=_mapper.Map<Pedido>(pedido);
        Pedidos.Add(Ped);
        return RedirectToAction("mostrarPedidos");
    }


    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
