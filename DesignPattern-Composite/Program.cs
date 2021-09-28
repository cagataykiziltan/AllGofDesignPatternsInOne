using System;
using System.Collections.Generic;

namespace DesignPattern_Composite
{
       enum Rank
    {
        General,
        Colonel,
        LieutenantColonel,
        Major,
        Captain,
        Lieutenant
    }


    class Program
    {
         public static void Main(string[] args)
        {

            // Root oluşturulur.   
            CompositeSoldier generalCagatay = new CompositeSoldier("cagatay", Rank.General);

            // root altına Leaf tipten nesne örnekleri eklenir.
            generalCagatay.AddSoldier(new PrimitiveSoldier("Mayk", Rank.Colonel));
            generalCagatay.AddSoldier(new PrimitiveSoldier("Tobiassen", Rank.Colonel));

            // Composite tipler oluşturulur.
            CompositeSoldier colonelNevi = new CompositeSoldier("Nevi", Rank.Colonel);
            CompositeSoldier lieutenantColonelZing = new CompositeSoldier("Zing", Rank.LieutenantColonel);


            // Composite tipe bağlı primitive tipler oluşturulur.
            lieutenantColonelZing.AddSoldier(new PrimitiveSoldier("Tomasson", Rank.Captain));
            colonelNevi.AddSoldier(lieutenantColonelZing);
            colonelNevi.AddSoldier(new PrimitiveSoldier("Mayro", Rank.LieutenantColonel));

            // Root' un altına Composite nesne örneği eklenir.
            generalCagatay.AddSoldier(colonelNevi);


            generalCagatay.AddSoldier(new PrimitiveSoldier("Zulu", Rank.Colonel));


            // root için ExecuteOrder operasyonu uygulanır. Buna göre root altındaki tüm nesneler için bu operasyon uygulanır
            generalCagatay.ExecuteOrder();


            Console.ReadLine();

        }

    }

}