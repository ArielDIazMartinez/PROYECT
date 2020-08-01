    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Program
    {
        static void ESPACIO()

        {
            Console.WriteLine();            // ESPACIOS
        }

        static void Main(string[] args)
        {   
            //Descripcion del programa:

            /*  En el siguiente proyecto crearemos una aplicación que pida al usuario su(username y clave).
            1-  El usuario sera el No.de cedula y la clave debe ser numerica, el sistma no debe permitir que el usuario acceda hasta que ponga su autenticacion correcta.
            2-  El sistema debe tener al menos 3 usuarios registrados para validar, y los usuarios al acceder tendran un rol(Supervisor, Administrador, Vendedor).
            3-  De acuerdo a su rol le mostrara el mensaje al acceder "Acabas de ingresar con el usuario XXXX y su rol es XXXXX.
            4-  Los usuarios algunos tendran un estado de(activo o inactivo) en caso de inactivo sea positivo el usuario no podra acceder,
                el sistema debe mostrar un mensaje que ese usuario esta inactivo y volver a validar otro usuario.
            5-  Datos de usuarios: Nombre, username, clave, rol, fecha de creacion, estado(Activo o inactivo)   */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // VARIABLES 

            string Username;
            int Password;

        

            Console.WriteLine("LOGIN");



            Console.WriteLine("Username: ");                                                  // Username Numero de cedula con guiones 
            Username = Convert.ToString(Console.ReadLine()).ToLower();

            Console.WriteLine("Password: ");                                                  // Password Solo se acepta caracteres numericos como contraseña 
            Password = Convert.ToInt32(Console.ReadLine());


           
            Program.ESPACIO();


            //   PRIMER USUARIO


            if (Username.Equals ("304-27189182-1") && Password == 123456)                                     // USUARIO 1 > 304-271889182-1
            {
                Console.WriteLine("Acabas de ingresar con el usuario LUIS y su rol es Supervisor.");


                Program.ESPACIO();


                Console.WriteLine("Nombre: Luis Mendez");
                Console.WriteLine("Estado: Activo");
                Console.WriteLine("Fecha de Creacion: 18-06-2019");


               

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Segundo Usuario

            Program.ESPACIO();

            if (Username.Equals("402-918928938-4") && Password == 123456)                                      //USUARIO 2  >  402-918928938-4"
            {
                Console.WriteLine("Acabas de ingresar con el usuario ARIEL y su rol es Administrador.");

                Program.ESPACIO();


                Console.WriteLine("Nombre: Ariel Diaz");
                Console.WriteLine("Estado: Activo");
                Console.WriteLine("Fecha de Creacion: 06-01-2020");

            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Tercer Usuario


            Program.ESPACIO();


            if (Username.Equals("102-3927839289-4") && Password == 123456)                                    // USUARIO 3 > 102-3927839289-4
            {
                Console.WriteLine("Acabas de ingresar con el usuario RAMON y su rol es Vendedor.");

                Program.ESPACIO();
                Console.WriteLine("SE HA DETECTADO UN ERROR EN EL USUARIO PRECIONE ENTER para ver el Estado");
                Console.ReadKey();
                Console.WriteLine("Estado: Inactivo");
                Console.WriteLine("Fecha de creacion: 12-01-2009");
                Console.WriteLine("Fecha de expiracion: 19-07-2020");

                Program.ESPACIO();

                Console.WriteLine("VUELVA A VALIDAR OTRO USUARIO");
            }



            else if (Username.Equals("304-271889182-1") && Password != 123456 || Username.Equals("402-918928938-4") && Password != 123456 || Username.Equals("102-3927839289-4") && Password != 123456)    
            {
                Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTA INTENTE NUEVAMENTE");
            }

           
            Console.ReadKey();
        }
    }
}
