using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class ProfesorEntity : UsuarioEntity
    {
        private String especialidad;
        private String nivelAcademico;

        public ProfesorEntity() : base() { }

        public ProfesorEntity(int id, string nombre, string apellido, string direccion,
            DateTime fechaNacimiento, string correo, string password, DateTime created_at, DateTime updated_at, string especialidad, string nivelAcademico)
            : base(id, nombre, apellido, direccion,
            fechaNacimiento, correo, password, created_at, updated_at)
        {
            this.Especialidad = especialidad;
            this.NivelAcademico = nivelAcademico;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string NivelAcademico { get => nivelAcademico; set => nivelAcademico = value; }
    }
}