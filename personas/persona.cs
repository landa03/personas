using System;

namespace Personas
{
    class persona
    {
        string name;
        // public es un modificador de exeso
        public persona (string name) 
        {
            //this se refiere al objeto actual
            this.name = name;
        }
        //metodo
        public void diHola ()
        {
            Console.WriteLine ("hola mi nombre es " + this.name);
        }
        static public string colorDeSangre = "rojo";
        //static no cambia
        static public void printRace ()
        {
            Console.WriteLine("humano");
        }
    }
}
