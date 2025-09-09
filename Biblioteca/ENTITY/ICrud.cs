using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface ICrud<T>
    {
        string Agregar(T entity);
        List<T> ObtenerTodo();
        bool Actualizar(T entity);
    }
}
