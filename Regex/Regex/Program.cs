using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace R1
{
    class Program
    {
        String a = @"^\d{4}\-?\d{0,2}\-?\d{0,2}$";
        static void Main(string[] args)
        {

            //string badstring = "Here is a";
            //string cleanedString = Regex.Replace(badstring, "\\s+","");
            //Console.WriteLine(cleanedString);
            //string azpattern = "[a-z]+";
            //string str = "Asd2323b09000c1234Def5678GHi9012jklm";
            //string[] result=Regex.Split(str,azpattern,RegexOptions.IgnoreCase);
            //for(int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}


            //if (Regex.IsMatch("+91-9678-967110", @"^[+]?\d{2}\-?\d{4}\-?\d{6}$"))
            //{
            //    Console.WriteLine("vaild");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            if(Regex.IsMatch("http\\www.NTR.com",@"^(http(s)?[\\.])+(\w)+[.](\w)+[.com]+$"))
            {
                Console.WriteLine("vaild");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            
            //try
            //    { 
            //if(Regex.IsMatch("24-1-2",  @"^\d{4}\-?\d{0,2}\-?\d{0,2}$"))
            //{
            //    Console.WriteLine("vaild");
            //}
            //    else
            //    {
            //        throw new FormatException("invaild");
            //    }
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //int n = 3;
            //int fraction = 1;
            //try
            //{
            //  for(int i = 0; i < n; i++)
            //    {
            //        fraction=fraction*i;
            //    }
            //    Console.WriteLine(fraction);
            //}
            //catch (Exception ex) { }
        }
    }
}
