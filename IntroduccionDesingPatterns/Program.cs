// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

namespace IntroduccionDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new PersonaDeportiva("manu", 27, "español", "futbol", "madrid");
            var persona2 = new PersonaDeportiva("pepe", 27, "español", "baloncesto", "barsa");
            Console.WriteLine(persona.Saludar());
            Console.WriteLine(persona2.Saludar());
            Console.WriteLine(persona.Run());
            persona.Run2();
        }
    }


    //el abstrac se utilza para que no se pueda instanciar la clase pero si se pueda heredar otra clase de esta
    abstract class Persona 
    {
        public string Nombre = "";
        public int edad;
        public string nacionalidad = "";

        public Persona(string Nombre_, int edad_, string nacionalidad_ ) 
        {
            Nombre = Nombre_;
            edad = edad_;
            nacionalidad = nacionalidad_;
        }

        public string Saludar() 
        {
            return $"Hola soy {Nombre} tengo {edad} años y soy {nacionalidad}"; 
        }
    }

    //extendemos esta clase de la clase persona con los dos puntos, ya que la clase persona es abstracta
    class PersonaDeportiva : Persona
    {
        public string deporte = "";
        public string equipo = "";

        public PersonaDeportiva(string Nombre_, int edad_, string nacionalidad_, string deporte_, string equipo_) : base(Nombre_, edad_, nacionalidad_)
        {
            deporte = deporte_;
            equipo = equipo_;
        }

        public string Run()
        {
            //Console.WriteLine("Hola soy " + Nombre + " tengo " + edad + " años y soy " + nacionalidad + " y juego al " + deporte + " en el equipo " + equipo);
            return $"Hola soy {Nombre} tengo {edad} años y soy {nacionalidad} y juego al {deporte} en el equipo {equipo}";
        }

        public void Run2()
        {
            Console.WriteLine("Hola soy " + Nombre + " tengo " + edad + " años y soy " + nacionalidad + " y juego al " + deporte + " en el equipo " + equipo);
            //return $"Hola soy {Nombre} tengo {edad} años y soy {nacionalidad} y juego al {deporte} en el equipo {equipo}";
        }
    }
    
}
