using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Data
{
    public static class UserPremiumDataManager
    {
        public static void SaveName(UserPremium PersonalInformation) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalInformation.Name);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void UpdateName(UserPremium PersonalInformation)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalInformation.Name);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static List<UserPremium> GetALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<UserPremium>();
        }
        public static UserPremium GetName(string name)
        {
            UserPremium PersonalInformation = new UserPremium("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            return PersonalInformation;
        }
        public static bool DeleteName(string name)
        {
            UserPremium PersonalInformation = new UserPremium("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            return true;
        }

    }
}
