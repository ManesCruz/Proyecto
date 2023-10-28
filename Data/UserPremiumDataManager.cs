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

        public static List<UserPremium> getALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<UserPremium>();
        }
        public static UserPremium GetName(string name) 
        {
   
        }


    }
}
