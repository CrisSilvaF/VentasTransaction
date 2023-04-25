using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class ProductoExistencia
    {
        public void ActualizarExistencia(SqlConnection con, SqlTransaction transaction, VentaDetalle concepto)
        {
            string query = "Update Existencias " +
                    "set Existencia = Existencia-@Cantidad " +
                    "where ProductoId = @ProductoId";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@ProductoId", concepto.ProductoId);
                    cmd.Parameters.AddWithValue("@Cantidad", concepto.Cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }
        public void AgregarExistenciaEnCero(SqlConnection con, SqlTransaction transaction, int productoId)
        {
            string query = "INSERT INTO Existencias (ProductoId, Existencia) " +
                "VALUES (@ProductoId, @Existencia)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@ProductoId", productoId);
                    cmd.Parameters.AddWithValue("@Existencia", 0);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
