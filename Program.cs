namespace Main
{
    public static class bar
    {
        public static void Main(string[] args) { }
        public static bool Palindrome(string word)
        {
         
            string reversed = new string(word.Reverse().ToArray());
            bool IsPalindrome= word.Equals(reversed);

            if (IsPalindrome)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYes, Miku");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo, Miku");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            return IsPalindrome;
        }
    }
}
    


