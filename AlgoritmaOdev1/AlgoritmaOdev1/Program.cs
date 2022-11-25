//Soru 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

#region Soru1
/*
Console.Write("Sayı Giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numberList = new int[n];
for (int i = 0; i < numberList.Length; i++)
{
    Console.Write($"{i+1}.Sayı: ");
    numberList[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int number in numberList)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    } 
}
*/
#endregion

//Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

#region Soru2
/*
Console.Write("Sayı Giriniz: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı Giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numberList = new int[n];
for (int i = 0; i < numberList.Length; i++)
{
    Console.Write($"{i + 1}.Sayı: ");
    numberList[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int number in numberList)
{
    if (number % m == 0 || number == m)
    {
        Console.WriteLine(number);
    }
}
*/
#endregion

//Soru 3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

#region Soru3
/*
Console.Write("Sayı Giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] wordList = new string[n];
for (int i = 0; i < wordList.Length; i++)
{
    Console.Write($"{i + 1}.Kelime: ");
    wordList[i] = Console.ReadLine();
}
foreach (string word in wordList.Reverse())
{
    Console.WriteLine(word);
}
*/
#endregion

//Soru 4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

#region Soru4
/*
Console.Write("Cümle Yazınız: ");
string sentence = Console.ReadLine();
Console.WriteLine(sentence.Length);
*/
#endregion