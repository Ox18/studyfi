using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class ProfesorProgramaEntity
    {
        private int id;
        private int idProfesor;
        private int idPrograma;
        private DateTime createdAt;
        private DateTime updatedAt;

        public ProfesorProgramaEntity() { }

        public ProfesorProgramaEntity(int id, int idProfesor, int idPrograma, DateTime createdAt, DateTime updatedAt)
        {
            this.Id = id;
            this.IdProfesor = idProfesor;
            this.IdPrograma = idPrograma;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public int Id { get => id; set => id = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public int IdPrograma { get => idPrograma; set => idPrograma = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}