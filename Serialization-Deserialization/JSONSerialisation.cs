using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serialization_Deserialization
{
    class JSONSerialisation
    {
        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Arunesh",
                Description = "Welcome to My World"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
            Console.WriteLine();
        }
        public void JsonDeserialize()
        {
            string json = @"{
                    'Name' : 'Arunesh',
                    'Description' : 'Welcome to My World'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.WriteLine(bsObj.Description);
            Console.WriteLine();
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
