using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class MisionColonizacion : Mision
    {
        private List<Equipo> Equipos;
     

        public override int PesoTotal
    {
        get
        {
           return Equipos.Sum(x=>x.Peso);
        }
    }
        public MisionColonizacion (string nombre): base(nombre)

        {
           

        }
        public override void Agregar(Equipo equipo)
        {
             if (Equipos is null)
                {
                    Equipos = new List<Equipo>();
                    Equipos.Add(equipo);
           
                }
             else
                Equipos.Add(equipo);
            }
        }

    }



