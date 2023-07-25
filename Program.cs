using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
         void PatternMatch1()
        {
            string input = "abb";

            string pattern = @"a(bb|bbb)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);


            if (match.Success)
            {
                Console.WriteLine("String matches the pattern");
            }
            else
            {
                Console.WriteLine("String does not match the pattern.");
            }
        }

        void PatternMatch2()
        {
            string input = "hello_word_how";

            string pattern = @"[a-z]+[_]";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);


            if (match.Success)
            {
                Console.WriteLine("String matches the pattern");
            }
            else
            {
                Console.WriteLine("String does not match the pattern.");
            }
        }
        void PatternMatch3()
        {
            string input = "<p>The<code>Regex</code> is a compiled representation of a regular expression</p>";

            string pattern = @"<[/]?[a-z]+>";                           
            
            Regex regex = new Regex(pattern);

            
            MatchCollection matches = regex.Matches(input);

           
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
        void PatternMatch4()
        {
            string pattern = "fox(es)?";


            string s = @"foxes are omnivorous mammals belonging to several genera of the family Canidae fox";
            Regex regex = new Regex(pattern);


            MatchCollection matches = regex.Matches(s);

            int count = 0;
            foreach (Match match in matches)
            {

                Console.WriteLine(match.Value);
                count++;
            }
           Console.WriteLine("There are "+count+" occurrences.");


        }


        void PatternMatch5()
        {
            string[] fileNames = {
            "image.jpg",
            "picture.png",
            "document.docx",
             "data.csv",
            "background.pqr" };

            string pattern = @"[a-z]+[.](jpg|jpeg|png)";                               

            foreach (string fileName in fileNames)
            {
                bool isValid = Regex.IsMatch(fileName, pattern);
                if (isValid)
                {
                    Console.WriteLine(fileName);
                }


            }
        }

        void PatternMatch6()
        {
            string[] urls = {
            "http://www.example.com",
            "www.example.com",
            "example.com",
            "http://example.com/page",
            "ftp://example.com",
            "invalidurl",
            "http://www.invalid"
        };

            string pattern = @"[https://]?[www][.]?[a-zA-Z0-9]+[.][a-zA-Z]{2,}";    
            
            foreach (string url in urls)
            {
                bool isValid = Regex.IsMatch(url, pattern);
                if (isValid)
                {
                    Console.WriteLine(url);
                }
            }
        }
        void pattern()
        {
            string input = "Aman";

            string pattern = @"[A-z]{1}[a-z]{3,}";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);


            if (match.Success)
            {
                Console.WriteLine("String matches the pattern");
            }
            else
            {
                Console.WriteLine("String does not match the pattern.");
            }

        }





        static void Main(string[] args)
        {
           Program program = new Program();

            
            program.PatternMatch1();
            program.PatternMatch2();
            program.PatternMatch3();
            program.PatternMatch4();
            program.PatternMatch5();
            program.PatternMatch6();
            program.pattern();
            Console.ReadLine();

        }
    }
}
