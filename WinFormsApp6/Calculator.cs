using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        private static double Result(string s1)
        {
            char[] 
                
                NewChar = getchar(s1);
            double[] NewNum = getnum(s1);
            int length = NewNum.Length;
            Excute_Div_And_Multiplication(NewChar, NewNum, ref length);
            excutePlusAndMinus(NewChar, NewNum, length);
            return NewNum[0];

        }
        private static void Excute_Div_And_Multiplication(char[] NewChar, double[] NewNum, ref int length)
        {
            for (int i = 0; i < length - 1; i++)//this for to find index operating * / 
            {
                if (NewChar[i] == '×' || NewChar[i] == '÷')
                {
                    if (NewChar[i] == '×')
                    {
                        NewNum[i] = NewNum[i] * NewNum[i + 1];
                        sheft(NewNum, i + 1);
                        sheft(NewChar, i);

                    }
                    else
                    {
                        NewNum[i] = NewNum[i] / NewNum[i + 1];
                        sheft(NewNum, i + 1);
                        sheft(NewChar, i);

                    }
                    //New_Area(ref NewNum);
                    length--;
                    i--;

                }

            }
        }

        private static void excutePlusAndMinus(char[] NewChar, double[] NewNum, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                if (NewChar[0] == '+')
                {
                    NewNum[0] = NewNum[0] + NewNum[1];

                }
                else
                {
                    NewNum[0] = NewNum[0] - NewNum[1];
                }
                sheft(NewNum, 1);
                sheft(NewChar, 0);

            }

        }

        private static void sheft(double[] area, int StartIndex)
        {
            for (int i = StartIndex; i < area.Length - 1; i++)
            {

                area[i] = area[i + 1];
            }

        }
        private static void sheft(char[] area, int StartIndex)
        {
            for (int i = StartIndex; i < area.Length - 1; i++)
            {

                area[i] = area[i + 1];
            }

        }

        private static double[] getnum(string str)
        {
            str = str.Replace('+', ' ');
            str = str.Replace('×', ' ');
            str = str.Replace('-', ' ');
            str = str.Replace('÷', ' ');
            string[] str2 = str.Split();
            double[] Result = new double[str2.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                Result[i] = double.Parse(str2[i]);
            }
            return Result;
        }
        private static char[] getchar(string str)
        {
            int c = 0;
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '×' || str[i] == '÷')
                {

                    c++;
                    s += str[i];
                }
            }
            char[] Result = new char[c];
            for (int i = 0; i < Result.Length; i++)
            {
                Result[i] = s[i];
            }
            return Result;

        }
        private static void Correction_Add_Number(char key, ref string str, ref string tempstr)
        {
            if (tempstr == "+" || tempstr == "-" || tempstr == "×" || tempstr == "÷")
            {
                str += tempstr;
                tempstr = "" + key;


            }

            else if (str == "")
                tempstr += key;
            else if (str != "" && !(str[str.Length - 1] >= '0' && str[str.Length - 1] <= '9'))//for to cheked 
                tempstr += key;
        }
        private static void Correction_Add_dot(char key, ref string str, ref string tempstr)
        {
            if ((tempstr != "+" && tempstr != "-" && tempstr != "×" && tempstr != "÷") && tempstr != "" && !tempstr.Contains('.'))
            {

                tempstr += key;
            }

            else if ((tempstr == "+" || tempstr == "-" || tempstr == "×" || tempstr == "÷") || (str == "" && tempstr == ""))
            {
                str += tempstr;
                tempstr = "0.";
            }

        }
        private static void Correction_Add_Mathematical_Calculations(char key, ref string str, ref string tempstr)
        {
            if (tempstr == "+" || tempstr == "-" || tempstr == "×" || tempstr == "÷")
            {

                if (key == '/')
                {

                    tempstr = "" + '÷';
                }
                else if (key == '*')
                {

                    tempstr = "" + '×';
                }
                else
                {

                    tempstr = "" + key;
                }




            }
            else if ((tempstr != "" && (key == '*' || key == '/')) || (str != "" && str[str.Length - 1] >= '0' && str[str.Length - 1] <= '9' && tempstr == "" && (key == '*' || key == '/')))
            {
                if (key == '/')
                {
                    str += tempstr;
                    tempstr = "" + '÷';
                }
                else if (key == '*')
                {
                    str += tempstr;
                    tempstr = "" + '×';
                }

            }
            else if (tempstr != "" || (str != "" && str[str.Length - 1] >= '0' && str[str.Length - 1] <= '9' && tempstr == ""))
            {
                str += tempstr;
                tempstr = "" + key;
            }

        }

        private static void Correction_Add_Equal(char key, ref string str, ref string tempstr)
        {

            if (str != "" && tempstr != "")
            {
                if (tempstr != "+" && tempstr != "-" && tempstr != "×" && tempstr != "÷")
                    str += tempstr;
                tempstr = Calculator.Result(str).ToString();
                str = "";
            }

        }
        public static void Correction_Add(char key, ref string str, ref string tempstr)
        {

            if (key >= '0' && key <= '9' && tempstr.Length < 12)
            {
                Correction_Add_Number(key, ref str, ref tempstr);

            }
            else if (key == '.' && tempstr.Length < 12)
            {
                Correction_Add_dot(key, ref str, ref tempstr);
            }
            else if ((key == '+' || key == '-' || key == '/' || key == '*' || key == '(' || key == ')'))
            {
                Correction_Add_Mathematical_Calculations(key, ref str, ref tempstr);
            }
            else if (key == '=' || key == 13)
            {
                Correction_Add_Equal(key, ref str, ref tempstr);
            }
            else if (key == 8 && tempstr.Length > 0)
            {
                tempstr = tempstr.Substring(0, tempstr.Length - 1);

            }
            else if (key == 'c')
            {
                str = tempstr = "";
            }

        }


    }

}
