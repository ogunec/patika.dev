char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
List<char> arr = new List<char>(){ };
Console.Write("Cümle giriniz: ");
string sentence = Console.ReadLine().ToLower();
foreach (char character in sentence)
{
    foreach (char item in sesliler)
    {
        if (character == item)
        {
            arr.Add(character);
        }
    }
}
foreach (char item in arr)
{
    Console.Write(item);
}