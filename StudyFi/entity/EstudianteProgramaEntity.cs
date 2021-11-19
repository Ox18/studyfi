using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class EstudianteProgramaEntity
    {
        private int id;
        private int idEstudiante;
        private int idPrograma;
        private DateTime createdAt;
        private DateTime updatedAt;

        public EstudianteProgramaEntity() { }

        public EstudianteProgramaEntity(int id, int idEstudiante, int idPrograma, DateTime createdAt, DateTime updatedAt)
        {
            this.Id = id;
            this.IdEstudiante = idEstudiante;
            this.IdPrograma = idPrograma;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public int Id { get => id; set => id = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int IdPrograma { get => idPrograma; set => idPrograma = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}