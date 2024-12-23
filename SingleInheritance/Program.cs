using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        BirthRegistration br = new BirthRegistration("Sam", "Tim", DateTime.ParseExact("12/12/2004", "dd/MM/yyyy", null), DateTime.ParseExact("28/12/2004", "dd/MM/yyyy", null), "male");
        System.Console.WriteLine(br.DisplayBirthDetails());
        AadharRegistration ar = new AadharRegistration(123, "Tony", "Liam", DateTime.ParseExact("05/12/2004", "dd/MM/yyyy", null), DateTime.ParseExact("25/12/2004", "dd/MM/yyyy", null), "male", "12th street");
        System.Console.WriteLine(ar.DisplayAadharDetails());

    }
}