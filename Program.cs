using Microsoft.VisualBasic;
using Proyecto.Data;

namespace Proyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserPremium PersonalInformation = new UserPremium("Manuel Esteban Cruz Parra",17,1.85,65,"elevate","crecer","masculine","Kilos");
            Console.WriteLine(PersonalInformation.Name);
            Exercise flexionesrusas = new Exercise("flexiones rusas", 3, 12, "subir y bajar", 0, "colchoneta");
            Console.WriteLine(flexionesrusas.ExerciseName);
            Exercise sentadillas = new Exercise("sentadillas", 3, 12, "subir y bajar", 0, "colchoneta");
            Console.WriteLine(sentadillas.ExerciseName);

            Exercise[] ejercicios = new Exercise[] { flexionesrusas, sentadillas };

            Rutine rutine = new Rutine("empuje", "alta", 1, 1, "Lunes,miercoles y viernes");


            UserPremiumDataManager.SaveName(PersonalInformation);

        }
    }
}