using System;

namespace DesignPattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.Id.ToString());

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Id.ToString());

            //ikisi için de aynı id gelir. çünkü tektir.
            Console.ReadKey();
        }
    }

    class Singleton
    {

        private static Singleton _instance;
        private static Guid _id; 

        public Guid Id { get { return  _id; } }

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }

    }
}
