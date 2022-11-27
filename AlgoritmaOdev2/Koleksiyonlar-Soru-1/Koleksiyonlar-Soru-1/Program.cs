List<int> asal = new List<int>() { };
List<int> notAsal = new List<int>() { };
List<int> arr = new List<int>() { };
while(arr.Count < 20)
{
	try
	{
		Console.Write("Sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
		if(number < 0)
		{
			Console.WriteLine("Pozitif tam sayı giriniz.");
			
		}
		else
		{
            arr.Add(number);
		}
    }
	catch (Exception)
	{
		Console.WriteLine("Sayı formatında bir değer giriniz.");
		
	}
    
}
foreach (var item in arr)
{
    int n = 0;
    for (int i = 2; i < item; i++)
    {

        if (item % i == 0)
        {
            n++;
        }
        else
        {
            continue;
        }
    }
    if (n == 0)
    {
        asal.Add(item);
    }
    else
    {
        notAsal.Add(item);
    }
}
asal.Sort(); //Küçükten büyüğe sıralar.
notAsal.Sort();
asal.Reverse(); //Tersine çevirir.
notAsal.Reverse();
Console.Write("Asal Sayılar: ");
double asalTotal = 0;

foreach (var item in asal)
{
    asalTotal += item;
    Console.Write(item + " ");
}
Console.WriteLine();
double notAsalTotal = 0;
Console.Write("Asal Olmayan Sayılar: ");
foreach (var item in notAsal)
{
    notAsalTotal += item;
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine($"{asal.Count} adet asal sayı vardır. Bu sayıların ortalaması {asalTotal/asal.Count} değerine eşittir.");
Console.WriteLine($"{notAsal.Count} adet asal olmayan sayı vardır. Bu sayıların ortalaması {notAsalTotal/notAsal.Count} değerine eşittir.");




