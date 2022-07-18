using System;
using System.Collections.Generic;

namespace Findall
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> nums = new MyList<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
        


            nums.Clear();

            nums.Add(1);
            nums.Add(2);

            nums.GetAll();
            var result = nums.Find(m => m = 2);

            Console.WriteLine(result);

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            list.FindAll(2);


            nums.AddRange(list);
            nums.GetAll();

        }
    }

    public class Book
    {
        public string Name { get; set; }
    }




}
