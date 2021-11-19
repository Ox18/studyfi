using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using StudyFi.entity;

namespace StudyFi.Model
{
    public class AdministradorModel
    {
        public static List<AdministradorEntity> findAll()
        {
            List<AdministradorEntity> administradores = new List<AdministradorEntity>();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM administrador";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AdministradorEntity administrador = new AdministradorEntity();
                    administrador.Id = Convert.ToInt32(reader["idAdministrador"]);
                    administrador.Nombre = reader["nombre"].ToString();
                    administrador.Apellido = reader["apellido"].ToString();
                    administrador.Direccion = reader["direccion"].ToString();
                    administrador.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    administrador.Correo = reader["correo"].ToString();
                    administrador.Password = reader["password"].ToString();
                    administrador.Created_at = Convert.ToDateTime(reader["created_at"]);
                    administrador.Updated_at = Convert.ToDateTime(reader["updated_at"]);
                    administradores.Add(administrador);
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
            return administradores;
        }

        public static AdministradorEntity findById(int id)
        {
            AdministradorEntity administrador = new AdministradorEntity();
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM administrador Where idAdministrador = " + id;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    administrador.Id = Convert.ToInt32(reader["idAdministrador"]);
                    administrador.Nombre = reader["nombre"].ToString();
                    administrador.Apellido = reader["apellido"].ToString();
                    administrador.Direccion = reader["direccion"].ToString();
                    administrador.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    administrador.Correo = reader["correo"].ToString();
                    administrador.Password = reader["password"].ToString();
                    administrador.Created_at = Convert.ToDateTime(reader["created_at"]);
                    administrador.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return administrador;
        }

        public static AdministradorEntity findByCorreoAndPassword(string correo, string password)
        {
            AdministradorEntity administrador = null;
            MySqlConnection connection = ConnectionModel.getConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM administrador Where correo = '" + correo + "' and password = '" + password + "';";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    administrador = new AdministradorEntity();
                    administrador.Id = Convert.ToInt32(reader["idAdministrador"]);
                    administrador.Nombre = reader["nombre"].ToString();
                    administrador.Apellido = reader["apellido"].ToString();
                    administrador.Direccion = reader["direccion"].ToString();
                    administrador.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    administrador.Correo = reader["correo"].ToString();
                    administrador.Password = reader["password"].ToString();
                    administrador.Created_at = Convert.ToDateTime(reader["created_at"]);
                    administrador.Updated_at = Convert.ToDateTime(reader["updated_at"]);
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
            return administrador;
        }

        public static bool delete(AdministradorEntity administrador)
        {
            MySqlConnection conn = ConnectionModel.getConnection();
            bool isDeleted;
            try
            {
                string query = "delete from administador where idAdministrador = " + administrador.Id;
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

        public static bool update(AdministradorEntity administrador)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "UPDATE administrador SET nombre = @nombre, apellido" +
                " = @apellido, direccion = @direccion, " +
                "fechaNacimiento = @fechaNacimiento, correo = @correo, " +
                "password = @password WHERE idAdministrador = @id";
            bool isUpdated;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", administrador.Nombre);
                cmd.Parameters.AddWithValue("@apellido", administrador.Apellido);
                cmd.Parameters.AddWithValue("@direccion", administrador.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", administrador.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", administrador.Correo);
                cmd.Parameters.AddWithValue("@password", administrador.Password);
                cmd.Parameters.AddWithValue("@id", administrador.Id);

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

        public static bool save(AdministradorEntity administrador)
        {
            MySqlConnection cn = ConnectionModel.getConnection();
            string query = "INSERT INTO administrador (nombre, apellido" +
                ", direccion, " +
                "fechaNacimiento, correo, " +
                "password) VALUES(@nombre, @apellido, @direccion, @fechaNacimiento, @correo, @password)";
            bool success;
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", administrador.Nombre);
                cmd.Parameters.AddWithValue("@apellido", administrador.Apellido);
                cmd.Parameters.AddWithValue("@direccion", administrador.Direccion);
                cmd.Parameters.AddWithValue("@fechaNacimiento", administrador.FechaNacimiento);
                cmd.Parameters.AddWithValue("@correo", administrador.Correo);
                cmd.Parameters.AddWithValue("@password", administrador.Password);

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