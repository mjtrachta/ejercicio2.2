using ejercicio2._2;
using System;


namespace ejercicio2
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            JavierList javier = new JavierList();
            

            int n = 10;
            
            int[] javierList = new int[n];

            //cargo el array con 10 elementos
            for (int i = 0; i < n; i++)
            {
                javierList[i] = i + 1;
            }

            bool salir = false;


            while (!salir)
            {
                int nroElementos = javierList.Length;

                int[] newJavierList = new int[nroElementos + 1];

                int newNroElementos = newJavierList.Length;

                javier.Menu();


                try
                {
                    int opcion = Int32.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            javier.OpcionNro(1);
                            javier.PrintL("el número", "agregar");
                            int numeroAlFinal = Int32.Parse(Console.ReadLine());
                            int posicion = nroElementos + 1;

                            javier.Caso(nroElementos, posicion, newJavierList, javierList, numeroAlFinal);

                            javierList = newJavierList;

                            javier.Print(newNroElementos, newJavierList);
                        
                            break;

                        case 2:
                            javier.OpcionNro(2);
                            javier.PrintL("el número", "agregar");
                            int numeroEnPosicion = Int32.Parse(Console.ReadLine());
                            javier.PrintLargo(nroElementos);
                            javier.PrintL("la posición en la", "agregar");
                            int posicion2 = Int32.Parse(Console.ReadLine());

                            javier.Caso(nroElementos, posicion2, newJavierList, javierList, numeroEnPosicion);

                            javierList = newJavierList;

                            javier.Print(newNroElementos, newJavierList);

                            break;


                        case 3:

                            javier.OpcionNro(2);
                            javier.PrintLargo(nroElementos);
                            javier.PrintL("el número", "borrar");
                            int posicion3 = (Int32.Parse(Console.ReadLine()));
                            javier.OpcionNro(3);

                            newJavierList = new int[javierList.Length -1];

                            Console.WriteLine("old" + javierList.Length + "new" + newJavierList.Length);
                            
                            //javierList = javierList.Where(e => e != posicion3).ToArray();

                            javier.Borrar(posicion3,  newJavierList,  javierList);


                            javierList = newJavierList;

                            javier.Print(newJavierList.Length, newJavierList);

                        break;
                        case 4:
                            javier.OpcionNro(4);
                            javier.PrintL("el número", "buscar");
                            int numero4 = Int32.Parse(Console.ReadLine());
                            int ubicacion4 = (Array.IndexOf(javierList, numero4)) + 1;
                            if (ubicacion4 == 0)
                            {
                                Console.WriteLine("El número {0} no se encontró", numero4);
                            }
                            else
                            {
                                Console.WriteLine("El número {0} está en la posición: {1}", numero4, ubicacion4);
                            }

                            break;
                        case 5:
                            javier.OpcionNro(5);

                            javier.PrintL("la posición", "buscar");
                            int ubicacion5 = Int32.Parse(Console.ReadLine());
                            int numero5 = javierList[ubicacion5-1];
                            Console.WriteLine("En la posición {0} esta el número: {1}", ubicacion5, numero5);

                            break;
                        case 6:
                            javier.OpcionNro(5);

                            Array.Sort(javierList);

                            javier.Print(nroElementos, javierList);

                            break;
                        case 7:
                            salir = true;
                            break;

                        default:
                            javier.PrintError();
                            break;
                    }
                }
                catch (Exception)
                {
                    javier.PrintError2();
                }

            }
        }

    }
}

