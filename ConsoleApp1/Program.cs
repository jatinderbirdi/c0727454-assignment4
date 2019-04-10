using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        int counterletters = 0;
        int countSpaces = 0;
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Beowulf = new ArrayList();
            a.ReadTextFiles();
        }

        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:/Users/727454/Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;
                int averageLetterPerWord;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            myWord++;
                        }
                        a++;
                    }
                    a = 0;

                }

                averageLetterPerWord = counterletters / countSpaces;

                Console.WriteLine("\nLines " + counter);
                Console.WriteLine("Words " + myWord);
                Console.WriteLine("The number of average letters per word is  " + averageLetterPerWord);
                Console.ReadLine();
            }

        }
        public int FindNumberOfBlankSpaces(string line)
        {
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { counterletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}