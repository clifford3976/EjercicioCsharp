using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct ProductosMercado
{
    public int CodigoDeBarras;
    public string NombreProducto;
    public int PrecioProducto;

    public ProductosMercado(int nCodigoDeBarras, string nNombreProducto, int nPrecioProducto)
    {
        CodigoDeBarras = nCodigoDeBarras;
        NombreProducto = nNombreProducto;
        PrecioProducto = nPrecioProducto;
    }
}

namespace EjerciciosCsharp.Capitulo9
{
    class ejercicios1
    {
        public void cap9_1()
        {
            ProductosMercado PM;

            Console.Clear();
            PM.CodigoDeBarras = 09594978;
            PM.NombreProducto = "JUGO";
            PM.PrecioProducto = 100;
            Console.WriteLine("Codigo de Barras: " + PM.CodigoDeBarras + "\nNombre del Producto: "
                              + PM.NombreProducto + "\nPrecio del Producto: " + PM.PrecioProducto);
            Console.ReadKey();
        }
    }
}
            