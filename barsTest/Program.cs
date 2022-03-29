using System;

namespace barsTest
{
    public delegate char EventHander(char Char);
    class Program
    {
        static void Main(string[] args)
        {
            CheckingEnteredCharacter Char = new CheckingEnteredCharacter();
            Char.Run();
        }
    }
    class CheckingEnteredCharacter
    {
        public event EventHander OnKeyPressed;
        private char Char;
        private char[] Char_cRreE= { 'C', 'c', 'с', 'С'};
        public char Run()
        {
            while (true)
            {
                Char = Console.ReadKey().KeyChar;
                for (int i = 0; i < Char_cRreE.Length; i++)
                {
                    if (Char == Char_cRreE[i])
                    {
                        Console.Clear();
                        OnKeyPressed += WriteLineConsole;
                        return OnKeyPressed.Invoke(Char);
                        
                    }
                }
            }
        }
        public char WriteLineConsole(char Char)
        {
            Console.WriteLine(Char);
            return Char;
        }
    }

    
}
