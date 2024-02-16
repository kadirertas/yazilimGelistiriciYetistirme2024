using Business.Concrete;
using Entities.Concrete;

static void Main(string[] args)
        {
            Variables();

            SelamVer();
            SelamVer();
            SelamVer();

            int sonuc = Toplam(5, 68);
            Console.WriteLine(sonuc);

            string[] students = { "Engin", "Kerem", "Berkay" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }




            


            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Antep";

            Console.WriteLine("------------------------------------------------ Reference Type ---------------------------");
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 58;

            Console.WriteLine("------------------------------------------------ Value Type ---------------------------");
            Console.WriteLine(sayi1);

            Console.WriteLine("------------------------------------------------ Foreach Version ---------------------------");
            foreach (string item in sehirler1)
            {
                Console.WriteLine(item);
            }

            Person person = new Person();
                 person.FirstName = "Engin ";
                 person.LastName = "Demiroğ";
                 person.DateOfBirthYear = 1985;
                 person.NationalIdentity = 12345;
            Person person2 = new Person();
             person2.FirstName = "Murat"; 


            Console.WriteLine("------------------------------------------------ List Version ---------------------------");
            List<string> yenisehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yenisehirler1.Add("Muş");

            foreach (string item in yenisehirler1)
            {
                Console.WriteLine(item);
            }


          PttManager pttManager = new PttManager(new PersonManager());
          pttManager.GiveMask(person);
      
            
        }

        static void Variables()
        {
            string message = "Selam ";
            double tutar = 100000.5; // bu bize veri kaynağından gelecek 
            int number = 100;
            bool isAuthenticated = false;

            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);
            Console.WriteLine(message);

            string name = "Engin";
            string surname = "Demiroğ";
            int year = 1985;
            long tcNumber = 12345678910;
        }

        static int Toplam(int sayı = 1, int sayı2 = 2)
        {
            int toplam = sayı + sayı2;
            Console.WriteLine("Toplam değer: " + toplam.ToString());
            return toplam;
        }

        static void SelamVer()
        {
            Console.WriteLine("Selamlar");
        }
    

            

    public class People
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int year { get; set; }
        public long tcNumber { get; set; }
    }

   





