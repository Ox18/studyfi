using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class PagoEntity
    {
        private int id;
        private double costo;
        private int idEstudiante;
        private int idPrograma;
        private DateTime createdAt;
        private DateTime updatedAt;

        public PagoEntity()
        {

        }

        public PagoEntity(int id, double costo, int idEstudiante, int idPrograma, DateTime createdAt, DateTime updatedAt)
        {
            this.Id = id;
            this.Costo = costo;
            this.IdEstudiante = idEstudiante;
            this.IdPrograma = idPrograma;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public int Id { get => id; set => id = value; }
        public double Costo { get => costo; set => costo = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int IdPrograma { get => IdPrograma; set => IdPrograma = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}