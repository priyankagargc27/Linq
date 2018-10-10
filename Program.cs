using System;
using System.Linq;
using System.Collections.Generic;


namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'

List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

 IEnumerable<string> LFruits = from fruit in fruits
  where fruit.StartsWith("L")
    orderby fruit ascending
    select fruit;

            foreach (string fruit in LFruits)
            {
                Console.WriteLine($"{fruit}");
            
            }

// Which of the following numbers are multiples of 4 or 6
List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

IEnumerable<int> fourSixMultiples = numbers.Where(n => n%4==0 || n%6==0).OrderBy(n => n);
foreach(int num in fourSixMultiples)
{
    Console.WriteLine($"multiple of 4 or 6 is {num}");
}

// Order these student names alphabetically, in descending order (Z to A)
List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

var des= 
from n in names 
orderby n  descending
select n;  
Console.WriteLine("Student Names by desecnding order") ;
foreach(string n in des)
{
    Console.WriteLine(n);
}   

// Build a collection of these numbers sorted in ascending order
// Output how many numbers are in this list
List<int> Numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
var asc=
from num in Numbers
orderby num ascending
select num;
Console.WriteLine("Numbers in ascending order are");
foreach(int num in asc)
{
    Console.WriteLine(num);
}
int CountNumber = Numbers.Count(); 
  
    Console.WriteLine($"There are {CountNumber} number"); 
// How much money have we made?
List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};

double SumNumber = purchases.Sum(); 
  
    Console.WriteLine($"Total Money is {SumNumber}"); 
    // What is our most expensive product?
List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};
Console.WriteLine($"most expensive product is {prices.Max()}");

/*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};  
 List<int> newList = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0).ToList();
            foreach (int num in newList)
            {
                Console.WriteLine(num);
            }
    }
}
}


