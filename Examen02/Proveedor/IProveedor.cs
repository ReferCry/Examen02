using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen02.Pedidos;

namespace Examen02.Proveedor
{
    public interface IProveedor
    {
        void EnviarPedido(Pedido pedido);
    }

}
