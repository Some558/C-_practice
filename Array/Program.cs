using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(25);
            numbers.Add(37);
            numbers.Add(42);
            numbers.Add(55);
            numbers.Add(68);
            numbers.Add(79);
            numbers.Add(81);
            numbers.Add(96);
            numbers.Add(100);

            int totalNumber = 0;
            double oddNumber = 0;
            int count = 0;

            foreach(int number in numbers)
            {
                if(number % 2 == 0)
                {
                    totalNumber += number;
                }
                else
                {
                    oddNumber += number;
                    count ++;
                }
            }
            Console.WriteLine($"偶数の合計:{totalNumber}");
            Console.WriteLine($"奇数の平均{oddNumber / count}");
        }
    }
}