using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyFi.entity;
using MySql.Data.MySqlClient;

namespace StudyFi.Model

{
    public class EstudianteModel
    {
        
        public static List<EstudianteEntity> findAll()
        {
            List<EstudianteEntity> estudiantes = new List<EstudianteEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM estudiante";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EstudianteEntity estudiante = new EstudianteEntity();
                    estudiante.Id = Convert.ToInt32(reader["idEstudiante"]);
                    estudiante.Nombre = reader["nombre"].ToString();
                    estudiante.Apellido = reader["apellido"].ToString();
                    estudiante.Direccion = reader["direccion"].ToString();
                    estudiante.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    estudiante.Correo = reader["correo"].ToString();
                    estudiante.Password = reader["password"].ToString();
                    estudiante.Created_at = Convert.ToDateTime(reader["created_at"]);
                    estudiante.Updated_at = Convert.ToDateTime(reader["updated_at"]);
                    estudiantes.Add(estudiante);
                }
            } catch(Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return estudiantes;
        }

        public static EstudianteEntity findById(int idEstudent)
        {
            EstudianteEntity estudiante = new EstudianteEntity();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM estudiante Where idEstudiante = " + idEstudent;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    estudiante.Id = Convert.ToInt32(reader["idEstudiante"]);
                    estudiante.Nombre = reader["nombre"].ToString();
                    estudiante.Apellido = reader["apellido"].ToString();
                    estudiante.Direccion = reader["direccion"].ToString();
                    estudiante.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    estudiante.Correo = reader["correo"].ToString();
                    estudiante.Password = reader["password"].ToString();
                    estudiante.Created_at = Convert.ToDateTime(reader["created_at"]);
                    estudiante.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return estudiante;
        }

        public static EstudianteEntity findByCorreoAndPassword(string correo, string password)
        {
            EstudianteEntity estudiante = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM estudiante Where correo = '" + correo + "' and password = '" + password + "';";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    estudiante = new EstudianteEntity();
                    estudiante.Id = Convert.ToInt32(reader["idEstudiante"]);
                    estudiante.Nombre = reader["nombre"].ToString();
                    estudiante.Apellido = reader["apellido"].ToString();
                    estudiante.Direccion = reader["direccion"].ToString();
                    estudiante.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    estudiante.Correo = reader["correo"].ToString();
                    estudiante.Password = reader["password"].ToString();
                    estudiante.Created_at = Convert.ToDateTime(reader["created_at"]);
                    estudiante.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return estudiante;
        }

        public static bool delete(EstudianteEntity estudiante)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from estudiante where idEstudiante = " + estudiante.Id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = cmd.ExecuteReader();
                isDeleted = true;
                while (reader.Read())
                {

                }
            }catch(Exception ex)
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();
            }
            return isDeleted;
        } 

        public static bool update(EstudianteEntity estudiante)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE estudiante SET nombre = @nombre, apellido" +
                " = @apellido, direccion = @direccion, " +
                "fechaNacimiento = @fechaNacimiento, correo = @correo, " +
                "password = @password WHERE idEstudiante = @idEstudiante";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                cmd.Parameters.AddWithValue("@apellido", estudiante.Apellido);
                cmd.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", estudiante.Correo);
                cmd.Parameters.AddWithValue("@password", estudiante.Password);
                cmd.Parameters.AddWithValue("@idEstudiante", estudiante.Id);

                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                isUpdated = true;
                while (reader.Read())
                {

                }
            }catch(Exception ex)
            {
                isUpdated = false;
            }
            finally
            {
                cn.Close();
            }
            return isUpdated;
        }

        public static bool save(EstudianteEntity estudiante)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO estudiante (nombre, apellido" +
                ", direccion, " +
                "fechaNacimiento, correo, " +
                "password) VALUES(@nombre, @apellido, @direccion, @fechaNacimiento, @correo, @password)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                cmd.Parameters.AddWithValue("@apellido", estudiante.Apellido);
                cmd.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", estudiante.Correo);
                cmd.Parameters.AddWithValue("@password", estudiante.Password);

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