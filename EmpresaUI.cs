using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MODULO1
{
    public class EmpresaUI
    {
        const int ANCHO = 50;
        private CRUDEmpresas ?crud;

        MensajeUI message = new MensajeUI(50);


        public EmpresaUI()
        {
            crud = new CRUDEmpresas();
        }

      

        private void MensajeOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"ESCOGIÓ LA OPCIÓN REGISTRAR");
                    break; 
                case 2:
                    Console.WriteLine($"ESCOGIÓ LA OPCIÓN MOSTRAR");
                    break;  
                case 3:
                    Console.WriteLine($"ESCOGIÓ LA OPCIÓN ACTUALIZAR");
                    break;   
                case 4:
                    Console.WriteLine($"ESCOGIÓ LA OPCIÓN ELIMINAR");
                    break;  
              default: Console.WriteLine("OPCIÓN INCORRECTA");
                    break;

            }
        }

        public void MenuPrincipal()
        {


            int option = 0;
            while (option != 5)
            {
                Console.Clear();
                message.MostrarTitulo("ESCOGER MENÚ");
                Console.WriteLine(@"
                [1] MOSTRAR EMPRESA                
                [2] REGISTRAR EMPRESA                
                [3] ACTUALIZAR EMPRESA                
                [4] ELIMINAR EMPRESA                
                [5] SALIR
                ");
                message.MostrarTitulo("INGRESAR OPCIÓN");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                    MensajeOpcion(option);
                        crud.MostrarEmpresas();
                        break;
                    case 2:
                    MensajeOpcion(option);
                        crud.RegistrarEmpresa();
                        break;
                    case 3:
                    MensajeOpcion(option);
                        crud.ActualizarEmpresa();
                        break;
                    case 4:
                    MensajeOpcion(option);
                        crud.EliminarEmpresa();
                        break;

                   default :

                        MensajeOpcion(option);
                        break;
                }



                Console.WriteLine($"OPCION : {option}");
                System.Threading.Thread.Sleep(1000);

            }
            crud.GuardarEmpresa();
            Console.Clear();
            message.MostrarTitulo("SALIR SISTEMA");
        }










    }
}
