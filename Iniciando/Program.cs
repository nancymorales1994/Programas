using System;

namespace aperturaDeArchivoConExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Carolina\Desktop\texto.txt";
                archivo = new System.IO.StreamReader(path);

                while ((linea=archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                    
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexion con el fichero cerrada");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Programa terminado");
            Console.ReadLine();
        }

       
    } 
}
