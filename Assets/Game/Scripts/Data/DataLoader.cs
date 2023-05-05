using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Game.Scripts.Data
{
    public static class DataLoader
    {
        public static List<APIDataClass> LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<APIDataClass>>(jsonString);
        }
    }
}