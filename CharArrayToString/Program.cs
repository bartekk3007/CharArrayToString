namespace CharArrayToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = { 'B', 'a', 'r', 't', 'e', 'k' };
            string s1 = new string(array);
            Console.WriteLine(s1);
        }
    }
}
