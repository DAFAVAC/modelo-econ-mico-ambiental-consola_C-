
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ModeloEconomico
{
    class Pedidos
    {
        Random number = new Random();
        public int Id { get { return number.Next(); } set { Id = value; } }




        public void despachoTienda(string Solisita,string Envia,int pedido) 
        {
            Console.WriteLine(Envia + " despacho "+pedido+" a la tienda "+Solisita );
        }


        public void despachoEmpresa(string empresaSolisita)
        {
            string materia = Convert.ToString(ElementEmpresa.Prima);

            Console.WriteLine(empresaSolisita + " realizo el pedido de materia " + materia);
        }

    }
}
