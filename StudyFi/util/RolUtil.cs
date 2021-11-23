
namespace StudyFi.util
{
    public class RolUtil
    {
        public static string GuessName(string rol = "")
        {
            switch (rol)
            {
                case "student":
                    return "Estudiante";
                case "teacher":
                    return "Profesor";
                case "admin":
                    return "Administrador";
                default:
                   return "Indefinido";
            }
        }
    }
}