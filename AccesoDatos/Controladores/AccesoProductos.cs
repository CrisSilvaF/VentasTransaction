﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Entidades;

namespace AccesoDatos.Controladores
{
    public class AccesoProductos
    {
        // Metodos De Producto (Crear, Actualizar, Eliminar) //
        public void CrearProducto(Productos producto)
        {
            try
            {
                string query = "INSERT INTO Productos" +
                    "(Descripcion,PrecioUnitario) " +
                    "VALUES" +
                    "(@Descripcion,@PrecioUnitario);select scope_identity()";

                using (SqlConnection con = new SqlConnection(Conexion.ConnectionString))
                {
                    SqlTransaction transaction;
                    con.Open();
                    transaction = con.BeginTransaction();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

                            
                            if (!int.TryParse(cmd.ExecuteScalar().ToString(), out int idProducto))
                            {
                                throw new Exception("Ocurrio un error al obtener el id del Producto");
                            }
                            Console.WriteLine("ID: " + idProducto);
                            ProductoExistencia productoExistencia = new ProductoExistencia();
                            productoExistencia.AgregarExistenciaEnCero(con, transaction, idProducto);
                        }
                        //transaction.Commit();
                    }catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /*public void ActualizarProducto(Productos producto)
        {
            try
            {
                string query = "UPDATE Existencias SET Descripcion = @Descripcion, PrecioUnitario = @PrecioUnitario WHERE Id = @Id";

                using (SqlConnection con = new SqlConnection(query))
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                        cmd.Parameters.AddWithValue("@Id", producto.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
        public void EliminarProducto(int id)
        {
            try
            {
                string query = "DELETE FROM Existencias where Id = @Id";

                using (SqlConnection con = new SqlConnection(query))
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Productos> ObtenerProductos()
        {
            try
            {
                List<Productos> productos = new List<Productos>();
                string query = "SELECT * FROM Productos";

                using (SqlConnection con = new SqlConnection(Conexion.ConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        //cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Productos producto = new Productos();

                                    producto.Id = reader.GetInt32(0);
                                    producto.Descripcion = reader.GetString(1);
                                    producto.PrecioUnitario = reader.GetDecimal(2);

                                    productos.Add(producto);
                                    //return producto;
                                }
                            }
                        }
                    }
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
