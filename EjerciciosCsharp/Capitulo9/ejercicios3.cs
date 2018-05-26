using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct Mascota
{
    public string NombreMascota;
    public int EdadMascota;
    public string TipoMascota;

    public Mascota(string nNombreMascota, int nEdadMascota, string nTipoMascota)
    {
        NombreMascota = nNombreMascota;
        EdadMascota = nEdadMascota;
        TipoMascota = nTipoMascota;
    }
}

public struct Dueño
{
    public string NombreDueño;
    public int EdadDueño;
    public Mascota Perro;

    public Dueño(string nNombreDueño, int nEdadDueño, string NM, int EM, string TM)
    {
        NombreDueño = nNombreDueño;
        EdadDueño = nEdadDueño;

        Perro = new Mascota(NM, EM, TM);
    }
}


namespace EjerciciosCsharp.Capitulo9
{
    class ejercicios3
    {
        public void cap9_3()
        {
            Dueño Du;

            Console.Clear();
            Du.NombreDueño = "Edwin";
            Du.EdadDueño = 19;
            Du.Perro.NombreMascota = "cat";
            Du.Perro.TipoMascota = "dog";
            Du.Perro.EdadMascota = 10;
            Console.WriteLine("Nombre del Dueño: " + Du.NombreDueño + "\nEdad del Dueño: " + Du.EdadDueño + "\nNombre de la Mascota: " + Du.Perro.NombreMascota + "\nTipo de Mascota: " + Du.Perro.TipoMascota + "\nEdad de La Mascota: " + Du.Perro.TipoMascota);

            Console.ReadKey();
        }
    }
}
