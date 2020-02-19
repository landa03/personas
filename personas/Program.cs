using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            persona lalo = new persona("lalo");
            lalo.diHola();

            persona polo = new persona ("polo");
            polo.diHola();
            Console.WriteLine("de que color es tu sangre?");
            Console.WriteLine(persona.colorDeSangre);
            persona.printRace();
        }
    }
}
//metodos en mayuscula y variables en minuscula
//para hacer uso de static se usa persona