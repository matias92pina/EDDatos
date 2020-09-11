using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_EDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            /*int numA = 200;
            int numB = 56;
            Console.WriteLine(numB + numA);
            Console.ReadLine();*/

            //3
            /*int resultado = 12 * 13;
            Console.WriteLine(resultado);
            Console.ReadLine();*/

            //4
            /*int result = 321 - 123;
            Console.WriteLine(result);
            Console.ReadLine();*/

            //5

            /*float resultado = (20 + 5) % 6;
            Console.WriteLine(resultado);
            Console.ReadLine();*/


            /*double a = 20;
            double b = 5;
            double c = 6;
            double d = (a + b) % c;
            Console.WriteLine(d);
            Console.ReadLine();*/

            /*float A = 20;
            float B = 5;
            float C = 6;
            float D = (A + B) % C;
            Console.WriteLine(D);
            Console.ReadLine();*/

            //6
            /*int A = 12;
            int B = 102;
            int C = A * B;
            Console.WriteLine(C);
            Console.ReadLine();*/

            //7
            /*
            double A = 200;
            double B = 1111;
            double C = A + B;
            Console.WriteLine(C);
            Console.ReadLine();*/

            //8
            /*int numero1 = 10;
            int numero2 = 25;
            Console.WriteLine(numero1 + numero2);
            Console.ReadLine();*/

            //9
            //Vamos a solicitarle al usuario que ingrese datos
            /*int A;
            int B;
            int producto;
            Console.Write("Ingrese el valor de A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de B:");
            B = Convert.ToInt32(Console.ReadLine());
            producto = A * B;
            Console.WriteLine("El valor del producto es: {0}", producto);
            //FUNDAMENTAL EL {0} PARA QUE ME IMPRIMA EL VALOR DE PRODUCTO
            Console.ReadLine();*/

            //10
            /*int A;
            Console.Write("Ingrese un número entero: ");
            A = Convert.ToInt32(Console.ReadLine());
            if (A% 2 == 0)
                Console.WriteLine("El número: {0}, es Par", A);
            else
                Console.WriteLine("El número: {0}, es Impar", A);
            Console.ReadLine();*/

            //11
            /*int A;
            int B;
            Console.Write("Ingrese el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
                Console.WriteLine("A es mayor que B");
            if (A == B)
                Console.WriteLine("A y B son el mismo número");
            if (A < B)
                Console.WriteLine("B es mayor que A");
            Console.ReadLine();*/

            //11 bis. Acá no tenemos el igual
            /*int A;
            int B;
            Console.Write("Ingrese el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A > B ? "A es mayor que B" : "B es mayor que A");
            Console.ReadLine();*/

            //12
            /*int A;
            int B;
            Console.Write("Ingrese el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (B != 0)
                Console.WriteLine("A/B={0}", A / B;
            if (B == 0)
                Console.WriteLine("No se puede dividir si el dividendo es 0");
            Console.ReadLine();*/

            //13
            /*int num;
            Console.Write("Ingrese un número del 1 al 5");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }
            Console.ReadLine();*/

            //14
            /*int num = 1;
            while (num <=10)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadLine();*/

            //15
            /*int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
            Console.ReadLine();*/

            //16
            /*int num;
            for (num=10; num<=20; num++)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }*/

        }
    }
}
