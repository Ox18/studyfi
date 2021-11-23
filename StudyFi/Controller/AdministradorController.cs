using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyFi.entity;
using StudyFi.Model;

namespace StudyFi.Controller

{
    public class AdministradorController
    {

        public static AdministradorEntity findByCorreoAndPassword(string correo, string password)
        {
            return AdministradorModel.findByCorreoAndPassword(correo, password);
        }

    }
}