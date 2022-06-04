using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedThread.JsonData
{
    public static class JsonUtil
    {
        public static void ExportJsonToFile(object obj)
        {
            string path = $"..\\..\\..\\..\\files\\result - {DateTime.Now:dd.MM.yyyy HH.mm.ss}.json";
            File.Create(path).Close();

            using var file = new StreamWriter(path, false, Encoding.UTF8);
            file.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
        }
    }
}
