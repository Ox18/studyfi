using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using StudyFi.entity;

namespace StudyFi.Model
{
    public class MateriaModel
    {
        public static List<MateriaEntity> findAll() {
            List<MateriaEntity> materias = new List<MateriaEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM materia";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MateriaEntity materia = new MateriaEntity();
                    materia.Id = Convert.ToInt32(reader["idMateria"]);
                    materia.Nombre = reader["nombre"].ToString();
                    materia.Descripcion = reader["descripcion"].ToString();
                    materia.PhotoUri = reader["photoUri"].ToString();
                    materia.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    materia.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    materia.UpdatedAT = Convert.ToDateTime(reader["updated_at"]);
                    materias.Add(materia);
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
            return materias;

        }

        public static MateriaEntity findById(int id)
        {
            MateriaEntity materia = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM materia Where idMateria = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    materia = new MateriaEntity();
                    materia.Id = Convert.ToInt32(reader["idMateria"]);
                    materia.Nombre = reader["nombre"].ToString();
                    materia.Descripcion = reader["descripcion"].ToString();
                    materia.PhotoUri = reader["photoUri"].ToString();
                    materia.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    materia.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    materia.UpdatedAT = Convert.ToDateTime(reader["updated_at"]);
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
            return materia;
        }

        public static List<MateriaEntity> findAllByIdPrograma(int id)
        {
            List<MateriaEntity> materias = new List<MateriaEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM materia WHERE idMateria = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MateriaEntity materia = new MateriaEntity();
                    materia.Id = Convert.ToInt32(reader["idMateria"]);
                    materia.Nombre = reader["nombre"].ToString();
                    materia.Descripcion = reader["descripcion"].ToString();
                    materia.PhotoUri = reader["photoUri"].ToString();
                    materia.IdPrograma = Convert.ToInt32(reader["idPrograma"]);
                    materia.CreatedAt = Convert.ToDateTime(reader["created_at"]);
                    materia.UpdatedAT = Convert.ToDateTime(reader["updated_at"]);
                    materias.Add(materia);
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
            return materias;

        }

        public static bool delete(MateriaEntity materia)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from materia where idMateria = " + materia.Id;
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

        public static bool update(MateriaEntity materia)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE materia SET nombre = @nombre," +
                "descripcion  = @descripcion, " +
                "photoUri = @photoUri, idPrograma = @idPrograma " +
                " WHERE idMateria = @id";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", materia.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", materia.Descripcion);
                cmd.Parameters.AddWithValue("@photoUri", materia.PhotoUri);
                cmd.Parameters.AddWithValue("@idPrograma", materia.IdPrograma);
                cmd.Parameters.AddWithValue("@id", materia.Id);

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

        public static bool save(MateriaEntity materia)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO materia (nombre, descripcion" +
                ", photoUri, " +
                "idPrograma) VALUES(@nombre, @descripcion, @photoUri, @idPrograma)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", materia.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", materia.Descripcion);
                cmd.Parameters.AddWithValue("@photoUri", materia.PhotoUri);
                cmd.Parameters.AddWithValue("@idPrograma", materia.IdPrograma);
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