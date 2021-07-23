
namespace Biblioteca

{
public class Cohete
{
    public string Fabricante {get;set;}
    public Motor Motor {get; set;}

    public Mision Mision {get;}

    public Cohete(string fabricante, Motor motor, Mision mision)
    {
        this.Fabricante=fabricante;
        this.Motor = motor;
        this.Mision = mision;
    }

    public int CalcularCarga()
    {
       var total=0;
       total+= this.Motor.peso;
       total+= this.Mision.PesoTotal;
       return total;
     
    }
}

}
