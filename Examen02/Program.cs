using System;
using Examen02;
using Examen02.Pedidos;
using Examen02.Proveedor;

IProveedor proveedorElectronico = new ProveedorElectronico();
IProveedor proveedorRopa = new ProveedorRopa();

GestorPedidos gestor = new GestorPedidos();

Pedido pedidoElectronico = new Pedido { TipoProducto = "Electrónico", IdPedido = 1, DescripicionPedido = "Computadora Gamer", CantidadPedido = 2 };
Pedido pedidoRopa = new Pedido { TipoProducto = "Ropa", IdPedido = 2, DescripicionPedido = "Zapatillas Nike", CantidadPedido = 6 };

gestor.EnviarPedidosSegunTipoProducto(pedidoElectronico, proveedorElectronico);
gestor.EnviarPedidosSegunTipoProducto(pedidoRopa, proveedorRopa);

