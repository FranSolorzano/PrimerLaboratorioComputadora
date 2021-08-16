using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();

            clscomputadora.MemoriaRam = 8;
            clscomputadora.Monitor = "CRT";
            clscomputadora.Mouse = "Laser";
            clscomputadora.Procesador = "Intel";
            clscomputadora.TarjetaGrafica = "MDA";
            clscomputadora.TarjetaMadre = "ATX";
            clscomputadora.Teclado = "RGB";


            Console.WriteLine(nclscomputadora.Encender(clscomputadora));


            Console.ReadLine();
        }
    }
}
