using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HomeWorks
{
    internal class DelegatePractice
    {
        //public delegate bool CheckNums(int a);

        //public delegate void ChangeStr(string str);

        //public delegate int CalculateLength(string str,int num);

       // public delegate bool CheckNum(int num1, int num2, int num3);
        //public bool CheckOddNums(int num)
        //{
        //    return num%2 != 0;
        //}


        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}


        //public bool SumOfGreaterSevenNums(int num)
        //{
        //    return num>7;
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}
        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public bool CheckNums(int num1, int num2, int num3)
        //{
        //    return num1>5&&num2>5&&num3>5;
        //}
        //public int GetLength(string str, int num)
        //{
        //    return str.Length+num;
        //}

        public void Execute()
        {
             List<int> list = new List<int> { 1,2,3,4,5,8,8};
            //list.Where(m => m > 100);//=> lamda expression
            //SumOfNumsByCondition(list, m=>m%2!=0);//arrow function
            //SumOfNumsByCondition(list, m => m % 2 == 0);
            //SumOfNumsByCondition(list, m => m > 7);
            //ShowText("Salam",StrToUpper);
            //ShowText("Salam", StrToLower);

            //Action<string> del1 =new Action<string> (StrToUpper);
            //Action<string> del2 = new Action<string>(StrToUpper);

            //del1("sagol");
            //del2("Sagol");
            
            //GetLengthOfStr("salam",10,GetLength);
            
            //Func<string, int, int> func = GetLength;
            //var t=func("Salam", 10);
            //Console.WriteLine(t);
            
            //SumOfNumsByCondition(10, 10, 10, CheckNums);
            //Predicate<int> test = CheckEvenNums;
            //Console.WriteLine(test(10));

        }

        //public void ShowText(string str, Action<string> func)
        //{
        //    func(str);
        //}

        //public void SumOfNumsByCondition(List<int> nums, Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach (int item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //public void GetLengthOfStr(string str, int num, Func<string, int, int> func)
        //{
        //    int count = func(str, 10);
        //    Console.WriteLine(count);
        //}

        //public void SumOfNumsByCondition(int num1,int num2,int num3,Func<int, int, int, bool> expression)
        //{
        //    if (expression(num1,num2,num3))
        //    {
        //        Console.WriteLine(num1+num2+num3);
        //    }

        //}

    }
}
