using System;
using System.Linq;
using System.Collections.Generic;


namespace linq
{
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
// Define a bank
    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }
     public class ReportItem
            {
                public string CustomerName { get; set; }
                public string BankName { get; set; }
            }
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
 Console.WriteLine("=======================================================================");
Console.WriteLine("=======================================================================");
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
 Console.WriteLine("=======================================================================");
Console.WriteLine("=======================================================================");
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
 Console.WriteLine("=======================================================================");
 Console.WriteLine("=======================================================================");
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
   Console.WriteLine("=======================================================================");
Console.WriteLine("Numbers in ascending order are");
foreach(int num in asc)
{
    Console.WriteLine(num);
}
int CountNumber = Numbers.Count(); 
    Console.WriteLine($"There are {CountNumber} number"); 
            Console.WriteLine("=======================================================================");
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
}; Console.WriteLine("=======================================================================");
Console.WriteLine($"most expensive product is {prices.Max()}");
 Console.WriteLine("=======================================================================");

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
  Console.WriteLine("=======================================================================");
            Console.WriteLine("List of New Numbers");
            Console.WriteLine("=======================================================================");
            foreach (int num in newList)
            {
                Console.WriteLine(num);
            }
        
        
    
    // Build a collection of customers who are millionaires

 
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };


         
/*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/

        IEnumerable<Customer> millionare = from million in customers
                                               where million.Balance >= 1000000
                                               select million;

            Console.WriteLine("=======================================================================");
            Console.WriteLine("List of millionare customers");
            Console.WriteLine("=======================================================================");
            
            foreach (Customer million in millionare)
            {
                Console.WriteLine("Name: " + $"{million.Name}" + ", Balance: " + $"{million.Balance}" + ", Bank: " + $"{million.Bank}");
            }

var millionBank = millionare.GroupBy(millionGroup => millionGroup.Bank);

            Console.WriteLine("=================================================================");

            foreach (var millionb in millionBank)
            {
                Console.WriteLine($"{millionb.Key}" + "  " + $"{millionb.Count()}");
            }
       
// Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

        /*
            You will need to use the `Where()`
            and `Select()` methods to generate
            instances of the following class.

            public class ReportItem
            {
                public string CustomerName { get; set; }
                public string BankName { get; set; }
            }
        */

            var millionaireReport = from cus in customers
                                    join bankM in banks on cus.Bank equals bankM.Symbol
                                    select new { CustomerName = cus.Name, BankName = bankM.Name };



            Console.WriteLine("=========================================================================");
            Console.WriteLine("Joining Two related collections");
            Console.WriteLine("=========================================================================");
            foreach (var customer in millionaireReport)
            {
                Console.WriteLine($"{customer.CustomerName} have bank account at {customer.BankName}");
            }

        }
    }
}

    


    
    
    


