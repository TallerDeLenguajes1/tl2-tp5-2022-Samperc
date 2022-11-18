public class Pedido {
    int Nro  { get; set;}
    string Obs  { get; set;}
    string cliente  { get; set;}
    bool Estado  { get; set;}
    public int numero {get=>Nro;}
    public bool esta_entregado {get=>Estado;}
    
    public Pedido(){}
    public Pedido(int numero,string obs,string Ncliente,bool estado){
        this.Nro=numero;
        this.Obs=obs;
        this.Estado=estado;
        this.cliente=Ncliente;
    }
    public
    void darDeAlta(){
        this.Estado=true;
    }
}