using AccesoDatos;
using AccesoDatos.Controladores;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
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
            
            try
            {
                CargarProductos();
                CargarClientes();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargarProductos()
        {
            AccesoProductos accesoProductos = new AccesoProductos();
            SqlDataAdapter adapter = accesoProductos.ObtenerProductos();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProductosGrid.DataSource = dt;
        }

        private void CargarClientes()
        {
            AccesoClientes accesoClientes = new AccesoClientes();
            SqlDataAdapter adapter = accesoClientes.ObtenerClientes();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ClientesGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string client = textBox2.Text;
            if (!string.IsNullOrEmpty(client))
            {
                AgregarCliente(client);
                CargarClientes();
            }
            
        }

        private void AgregarCliente(string nombreCliente)
        {
            Clientes cliente = new Clientes();
            cliente.Nombre = nombreCliente;
            AccesoClientes accesoClientes = new AccesoClientes();
            accesoClientes.CrearCliente(cliente);
        }

        private void BorrarCLiente()
        {
            try
            {
                int clienteId;
                if (int.TryParse(ClientesGrid.SelectedRows[0].Cells[0].Value.ToString(), out clienteId))
                {
                    AccesoClientes accesoClientes = new AccesoClientes();
                    accesoClientes.EliminarCliente(clienteId);
                    CargarClientes();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void GuardarProducto()
        {
            try
            {
                Productos producto = new Productos();
                producto.Descripcion = descriptionText.Text;
                decimal number;
                if (decimal.TryParse(priceText.Text, out number))
                {
                    producto.PrecioUnitario = number;
                }
                AccesoProductos accesoProductos = new AccesoProductos();
                accesoProductos.CrearProducto(producto);
                descriptionText.Text = "";
                priceText.Text = "";
            }
            catch (Exception ex)
            {

            }
            
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

        private void agregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarProducto();
                CargarProductos();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void borrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int productId;
                if(int.TryParse(ProductosGrid.SelectedRows[0].Cells[0].Value.ToString(), out productId))
                {
                    AccesoProductos accesoProductos = new AccesoProductos();
                    accesoProductos.EliminarProducto(productId);
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void borrarCliente_Click(object sender, EventArgs e)
        {
            BorrarCLiente();
        }
    }
}
