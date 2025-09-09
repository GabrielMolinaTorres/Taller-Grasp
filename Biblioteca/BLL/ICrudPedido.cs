using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudPedido
    {
            string Agregar(Pedido pedido);
            List<Pedido> ObtenerTodo();
            bool Actualizar(Pedido pedido);
    }
}
