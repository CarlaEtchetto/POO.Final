namespace Biblioteca

{
    public class MisionInvestigacion : Mision
    {
        public Rover rover{get;set;}
      
    public override int PesoTotal
    {
        get
        {
            return this.rover.Peso;
        }
    }


        public MisionInvestigacion (string nombre): base(nombre)
        {
           
        }

        public override void Agregar(Equipo equipo)
        {
           this.rover=(Rover)equipo;
    
        }

    }

}