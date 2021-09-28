namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();

            facade.UseCredit(new Client { Name = "Burak", Id = "123303", ClientNumber = 4234242 },1000) ;
        }
    }
}
