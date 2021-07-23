using System;
using Biblioteca;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*La misión de investigación a la Luna y llevará un “rover”
            como equipamiento.*/
           
            MisionInvestigacion Luna = new MisionInvestigacion("Luna");
            Rover rover = new Rover();
            Luna.Agregar(rover);

            /*La misión de aprovisionamiento a la estación espacial
            llevará dos tanques de agua.*/
            MisionAprovisionamiento EstacionEspacial = new MisionAprovisionamiento("Mision Aprovisionamiento");
            Agua tanque1 = new Agua();
            Agua tanque2 = new Agua();

            EstacionEspacial.Agregar(tanque1);
            EstacionEspacial.Agregar(tanque2);

            /*
            La tercera misión es colonizadora a Marte, para ello
              utilizará un “rover”, un tanque de agua y  un telescopio.*/

 
            MisionColonizacion Colonizar = new MisionColonizacion("Colonizar");

            Rover rover2 = new Rover();
            Agua tanque3  = new Agua();
            Telescopio telecopio = new Telescopio();

            Colonizar.Agregar(rover2);
            Colonizar.Agregar(tanque3);
            Colonizar.Agregar(telecopio);
         
            /*El cohete 1 de la empresa SpaceX, contiene un motor que
            pesa 4 tn y una misión de investigación.*/
            Motor motor = new Motor(4);
            MisionInvestigacion misionSpaceX = new MisionInvestigacion("Mision SpaceX");
            Cohete cohete1 = new Cohete("SpaceX",motor,misionSpaceX);


             /*El cohete 2 de la empresa BlueOrigin, contiene un motor
            que pesa 3 tn y una misión de aprovisionamiento.*/
             Motor motor2 = new Motor(3);
             MisionAprovisionamiento BlueOrigin = new MisionAprovisionamiento("Blue Origin");
             Cohete cohete2 = new Cohete("BlueOrigin",motor2,BlueOrigin);

             /*El cohete 3 de la empresa Virgin Galactic, contiene un
            motor que pesa 5 tn y una misión de colonización.
                */
             Motor motor3 = new Motor(5);
             MisionColonizacion VirginGalactic = new MisionColonizacion("Virgin Galactic");
             Cohete cohete3 = new Cohete("Virgin Galactic",motor3,VirginGalactic);

        }   
    }
}
