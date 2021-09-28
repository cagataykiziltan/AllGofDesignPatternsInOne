using DesignPattern_Mediator.Airlines;
using DesignPattern_Mediator.Mediator;
using MediatorPattern.ChatExample;
using MediatorPattern.Mediator;
using System;

namespace MediatorPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            //-------------------------AIRPORT EXAMPLE----------------------------
            // Kule nesnesi örneklenir(Concrete Mediator)
            IstanbulControl istanbulKule = new IstanbulControl();

            // Kuleden hizmet alacak tüm uçakların kendisini kuleye bildirmesi gerekmektedir. Bu nedenle uçaklar örneklendikten sonra Concrete Mediator tipine Register metedo yardımıyla kayıt olurlar.
            OzHawaii oh101 = new OzHawaii { Airport = istanbulKule, FlightNumber = "oh101", From = "Hawai" };
            istanbulKule.Register(oh101);
            OzHawaii oh132 = new OzHawaii { Airport = istanbulKule, FlightNumber = "oh132", From = "Roma" };
            istanbulKule.Register(oh132);
            ZorluYol zy99 = new ZorluYol { Airport = istanbulKule, FlightNumber = "zy99", From = "Antarktika" };
            istanbulKule.Register(zy99);

            // Uçaklar yeni rotalarını talep ederler.
            zy99.RequestNewWay("34:43E;41:41W");

            oh101.RequestNewWay("34:43E;41:41W");
            //---------------------------------------------------------------------

            //-------------------------CHAT EXAMPLE----------------------------

            ConcreteMediator sohbetOdasi = new ConcreteMediator();


            Participant Can = new ConcreteColleague1("Can"); 
            Participant Canan = new ConcreteColleague1("Canan");
            Participant Baris = new ConcreteColleague2("Barış");
            Participant Ahmet = new ConcreteColleague2("Ahmet"); 
            Participant Selvi = new ConcreteColleague1("Selvi");


            sohbetOdasi.Register(Can); 
            sohbetOdasi.Register(Canan); 
            sohbetOdasi.Register(Baris); 
            sohbetOdasi.Register(Ahmet); 
            sohbetOdasi.Register(Selvi);
          

            Canan.SendMessage("Can", "Selam Can Yemeğe Çıkacakmısın ?"); 
            Baris.SendMessage("Ahmet", "İstediğim evraklar hazır mı ?"); 
            Canan.SendMessage("Ahmet", "Toplantı saat 3'te ");
            Ahmet.SendMessage("Barış", "İstediğin evraklar hazır");

            //---------------------------------------------------------------------
        }
    }
}
