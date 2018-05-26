using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            EjerciciosCsharp.Capitulo9.ejercicios1 Tienda = new Capitulo9.ejercicios1();
            EjerciciosCsharp.Capitulo9.ejercicios3 Mascota = new Capitulo9.ejercicios3();
            EjerciciosCsharp.Capitulo9.ejercicios4 Enum = new Capitulo9.ejercicios4();
            EjerciciosCsharp.Capitulo12.ejercicios2 Met = new Capitulo12.ejercicios2();
            EjerciciosCsharp.Capitulo12.ejercicios3 MSDN = new Capitulo12.ejercicios3();


            int opp = 0;

            while (opp != 5)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n\n1-Tienda.\n2-Mascota.\n3-Enumeracion.\n4-Metodo.\n5-MSDN.\n6-Salir.");

                opp = Convert.ToInt16(Console.ReadLine());


                switch (opp)
                {
                    case 1:
                        Console.Clear();
                        Tienda.cap9_1();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Mascota.cap9_3();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Enum.cap9_4();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Met.cap12_2();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        MSDN.cap12_3();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}