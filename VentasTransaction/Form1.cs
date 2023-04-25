using AccesoDatos;
using AccesoDatos.Controladores;
using AccesoDatos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VentasTransaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarVenta();
        }

        private void CrearCliente()
        {
            Clientes cliente = new Clientes();
            cliente.Nombre = "NombrePrueba";
            AccesoClientes accesoClientes = new AccesoClientes();
            accesoClientes.CrearCliente(cliente);
        }

        private void GuardarProducto()
        {
            Productos producto = new Productos();
            producto.Descripcion = "Producto Preuba";
            producto.PrecioUnitario = 10.20m;
            AccesoProductos accesoProductos = new AccesoProductos();
            accesoProductos.CrearProducto(producto);
        }

        //Debemos reubicar este metodo 
        private void GuardarVenta()
        {
            int folioActual = 0;
            Venta venta = new Venta();
            venta.CLienteId = 1;
            venta.Folio = folioActual + 1;
            venta.Fecha = DateTime.Now;

            VentaDetalle producto1 = new VentaDetalle();
            producto1.ProductoId = 1;
            producto1.Cantidad = 1;
            producto1.Descripcion = "Azucar2 kg";
            producto1.PrecioUnitario = 27.00m;
            producto1.Importe = producto1.Cantidad * producto1.PrecioUnitario;

            VentaDetalle producto2 = new VentaDetalle();
            producto2.ProductoId = 2;
            producto2.Cantidad = 1;
            producto2.Descripcion = "Jugo Mango2";
            producto2.PrecioUnitario = 10.00m;
            producto2.Importe = producto2.Cantidad * producto2.PrecioUnitario;

            venta.Conceptos.Add(producto1);
            venta.Conceptos.Add(producto2);

            AccesoVentas accesoVentas = new AccesoVentas();
            accesoVentas.crearVenta(venta);
        }
    }
}
