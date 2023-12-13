using System;


public static class StringManipulator
{

    public static string ReverseString(this string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}


public static class ArrayOperations
{
   
    public static void SortArray(this int[] array)
    {
        Array.Sort(array);
    }
}

class Program
{
    static void Main()
    {
        
        string text = "message box!";
        string reversedText = text.ReverseString();
        Console.WriteLine("Tersine çevrilmiş metin: " + reversedText);

      
        int[] numbers = { 5, 2, 8, 1, 9 };
        numbers.SortArray();
        Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", numbers));
    }
}
