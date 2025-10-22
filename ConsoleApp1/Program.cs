namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> roman = new Dictionary<char, int>()
                {
                     {'I', 1},             
                     {'V', 5},              
                     {'X', 10},
                     {'L', 50},
                     {'C', 100},
                      {'D', 500},
                     {'M', 1000}
                 };
            Console.WriteLine("enter the word");
            int s = Console.ReadLine();

        }
    }
}
