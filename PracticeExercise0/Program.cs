using System;

namespace PracticeExcercise0
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(IsPalindrome("mom "));
            //Console.WriteLine(IsPalindrome("Mom"));
            Console.WriteLine(IsPalindrome("Race car"));
            Console.WriteLine(IsPalindrome("A nut for a jar of tuna"));

            //Console.WriteLine(Reverse("coffee"));
            //Console.WriteLine(Reverse("abcdefghijklmnopqrstuvwxyz"));
            //Console.WriteLine(Reverse("Dad"));
            //Console.WriteLine(Reverse(""));
            //Console.WriteLine(Reverse("savannaH"));

            Console.WriteLine(ReverseInt(369)); // 963
            Console.WriteLine(ReverseInt(-369)); // -963


            //Console.WriteLine(IsUnique("mom"));
            //IsUnique("");
            //IsUnique("mom");
            //IsUnique("Robbie");
            //IsUnique("Judah");

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            // clean up the string
            // remove spaces
            // lowercase it
            string cleanString = s.ToLower().Replace(" ", "");

            // reverse the clean string
            string reversed = Reverse(cleanString);

            // check if reverse string is the same as the clean string

          
            return (reversed == cleanString);
        }

        private static string Reverse(string s)
        {
            string result = "";

            foreach( char c in s)
            {
                result = result.Insert(0, c.ToString() );
            }

            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            int x = i;
            int reverse = 0;

            while( x != 0 )
            {
                int remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x = x / 10;
            }

            return reverse;
        }

        // #3
        public static bool IsUnique(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");

            for( int i=0; i < cleanString.Length; i++)
            {
                // compare cleanString[i] to every subsequent letter
                // in cleanString

                for(int j=i+1; j < cleanString.Length; j++)
                {
                    if (cleanString[i] == cleanString[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
         

        // #4
        public static bool IsNeilNumber(int i)
        {
            int numDigits = (int)Math.Ceiling(Math.Log10(i));

            int nDigits = i.ToString().Length;


 

           
        }

    }
}
