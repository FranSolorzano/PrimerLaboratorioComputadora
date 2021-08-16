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
            return "El equipo " + computadora.MemoriaRam + "Se esta apagando ";

        }

        public String monitor(ClsComputadora computadora)
        {
            return "El monitor "+ computadora.Monitor + "no esta conectado ";

        }

        public String tarjeta(ClsComputadora computadora)
        {
            return "La tarjeta grafica " + computadora.TarjetaGrafica + "esta fallando ";

        }

        public String mouse(ClsComputadora computadora)
        {
            return "El mouse  " + computadora.Mouse + "No esta conectado ";
        }

        public String Encender(ClsComputadora computadora)
        {
            return "La computadora con memoria RAM de " + computadora.MemoriaRam + "y micro procesador " + computadora.Procesador + "esta encendida"; 

        }
    }




}
