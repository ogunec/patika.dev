Console.Write("Kenar Uzunluğu: ");
int length = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
int sayac2 = length;
for (int i = 0; i < length; i++)
{
	for (int j = sayac2-1; j > 0; j--)
	{
		Console.Write(" ");
	}
	sayac2--;
	for (int k = 1; k <= sayac; k++)
	{
		Console.Write("*");
		Console.Write(" ");
	}
	sayac++;
	Console.WriteLine();
}
