using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Genrics
{
    internal class Program
    {
        //public static string expresstionstr = "^[0-9]*[A-Za-z]{3,}[A-Za-z0-9]*$";
        // public static string str1 = "^[1-9][0-9]{5}$";
        //public static string str2 = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        //public static string str3 = "^[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}$";
        //public static string str = @"^\d{0,2}\-?\d{10}$";
        public static string str12 = @"^\d{0,2}\-?\d{0,3}\-?\d{0,4}$";
        

        static void Main(string[] args)
        {

            // if (Regex.IsMatch("1aaaaAA1",expresstionstr))
            //if (Regex.IsMatch("91-9110312345", str))
            if (Regex.IsMatch("26-03-2024", str12))
            {
                Console.WriteLine("vaild");
            }
            else
            {
                Console.WriteLine("Invaild");
            }

            //string pattern = @"\b[M]\w+";
            //Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            //string author = "Mahesh , mike, Allen";
            //MatchCollection matches = regex.Matches(author);
            //for (int count = 0; count < matches.Count; count++)
            //{
            //    Console.WriteLine(matches[count].Value);
            //}

            
            //string a1 = "hi";
            //Regex  r= new Regex(a1, RegexOptions.IgnoreCase);
            //string a2 = r.Replace(a1, "hiii");
            //Console.WriteLine(a2);
            //string str = @"\b\w+";
            //string input = "allu arjun";
            //Regex  regex1=new Regex(str, RegexOptions.IgnoreCase);
            //Match match = regex1.Match(input);
            //if (match.Success)
            //{

            //}
            //bool isMatch=regex1.IsMatch(input);
            //if (isMatch)
            //{
            //    Console.WriteLine();
            //}
            string a = @"^[A-Za-z]*$";
            Console.WriteLine("enter the string ");
            string b = Console.ReadLine();
            if (Regex.IsMatch(b, a)
)
            {
                Console.WriteLine("valid");
            }else
            {
                Console.WriteLine("invalid");
            }
        }           
       }       
    }

