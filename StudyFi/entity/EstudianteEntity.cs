using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class EstudianteEntity : UsuarioEntity
    {
        public EstudianteEntity() : base() { }

        public EstudianteEntity(int id, string nombre, string apellido, string direccion,
            DateTime fechaNacimiento, string correo, string password, DateTime created_at, DateTime updated_at)
            : base(id, nombre, apellido, direccion,
            fechaNacimiento, correo, password, created_at, updated_at)
        {

        }
    }
}