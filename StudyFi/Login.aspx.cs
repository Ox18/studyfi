using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudyFi.util;
using StudyFi.Controller;
using StudyFi.entity;

namespace StudyFi
{
    public partial class Login : System.Web.UI.Page
    {
        public string typeSession = "";
        public string rolName = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.typeSession = Request.QueryString["type"];
            this.rolName = RolUtil.GuessName(typeSession);
            typeAccount.Text = this.rolName;
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            hideError();
            string email = txtUsername.Text;
            string pass = txtPassword.Text;
            try
            {
                if (rolName == "Estudiante")
                {
                    EstudianteEntity estudianteEntity = EstudianteController.findByCorreoAndPassword(email, pass);

                }
                else if (rolName == "Profesor")
                {
                    ProfesorEntity profesorEntity = ProfesorController.findByCorreoAndPassword(email, pass);

                }
                else if (rolName == "Administrador")
                {
                    AdministradorEntity administradorEntity = AdministradorController.findByCorreoAndPassword(email, pass);
                }
                else
                {
                    throw new Exception("Hubo un problema con la web.");
                }
            }catch(Exception ex)
            {
                showError(ex.Message);
            }
        }

        public void loginEstudiante()
        {

        }

        public void loginProfesor()
        {

        }

        public void loginAdministrador()
        {

        }

        public void showError(string text)
        {
            txtAlert.Text = text;
            txtAlert.Visible = true;
        }

        public void hideError()
        {
            txtAlert.Visible = false;
        }
    }
}