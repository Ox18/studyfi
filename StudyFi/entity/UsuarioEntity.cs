using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class UsuarioEntity
    {

        private int id;
        private String nombre;
        private String apellido;
        private String direccion;
        private DateTime fechaNacimiento;
        private String correo;
        private String password;
        private DateTime created_at;
        private DateTime updated_at;

        public UsuarioEntity()
        {
        }

        public UsuarioEntity(int id, string nombre, string apellido, string direccion,
            DateTime fechaNacimiento, string correo, string password, DateTime created_at, DateTime updated_at)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.FechaNacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Password = password;
            this.Created_at = created_at;
            this.Updated_at = updated_at;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}