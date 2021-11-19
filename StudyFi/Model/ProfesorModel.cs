using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudyFi.entity;

namespace StudyFi.Model
{
    public class ProfesorModel
    {
        public static List<ProfesorEntity> findAll()
        {
            List<ProfesorEntity> profesores = new List<ProfesorEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM profesor";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProfesorEntity profesor = new ProfesorEntity();
                    profesor.Id = Convert.ToInt32(reader["idProfesor"]);
                    profesor.Nombre = reader["nombre"].ToString();
                    profesor.Apellido = reader["apellido"].ToString();
                    profesor.Direccion = reader["direccion"].ToString();
                    profesor.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    profesor.Correo = reader["correo"].ToString();
                    profesor.Password = reader["password"].ToString();
                    profesor.NivelAcademico = reader["nivelAcademico"].ToString();
                    profesor.Especialidad = reader["especialidad"].ToString();
                    profesor.Created_at = Convert.ToDateTime(reader["created_at"]);
                    profesor.Updated_at = Convert.ToDateTime(reader["updated_at"]);
                    profesores.Add(profesor);
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
            return profesores;
        }

        public static ProfesorEntity findById(int id)
        {
            ProfesorEntity profesor = new ProfesorEntity();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM profesor Where idProfesor = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    profesor.Id = Convert.ToInt32(reader["idProfesor"]);
                    profesor.Nombre = reader["nombre"].ToString();
                    profesor.Apellido = reader["apellido"].ToString();
                    profesor.Direccion = reader["direccion"].ToString();
                    profesor.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    profesor.Correo = reader["correo"].ToString();
                    profesor.NivelAcademico = reader["nivelAcademico"].ToString();
                    profesor.Especialidad = reader["especialidad"].ToString();
                    profesor.Password = reader["password"].ToString();
                    profesor.Created_at = Convert.ToDateTime(reader["created_at"]);
                    profesor.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return profesor;
        }

        public static ProfesorEntity findByCorreoAndPassword(string correo, string password)
        {
            ProfesorEntity profesor = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM profesor Where correo = '" + correo + "' and password = '" + password + "';";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    profesor = new ProfesorEntity();
                    profesor.Id = Convert.ToInt32(reader["idProfesor"]);
                    profesor.Nombre = reader["nombre"].ToString();
                    profesor.Apellido = reader["apellido"].ToString();
                    profesor.Direccion = reader["direccion"].ToString();
                    profesor.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    profesor.Correo = reader["correo"].ToString();
                    profesor.Password = reader["password"].ToString();
                    profesor.NivelAcademico = reader["nivelAcademico"].ToString();
                    profesor.Especialidad = reader["especialidad"].ToString();
                    profesor.Created_at = Convert.ToDateTime(reader["created_at"]);
                    profesor.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return profesor;
        }

        public static bool delete(ProfesorEntity profesor)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from profesor where idProfesor = " + profesor.Id;
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

        public static bool update(ProfesorEntity profesor)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE profesor SET nombre = @nombre, apellido" +
                " = @apellido, direccion = @direccion, nivelAcademico = @nivelAcademico, especialidad = @especialidad, " +
                "fechaNacimiento = @fechaNacimiento, correo = @correo, " +
                "password = @password WHERE idProfesor = @id";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", profesor.Apellido);
                cmd.Parameters.AddWithValue("@direccion", profesor.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", profesor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", profesor.Correo);
                cmd.Parameters.AddWithValue("@password", profesor.Password);
                cmd.Parameters.AddWithValue("@nivelAcademico", profesor.NivelAcademico);
                cmd.Parameters.AddWithValue("@especialidad", profesor.Especialidad);
                cmd.Parameters.AddWithValue("@id", profesor.Id);

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

        public static bool save(ProfesorEntity profesor)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO profesor (nombre, apellido" +
                ", direccion, " +
                "fechaNacimiento, correo, " +
                "password, nivelAcademico, especialidad) VALUES(@nombre, " +
                "@apellido, @direccion, @fechaNacimiento, @correo, @password, @nivelAcademico, @especialidad)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", profesor.Apellido);
                cmd.Parameters.AddWithValue("@direccion", profesor.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", profesor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", profesor.Correo);
                cmd.Parameters.AddWithValue("@password", profesor.Password);
                cmd.Parameters.AddWithValue("@nivelAcademico", profesor.NivelAcademico);
                cmd.Parameters.AddWithValue("@especialidad", profesor.Especialidad);

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