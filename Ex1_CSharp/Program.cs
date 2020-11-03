using System;

namespace Ex1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Fase 1//

            string nom = "Albert";
            string cognom1 = "Pipió";
            string cognom2 = "Adroher";

            int dia = 5;
            int mes = 3;
            int any = 1987;

            Console.WriteLine($"{cognom1} {cognom2}, {nom}");

            Console.WriteLine($"{dia}/{mes}/{any}");

            //Fi Fase 1//

            //Fase 2//

            int BISIESTO = 1948;

            int anyBisiesto = BISIESTO + 4;

            int anysTraspas = 0;

            while (anyBisiesto < any)
            {
                anysTraspas++;
                anyBisiesto += 4;
            }

            Console.WriteLine($"Entre el {BISIESTO} i el {any} hi ha {anysTraspas} anys de traspàs.");

            //Fi Fase 2//

            //Fase 3//

            for (int i = BISIESTO; i <= any; i+=4) 
            {
                Console.WriteLine(i);
            }

            string nomComplet = ($"El meu nom és {nom} {cognom1} {cognom2}");
            string dataNaixement = ($"Vaig néixer el {dia}/{mes}/{any}");

            Console.WriteLine(nomComplet);
            Console.WriteLine(dataNaixement);

            string anySi = ("El meu any de naixement és de traspàs");
            string anyNo = ("El meu any de naixement no és de traspàs");

            bool preguntaAny = false;

            if(preguntaAny) Console.WriteLine(anySi);

            else Console.WriteLine(anyNo);

            //Fi Fase 3//

        }
    }
}