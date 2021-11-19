using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class MateriaEntity
    {
        private int id;
        private String nombre;
        private String descripcion;
        private String photoUri;
        private int idPrograma;
        private DateTime createdAt;
        private DateTime updatedAT;

        public MateriaEntity() { }

        public MateriaEntity(int id, string nombre, string descripcion, string photoUri, int idPrograma, DateTime createdAt, DateTime updatedAT)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PhotoUri = photoUri;
            this.IdPrograma = idPrograma;
            this.CreatedAt = createdAt;
            this.UpdatedAT = updatedAT;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string PhotoUri { get => photoUri; set => photoUri = value; }
        public int IdPrograma { get => idPrograma; set => idPrograma = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAT { get => updatedAT; set => updatedAT = value; }
    }
}