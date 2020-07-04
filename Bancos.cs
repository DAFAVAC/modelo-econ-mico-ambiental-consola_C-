using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloEconomico
{
    class Bancos
    {
        Random number = new Random();
        public int Id { get { return number.Next(); } set { Id = value; } }
        public string Nombre { get; set; }
        public int Cantidad_Fondos { get; set; }
        public int Cantidad_Empleados { get; set; }
        public string Administrador { get; set; }
        public int Cantidad_Accionistas { get; set; }


        public void prestamos(string deudor , float monto)
        {
            Console.WriteLine("Sr/Srta " + deudor + " su prestamo de " + monto + " en el banco " + this.Nombre);
        }
        public void cobros(string deudor)
        {
            Console.WriteLine("Sr/Srta " + deudor + " le recordamos que tiene una deuda pendiente por el prestamo realiazdo ");
        }
        public void transacciones(string deudor)
        {
            Console.WriteLine("Sr/Srta " + deudor + " le recordamos que tiene una deuda pendiente por el prestamo \n realiazado,por lo que no puede hacer ninguna transaccion ");
        }
        public void transacciones()
        {
            Console.WriteLine("Sr/Srta  comuniquese con nuestros numeros oficiales para realizar su peticion. ");
        }
        public void manejoValores(string persona, float dineroAhorro, float porcentaje)
        {
            Console.WriteLine("Sr/Srta " + persona + ", Banco "+this.Nombre+" empesara a ahorrar "+porcentaje+"%  de su sueldo.");
            Console.WriteLine("Correspondiente a : $ " + dineroAhorro);

        }
    }
}
