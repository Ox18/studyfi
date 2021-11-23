using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyFi.entity;
using StudyFi.Model;

namespace StudyFi.Controller
{
    public class ProfesorController
    {
        public static ProfesorEntity findByCorreoAndPassword(string correo, string password)
        {
            return ProfesorModel.findByCorreoAndPassword(correo, password);
        }
    }
}