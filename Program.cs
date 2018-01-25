using System;

namespace StudyGuide
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 12;                //int
            var price = 12.56f;             //float
            var vowel = true;               //bool
            var character = 'S';            //char
            var lastName = "Adkins";        //string


            Console.WriteLine(number);
            Console.WriteLine(price);
            Console.WriteLine(vowel);
            Console.WriteLine(character);
            Console.WriteLine(lastName);


        }
   
    
    }
    // Conversion Notes

    /* Implicit Conversion Examples:
     
     byte b= 1; --> int i = b;  (no Data Loss)
     int i = 1; --> float f = i;  (no Data Loss)

    Explicit Conversion:
    
    int i = 1; byte b= i;
    (possible data loss, if more data than what there's room for)

    Non Compatible types:

    string s = "1";
    int i - Convert.ToInt32(s);
    int j = int.Parse(s); */

    





}
