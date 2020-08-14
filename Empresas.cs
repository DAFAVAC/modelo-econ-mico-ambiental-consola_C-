using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ModeloEconomico
{
    class Empresas : IParalelo
    {
        Random number = new Random();
        public int Id { get { return number.Next(); } set { Id = value; } }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Cantidad_Productos { get; set; }
        public string Administrador { get; set; }


        string material = Convert.ToString(ElementEmpresa.Prima);
        Pedidos pedido = new Pedidos();


        public void crearProducto()
        {
            pedido.despachoEmpresa(this.Nombre);
            this.contaminacion();
        }

        public void contaminacion()
        {
            Console.WriteLine("La empresa al trabajar con "+ material + " la cual deja residuos que contaminan el medio ambiente.");
        }

        public void distribuidores(string tienda)
        {
            Console.WriteLine("Sabia que "+tienda + " es distribuidor autorizado de "+this.Nombre);
        }

        public void Seek()
        {
            string direct = "C:\\";

            string[] files = Directory.GetFiles(direct);
            Parallel.ForEach(files, i =>
            {
                Console.WriteLine(i);
            }
            );
            Console.WriteLine("Numero de archivos: {0} . ", files.GetLength(0));
        }
    }
}
