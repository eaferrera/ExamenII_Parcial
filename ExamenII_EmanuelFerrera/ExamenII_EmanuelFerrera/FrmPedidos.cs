using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenII_EmanuelFerrera
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        Pedido pedidos = new Pedido();
        ProductoDA productosDA = new ProductoDA();
        Producto producto;

        List<Pedido> pedidoLista = new List<Pedido>();

        decimal subTotal = decimal.Zero;
        decimal impuesto = decimal.Zero;
        decimal total = decimal.Zero;

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            EventoLista();
        }

        private void EventoLista()
        {
            PedidosDataGridView.DataSource = pedidoLista;
        }

        private void CodigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoTextBox.Text))
            {
                producto = new Producto();
                producto = productosDA.GetProductoPorCodigo(CodigoTextBox.Text);
                ProductoTextBox.Text = producto.Descripcion;
                ClienteTextBox.Focus();
            }
            else
            {
                producto = null;
                ProductoTextBox.Clear();
                ClienteTextBox.Clear();
                CantidadTextBox.Clear();
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                Pedido pedidoS = new Pedido();

                pedidos.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                pedidos.Cliente = ClienteTextBox.Text;
                pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);

                subTotal = producto.Precio * pedidos.Cantidad;
                impuesto = subTotal * 0.15M;
                total = subTotal + impuesto;

                pedidos.SubTotal = subTotal;
                pedidos.Impuesto = impuesto;
                pedidos.Total = total;

                SubTotalTextBox.Text = subTotal.ToString();
                ImpuestoTextBox.Text = impuesto.ToString();
                TotalTextBox.Text = total.ToString();

                pedidoLista.Add(pedidos);
                PedidosDataGridView.DataSource = null;
                PedidosDataGridView.DataSource = pedidoLista;

                bool inserto = productosDA.InsertarPedido(pedidos);

                if (inserto)
                {
                    MessageBox.Show("Realizado correctamente el pedido.");
                    CodigoTextBox.Clear();
                    ClienteTextBox.Clear();
                    CantidadTextBox.Clear();
                    SubTotalTextBox.Clear();
                    ImpuestoTextBox.Clear();
                    TotalTextBox.Clear();
                    ProductoTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el pedido.");
                    CodigoTextBox.Clear();
                    ClienteTextBox.Clear();
                    CantidadTextBox.Clear();
                    SubTotalTextBox.Clear();
                    ImpuestoTextBox.Clear();
                    TotalTextBox.Clear();
                    ProductoTextBox.Clear();
                }
            }
        }

        private void ClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(ClienteTextBox.Text))
            {
                CantidadTextBox.Focus();
            }
            else if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(ClienteTextBox.Text))
            {
                MessageBox.Show("Es necesario ingresar el código del cliente.");
            }
        }
    }
}
