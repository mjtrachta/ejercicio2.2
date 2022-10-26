using System;
using System.Linq;

namespace ejercicio2._2
{
    class JavierList
    {
        
        public  void Menu()
        {
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("|   1. Agregar un elemento al final de la lista                    |");
            Console.WriteLine("|   2. Agregar un elemento en alguna posición de la lista          |");
            Console.WriteLine("|   3. Eliminar un elemento                                        |");
            Console.WriteLine("|   4. Buscar un elemento en la lista(devolviendo su posición)     |");
            Console.WriteLine("|   5. Buscar un elemento en la posición de la lista indicada     |");
            Console.WriteLine("|   6. Ordenar los elementos de la lista de menor a mayor          |");
            Console.WriteLine("|   7. Salir                                                       |");
            Console.WriteLine("+------------------------------------------------------------------+");

            Console.WriteLine("|                     Elige una de las opciones:                   |");

            Console.WriteLine("+------------------------------------------------------------------+");

        }
        public void OpcionNro(int n)
        {
            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("|                   Has elegido la opción {0}                 |", n);
            Console.WriteLine("+-----------------------------------------------------------+");
        }

        public void Print(int newNroElementos, int[] newJavierList)
        {
            for (int i = 0; i < newNroElementos; i++)
            {
                Console.WriteLine("|                            {0}                            |", newJavierList[i]);
                Console.WriteLine("+-----------------------------------------------------------+");
            }
        }

        public void Caso(int nroElementos, int posicion, int[] newJavierList, int[] javierList, int numeroAlFinal )
        {

            for (int i = 0; i < nroElementos + 1; i++)
            {
                if (i < posicion - 1)
                {
                    newJavierList[i] = javierList[i];
                }
                else if (i == posicion - 1)
                {
                    newJavierList[i] = numeroAlFinal;
                }
                else
                {
                    newJavierList[i] = javierList[i - 1];
                }
            }
        }

        public void Borrar(int posicion, int[] newJavierList, int[] javierList)
        {
            

            for (int i = 0; i < newJavierList.Length ; i++)
            {
                if (i < posicion - 1)
                {
                    newJavierList[i] = javierList[i];
                }
                else
                {
                    newJavierList[i] = javierList[i+1];
                }
            }
        }

        public void PrintL(string n,string l)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|        Por favor ingresa {0} que desea {1}      ", n,l);
        }

        public void PrintLargo(int nroElementos)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|        Recuerde que la lista tiene {0} elementos         ", nroElementos);
            Console.WriteLine("-----------------------------------------------------------");
        }

        public void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|  ERROR !! Elige una opcion entre 1 y 6  |");
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintError2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|     ERROR Ingrese un número valido.     |");
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        

    }
}
