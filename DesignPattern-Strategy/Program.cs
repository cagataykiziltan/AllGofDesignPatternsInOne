using System;

namespace DesignPattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new Serializer(new XmlSerializer());

            serializer.Serialize("Stragey");
            serializer.Deserialize("Stragey");

            serializer = new Serializer(new BinarySeriazlier());

            serializer.Serialize("");
            serializer.Deserialize("");
        }
    }

   //Base Interface
    interface ISerializable
    {
        void Serialize(string str);
        void Deserialize(string str);
    }

    //Concrete tip 1
    class XmlSerializer : ISerializable
    {
        public void Deserialize(string str)
        {
            Console.WriteLine("xml deserialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("xml serialized");
        }
    }

    //Concrete tip 2
    class BinarySeriazlier : ISerializable
    {
        public void Deserialize(string str)
        {
            Console.WriteLine("binary deserialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("binary serialized");
        }
    }

    //Context tip
    class Serializer
    {
        ISerializable _serializer;

        public Serializer(ISerializable serializer)
        {
            _serializer = serializer;
        }

        public void Serialize(string str)
        {
            _serializer.Serialize(str);
        }

        public void Deserialize(string str)
        {
            _serializer.Deserialize(str);
        }
    }


}
