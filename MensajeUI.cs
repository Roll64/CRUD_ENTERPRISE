using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MODULO1
{
    internal class MensajeUI
    {
        private int ancho;
        public MensajeUI(int ancho)
        {

            this.ancho = ancho;


        }
        internal     void MostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', ancho));
            Console.WriteLine(new string('=', 11) + $" {titulo} " + new string('=', 11));
            Console.WriteLine(new string('=', ancho));
        }






    }
}
