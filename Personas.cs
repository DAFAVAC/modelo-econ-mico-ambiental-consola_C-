
using System;
using System.IO;
using System.Threading.Tasks;

namespace ModeloEconomico
{
    class Personas : IParalelo
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public float Sueldo { get; set; }



        public float ahorrar(float sueldo, float porcentaje)
        {
            float ahorrado = sueldo*(porcentaje/100);
            return ahorrado;

        }
        public void adeuda(float deuda)
        {
            Console.WriteLine("Yo "+this.Nombre+" me comprometo a cancelar las \n " +
                              " mesualidades con el interes de 43% respecto al valor \n " +
                              " total de " + deuda+" del prestamo realizado");
        }
        public void pagarDeudas()
        {
            Console.WriteLine(this.Nombre + "de las mesualidades con el interes de 43%, en su Banco.");
        }

        public void Seek()
        {
            string directorio = "C:\\";

            string[] ficheros = Directory.GetDirectories(directorio);
            Parallel.ForEach(ficheros, i =>
            {
                Console.WriteLine(i);
            }
            );
            Console.WriteLine("Numero de carpetas: {0}  ", ficheros.GetLength(0));
        }
    }
}
