List<double> arr = new List<double>() { };
while (arr.Count < 20)
{
    try
    {
        Console.Write("Sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr.Add(number);
    }
    catch (Exception)
    {
        Console.WriteLine("Sayı formatında bir değer giriniz.");

    }

}
arr.Sort();
double minAverage = (arr[0] + arr[1] + arr[2]) / 3;
double maxAverage = (arr[19] + arr[18] + arr[17]) / 3;
Console.WriteLine($"En küçük 3 sayının ortalaması {minAverage} sayısına eşittir.");
Console.WriteLine($"En büyük 3 sayının ortalaması {maxAverage} sayısına eşittir.");
Console.WriteLine($"Ortalamaların toplamı {minAverage+maxAverage} sayısına eşittir.");
