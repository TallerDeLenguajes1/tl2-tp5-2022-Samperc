using AutoMapper;
using NombreSolucion.Models.entities;
using NombreSolucion.Models;

public class PerfilDeMapeo : Profile {
    public PerfilDeMapeo(){
        CreateMap<Cadete,CadeteVM>().ReverseMap();
        CreateMap<Pedido,PedidoVM>().ReverseMap();
    }

}