
using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            //SelamVer("Engin");
            //SelamVer("Ahmet");
            //SelamVer("Ayşe");
            //SelamVer();

            //int sonuc = Topla(6, 58);

            //Diziler / Arrays





            string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            //Console.WriteLine(sehirler2[0]);




            Person person2 = new Person();
            person2.FirstName = "Murat";

            //foreach (string sehir in sehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            //foreach (var sehir in yeniSehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}
            Person person1 = new Person();
            person1.FirstName = "Muhammed";
            person1.LastName = "Gedük";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 384013681600;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }


    }
}
