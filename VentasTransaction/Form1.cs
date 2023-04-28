using AccesoDatos;
using AccesoDatos.Controladores;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                CargarExistencias();
                InitConceptos();
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

        private void CargarExistencias()
        {
            ProductoExistencia existencias = new ProductoExistencia();
            SqlDataAdapter adapter = existencias.ObtenerExistencias();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ProductoExistenciaGrid.DataSource = dt;
            ExistenciasGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
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
                throw new Exception(ex.Message);
            }
        }

        public void EditarCliente()
        {
            if(ClientesGrid.SelectedRows.Count > 0)
            {
                int clienteId;
                if (int.TryParse(ClientesGrid.SelectedRows[0].Cells[0].Value.ToString(), out clienteId))
                {
                    AccesoClientes accesoClientes = new AccesoClientes();
                    string nombre = InputBox.ShowDialog("Nuevo valor::", "Editar cliente");
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        accesoClientes.ActualizarCliente(clienteId, nombre);
                        CargarClientes();
                    }
                    
                }
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

        private void GuardarVenta()
        {

        }

        //Debemos reubicar este metodo 
        private void GuardarVentaOld()
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
                CargarExistencias();
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
                    CargarExistencias();
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

        private void actualizarCliente_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string client = textBox2.Text;
            if (!string.IsNullOrEmpty(client))
            {
                AgregarCliente(client);
                CargarClientes();
            }
        }

        private void EditarExistencia_Click(object sender, EventArgs e)
        {
            //if (ExistenciasGrid.SelectedRows.Count > 0)
            //{
                int ExistenciaId;
                if (int.TryParse(ExistenciasGrid.SelectedRows[0].Cells[0].Value.ToString(), out ExistenciaId))
                {
                    ProductoExistencia productoExistencia = new ProductoExistencia();
                    decimal valor;
                    if (decimal.TryParse(InputBox.ShowDialog("Nuevo Valor:", "Editar Existencia"), out valor))
                    {
                        productoExistencia.ActualizarExistencia(ExistenciaId, valor);
                        CargarExistencias();
                    }

                }
            //}
        }

        private void generarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int folioActual = 0;
                Venta venta = new Venta();
                venta.CLienteId = 1;
                venta.Folio = folioActual + 1;
                venta.Fecha = DateTime.Now;

                for (int i = 0; i < ProductoExistenciaGrid.RowCount; i++)
                {
                    VentaDetalle concepto = new VentaDetalle();
                    concepto.ProductoId = int.Parse(conceptosGrid.Rows[i].Cells[0].Value.ToString());
                    concepto.Descripcion = conceptosGrid.Rows[i].Cells[1].Value.ToString();
                    concepto.Cantidad = decimal.Parse(conceptosGrid.Rows[i].Cells[2].Value.ToString());
                    concepto.PrecioUnitario = decimal.Parse(conceptosGrid.Rows[i].Cells[3].Value.ToString());
                    concepto.Importe = decimal.Parse(conceptosGrid.Rows[i].Cells[4].Value.ToString());
                    venta.Conceptos.Add(concepto);
                }
                AccesoVentas accesoVentas = new AccesoVentas();
                accesoVentas.crearVenta(venta);
            }
            catch (Exception ex)
            {

            }
        }

        private void agregarConcepto_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = conceptosGrid.Rows.Add();
                DataGridViewRow row = conceptosGrid.Rows[rowIndex];
                row.Cells["Id"].Value = ProductoExistenciaGrid.SelectedRows[0].Cells[0].Value;//
                row.Cells["Descripcion"].Value = ProductoExistenciaGrid.SelectedRows[0].Cells[1].Value;
                decimal existencia = decimal.Parse(ProductoExistenciaGrid.SelectedRows[0].Cells[0].Value.ToString());
                decimal cantidad;
                if(decimal.TryParse(cantidadText.Text, out cantidad)){
                    if(cantidad > existencia ) { cantidad = existencia;}
                    if (cantidad <= 0) { cantidad = 1; }

                    row.Cells["Cantidad"].Value = cantidad;
                }
                else
                {
                    row.Cells["Cantidad"].Value = 1;
                }
                decimal precio;
                if (decimal.TryParse(ProductoExistenciaGrid.SelectedRows[0].Cells[2].Value.ToString(), out precio))
                {
                    row.Cells["Precio Unitario"].Value = precio;
                }

                row.Cells["Importe"].Value = cantidad * precio;

                MessageBox.Show("Agregado!", "");
            }catch(Exception ex)
            {
                MessageBox.Show("Error", "");
                throw new Exception(ex.Message);
            }
            
        }

        private void InitConceptos()
        {
            conceptosGrid.Columns.Add("Id", "Id");
            conceptosGrid.Columns.Add("Descripcion", "Descripcion");
            conceptosGrid.Columns.Add("Cantidad", "Cantidad");
            conceptosGrid.Columns.Add("Precio Unitario", "Precio Unitario");
            conceptosGrid.Columns.Add("Importe", "Importe");
        }
    }
}
