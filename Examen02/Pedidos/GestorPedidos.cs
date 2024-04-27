using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen02.Proveedor;

namespace Examen02.Pedidos
{
    public class GestorPedidos
    {
        public void EnviarPedidosSegunTipoProducto(Pedido pedido, IProveedor proveedor)
        {
            proveedor.EnviarPedido(pedido);
        }
    }
}
