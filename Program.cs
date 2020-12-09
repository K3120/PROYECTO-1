using System; // directivas de código

namespace CALCULADORA_PROYECTO_1    // nombre de mi proyecto
{
    class Program //se utiliza para instanciar sentencias del objeto "program"
    {
        static void Main(string[] args) //se introduce el código que se quiere ejecutar. Lo primero que hay que hacer es DECLARAR LAS VARIABLES QUE SE VAN A UTILIZAR. Función principal
        {

            //DECLARACIÓN DE VARIABLES 
            double nu1 = 0;
            double nu2 = 0;
            double respuesta = 0;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;


            int n = 1;

            try  //control de errores de mi código
            {

                for (int i = 0; i < n; i++)


                {
                    Console.WriteLine("¿QUIERES REALIZAR UNA OPERACIÓN? \n si/no");
                    String resultado = Convert.ToString(Console.ReadLine());

                    if (resultado.ToUpper() == "SI")  // ToUpper() convierte la expresión en mayúscula
                    {

                        Console.Clear(); // sirve para "limpiar" la pantalla cuando el usiario quiera realizar otra operación


                        //Las opciones que le doy a elejir al usuario 

                        Console.WriteLine("--- BIENVENIDO A MI CALCULADORA--- \n" + "Elije una opción: \n" + "1. SUMA \n" + "2. RESTA \n" + "3. MULTIPLICA \n" + "4. DIVIDE \n");
                        String Opcion = Console.ReadLine();

                        // las instrucciones que le doy al usuario

                        Console.WriteLine("Marca un número");
                        nu1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Marca un número");
                        nu2 = Convert.ToDouble(Console.ReadLine());

                        if (nu2==0 && Opcion=="4")  //esto nos sirve para provocar un error en nuestro código por si acaso el usuario decide probar en mi código una instrucción no disponible
                        {
                            throw new ArgumentException("\n SE HA DETECTADO UN ERROR, CONTACTA CON EL SOPORTE TÉCNICO");

                        }

                        switch (Opcion) // switch sirve para la comparacion de las variables con las distintas posibilidades que tenga
                        {
                            case "1": respuesta = nu1 + nu2; Console.WriteLine("El resultado es:" + respuesta); break;
                            case "2": respuesta = nu1 - nu2; Console.WriteLine("El resultado es:" + respuesta); break;
                            case "3": respuesta = nu1 * nu2; Console.WriteLine("El resultado es:" + respuesta); break;
                            case "4": respuesta = nu1 / nu2; Console.WriteLine("El resultado es:" + respuesta); break;
                            default: Console.WriteLine(" Opción Inválida"); break;

                        }
                        n++;

                    }

                    else
                        Console.WriteLine("pulsar otra tecla para salir");


                    Console.ReadKey();
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("NO SE PUEDE REALIZAR LA OPERAZIÓN \n" + error.Message);
                Console.ReadKey();

                //throw: para hacer excepciones

            }
  
                


          
        }

            
       
    }


}