using System;
using System.Text;

namespace CodingBat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(countCode("cozexxcope"));
            //Console.WriteLine(sameStarChar("xy*yzz"));
            //Console.WriteLine(mixString("xxxx", "There"));
            //Console.WriteLine(doubleChar("Hi-There"));
            //Console.WriteLine(xyzMiddle("AaaAxyzBBb"));
            //Console.WriteLine(countYZ("day fyyyz"));
            mirrorEnds("abXYZba");
            Console.ReadLine();
        }

        static int countCode(string str)
        {
            int num = 0;
            for(int i = 0; i < str.Length-3; i++)
            {
                if (str.Substring(i, 2).Equals("co")&&str.Substring(i+3,1).Equals("e"))
                    {
                        num = num + 1;
                    }
            }
            return num;
        }//returns number of occurances of "co*e" in string. where "*" is any character

        static bool sameStarChar(string str)
        {
            bool answer = false;
            for (int i = 0; i < (str.Length-3); i++)
            {
                string first = str.Substring(i,1);
                string second = str.Substring(i+1,1);
                string third = str.Substring(i+2,1);
                if (second.Equals("*"))
                {
                    answer = true;
                }
            }
            return answer;
        }//returns true if "*" in string has same letters immediately next to it

        static StringBuilder mixString(string a, string b)
        {
            StringBuilder mixString = new StringBuilder();
            int length = a.Length + b.Length;


            for (int i = 0; i < length-1; i++)
            {
                if (i < a.Length)
                {
                    mixString.Append(a[i]);
                }
                if (i < b.Length)
                {
                    mixString.Append(b[i]);
                }


            }




            return mixString;

        }//prints string a and b combined

        static StringBuilder doubleChar(string str)
        {
            StringBuilder sb1 = new StringBuilder();
            for(int i = 0; i < str.Length ; i++)
            {
                sb1.Append(str[i]);
                sb1.Append(str[i]);
            }


            return sb1;
        }//prints 2x characters in a string

        static bool xyzMiddle(string str)
        {
            bool answer = false;
            for(int i = 1; i < str.Length-1; i++)
            {
                if (str.Substring(i-1, 3).Equals("xyz"))
                {
                    int y = (str.Length+1) / 2;
                    if (y >= i-1 && y <= i+1)
                    {
                        Console.WriteLine("Here");
                        answer = true;
                    }
                }

            }


            return answer;
        }//returns true or false if "xyz" is in middle of string

        static int countYZ(string str)
        {
            int num = 0;

            for(int i = 0; i < str.Length; i++)
            {

                if (str.Substring(i,1).Equals("y"))
                {
                    if (i == str.Length - 1)
                    {
                        num = num + 1;
                        Console.WriteLine("Here for Ya");
                    }
                    else if (Char.IsLetter(str[i + 1]) == false)
                    {
                        num = num + 1;
                        Console.WriteLine("Here for Yb");
                    }

                }

                Console.WriteLine(str.Substring(i,1));
                if (str.Substring(i,1).Equals("z"))
                {
                    if (i == str.Length - 1)
                    {
                        num = num + 1;
                        Console.WriteLine("Here for Za");
                    }
                    else if (Char.IsLetter(str[i + 1]) == false)
                    {
                        num = num + 1;
                        Console.WriteLine("Here for Zb");
                    }

                }
            }



            return num;
        }//returns number of z and y at ends of words

        static StringBuilder mirrorEnds(string str)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb1.Append(str);

            sb2.Append(str);

            for(int i = 0; i < str.Length/2; i++)
            {
               char a = sb2[i];
                sb2[i] = sb2[(str.Length-1) - i];
                sb2[(str.Length-1) - i] = a;
            }

            for (int i = (str.Length)/2; i > 0; i--){
                if (sb1.ToString(0, i).Equals(sb2.ToString(0, i)))
                {
                    if (i == str.Length  / 2)
                    {
                        Console.WriteLine(sb1);
                    }
                    else
                    {
                        Console.WriteLine(sb1.ToString(0,i));
                    }
                    break;

                }

            }





            return sb1;
        }//prints out matching start and end characters of a string
    }
}
