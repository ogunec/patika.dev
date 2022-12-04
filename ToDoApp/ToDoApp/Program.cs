using ToDoApp;

List<Person> persons = new List<Person>()
{
    new Person() { Name = "Onur", Id = "1" },
    new Person() { Name = "Esra", Id = "2" },
    new Person() { Name = "Hakan", Id = "3" },
    new Person() { Name = "Uğur", Id = "4" }
};

List<Card> cards = new List<Card>()
{
    new Card(){ Title = "Student", Content = "Student Information", AssignedPerson = "Onur", Dimension = CardDimensions.XL, Line = "TODO"},
    new Card(){ Title = "Engineer", Content = "Engineer Information", AssignedPerson = "Esra", Dimension = CardDimensions.M, Line = "IN PROGRESS"},
    new Card(){ Title = "Teacher", Content = "Teacher Information", AssignedPerson = "Hakan", Dimension = CardDimensions.L, Line = "TODO"}
};
while (true)
{
    void ListBoard()
    {
        int doneCount = 0;
        int inprogressCount = 0;
        int todoCount = 0;
        void isEmpty(int boardCount)
        {
            if (boardCount == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }
        Console.WriteLine("TODO Line\r\n************************");
        foreach (Card item in cards)
        {
            if (item.Line == "TODO")
            {
                Console.WriteLine($"Başlık      :{item.Title}\r\nİçerik      :{item.Content}\r\nAtanan Kişi :{item.AssignedPerson}\r\nBüyüklük    :{item.Dimension}");
                todoCount++;
                Console.WriteLine("-");
            }

        }
        isEmpty(todoCount);
        Console.WriteLine("\r\n\r\nIN PROGRESS Line\r\n************************");
        foreach (Card item in cards)
        {
            if (item.Line == "IN PROGRESS")
            {
                Console.WriteLine($"Başlık      :{item.Title}\r\nİçerik      :{item.Content}\r\nAtanan Kişi :{item.AssignedPerson}\r\nBüyüklük    :{item.Dimension}");
                inprogressCount++;
                Console.WriteLine("-");
            }

        }
        isEmpty(inprogressCount);
        Console.WriteLine("\r\n\r\nDONE Line\r\n************************");
        foreach (Card item in cards)
        {
            if (item.Line == "DONE")
            {
                Console.WriteLine($"Başlık      :{item.Title}\r\nİçerik      :{item.Content}\r\nAtanan Kişi :{item.AssignedPerson}\r\nBüyüklük    :{item.Dimension}");
                doneCount++;
                Console.WriteLine("-");
            }

        }
        isEmpty(doneCount);
    }
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\r\n*******************************************\r\n(1) Board Listelemek\r\n(2) Board'a Kart Eklemek\r\n(3) Board'dan Kart Silmek\r\n(4) Kart Taşımak");
    string islem = Console.ReadLine();
    if (islem == "1")
    {
        ListBoard();


    }
    if (islem == "2")
    {
        Card card = new Card();
        card.Line = "TODO";
        Console.Write("Başlık Giriniz                                  :");
        card.Title = Console.ReadLine();
        Console.Write("İçerik Giriniz                                  :");
        card.Content = Console.ReadLine();
        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        string dimensionValue = Console.ReadLine();
        card.Dimension = (CardDimensions)Enum.Parse(typeof(CardDimensions), dimensionValue);
        Console.Write("Kişi Seçiniz                                    :");
        string personId = Console.ReadLine();
        foreach (Person item in persons)
        {
            if (item.Id == personId)
            {
                card.AssignedPerson = item.Name;
            }
        }
        cards.Add(card);


    }

    if (islem == "3")
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        SituationCheck();


    }
    void SituationCheck()
    {
        Console.Write("Lütfen kart başlığını yazınız: ");
        string title = Console.ReadLine();
        int count = 0;
        foreach (Card item in cards.ToList())
        {
            if (item.Title == title)
            {
                cards.Remove(item);
                count++;
            }
        }
        if (count >= 1)
        {
            Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n* Silmeyi sonlandırmak için : (1)\r\n* Yeniden denemek için : (2)");
            string prefferedAction = Console.ReadLine();
            if (prefferedAction == "1")
            {
                Console.WriteLine("Silme işlemi sonlandırıldı. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
            else if (prefferedAction == "2")
            {
                SituationCheck();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }

    if (islem == "4")
    {
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        MovingCard();
    }

    void MovingCard()
    {
        Console.Write("Lütfen kart başlığını yazınız: ");
        string title = Console.ReadLine().ToLower();
        int count = 0;
        foreach (Card item in cards)
        {
            if (item.Title.ToLower() == title)
            {
                Console.WriteLine($"Bulunan Kart Bilgileri:\r\n **************************************\r\nBaşlık      :{item.Title}\r\nİçerik      :{item.Content}\r\nAtanan Kişi :{item.AssignedPerson}\r\nBüyüklük    :{item.Dimension}\r\nLine        :{item.Line}");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \r\n(1) TODO\r\n(2) IN PROGRESS\r\n(3) DONE");
                string line = Console.ReadLine();
                if (line == "1")
                {
                    item.Line = "TODO";
                    count++;
                }
                else if (line == "2")
                {
                    item.Line = "IN PROGRESS";
                    count++;
                }
                else if (line == "3")
                {
                    item.Line = "DONE";
                    count++;
                }
                else
                {
                    count--;

                }
            }
        }
        if (count >= 1)
        {
            Console.WriteLine("Taşıma işlemi başarıyla gerçekleştirildi.");
            ListBoard();
        }
        else if (count < 0)
        {
            Console.WriteLine("Hatalı tuşlama yaptınız. Ana menüye yönlendiriliyorsunuz.");
            System.Threading.Thread.Sleep(3000);
        }
        else
        {
            Console.WriteLine("Böyle bir kart bulunamadı.");
        }
    }
}

