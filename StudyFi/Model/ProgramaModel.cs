using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudyFi.entity;

namespace StudyFi.Model
{
    public class ProgramaModel
    {
        public static ProgramaEntity findById(int id)
        {
            ProgramaEntity programa = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM programa Where idPrograma = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    programa = new ProgramaEntity();
                    programa.Id = Convert.ToInt32(reader["idPrograma"]);
                    programa.Nombre = reader["nombre"].ToString();
                    programa.Descripcion = reader["descripcion"].ToString();
                    programa.Costo = Convert.ToDouble(reader["costo"]);
                    programa.FechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                    programa.FechaFin = Convert.ToDateTime(reader["fechaFin"]);
                    programa.PhotoUri = reader["photoURI"].ToString();
                    programa.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    programa.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);
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
            return programa;
        }

        public static List<ProgramaEntity> findAll()
        {
            List<ProgramaEntity> programas = new List<ProgramaEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM programa";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProgramaEntity programa = new ProgramaEntity();
                    programa.Id = Convert.ToInt32(reader["idPrograma"]);
                    programa.Nombre = reader["nombre"].ToString();
                    programa.Descripcion = reader["descripcion"].ToString();
                    programa.Costo = Convert.ToDouble(reader["costo"]);
                    programa.FechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                    programa.FechaFin = Convert.ToDateTime(reader["fechaFin"]);
                    programa.PhotoUri = reader["photoURI"].ToString();
                    programa.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    programa.UpdatedAt = Convert.ToDateTime(reader["updated_at"]);

                    programas.Add(programa);
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
            return programas;
        }

        public static bool delete(ProgramaEntity programa)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from programa where idPrograma = " + programa.Id;
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

        public static bool update(ProgramaEntity programa)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE programa SET nombre = @nombre, descripcion = @descripcion, " +
                "costo = @costo, fechaInicio = @fechaInicio, fechaFin = @fechaFin, photoURI = @photoURI WHERE idPrograma = @id";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", programa.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", programa.Descripcion);
                cmd.Parameters.AddWithValue("@costo", programa.Costo);
                cmd.Parameters.AddWithValue("@fechaInicio", programa.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", programa.FechaFin);
                cmd.Parameters.AddWithValue("@photoURI", programa.PhotoUri);
                cmd.Parameters.AddWithValue("@idPrograma", programa.Id);

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

        public static bool save(ProgramaEntity programa)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO programa (nombre, descripcion, costo, fechaInicio, fechaFin, photoURI) " +
                "VALUES(@nombre, " +
                "@descripcion, @costo, @fechaInicio, @fechaFin, @photoURI)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", programa.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", programa.Descripcion);
                cmd.Parameters.AddWithValue("@costo", programa.Costo);
                cmd.Parameters.AddWithValue("@fechaInicio", programa.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", programa.FechaFin);
                cmd.Parameters.AddWithValue("@photoURI", programa.PhotoUri);
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