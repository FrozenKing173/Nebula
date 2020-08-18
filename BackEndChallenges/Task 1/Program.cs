public class Program
{
    /// <summary>
    /// Task 1 : Write a method that will take, as input, a string and dependent on the string length prints out the following:
    /// 1. If the length is a multiple of 2 your method must print out "Stack"
    /// 2. If the length is a multiple of 4 your method must print out "Overflow"
    /// 3. If the length is a multiple of 2 and 4 your method must print out "Stack Overflow!"
    /// </summary>
    public void Print(string paramText)
    {
        // Print 'Stack' IF paramText is multiple of 2
        // Print 'Overflow IF paramText is multiple of 4
        // Print 'Stack Overflow' IF paramText is multiple of 2 and 4

        int paramTextLength = paramText.Length;

        if (paramTextLength % 2 == 0)
            Console.WriteLine("Stack");

        if (paramTextLength % 4 == 0)
            Console.WriteLine("Overflow");

        if (paramTextLength % 2 == 0 && paramTextLength % 4 == 0)
            Console.WriteLine("Stack Overflow");
    }
}