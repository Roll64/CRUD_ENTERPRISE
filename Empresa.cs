using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MODULO1
{
    internal class Empresa
    {
         private string ruc;
         private string razonSocial;
         private string direccion;
     

        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Direccion { get => direccion; set => direccion = value; }
     


        public Empresa(string ruc,string razonSocial, string direccion)
        {
            this.ruc = ruc;
            this.razonSocial = razonSocial;
            this.direccion = direccion;

        }

        public void MostrarDatosEmpresa()
        {
            Console.WriteLine($"El ruc es :{this.ruc}");
            Console.WriteLine($"La Razon Social es :{this.razonSocial}");
            Console.WriteLine($"La Dirección es :{this.direccion}");

        }


        public string  convertCSV()
        {

            return $"{this.ruc},{this.razonSocial},{this.direccion}"; 
        }

        public static Empresa FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            if (values.Length!=3) {
                throw new Exception("El formato csv es incorrecto");                       
            }

            return new Empresa(values[0], values[1], values[2]);




        }






    }





}
