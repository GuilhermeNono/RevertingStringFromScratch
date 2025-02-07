namespace LowAbstraction;

unsafe class Program
{
    static void Main(string[] args)
    {
        string hello = "Hello World!";
        int stringQuantity = hello.Length;
        char[] helloChars = new char[stringQuantity]; 

        fixed (char* cPtr = hello)
        {
            for (int i = 0; i < stringQuantity; i++)
            {
                helloChars[i] = cPtr[stringQuantity - i - 1];
            }
        }

        Console.WriteLine(helloChars);
    }
}
