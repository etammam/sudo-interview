using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sudo.Application.Persistence.Extensions;

namespace Sudo.Application.Persistence
{
    public class StoreManager : IStore
    {
        private const string StorageLocation = "wwwroot\\database";
        public string GenerateNewJsonFile()
        {
            Direction.ValidateStorage();
            var newFileName = Guid.NewGuid().ToString().Replace("-", string.Empty) + ".json";
            var filePath = Path.Combine(Direction.GetCurrentDirectory(), StorageLocation, newFileName);
            return filePath;
        }

        public void StoreToJson(object value)
        {
            if (value != null)
            {
                var jsonPath = GenerateNewJsonFile();
                var stringfiy = JsonConvert.SerializeObject(value,Formatting.Indented,new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DateFormatString = "dd/MM/yyyy"
                });
                using (var stream = new FileStream(jsonPath, FileMode.Create))
                {
                    var json = new UTF8Encoding(true).GetBytes(stringfiy);
                    stream.Write(json,0,json.Length);
                }
                return;
            }
            throw new Exception("the object value can't be null");
        }
    }
}
