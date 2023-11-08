using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Proyecto.Data
{
    public static class UserPremiumDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Laura\\Source\\Repos\\ManesCruz\\Proyecto\\Data\\UserPremium.json";
        public static UserPremium AddUserPremium(UserPremium userPremium)
        {
            try
            {
                string currentUserPremiumState = GetFileInfo();
                var jObject = JObject.Parse(currentUserPremiumState);
                userPremium.Id = $"{jObject.Properties().Count() + 1}";
                string userPremiumJson = JsonConvert.SerializeObject(userPremium);
                jObject.Add(userPremium.Id,userPremiumJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outputJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userPremium;     
        }
        private static string GetFileInfo() 
        {
        return File.ReadAllText(DATA_FILE);
        }
        private static void WriteFileInfo(string json) 
        { 
            File.WriteAllText(DATA_FILE,json);
        }
    }
}
