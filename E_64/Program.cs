namespace ConsoleApplication17
{
    class Program
    {
        static string KO(int n)
        {
            if (n == 1)
                return "1";
            else
                return KO(n - 1) + n;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(KO(3));
 
        }
    }
}