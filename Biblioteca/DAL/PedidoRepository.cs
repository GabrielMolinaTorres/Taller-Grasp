using System;
using ENTITY;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidoRepository
    {
        private string ruta = "pedidos.txt";

        public string Agregar(Pedido entity)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine($"{entity.Id}|{entity.Estudiante}|{entity.Libro}|{entity.Fecha}");
                escritor.Close();
                return $"se guardo el pedido con ID #{entity.Id}";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public List<Pedido> ObtenerTodas()
        {
            try
            {
                List<Pedido> lista = new List<Pedido>();
                StreamReader lector = new StreamReader(ruta);

                while (!lector.EndOfStream)
                {
                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Pedido Mappear(string linea)
        {
            Pedido pedido = new Pedido();

            pedido.Id = int.Parse(linea.Split('|')[0]);
            pedido.Estudiante = linea.Split('|')[1];
            pedido.Libro = linea.Split('|')[2];
            pedido.Fecha = DateTime.Parse(linea.Split('|')[3]);
            return pedido;
        }
    }
}
