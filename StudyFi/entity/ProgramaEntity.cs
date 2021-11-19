using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyFi.entity
{
    public class ProgramaEntity
    {
        private int id;
        private String nombre;
        private String descripcion;
        private double costo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private String photoUri;
        private DateTime createdAt;
        private DateTime updatedAt;

        public ProgramaEntity(int id, string nombre, string descripcion, double costo, DateTime fechaInicio, DateTime fechaFin, string photoUri, DateTime createdAt, DateTime updatedAt)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.PhotoUri = photoUri;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Costo { get => costo; set => costo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string PhotoUri { get => photoUri; set => photoUri = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}