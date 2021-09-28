using System;


namespace DesignPattern_AbstractFactory
{
    //Connection ürünleri için soyut tasarım
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; } //read-only
    }

    //Connection ürünleri için soyut tasarım
    public abstract class Command
    {
        public abstract void Execute(string query);
    }


    public class Db2Connection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("Db2Baglantisi kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("Db2Baglantisi acilacak");
            return true;
        }
    }

    public class InterbaseConnection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("interbase kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("interbase acilacak");
            return true;
        }

    }

    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("DB2 Sorgusu çalıştırılır");
        }
    }

    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("interbase Sorgusu çalıştırılır");
        }
    }


    //istemcinin ihtiyacı olan ürünlerin üretilmesi
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();

    }

    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();

        }
    }

    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }

    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;

            _connection = databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {

            _connection.Connect();

            if (_connection.State == "Baglanti Durumu")
                _command.Execute("select ...");


        }
    }

}
