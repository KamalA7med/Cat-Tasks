using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_Man_Game
{
    internal class Program
    {
        
       public static string[] hangman = new string[]
{
   
    "  +---+\n" +
    "  |   |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "=========",

    
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    "      |\n" +
    "      |\n" +
    "      |\n" +
    "=========",

  
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    "  |   |\n" +
    "      |\n" +
    "      |\n" +
    "=========",

  
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    " /|   |\n" +
    "      |\n" +
    "      |\n" +
    "=========",

   
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    " /|\\  |\n" +
    "      |\n" +
    "      |\n" +
    "=========",

    
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    " /|\\  |\n" +
    " /    |\n" +
    "      |\n" +
    "=========",

   
    "  +---+\n" +
    "  |   |\n" +
    "  O   |\n" +
    " /|\\  |\n" +
    " / \\  |\n" +
    "      |\n" +
    "========="
};
        
        public static void Print_Header()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Welcom to Hang Man Game  ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Can you Svae Him Before This ? ");
            Console.WriteLine(hangman[6]);

        }
        public static void Print_Question(string Word,bool[] charcters, List<char> Wrong_Gussed)
        {
            Console.Write("        Word :");
            for (int i = 0; i < Word.Length; i++)
            {
                if (charcters[i]==true)
                {
                    Console.Write(Word[i]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.Write("\n\n        Failed Trials : ");
            foreach (char c in Wrong_Gussed)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        public static bool Check_Answer(string Word, bool[] charcters, char answer)
        {
            bool Character_Exists = false;
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == answer)
                {
                    charcters[i] = true;
                    Character_Exists = true;
                }
         
            }
            return Character_Exists;
        }
        
        public static bool Start_Game(string Word)
        {
            int Failed_Trials_Counter = 0;
            bool[] charcters=new bool[Word.Length];
            List<char> Failed_Trials = new List<char>();
           
            while (Failed_Trials_Counter < 6)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------\n");
                Print_Question(Word, charcters, Failed_Trials);
                Console.WriteLine("--------------------------------------\n");
                Console.Write("Entre Charcter : ");
                char ch= Console.ReadLine().ToLower()[0];
                if(Check_Answer(Word,charcters, ch))
                {
                    Console.WriteLine("\n\n        Nice Guess ");
                    bool f = true;
                    for (int i = 0; i < Word.Length; i++)
                    {
                        if (!charcters[i] )
                        {
                            f = false;
                            break;
                        }
                        
                    }
                    if ( f)
                    {
                        return true;
                    }
                   

                }
                else
                {
                    Console.WriteLine("\n         Wrong Guess");
                    Failed_Trials.Add(ch);
                    Failed_Trials_Counter++;
                    Console.WriteLine(hangman[Failed_Trials_Counter]);
                }
                Console.WriteLine("\n\nEnter any Key To Continue.............");
                Console.ReadKey();


            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] Words = { "bright", "active", "friend", "kindly", "spirit" };
            Random random = new Random(); 
            string word = Words[random.Next(0, Words.Length)];
            Print_Header();
            Console.WriteLine("\n\nEnter any Key To Continue............");
            Console.ReadKey();
            
            if (Start_Game(word))
            {
               
                Console.WriteLine("\n\nYou saved him ");
            }
            else
            {
                Console.WriteLine("\n\nYou Lost The Game ");
            }
            


        }
    }
}
