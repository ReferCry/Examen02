﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen02.Pedidos;

namespace Examen02.Proveedor
{
    public class ProveedorElectronico : IProveedor
    {
        public void EnviarPedido(Pedido pedido)
        {

            Console.WriteLine($"Enviando productos electronicos-->" +
                $"Id del Producto: {pedido.IdPedido} - " +
                $"Descripción del Producto: {pedido.DescripicionPedido} - " +
                $"Cantidad del producto: {pedido.CantidadPedido}"); 
        }
    }
}
