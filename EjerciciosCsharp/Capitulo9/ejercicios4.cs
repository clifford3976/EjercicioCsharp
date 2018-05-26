using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCsharp.Capitulo9
{
    class ejercicios4
    {
        public enum Neumaticos { Para_Coche, Para_Furgoneta, Para_4X4 };
        public void cap9_4()
        {

            Console.Clear();
            Console.WriteLine("Tipos de Neumaticos: \n\n");
            Console.WriteLine(Neumaticos.Para_4X4.ToString());
            Console.WriteLine(Neumaticos.Para_Coche.ToString());
            Console.WriteLine(Neumaticos.Para_Furgoneta.ToString());

            Console.ReadKey();
        }
    }
}
