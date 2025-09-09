using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class VistaPedido
    {
        ServicioPedido servicioPedido;
        public VistaPedido()
        {
            servicioPedido = new ServicioPedido();
        }
        public void MenuPedido()
        {
            string Nombre, Libro;

            Console.Clear();
            Console.SetCursorPosition(20, 4); Console.WriteLine("R E A L I Z A R  P E D I D O");
            Console.SetCursorPosition(20, 6); Console.WriteLine("Nombre Estudiante:");
            Console.SetCursorPosition(20, 8); Nombre = Console.ReadLine();
            Console.SetCursorPosition(20, 10); Console.WriteLine("Nombre Libro:");
            Console.SetCursorPosition(20, 12); Libro = Console.ReadLine();

            if(Libro == "" || Nombre == "")
            {
                Console.SetCursorPosition(20, 14); Console.WriteLine("No se aceptan campos nulos");
                Console.ReadKey();
                return;
            }

            Pedido pedido = new Pedido() {
                Id = servicioPedido.ObtenerTodo().Count + 1,
                Estudiante = Nombre,
                Libro = Libro,
                Fecha = DateTime.Now
            };

            var mensaje = servicioPedido.Agregar(pedido);
        }
    }
}
