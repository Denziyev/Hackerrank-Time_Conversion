using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
 

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        
        StringBuilder sb = new StringBuilder(s);
       
            string strr = (string.Concat(sb[0], sb[1])).ToString();
     
            int str = int.Parse(strr);
             if ((sb[sb.Length - 2] == 'A' && str < 12)|| (sb[sb.Length - 2] == 'P' && str == 12))
             {

             }
        else
        {
            string str2;
            str += 12;
            Console.WriteLine(str);
            str2 = str.ToString();
            if (str == 24)
            {
                str2 = "00";
            }


            Console.WriteLine(strr);



            StringBuilder sb2 = new StringBuilder(str2);
            sb[0] = str2[0];
            sb[1] = str2[1];

        }



        sb[sb.Length - 1] = ' ';
            sb[sb.Length - 2] = ' ';
        
        
        s=sb.ToString();
         
        return s;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
