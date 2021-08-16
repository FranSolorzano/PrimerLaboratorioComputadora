using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private int memoriaRam;
        private String tarjetaMadre;
        private String procesador;
        private String discoDuro;
        private String teclado;
        private String mouse;
        private String monitor;
        private String tarjetaGrafica;
        private String entradaUsb;
        private String bateria;

        
        public string TarjetaMadre { get => tarjetaMadre; set => tarjetaMadre = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string DiscoDuro { get => discoDuro; set => discoDuro = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string TarjetaGrafica { get => tarjetaGrafica; set => tarjetaGrafica = value; }
        public string EntradaUsb { get => entradaUsb; set => entradaUsb = value; }
        public string Bateria { get => bateria; set => bateria = value; }
        public int MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
    }
}
