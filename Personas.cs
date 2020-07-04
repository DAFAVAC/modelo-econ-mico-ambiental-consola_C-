
using System;

namespace ModeloEconomico
{
    class Personas
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
    }
}
