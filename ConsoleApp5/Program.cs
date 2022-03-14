using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 1, 2, 3};
            string[] name = { "Jack", "Mary", "Tom" };
            int[] com = { 80, 65, 100 };
            int[] pro = { 75, 67, 93 };
            int[] des = { 60, 62, 91 };

            while (true)
            {
                Console.WriteLine("請輸入1-3");
                var inputno = Console.ReadLine();
                int input = int.Parse(inputno);
                int arrayindex = Array.IndexOf(no, input);
                if (arrayindex > -1)
                {
                    Console.WriteLine("姓名" + name[arrayindex]);
                    Console.WriteLine("電腦概論" + com[arrayindex]);
                    Console.WriteLine("程式設計" + pro[arrayindex]);
                    Console.WriteLine("動畫設計" + des[arrayindex]);
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }
            }
        }
    }
}
