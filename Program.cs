using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Otro_Final
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al gestior de patentes.\nCrearemos una pila donde almacenaremos los datos que ingreses.");
            Stack pila_patentes = new Stack();
            menu();

            int seleccion()
            {
                int opcion;
                int[] posibles = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
                do
                {
                    Console.WriteLine("Selecciona una opción del menú.");
                    Console.WriteLine("1. Borrar pila.");
                    Console.WriteLine("2. Agregar patente a pila.");
                    Console.WriteLine("3. Eliminar patente."); //Elimina CIMA
                    Console.WriteLine("4. Mostrar las patentes almacenadas.");
                    Console.WriteLine("5. Mostrar la primer patente ingresada."); // PISO de pila
                    Console.WriteLine("6. Mostrar la última patente ingresada."); // CIMA de pila
                    Console.WriteLine("7. Mostrar la cantidad de patentes almacenadas.");
                    Console.WriteLine("8. Buscar patente.");  
                    Console.WriteLine("9. Función"); //Inventar una función. 
                    Console.WriteLine("0. Salir del programa.");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    return opcion;
                } while (posibles.Contains(opcion) == false);
            }

            void menu()
            {
                switch (seleccion())
                {

                    case 1:
                        pila_patentes.Clear();
                        Console.WriteLine("Se han eliminado todas las patentes de la pila.");
                        menu();
                        break;
                    case 2:
                        agregar(ref pila_patentes);
                        menu();
                        break;
                    case 3:
                        eliminar_elemento(ref pila_patentes);
                        menu();
                        break;
                    case 4:
                        mostrar_patentes(ref pila_patentes);
                        menu();
                        break;
                    case 5:
                        mostrar_primera(ref pila_patentes);
                        menu();
                        break;
                    case 6:
                        mostrar_ultima(ref pila_patentes);
                        menu();
                        break;
                    case 7:
                        Console.WriteLine("La pila tiene: {0} patentes cargadas.", cantidad_elementos(ref pila_patentes));
                        menu();
                        break;
                    case 8:
                        buscar(ref pila_patentes);
                        menu();
                        break;
                    case 9:
                        Console.WriteLine("Función");
                        break;
                    case 0:
                        salir();
                        break;
                }
                Console.ReadLine();
            }
        }

        static void salir()
        {
            Console.WriteLine("Muchas gracias.");
            Thread.Sleep(500);
            Environment.Exit(0);
        }

        static void agregar(ref Stack pila)
        {
            string patente;
            string seguir = "si";
            Console.WriteLine("Las patentes a ingresar deben respetar las siguientes condiciones:\n\tLos primeros 3 caracteres deben ser LETRAS\n\tLos últimos 3 caracteres deben ser NÚMEROS\n\tDebe contener 6 (seis) caracteres en total.");
            do
            {
                Console.WriteLine("Ingrese una patente: ");
                patente = Convert.ToString(Console.ReadLine());
                while (patente.Length != 6)
                {
                    Console.WriteLine("Ingrese una patente que respete las condiciones: ");
                    patente = Convert.ToString(Console.ReadLine());
                }
                try
                {
                    string primeros = patente.Substring(0, 3);
                    string segundos = patente.Substring(3);
                    int numeros = int.Parse(segundos);
                    if ((primeros.All(char.IsLetter)) && (numeros.GetType() == Type.GetType("System.Int32")))
                    {
                        patente.ToString();
                        pila.Push(patente);
                    }
                    Console.WriteLine("Desea seguir ingresando patentes? si/no. ");
                    seguir = Console.ReadLine();
                    seguir.ToLower();
                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine("La patente no respeta las condiciones establecidas.");
                    Console.WriteLine("Desea volver a ingresar la patente? si/no: ");
                    seguir = Console.ReadLine();
                    seguir.ToLower();
                    
                }

            } while (seguir == "si");
            Console.WriteLine("Se han agregado las patentes exitosamente.");
            
        }

        static void eliminar_elemento(ref Stack pila)
        {
            string continuar;
            try
            {
                string patente = (string)pila.Pop();
                Console.WriteLine("Se ha eliminado el elemento {0}", patente);
            }
            catch (System.InvalidOperationException e)
            
            {
                Console.WriteLine("La pila está vacía: no puedes eliminar elementos.");
                Console.WriteLine("Desea agregar patentes en la pila? si/no");
                continuar = Console.ReadLine();
                continuar.ToLower();
                if (continuar=="si")
                {
                    agregar(ref pila);
                }
                else
                {
                    salir();
                }
            }

        }

        static void mostrar_patentes(ref Stack pila)
        {
            if (cantidad_elementos(ref pila)> 0)
            {
                foreach (string dato in pila)
                {
                    Console.WriteLine(dato);
                    
                }
            }
            else
            {
                Console.WriteLine("La pila no tiene elementos.");
                Console.ReadLine();
            }
        }

        static void mostrar_primera(ref Stack pila)
        {
            
            int cont = 0;
            foreach (string dato in pila)
            {
                cont++;
                if (cont==cantidad_elementos(ref pila))
                {
                    Console.WriteLine("El primer elemento ingresado es: {0}", dato);
                    
                }
            }
        }

        static void mostrar_ultima(ref Stack pila)
        {
            
            int cont = 0;
            foreach (string dato in pila)
            {
                cont++;
                if (cont==1)
                {
                    Console.WriteLine("El último elemento ingresado es: {0}", dato);
                    
                }
            }
        }

        static int cantidad_elementos(ref Stack pila)
        {
            int cantidad = pila.Count;
            return cantidad;
        }
        
        static void buscar(ref Stack pila)
        {
            string patente;
            string agregamos;
            Console.WriteLine("Ingrese la patente que desea buscar: ");
            patente = Console.ReadLine();
            patente.ToLower();
            try
            {
                string primeros = patente.Substring(0, 3);
                string segundos = patente.Substring(3);
                int numeros = int.Parse(segundos);
                if ((primeros.All(char.IsLetter)) && (numeros.GetType() == Type.GetType("System.Int32")))
                    if (pila.Contains(patente))
                    {
                        Console.WriteLine("La patente: {0}, está en la pila.", patente);
                    }
                    else
                    {
                        Console.WriteLine("La patente: {0}, no está en la pila", patente);
                        Console.WriteLine("Desea agregarla? si/no");
                        agregamos = Console.ReadLine();
                        agregamos.ToLower();
                        if (agregamos == "si")
                        {
                            patente.ToString();
                            pila.Push(patente);
                            Console.WriteLine("Se han agregado las patentes exitosamente.");
                        }
                        else
                            Console.WriteLine("Te redirigimos al menú principal.");
                    }
                
            }
            catch
            {
                Console.WriteLine("El formato de la patente no coincide con el solicitado para esta pila");
                buscar(ref pila);
            }
        }      
    }
}
