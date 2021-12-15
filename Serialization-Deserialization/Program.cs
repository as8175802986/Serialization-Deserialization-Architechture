using System;

namespace Serialization_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialisation binary = new BinarySerialisation();
            binary.Serialization();
            binary.Deserialization();
            //JSONSerialisation serialization = new JSONSerialisation();
            //serialization.JsonSerialize();
            //serialization.JsonDeserialize();
        }
    }
}
