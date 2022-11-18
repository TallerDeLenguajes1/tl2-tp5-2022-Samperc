namespace NombreSolucion.Models.entities;
using System.Collections.Generic;
public class Cadete {
     int ID;
    string nombre;
    string Telefono;

    static int Id=0;
    List<Pedido> Pedidos  { get; set;}
    public int id {get=>ID;}
    public string Nombre{set=>nombre=value;get=>nombre;} 
    public string telefono{set=>Telefono=value;get=>Telefono;}
    //public List<Pedido> Pedidoss {get=>Pedidos;}
    public Cadete(){
        this.ID=Id++;
        this.Telefono="111111";
    }
    public Cadete(string nombre,string Telefono){ 
        this.ID=Id++;
        this.nombre=nombre;
        this.telefono=Telefono;
       //Pedidos=new List<Pedido>();
    }
     public void AsignarPedido(Pedido p){
        Pedidos.Add(p);
    }
    
}