using PhoneBookApp;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

List<Phone> phones = new List<Phone>()
{
    new Phone(){ FirstName="Onur",LastName="Güneç",PhoneNumber="1109008080"},
    new Phone(){ FirstName="Esra",LastName="Balcı",PhoneNumber="1108007070"},
    new Phone(){ FirstName="İsmail",LastName="Kalan",PhoneNumber="1107006060"},
    new Phone(){ FirstName="Ada",LastName="Zorlu",PhoneNumber="1106005050"},
    new Phone(){ FirstName="Yağmur",LastName="Kurt",PhoneNumber="1106305050"},
    new Phone(){ FirstName="Onur",LastName="Kurt",PhoneNumber="1105805050"}
};
while (true)
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Yeni Numara Kaydetmek");
    Console.WriteLine("(2) Varolan Numarayı Silmek");
    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
    Console.WriteLine("(4) Rehberi Listelemek");
    Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
    string islem = Console.ReadLine();
    if (islem == "1")
    {
        Phone phone = new Phone();
        Console.Write("Lütfen isim giriniz: ");
        phone.FirstName = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz: ");
        phone.LastName = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        phone.PhoneNumber = Console.ReadLine();
        phones.Add(phone);
        Console.WriteLine("Numara ekleme işleminiz başarıyla gerçekleştirildi.");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        continue;

    }
    if (islem == "2")
    {
        SearchPhone();
    }

    void SearchPhone()
    {
        Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        var input = Console.ReadLine();
        Phone phone = new Phone();
        foreach (Phone item in phones)
        {
            if (item.FirstName.ToLower() == input.ToLower() || item.LastName.ToLower() == input.ToLower())
            {
                phone = item;
            }
        }
        if (phone.FirstName == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Silmeyi sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
            string preferredAction = Console.ReadLine();
            if (preferredAction == "1")
            {
                Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
            else if (preferredAction == "2")
            {
                SearchPhone();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
        }
        else
        {
            Console.WriteLine($"{phone.FirstName} {phone.LastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            string userDecision = Console.ReadLine().ToLower();
            if (userDecision == "y")
            {
                phones.Remove(phone);
                Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                System.Threading.Thread.Sleep(3000);
            }
            else if (userDecision == "n")
            {
                Console.WriteLine("Silme işlemi iptal edildi.");
                System.Threading.Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yapıldı. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }

    if (islem == "3")
    {
        UpdatePhone();
    }
    void UpdatePhone()
    {
        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
        var input = Console.ReadLine();
        Phone phone = new Phone();
        foreach (Phone item in phones)
        {
            if (item.FirstName.ToLower() == input.ToLower() || item.LastName.ToLower() == input.ToLower())
            {
                phone = item;
            }
        }
        if (phone.FirstName == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
            string preferredAction = Console.ReadLine();
            if (preferredAction == "1")
            {
                Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
            else if (preferredAction == "2")
            {
                UpdatePhone();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
        }
        else
        {
            Console.WriteLine($"{phone.FirstName} {phone.LastName} isimli kişiyi güncellemek istiyor musunuz ?(y/n)");
            string userDecision = Console.ReadLine().ToLower();
            if (userDecision == "y")
            {
                Console.Write("İsim: ");
                phone.FirstName = Console.ReadLine();
                Console.Write("Soyisim: ");
                phone.LastName = Console.ReadLine();
                Console.Write("Telefon: ");
                phone.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Güncelleme işlemi başarıyla gerçekleştirildi.");
                System.Threading.Thread.Sleep(3000);
            }
            else if (userDecision == "n")
            {
                Console.WriteLine("Güncelleme işlemi iptal edildi.");
                System.Threading.Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yapıldı. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
    if (islem == "4")
    {
        Console.Clear();
        Console.WriteLine("Telefon Rehberi\r\n**********************************************");
        foreach (Phone item in phones)
        {
            Console.WriteLine($"isim: {item.FirstName}\r\nSoyisim: {item.LastName}\r\nTelefon Numarası: {item.PhoneNumber}\r\n-");
        }
        Console.WriteLine("Ana menüye dönmek için: (1)");
        StartMenu();
        

    }
    void StartMenu()
    {
        string decision = Console.ReadLine();
        if (decision == "1")
        {
            Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Hatalı tuşlama yaptınız tekrar deneyin.");
            StartMenu();
        }
    }
    if (islem == "5")
    {
        Console.Clear();
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\r\n**********************************************\r\n\r\nİsim veya soyisime göre arama yapmak için: (1)\r\nTelefon numarasına göre arama yapmak için: (2)");
        string preferredAction = Console.ReadLine();
        if (preferredAction == "1")
        {
            ListPhoneWithName();
        }
        if (preferredAction == "2")
        {
            ListPhoneWithNumber();
        }

        void ListPhoneWithName()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var input = Console.ReadLine();
            Phone phone = new Phone();
            foreach (Phone item in phones)
            {
                if (item.FirstName.ToLower() == input.ToLower() || item.LastName.ToLower() == input.ToLower())
                {
                    phone = item;
                }
            }
            if (phone.FirstName == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Aramayı sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
                string preferredAction = Console.ReadLine();
                if (preferredAction == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (preferredAction == "2")
                {
                    ListPhoneWithName();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Arama Sonuçlarınız:\r\n**********************************************\r\nisim: {phone.FirstName}\r\nSoyisim: {phone.LastName}\r\nTelefon Numarası: {phone.PhoneNumber}");
            }

        }

        void ListPhoneWithNumber()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin telefon numarasını giriniz: ");
            var input = Console.ReadLine();
            Phone phone = new Phone();
            foreach (Phone item in phones)
            {
                if (item.PhoneNumber == input)
                {
                    phone = item;
                }
            }
            if (phone.PhoneNumber == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Aramayı sonlandırmak için : (1)\r\nYeniden denemek için      : (2)");
                string preferredAction = Console.ReadLine();
                if (preferredAction == "1")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (preferredAction == "2")
                {
                    ListPhoneWithNumber();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Arama Sonuçlarınız:\r\n**********************************************\r\nisim: {phone.FirstName}\r\nSoyisim: {phone.LastName}\r\nTelefon Numarası: {phone.PhoneNumber}");
            }
            

        }
        Console.WriteLine("\r\n\r\n");
        Console.WriteLine("Ana menüye dönmek için: (1)");
        StartMenu();

    }


}


