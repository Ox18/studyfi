using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyFi.Model;
using StudyFi.entity;

namespace StudyFi.Controller
{
    public class EstudianteController
    {
        public static EstudianteEntity findByCorreoAndPassword(string correo, string password)
        {
            return EstudianteModel.findByCorreoAndPassword(correo, password);
        }
    }
}