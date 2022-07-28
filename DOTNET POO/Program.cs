using System.ComponentModel.Design;
using System;
using DOTNET_POO.src.Entities;


namespace DOTNET_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Hero wizard = new Hero("Jennica", 23, "Wizard");



            System.Console.WriteLine(arus.Attack());
            System.Console.WriteLine(wizard.Attack());
        }
    }
}
