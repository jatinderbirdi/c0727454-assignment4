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
                ArrayList lineNumbers = new ArrayList();
                int linenum = 1;
                lineNumbers.Add(22);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    if (line.Substring(0).Contains("sea") &&  line.Substring(0).Contains("fare"))
                    {
                        lineNumbers.Add(linenum);
                    }

                    // COUNTING THE NUMBER OF WORDS  SECTION B
                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            myWord++;
                        }
                        a++;
                    }
                    a = 0;

                    linenum++;  // SECTION C
                }
                

                // SECTION A: NUMBER OF LINES
                Console.WriteLine("\n\n\n\n********************************\nLines" + counter);
                Console.WriteLine("Words " + myWord);


                // SECTION C: WORDS WHICH CONTAINS BOTH SEA AND FARE
                Console.WriteLine("Section c\n");
                foreach (int i in lineNumbers)
                {
                    Console.Write(i + " ");
                }
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