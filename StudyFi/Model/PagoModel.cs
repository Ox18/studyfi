using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using StudyFi.entity;

namespace StudyFi.Model
{
    public class PagoModel
    {
        public static PagoEntity findById(int id)
        {
            PagoEntity pago = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM pago Where idpago = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pago = new PagoEntity();
                    pago.Id = Convert.ToInt32(reader["idpago"]);
                    pago.Costo = Convert.ToDouble(reader["costo"]);
                    pago.IdEstudiante = Convert.ToInt32(reader["idEstudiante"]);
                    pago.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    pago.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    pago.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return pago;
        }


        public static List<PagoEntity> findAll()
        {
            List<PagoEntity> pagos = new List<PagoEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM pago";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PagoEntity pago = new PagoEntity();
                    pago.Id = Convert.ToInt32(reader["idpago"]);
                    pago.Costo = Convert.ToDouble(reader["costo"]);
                    pago.IdEstudiante = Convert.ToInt32(reader["idEstudiante"]);
                    pago.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    pago.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    pago.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);

                    pagos.Add(pago);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return pagos;
        }

        public static List<PagoEntity> findAllByIdEstudiante(int idEstudiante)
        {
            List<PagoEntity> pagos = new List<PagoEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM pago WHERE idEstudiante = " + idEstudiante;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PagoEntity pago = new PagoEntity();
                    pago.Id = Convert.ToInt32(reader["idpago"]);
                    pago.Costo = Convert.ToDouble(reader["costo"]);
                    pago.IdEstudiante = Convert.ToInt32(reader["idEstudiante"]);
                    pago.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    pago.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    pago.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);

                    pagos.Add(pago);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return pagos;
        }

        public static List<PagoEntity> findAllByIdPrograma(int idPrograma)
        {
            List<PagoEntity> pagos = new List<PagoEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM pago WHERE idPrograma = " + idPrograma;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PagoEntity pago = new PagoEntity();
                    pago.Id = Convert.ToInt32(reader["idpago"]);
                    pago.Costo = Convert.ToDouble(reader["costo"]);
                    pago.IdEstudiante = Convert.ToInt32(reader["idEstudiante"]);
                    pago.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    pago.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    pago.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);

                    pagos.Add(pago);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return pagos;
        }

        public static bool delete(PagoEntity pago)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from pago where idpago = " + pago.Id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = cmd.ExecuteReader();
                isDeleted = true;
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();
            }
            return isDeleted;
        }

        public static bool update(PagoEntity pago)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE pago SET costo = @costo, idEstudiante" +
                " = @idEstudiante, idPrograma = @idPrograma WHERE idpago = @id";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@costo", pago.Costo);
                cmd.Parameters.AddWithValue("@idEstudiante", pago.IdEstudiante);
                cmd.Parameters.AddWithValue("@idPrograma", pago.IdPrograma);
                cmd.Parameters.AddWithValue("@id", pago.Id);

                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                isUpdated = true;
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                isUpdated = false;
            }
            finally
            {
                cn.Close();
            }
            return isUpdated;
        }

        public static bool save(PagoEntity pago)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO pago (costo, idEstudiante, idPrograma) VALUES(@costo, " +
                "@idEstudiante, @idPrograma)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@costo", pago.Costo);
                cmd.Parameters.AddWithValue("@idEstudiante", pago.IdEstudiante);
                cmd.Parameters.AddWithValue("@idPrograma", pago.IdPrograma);

                cn.Open();
                cmd.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
                cn.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return success;
        }

    }
}