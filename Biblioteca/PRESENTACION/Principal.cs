using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    internal class Principal
    {
        public void MenuPrincipal()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 6); Console.Write("1. Realizar pedido...");
                Console.SetCursorPosition(20, 8); Console.Write("2. Lista Pedidos...");
                Console.SetCursorPosition(20, 16); Console.Write("0. Salir");
                Console.SetCursorPosition(17, 4); Console.Write("M E N U   P R I N C I P A L");

                Console.SetCursorPosition(20, 20); Console.Write("Seleccione una opción: ");

                Console.SetCursorPosition(44, 20); opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        VistaPedido vistaPedido = new VistaPedido();
                        vistaPedido.MenuPedido();
                        break;
                    case 2:
                        ConsultarTodos();
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
        }

        private void ConsultarTodos()
        {

            ServicioPedido servicioPedido;
            servicioPedido = new ServicioPedido();
            int salto = 0;
            Console.Clear();
            Console.SetCursorPosition(12, 3); Console.WriteLine("L I S T A D O  D E  P E D I D O S");
            Console.SetCursorPosition(15, 5); Console.Write("-------------------------------------------");
            Console.SetCursorPosition(15, 6); Console.WriteLine("ID");
            Console.SetCursorPosition(28, 6); Console.WriteLine("ESTUDIANTE");
            Console.SetCursorPosition(40, 6); Console.WriteLine("LIBRO");
            Console.SetCursorPosition(53, 6); Console.WriteLine("FECHA");
            var lista = servicioPedido.ObtenerTodo();
            if (lista == null)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 8 + salto); Console.Write("no hay datos que mostrar");
                Console.ReadKey();
                return;
            }
            foreach (var item in lista)
            {
                Console.SetCursorPosition(15, 8 + salto); Console.Write(item.Id);
                Console.SetCursorPosition(28, 8 + salto); Console.Write(item.Estudiante);
                Console.SetCursorPosition(40, 8 + salto); Console.Write(item.Libro);
                Console.SetCursorPosition(53, 8 + salto); Console.Write(item.Fecha);
                Console.SetCursorPosition(15, 9 + salto); Console.Write("-------------------------------------------");
                salto++;
            }
            Console.ReadKey();
        }
    }
}
