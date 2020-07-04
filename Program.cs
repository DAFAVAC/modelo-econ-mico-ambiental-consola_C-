using System;
using System.ComponentModel;

namespace ModeloEconomico
{
    class Program
    {
        static void Main(string[] args)
        {
            Personas persona = new Personas();
            Bancos banco = new Bancos();
            Empresas empresa = new Empresas();
            Tiendas tienda = new Tiendas();
            Pedidos pedido = new Pedidos();


            Console.WriteLine("Ingrese sus datos personales:");
            //datos persona
            Console.WriteLine("Numero de Cedula:");
            persona.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            persona.Apellido = Console.ReadLine();
            Console.WriteLine("Edad:");
            persona.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingreso neto mensual:");
            persona.Sueldo = float.Parse(Console.ReadLine());


            //operaciones de Banco
            Console.WriteLine("Nombre de su Banco para ahorros:");
            banco.Nombre = Console.ReadLine();
            Console.WriteLine("¿Desea ahorrar ahora?(si/no)");
            var ahorrara = Convert.ToString(Console.ReadLine());
            if (ahorrara == "si")
            {
                Console.WriteLine("Digite entre 0-100 el porcentaje que desea que se ahorre de su sueldo:");
                float porcentaje = float.Parse(Console.ReadLine());
                var dineroAhorrado = persona.ahorrar(persona.Sueldo, porcentaje);
                banco.manejoValores(persona.Nombre , dineroAhorrado,porcentaje);
            }

            Console.WriteLine("¿Desea hacer un prestamo?(si/no)");
            var respuesta = Convert.ToString(Console.ReadLine());
            if (respuesta == "si" )
            {
                Console.WriteLine("Digite en numeros el monto deseado:");
                float monto = float.Parse(Console.ReadLine());
                banco.prestamos(persona.Nombre, monto);
                persona.adeuda(monto);
            }

            Console.WriteLine("¿Desea hacer un transaccion?(si/no)");
            var respuestaTranssaccion = Convert.ToString(Console.ReadLine());
            if (respuesta == "si" && respuestaTranssaccion == "si")
            {
                banco.transacciones(persona.Nombre);
            }
            if (respuesta == "no" && respuestaTranssaccion == "si")
            {
                banco.transacciones();
            }


            Console.WriteLine("¿Desea conocer sus deudas actuales?(si/no)");
            var deuda_Respuesta = Convert.ToString(Console.ReadLine());
            if (deuda_Respuesta == "si" )
            {
                if (respuesta == "si")
                {
                    banco.cobros(persona.Nombre);
                    persona.pagarDeudas();
                }
                else
                {
                    Console.WriteLine("No tiene deudas.");
                }
            }


            //informacion de empresa
            Console.WriteLine("Nombre de la empresa para la que trabaja:");
            empresa.Nombre = Convert.ToString(Console.ReadLine());
            empresa.Administrador = persona.Nombre;

            Console.WriteLine("¿Conocer mas sobre su empresa?(si/no)");
            var conocer = Convert.ToString(Console.ReadLine());
            if (conocer == "si")
            {
                empresa.crearProducto();
            }


            Console.WriteLine("Nombre de la tiena mas proxima a su casa:");
            tienda.Nombre = Convert.ToString(Console.ReadLine());


            Console.WriteLine("¿Cuantos productos cree que vende la tienda en un dia ?");
            int ventas = Convert.ToInt32(Console.ReadLine());
            tienda.articulosVendidos(ventas);

            Console.WriteLine("NOTA: La empresa por lo general solicita el doble de producto que vende , eso quiere decir que ,\n");
            int pedidostienda = tienda.Pedidos(ventas);
            pedido.despachoTienda(tienda.Nombre , empresa.Nombre , pedidostienda);

            Console.WriteLine("Toma conciencia en el impacto ambiental ,por cada compra que haces ,por un planeta mas limpio. ");
            






















            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
