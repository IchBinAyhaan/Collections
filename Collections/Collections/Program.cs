
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your word:");
        string original =Console.ReadLine();
        string reversed = ReverseString(original);
        Console.WriteLine("Reversed word:");
        Console.WriteLine(reversed);
    }

    private static string ReverseString(string originalString)
    {
        char[] charArr = originalString.ToCharArray();
        int size = charArr.Length;
        Stack stack = new Stack(size);

        int i;
        for (i = 0; i < size; ++i)
        {
            stack.Push(charArr[i]);
        }

        for (i = 0; i < size; ++i)
        {
            charArr[i] = (char)stack.Pop();
        }

        return new string(charArr);
    }
}
