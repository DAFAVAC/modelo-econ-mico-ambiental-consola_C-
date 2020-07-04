
using System;

namespace ModeloEconomico
{
    public class Tiendas
    {
        Random number = new Random();
        public int Id { get { return number.Next(); } set { Id = value; } }
        public string Nombre { get; set; }
        public string Dueño { get; set; }
        public string Direccion { get; set; }
        public int Cantidad_Empleados { get; set; }

        string material = Convert.ToString(ElementTienda.biberes);
        Pedidos pedido = new Pedidos();

        public void articulosVendidos(int ventas)
        {
            Console.WriteLine("La tienda vende actualmente mas de "+ventas+" "+material+" por dia.");
            this.ganancias();
        }

        public void ganancias()
        {
            Console.WriteLine("Pero la tienda gana entre 10 a 25 centavos por cada producto vendido");
        }
        public int Pedidos(int ventas)
        {
            ventas = 2 * ventas;
            return ventas;

        }


    }


}
