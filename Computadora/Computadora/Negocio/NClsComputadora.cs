using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.Entidades;

namespace Computadora.Negocio
{
    class NClsComputadora
    {



        public String Apagar(ClsComputadora computadora)
        {
            return "Se esta apagando el equipo " + computadora.MemoriaRam;

        }

        public String monitor(ClsComputadora computadora)
        {
            return "El monitor no esta conectado " + computadora.Monitor;

        }

        public String tarjeta(ClsComputadora computadora)
        {
            return "La tarjeta grafica esta fallando " + computadora.TarjetaGrafica;

        }

        public String mouse(ClsComputadora computadora)
        {
            return "El mouse no esta conectado " + computadora.Mouse;
        }




    }





}
