using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace CRUD_MODULO1
{
    internal class CRUDEmpresas
    {

        private List<Empresa> listaEmpresas= new List<Empresa>();

        MensajeUI msj = new MensajeUI(50);

        private const string FilePath = "empresa.csv";

        public CRUDEmpresas()
        {
            this.CargarEmpresa();



        }

        private  int SearchEnterprise(string option)
        {
            Console.WriteLine($"Ingresar el ruc de la empresa a ´{option}");
            string ruc = Console.ReadLine();

            //Empresa empresa = listaEmpresas.Find(n => n.Ruc.Equals(ruc, StringComparison.OrdinalIgnoreCase));
            int position = listaEmpresas.FindIndex(n => n.Ruc.Equals(ruc, StringComparison.OrdinalIgnoreCase));

            return position;
        }
        public void MostrarEmpresas()
        {
                Console.WriteLine(new string('=',30)+"LISTA DE EMPRESA"+ new string('=', 30));
            foreach(var enterprise in listaEmpresas)
            {
                enterprise.MostrarDatosEmpresa();
            }
        }

        public void RegistrarEmpresa()
        {
            msj.MostrarTitulo("REGISTRAR NUEVA EMPRESA");
            Console.WriteLine("Ingrese RUC:");
            string ruc = Console.ReadLine();
            Console.WriteLine("Ingrese Razon Social:");
            string razon=Console.ReadLine();
            Console.WriteLine("Ingrese Dirección:");
            string direccion = Console.ReadLine();

            Empresa nuevaEmpresa= new Empresa(ruc, razon, direccion);

            listaEmpresas.Add(nuevaEmpresa);
            msj.MostrarTitulo("Empresa registrada Exitosamente !!!");
          

        }

        public void ActualizarEmpresa()
        {

            int position = SearchEnterprise("ACTUALIZAR");


            if (position == -1) {

                this. msj.MostrarTitulo("RUC INGRESADO NO EXISTE, INTENTARLO NUEVAMENTE !");
            }
            else
            {

                Console.WriteLine("Ingrese nuevo RUC");
                Console.WriteLine("Si no deseas actualizar ruc presionar enter");
                string newruc = Console.ReadLine();
                if (string.IsNullOrEmpty(newruc)) newruc = listaEmpresas[position].Ruc;
                Console.WriteLine("Ingrese nueva Razon Social");
                Console.WriteLine("Si no deseas actualizar Razon Social presionar enter");
                string newRazon = Console.ReadLine();
                if (string.IsNullOrEmpty(newRazon)) newRazon = listaEmpresas[position].RazonSocial;
                Console.WriteLine("Ingrese nueva  Dirección");
                Console.WriteLine("Si no deseas actualizar la dirección presionar enter");
                string newdireccion = Console.ReadLine();
                if (string.IsNullOrEmpty(newdireccion)) newdireccion = listaEmpresas[position].Direccion;
                Empresa newEmpresa = new Empresa(newruc, newRazon, newdireccion);

                listaEmpresas.Add(newEmpresa);
            }




        }

        public void EliminarEmpresa()
        {
            int position = SearchEnterprise("ELIMINAR");

            listaEmpresas.RemoveAt(position);
            this.msj.MostrarTitulo("La empresa fue removida exitosamente !");

        }

        public void CargarEmpresa()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader sr = new StreamReader(FilePath)) {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        listaEmpresas.Add(Empresa.FromCsv(line));                   
                    }  


                }
            }

        }



        public void GuardarEmpresa()
        {

            using(StreamWriter sr=new StreamWriter(FilePath))
            {
                foreach (var empresa in listaEmpresas)
                {
                    sr.WriteLine(empresa.convertCSV());
                }


            }


        }








    }
}
