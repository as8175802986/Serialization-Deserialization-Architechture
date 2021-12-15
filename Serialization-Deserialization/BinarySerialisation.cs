using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization_Deserialization
{
    class BinarySerialisation
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"E:\Serialization-Deserialization\Serialization-Deserialization-Architechture\Serialization-Deserialization\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }
        public void Deserialization()
        {
            FileStream fileStream = new FileStream(@"E:\Serialization-Deserialization\Serialization-Deserialization-Architechture\Serialization-Deserialization\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application Name : { deserializedSampleDemo.ApplicationName}     ---      Application ID : {deserializedSampleDemo.ApplicationId}");
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
