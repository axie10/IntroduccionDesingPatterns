using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionDesingPatterns

{

    class Program
    {
        static void Main(string[] arg)
        {
            var pato = new Pato();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var gallina = new Gallina();

            var aves = new List<IVolador>();

            aves.Add(pato);
            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(gallina);

            AVolar(aves);
        }

        static void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Volar();
            }
        }

        interface IVolador
        {
            void Volar();
        }

        interface ICaminador
        {
            public void Caminar();
        }

        public class Pato : IVolador, ICaminador
        {
            public void Volar()
            {
                Console.WriteLine("Estoy volando");
            }

            public void Caminar()
            {
                Console.WriteLine("Estoy caminando");
            }
        }

        public class Gallina : IVolador, ICaminador
        {
            public void Volar()
            {
                Console.WriteLine("Estoy volando gallina");
            }

            public void Caminar()
            {
                Console.WriteLine("Estoy caminando");
            }
        }


    }

 

    


    

}
