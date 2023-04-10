//comentario lineal

/*
 * Comentario multi linea
 */

using System;

namespace Introduccion
{

    class Programa
    {
        static void Main(string[] args)
        {
            int edadFulanito = 25, edadMargarita = 17;

            edadFulanito -= 3; //hace la operacion sobre la misma variable

            //CONCATENACION DE CADENAS
            Console.WriteLine("La edad de Fulanito es de " + edadFulanito + " años");

            //INTERPOLACION DE STRINGS
            Console.WriteLine($"La edad de Margarita es de {++edadMargarita} años");
            //Codigo leido de izquierda a derecha, si hago un preincremento, sera mostrado en consola
            //sin problema

            /*
            int a, b, c, d;

            a = b = c = d = 2;
            C# nos permite asignarle el mismo valor a todas las variables con esa sintaxis
            
            Una forma mas sencilla de hacerlo, seria la siguiente:
            */

            int a, b, c, d = 2;

            /*
            DECLARACION IMPLICITA DE VARIABLES

            En lugar de especificar el tipo de dato que usara nuestra variable, podemos dejarlo
            como <var>, haciendo que durante la ejecucion se asignen el tipo de variable segun el valor

            No esta permitido cambiar el tipo de dato ni declararla sin inicializarla, una vez que se inicializo, 
            el resto de datos introducidos a la variable deben ser del mismo tipo
            */

            var edadSofi = 12;

            Console.WriteLine($"La edad de Sofi es de {edadSofi} años");

            /*
            CONVERSION EXPLICITA O CASTING
            Para poder pasar los datos de una variable a otra que esta definida con un tipo de dato distinto  

            solamente se antepone entre parentesis a que tipo de dato al que sera convertido
            */

            double temperatura = 38.05;
            int temperaturaGDL;

            temperaturaGDL = (int)temperatura;

            Console.WriteLine($"La temperatura en GDL es de {temperaturaGDL} grados");

            /*
            CONVERSION IMPLICITA

            tabla de conversiones implicitas permitidas en C#
            https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            */
            int habitantes = 100000;
            long habitantes2020 = habitantes;

            Console.WriteLine($"La poblacion de GDL en el año 2020 es de {habitantes2020}");
        }
    }
}
