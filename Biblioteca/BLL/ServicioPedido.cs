using System;
using ENTITY;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPedido : ENTITY.ICrud<Pedido>
    {
        List<Pedido> pedidos;
        PedidoRepository pedidoRepository;

        public ServicioPedido()
        {
            pedidoRepository = new PedidoRepository();
            pedidos = pedidoRepository.ObtenerTodas();

            if(pedidos == null)
            {
                pedidos = new List<Pedido>();
            }
        }
        public bool Actualizar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Pedido entity)
        {
            var mensaje = pedidoRepository.Agregar(entity);
            pedidos = pedidoRepository.ObtenerTodas();
            return mensaje;
        }

        public List<Pedido> ObtenerTodo()
        {
            return pedidos;
        }
    }
}
