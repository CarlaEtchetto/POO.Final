using System;
using Biblioteca;
namespace Biblioteca

{
    public abstract class Mision
    {
        private string _nombre;
        public abstract int PesoTotal {get;}
     
        public string nombre
        {
            get { return _nombre; }
        }

        public Mision(string nombre)
        {
            this._nombre = nombre;
        }

      
        public abstract void Agregar(Equipo equipo);
     

    }
    
    

}
