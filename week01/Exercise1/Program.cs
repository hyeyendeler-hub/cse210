using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your home country?");
        string homeCountry = Console.ReadLine();

        Console.WriteLine("You are from {0}", homeCountry);
        string capitalCity = homeCountry.ToUpper(); 
         
        Console.WriteLine("In which district do you come from?");
        string district = Console.ReadLine();   

        Console.WriteLine("You are from {0}", district);
        string capitalLetters = district.ToUpper();

        Console.WriteLine("The capital of {0} is {1}", homeCountry, capitalCity);
        Console.WriteLine("The district you come from is {0}", capitalLetters);
    }
}