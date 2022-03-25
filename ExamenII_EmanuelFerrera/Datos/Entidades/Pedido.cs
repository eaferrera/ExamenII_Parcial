using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        public Pedido()
        {
        }

        public Pedido(int codigo, string cliente, int cantidad, decimal subTotal, decimal impuesto, decimal total)
        {
            Codigo = codigo;
            Cliente = cliente;
            Cantidad = cantidad;
            SubTotal = subTotal;
            Impuesto = impuesto;
            Total = total;
        }
    }
}
