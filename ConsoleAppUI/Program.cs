using DemoLibrary;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "John";
            owner.LastName = "Doe";
            owner.EmailAddress = "JohnDoe@hotmail.com";
            owner.PhoneNumber = "1234567";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Mow the lawn";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
