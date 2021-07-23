using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca

{
    public class MisionAprovisionamiento : Mision
    {
        private List<Agua> Agua;
        public List<Agua> _agua { get {return Agua;}}
        
        public override int PesoTotal
    {
        get
        {
         return Agua.Sum(x => x.Peso);
        }
    }
     
        public MisionAprovisionamiento(string nombre): base(nombre)
        {
           
        }

        public override void Agregar(Equipo equipo)
        {
            if (Agua is null)
            {
              Agua = new List<Agua>();
              Agua.Add((Agua)equipo);
            }
            else
            Agua.Add((Agua)equipo);
                    
        }
        
    }
}      


